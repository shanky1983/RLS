IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='BarcodeNo' AND object_id= OBJECT_ID('HCTestInBound'))
BEGIN
	ALTER TABLE HCTestInBound ADD [BarcodeNo] nvarchar(150) NULL
END
Go
				
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='EmployeeID' AND object_id= OBJECT_ID('HCBookingInBound'))
BEGIN
	ALTER TABLE HCBookingInBound ADD [EmployeeID] nvarchar(75) NULL
END
Go

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='EmployeeID' AND object_id= OBJECT_ID('HCBookingInBound_Hist'))
BEGIN
	ALTER TABLE HCBookingInBound_Hist ADD [EmployeeID] nvarchar(75) NULL
END
Go

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='CollectionStatus' AND object_id= OBJECT_ID('HCTestSampleInBound'))
BEGIN
   ALTER TABLE HCTestSampleInBound ADD [CollectionStatus] [nvarchar](75) NULL
END
Go
	
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='Reason' AND object_id= OBJECT_ID('HCBookingInBound'))
BEGIN
   ALTER TABLE HCBookingInBound ADD [Reason] [nvarchar](150) NULL
END
Go

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='Reason' AND object_id= OBJECT_ID('HCBookingInBound_HIST'))
BEGIN
   ALTER TABLE HCBookingInBound_HIST ADD [Reason] [nvarchar](150) NULL
END
Go

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='CollectionTime' AND object_id= OBJECT_ID('HCBookingInBound'))
BEGIN
   ALTER TABLE HCBookingInBound ADD [CollectionTime] datetime NULL
END
Go

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='CollectionTime' AND object_id= OBJECT_ID('HCBookingInBound_HIST'))
BEGIN
   ALTER TABLE HCBookingInBound_HIST ADD [CollectionTime] datetime NULL
END
Go
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='Location' AND object_id= OBJECT_ID('HCBookingInBound'))
BEGIN
ALTER TABLE HCBookingInBound ADD Location NVARCHAR(1000)
END
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='ERPPatientNumber' AND object_id= OBJECT_ID('HCBookingInBound'))
BEGIN
ALTER TABLE HCBookingInBound ADD ERPPatientNumber NVARCHAR(300)
END
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='Location' AND object_id= OBJECT_ID('HCBookingInBound_HIST'))
BEGIN
ALTER TABLE HCBookingInBound_HIST ADD Location NVARCHAR(1000)
END
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='ERPPatientNumber' AND object_id= OBJECT_ID('HCBookingInBound_HIST'))
BEGIN
ALTER TABLE HCBookingInBound_HIST ADD ERPPatientNumber NVARCHAR(300)
END
GO