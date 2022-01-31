




--INSERT INTO ReferingPhysician

SELECT 
Name,
NULL Qualification,
NULL OrganizationName,
86 OrgID,
NULL Status,
14 Salutation,
NULL LoginID,
Code,
NULL IsClient,
'Y'IsActive,
NULL CreatedBy,
GETDATE() CreatedAt,
NULL ModifiedBy,
NULL ModifiedAt,
NULL Gender,
NULL DOB,
NULL Age,
'P' RegistrationType,
0 ParentReferingPhysicianID,
NULL IsMerged,
NULL DiscountLimit,
NULL DiscountPeriod,
NULL DiscountValidFrom,
NULL DiscountValidTo
 FROM LIMS_QA..EXCEL_DR_09
 


-----//**INSERT INTO ADDRESS DETAILS**//-----------

INSERT INTO ADDRESSDETAILS
SELECT 
1,
5744,
'Client',
Address,
City,
75,
35,
EmailID,
Phone,
Mobile,
Fax,
109,
IsCommunication,
332,
getdate(),
NULL,
NULL,
NULL,
NULL,
NULL,
NULL,
NULL,
NULL,
NULL 
FROM HEALTH_CLIENT_28 WHERE State='WB'
