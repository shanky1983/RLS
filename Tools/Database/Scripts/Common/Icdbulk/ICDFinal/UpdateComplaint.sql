UPDATE CMP
SET CMP.ICDDescription=I.ICDDescription
FROM Complaint CMP
JOIN ICDCodes I
ON CMP.ICDCode=I.ICDCode
