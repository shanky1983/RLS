/*===============   /* Action RoleMapping Table Script */  ======================= */
/*  CREATED BY:  GURUNATH S
     DATE         :  12-Dec-2012	
     Description : In the ActionRoleMapping, there is no primary column. Created a new primary column as "ID", and update running number 
                       for existing records. Before run the script, run the "Alter Script". 
*/ 

	WITH ActionRoleMapping_1
		AS
		(
		SELECT *, ROW_NUMBER() OVER(ORDER BY ActionID) AS RNK
					FROM ActionRoleMapping
		)
			UPDATE ActionRoleMapping_1
					SET ID = RNK
		GO