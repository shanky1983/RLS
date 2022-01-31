
/****** Object:  StoredProcedure [dbo].[pGetLabPatientDetailandAddress]    Script Date: 04/22/2009 11:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetLabPatientDetailandAddress]  
(  
@pUserID bigint    
)  
AS  
DECLARE @ret bigint  
 BEGIN  
 SET @ret = -1  
   
 SELECT P.Name,P.Age As PatientAge,--P.AgeUnit,
 P.SEX,P.TITLECode,  
 P.OrgID,S.TitleName,URNO,EMail,
URNofId,
URNTypeId 
 FROM Patient P  
 INNER JOIN Salutation S  
 ON S.TitleID = P.TITLECode  
 WHERE P.PatientID = @pUserID   
    
 SELECT PA.*  
 FROM PatientAddress PA  
 WHERE PA.PatientID = @pUserID  
    
 SET @ret = 0     
 RETURN @ret  
 END  