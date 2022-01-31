DECLARE @OrgID INT = 112

IF EXISTS(
SELECT *
FROM tempdb.dbo.sysobjects o
WHERE o.xtype IN ('U')
	AND o.id = object_id(N'tempdb..#tbleConfigkeys')
)
BEGIN
	DROP TABLE #tbleConfigkeys;
END

CREATE TABLE #tbleConfigkeys (configkey NVARCHAR(100), DisplayText NVARCHAR(100), isIntenal NVARCHAR(100), ControlType NVARCHAR(100), ConfigType NVARCHAR(100), isAddressBased NVARCHAR(100), ID INT identity(1, 1))

INSERT INTO #tbleConfigkeys (configkey, DisplayText, isIntenal, ControlType, ConfigType, isAddressBased)
SELECT 'Required_CategoryBased_AttributesMapping', 'Is Required Category Based Attributes Mapping?', 'N', 'CHB', 'PRM', 'N'

UNION

SELECT 'Attributes_Basedby_Category', 'Attributes Basedby Category?', 'N', 'CHB', 'PRM', 'N'

UNION

SELECT 'Required_Quotation_Approval', 'Is Approval step required for Quotation?', 'N', 'CHB', 'PRM', 'N'

DECLARE @RowCount INT = (
		SELECT count(1)
		FROM #tbleConfigkeys
		)
DECLARE @CurrentRow INT = 0

 

WHILE (
		
		 @CurrentRow <= @RowCount
		)
BEGIN

	INSERT INTO ConfigKeyMaster (ConfigKeyID, configkey, DisplayText, IsInternal, ControlType, ConfigType, isAddressBased)
	SELECT (
			SELECT MAX(ISNULL(ConfigKeyID, 0)) + 1
			FROM ConfigKeyMaster
			), A.configkey, A.DisplayText, A.isIntenal, A.ControlType, A.ConfigType, A.isAddressBased
	FROM #tbleConfigkeys A
	LEFT JOIN ConfigKeyMaster B ON B.ConfigKey = A.configkey
	WHERE ID = @CurrentRow
		AND B.ConfigKey IS NULL

	DECLARE @cONFIGKEID INT

	SELECT @cONFIGKEID = b.ConfigKeyID
	FROM #tbleConfigkeys A
	INNER JOIN ConfigKeyMaster B ON B.ConfigKey = A.configkey
	WHERE A.ID = @CurrentRow





	IF   @cONFIGKEID IS NOT NULL AND NOT EXISTS (
			(SELECT CONFIGKEYID
			FROM ConfigOrgMaster
			WHERE ConfigKeyID = @cONFIGKEID ) 
			)
	BEGIN
	
		INSERT INTO ConfigOrgMaster (ConfigKeyID, OrgID, CreatedAt)
		SELECT @cONFIGKEID, @OrgID, getdate()
	END

	IF NOT EXISTS (
			SELECT CONFIGKEYID
			FROM inventoryconfig
			WHERE ConfigKeyID = @cONFIGKEID
			)
	BEGIN
		INSERT INTO inventoryconfig (ConfigKey, ConfigValue, OrgID, OrgAddressId, ConfigKeyID, CreatedAt)
		SELECT A.configkey, 'Y', @OrgID, 0, @cONFIGKEID, GETDATE()
		FROM #tbleConfigkeys A
		INNER JOIN ConfigKeyMaster B ON B.ConfigKey = A.configkey
		WHERE ID = @CurrentRow
	END

	SET @CurrentRow = @CurrentRow + 1
END
