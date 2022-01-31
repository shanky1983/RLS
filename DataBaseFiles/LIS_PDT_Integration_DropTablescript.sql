IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInBound]') AND type in (N'U'))
    DROP TABLE [dbo].[PatientInBound]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInBound_hist]') AND type in (N'U'))
    DROP TABLE [dbo].[PatientInBound_hist]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInBound_hist]') AND type in (N'U'))
    DROP TABLE [dbo].[PatientInBound_hist]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking]') AND type in (N'U'))
    DROP TABLE [dbo].[Booking]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HCPaymentDetailsInBound]') AND type in (N'U'))
    DROP TABLE [dbo].[HCPaymentDetailsInBound]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HCTestInBound]') AND type in (N'U'))
    DROP TABLE [dbo].[HCTestInBound]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HCLiveLocation]') AND type in (N'U'))
    DROP TABLE [dbo].[HCLiveLocation]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HCBookingInBound]') AND type in (N'U'))
    DROP TABLE [dbo].[HCBookingInBound]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HCBookingInBound_HIST]') AND type in (N'U'))
    DROP TABLE [dbo].[HCBookingInBound_HIST]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DashboardOrderDetail]') AND type in (N'U'))
    DROP TABLE [dbo].[DashboardOrderDetail]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DashboardPatientDetail]') AND type in (N'U'))
    DROP TABLE [dbo].[DashboardPatientDetail]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductIntegaration_LIMS]') AND type in (N'U'))
    DROP TABLE [dbo].[ProductIntegaration_LIMS]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductConsumptionMapping_LIMS]') AND type in (N'U'))
    DROP TABLE [dbo].[ProductConsumptionMapping_LIMS]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutMappingDetails_LIMS]') AND type in (N'U'))
    DROP TABLE [dbo].[StockOutMappingDetails_LIMS]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutMappingDetails_LIMS]') AND type in (N'U'))
    DROP TABLE [dbo].[StockOutMappingDetails_LIMS]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HCTestSampleInBound]') AND type in (N'U'))
    DROP TABLE [dbo].[HCTestSampleInBound]
GO