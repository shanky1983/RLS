/****** Object:  Table [dbo].[PatientInBound]    Script Date: 9/30/2020 12:25:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PatientInBound](
	[PatientID] [bigint] NOT NULL,
	[FirstName] [nvarchar](150) NULL,
	[MiddleName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Gender] [nchar](3) NULL,
	[DateofBirth] [datetime] NULL,
	[Age] [nvarchar](50) NULL,
	[Salutation ] [nvarchar](8) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[EMail] [nvarchar](50) NULL,
	[Address] [nvarchar](150) NULL,
	[City] [nvarchar](125) NULL,
	[State] [nvarchar](125) NULL,
	[Country] [nvarchar](125) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[URNType] [nvarchar](125) NULL,
	[URNNo] [nvarchar](50) NULL,
	[DateOfRegistration] [datetime] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[Source] [nvarchar](125) NULL,
	[Status] [nvarchar](125) NULL,
	[ClientID] [nvarchar](125) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsProcessed ] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[Name] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[PatientInBound_hist]    Script Date: 9/30/2020 12:27:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PatientInBound_hist](
	[PatientID] [bigint] NULL,
	[FirstName] [nvarchar](150) NULL,
	[MiddleName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Gender] [nchar](3) NULL,
	[DateofBirth] [datetime] NULL,
	[Age] [nvarchar](50) NULL,
	[Salutation ] [nvarchar](8) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[EMail] [nvarchar](50) NULL,
	[Address] [nvarchar](150) NULL,
	[City] [nvarchar](125) NULL,
	[State] [nvarchar](125) NULL,
	[Country] [nvarchar](125) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[URNType] [nvarchar](125) NULL,
	[URNNo] [nvarchar](50) NULL,
	[DateOfRegistration] [datetime] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[Source] [nvarchar](125) NULL,
	[Status] [nvarchar](125) NULL,
	[ClientID] [nvarchar](125) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsProcessed ] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[Name] [nvarchar](250) NULL
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[Booking]    Script Date: 9/30/2020 12:28:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Booking](
	[BookingID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](150) NULL,
	[MiddleName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Salutation] [nchar](4) NULL,
	[Age] [nvarchar](50) NULL,
	[Gender] [nchar](3) NULL,
	[DateofBirth] [datetime] NULL,
	[Address] [nvarchar](250) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[Email] [nvarchar](50) NULL,
	[City] [nvarchar](150) NULL,
	[State] [nvarchar](150) NULL,
	[Country] [nvarchar](150) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[ClientCode] [nvarchar](25) NULL,
	[URNType] [nvarchar](125) NULL,
	[URNNo] [nvarchar](50) NULL,
	[TRFFile] [nvarchar](150) NULL,
	[DispatchType] [nvarchar](50) NULL,
	[BookingDTTM] [datetime] NULL,
	[SampleID] [nvarchar](50) NULL,
	[SampleName] [nvarchar](125) NULL,
	[ContainerID] [nvarchar](50) NULL,
	[ContainerName] [nvarchar](125) NULL,
	[SampleContainerColour] [nvarchar](125) NULL,
	[SampleCollectionTime] [datetime] NULL,
	[SampleStatus] [nvarchar](50) NULL,
	[Reason] [nvarchar](250) NULL,
	[FollowUpTest] [nvarchar](125) NULL,
	[FollowUpDTTM] [datetime] NULL,
	[TestCode] [nvarchar](100) NULL,
	[TestName] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[ReceivedAmount] [decimal](18, 2) NULL,
	[DueAmount] [decimal](18, 2) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PaymentMode] [nvarchar](25) NULL,
	[CardDetails] [nvarchar](150) NULL,
	[ReferenceNo] [nvarchar](25) NULL,
	[InventoryCount] [bigint] NOT NULL,
	[InventoryDetails] [nvarchar](100) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[UserID] [nvarchar](50) NULL,
	[Status] [nvarchar](250) NULL,
	[ClientID] [nvarchar](250) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[TripStatus] [nvarchar](250) NULL,
	[TripReason] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[HCPaymentDetailsInBound]    Script Date: 9/30/2020 12:29:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HCPaymentDetailsInBound](
	[HCPaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[FinalBillID] [bigint] NULL,
	[BookingID] [bigint] NULL,
	[OrgID] [int] NOT NULL,
	[PaymentMode] [nvarchar](50) NULL,
	[AmtReceived] [decimal](18, 2) NOT NULL,
	[ReceivedBy] [bigint] NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[CardHolderName] [nvarchar](255) NULL,
	[TransactionID] [nvarchar](1020) NULL,
	[ClosureStatus] [nvarchar](10) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[OtherCurrencyAmount] [decimal](18, 2) NULL,
	[RoleID] [int] NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[Units] [int] NULL,
	[CashGiven] [decimal](18, 2) NULL,
	[BalanceGiven] [decimal](18, 2) NULL,
	[RoundOffAmount] [decimal](18, 2) NULL,
	[ChequeValidDate] [datetime] NULL,
	[AuthorisationCode] [nvarchar](1020) NULL,
	[Remarks] [nvarchar](150) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[ErrorRemarks] [nvarchar](1) NULL
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[HCTestInBound]    Script Date: 9/30/2020 12:30:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HCTestInBound](
	[HCAddTestID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderedFrom] [nvarchar](50) NULL,
	[BookingID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[Type] [nvarchar](10) NULL,
	[TestCode] [nvarchar](50) NULL,
	[SampleID] [bigint] NULL,
	[SampleName] [nvarchar](150) NULL,
	[ContainerID] [bigint] NULL,
	[ContainerName] [nvarchar](150) NULL,
	[SampleContainerColour] [nvarchar](150) NULL,
	[CollectionStatus] [nvarchar](50) NULL,
	[SampleCollectedTime] [datetime] NULL,
	[Reason] [nvarchar](150) NULL,
	[AmtReceived] [decimal](18, 2) NULL,
	[ReceivedBy] [bigint] NULL,
	[IsAdded] [nvarchar](5) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[IsProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[BarcodeNo] nvarchar(150) NULL
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[HCLiveLocation]    Script Date: 9/30/2020 12:31:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HCLiveLocation](
	[HCLiveID] [bigint] IDENTITY(1,1) NOT NULL,
	[LoginID] [bigint] NULL,
	[TransactionDate] [datetime] NULL,
	[Latitude] [float] NOT NULL,
	[Longitude] [float] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[HCBookingInBound]    Script Date: 9/30/2020 12:33:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HCBookingInBound](
	[HCID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingID] [bigint] NULL,
	[BookingDTTM] [datetime] NULL,
	[TRFFile] [nvarchar](150) NULL,
	[DispatchType] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Salutation] [nvarchar](50) NULL,
	[FirstName] [nvarchar](150) NULL,
	[MiddleName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Age] [nvarchar](50) NULL,
	[DateofBirth] [datetime] NULL,
	[Gender] [nchar](4) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[Email] [nvarchar](50) NULL,
	[LISPatientID] [bigint] NULL,
	[ExternalPatientNo] [nvarchar](50) NULL,
	[FullName] [nvarchar](250) NULL,
	[AddressType] [nvarchar](5) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nvarchar](75) NULL,
	[State] [nvarchar](75) NULL,
	[Country] [nvarchar](75) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[URNType] [nvarchar](50) NULL,
	[URNNo] [nvarchar](30) NULL,
	[OrderedFrom] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[LoginID] [bigint] NULL,
	[SourceType] [nvarchar](100) NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[DiscountID] [bigint] NULL,
	[ClientID] [nvarchar](100) NULL,
	[ClientCode] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[JsonValue] [nvarchar](max) NULL,
	[JsonString] [nvarchar](max) NULL,
	[UserID] [nvarchar](50) NULL,
	[TripStatus] [nvarchar](100) NULL,
	[TripReason] [nvarchar](250) NULL,
	[HealthHubID] [nvarchar](50) NULL,
	[EmployeeID] nvarchar(75) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/****** Object:  Table [dbo].[HCBookingInBound_HIST]    Script Date: 9/30/2020 12:34:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HCBookingInBound_HIST](
	[HCID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingID] [bigint] NULL,
	[BookingDTTM] [datetime] NULL,
	[TRFFile] [nvarchar](150) NULL,
	[DispatchType] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Salutation] [nvarchar](50) NULL,
	[FirstName] [nvarchar](150) NULL,
	[MiddleName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Age] [nvarchar](50) NULL,
	[DateofBirth] [datetime] NULL,
	[Gender] [nchar](4) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[Email] [nvarchar](50) NULL,
	[LISPatientID] [bigint] NULL,
	[ExternalPatientNo] [nvarchar](50) NULL,
	[FullName] [nvarchar](250) NULL,
	[AddressType] [nvarchar](5) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nvarchar](75) NULL,
	[State] [nvarchar](75) NULL,
	[Country] [nvarchar](75) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[URNType] [nvarchar](50) NULL,
	[URNNo] [nvarchar](30) NULL,
	[OrderedFrom] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[LoginID] [bigint] NULL,
	[SourceType] [nvarchar](100) NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[DiscountID] [bigint] NULL,
	[ClientID] [nvarchar](100) NULL,
	[ClientCode] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[JsonValue] [nvarchar](max) NULL,
	[JsonString] [nvarchar](max) NULL,
	[UserID] [nvarchar](50) NULL,
	[TripStatus] [nvarchar](100) NULL,
	[TripReason] [nvarchar](250) NULL,
	[HealthHubID] [nvarchar](50) NULL,
	[EmployeeID] nvarchar(75) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/****** Object:  Table [dbo].[DashboardOrderDetail]    Script Date: 9/30/2020 2:12:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DashboardOrderDetail](
	[OrderDetailId] [bigint] IDENTITY(1,1) NOT NULL,
	[PatientId] [bigint] NOT NULL,
	[PatientNumber] [nvarchar](100) NULL,
	[VisitNumber] [nvarchar](255) NULL,
	[PatientVisitId] [bigint] NULL,
	[OrgId] [bigint] NULL,
	[TestId] [bigint] NULL,
	[TestName] [nvarchar](255) NULL,
	[Type] [nvarchar](10) NULL,
	[DeptId] [bigint] NULL,
	[DepartName] [nvarchar](255) NULL,
	[AccessionNumber] [bigint] NULL,
	[OrderedDate] [datetime] NULL,
	[ReferingPhysicianId] [bigint] NULL,
	[ReferingPhysicianName] [nvarchar](255) NULL,
	[ClientID] [bigint] NULL,
	[ClientName] [nvarchar](255) NULL,
	[ClientType] [nvarchar](50) NULL,
	[CollectedDate] [datetime] NULL,
	[PendingDate] [datetime] NULL,
	[CompleteDate] [datetime] NULL,
	[ValidateDate] [datetime] NULL,
	[ApproveDate] [datetime] NULL,
	[ReTestGivenDate] [datetime] NULL,
	[ReCheckGivenDate] [datetime] NULL,
	[CurrentStatus] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[PkgID] [bigint] NULL,
	[PkgName] [nvarchar](2000) NULL,
	[LocationId] [bigint] NULL,
	[LocationName] [nvarchar](200) NULL,
	[Amount] [decimal](10, 2) NULL,
	[OrgName] [nvarchar](1000) NULL,
	[Salutation] [nvarchar](50) NULL
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[DashboardPatientDetail]    Script Date: 9/30/2020 2:15:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DashboardPatientDetail](
	[PatientDetailId] [bigint] IDENTITY(1,1) NOT NULL,
	[ORGID] [bigint] NULL,
	[LocationId] [bigint] NULL,
	[OrgName] [nvarchar](200) NULL,
	[LocationName] [nvarchar](200) NULL,
	[PatientId] [bigint] NOT NULL,
	[PatientNumber] [nvarchar](100) NULL,
	[SEX] [nvarchar](10) NULL,
	[RegistrationDTTM] [datetime] NULL,
	[DOB] [datetime] NULL,
	[Age] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[IsPorted] [nvarchar](1) NULL,
	[OrgCode] [nvarchar](100) NULL,
	[InstanceId] [tinyint] NULL,
	[Salutation] [nvarchar](30) NULL
) ON [PRIMARY]
GO

CREATE TABLE ProductIntegaration_LIMS
(
    ProductIntegarationID BIGINT IDENTITY(1,1), 
	ProductID BIGINT,
	OrgID INT,	
    ProductJsonText TEXT,
	[Status] NVARCHAR(100),	
	CreatedBy BIGINT,
	CreatedAt DATETIME,	
	ModifiedBy	BIGINT,
	ModifiedAt DATETIME
)
GO


CREATE TABLE ProductConsumptionMapping_LIMS
(
	ProductConsumptionMappingID Bigint Identity(1,1),
	InvestigationProductMapDetailID Bigint,	
	InvestigationProductMapID Bigint,
	ProductID Bigint,
	OrgID int,
	Status Nvarchar(50),
	CreatedBy Bigint,
	CreatedAt Datetime,		
	ModifiedBy Bigint,
	ModifiedAt Datetime
)
GO


CREATE TABLE StockOutMappingDetails_LIMS
(
	StockOutMappingDetailsID Bigint Identity(1,1),
	--StockOutFlowID Bigint,	
	ReceivedUniqueNumber Bigint,
	ProductID Bigint,
	OrgID int,
	LocationID int,
	StockoutFlowDate Datetime,
	Status Nvarchar(50),
	CreatedBy Bigint,
	CreatedAt Datetime,		
	ModifiedBy Bigint,
	ModifiedAt Datetime
)
GO

/****** Object:  Table [dbo].[HCTestSampleInBound]    Script Date: 3/2/2021 8:16:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HCTestSampleInBound](
	[BookingID] [bigint] NULL,
	[SampleCode] [bigint] NULL,
	[SampleName] [nvarchar](150) NULL,
	[ContainerID] [bigint] NULL,
	[ContainerName] [nvarchar](150) NULL,
	[SampleContainerColour] [nvarchar](150) NULL,
	[SampleCollectedTime] [datetime] NULL,
	[BarcodeNo] [nvarchar](150) NULL,
	[Reason] [nvarchar](150) NULL,
	[IsNewSampleYN] [nvarchar](5) NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL
) ON [PRIMARY]
GO