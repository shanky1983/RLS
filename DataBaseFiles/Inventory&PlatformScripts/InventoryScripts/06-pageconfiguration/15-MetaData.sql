
delete from DrugGeneric where GenericID in (
select GenericID from DrugGeneric
group by GenericID having count(1)>1
)



DECLARE @orgid INT

SET @orgid = 112

INSERT INTO MetaData (Domain, Code, DisplayText, LangCode)
SELECT 'All', '0', '----Select All----', 'en-GB'
WHERE NOT EXISTS (
		SELECT 1
		FROM MetaData
		WHERE Domain = 'All'
			AND Code = '0'
		)

DECLARE @metadataid BIGINT = (
		SELECT metadataid
		FROM MetaData
		WHERE Domain = 'All'
			AND Code = '0'
		)





INSERT INTO MetaDataOrgMapping (MetadataID, OrgID, LangCode, DisplayText)
SELECT @metadataid, @orgid, 'en-GB', '----Select All----'
where not exists (
SELECT 1
		FROM MetaData MD
inner join MetaDataOrgMapping MDO on MDO.MetadataID=md.MetaDataID  and OrgID=@orgid 
		WHERE Domain = 'All'
			AND Code = '0')

