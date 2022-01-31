/****** Object:  Table [dbo].[TempStockReceivedDetails]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TempStockReceivedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TempStockReceivedDetails]
GO


/****** Object:  Table [dbo].[DraftIDMaster]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryUOMOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryUOMOrgMapping]
GO


/****** Object:  Table [dbo].[DraftIDMaster]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DraftIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DraftIDMaster]
GO




/****** Object:  Table [dbo].[BackGroundPrintAttributes]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackGroundPrintAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[BackGroundPrintAttributes]
GO



--/****** Object:  Table [dbo].[Theme]    Script Date: 05/08/2015 16:25:47 ******/
--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Theme]') AND type in (N'U'))
--DROP TABLE [dbo].[Theme]
--GO


/****** Object:  Table [dbo].[RoleVideoMapping]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleVideoMapping]') AND type in (N'U'))
DROP TABLE [dbo].[RoleVideoMapping]
GO

/****** Object:  Table [dbo].[ProductCategoriesTypeMapping]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductCategoriesTypeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProductCategoriesTypeMapping]
GO


/****** Object:  Table [dbo].[AdhocIDMaster]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AdhocIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[AdhocIDMaster]
GO


/****** Object:  Table [dbo].[Inv_Config]    Script Date: 05/11/2015 18:36:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inv_Config]') AND type in (N'U'))
BEGIN 
DROP TABLE [dbo].[Inv_Config]
END
GO

/****** Object:  Table [dbo].[Audit_ProductSupplierRateMapping]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Audit_ProductSupplierRateMapping_Rate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] DROP CONSTRAINT [DF_Audit_ProductSupplierRateMapping_Rate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Audit_ProductSupplierRateMapping_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] DROP CONSTRAINT [DF_Audit_ProductSupplierRateMapping_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Audit_ProductSupplierRateMapping_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] DROP CONSTRAINT [DF_Audit_ProductSupplierRateMapping_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Audit_ProductSupplierRateMapping_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] DROP CONSTRAINT [DF_Audit_ProductSupplierRateMapping_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Audit_ProductSupplierRateMapping_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] DROP CONSTRAINT [DF_Audit_ProductSupplierRateMapping_Tax]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Audit_ProductSupplierRateMapping]') AND type in (N'U'))
DROP TABLE [dbo].[Audit_ProductSupplierRateMapping]
GO
/****** Object:  Table [dbo].[CategorieAttributesMapping]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CategorieAttributesMapping]') AND type in (N'U'))
DROP TABLE [dbo].[CategorieAttributesMapping]
GO
/****** Object:  Table [dbo].[CenteralStoreStock]    Script Date: 05/08/2015 16:25:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CenteralStoreStock]') AND type in (N'U'))
DROP TABLE [dbo].[CenteralStoreStock]
GO
/****** Object:  Table [dbo].[ControlOrgMapping]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ControlOrgMapping]
GO
/****** Object:  Table [dbo].[ControlTypeMaster]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ControlTypeMaster]
GO
/****** Object:  Table [dbo].[ControlValueMaster]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlValueMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ControlValueMaster]
GO
/****** Object:  Table [dbo].[DrugBrand]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugBrand]') AND type in (N'U'))
DROP TABLE [dbo].[DrugBrand]
GO
/****** Object:  Table [dbo].[DrugFormulation]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugFormulation]') AND type in (N'U'))
DROP TABLE [dbo].[DrugFormulation]
GO
/****** Object:  Table [dbo].[IndendIDMaster]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IndendIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IndendIDMaster]
GO
/****** Object:  Table [dbo].[Intend]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Intend]') AND type in (N'U'))
DROP TABLE [dbo].[Intend]
GO
/****** Object:  Table [dbo].[Intend_HIST]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Intend_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[Intend_HIST]
GO
/****** Object:  Table [dbo].[IntendDetail]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail] DROP CONSTRAINT [DF_IntendDetail_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail] DROP CONSTRAINT [DF_IntendDetail_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail] DROP CONSTRAINT [DF_IntendDetail_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail] DROP CONSTRAINT [DF_IntendDetail_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_Receivedquantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail] DROP CONSTRAINT [DF_IntendDetail_Receivedquantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendDetail]') AND type in (N'U'))
DROP TABLE [dbo].[IntendDetail]
GO
/****** Object:  Table [dbo].[IntendDetail_HIST]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_HIST_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail_HIST] DROP CONSTRAINT [DF_IntendDetail_HIST_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_HIST_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail_HIST] DROP CONSTRAINT [DF_IntendDetail_HIST_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_HIST_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail_HIST] DROP CONSTRAINT [DF_IntendDetail_HIST_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendDetail_HIST_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendDetail_HIST] DROP CONSTRAINT [DF_IntendDetail_HIST_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendDetail_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[IntendDetail_HIST]
GO
/****** Object:  Table [dbo].[IntendReceived]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceived]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceived]
GO
/****** Object:  Table [dbo].[IntendReceived_HIST]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceived_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceived_HIST]
GO
/****** Object:  Table [dbo].[IntendReceivedDetail]    Script Date: 05/08/2015 16:25:48 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF_IntendReceivedDetail_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF_IntendReceivedDetail_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF_IntendReceivedDetail_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF_IntendReceivedDetail_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_IssueQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF_IntendReceivedDetail_IssueQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_RecdQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF_IntendReceivedDetail_RecdQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__IntendRec__Produ__0AA882D3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail] DROP CONSTRAINT [DF__IntendRec__Produ__0AA882D3]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceivedDetail]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceivedDetail]
GO
/****** Object:  Table [dbo].[IntendReceivedDetail_HIST]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_HIST_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] DROP CONSTRAINT [DF_IntendReceivedDetail_HIST_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_HIST_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] DROP CONSTRAINT [DF_IntendReceivedDetail_HIST_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_HIST_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] DROP CONSTRAINT [DF_IntendReceivedDetail_HIST_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_HIST_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] DROP CONSTRAINT [DF_IntendReceivedDetail_HIST_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_HIST_IssueQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] DROP CONSTRAINT [DF_IntendReceivedDetail_HIST_IssueQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IntendReceivedDetail_HIST_RecdQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] DROP CONSTRAINT [DF_IntendReceivedDetail_HIST_RecdQty]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceivedDetail_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceivedDetail_HIST]
GO
/****** Object:  Table [dbo].[InventoryAttributesMaster]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryAttributesMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryAttributesMaster]
GO
/****** Object:  Table [dbo].[InventoryAttributesOrgMapping]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryAttributesOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryAttributesOrgMapping]
GO
/****** Object:  Table [dbo].[InventoryConfig]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryConfig]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryConfig]
GO
/****** Object:  Table [dbo].[InventoryIDMaster]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryIDMaster]
GO
/****** Object:  Table [dbo].[InventoryLocationsClientMapping]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryLocationsClientMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryLocationsClientMapping]
GO
/****** Object:  Table [dbo].[InventoryPageMap]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryPageMap]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryPageMap]
GO
/****** Object:  Table [dbo].[InventoryProductMapping]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InventoryProductMapping_EstimateQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InventoryProductMapping] DROP CONSTRAINT [DF_InventoryProductMapping_EstimateQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InventoryProductMapping_BufferQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InventoryProductMapping] DROP CONSTRAINT [DF_InventoryProductMapping_BufferQty]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryProductMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryProductMapping]
GO
/****** Object:  Table [dbo].[InventoryTaxDetails]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryTaxDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryTaxDetails]
GO
/****** Object:  Table [dbo].[InventoryUOM]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryUOM]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryUOM]
GO
/****** Object:  Table [dbo].[InventoryWantedList]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InventoryWantedList_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InventoryWantedList] DROP CONSTRAINT [DF_InventoryWantedList_Quantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryWantedList]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryWantedList]
GO
/****** Object:  Table [dbo].[KitMaster]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitMaster_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitMaster] DROP CONSTRAINT [DF_KitMaster_Quantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitMaster]') AND type in (N'U'))
DROP TABLE [dbo].[KitMaster]
GO
/****** Object:  Table [dbo].[KitPatientUsage]    Script Date: 05/08/2015 16:25:49 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPatientUsage_SoldPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPatientUsage] DROP CONSTRAINT [DF_KitPatientUsage_SoldPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitPatientUsage]') AND type in (N'U'))
DROP TABLE [dbo].[KitPatientUsage]
GO
/****** Object:  Table [dbo].[KitPrepMaster]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMaster_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMaster] DROP CONSTRAINT [DF_KitPrepMaster_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMaster_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMaster] DROP CONSTRAINT [DF_KitPrepMaster_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMaster_TaxPercent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMaster] DROP CONSTRAINT [DF_KitPrepMaster_TaxPercent]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__KitPrepMa__Produ__2A212E2C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMaster] DROP CONSTRAINT [DF__KitPrepMa__Produ__2A212E2C]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMaster_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMaster] DROP CONSTRAINT [DF_KitPrepMaster_Quantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitPrepMaster]') AND type in (N'U'))
DROP TABLE [dbo].[KitPrepMaster]
GO
/****** Object:  Table [dbo].[KitPrepMasterDetails]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMasterDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMasterDetails] DROP CONSTRAINT [DF_KitPrepMasterDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMasterDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMasterDetails] DROP CONSTRAINT [DF_KitPrepMasterDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMasterDetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMasterDetails] DROP CONSTRAINT [DF_KitPrepMasterDetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMasterDetails_TaxPercent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMasterDetails] DROP CONSTRAINT [DF_KitPrepMasterDetails_TaxPercent]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__KitPrepMa__Produ__2C09769E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMasterDetails] DROP CONSTRAINT [DF__KitPrepMa__Produ__2C09769E]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_KitPrepMasterDetails_ActualQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KitPrepMasterDetails] DROP CONSTRAINT [DF_KitPrepMasterDetails_ActualQty]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitPrepMasterDetails]') AND type in (N'U'))
DROP TABLE [dbo].[KitPrepMasterDetails]
GO
/****** Object:  Table [dbo].[KitStudyDetails]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitStudyDetails]') AND type in (N'U'))
DROP TABLE [dbo].[KitStudyDetails]
GO
/****** Object:  Table [dbo].[Localities]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Localities]') AND type in (N'U'))
DROP TABLE [dbo].[Localities]
GO
 
/****** Object:  Table [dbo].[LocationProductMaping]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocationProductMaping]') AND type in (N'U'))
DROP TABLE [dbo].[LocationProductMaping]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Locations]') AND type in (N'U'))
DROP TABLE [dbo].[Locations]
GO
/****** Object:  Table [dbo].[LocationType]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocationType]') AND type in (N'U'))
DROP TABLE [dbo].[LocationType]
GO
/****** Object:  Table [dbo].[LocationUserMap]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocationUserMap]') AND type in (N'U'))
DROP TABLE [dbo].[LocationUserMap]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Manufacturer]') AND type in (N'U'))
DROP TABLE [dbo].[Manufacturer]
GO
/****** Object:  Table [dbo].[MaritalStatus]    Script Date: 05/08/2015 16:25:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MaritalStatus]') AND type in (N'U'))
DROP TABLE [dbo].[MaritalStatus]
GO
/****** Object:  Table [dbo].[MatchingStockReceived]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_PaidAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_PaidAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_GrandTotal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_GrandTotal]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_CessOnExciseTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_CessOnExciseTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_HighterEdCessTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_HighterEdCessTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_CSTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_CSTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_CessOnExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_CessOnExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_HighterEdCessTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_HighterEdCessTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_CSTAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_CSTAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_ExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_ExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceived_RoundOfValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceived] DROP CONSTRAINT [DF_MatchingStockReceived_RoundOfValue]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MatchingStockReceived]') AND type in (N'U'))
DROP TABLE [dbo].[MatchingStockReceived]
GO
/****** Object:  Table [dbo].[MatchingStockReceiveddetails]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_POQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_POQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_ComplimentQTY]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_ComplimentQTY]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_TotalCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_TotalCost]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_RECQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_RECQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_InvoiceQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_InvoiceQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_RcvdLSUQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_RcvdLSUQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_UnitSellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_UnitSellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_UnitCostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_UnitCostPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MatchingStockReceiveddetails_ExciseTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MatchingStockReceiveddetails] DROP CONSTRAINT [DF_MatchingStockReceiveddetails_ExciseTax]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MatchingStockReceiveddetails]') AND type in (N'U'))
DROP TABLE [dbo].[MatchingStockReceiveddetails]
GO
/****** Object:  Table [dbo].[PharmacyBillIdMaster]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PharmacyBillIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PharmacyBillIdMaster]
GO
/****** Object:  Table [dbo].[PharmacyInventoryIDMaster]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PharmacyInventoryIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PharmacyInventoryIDMaster]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductCategories]') AND type in (N'U'))
DROP TABLE [dbo].[ProductCategories]
GO
/****** Object:  Table [dbo].[ProductCodeMaster]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductCodeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ProductCodeMaster]
GO
/****** Object:  Table [dbo].[ProductEpisodeVisitMapping]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__ProductEp__IsDel__4E5E8EA2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductEpisodeVisitMapping] DROP CONSTRAINT [DF__ProductEp__IsDel__4E5E8EA2]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductEpisodeVisitMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProductEpisodeVisitMapping]
GO
/****** Object:  Table [dbo].[ProductLocationMapping]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductLocationMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProductLocationMapping]
GO
/****** Object:  Table [dbo].[ProductMaintenanceRecord]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductMaintenanceRecord_MaintenanceCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductMaintenanceRecord] DROP CONSTRAINT [DF_ProductMaintenanceRecord_MaintenanceCost]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductMaintenanceRecord]') AND type in (N'U'))
DROP TABLE [dbo].[ProductMaintenanceRecord]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Products_TaxPercent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [DF_Products_TaxPercent]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__Products__IsDisc__4F52B2DB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [DF__Products__IsDisc__4F52B2DB]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO
/****** Object:  Table [dbo].[Products_HIST]    Script Date: 05/08/2015 16:25:51 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Products_HIST_TaxPercent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Products_HIST] DROP CONSTRAINT [DF_Products_HIST_TaxPercent]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[Products_HIST]
GO
/****** Object:  Table [dbo].[ProductsAttributes]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductsAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[ProductsAttributes]
GO
/****** Object:  Table [dbo].[ProductsAttributesDetails]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductsAttributesDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ProductsAttributesDetails]
GO
/****** Object:  Table [dbo].[ProductSupplierRateMapping]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_Rate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping] DROP CONSTRAINT [DF_ProductSupplierRateMapping_Rate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping] DROP CONSTRAINT [DF_ProductSupplierRateMapping_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping] DROP CONSTRAINT [DF_ProductSupplierRateMapping_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping] DROP CONSTRAINT [DF_ProductSupplierRateMapping_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping] DROP CONSTRAINT [DF_ProductSupplierRateMapping_Tax]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductSupplierRateMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProductSupplierRateMapping]
GO
/****** Object:  Table [dbo].[ProductSupplierRateMapping_HIST]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_HIST_Rate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] DROP CONSTRAINT [DF_ProductSupplierRateMapping_HIST_Rate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_HIST_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] DROP CONSTRAINT [DF_ProductSupplierRateMapping_HIST_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_HIST_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] DROP CONSTRAINT [DF_ProductSupplierRateMapping_HIST_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_HIST_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] DROP CONSTRAINT [DF_ProductSupplierRateMapping_HIST_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProductSupplierRateMapping_HIST_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] DROP CONSTRAINT [DF_ProductSupplierRateMapping_HIST_Tax]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductSupplierRateMapping_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[ProductSupplierRateMapping_HIST]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductType]') AND type in (N'U'))
DROP TABLE [dbo].[ProductType]
GO
/****** Object:  Table [dbo].[ProductUpload]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductUpload]') AND type in (N'U'))
DROP TABLE [dbo].[ProductUpload]
GO
/****** Object:  Table [dbo].[ProjectionList]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ProjectionList_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ProjectionList] DROP CONSTRAINT [DF_ProjectionList_Quantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectionList]') AND type in (N'U'))
DROP TABLE [dbo].[ProjectionList]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderDetails] DROP CONSTRAINT [DF_PurchaseOrderDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderDetails]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails_HIST]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderDetails_HIST_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderDetails_HIST] DROP CONSTRAINT [DF_PurchaseOrderDetails_HIST_Quantity]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderDetails_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderDetails_HIST]
GO
/****** Object:  Table [dbo].[PurchaseOrderIDMaster]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderIDMaster]
GO
/****** Object:  Table [dbo].[PurchaseOrderMappingLocation]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderMappingLocation_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] DROP CONSTRAINT [DF_PurchaseOrderMappingLocation_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderMappingLocation_CompQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] DROP CONSTRAINT [DF_PurchaseOrderMappingLocation_CompQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderMappingLocation_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] DROP CONSTRAINT [DF_PurchaseOrderMappingLocation_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderMappingLocation_Vat]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] DROP CONSTRAINT [DF_PurchaseOrderMappingLocation_Vat]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderMappingLocation_Amount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] DROP CONSTRAINT [DF_PurchaseOrderMappingLocation_Amount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrderMappingLocation_Rate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] DROP CONSTRAINT [DF_PurchaseOrderMappingLocation_Rate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderMappingLocation]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderMappingLocation]
GO
/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 05/08/2015 16:25:52 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrders_Charges]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrders] DROP CONSTRAINT [DF_PurchaseOrders_Charges]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrders_PoDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrders] DROP CONSTRAINT [DF_PurchaseOrders_PoDiscount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrders_GrossAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrders] DROP CONSTRAINT [DF_PurchaseOrders_GrossAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrders_NetAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrders] DROP CONSTRAINT [DF_PurchaseOrders_NetAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseOrders_FreightCharges]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseOrders] DROP CONSTRAINT [DF_PurchaseOrders_FreightCharges]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrders]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrders]
GO
/****** Object:  Table [dbo].[PurchaseRequest]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseRequest]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseRequest]
GO
/****** Object:  Table [dbo].[PurchaseRequestDetails]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseRequestDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseRequestDetails]
GO
/****** Object:  Table [dbo].[QuotationMaster]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuotationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[QuotationMaster]
GO
/****** Object:  Table [dbo].[QuotationMaster_HIST]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuotationMaster_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[QuotationMaster_HIST]
GO
/****** Object:  Table [dbo].[SalesOrderDetails]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesOrderDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesOrderDetails] DROP CONSTRAINT [DF_SalesOrderDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesOrderDetails_IssueQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesOrderDetails] DROP CONSTRAINT [DF_SalesOrderDetails_IssueQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesOrderDetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesOrderDetails] DROP CONSTRAINT [DF_SalesOrderDetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesOrderDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesOrderDetails] DROP CONSTRAINT [DF_SalesOrderDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesOrderDetails_TotalAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesOrderDetails] DROP CONSTRAINT [DF_SalesOrderDetails_TotalAmount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesOrderDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SalesOrderDetails]
GO
/****** Object:  Table [dbo].[SalesOrderOutFlowDetails]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesOrderOutFlowDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SalesOrderOutFlowDetails]
GO
/****** Object:  Table [dbo].[SalesOrders]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesOrders_GrandTotal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesOrders] DROP CONSTRAINT [DF_SalesOrders_GrandTotal]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesOrders]') AND type in (N'U'))
DROP TABLE [dbo].[SalesOrders]
GO
/****** Object:  Table [dbo].[SalesReturn]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesReturn_ActualAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesReturn] DROP CONSTRAINT [DF_SalesReturn_ActualAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesReturn_ApprovedAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesReturn] DROP CONSTRAINT [DF_SalesReturn_ApprovedAmount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesReturn]') AND type in (N'U'))
DROP TABLE [dbo].[SalesReturn]
GO
/****** Object:  Table [dbo].[SalesReturnDetails]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesReturnDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesReturnDetails] DROP CONSTRAINT [DF_SalesReturnDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesReturnDetails_CostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesReturnDetails] DROP CONSTRAINT [DF_SalesReturnDetails_CostPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SalesReturnDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SalesReturnDetails] DROP CONSTRAINT [DF_SalesReturnDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesReturnDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SalesReturnDetails]
GO
/****** Object:  Table [dbo].[SellingPriceRuleLocationMapping]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SellingPriceRuleLocationMapping]') AND type in (N'U'))
DROP TABLE [dbo].[SellingPriceRuleLocationMapping]
GO
/****** Object:  Table [dbo].[SellingPriceRuleMaster]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SellingPriceRuleMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SellingPriceRuleMaster]
GO
/****** Object:  Table [dbo].[StockDamageIDMaster]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockDamageIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StockDamageIDMaster]
GO
/****** Object:  Table [dbo].[StockInHand]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockReceived]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockReceived]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockIssued]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockIssued]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockReturn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockReturn]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockDamage]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockDamage]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalLocationIssued]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalLocationIssued]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_CostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_CostPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockInHand]') AND type in (N'U'))
DROP TABLE [dbo].[StockInHand]
GO
/****** Object:  Table [dbo].[StockInHand_HIST]    Script Date: 05/08/2015 16:25:53 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_TotalStockReceived]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_TotalStockReceived]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_TotalStockIssued]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_TotalStockIssued]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_TotalStockReturn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_TotalStockReturn]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_TotalStockDamage]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_TotalStockDamage]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_TotalLocationIssued]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_TotalLocationIssued]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_HIST_CostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand_HIST] DROP CONSTRAINT [DF_StockInHand_HIST_CostPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockInHand_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[StockInHand_HIST]
GO
/****** Object:  Table [dbo].[StockIssuedIDMaster]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockIssuedIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StockIssuedIDMaster]
GO
/****** Object:  Table [dbo].[StockOutFlow]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__StockOutF__Presc__5E94F66B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF__StockOutF__Presc__5E94F66B]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_GrandTotal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_GrandTotal]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_CSTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_CSTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_CSTAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_CSTAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_ExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_ExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_VAT]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_VAT]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_Surcharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_Surcharge]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_RoundOfValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_RoundOfValue]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlow_TotalSales]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlow] DROP CONSTRAINT [DF_StockOutFlow_TotalSales]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutFlow]') AND type in (N'U'))
DROP TABLE [dbo].[StockOutFlow]
GO
/****** Object:  Table [dbo].[StockOutFlowDetails]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_TaxPercent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_TaxPercent]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__StockOutF__Produ__5F891AA4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF__StockOutF__Produ__5F891AA4]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_TotalCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_TotalCost]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_TotalMRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_TotalMRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_Taxvalues]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_Taxvalues]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_ExciesDuty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_ExciesDuty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_CSTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_CSTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_CSTAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_CSTAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_Discountvalue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_Discountvalue]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockOutFlowDetails_Returnqty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockOutFlowDetails] DROP CONSTRAINT [DF_StockOutFlowDetails_Returnqty]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutFlowDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockOutFlowDetails]
GO
/****** Object:  Table [dbo].[StockOutFlowTypes]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutFlowTypes]') AND type in (N'U'))
DROP TABLE [dbo].[StockOutFlowTypes]
GO
/****** Object:  Table [dbo].[StockReceived]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_PaidAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_PaidAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_GrandTotal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_GrandTotal]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_CessOnExciseTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_CessOnExciseTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HighterEdCessTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_HighterEdCessTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_CSTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_CSTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_CessOnExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_CessOnExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HighterEdCessTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_HighterEdCessTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_CSTAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_CSTAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_ExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_ExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_RoundOfValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived] DROP CONSTRAINT [DF_StockReceived_RoundOfValue]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceived]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceived]
GO
/****** Object:  Table [dbo].[StockReceived_HIST]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_PaidAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_PaidAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_GrandTotal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_GrandTotal]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_CessOnExciseTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_CessOnExciseTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_HighterEdCessTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_HighterEdCessTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_CSTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_CSTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_CessOnExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_CessOnExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_HighterEdCessTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_HighterEdCessTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_CSTAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_CSTAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_ExciseTaxAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_ExciseTaxAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceived_HIST_RoundOfValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceived_HIST] DROP CONSTRAINT [DF_StockReceived_HIST_RoundOfValue]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceived_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceived_HIST]
GO
/****** Object:  Table [dbo].[StockReceivedAttributesDetails]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedAttributesDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedAttributesDetails]
GO
/****** Object:  Table [dbo].[StockReceivedDetails]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_POQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_POQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_ComplimentQTY]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_ComplimentQTY]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_TotalCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_TotalCost]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_RECQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_RECQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_InvoiceQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_InvoiceQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_RcvdLSUQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_RcvdLSUQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_UnitSellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_UnitSellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_UnitCostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_UnitCostPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_ExciseTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF_StockReceivedDetails_ExciseTax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__StockRece__Produ__61716316]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails] DROP CONSTRAINT [DF__StockRece__Produ__61716316]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedDetails]
GO
/****** Object:  Table [dbo].[StockReceivedDetails_HIST]    Script Date: 05/08/2015 16:25:54 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_POQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_POQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_ComplimentQTY]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_ComplimentQTY]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_TotalCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_TotalCost]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_RECQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_RECQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_InvoiceQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_InvoiceQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_RcvdLSUQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_RcvdLSUQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_UnitSellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_UnitSellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_UnitCostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_UnitCostPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_MRP]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReceivedDetails_HIST_ExciseTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReceivedDetails_HIST] DROP CONSTRAINT [DF_StockReceivedDetails_HIST_ExciseTax]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedDetails_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedDetails_HIST]
GO
/****** Object:  Table [dbo].[StockReceivedIDMaster]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedIDMaster]
GO
/****** Object:  Table [dbo].[StockReceivedType]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedType]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedType]
GO
/****** Object:  Table [dbo].[StockReturn]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReturn_ActualAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReturn] DROP CONSTRAINT [DF_StockReturn_ActualAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReturn_ApprovedAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReturn] DROP CONSTRAINT [DF_StockReturn_ApprovedAmount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReturn]') AND type in (N'U'))
DROP TABLE [dbo].[StockReturn]
GO
/****** Object:  Table [dbo].[StockReturnDetails]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReturnDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReturnDetails] DROP CONSTRAINT [DF_StockReturnDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReturnDetails_CostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReturnDetails] DROP CONSTRAINT [DF_StockReturnDetails_CostPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockReturnDetails_Amount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReturnDetails] DROP CONSTRAINT [DF_StockReturnDetails_Amount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__StockRetu__Produ__6265874F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockReturnDetails] DROP CONSTRAINT [DF__StockRetu__Produ__6265874F]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReturnDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockReturnDetails]
GO
/****** Object:  Table [dbo].[StockReturnIDMaster]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReturnIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StockReturnIDMaster]
GO
/****** Object:  Table [dbo].[StockStatus]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockStatus]') AND type in (N'U'))
DROP TABLE [dbo].[StockStatus]
GO
/****** Object:  Table [dbo].[StockStatusMapping]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockStatusMapping]') AND type in (N'U'))
DROP TABLE [dbo].[StockStatusMapping]
GO
/****** Object:  Table [dbo].[StockType]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockType]') AND type in (N'U'))
DROP TABLE [dbo].[StockType]
GO
/****** Object:  Table [dbo].[StockTypeMapping]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockTypeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[StockTypeMapping]
GO
/****** Object:  Table [dbo].[StockUsage]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockUsage]') AND type in (N'U'))
DROP TABLE [dbo].[StockUsage]
GO
/****** Object:  Table [dbo].[StockUsageDetails]    Script Date: 05/08/2015 16:25:55 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockUsageDetails_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockUsageDetails] DROP CONSTRAINT [DF_StockUsageDetails_Quantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockUsageDetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockUsageDetails] DROP CONSTRAINT [DF_StockUsageDetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockUsageDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockUsageDetails] DROP CONSTRAINT [DF_StockUsageDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockUsageDetails_TaxPercent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockUsageDetails] DROP CONSTRAINT [DF_StockUsageDetails_TaxPercent]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockUsageDetails_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockUsageDetails] DROP CONSTRAINT [DF_StockUsageDetails_Discount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockUsageDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockUsageDetails]
GO
/****** Object:  Table [dbo].[StockUsageIDMaster]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockUsageIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StockUsageIDMaster]
GO
/****** Object:  Table [dbo].[SupplierAddress]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierAddress]') AND type in (N'U'))
DROP TABLE [dbo].[SupplierAddress]
GO
/****** Object:  Table [dbo].[SupplierCreditorDebitNote]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SupplierCreditorDebitNote_CreditAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SupplierCreditorDebitNote] DROP CONSTRAINT [DF_SupplierCreditorDebitNote_CreditAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SupplierCreditorDebitNote_UsedAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SupplierCreditorDebitNote] DROP CONSTRAINT [DF_SupplierCreditorDebitNote_UsedAmount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SupplierCreditorDebitNote_DebitAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SupplierCreditorDebitNote] DROP CONSTRAINT [DF_SupplierCreditorDebitNote_DebitAmount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierCreditorDebitNote]') AND type in (N'U'))
DROP TABLE [dbo].[SupplierCreditorDebitNote]
GO
/****** Object:  Table [dbo].[SupplierCreditorDebitReference]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SupplierCreditorDebitReference_UsedAmount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SupplierCreditorDebitReference] DROP CONSTRAINT [DF_SupplierCreditorDebitReference_UsedAmount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierCreditorDebitReference]') AND type in (N'U'))
DROP TABLE [dbo].[SupplierCreditorDebitReference]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suppliers]') AND type in (N'U'))
DROP TABLE [dbo].[Suppliers]
GO
/****** Object:  Table [dbo].[Suppliers_HIST]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suppliers_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[Suppliers_HIST]
GO
/****** Object:  Table [dbo].[TempStockReceivedDetails]    Script Date: 05/08/2015 16:25:56 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_POQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_POQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_ComplimentQTY]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_ComplimentQTY]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_Tax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_Tax]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_Discount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_TotalCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_TotalCost]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_UnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_UnitPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_SellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_SellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_RECQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_RECQuantity]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_InvoiceQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_InvoiceQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_RcvdLSUQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_RcvdLSUQty]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_UnitSellingPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_UnitSellingPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_UnitCostPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_UnitCostPrice]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_TempStockReceivedDetails_MRP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TempStockReceivedDetails] DROP CONSTRAINT [DF_TempStockReceivedDetails_MRP]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TempStockReceivedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TempStockReceivedDetails]
GO


/****** Object:  Table [dbo].[Drafts]    Script Date: 05/08/2015 18:50:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Drafts]') AND type in (N'U'))
DROP TABLE [dbo].[Drafts]
GO

GO

/****** Object:  Table [dbo].[ProductsAttributesMaster]    Script Date: 05/08/2015 18:56:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductsAttributesMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ProductsAttributesMaster]
GO

GO

/****** Object:  Table [dbo].[ProductsNoExpiryDate]    Script Date: 05/08/2015 18:56:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductsNoExpiryDate]') AND type in (N'U'))
DROP TABLE [dbo].[ProductsNoExpiryDate]
GO


/****** Object:  Table [dbo].[TaxCategoriesMapping]    Script Date: 05/11/2015 12:58:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaxCategoriesMapping]') AND type in (N'U'))
DROP TABLE [dbo].[TaxCategoriesMapping]
GO



/****** Object:  Table [dbo].[EpisodeVisitDetails]    Script Date: 05/11/2015 14:32:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EpisodeVisitDetails]') AND type in (N'U'))
DROP TABLE [dbo].[EpisodeVisitDetails]
GO

 
 
GO

/****** Object:  Table [dbo].[EquipmentMaintenanceMaster]    Script Date: 05/11/2015 14:33:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EquipmentMaintenanceMaster]') AND type in (N'U'))
DROP TABLE [dbo].[EquipmentMaintenanceMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugGeneric]') AND type in (N'U'))
DROP TABLE [dbo].[DrugGeneric]
GO

GO

/****** Object:  Table [dbo].[ApprovalMechanismStatus]    Script Date: 05/12/2015 14:49:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ApprovalMechanismStatus]') AND type in (N'U'))
DROP TABLE [dbo].[ApprovalMechanismStatus]
GO

/****** Object:  Table [dbo].[RuleMaster]    Script Date: 05/12/2015 14:49:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RuleMaster]') AND type in (N'U'))
DROP TABLE [dbo].RuleMaster
GO



/****** Object:  Table [dbo].[RuleApprovelMaster]    Script Date: 05/12/2015 14:49:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RuleApprovelMaster]') AND type in (N'U'))
DROP TABLE [dbo].RuleApprovelMaster
GO
/****** Object:  Table [dbo].[ApprovalMechanismStatus]    Script Date: 05/12/2015 14:49:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeMapping]') AND type in (N'U'))
DROP TABLE [dbo].BarcodeMapping
GO

/****** Object:  Table [dbo].[StockReceivedBarcodeMapping]    Script Date: 05/12/2015 14:49:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedBarcodeMapping]') AND type in (N'U'))
DROP TABLE [dbo].StockReceivedBarcodeMapping
GO

/****** Object:  Table [dbo].[[ReportExcelSp]]    Script Date: 05/12/2015 14:49:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[[ReportExcelSp]]') AND type in (N'U'))
DROP TABLE [dbo].[ReportExcelSp]
GO

