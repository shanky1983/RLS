
/****** Object:  UserDefinedFunction [dbo].[ufsFormat]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ufsFormat]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[ufsFormat]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_TitleCase]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_TitleCase]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_TitleCase]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_DayOfWeek]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DayOfWeek]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_DayOfWeek]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_DayOfMonth]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DayOfMonth]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_DayOfMonth]
GO
/****** Object:  UserDefinedFunction [dbo].[StripHTML]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StripHTML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[StripHTML]
GO
/****** Object:  UserDefinedFunction [dbo].[Splitfunc]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Splitfunc]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Splitfunc]
GO
/****** Object:  UserDefinedFunction [dbo].[SpiltDrugFrequence]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpiltDrugFrequence]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[SpiltDrugFrequence]
GO
/****** Object:  UserDefinedFunction [dbo].[SpiltDrugDruration]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpiltDrugDruration]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[SpiltDrugDruration]
GO
/****** Object:  UserDefinedFunction [dbo].[ReportPdfPath]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportPdfPath]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[ReportPdfPath]
GO
/****** Object:  UserDefinedFunction [dbo].[ReportBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[ReportBillDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[RemoveNonNumerics]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveNonNumerics]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[RemoveNonNumerics]
GO
/****** Object:  UserDefinedFunction [dbo].[properCase]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[properCase]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[properCase]
GO
/****** Object:  UserDefinedFunction [dbo].[PrintReportPdf]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrintReportPdf]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[PrintReportPdf]
GO
/****** Object:  UserDefinedFunction [dbo].[posSubString]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[posSubString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[posSubString]
GO
/****** Object:  UserDefinedFunction [dbo].[PMSGetBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PMSGetBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[PMSGetBillDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[pGetStockinHand]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetStockinHand]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[pGetStockinHand]
GO
/****** Object:  UserDefinedFunction [dbo].[PGetRateValueBasedonRate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PGetRateValueBasedonRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[PGetRateValueBasedonRate]
GO
/****** Object:  UserDefinedFunction [dbo].[pGetCoPayandClaimAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetCoPayandClaimAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[pGetCoPayandClaimAmount]
GO
/****** Object:  UserDefinedFunction [dbo].[Pgetamountreceivedforvisit_S]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pgetamountreceivedforvisit_S]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Pgetamountreceivedforvisit_S]
GO
/****** Object:  UserDefinedFunction [dbo].[Pgetamountreceivedforvisit_arun]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pgetamountreceivedforvisit_arun]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Pgetamountreceivedforvisit_arun]
GO
/****** Object:  UserDefinedFunction [dbo].[pGetAmountReceivedForVisit]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetAmountReceivedForVisit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[pGetAmountReceivedForVisit]
GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWords_t]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWords_t]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[NumbertToWords_t]
GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWords_bak]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWords_bak]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[NumbertToWords_bak]
GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWords]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWords]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[NumbertToWords]
GO
/****** Object:  UserDefinedFunction [dbo].[mydbr_style]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mydbr_style]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[mydbr_style]
GO
/****** Object:  UserDefinedFunction [dbo].[Isdeleteable]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Isdeleteable]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Isdeleteable]
GO
/****** Object:  UserDefinedFunction [dbo].[IsAllowed]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsAllowed]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[IsAllowed]
GO
/****** Object:  UserDefinedFunction [dbo].[InvoiceWatersBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceWatersBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[InvoiceWatersBillDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[InvoiceBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[InvoiceBillDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[InitialCap]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InitialCap]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[InitialCap]
GO
/****** Object:  UserDefinedFunction [dbo].[InitCap]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InitCap]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[InitCap]
GO
/****** Object:  UserDefinedFunction [dbo].[HasChildHistory]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasChildHistory]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[HasChildHistory]
GO
/****** Object:  UserDefinedFunction [dbo].[HasChildExamination]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasChildExamination]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[HasChildExamination]
GO
/****** Object:  UserDefinedFunction [dbo].[HasChild]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasChild]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[HasChild]
GO
/****** Object:  UserDefinedFunction [dbo].[getunitcost]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getunitcost]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[getunitcost]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAPaymentDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAPaymentDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTPAPaymentDetails]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAbalanceLab]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAbalanceLab]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTPAbalanceLab]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAbalanceAll]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAbalanceAll]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTPAbalanceAll]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAbalance]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAbalance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTPAbalance]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTPAAmount]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTDSAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTDSAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTDSAmount]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSurgerySplitupDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSurgerySplitupDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetSurgerySplitupDetails]
GO
/****** Object:  UserDefinedFunction [dbo].[GetStockRecdQty]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockRecdQty]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetStockRecdQty]
GO
/****** Object:  UserDefinedFunction [dbo].[GetStockOutFlowQty]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockOutFlowQty]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetStockOutFlowQty]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSPKGSplitupDetailsTemp]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSPKGSplitupDetailsTemp]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetSPKGSplitupDetailsTemp]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSPKGSplitupDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSPKGSplitupDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetSPKGSplitupDetails]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSpecialityID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSpecialityID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetSpecialityID]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSpeciality]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSpeciality]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetSpeciality]
GO
/****** Object:  UserDefinedFunction [dbo].[GetRoomDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRoomDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetRoomDetails]
GO
/****** Object:  UserDefinedFunction [dbo].[GetRoomCollectionByDate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRoomCollectionByDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetRoomCollectionByDate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetReceivedFromTPA]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetReceivedFromTPA]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetReceivedFromTPA]
GO
/****** Object:  UserDefinedFunction [dbo].[GetRatePCClient]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRatePCClient]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetRatePCClient]
GO
/****** Object:  UserDefinedFunction [dbo].[GetRate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetRate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetPaymentBalance]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPaymentBalance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetPaymentBalance]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIPReceiptAmountByDate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPReceiptAmountByDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetIPReceiptAmountByDate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIPRate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetIPRate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIPDueExcludeAdvance]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPDueExcludeAdvance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetIPDueExcludeAdvance]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIPBillAmtByDate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPBillAmtByDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetIPBillAmtByDate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIPBalanceAll]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPBalanceAll]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetIPBalanceAll]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIPBalance]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPBalance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetIPBalance]
GO
/****** Object:  UserDefinedFunction [dbo].[GetINVRate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetINVRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetINVRate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetINVIPRate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetINVIPRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetINVIPRate]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFeeDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetFeeDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetFeeDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[GetExonvalues_fn]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExonvalues_fn]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetExonvalues_fn]
GO
/****** Object:  UserDefinedFunction [dbo].[GetDiscount]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetDiscount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetDiscount]
GO
/****** Object:  UserDefinedFunction [dbo].[getCond]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getCond]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[getCond]
GO
/****** Object:  UserDefinedFunction [dbo].[GetConcatReceiptNo]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetConcatReceiptNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetConcatReceiptNo]
GO
/****** Object:  UserDefinedFunction [dbo].[GetClaimfromTPA]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetClaimfromTPA]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetClaimfromTPA]
GO
/****** Object:  UserDefinedFunction [dbo].[GetBillSplitDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetBillSplitDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetBillSplitDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[GetBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetBillDescription]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAsciiValue]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAsciiValue]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetAsciiValue]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAmountForLedgerHeads]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAmountForLedgerHeads]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetAmountForLedgerHeads]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAdvanceAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAdvanceAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetAdvanceAmount]
GO
/****** Object:  UserDefinedFunction [dbo].[GetaddressdetailsB]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetaddressdetailsB]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetaddressdetailsB]
GO
/****** Object:  UserDefinedFunction [dbo].[Getaddressdetails1]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Getaddressdetails1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Getaddressdetails1]
GO
/****** Object:  UserDefinedFunction [dbo].[Getaddressdetails]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Getaddressdetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Getaddressdetails]
GO
/****** Object:  UserDefinedFunction [dbo].[fnTATDelayPriority]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnTATDelayPriority]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnTATDelayPriority]
GO
/****** Object:  UserDefinedFunction [dbo].[fnSplitString]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSplitString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnSplitString]
GO
/****** Object:  UserDefinedFunction [dbo].[fnsplitcalinv]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnsplitcalinv]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnsplitcalinv]
GO
/****** Object:  UserDefinedFunction [dbo].[fnSplit]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSplit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnSplit]
GO
/****** Object:  UserDefinedFunction [dbo].[fnPadNumber]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnPadNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnPadNumber]
GO
/****** Object:  UserDefinedFunction [dbo].[fnMakeReminderEntry]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnMakeReminderEntry]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnMakeReminderEntry]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockTypeForID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockTypeForID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetStockTypeForID]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockTypeForDesc]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockTypeForDesc]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetStockTypeForDesc]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockStatusForID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockStatusForID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetStockStatusForID]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockStatusForDesc]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockStatusForDesc]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetStockStatusForDesc]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetSplitedValues]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetSplitedValues]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetSplitedValues]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetSlotsWithTokenNumber]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetSlotsWithTokenNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetSlotsWithTokenNumber]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetRoomFee]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetRoomFee]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetRoomFee]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetPatientDemogHistory]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientDemogHistory]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetPatientDemogHistory]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetInvComments]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetInvComments]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetInvComments]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetIDwithPattern_Invoice]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetIDwithPattern_Invoice]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetIDwithPattern_Invoice]
GO
/****** Object:  UserDefinedFunction [dbo].[Fngetidwithpattern]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fngetidwithpattern]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fngetidwithpattern]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetGroupName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetGroupName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetGroupName]
GO
/****** Object:  UserDefinedFunction [dbo].[Fngetgroupcountablelist]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fngetgroupcountablelist]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fngetgroupcountablelist]
GO
/****** Object:  UserDefinedFunction [dbo].[Fngetcountablelist]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fngetcountablelist]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fngetcountablelist]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetBillWiseReceived]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetBillWiseReceived]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetBillWiseReceived]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetAmtReceivedDtls]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetAmtReceivedDtls]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetAmtReceivedDtls]
GO
/****** Object:  UserDefinedFunction [dbo].[fnGeneratePatientNumberCustomLogic]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGeneratePatientNumberCustomLogic]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGeneratePatientNumberCustomLogic]
GO
/****** Object:  UserDefinedFunction [dbo].[fnFormatDate_Invoice]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnFormatDate_Invoice]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnFormatDate_Invoice]
GO
/****** Object:  UserDefinedFunction [dbo].[fnFormatDate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnFormatDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnFormatDate]
GO
/****** Object:  UserDefinedFunction [dbo].[fnConvertIntToRoman]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnConvertIntToRoman]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnConvertIntToRoman]
GO
/****** Object:  UserDefinedFunction [dbo].[fnCheckConsumableQuantity]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnCheckConsumableQuantity]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnCheckConsumableQuantity]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_XML]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_XML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_XML]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_StripCharacters]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_StripCharacters]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_StripCharacters]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_SplitString]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_SplitString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_SplitString]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_SplitExact]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_SplitExact]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_SplitExact]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ShowInQMSDashboard]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_ShowInQMSDashboard]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_ShowInQMSDashboard]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_seconds_to_time_str]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_seconds_to_time_str]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_seconds_to_time_str]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_seconds_to_time]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_seconds_to_time]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_seconds_to_time]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_REMOVE_SPECIAL_CHARACTER]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_REMOVE_SPECIAL_CHARACTER]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FN_REMOVE_SPECIAL_CHARACTER]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_OrderbleTest]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_OrderbleTest]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FN_OrderbleTest]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_OrderbleDept]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_OrderbleDept]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FN_OrderbleDept]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_mydbr_column_exists]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_mydbr_column_exists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_mydbr_column_exists]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_getVisitNumberTAT_DIXIT]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_getVisitNumberTAT_DIXIT]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FN_getVisitNumberTAT_DIXIT]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetTestNamebak]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetTestNamebak]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_GetTestNamebak]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetTestName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetTestName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_GetTestName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetTestChildCountable]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetTestChildCountable]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetTestChildCountable]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHandByExpDate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHandByExpDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetStockInHandByExpDate]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand_Unit]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand_Unit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetStockInHand_Unit]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand_BatchNo_check]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand_BatchNo_check]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetStockInHand_BatchNo_check]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand_BatchNo]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand_BatchNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetStockInHand_BatchNo]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetStockInHand]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getSpecialtyName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getSpecialtyName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getSpecialtyName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerDateWithOutContext]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetServerDateWithOutContext]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetServerDateWithOutContext]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerDate_BKP]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetServerDate_BKP]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetServerDate_BKP]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerDate]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetServerDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetServerDate]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetSampleName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetSampleName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_GetSampleName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getRoundOff]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getRoundOff]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getRoundOff]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetRateAplliedSettinsForTest_Dixit]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetRateAplliedSettinsForTest_Dixit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetRateAplliedSettinsForTest_Dixit]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetRateAplliedSettinsForClient_Dixit]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetRateAplliedSettinsForClient_Dixit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetRateAplliedSettinsForClient_Dixit]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcessingLocation1]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcessingLocation1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getProcessingLocation1]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcessingLocation_B]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcessingLocation_B]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getProcessingLocation_B]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcessingLocation]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcessingLocation]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getProcessingLocation]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcedureName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcedureName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getProcedureName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getPrimaryConsultantName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getPrimaryConsultantName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getPrimaryConsultantName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getOutSourceLocation1]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getOutSourceLocation1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getOutSourceLocation1]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getOutSourceLocation]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getOutSourceLocation]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getOutSourceLocation]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetOrderedOrggroupID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetOrderedOrggroupID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetOrderedOrggroupID]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getNextID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getNextID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getNextID]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getNameByLoginID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getNameByLoginID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getNameByLoginID]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getname]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getname]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getname]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getMappedStatus_1]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getMappedStatus_1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getMappedStatus_1]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getMappedStatus]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getMappedStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getMappedStatus]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetLoginName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetLoginName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_GetLoginName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getKit_SellingPrice]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getKit_SellingPrice]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getKit_SellingPrice]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getinvoicedueamt]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_getinvoicedueamt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_getinvoicedueamt]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getINVMaxMinFinalBBillNo]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getINVMaxMinFinalBBillNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getINVMaxMinFinalBBillNo]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetIntendReceivedQuantity]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetIntendReceivedQuantity]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetIntendReceivedQuantity]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getHalfDayDateDiff]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getHalfDayDateDiff]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getHalfDayDateDiff]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getGrpDept]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getGrpDept]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getGrpDept]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getFullDayDateDiff]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getFullDayDateDiff]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getFullDayDateDiff]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getForeName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getForeName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getForeName]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetFinalBillID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetFinalBillID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_GetFinalBillID]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getDOB]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getDOB]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getDOB]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getDeptNameByFeeID]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getDeptNameByFeeID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getDeptNameByFeeID]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getdecimalage]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_getdecimalage]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Fn_getdecimalage]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetDateTime]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetDateTime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetDateTime]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetBillerName]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetBillerName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetBillerName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getAgeDecimalAge]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getAgeDecimalAge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getAgeDecimalAge]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetAgeAtVisit]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetAgeAtVisit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_GetAgeAtVisit]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getAge1]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getAge1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getAge1]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_getAge]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getAge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_getAge]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_isstatus]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_get_isstatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_get_isstatus]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_collectioncenter]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_get_collectioncenter]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_get_collectioncenter]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_EndOfDay]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_EndOfDay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_EndOfDay]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_BegOfDay]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_BegOfDay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_BegOfDay]
GO
/****** Object:  UserDefinedFunction [dbo].[f_demo_datetoQ]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[f_demo_datetoQ]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[f_demo_datetoQ]
GO
/****** Object:  UserDefinedFunction [dbo].[DIXIT_DBR_CheckOrgRights]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIXIT_DBR_CheckOrgRights]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[DIXIT_DBR_CheckOrgRights]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckFrequencyDay]    Script Date: 6/25/2018 4:03:34 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckFrequencyDay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[CheckFrequencyDay]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckFrequencyDay]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckFrequencyDay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION  [dbo].[CheckFrequencyDay]
(@String NVARCHAR(100), @Delimiter NCHAR(1),@frequncyDay VARCHAR(20))
RETURNS  INT
AS
BEGIN
DECLARE @out INT=0
  IF EXISTS (SELECT 1 FROM splitfunc(@String,@Delimiter) WHERE discount= @frequncyDay)
  BEGIN
  SET @out=1
  END

  RETURN @out
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[DIXIT_DBR_CheckOrgRights]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIXIT_DBR_CheckOrgRights]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[DIXIT_DBR_CheckOrgRights] (@inLogin nvarchar(30) , @OrgID int) RETURNS INTEGER
AS
BEGIN
/*
MERGE INTO mydbr_userOrg as TARGET USING
(
SELECT Username , OrgID OrgID , 0 allow
FROM mydbr_userlogin ,Organization
) AS SOURCE
ON TARGET.Username = SOURCE.Username
AND TARGET.OrgID = SOURCE.OrgID
WHEN NOT MATCHED THEN INSERT
(
Username , 
OrgID , 
allow
)
VALUES
(
SOURCE.Username , 
SOURCE.OrgID , 
SOURCE.allow
);
*/
   DECLARE @retval INTEGER

   SELECT @retval = COUNT(*) from mydbr_userOrg where OrgID = @OrgID 
and LTRIM(RTRIM(Username)) = LTRIM(RTRIM(@inLogin))
and allow = 1

   RETURN @retval
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[f_demo_datetoQ]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[f_demo_datetoQ]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[f_demo_datetoQ] ( @dDate datetime )
RETURNS NVARCHAR(40)
AS
BEGIN
	return CAST( DATEPART(YEAR,@dDate) AS nvarchar)+ '' Q''+CAST( DATEPART(QUARTER,@dDate) AS nvarchar)
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_BegOfDay]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_BegOfDay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create function [dbo].[fn_BegOfDay](@inDate datetime)
returns datetime
as
begin
return dateadd(dd,0, datediff(dd,0,@inDate))
end


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_EndOfDay]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_EndOfDay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create function [dbo].[fn_EndOfDay](@inDate datetime)
returns datetime
as
begin
declare @ret datetime

set @ret=dateadd(ms,-5,dateadd(day,1,dateadd(ms,-datepart(ms,@inDate),dateadd(ss,-datepart(ss,@inDate),
    dateadd(mi,-datepart(mi,@inDate),dateadd(hh,-datepart(hh,@inDate),@inDate))))))
return @ret
end


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_collectioncenter]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_get_collectioncenter]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE function [dbo].[fn_get_collectioncenter](@visitid bigint)        
returns nvarchar(200)           
as        
begin        
declare @ccenter nvarchar(200)        
select @ccenter=c.clientname from patientinvsample ps inner join VisitClientMapping cm WITH(NOLOCK)          
on ps.PatientVisitID=cm.VisitID and ps.OrgID=cm.OrgID  inner join ClientMaster c With(NOLOCK)          
on cm.ClientID=c.ClientID and ps.OrgID=c.OrgID  inner join visitclientmapping vc on vc.clientid=c.clientid where vc.visitid=@visitid       
return @ccenter        
End

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_isstatus]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_get_isstatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE function [dbo].[fn_get_isstatus](@sampleid bigint)            
returns nvarchar(500)            
as            
begin            
declare @status nvarchar(500)             
set @status=(select TOP 1 displaytext from InvSampleStatusOrgmapping iso inner join sampletracker s on iso.invsamplestatusid=s.invsamplestatusid     
where s.sampleid=@sampleid and iso.orgid=s.orgid  
order by s.sampletrackerid desc  )  
return @status            
End

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getAge]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getAge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[fn_getAge] (@pDOB DATETIME)
RETURNS nvarchar(50)
AS
  BEGIN
      declare @Configvalue nvarchar(2)

      set @Configvalue=(select top 1 ConfigValue
                        from   ConfigOrgMaster (NOLOCK)
                        where  ConfigKeyID in(select ConfigKeyID
                                              from   ConfigKeyMaster (NOLOCK)
                                              where  ConfigKey = ''DecimalAge''))

      --set @Configvalue=''N''    
      DECLARE @NoofDays INT
      DECLARE @Age nvarchar(20)

      IF @Configvalue != ''Y''
        BEGIN
            IF ( @pDOB IS NULL )
              BEGIN
                  SET @Age = '' -''
              END
            ELSE IF YEAR(@pDOB) = ''1800''
              BEGIN
                  SELECT @Age = ''1800''
              END
            ELSE
              BEGIN
                  SELECT @NoofDays = DATEDIFF(DAY, ( @pDOB ), GETDATE())

                  IF( @NoofDays > 365 )
                    BEGIN
                        SELECT @Age = abs(@NoofDays / 365) --DATEDIFF(YEAR,(@pDOB),GETDATE())        

                        SET @Age = @Age + '' '' + ''Year(s)''
                    END
                  ELSE IF ( @NoofDays > 31
                       AND @NoofDays <= 365 )
                    BEGIN
                        SELECT @Age = DATEDIFF(MONTH, ( @pDOB ), GETDATE())

                        SET @Age = @Age + '' '' + ''Month(s)''
                    END
                  ELSE IF ( @NoofDays > 7
                       AND @NoofDays <= 31 )
                    BEGIN
                        SELECT @Age = DATEDIFF(WEEK, ( @pDOB ), GETDATE())

                        SET @Age = @Age + '' '' + ''Week(s)''
                    END
                  ELSE
                    BEGIN
                        SELECT @Age = DATEDIFF(DAY, ( @pDOB ), GETDATE())

                        SET @Age = @Age + '' '' + ''Day(s)''
                    END
              END
        END
      ELSE
        BEGIN
            select @Age = dbo.fn_getDecimalAge(@pDOB)
        END

      return @Age
  END




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getAge1]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getAge1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getAge1]
(
	@pDOB DATETIME,
	@Rdd DATETIME
)
RETURNS nvarchar(50)
AS
BEGIN

	DECLARE @NoofDays INT
	DECLARE @Age nvarchar(20)

	SELECT @NoofDays = DATEDIFF(DAY,(@pDOB),@Rdd)
	
	IF(@NoofDays > 365)
		BEGIN
			SELECT @Age = DATEDIFF(YEAR,(@pDOB),@Rdd)
			SET @Age = @Age + '' '' + ''Years''
		END
	ELSE IF (@NoofDays > 31 AND @NoofDays <= 365)
		BEGIN
			SELECT @Age = DATEDIFF(MONTH,(@pDOB),@Rdd)
			SET @Age = @Age + '' '' + ''Months''
		END
	ELSE IF (@NoofDays > 7 AND @NoofDays <= 31)
		BEGIN
			SELECT @Age = DATEDIFF(WEEK,(@pDOB),@Rdd)
			SET @Age = @Age + '' '' + ''Weeks''
		END
	ELSE
		BEGIN
			SELECT @Age = DATEDIFF(DAY,(@pDOB),@Rdd)
			SET @Age = @Age + '' '' + ''Days''
		END

	RETURN(@Age);

END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetAgeAtVisit]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetAgeAtVisit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE  FUNCTION [dbo].[fn_GetAgeAtVisit]         
(          
 @pDOB DATETIME,      
 @pVisitDate DATETIME        
        
)          
RETURNS nvarchar(50)          
AS          
BEGIN          
 declare @Configvalue nvarchar(2)    
 set @Configvalue=(select top 1 ConfigValue from ConfigOrgMaster where ConfigKeyID in(select ConfigKeyID from ConfigKeyMaster where ConfigKey=''DecimalAge''))    
-- set @Configvalue=''N''    
 DECLARE @NoofDays INT          
 DECLARE @Age nvarchar(20)         
 IF @Configvalue!=''Y''     
   BEGIN     
 IF (@pDOB IS NULL)          
  BEGIN          
   SET @Age = '' -''          
  END         
  ELSE IF YEAR(@pDOB) = ''1800''        
    BEGIN        
 SELECT @Age = ''1800''        
         
  END         
 ELSE          
  BEGIN          
          
   SELECT @NoofDays = DATEDIFF(DAY,(@pDOB),(@pVisitDate))          
             
   IF(@NoofDays > 365)          
    BEGIN          
     SELECT @Age =  abs(@NoofDays/365) --DATEDIFF(YEAR,(@pDOB),GETDATE())          
     SET @Age = @Age + '' '' + ''Year(s)''          
    END          
   ELSE IF (@NoofDays > 31 AND @NoofDays <= 365)          
    BEGIN          
     SELECT @Age = DATEDIFF(MONTH,(@pDOB),GETDATE())          
     SET @Age = @Age + '' '' + ''Month(s)''          
    END          
   ELSE IF (@NoofDays > 7 AND @NoofDays <= 31)          
    BEGIN          
     SELECT @Age = DATEDIFF(WEEK,(@pDOB),GETDATE())          
     SET @Age = @Age + '' '' + ''Week(s)''          
    END          
   ELSE IF (@NoofDays ! = 0)               
    BEGIN                
     SELECT @Age = DATEDIFF(DAY,(@pDOB),GETDATE())                
     SET @Age = @Age + '' '' + ''Day(s)''               
    END    
   ELSE          
    BEGIN          
     SELECT @Age = DATEDIFF(DAY,(@pDOB),@pVisitDate)                
     SET @Age = @Age + '' '' + ''Day(s)''          
    END          
  END       
  END    
      
  ELSE     
  BEGIN    
  declare @NumofDays nvarchar(50)    
  SELECT @NumofDays = Case    
       when DATEDIFF(day,@pDOB,(@pVisitDate)) > 365     
       then    
       cast(DATEDIFF(MM,(@pDOB),(@pVisitDate))/12 as nvarchar)+''.''+    
                   Case     
                   when (DATEDIFF(MM,(@pDOB),(@pVisitDate))) % 12 > 0     
                   then     
                   CAST ((DATEDIFF(MM,(@pDOB),(@pVisitDate))) % 12  as nvarchar)+'' Year(s)''    
                   Else    
     ''''    
                   End    
      when DATEDIFF(day,@pDOB,(@pVisitDate)) > 31 and DATEDIFF(day,@pDOB,(@pVisitDate)) < 365    
      then    
       cast(DATEDIFF(MM,(@pDOB),(@pVisitDate)) as nvarchar)+'' Month(s) ''    
      when DATEDIFF(day,@pDOB,(@pVisitDate)) > 7 and DATEDIFF(day,@pDOB,(@pVisitDate)) < 31    
      then    
       cast(DATEDIFF(WW,(@pDOB),(@pVisitDate)) as nvarchar)+'' Week(s) ''    
      Else    
       cast(DATEDIFF(DD,(@pDOB),(@pVisitDate)) as nvarchar)+'' Day(s) ''           
      End    
    
if (select substring(@NumofDays, charindex(''.'', @NumofDays) + 1,charindex(''.'', @NumofDays) + 1))=''''    
    
set @NumofDays=REPLACE(@NumofDays,''.'','' Year(s)'')    
    
set @Age=@NumofDays    
 END       
     
 RETURN(@Age);        
          
END   


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getAgeDecimalAge]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getAgeDecimalAge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create FUNCTION [dbo].[fn_getAgeDecimalAge] (@pDOB DATETIME,@orgid int)      
RETURNS nvarchar(50)      
AS      
  BEGIN      
      declare @Configvalue nvarchar(2)      
      
      set @Configvalue=(select top 1 ConfigValue      
                        from   ConfigOrgMaster (NOLOCK)      
                        where  ConfigKeyID in(select ConfigKeyID      
                                              from   ConfigKeyMaster (NOLOCK)      
                                              where  ConfigKey = ''DecimalAge'')and Orgid=@Orgid)      
      
             
      DECLARE @NoofDays INT      
      DECLARE @Age nvarchar(20)      
      
      IF @Configvalue != ''Y''      
        BEGIN      
            IF ( @pDOB IS NULL )      
              BEGIN      
                  SET @Age = '' -''      
              END      
            ELSE IF YEAR(@pDOB) = ''1800''      
              BEGIN      
                  SELECT @Age = ''1800''      
              END      
            ELSE      
              BEGIN      
                  SELECT @NoofDays = DATEDIFF(DAY, ( @pDOB ), GETDATE())      
      
                  IF( @NoofDays > 365 )      
                    BEGIN      
                        SELECT @Age = abs(@NoofDays / 365) --DATEDIFF(YEAR,(@pDOB),GETDATE())              
      
                        SET @Age = @Age + '' '' + ''Year(s)''      
                    END      
                  ELSE IF ( @NoofDays > 31      
                       AND @NoofDays <= 365 )      
                    BEGIN      
                        SELECT @Age = DATEDIFF(MONTH, ( @pDOB ), GETDATE())      
      
                        SET @Age = @Age + '' '' + ''Month(s)''      
                    END      
                  ELSE IF ( @NoofDays > 7      
                       AND @NoofDays <= 31 )      
                    BEGIN      
                        SELECT @Age = DATEDIFF(WEEK, ( @pDOB ), GETDATE())      
      
                        SET @Age = @Age + '' '' + ''Week(s)''      
                    END      
                  ELSE      
                    BEGIN      
                        SELECT @Age = DATEDIFF(DAY, ( @pDOB ), GETDATE())      
      
                        SET @Age = @Age + '' '' + ''Day(s)''      
                    END      
              END      
        END      
      ELSE      
        BEGIN      
            select @Age = dbo.fn_getDecimalAge(@pDOB)      
        END      
      
      return @Age      
  END      

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetBillerName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetBillerName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--File Header Comments 
--=======================================================================================
-- Copyright (C) 2007-2012 Attune Technologies, Adyar, Chennai
--========================================================================================
-- Purpose: To get the User name (Billed by) along with Saluation in the Receipt Print. Instead of JOIN
--          with User tables to get the name and salutation, this Function can be called. 
-- Author: Vijay TV
-- Date Created: 16-Mar-2011
--========================================================================================
-- File Change History (to be updated everytime this file is modified)
-- ---------------------------------------------------------------------------------------
--  Date            Worker                        Work Description
-- ---------------------------------------------------------------------------------------
--       
-- ---------------------------------------------------------------------------------------                              
CREATE FUNCTION [dbo].[fn_GetBillerName](@LoginID Bigint,@ContextInfo [UDT_Context] READONLY)  
RETURNS nvarchar(50)  
AS  
BEGIN  
 DECLARE @BillerName nvarchar(50)  
   
 SELECT @BillerName = S.DisplayText + U.Name FROM Users U inner join SalutationOrgMapping S on U.TitleCode = S.TitleID
 inner join @ContextInfo ctx1 on ctx1.OrgID=S.OrgID and ctx1.LanguageCode=S.LanguageCode    
 WHERE U.LoginID = @LoginID AND U.Status = ''A''  
 AND U.TitleCode = S.TitleID  
   
 Return LTRIM(RTRIM(@BillerName))  
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetDateTime]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetDateTime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[fn_GetDateTime]                          
(           
@pDateTime [datetime],                       
@pOrgID bigint              
)                          
RETURNS DATETIME                          
AS                          
BEGIN                          
 DECLARE @GetLocalDate DATETIME          
  DECLARE @GetLocalDate1 DATETIME                       
 Declare @TimeDiff INT                      
 --Declare @pOrgID int = 0,@pOrgAddressID int = 0                  
              
 Select @TimeDiff=TimeDifference from Organization where OrgID=@pOrgID --and AddressID=@pOrgAddressID                       
-- Select @TimeDiff                        
                           
 IF (@TimeDiff IS NULL OR @TimeDiff='''')                       
  BEGIN                          
    SELECT @GetLocalDate= @pDateTime                        
  END                          
 ELSE                          
  BEGIN       
       
  select @GetLocalDate1=DATEADD(Hh,-5, @pDateTime)       
   select @GetLocalDate1=DATEADD(Mi,-30, @GetLocalDate1)       
        
  SELECT @GetLocalDate=DATEADD(Hh, @TimeDiff , @GetLocalDate1)       
                          
  END                          
 RETURN(@GetLocalDate);                          
END;

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getdecimalage]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_getdecimalage]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Fn_getdecimalage] (@pDOB DATETIME)
RETURNS NVARCHAR(50)
AS
BEGIN
--Changed By Arivalagan.kk for leaf YEar--
DECLARE @NoofDays NVARCHAR(50)
DECLARE @febday NVARCHAR(3)
DECLARE @DaysInMonth AS TABLE
(
MthId int,
DaysInMonth INT
)
DECLARE @fday   INT,
@fmth   INT,
@fyear  INT,
@tday   INT,
@tmth   INT,
@tyear  INT,
@monchg INT,
@rday   INT,
@rmth   INT,
@ryear  INT
SELECT @febday = CASE Datepart(mm, Dateadd(dd, 1, Cast(( Cast(Datepart(YYYY, Getdate()) AS NVARCHAR(4))
+ ''0228'' ) AS DATETIME)))
WHEN 2 THEN Cast(29 AS NVARCHAR(3))
ELSE Cast(28 AS NVARCHAR(3))
END
---			   SELECT @febday
INSERT INTO @DaysInMonth
SELECT 1, 31
UNION ALL
SELECT 2,@febday
UNION ALL
SELECT 3,31
UNION ALL
SELECT 4,30
UNION ALL
SELECT 5,31
UNION ALL
SELECT 6,30
UNION ALL
SELECT 7,31
UNION ALL
SELECT 8,31
UNION ALL
SELECT 9,30
UNION ALL
SELECT 10,31
UNION ALL
SELECT 11,30
UNION ALL
SELECT 12,31
--SELECT @DaysInMonth
--SET @pDOB=CONVERT( NVARCHAR,@pDOB,102)
--SELECT @pDOB AS DOB
SELECT @fday = Datepart(dd, @pDOB)
SELECT @fmth = Datepart(MM, @pDOB)
SELECT @fyear = Datepart(YYYY, @pDOB)
SELECT @tday = Datepart(dd, Getdate())
SELECT @tmth = Datepart(MM, Getdate())
SELECT @tyear = Datepart(YYYY, Getdate())
--SELECT @tday AS tday 
--SELECT @tmth  AS tmth
--SELECT @tyear  AS tyear
--SELECT @fday AS fday
--SELECT @fmth AS fmth
--SELECT @fyear AS fyear 
--SELECT * FROM @DaysInMonth
IF( @tday < @fday )
BEGIN
if(@tmth=1)
BEGIN
SET @monchg =12
END
ELSE
BEGIN
SET @monchg = @tmth - 1
END
IF( @monchg < 0 )
BEGIN
SELECT @monchg = @tmth
END
SET @tday +=(SELECT [@DaysInMonth].DaysInMonth
FROM   @DaysInMonth
WHERE  [@DaysInMonth].MthId IN ( @monchg ))
SET @fmth += 1
END
--SELECT @tmth AS tmth
--SELECT @fmth AS fmth
--RETURN
IF( @tmth < @fmth )
BEGIN
SET @tmth+=12
SET @fyear+=1
END
--SELECT @tmth AS tmth
--SELECT @fmth AS fmth
SELECT @rday = @tday - @fday
SELECT @rmth = @tmth - @fmth
SELECT @ryear = @tyear - @fyear
--SELECT @rday AS rday 
--SELECT @rmth AS rmth
--SELECT @ryear AS ryear
--RETURN
IF( @ryear > 0
AND @rmth > 0 )
BEGIN
SELECT @NoofDays = Cast(@ryear AS NVARCHAR) + ''.''
+ Cast(@rmth AS NVARCHAR) + '' Year(s)''
END
IF( @ryear > 0 AND @rmth<=0 )
BEGIN
SELECT @NoofDays = Cast(@ryear AS NVARCHAR) + '' Year(s)''
END
IF( @rmth >0  AND @ryear<=0)
BEGIN
SELECT @NoofDays = Cast(@rmth AS NVARCHAR) + '' Month(s)''
END
IF( @rday > 0
AND @rmth <= 0
AND @ryear <= 0 )
BEGIN
IF( @rday > 7 )
BEGIN
SELECT @NoofDays = Cast((@rday/7 * 7)/7  AS VARCHAR)
+ '' Week(s)''
END
ELSE
BEGIN
SELECT @NoofDays = Cast(@rday AS VARCHAR) + '' Day(s)''
END
END
RETURN (ISNULL(@NoofDays,''ToDay''));
--Changed By Arivalagan.kk for leaf Year--
END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getDeptNameByFeeID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getDeptNameByFeeID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getDeptNameByFeeID]  
(   
 @OrgID int,  
 @pFeeID int,  
 @pBillingDetailID bigint  
)  
RETURNS nvarchar(255)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
  
     DECLARE @name nvarchar(255)  
      
     Select @name =   
  Case   
  WHEN (ID.DeptName!=''LAB'') Then ID.DeptName  
  Else ''LAB''  
  END   
 From InvDeptMaster ID INNER JOIN InvestigationOrgMapping IOM   
   ON ID.DeptID = IOM.DeptID  
   INNER JOIN InvRateMaster IRM ON IRM.ID=IOM.InvestigationID  
   INNER JOIN BillingDetails BD ON BD.FeeId=IRM.RateID  
 WHERE BD.FeeId=@pFeeID AND BD.BillingDetailsID=@pBillingDetailID and ID.OrgID=@OrgID  
  
     RETURN(ISNULL(@name,''Miscellaneous''));  
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getDOB]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getDOB]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getDOB]
(
	@pAgeVal INT,
	@pAgeUnits nchar(1)
)
RETURNS nvarchar(50)
AS
BEGIN
	DECLARE @pDOB DATETIME
	
	SET @pAgeVal = @pAgeVal * -1
 declare @CurrentDate as Datetime  = DATEADD(yy, DATEDIFF(yy,0,getdate()), 0)     
	
 IF(@pAgeUnits = ''D'')      
		BEGIN
			SELECT @pDOB= DATEADD(D, @pAgeVal, GETDATE())
		END
 ELSE IF(@pAgeUnits = ''W'')      
		BEGIN
			SELECT @pDOB= DATEADD(WEEK, @pAgeVal, GETDATE())
		END
 ELSE IF(@pAgeUnits = ''M'')      
		BEGIN
			SELECT @pDOB= DATEADD(M, @pAgeVal, GETDATE())
		END
	ELSE
		BEGIN
   SELECT @pDOB= DATEADD(YEAR, @pAgeVal, @CurrentDate)      
		END
		
	RETURN(@pDOB);
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetFinalBillID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetFinalBillID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[Fn_GetFinalBillID](@visitid INT)  
Returns nvarchar(200)   
AS  
BEGIN  
       DECLARE @FinalBillIDs NVARCHAR(200)
    SELECT @FinalBillIDs = COALESCE(@FinalBillIDs + '','', '''') + CAST(FinalBillID AS VARCHAR(20))
    FROM finalbill
    WHERE VisitId= @visitid
        return @FinalBillIDs   
        
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getForeName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getForeName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getForeName]
(
	@pLoginID bigint
)
RETURNS nvarchar(50)
AS
BEGIN

	DECLARE @roleName nvarchar(20)
	
	DECLARE @userName nvarchar(50)
	
	BEGIN
		SELECT @roleName = RoleName from Role r inner join LoginRole lr 
				on r.RoleID = lr.RoleID where LoginID = @pLoginID
	END
	IF(@roleName = ''Physician'')
		BEGIN
			SELECT @userName = ''Dr.'' + PhysicianName FROM Physician WHERE LoginID = @pLoginID
		END
	ELSE IF(@roleName = ''Nurse'')
		BEGIN
			SELECT @userName = NurseName FROM Nurse WHERE LoginID = @pLoginID
		END
	ELSE
		BEGIN
			SELECT @userName = Name FROM Users WHERE LoginID = @pLoginID
		END
	RETURN(@userName);
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getFullDayDateDiff]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getFullDayDateDiff]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getFullDayDateDiff]        
(        
 @pStartDate DATETIME,        
 @pEndDate DATETIME        
)        
--Select dbo.[fn_getFullDayDateDiff](''27/05/2010 12:34 PM '',''27/05/2010 12:39 PM'')         
--Select dbo.[fn_getFullDayDateDiff](''06 Mar 2010 19:29:07.203'',''08 Mar 2010 09:29:07.203'')         
RETURNS decimal(18,2)        
AS        
BEGIN        
       
SELECT @pStartDate = (CASE WHEN @pStartDate = ''1900-01-01 00:00:00.000'' THEN GETDATE() ELSE @pStartDate END) 
SELECT @pEndDate = (CASE WHEN @pEndDate = ''1900-01-01 00:00:00.000'' THEN GETDATE() ELSE @pEndDate END) 
 DECLARE @daysMain decimal(18,6)        
       
 SELECT @daysMain = DATEDIFF(MINUTE,@pStartDate,@pEndDate)        
     
 SELECT @daysMain = @daysMain/(24*60)        
     
  SELECT @daysMain = (CEILING(@daysMain))       
 RETURN(@daysMain);        
        
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getGrpDept]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getGrpDept]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--dbo.[fn_getProcessingLocation] 67,79,''GRP''              
              
              
CREATE Function [dbo].[fn_getGrpDept]               
(  @OrgID BIGINT,              
   @ID INT,              
   @Type nvarchar(50)              
)              
RETURNS nvarchar(50)                
WITH EXECUTE AS CALLER              
As               
Begin              
Declare @tblTempGrp Table(InvID Bigint,Parent nchar(1))              
Declare @tblGrpRPkgPL Table(DeptID int,NCount int)              
Declare @tblMaxGrpRPkgPL Table(DeptID int)              
Declare @pLocation nvarchar(50)              
IF(@Type=''GRP'')              
Begin              
 ;WITH C1 as                                                                                                                             
 (                                                                                                                            
 Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                                            
 FROM InvGroupMaster OI                                                                                                                             
 INNER JOIN InvOrgGroup IOG on IOG.AttGroupID = OI.GroupID                                                                                                                          
 INNER JOIN InvGroupMapMaster IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                            
              
 WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                            
              
 UNION ALL                                                                                                                            
              
 Select IGM.InvestigationID As InvID,IGM.Parent                                                                                                                            
 FROM C1 OI                                                                              
 INNER JOIN InvOrgGroup IOG on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                              
 INNER JOIN InvGroupMapMaster IGM  ON OI.InvID=IGM.GroupID                                                                                                                             
 WHERE  OI.Parent=''Y''                                                                                                                         
 )              
              
 Insert Into @tblTempGrp(InvID,Parent)                                             
 SELECT InvID,Parent                                                                                                                           
 FROM C1               
END               
Else IF(@Type=''PKG'')              
Begin              
Declare @InvGroupMapMasterForOrderedPkg  Table                                                            
(                                                    
 GroupID int,                                                            
 InvestigationID bigint,                                                            
 Parent nvarchar                                                          
)                                                            
insert Into @InvGroupMapMasterForOrderedPkg                                                            
select IOG.OrgGroupID,IPM.ID,Case When IPM.Type=''GRP'' Then ''Y'' Else ''N'' End As Parent  from InvGroupMaster OI                                                             
INNER JOIN InvOrgGroup IOG ON IOG.AttGroupID=OI.GroupID                                                             
INNER JOIN InvPackageMapping IPM ON IPM.PackageID=IOG.OrgGroupID And IPM.Type In(''INV'',''GRP'')                                    
Where OI.Type=''PKG'' AND OI.GroupID=@ID  AND IOG.OrgID=@OrgID          
              
;WITH C2 as                              
(                                         
Select IGM.InvestigationID  As InvID,IGM.Parent                                                                              
FROM InvGroupMaster OI                                                                                   
INNER JOIN InvOrgGroup IOG on IOG.AttGroupID = OI.GroupID               
INNER JOIN @InvGroupMapMasterForOrderedPkg IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                            
WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                            
              
UNION ALL                                                                                                                            
              
Select IGM.InvestigationID as InvID,CONVERT(nvarchar(1),IGM.Parent) As Parent                                                                                                                            
FROM C2 OI                                                  
INNER JOIN InvOrgGroup IOG on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                              
INNER JOIN InvGroupMapMaster IGM  ON OI.InvID=IGM.GroupID                                                                                            
WHERE  OI.Parent=''Y''                                                                           
)              
              
Insert Into @tblTempGrp(InvID,Parent)                                             
SELECT InvID,Parent                                                                                                                           
FROM C2               
END              
              
 insert into @tblGrpRPkgPL(DeptID,NCount)              
 Select IOM.DeptID,Count(*) from @tblTempGrp t Inner Join InvestigationOrgMapping IOM On t.InvID=IOM.InvestigationID               
 Where IOM.OrgID=@OrgID And t.Parent!=''Y''              
 group by  IOM.DeptID              
              
 Insert into @tblMaxGrpRPkgPL              
 select Top 1 DeptID from @tblGrpRPkgPL order by NCount  Desc             
              
 select @pLocation=OA.DeptName from InvDeptMaster OA Inner Join @tblMaxGrpRPkgPL t On t.DeptID=OA.DeptID              
 Return @pLocation              
End  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getHalfDayDateDiff]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getHalfDayDateDiff]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getHalfDayDateDiff]        
(        
 @pStartDate DATETIME,        
 @pEndDate DATETIME        
)        
--Select dbo.fn_getHalfDayDateDiff(''May  5 2010 10:20:00:000PM'',''May  6 2010 10:28:00:000AM'')         
--Select dbo.fn_getHalfDayDateDiff(''06 Mar 2010 19:29:07.203'',''08 Mar 2010 09:29:07.203'')         
RETURNS decimal(18,2)        
AS        
BEGIN        
 DECLARE @daysMain decimal(18,6)        
SELECT @pStartDate = (CASE WHEN @pStartDate = ''1900-01-01 00:00:00.000'' THEN GETDATE() ELSE @pStartDate END) 
SELECT @pEndDate = (CASE WHEN @pEndDate = ''1900-01-01 00:00:00.000'' THEN GETDATE() ELSE @pEndDate END) 

 SELECT @daysMain = DATEDIFF(MINUTE,@pStartDate,@pEndDate)        
     
 SELECT @daysMain = @daysMain/(24*60)        
     
  SELECT @daysMain = (CEILING(@daysMain/0.5))*0.5      
 RETURN(@daysMain);        
        
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetIntendReceivedQuantity]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetIntendReceivedQuantity]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetIntendReceivedQuantity] (@pProductID bigint,@pOrgID int,@IntendID bigint)
RETURNS DECIMAL(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN
    DECLARE @InHandQty DECIMAL(18,2)
	
	 
     SELECT @InHandQty= SI.Receivedquantity
						FROM IntendDetail SI 
						WHERE SI.OrgID=@pOrgID 
							AND	SI.ProductID=@pProductID 
							--AND	SI.LocationID=COALESCE(@pLocationID,SI.LocationID) and   DATEDIFF(M,@EmpDate,SI.ExpiryDate) >= 0
						--GROUP BY ProductID
						
      SET @InHandQty = ISNULL(@InHandQty,0)
     RETURN(@InHandQty);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getINVMaxMinFinalBBillNo]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getINVMaxMinFinalBBillNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getINVMaxMinFinalBBillNo]          
(   @pDateTime datetime,          
    @pLocID int,    
    @pOrgID int)          
RETURNS nvarchar(255)          
WITH EXECUTE AS CALLER          
AS          
BEGIN          
--declare @pDateTime datetime,@pLocID int        
DECLARE @pFromTime  datetime          
DECLARE @ToDateTime datetime        
        
--set  @pDateTime=''10/11/2010''        
--set @pLocID=1        
          
DECLARE @pFromBillID nvarchar(30)           
DECLARE @ToBillID nvarchar(30)           
          
          
SET @pFromTime = CONVERT(DATETIME,CONVERT(nvarchar,@pDateTime,103) + '' 00:00:00'')                              
SET @ToDateTime = CONVERT(DATETIME,CONVERT(nvarchar,@pDateTime,103) + '' 23:59:59.998'')                              
           
DECLARE @name nvarchar(255)          
                  
SELECT @pFromBillID=MIN(FinalBillID),@ToBillID=Max(FinalBillID)  from FinalBill F           
 INNER JOIN StockOutFlow B on F.FinalBillID=B.BillID          
  where LocationID=COALESCE(@pLocID,B.LocationID) and B.OrgID=@pOrgId       
  and F.CreatedAt  between @pFromTime        and @ToDateTime      
            
            
 -- SELECT @ToBillID=Max(FinalBillID) from FinalBill F           
 --INNER JOIN StockOutFlow B on F.FinalBillID=B.BillID          
 -- where LocationID=COALESCE(@pLocID,B.LocationID)          
 -- and CONVERT(DATETIME,CONVERT(nvarchar,F.CreatedAt,103) + '' 23:59:59.998'')=@ToDateTime              
             
 SELECT @pFromBillID=BillNumber FROM FinalBill where FinalBillID=@pFromBillID          
 SELECT @ToBillID=BillNumber FROM FinalBill where FinalBillID=@ToBillID          
           
 SELECT @name =convert (nvarchar,@pFromBillID)+''-''+ convert (nvarchar,@ToBillID)          
--SELECT @ToBillID        
     RETURN(@name);          
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getinvoicedueamt]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_getinvoicedueamt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Fn_getinvoicedueamt] (@InvoiceReceiptID VARCHAR(50),
                                             @InvoiceID        BIGINT)
RETURNS @DueAmt TABLE (
  DueAmt        DECIMAL(18, 2),
  InvoiceID     BIGINT,
  ReceiptNumber VARCHAR(50))
AS
  BEGIN
      DECLARE @Sno INT =1
      DECLARE @Rno INT
      DECLARE @amt DECIMAL (18, 2) =0
      DECLARE @Rec TABLE
        (
           InvoiceID      BIGINT,
           InvoiceAmount  DECIMAL(18, 2),
           ReceivedAmount DECIMAL(18, 2),
           DueAmount      DECIMAL(18, 2),
           ReceiptNumber  BIGINT
        )

      SELECT @Rno = Max(Sno)
      FROM   (SELECT InvoiceAmount,
                     ReceivedAmount,
                     ReceiptNumber,
                     Row_number()
                       OVER(
                         ORDER BY CreatedAt) Sno
              FROM   InvoiceReceipts
              WHERE  --ReceiptNumber =@InvoiceReceiptID AND         
               InvoiceID = @InvoiceID --ORDER BY CreatedAt             
             )t

      WHILE ( @Sno <= @Rno )
        BEGIN
            INSERT INTO @Rec
                        (InvoiceID,
                         InvoiceAmount,
                         ReceivedAmount,
                         DueAmount,
                         ReceiptNumber)
            SELECT InvoiceID,
                   InvoiceAmount,
                   ReceivedAmount,
                   InvoiceAmount - ( ReceivedAmount + @amt ),
                   ReceiptNumber
            FROM   (SELECT InvoiceID,
                           InvoiceAmount,
                           ReceivedAmount,
                           Row_number()
                             OVER(
                               ORDER BY CreatedAt) Sno,
                           ReceiptNumber
                    FROM   InvoiceReceipts
                    WHERE  --ReceiptNumber =@InvoiceReceiptID AND         
                     InvoiceID = @InvoiceID--ORDER BY CreatedAt             
                   )t
            WHERE  Sno = @Sno

            SELECT @amt += ReceivedAmount
            FROM   (SELECT InvoiceAmount,
                           ReceivedAmount,
                           Row_number()
                             OVER(
                               ORDER BY CreatedAt) Sno
                    FROM   InvoiceReceipts
                    WHERE  --ReceiptNumber =@InvoiceReceiptID AND         
                     InvoiceID = @InvoiceID --ORDER BY CreatedAt             
                   )t
            WHERE  Sno = @Sno

            SET @Sno=@Sno + 1

            INSERT @DueAmt
                   (DueAmt,
                    InvoiceID,
                    ReceiptNumber)
            SELECT DueAmount,
                   InvoiceID,
                   ReceiptNumber
            FROM   @Rec
            WHERE  ReceiptNumber = @InvoiceReceiptID
        --SELECT * FROM @Rec             
        END

      RETURN
  END; 




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getKit_SellingPrice]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getKit_SellingPrice]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getKit_SellingPrice]  
(                                  
 @pIsKitType nvarchar(15),  
 @pProductID BIGINT,  
 @pBatchNo   nvarchar(50),   
 @pLocationID INT,  
 @pOrgID INT   
)  
RETURNS DECIMAL(18,2)                                                     
WITH EXECUTE AS CALLER                                                     
AS                                                     
BEGIN    
DECLARE @IsCreditBill nvarchar(1)  
DECLARE @pSellingPrice decimal(18,2)  
SET @pSellingPrice =0  
  
--SELECT @IsCreditBill=IsCreditBill FROM FinalBill WHERE VisitID =@pVisitID AND OrgID =@pOrgID   
  
--IsReimbursable =''Y''  
IF @pIsKitType =''Y''  
BEGIN   
SELECT @pSellingPrice = CAST(SUM(ISNULL(K.Quantity * K.SellingPrice,0))AS Decimal(18,2))  FROM KitPrepMasterDetails K  
INNER JOIN KitPrepMaster KM ON K.KitID =KM.KitID AND K.IsReimbursable =''Y'' AND K.LocationID = KM.LocationID   
WHERE KM.MasterKitID =@pProductID AND KM.KitBatchNo =@pBatchNo AND KM.OrgID = @pOrgID  
AND KM.LocationID =@pLocationID   
  
END  
ELSE  
BEGIN   
SELECT @pSellingPrice = CAST(SUM(ISNULL(K.Quantity * K.SellingPrice,0))AS Decimal(18,2))  FROM KitPrepMasterDetails K  
INNER JOIN KitPrepMaster KM ON K.KitID =KM.KitID AND K.LocationID = KM.LocationID   
WHERE KM.MasterKitID =@pProductID AND KM.KitBatchNo =@pBatchNo AND KM.OrgID = @pOrgID  
AND KM.LocationID =@pLocationID   
END   
RETURN(@pSellingPrice);   
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetLoginName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetLoginName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE function [dbo].[Fn_GetLoginName](@AssignNo bigint)      
returns nvarchar(max)      
as       
begin      
 declare @rolename  nvarchar(max)      
 declare @GetRole table(rowno int identity(1,1),RoleName nvarchar(max),LoginName nvarchar(max))      
 insert into @GetRole(RoleName,LoginName)     
 ------------------Get Table wise Record ----------------------    
 select RoleName,LoginName from (select ROW_NUMBER()over(partition by SORT.RoleID,LO.loginid order by LO.loginid asc ) as rowno,SORT.RoleID,SORT.LoginID,RO.Description as RoleName,LO.LoginName from SortedOrderTest as SORT inner join Role as RO    
 on SORT.RoleID=RO.RoleID inner join  Login as LO    
 on SORT.LoginID=LO.loginID where SORT.AccessionNumber=@AssignNo) TEMP where rowno=1      
 declare @rocount int       
 select @rocount=COUNT(LoginName) from @GetRole      
 declare @count int =1      
 set @rolename=''<table style="border-style: solid;border-color: #A9BCF5;background-color:#F5A9A9">''     
      
 if(@rocount=0)      
 begin      
  set @rolename=@rolename+''<tr><td style="border: 1px solid black"></td><td style="border: 1px solid black"></td></tr>''      
 end       
 while(@rocount>0)      
 begin      
 declare @Role nvarchar(max)    
 declare @LoginName nvarchar(max)    
 select @LoginName=LoginName,@Role=RoleName from @GetRole where rowno=@count    
   set @rolename=@rolename+''<tr><td style="border: 1px solid black">''+@Role+''</td><td style="border: 1px solid black">''+@LoginName+''</td></tr>''      
         
  set @count=@count+1      
  set @rocount=@rocount-1      
 end       
       
 set @rolename=@rolename+''</table>''      
       
       
 return @rolename      
end



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getMappedStatus]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getMappedStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getMappedStatus]                
(                    
 @TaskActionID int,                  
 @MappingType nvarchar(100),           
 @OrgID int                
)                 
RETURNS @Status TABLE (Status nvarchar(100))                  
BEGIN             
 IF Exists(select 1 from TaskEntityMap where TaskActionID=@TaskActionID And MappingType=@MappingType And OrgID=@OrgID)            
 BEGIN          
 IF(@MappingType=''InvestigationStatus'')          
  BEGIN           
   INSERT INTO @Status                 
   select InvS.Status from TaskEntityMap TEM             
   Inner Join InvestigationStatus InvS On TEM.MappingID=InvS.InvestigationStatusID             
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND TEM.OrgID=@OrgID          
  END          
 ELSE          
  BEGIN           
   INSERT INTO @Status                 
   select InvS.InvSampleStatusDesc from TaskEntityMap TEM             
   Inner Join InvSampleStatusmaster InvS On TEM.MappingID=InvS.InvSampleStatusID             
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND OrgID=@OrgID          
  END          
 END            
 ELSE            
 BEGIN           
  IF(@MappingType=''InvestigationStatus'')          
  BEGIN            
   INSERT INTO @Status                 
   select InvS.Status from TaskEntityMap TEM             
   Inner Join InvestigationStatus InvS On TEM.MappingID=InvS.InvestigationStatusID             
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND TEM.OrgID Is NULL           
  END          
  --ELSE          
  -- BEGIN          
  --    INSERT INTO @Status                 
  --    select InvS.InvSampleStatusDesc from TaskEntityMap TEM             
  --    Inner Join InvSampleStatusmaster InvS On TEM.MappingID=InvS.InvSampleStatusID             
  --    where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND OrgID Is NULL           
  -- END          
      
  ELSE IF(@MappingType=''HorizontalEnterResultStatus'')          
  BEGIN            
   INSERT INTO @Status                 
   select InvS.Status from TaskEntityMap TEM             
   Inner Join InvestigationStatus InvS On TEM.MappingID=InvS.InvestigationStatusID             
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND TEM.OrgID Is NULL           
  END          
   ELSE          
   BEGIN          
  INSERT INTO @Status                 
   select InvS.InvSampleStatusDesc from TaskEntityMap TEM             
   Inner Join InvSampleStatusmaster InvS On TEM.MappingID=InvS.InvSampleStatusID             
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND OrgID Is NULL           
   END          
 END             
RETURN                  
END  

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getMappedStatus_1]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getMappedStatus_1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--SELECT dbo.fn_getMappedStatus_1 ( 83,''InvestigationStatus'',67 )
CREATE FUNCTION [dbo].[fn_getMappedStatus_1]         
(              
 @TaskActionID int,            
 @MappingType nvarchar(100),     
 @OrgID int          
)           
RETURNS @Status TABLE (Status nvarchar(100))            
BEGIN       
 IF Exists(select 1 from TaskEntityMap where TaskActionID=@TaskActionID And MappingType=@MappingType And OrgID=@OrgID)      
 BEGIN    
 IF(@MappingType=''InvestigationStatus'')    
  BEGIN     
   INSERT INTO @Status           
   select InvS.Status from TaskEntityMap TEM       
   Inner Join InvestigationStatus InvS On TEM.MappingID=InvS.InvestigationStatusID       
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND TEM.OrgID=@OrgID    
  END    
 ELSE    
  BEGIN     
   INSERT INTO @Status           
   select InvS.InvSampleStatusDesc from TaskEntityMap TEM       
   Inner Join InvSampleStatusmaster InvS On TEM.MappingID=InvS.InvSampleStatusID       
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND OrgID=@OrgID    
  END    
 END      
 ELSE      
 BEGIN     
  IF(@MappingType=''InvestigationStatus'')    
  BEGIN      
   INSERT INTO @Status           
   select InvS.Status from TaskEntityMap TEM       
   Inner Join InvestigationStatus InvS On TEM.MappingID=InvS.InvestigationStatusID       
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND TEM.OrgID Is NULL     
  END    
   ELSE    
   BEGIN    
  INSERT INTO @Status           
   select InvS.InvSampleStatusDesc from TaskEntityMap TEM       
   Inner Join InvSampleStatusmaster InvS On TEM.MappingID=InvS.InvSampleStatusID       
   where TEM.TaskActionID=@TaskActionID And  TEM.MappingType=@MappingType AND OrgID Is NULL     
   END    
     
 END       
RETURN            
END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getname]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getname]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[fn_getname](@visitid INT)
Returns nvarchar(100)

AS
BEGIN
	Declare @name nvarchar(100)
	SELECT @name=coalesce(@name,name+'','','''') from OrderedInvestigations OI ,PatientVisit PV where OI.VisitID= PV.PatientVisitId and visitid=@visitid

	REturn @name
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getNameByLoginID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getNameByLoginID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create FUNCTION [dbo].[fn_getNameByLoginID]  
(  
 @pLoginID bigint,@ContextInfo [UDT_Context] READONLY  
)  
RETURNS nvarchar(50)  
AS  
BEGIN  
  
 DECLARE @roleName nvarchar(20)  
   
 DECLARE @userName nvarchar(50)  
   
 BEGIN  
  SELECT @roleName = RoleName from Role r inner join LoginRole lr   
    on r.RoleID = lr.RoleID where LoginID = @pLoginID  
 END  
 IF(@roleName = ''Physician'')  
  BEGIN  
   --SELECT @userName = ''Dr.'' + PhysicianName FROM Physician WHERE LoginID = @pLoginID  
     
   SELECT @userName=S.DisplayText+'' ''+ p.PhysicianName FROM Physician p  
     JOIN SalutationOrgMapping S on p.TitleCode = S.TitleID
 inner join @ContextInfo ctx1 on ctx1.OrgID=S.OrgID and ctx1.LanguageCode=S.LanguageCode     
     WHERE p.LoginID = @pLoginID  
  END  
 ELSE IF(@roleName = ''Nurse'')  
  BEGIN  
   --SELECT @userName = NurseName FROM Nurse WHERE LoginID = @pLoginID  
   SELECT @userName=S.DisplayText+'' ''+ NurseName FROM Nurse N  
     JOIN SalutationOrgMapping S on N.TitleCode = S.TitleID
 inner join @ContextInfo ctx1 on ctx1.OrgID=S.OrgID and ctx1.LanguageCode=S.LanguageCode   
     WHERE N.LoginID = @pLoginID  
  END  
 ELSE  
  BEGIN  
   --SELECT @userName = Name FROM Users WHERE LoginID = @pLoginID  
     
    SELECT  @userName=S.DisplayText+'' ''+Name FROM Users U  
      JOIN SalutationOrgMapping S on U.TitleCode = S.TitleID
 inner join @ContextInfo ctx1 on ctx1.OrgID=S.OrgID and ctx1.LanguageCode=S.LanguageCode   
         WHERE U.LoginID = @pLoginID  
  END  
 RETURN(@userName);  
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getNextID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getNextID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getNextID]
(		@OrgID BIGINT,
		@IDType nvarchar(5))
RETURNS BIGINT
WITH EXECUTE AS CALLER
AS
BEGIN
/* ID Types
	1) PAT-- Patient Number 
	2) BLN-- Bill Number
	3) IPN-- Inpatient Number
	4) PVN-- Visit Number
*/
     DECLARE @MaxNumber BIGINT
    
     IF(@IDType=''PAT'')
     BEGIN
        SELECT @MaxNumber = PatientNumber from IDMaster WHERE OrgID=@OrgID
     END
     ELSE IF(@IDType=''BLN'')
     BEGIN
        SELECT @MaxNumber = BillNumber from IDMaster WHERE OrgID=@OrgID
     END
     ELSE IF(@IDType=''IPN'')
     BEGIN
        SELECT @MaxNumber = IPNumber from IDMaster WHERE OrgID=@OrgID
     END

	ELSE IF(@IDType=''PVN'')
     BEGIN
        SELECT @MaxNumber = VisitNumber from IDMaster WHERE OrgID=@OrgID
     END
     
     SELECT @MaxNumber = ISNULL(@MaxNumber,0)+1
     
     RETURN @MaxNumber
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetOrderedOrggroupID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetOrderedOrggroupID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create function [dbo].[fn_GetOrderedOrggroupID]      
(      
@pOrderedOrgID int,      
@pPerformedOrgID Int,      
@pPerformedOrgGroupID Int      
)      
Returns  Int      
As      
Begin      
Declare @attGroupID Int      
Declare @OrderedOrgGroupID Int      
select @attGroupID=AttGroupID from InvOrgGroup where OrgGroupID=@pPerformedOrgGroupID And OrgID=@pPerformedOrgID      
select @OrderedOrgGroupID=OrgGroupID from InvOrgGroup where AttGroupID=@attGroupID and OrgID=@pOrderedOrgID      
Return @OrderedOrgGroupID      
End



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getOutSourceLocation]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getOutSourceLocation]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'


Create Function [dbo].[fn_getOutSourceLocation]     

(  @OrgID BIGINT,                  

   @ID INT,                  

   @Type nvarchar(50),                  

   @ContextInfo [UDT_Context] READONLY
)                  

RETURNS BigInt                    

WITH EXECUTE AS CALLER                  

As                   

Begin                  

DECLARE @LocationID BIGINT

SELECT @LocationID=LocationID FROM @ContextInfo

Declare @tblTempGrp Table(InvID Bigint,Parent nchar(1))                  

Declare @tblGrpRPkgPL Table(ProLocID Bigint,NCount int)                  

Declare @tblMaxGrpRPkgPL Table(ProLocID Bigint)                  

Declare @pLocationID Bigint                  

IF(@Type=''INV'' OR @Type = ''GRP'')                  

Begin    

 Select @pLocationID=ProcessingAddressID From InvestigationLocationMapping ILM (NOLOCK)                   

 Where ILM.OrgID=@OrgID AND ILM.InvestigationID=@ID  AND ILM.Type=12 AND ILM.LocationID=@LocationID AND ILM.FeeType=@Type     

END    

--IF(@Type=''GRP'')                  

--Begin                  

-- ;WITH C1 as                                                                                                                                 

-- (                                                                                                                                

-- Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                                                

-- FROM InvGroupMaster OI                                                                                                                                 

-- INNER JOIN InvOrgGroup IOG on IOG.AttGroupID = OI.GroupID                                                                                                                              

-- INNER JOIN InvGroupMapMaster IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                                

                  

-- WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                                

                  

-- UNION ALL                                                                                                                                

                  

-- Select IGM.InvestigationID As InvID,IGM.Parent                                                                                                                                

-- FROM C1 OI                                                                                  

-- INNER JOIN InvOrgGroup IOG on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                                  

-- INNER JOIN InvGroupMapMaster IGM  ON OI.InvID=IGM.GroupID                                                                                                                                 

-- WHERE  OI.Parent=''Y''                                                                                                                             

-- )                  

                  

-- Insert Into @tblTempGrp(InvID,Parent)                                                 

-- SELECT InvID,Parent                                                                                                                               

-- FROM C1                   

--END                   

--Else 
IF(@Type=''PKG'')                  

Begin                  

Declare @InvGroupMapMasterForOrderedPkg  Table                                                                

(                                                        

 GroupID int,                                                                

 InvestigationID bigint,                                                                

 Parent nvarchar                                                              

)                                                                

insert Into @InvGroupMapMasterForOrderedPkg                     

select IOG.OrgGroupID,IPM.ID,Case When IPM.Type=''GRP'' Then ''Y'' Else ''N'' End As Parent  from InvGroupMaster OI (NOLOCK)                                                                

INNER JOIN InvOrgGroup IOG (NOLOCK) ON IOG.AttGroupID=OI.GroupID                                                                 

INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID And IPM.Type In(''INV'',''GRP'')                                        

Where OI.Type=''PKG'' AND OI.GroupID=@ID  AND IOG.OrgID=@OrgID              

                  

;WITH C2 as                                  

(                                             

Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                  

FROM InvGroupMaster OI (NOLOCK)                                                                                       

INNER JOIN InvOrgGroup IOG (NOLOCK) on IOG.AttGroupID = OI.GroupID                   

INNER JOIN @InvGroupMapMasterForOrderedPkg IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                                

WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                                

                  

UNION ALL                                                                                                                                

                  

Select IGM.InvestigationID as InvID,CONVERT(nvarchar(1),IGM.Parent) As Parent                                                                                                                                

FROM C2 OI                                                      

INNER JOIN InvOrgGroup IOG (NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                                  

INNER JOIN InvGroupMapMaster IGM (NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                                

WHERE  OI.Parent=''Y''                                                                               

)                  

                  

Insert Into @tblTempGrp(InvID,Parent)                                                 

SELECT InvID,Parent                                                                                                                               

FROM C2                   

END                  

                  

 insert into @tblGrpRPkgPL(ProLocID,NCount)                  

 Select ILM.ProcessingAddressID,Count(*) from @tblTempGrp t Inner Join InvestigationLocationMapping ILM (NOLOCK) On t.InvID=ILM.InvestigationID                   

 Where ILM.OrgID=@OrgID And t.Parent!=''Y'' AND ILM.Type=12                  

 group by  ILM.ProcessingAddressID                  

                  

 Insert into @tblMaxGrpRPkgPL                  

 select Top 1 ProLocID from @tblGrpRPkgPL order by NCount  Desc                 

 IF(@Type=''PKG'')     

 BEGIN                

 select @pLocationID=ProLocID from  @tblMaxGrpRPkgPL t                  

 END    

 set @pLocationID=Isnull(@pLocationID,-1)    

 Return @pLocationID                  

End 

 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getOutSourceLocation1]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getOutSourceLocation1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

CREATE Function [dbo].[fn_getOutSourceLocation1]     

(  @OrgID BIGINT,                  

   @ID INT,                  

   @Type nvarchar(50),                  

   @ContextInfo [UDT_Context] READONLY
)                  

RETURNS BigInt                    

WITH EXECUTE AS CALLER                  

As                   

Begin                  

DECLARE @LocationID BIGINT

SELECT @LocationID=LocationID FROM @ContextInfo

Declare @tblTempGrp Table(InvID Bigint,Parent nchar(1))                  

Declare @tblGrpRPkgPL Table(ProLocID Bigint,NCount int)                  

Declare @tblMaxGrpRPkgPL Table(ProLocID Bigint)                  

Declare @pLocationID Bigint                  

IF(@Type=''INV'' OR @Type = ''GRP'')                  

Begin    

 Select @pLocationID=ProcessingAddressID From InvestigationLocationMapping ILM (NOLOCK)                   

 Where ILM.OrgID=@OrgID AND ILM.InvestigationID=@ID  AND ILM.Type=12 AND ILM.LocationID=@LocationID AND ILM.FeeType=@Type     

END    

--IF(@Type=''GRP'')                  

--Begin                  

-- ;WITH C1 as                                                                                                                                 

-- (                                                                                                                                

-- Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                                                

-- FROM InvGroupMaster OI                                                                                                                                 

-- INNER JOIN InvOrgGroup IOG on IOG.AttGroupID = OI.GroupID                                                                                                                              

-- INNER JOIN InvGroupMapMaster IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                                

                  

-- WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                                

                  

-- UNION ALL                                                                                                                                

                  

-- Select IGM.InvestigationID As InvID,IGM.Parent                                                                                                                                

-- FROM C1 OI                                                                                  

-- INNER JOIN InvOrgGroup IOG on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                                  

-- INNER JOIN InvGroupMapMaster IGM  ON OI.InvID=IGM.GroupID                                                                                                                                 

-- WHERE  OI.Parent=''Y''                                                                                                                             

-- )                  

                  

-- Insert Into @tblTempGrp(InvID,Parent)                                                 

-- SELECT InvID,Parent                                                                                                                               

-- FROM C1                   

--END                   

--Else 
IF(@Type=''PKG'')                  

Begin                  

Declare @InvGroupMapMasterForOrderedPkg  Table                                                                

(                                                        

 GroupID int,                                                                

 InvestigationID bigint,                                                                

 Parent nvarchar                                                              

)                                                                

insert Into @InvGroupMapMasterForOrderedPkg                     

select IOG.OrgGroupID,IPM.ID,Case When IPM.Type=''GRP'' Then ''Y'' Else ''N'' End As Parent  from InvGroupMaster OI (NOLOCK)                                                                

INNER JOIN InvOrgGroup IOG (NOLOCK) ON IOG.AttGroupID=OI.GroupID                                                                 

INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID And IPM.Type In(''INV'',''GRP'')                                        

Where OI.Type=''PKG'' AND OI.GroupID=@ID  AND IOG.OrgID=@OrgID              

                  

;WITH C2 as                                  

(                                             

Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                  

FROM InvGroupMaster OI (NOLOCK)                                                                                       

INNER JOIN InvOrgGroup IOG (NOLOCK) on IOG.AttGroupID = OI.GroupID                   

INNER JOIN @InvGroupMapMasterForOrderedPkg IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                                

WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                                

                  

UNION ALL                                                                                                                                

                  

Select IGM.InvestigationID as InvID,CONVERT(nvarchar(1),IGM.Parent) As Parent                                                                                                                                

FROM C2 OI                                                      

INNER JOIN InvOrgGroup IOG (NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                                  

INNER JOIN InvGroupMapMaster IGM (NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                                

WHERE  OI.Parent=''Y''                                                                               

)                  

                  

Insert Into @tblTempGrp(InvID,Parent)                                                 

SELECT InvID,Parent                                                                                                                               

FROM C2                   

END                  

                  

 insert into @tblGrpRPkgPL(ProLocID,NCount)                  

 Select ILM.ProcessingAddressID,Count(*) from @tblTempGrp t Inner Join InvestigationLocationMapping ILM (NOLOCK) On t.InvID=ILM.InvestigationID                   

 Where ILM.OrgID=@OrgID And t.Parent!=''Y'' AND ILM.Type=12                  

 group by  ILM.ProcessingAddressID                  

                  

 Insert into @tblMaxGrpRPkgPL                  

 select Top 1 ProLocID from @tblGrpRPkgPL order by NCount  Desc                 

 IF(@Type=''PKG'')     

 BEGIN                

 select @pLocationID=ProLocID from  @tblMaxGrpRPkgPL t                  

 END    

 set @pLocationID=Isnull(@pLocationID,-1)    

 Return @pLocationID                  

End 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getPrimaryConsultantName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getPrimaryConsultantName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getPrimaryConsultantName]  
(    @PhysicianID BIGINT,
@ContextInfo [UDT_Context] READONLY  
 )  
RETURNS nvarchar(255)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
  
     DECLARE @name nvarchar(255)  
      
      
     BEGIN  
        SELECT @name = S.DisplayText+PhysicianName FROM Physician P LEFT JOIN  SalutationOrgMapping S on P.TitleCode = S.TitleID
 inner join @ContextInfo ctx1 on ctx1.OrgID=S.OrgID and ctx1.LanguageCode=S.LanguageCode   WHERE  PhysicianID=@PhysicianID  
      END  
  
     RETURN(@name);  
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcedureName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcedureName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getProcedureName]   
(   
 @pFeeID int,  
 @OrgID bigint  
)  
RETURNS nvarchar(255)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
     DECLARE @name nvarchar(255)  
	  select @name=PM.ProcedureName from ProcedureMaster PM   
	  inner join ProcedureFee PF on PM.ProcedureID=PF.ProcedureID  
	  where PM.OrgID=@OrgID and PF.ProcedureFeeID=@pFeeID  
	  
     RETURN(ISNULL(@name,''Miscellaneous''));  
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcessingLocation]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcessingLocation]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--dbo.[fn_getProcessingLocation] 67,79,''GRP''              
              
              
CREATE Function [dbo].[fn_getProcessingLocation]               
(  @OrgID BIGINT,              
   @ID INT,              
   @Type nvarchar(50)              
)              
RETURNS nvarchar(50)                
WITH EXECUTE AS CALLER              
As               
Begin              
Declare @tblTempGrp Table(InvID Bigint,Parent nchar(1))              
Declare @tblGrpRPkgPL Table(ProLocID Bigint,NCount int)              
Declare @tblMaxGrpRPkgPL Table(ProLocID Bigint)              
Declare @pLocation nvarchar(50)              
IF(@Type=''GRP'')              
Begin              
 ;WITH C1 as                                                                                                                             
 (                                                                                                                            
 Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                                            
 FROM InvGroupMaster OI WITH(NOLOCK)                                                                                                                             
 INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.AttGroupID = OI.GroupID                                                                                                                          
 INNER JOIN InvGroupMapMaster  IGM WITH(NOLOCK)  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                            
              
 WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                            
              
 UNION ALL                                                                                                                            
              
 Select IGM.InvestigationID As InvID,IGM.Parent                                                                                                                            
 FROM C1 OI                                                                              
 INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                              
 INNER JOIN InvGroupMapMaster IGM WITH(NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                                                             
 WHERE  OI.Parent=''Y''                                                                                                                         
 )              
              
 Insert Into @tblTempGrp(InvID,Parent)                                             
 SELECT InvID,Parent                                                                                                                           
 FROM C1               
END               
Else IF(@Type=''PKG'')              
Begin              
Declare @InvGroupMapMasterForOrderedPkg  Table                                                            
(                                                    
 GroupID int,                                                            
 InvestigationID bigint,                                                            
 Parent nvarchar                                                          
)                                                            
insert Into @InvGroupMapMasterForOrderedPkg                                                            
select IOG.OrgGroupID,IPM.ID,Case When IPM.Type=''GRP'' Then ''Y'' Else ''N'' End As Parent  from InvGroupMaster OI  WITH(NOLOCK)                                                           
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) ON IOG.AttGroupID=OI.GroupID                                                             
INNER JOIN InvPackageMapping IPM WITH(NOLOCK) ON IPM.PackageID=IOG.OrgGroupID And IPM.Type In(''INV'',''GRP'')                                    
Where OI.Type=''PKG'' AND OI.GroupID=@ID  AND IOG.OrgID=@OrgID          
              
;WITH C2 as                              
(                                         
Select IGM.InvestigationID  As InvID,IGM.Parent                                                                              
FROM InvGroupMaster OI  WITH(NOLOCK)                                                                                  
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.AttGroupID = OI.GroupID               
INNER JOIN @InvGroupMapMasterForOrderedPkg IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                            
WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                            
              
UNION ALL                                                                                                                            
              
Select IGM.InvestigationID as InvID,CONVERT(nvarchar(1),IGM.Parent) As Parent                                                                                                                            
FROM C2 OI                                                  
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                              
INNER JOIN InvGroupMapMaster IGM WITH(NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                            
WHERE  OI.Parent=''Y''                                                                           
)              
              
Insert Into @tblTempGrp(InvID,Parent)                                             
SELECT InvID,Parent                                                                                                                           
FROM C2               
END              
              
 insert into @tblGrpRPkgPL(ProLocID,NCount)              
 Select IOM.ProcessingAddressID,Count(*) from @tblTempGrp t Inner Join InvestigationOrgMapping IOM WITH(NOLOCK) On t.InvID=IOM.InvestigationID               
 Where IOM.OrgID=@OrgID And t.Parent!=''Y''              
 group by  IOM.ProcessingAddressID              
              
 Insert into @tblMaxGrpRPkgPL              
 select Top 1 ProLocID from @tblGrpRPkgPL order by NCount  Desc             
              
 select @pLocation=OA.Location from OrganizationAddress OA WITH(NOLOCK) Inner Join @tblMaxGrpRPkgPL t On t.ProLocID=OA.AddressID              
 Return @pLocation              
End  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcessingLocation_B]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcessingLocation_B]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--dbo.[fn_getProcessingLocation_B] 67,79,''GRP''              
              
              
CREATE Function [dbo].[fn_getProcessingLocation_B]               
(  @OrgID BIGINT,              
   @ID INT,              
   @Type nvarchar(50)              
)              
RETURNS nvarchar(50)                
WITH EXECUTE AS CALLER              
As               
Begin              
Declare @tblTempGrp Table(InvID Bigint,Parent nchar(1))              
Declare @tblGrpRPkgPL Table(ProLocID Bigint,NCount int)              
Declare @tblMaxGrpRPkgPL Table(ProLocID Bigint)              
Declare @pLocation nvarchar(50)              
IF(@Type=''GRP'')              
Begin              
 ;WITH C1 as                                                                                                                             
 (                                                                                                                            
 Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                                            
 FROM InvGroupMaster OI WITH(NOLOCK)                                                                                                                             
 INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.AttGroupID = OI.GroupID                                                                                                                          
 INNER JOIN InvGroupMapMaster  IGM WITH(NOLOCK)  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                            
              
 WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                            
              
 UNION ALL                                                                                                                            
              
 Select IGM.InvestigationID As InvID,IGM.Parent                                                                                                                            
 FROM C1 OI                                                                              
 INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                              
 INNER JOIN InvGroupMapMaster IGM WITH(NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                                                             
 WHERE  OI.Parent=''Y''                                                                                                                         
 )              
              
 Insert Into @tblTempGrp(InvID,Parent)                                             
 SELECT InvID,Parent                                                                                                                           
 FROM C1               
END               
Else IF(@Type=''PKG'')              
Begin              
Declare @InvGroupMapMasterForOrderedPkg  Table                                                            
(                                                    
 GroupID int,                                                            
 InvestigationID bigint,                                                            
 Parent nvarchar                                                          
)                                                            
insert Into @InvGroupMapMasterForOrderedPkg                                                            
select IOG.OrgGroupID,IPM.ID,Case When IPM.Type=''GRP'' Then ''Y'' Else ''N'' End As Parent  from InvGroupMaster OI  WITH(NOLOCK)                                                           
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) ON IOG.AttGroupID=OI.GroupID                                                             
INNER JOIN InvPackageMapping IPM WITH(NOLOCK) ON IPM.PackageID=IOG.OrgGroupID And IPM.Type In(''INV'',''GRP'')                                    
Where OI.Type=''PKG'' AND OI.GroupID=@ID  AND IOG.OrgID=@OrgID          
              
;WITH C2 as                              
(                                         
Select IGM.InvestigationID  As InvID,IGM.Parent                                                                              
FROM InvGroupMaster OI  WITH(NOLOCK)                                                                                  
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.AttGroupID = OI.GroupID               
INNER JOIN @InvGroupMapMasterForOrderedPkg IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                            
WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                            
              
UNION ALL                                                                                                                            
              
Select IGM.InvestigationID as InvID,CONVERT(nvarchar(1),IGM.Parent) As Parent                                                                                                                            
FROM C2 OI                                                  
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                              
INNER JOIN InvGroupMapMaster IGM WITH(NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                            
WHERE  OI.Parent=''Y''                                                                           
)              
              
Insert Into @tblTempGrp(InvID,Parent)                                             
SELECT InvID,Parent                                                                                                                           
FROM C2               
END              
              
 insert into @tblGrpRPkgPL(ProLocID,NCount)              
 Select IOM.ProcessingAddressID,Count(*) from @tblTempGrp t Inner Join InvestigationOrgMapping IOM On t.InvID=IOM.InvestigationID               
 Where IOM.OrgID=@OrgID And t.Parent!=''Y''              
 group by  IOM.ProcessingAddressID              
              
 Insert into @tblMaxGrpRPkgPL              
 select Top 1 ProLocID from @tblGrpRPkgPL order by NCount  Desc             
              
 select @pLocation=OA.Location from OrganizationAddress OA Inner Join @tblMaxGrpRPkgPL t On t.ProLocID=OA.AddressID              
 Return @pLocation              
End  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getProcessingLocation1]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getProcessingLocation1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--dbo.[fn_getProcessingLocation] 67,79,''GRP''                  
                  
                  
CREATE Function [dbo].[fn_getProcessingLocation1]                   
(  @OrgID BIGINT,                  
   @ID INT,                  
   @Type nvarchar(50)                  
)                  
RETURNS nvarchar(50)                    
WITH EXECUTE AS CALLER                  
As                   
Begin                  
Declare @tblTempGrp Table(InvID Bigint,Parent nchar(1))                  
Declare @tblGrpRPkgPL Table(ProLocID Bigint,NCount int)                  
Declare @tblMaxGrpRPkgPL Table(ProLocID Bigint)                  
Declare @pLocation nvarchar(50)                  
IF(@Type=''GRP'')                  
Begin                  
 ;WITH C1 as                                                                                                                                 
 (                                                                                                                                
 Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                                                
 FROM InvGroupMaster OI WITH(NOLOCK)                                                                                                                                 
 INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.AttGroupID = OI.GroupID                                                                                                                              
 INNER JOIN InvGroupMapMaster  IGM WITH(NOLOCK)  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                                
                  
 WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                                
                  
 UNION ALL                                                                                                                                
                  
 Select IGM.InvestigationID As InvID,IGM.Parent                                                                                                                                
 FROM C1 OI                                                                                  
 INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                                  
 INNER JOIN InvGroupMapMaster IGM WITH(NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                                                                 
 WHERE  OI.Parent=''Y''                                                                                                                             
 )                  
                  
 Insert Into @tblTempGrp(InvID,Parent)                                                 
 SELECT InvID,Parent                                                                                                                               
 FROM C1                   
END                   
Else IF(@Type=''PKG'')                  
Begin                  
Declare @InvGroupMapMasterForOrderedPkg  Table                                                                
(                                                        
 GroupID int,                                                                
 InvestigationID bigint,                                                                
 Parent nvarchar                                                              
)                                                                
insert Into @InvGroupMapMasterForOrderedPkg                                                                
select IOG.OrgGroupID,IPM.ID,Case When IPM.Type=''GRP'' Then ''Y'' Else ''N'' End As Parent  from InvGroupMaster OI  WITH(NOLOCK)                                                               
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) ON IOG.AttGroupID=OI.GroupID                                                                 
INNER JOIN InvPackageMapping IPM WITH(NOLOCK) ON IPM.PackageID=IOG.OrgGroupID And IPM.Type In(''INV'',''GRP'')                                        
Where OI.Type=''PKG'' AND OI.GroupID=@ID  AND IOG.OrgID=@OrgID              
                  
;WITH C2 as                                  
(                                             
Select IGM.InvestigationID  As InvID,IGM.Parent                                                                                  
FROM InvGroupMaster OI  WITH(NOLOCK)                                                                                      
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.AttGroupID = OI.GroupID                   
INNER JOIN @InvGroupMapMasterForOrderedPkg IGM  ON IOG.OrgGroupID =IGM.GroupID                                                                                                                                
WHERE OI.Type=@Type And IOG.OrgID=@OrgID AND OI.GroupID= @ID                                                                                                                
                  
UNION ALL                                                                                                                                
                  
Select IGM.InvestigationID as InvID,CONVERT(nvarchar(1),IGM.Parent) As Parent                                                                                                                                
FROM C2 OI                                                      
INNER JOIN InvOrgGroup IOG WITH(NOLOCK) on IOG.OrgGroupID =OI.InvID  and IOG.OrgID=@OrgID                                                                                                                                  
INNER JOIN InvGroupMapMaster IGM WITH(NOLOCK)  ON OI.InvID=IGM.GroupID                                                                                                
WHERE  OI.Parent=''Y''                                                                               
)                  
                  
Insert Into @tblTempGrp(InvID,Parent)                                                 
SELECT InvID,Parent                                                                                                                               
FROM C2                   
END                  
                  
 insert into @tblGrpRPkgPL(ProLocID,NCount)                  
 Select IOM.ProcessingAddressID,Count(*) from @tblTempGrp t Inner Join InvestigationOrgMapping IOM WITH(NOLOCK) On t.InvID=IOM.InvestigationID                   
 Where IOM.OrgID=@OrgID And t.Parent!=''Y''                  
 group by  IOM.ProcessingAddressID                  
                  
 Insert into @tblMaxGrpRPkgPL                  
 select Top 1 ProLocID from @tblGrpRPkgPL order by NCount  Desc                 
                  
 select @pLocation=LRO1.Add1 from LabReferenceOrg LRO WITH(NOLOCK)
 INNER JOIN  LabRefOrgAddress LRO1  WITH(NOLOCK) ON LRO1.LabRefOrgID=LRO.LabRefOrgID
 Inner Join @tblMaxGrpRPkgPL t On t.ProLocID=LRO1.AddressID                  
 Return @pLocation                  
End 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetRateAplliedSettinsForClient_Dixit]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetRateAplliedSettinsForClient_Dixit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE  FUNCTION [dbo].[fn_GetRateAplliedSettinsForClient_Dixit] 
(
@OrgID int 
, @ClientCode nchar(10)
)
returns @Tbl_RateDetailsForClient table
(
	OrgID bigint  , 
	Clientid bigint ,
	ClientCode nchar(10) ,
	ClientName nchar(150) ,
	Test_Attune_Code bigint ,
	Test_Org_Code bigint ,
	Test_EDOS_Code nchar(20) ,
	Test_Type nchar(10) ,
	Test_Name nchar(200) ,
	Discount_Catergory nchar(10) ,
Base_Rate_Card nchar(20),
Applied_Rate_Card nchar(20),
RateType nchar(20) ,
Discount_Policy nchar(200) ,
Discount_Applied Decimal(18 , 2) ,
MRP Decimal(18 , 2) ,
Rate Decimal(18 , 2) ,
Collection_Charges Decimal(18 , 2) 
)
as
/*
Exec fN_GetRateAplliedSettinsForClient_Dixit @OrgID = 67  , @ClientCode
*/
Begin
Insert INTO @Tbl_RateDetailsForClient
(
OrgID ,
ClientID ,
ClientCode ,
ClientName ,
Test_Attune_Code  ,
Test_Org_Code  ,
Test_EDOS_Code  ,
Test_Type ,
Test_Name ,
MRP ,
Rate 
)
SELECT 
t.ORGID OrgID ,
cm.ClientID ,
cm.ClientCode ,
cm.ClientName ,
t.ACRPID Test_Attune_Code  ,
t.AORGID Test_Org_Code  ,
t.TCODE Test_EDOS_Code  ,
t.ATYPE Test_Type ,
t.TNAME Test_Name ,
-1 MRP ,
-1 Rate  
FROM
[LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK)
INNER JOIN [LIMS_LIVE].[dbo].[ClientMaster] cm (NOLOCK)
ON t.OrgID = cm.OrgID
WHERE t.Orderable = ''YES''
and t.OrgID = @OrgID
and cm.ClientCode = @ClientCode

declare @Tbl_TestDiscountCat as taBLE
(
OrgID bigint ,
ATYPE nchar(10) ,
ACRPID bigint ,
AORGID bigint ,
Discount_Catergory nchar(10)
) 
INSERT INTO @Tbl_TestDiscountCat
(
OrgID ,
ATYPE ,
ACRPID ,
AORGID ,
Discount_Catergory 
)
SELECT 
t.OrgID ,
t.ATYPE ,
t.ACRPID ,
t.AORGID ,
IOM.[Category] 
FROM [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK)
INNER JOIN [LIMS_LIVE].[dbo].[InvestigationOrgAttributes]  IOM (NOLOCK)
ON t.ACRPID = IOM.[InvestigationID]
AND t.OrgID = IOM.OrgID
AND t.ATYPE = ''INV''
WHERE t.OrgID = @OrgID
AND [Orderable] = ''YES''
UNION
SELECT 
t.OrgID ,
t.ATYPE ,
t.ACRPID ,
t.AORGID ,
IOG.[SubCategory] 
FROM [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK)
INNER JOIN [LIMS_LIVE].[dbo].[InvOrgGroup]  IOG (NOLOCK)
ON t.ACRPID = IOG.[AttGroupID]
AND t.AORGID = IOG.[OrgGroupID]
AND t.OrgID = IOG.OrgID
AND (t.ATYPE = ''GRP'' OR t.ATYPE = ''PKG'')
WHERE t.OrgID = @OrgID
AND [Orderable] = ''YES''


UPDATE @Tbl_RateDetailsForClient  SET 
TRD.Discount_Catergory = a.Discount_Catergory
FROM @Tbl_RateDetailsForClient TRD , @Tbl_TestDiscountCat  a
WHERE 
TRD.Test_Type  = a.ATYPE
AND TRD.Test_Attune_Code = a.ACRPID
AND TRD.Test_Org_Code = a.AORGID
AND TRD.OrgID = a.OrgID ;


-- Scan Base Rate Cards For MRP
DECLARE @Tbl_RateCardMappingForClient AS TABLE
(
	     [ClientID] bigint
      , [OrgID] bigint
      , [ClientName] nchar(150)
      , ClientCode nchar(20)
      , [RateId] bigint
      , RateName nchar(50)
      ,[ValidFrom] datetime
      ,[ValidTo] datetime
      ,[Priority] int
      ,[ClientMappingDetailsID] bigint
      , RateType nchar(50)
)
INSERT INTO @Tbl_RateCardMappingForClient 
(
	     [ClientID]
      , [OrgID] 
      , [ClientName] 
      , ClientCode 
      , [RateId] 
      , RateName 
      ,[ValidFrom] 
      ,[ValidTo] 
      ,[Priority] 
      ,[ClientMappingDetailsID] 
      , RateType
)

SELECT ICM.[ClientID]
      ,ICM.[OrgID]
      ,ICM.[ClientName]
      , ClientCode
      ,ICM.[RateId]
      , RateName
      ,[ValidFrom]
      ,[ValidTo]
      ,[Priority]
      ,[ClientMappingDetailsID]
      , RM.Type RateType
  FROM [LIMS_LIVE].[dbo].[InvClientMaster] ICM (NOLOCK) 
  INNER JOIN [LIMS_LIVE].[dbo].[ClientMaster] cm (NOLOCK)
  ON ICM.OrgID = cm.OrgID AND ICM.ClientID = cm.ClientID
  LEFT JOIN [LIMS_LIVE].[dbo].RateMaster RM (NOLOCK) 
  ON RM.RateID = ICM.RateID
  WHERE 
  CAST(ValidFrom as Date) <= CAST(getDate() as Date)
  AND CAST(ValidTo as Date) >= CAST(getDate() as Date)
  AND ICM.OrgID = @OrgID
  AND cm.ClientCode = @ClientCode
  ORDER BY ClientName ,Priority ;

DECLARE @RateID bigint 
DECLARE @Priority bigint 
DECLARE @RateTYPE nchar(20)
DECLARE @RateName nchar(20)
DECLARE @MRP DECIMAL(18,2)
DECLARE @FinalRate DECIMAL(18,2)
DECLARE @BASERATECARD nchar(50)
DECLARE @SPECIALRATECARD nchar(50)

DECLARE TableCursor CURSOR FOR
SELECT 
        [RateId] 
      , RateName 
      ,[Priority] 
      , RateType
FROM @Tbl_RateCardMappingForClient
ORDER BY Priority
OPEN TableCursor

FETCH NEXT FROM TableCursor INTO @RateID , @RateName , @Priority , @RateType
WHILE @@FETCH_STATUS = 0
BEGIN
UPDATE @Tbl_RateDetailsForClient  SET 
  TRFD.Applied_Rate_Card = b.RateName 
, TRFD.RateType = b.RateType 
, TRFD.Rate = b.Rate
FROM @Tbl_RateDetailsForClient TRFD ,
(
SELECT [RateTypeID]
      ,IRM.[Type]
      ,IRM.[ID]
      ,IRM.[RateID]
      ,[Rate]
      , RM.Type RateTYPE
      , RateName
  FROM [LIMS_LIVE].[dbo].[InvRateMaster] IRM (NOLOCK)
  INNER JOIN RATEMASTER RM (NOLOCK) ON RM.RateID = IRM.RateID
  WHERE RM.OrgID = @OrgID
  AND IRM.RateID = @RateID 
) b
WHERE TRFD.Test_Type = b.TYPE
AND   TRFD.Test_Org_Code = b.ID
AND   TRFD.RATE = -1 ;



UPDATE @Tbl_RateDetailsForClient SET 
TRFD.Base_Rate_Card = b.RateName 
, TRFD.MRP = b.Rate
FROM @Tbl_RateDetailsForClient TRFD ,
(
SELECT [RateTypeID]
      ,IRM.[Type]
      ,IRM.[ID]
      ,IRM.[RateID]
      ,[Rate]
      , RM.TYPE RateTYPE
      , RateName
  FROM [LIMS_LIVE].[dbo].[InvRateMaster] IRM (NOLOCK)
  INNER JOIN RATEMASTER RM (NOLOCK) ON RM.RateID = IRM.RateID
  WHERE RM.OrgID = @OrgID
  AND IRM.RateID = @RateID 
  AND RM.Type = ''Normal''
) b
WHERE TRFD.Test_Type = b.TYPE
AND   TRFD.Test_Org_Code = b.ID
AND   TRFD.MRP = -1 ;

FETCH NEXT FROM TableCursor INTO @RateID , @RateName , @Priority , @RateType
END
CLOSE TableCursor
DEALLOCATE TableCursor 

DECLARE @Tbl_SubCatDiscounts AS TABLE
(
	      ClientID bigint
      , ClientCode nchar(100)
      , [DiscountPolicyID]  bigint
      , PolicyName nchar(100)
      , [PolicyID] bigint
      , [FeeType] nchar(100)
      , [CategoryCode] nchar(100)
      , [DiscountPercentage] DECIMAL(18,2)
      , [OrgID] bigint
)
INSERT INTO @Tbl_SubCatDiscounts 
(
        ClientID
      , ClientCode
      , [DiscountPolicyID]
      , PolicyName
      , [PolicyID]
      , [FeeType]
      , [CategoryCode]
      , [DiscountPercentage]
      , [OrgID]
)
SELECT  cm.ClientID 
      , cm.ClientCode 
      , cm.[DiscountPolicyID]  
      , PM.PolicyName
      , DPM.[PolicyID]
      , DPM.[FeeType]
      , DPM.[CategoryCode]
      , DPM.[DiscountPercentage]
      , DPM.[OrgID]
       FROM LIMS_LIVE.dbo.ClientMaster cm (NOLOCK)
       LEFT JOIN [LIMS_LIVE].[dbo].[PolicyMaster] PM (NOLOCK)
       ON PM.[PolicyID] = cm.[DiscountPolicyID] 
       LEFT JOIN [LIMS_LIVE].[dbo].[DiscountPolicyMapping] DPM (NOLOCK) ON 
       DPM.PolicyID = cm.DiscountPolicyID
       AND DPM.OrgID = cm.OrgID
       and PM.[OrgID] = cm.OrgID
       WHERE cm.ClientCode = @ClientCode
      AND cm.OrgID = @OrgID 
      
UPDATE @Tbl_RateDetailsForClient
SET Discount_Policy  = a.PolicyName
    , Discount_Applied = a.DiscountPercentage
    FROM @Tbl_RateDetailsForClient TRDF , @Tbl_SubCatDiscounts a
    WHERE TRDF.MRP = TRDF.RATE
    AND TRDF.Base_Rate_Card = TRDF.Applied_Rate_Card
    AND TRDF.RateType = ''Normal''
    AND TRDF.ClientID = a.ClientID
    AND TRDF.OrgID = a.OrgID
    AND TRDF.Test_Type = ''INV''
    AND a.FeeType = ''INVESTIGATION_FEE''
    AND TRDF.Discount_Catergory = a.CategoryCode ;

    
UPDATE @Tbl_RateDetailsForClient
SET Discount_Policy  = a.PolicyName
    , Discount_Applied = a.DiscountPercentage
    FROM @Tbl_RateDetailsForClient TRFD , @Tbl_SubCatDiscounts a
    WHERE TRFD.MRP = TRFD.RATE
    AND TRFD.Base_Rate_Card = TRFD.Applied_Rate_Card
    AND TRFD.RateType = ''Normal''
    AND TRFD.ClientID = a.ClientID
    AND TRFD.OrgID = a.OrgID
    AND TRFD.Test_Type = ''GRP''
    AND a.FeeType = ''INVESTIGATION_GROUP_FEE''
    AND TRFD.Discount_Catergory = a.CategoryCode ;

  
UPDATE @Tbl_RateDetailsForClient
SET Discount_Policy  = a.PolicyName
    , Discount_Applied = a.DiscountPercentage
    FROM @Tbl_RateDetailsForClient TRFD , @Tbl_SubCatDiscounts a
    WHERE TRFD.MRP = TRFD.RATE
    AND TRFD.Base_Rate_Card = TRFD.Applied_Rate_Card
    AND TRFD.RateType = ''Normal''
    AND TRFD.ClientID = a.ClientID
    AND TRFD.OrgID = a.OrgID
    AND TRFD.Test_Type = ''PKG''
    AND a.FeeType = ''HEALTH_PACKAGE''
    AND TRFD.Discount_Catergory = a.CategoryCode ;


UPDATE @Tbl_RateDetailsForClient SET Rate = Rate - (Rate*Discount_Applied/100)
WHERE Discount_Policy <> '''' AND Discount_Applied > 0 
AND RateTYPE = ''Normal'' ;

UPDATE @Tbl_RateDetailsForClient SET Collection_Charges = MRP - RATE ;



RETURN
End


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetRateAplliedSettinsForTest_Dixit]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetRateAplliedSettinsForTest_Dixit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE function [dbo].[fn_GetRateAplliedSettinsForTest_Dixit] 
(
@OrgID int 
, @TCODE nchar(10)
)
RETURNS @Tbl_RateDetailsForTest table
(
	OrgID bigint  , 
	Clientid bigint ,
	ClientCode nchar(10) ,
	ClientName nchar(150) ,
	Test_Attune_Code bigint ,
	Test_Org_Code bigint ,
	Test_EDOS_Code nchar(20) ,
	Test_Type nchar(10) ,
	Test_Name nchar(200) ,
	Discount_Catergory nchar(10) ,
Base_Rate_Card nchar(20),
Applied_Rate_Card nchar(20),
RateType nchar(20) ,
Discount_Policy nchar(200) ,
Discount_Applied Decimal(18 , 2) ,
MRP Decimal(18 , 2) ,
Rate Decimal(18 , 2) ,
Collection_Charges Decimal(18 , 2) 
-- UNIQUE CLUSTERED (OrgID,ClientCode,Test_Org_Code)
)
as

Begin

 

Insert INTO @Tbl_RateDetailsForTest 
(
OrgID ,
ClientID ,
ClientCode ,
ClientName ,
Test_Attune_Code  ,
Test_Org_Code  ,
Test_EDOS_Code  ,
Test_Type ,
Test_Name ,
MRP ,
Rate 
)
SELECT 
t.ORGID OrgID ,
cm.ClientID ,
cm.ClientCode ,
cm.ClientName ,
t.ACRPID Test_Attune_Code  ,
t.AORGID Test_Org_Code  ,
t.TCODE Test_EDOS_Code  ,
t.ATYPE Test_Type ,
t.TNAME Test_Name ,
-1 MRP ,
-1 Rate  
FROM
[LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK)
INNER JOIN [LIMS_LIVE].[dbo].[ClientMaster] cm (NOLOCK)
ON t.OrgID = cm.OrgID
WHERE t.Orderable = ''YES''
and t.OrgID = @OrgID
and t.TCODE = @TCODE

DECLARE  @Tbl_TestDiscountCat TABLE 
(
OrgID bigint ,
ATYPE nchar(10) ,
ACRPID bigint ,
AORGID bigint ,
Discount_Catergory nchar(10)
UNIQUE CLUSTERED (OrgID,ATYPE,AORGID)
) 
INSERT INTO @Tbl_TestDiscountCat 
(
OrgID ,
ATYPE ,
ACRPID ,
AORGID ,
Discount_Catergory 
)
SELECT 
t.OrgID ,
t.ATYPE ,
t.ACRPID ,
t.AORGID ,
IOM.[Category] 
FROM [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK)
INNER JOIN [LIMS_LIVE].[dbo].[InvestigationOrgAttributes]  IOM (NOLOCK)
ON t.ACRPID = IOM.[InvestigationID]
AND t.OrgID = IOM.OrgID
AND t.ATYPE = ''INV''
WHERE t.OrgID = @OrgID
AND [Orderable] = ''YES''
AND t.TCODE = @TCODE
UNION
SELECT 
t.OrgID ,
t.ATYPE ,
t.ACRPID ,
t.AORGID ,
IOG.[SubCategory] 
FROM [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK)
INNER JOIN [LIMS_LIVE].[dbo].[InvOrgGroup]  IOG (NOLOCK)
ON t.ACRPID = IOG.[AttGroupID]
AND t.AORGID = IOG.[OrgGroupID]
AND t.OrgID = IOG.OrgID
AND (t.ATYPE = ''GRP'' OR t.ATYPE = ''PKG'')
WHERE t.OrgID = @OrgID
AND [Orderable] = ''YES''
AND t.TCODE = @TCODE


UPDATE @Tbl_RateDetailsForTest  SET 
TRDT.Discount_Catergory = a.Discount_Catergory
FROM @Tbl_RateDetailsForTest TRDT , @Tbl_TestDiscountCat  a
WHERE 
TRDT.Test_Type  = a.ATYPE
AND TRDT.Test_Attune_Code = a.ACRPID
AND TRDT.Test_Org_Code = a.AORGID
AND TRDT.OrgID = a.OrgID ;


-- Scan Base Rate Cards For MRP
DECLARE @Tbl_RateCardMappingForClient TABLE
(
	     [ClientID] bigint
      , [OrgID] bigint
      , [ClientName] nchar(150)
      , ClientCode nchar(20)
      , [RateId] bigint
      , RateName nchar(50)
      ,[ValidFrom] datetime
      ,[ValidTo] datetime
      ,[Priority] int
      ,[ClientMappingDetailsID] bigint
      , RateType nchar(50)
       , ACRPID bigint
      , ATYPE nchar(10)
      , AORGID bigint
)
INSERT INTO @Tbl_RateCardMappingForClient 
(
	     [ClientID]
      , [OrgID] 
      , [ClientName] 
      , ClientCode 
      , [RateId] 
      , RateName 
      ,[ValidFrom] 
      ,[ValidTo] 
      ,[Priority] 
      ,[ClientMappingDetailsID] 
      , RateType
       , ACRPID 
      , ATYPE
      , AORGID
)

SELECT ICM.[ClientID]
      ,ICM.[OrgID]
      ,ICM.[ClientName]
      , ClientCode
      ,ICM.[RateId]
      , RM.RateName
      ,[ValidFrom]
      ,[ValidTo]
      ,[Priority]
      ,[ClientMappingDetailsID]
      , RM.Type RateType
      , ACRPID 
      , ATYPE
      , AORGID
  FROM [LIMS_LIVE].[dbo].[InvClientMaster] ICM (NOLOCK) 
  INNER JOIN [LIMS_LIVE].[dbo].[ClientMaster] cm (NOLOCK)
  ON ICM.OrgID = cm.OrgID AND ICM.ClientID = cm.ClientID
  INNER JOIN [LIMS_LIVE].[dbo].RateMaster RM (NOLOCK) 
  ON RM.RateID = ICM.RateID and RM.OrgID = ICM.OrgID
  INNER JOIN [LIMS_LIVE].[dbo].InvRateMaster IRM (NOLOCK) 
  ON IRM.RateID = ICM.RateID
  INNER JOIN [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK) 
  ON IRM.ID = t.AORGID AND IRM.TYPE = t.ATYPE AND t.OrgID = RM.OrgID
  WHERE 
  CAST(ValidFrom as Date) <= CAST(getDate() as Date)
  AND CAST(ValidTo as Date) >= CAST(getDate() as Date)
  AND ICM.OrgID = @OrgID
  AND t.TCODE = @TCODE
  ORDER BY ClientName ,Priority ;



DECLARE @Priority bigint 
DECLARE TableCursor CURSOR FOR
SELECT  DISTINCT
       [Priority] 
FROM @Tbl_RateCardMappingForClient 
ORDER BY Priority
OPEN TableCursor

FETCH NEXT FROM TableCursor INTO @Priority 
WHILE @@FETCH_STATUS = 0
BEGIN
UPDATE @Tbl_RateDetailsForTest SET 
TRDT.Applied_Rate_Card = b.RateName 
, TRDT.RateType = b.RateType 
, TRDT.Rate = b.Rate
FROM @Tbl_RateDetailsForTest TRDT , 
(
SELECT [RateTypeID]
      ,IRM.[Type]
      ,IRM.[ID]
      ,IRM.[RateID]
      ,[Rate]
      , RM.Type RateTYPE
      , RM.RateName
      , TRM.ClientID
  FROM [LIMS_LIVE].[dbo].[InvRateMaster] IRM (NOLOCK)
  INNER JOIN RATEMASTER RM (NOLOCK) ON RM.RateID = IRM.RateID
  INNER JOIN [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK) 
  ON IRM.ID = t.AORGID AND IRM.TYPE = t.ATYPE AND t.OrgID = RM.OrgID
  INNER JOIN @Tbl_RateCardMappingForClient TRM ON 
  TRM.RateID = RM.RateID 
  AND TRM.OrgID = RM.OrgID 
  AND TRM.Priority = @Priority
  AND TRM.AORGID = IRM.ID
  AND TRM.ATYPE = IRM.TYPE
  WHERE RM.OrgID = @OrgID
  AND t.TCODE = @TCODE
) b
WHERE TRDT.Test_Type = b.TYPE
AND   TRDT.Test_Org_Code = b.ID
AND   TRDT.ClientID = b.ClientID
AND   TRDT.RATE = -1 ;



UPDATE @Tbl_RateDetailsForTest SET 
TRDT.Base_Rate_Card = b.RateName 
, TRDT.MRP = b.Rate
FROM @Tbl_RateDetailsForTest TRDT , 
(
SELECT [RateTypeID]
      ,IRM.[Type]
      ,IRM.[ID]
      ,IRM.[RateID]
      ,[Rate]
      , RM.TYPE RateTYPE
      , RM.RateName
      , TRM.ClientID
  FROM [LIMS_LIVE].[dbo].[InvRateMaster] IRM (NOLOCK)
  INNER JOIN RATEMASTER RM (NOLOCK) ON RM.RateID = IRM.RateID
  INNER JOIN [LIMS_LIVE].[dbo].[View_Tests671] t (NOLOCK) 
  ON IRM.ID = t.AORGID AND IRM.TYPE = t.ATYPE AND t.OrgID = RM.OrgID
  INNER JOIN @Tbl_RateCardMappingForClient TRM ON 
  TRM.RateID = RM.RateID 
  AND TRM.OrgID = RM.OrgID 
  AND TRM.Priority = @Priority
  AND TRM.AORGID = IRM.ID
  AND TRM.ATYPE = IRM.TYPE
  WHERE RM.OrgID = @OrgID
  AND RM.Type = ''Normal''
  AND t.TCODE = @TCODE
) b
WHERE TRDT.Test_Type = b.TYPE
AND   TRDT.Test_Org_Code = b.ID
AND   TRDT.ClientID = b.ClientID
AND   TRDT.MRP = -1 ;

FETCH NEXT FROM TableCursor INTO @Priority
END
CLOSE TableCursor
DEALLOCATE TableCursor 



DECLARE @Tbl_SubCatDiscounts  TABLE
(
	      ClientID bigint
      , ClientCode nchar(100)
      , [DiscountPolicyID]  bigint
      , PolicyName nchar(100)
      , [PolicyID] bigint
      , [FeeType] nchar(100)
      , [CategoryCode] nchar(100)
      , [DiscountPercentage] DECIMAL(18,2)
      , [OrgID] bigint
)


INSERT INTO @Tbl_SubCatDiscounts 
(
        ClientID
      , ClientCode
      , [DiscountPolicyID]
      , PolicyName
      , [PolicyID]
      , [FeeType]
      , [CategoryCode]
      , [DiscountPercentage]
      , [OrgID]
)
SELECT  cm.ClientID 
      , cm.ClientCode 
      , cm.[DiscountPolicyID]  
      , PM.PolicyName
      , DPM.[PolicyID]
      , DPM.[FeeType]
      , DPM.[CategoryCode]
      , DPM.[DiscountPercentage]
      , DPM.[OrgID]
       FROM LIMS_LIVE.dbo.ClientMaster cm (NOLOCK)
       LEFT JOIN [LIMS_LIVE].[dbo].[PolicyMaster] PM (NOLOCK)
       ON PM.[PolicyID] = cm.[DiscountPolicyID] 
       LEFT JOIN [LIMS_LIVE].[dbo].[DiscountPolicyMapping] DPM (NOLOCK) ON 
       DPM.PolicyID = cm.DiscountPolicyID
       AND DPM.OrgID = cm.OrgID
       and PM.[OrgID] = cm.OrgID
       INNER JOIN @Tbl_TestDiscountCat TDB
       ON TDB.Discount_Catergory = DPM.[CategoryCode]
       WHERE  cm.OrgID = @OrgID 
      
UPDATE @Tbl_RateDetailsForTest
SET TRDT.Discount_Policy  = a.PolicyName
    , TRDT.Discount_Applied = a.DiscountPercentage
    FROM @Tbl_RateDetailsForTest TRDT , @Tbl_SubCatDiscounts a
    WHERE TRDT.MRP = TRDT.RATE
    AND TRDT.Base_Rate_Card = TRDT.Applied_Rate_Card
    AND TRDT.RateType = ''Normal''
    AND TRDT.ClientID = a.ClientID
    AND TRDT.OrgID = a.OrgID
    AND TRDT.Test_Type = ''INV''
    AND a.FeeType = ''INVESTIGATION_FEE''
    AND TRDT.Discount_Catergory = a.CategoryCode ;

     
UPDATE @Tbl_RateDetailsForTest
SET TRDT.Discount_Policy  = a.PolicyName
    , TRDT.Discount_Applied = a.DiscountPercentage
    FROM @Tbl_RateDetailsForTest TRDT , @Tbl_SubCatDiscounts a
    WHERE TRDT.MRP = TRDT.RATE
    AND TRDT.Base_Rate_Card = TRDT.Applied_Rate_Card
    AND TRDT.RateType = ''Normal''
    AND TRDT.ClientID = a.ClientID
    AND TRDT.OrgID = a.OrgID
    AND TRDT.Test_Type = ''GRP''
    AND a.FeeType = ''INVESTIGATION_GROUP_FEE''
    AND TRDT.Discount_Catergory = a.CategoryCode ;
 
 
     
UPDATE @Tbl_RateDetailsForTest
SET TRDT.Discount_Policy  = a.PolicyName
    , TRDT.Discount_Applied = a.DiscountPercentage
    FROM @Tbl_RateDetailsForTest TRDT , @Tbl_SubCatDiscounts a
    WHERE TRDT.MRP = TRDT.RATE
    AND TRDT.Base_Rate_Card = TRDT.Applied_Rate_Card
    AND TRDT.RateType = ''Normal''
    AND TRDT.ClientID = a.ClientID
    AND TRDT.OrgID = a.OrgID
    AND TRDT.Test_Type = ''PKG''
    AND a.FeeType = ''HEALTH_PACKAGE''
    AND TRDT.Discount_Catergory = a.CategoryCode ;
       


UPDATE @Tbl_RateDetailsForTest 
SET Rate = Rate - (Rate*Discount_Applied/100)
WHERE Discount_Policy <> '''' AND Discount_Applied > 0 
AND RateTYPE = ''Normal'' ;

UPDATE @Tbl_RateDetailsForTest SET Collection_Charges = MRP - RATE ;


RETURN
End


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getRoundOff]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getRoundOff]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getRoundOff](@orgid int, @NetAmount Decimal(18,2))
returns decimal(18,2)
as
begin
	  DECLARE @RoundOFFType AS VARCHAR(250)
      DECLARE @RoundOFFValue AS DECIMAL(18, 2)
	  Declare @FinalNetAmount as decimal(18,2)
      SELECT @RoundOFFType = com.ConfigValue
      FROM   ConfigKeyMaster ckm
             INNER JOIN ConfigOrgMaster com
                     ON ckm.ConfigKeyID = com.ConfigKeyID
      WHERE  com.OrgID = @orgid
             AND configkey = ''PatientRoundOffPattern''
      SELECT @RoundOFFValue = com.ConfigValue
      FROM   ConfigKeyMaster ckm
             INNER JOIN ConfigOrgMaster com
                     ON ckm.ConfigKeyID = com.ConfigKeyID
      WHERE  com.OrgID = @orgid
             AND configkey = ''RoundOffPatAmt''
			 
     If @RoundOFFType =''Lower Value''
	 begin
		/*	 Value= Amount -  (Amount % RoundoffValue)
		= 33.50 -  (33.50%5)
		= 33.50-3.50
		= 30.00
		*/
	
		Set @FinalNetAmount =0.00
		set @FinalNetAmount =@NetAmount - (@NetAmount % @RoundOFFValue )
	 end
	 if @RoundOFFType =''Upper Value''
	 begin
	 
		/*
		Value= (Amount -  (Amount % RoundoffValue))+RoundoffValue
		= (33.50-(33.50%1))+1
		= (33.50 - (0.50))+1
		= 33+1
		= 34.00*/
		set @FinalNetAmount =0.00
		set @FinalNetAmount =(@NetAmount -(@NetAmount % @RoundOFFValue ))+@RoundOFFValue 
	 end
    Return @FinalNetAmount
end





' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetSampleName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetSampleName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[Fn_GetSampleName](@visitid INT,@orgid int)        
Returns nvarchar(100)        
        
AS        
BEGIN        
Declare @name nvarchar(max)        
SET @name=''''        
       
select @name=STUFF((SELECT '','' + inv.SampleDesc AS [text()] FROM patientinvsample pv    
    inner join InvSampleMaster inv on pv.SampleCode=inv.SampleCode        
where  inv.OrgID=@orgid  and pv.PatientVisitID=@visitid                           
 for xml PATH(''''), root(''TC''), type ).value(''/TC[1]'',''nvarchar(max)'') , 1, 1, '''')               
         
   REturn @name        
END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerDate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetServerDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
--Drop Function [fn_GetServerDate]

CREATE FUNCTION [dbo].[fn_GetServerDate](@ContextInfo [dbo].[UDT_Context] READONLY)
RETURNS [datetime] WITH EXECUTE AS CALLER
AS
begin  
Declare @OrgDateTime datetime  
Declare @OrgID int  
Declare @OrgAddID int  
Declare @TimeDiff time
Declare @TimeDiff1 int  
DECLARE @GetLocalDate DATETIME 
 

 
select @OrgID=OrgID,@OrgAddID=OrgAddressID from @ContextInfo  
 
select @TimeDiff=TimeDifference from organizationAddress where OrgID=@OrgID and AddressID=@OrgAddID  
if(ISNULL(@TimeDiff,'''')='''')  
begin  
	 select @TimeDiff1=TimeDifference from organization where OrgID=@OrgID  

	IF(@TimeDiff1  = 0)
		BEGIN
			 SELECT @GetLocalDate=GETUTCDATE()
		END       
	ELSE IF (@TimeDiff1 IS NULL OR @TimeDiff1='''')             
	  BEGIN                
		SELECT @GetLocalDate= GETDATE()               
	  END                
	 ELSE                
	  BEGIN                
	   SELECT @GetLocalDate=DATEADD(Hh, @TimeDiff1 , GETUTCDATE())                
	  END                
	 RETURN(@GetLocalDate);


End  
 
else if(isnull(@TimeDiff,'''')<>'''')  
begin  
	 SEt @OrgDateTime=GETUTCDATE()  
	 Set @OrgDateTime=DATEADD(HH,DATEPART(HH,@TimeDiff) ,@OrgDateTime);  
	 Set @OrgDateTime=DATEADD(MINUTE,DATEPART(MINUTE,@TimeDiff) ,@OrgDateTime);  
	 Set @OrgDateTime=DATEADD(SS,DATEPART(SS,@TimeDiff) ,@OrgDateTime);  
	End
	Else
	begin  
	 SEt @OrgDateTime=GETDATE();  
	end  
 
	return @OrgDateTime  
End


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerDate_BKP]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetServerDate_BKP]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetServerDate_BKP]                
(                
@ContextInfo [UDT_Context] READONLY        
)                
RETURNS DATETIME                
AS                
BEGIN                
 DECLARE @GetLocalDate DATETIME               
 Declare @TimeDiff INT            
 Declare @pOrgID int = 0,@pOrgAddressID int = 0        
 Select @pOrgID = OrgID, @pOrgAddressID = OrgAddressID from @ContextInfo        
 Select @TimeDiff=TimeDifference from Organization(nolock) where OrgID=@pOrgID --and AddressID=@pOrgAddressID             
-- Select @TimeDiff              
                 
 IF (@TimeDiff IS NULL OR @TimeDiff='''')             
  BEGIN                
    SELECT @GetLocalDate= GETDATE()               
  END                
 ELSE                
  BEGIN                
   SELECT @GetLocalDate=DATEADD(Hh, @TimeDiff , GETUTCDATE())                
  END                
 RETURN(@GetLocalDate);                
END 





' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerDateWithOutContext]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetServerDateWithOutContext]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetServerDateWithOutContext]                    
(                    
@OrgId int,    
@OrgAddressID Bigint             
)                    
RETURNS DATETIME                    
AS                    
BEGIN                    
 DECLARE @GetLocalDate DATETIME                   
 Declare @TimeDiff INT                
 Declare @pOrgID int = 0,@pOrgAddressID int = 0            
 --Select @pOrgID = OrgID, @pOrgAddressID = OrgAddressID from @ContextInfo            
 Select @TimeDiff=TimeDifference from Organization where OrgID=@OrgId --and AddressID=@pOrgAddressID                 
-- Select @TimeDiff                  
                     
 IF (@TimeDiff IS NULL OR @TimeDiff='''')                 
  BEGIN                    
    SELECT @GetLocalDate= GETDATE()                   
  END                    
 ELSE                    
  BEGIN                    
   SELECT @GetLocalDate=DATEADD(Hh, @TimeDiff , GETUTCDATE())                    
  END                    
 RETURN(@GetLocalDate);                    
END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getSpecialtyName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getSpecialtyName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_getSpecialtyName]
(    @pVisitPurposeID int,
    @pSpecialtyID int)
RETURNS nvarchar(255)
WITH EXECUTE AS CALLER
AS
BEGIN

     DECLARE @name nvarchar(255)
    
     IF(@pVisitPurposeID=1)
     BEGIN
        SELECT @name = SpecialityName from Speciality WHERE SpecialityID=@pSpecialtyID
     END
     ELSE IF(@pVisitPurposeID=3)
     BEGIN
        SELECT @name = ''LAB Investigations''
     END
     ELSE IF(@pVisitPurposeID=7)
     BEGIN
        SELECT @name = ProcedureName from ProcedureMaster WHERE ProcedureID=@pSpecialtyID
     END

     RETURN(@name);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetStockInHand](@pProductID [bigint], @pOrgID [int], @pLocationID [int])
RETURNS [decimal](18, 2) WITH EXECUTE AS CALLER
AS 
BEGIN
    DECLARE @InHandQty DECIMAL(18,2)
	
	IF (@pLocationID=0)            
		SET @pLocationID =Null


     SELECT @InHandQty=(
						(SUM(SI.TotalStockReceived) - ( SUM(SI.TotalLocationIssued)+
						SUM(SI.TotalStockIssued) + SUM(SI.TotalStockReturn)+
						SUM(SI.TotalStockDamage)))
						)
						FROM StockInHand SI 
						WHERE SI.OrgID=@pOrgID 
							AND	SI.ProductID=@pProductID 
							AND	SI.LocationID=COALESCE(@pLocationID,SI.LocationID)
						GROUP BY ProductID
						
      SET @InHandQty = ISNULL(@InHandQty,0)
     RETURN(@InHandQty);
END;





' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand_BatchNo]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand_BatchNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[fn_GetStockInHand_BatchNo]
   (@pProductID [bigint], @BatchNo [nvarchar](510), @pOrgID [int], @pLocationID [int])
RETURNS [decimal](18, 2) WITH EXECUTE AS CALLER
AS 
BEGIN  
    DECLARE @InHandQty DECIMAL(18,2)  
   
 IF (@pLocationID=0)              
  SET @pLocationID =Null  
  
  
     SELECT @InHandQty=(  
      (SUM(SI.TotalStockReceived) - ( SUM(SI.TotalLocationIssued)+  
      SUM(SI.TotalStockIssued) + SUM(SI.TotalStockReturn)+  
      SUM(SI.TotalStockDamage)))  
      )  
      FROM StockInHand SI   
      WHERE SI.OrgID=@pOrgID   
       AND SI.ProductID=@pProductID  and SI.ReceivedUniqueNumber=@BatchNo   
       AND SI.LocationID=COALESCE(@pLocationID,SI.LocationID)  
      GROUP BY ProductID,SI.ReceivedUniqueNumber  
        
      SET @InHandQty = ISNULL(@InHandQty,0)  
     RETURN(@InHandQty);  
END;  
  




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand_BatchNo_check]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand_BatchNo_check]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[fn_GetStockInHand_BatchNo_check]
   (@pProductID [bigint], @BatchNo [nvarchar](510), @pOrgID [int], @pLocationID [int])
RETURNS [decimal](18, 2) WITH EXECUTE AS CALLER
AS 
BEGIN  
    DECLARE @InHandQty DECIMAL(18,2)  
   
 IF (@pLocationID=0)              
  SET @pLocationID =Null  
  
  
     SELECT @InHandQty=(  
      (SUM(SI.TotalStockReceived) - ( SUM(SI.TotalLocationIssued)+  
      SUM(SI.TotalStockIssued) + SUM(SI.TotalStockReturn)+  
      SUM(SI.TotalStockDamage)))  
      )  
      FROM StockInHand SI   
      WHERE SI.OrgID=@pOrgID   
       AND SI.ProductID=@pProductID  and SI.ReceivedUniqueNumber=@BatchNo   
       AND SI.LocationID=COALESCE(@pLocationID,SI.LocationID)  
      GROUP BY ProductID,SI.ReceivedUniqueNumber  
        
      SET @InHandQty = ISNULL(@InHandQty,0)  
     RETURN(@InHandQty);  
END;  

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHand_Unit]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHand_Unit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetStockInHand_Unit] (@pProductID bigint,@pOrgID int,@pLocationID int)    
RETURNS nvarchar(MAX)    
WITH EXECUTE AS CALLER    
AS    
BEGIN    
    DECLARE @SellingUnit nvarchar(MAX)    
 IF (@pLocationID=0)                
  SET @pLocationID =Null    
    
    
     SELECT @SellingUnit= Convert(nvarchar(max),(    
      SI.BatchNo) )  
      FROM StockInHand SI     
      WHERE SI.OrgID=@pOrgID     
       AND SI.ProductID=@pProductID     
       AND SI.LocationID=COALESCE(@pLocationID,SI.LocationID)    
      GROUP BY ProductID ,BatchNo   
          
      SET @SellingUnit = @SellingUnit   
     RETURN(@SellingUnit);    
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStockInHandByExpDate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetStockInHandByExpDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetStockInHandByExpDate](@pProductID [bigint], @pOrgID [int], @pLocationID [int], @EmpDate [datetime])
RETURNS [decimal](18, 2) WITH EXECUTE AS CALLER
AS 
BEGIN
    DECLARE @InHandQty DECIMAL(18,2)
	
	IF (@pLocationID=0)            
		SET @pLocationID =Null


     SELECT @InHandQty=(
						(SUM(SI.TotalStockReceived) - ( SUM(SI.TotalLocationIssued)+
						SUM(SI.TotalStockIssued) + SUM(SI.TotalStockReturn)+
						SUM(SI.TotalStockDamage)))
						)
						FROM StockInHand SI 
						WHERE SI.OrgID=@pOrgID 
							AND	SI.ProductID=@pProductID 
							AND	SI.LocationID=COALESCE(@pLocationID,SI.LocationID) and   DATEDIFF(M,@EmpDate,SI.ExpiryDate) >= 0
						GROUP BY ProductID
						
      SET @InHandQty = ISNULL(@InHandQty,0)
     RETURN(@InHandQty);
END;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetTestChildCountable]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_GetTestChildCountable]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_GetTestChildCountable] (@OrgID INT, @AttGroupID INT, @Type nvarchar(50))
RETURNS @retChildCountable TABLE 
(
    OrgID INT NOT NULL,
    AttID BIGINT NOT NULL,
    AttType nvarchar(50) NOT NULL
)
AS
BEGIN
	IF (@type=''GRP'')
	BEGIN
		INSERT INTO @retChildCountable
		-- Group content is single test and it''s countable
		SELECT @OrgID AS OrgID,IOM.InvestigationID AS AttID,''INV'' AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvGroupMapMaster IGMM (NOLOCK) ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent=''N'' AND ISNULL(IGMM.Active,''Y'')=''Y''
		INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=IGMM.InvestigationID AND IOM.Iscountable=''YES'' AND IOM.OrgID=@OrgID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''GRP''
		UNION ALL
		-- Group content is group and it''s countable
		SELECT @OrgID AS OrgID,IOG1.AttGroupID AS AttID,IGM1.Type AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvGroupMapMaster IGMM (NOLOCK) ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent=''Y'' AND ISNULL(IGMM.Active,''Y'')=''Y''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IGMM.InvestigationID AND IOG1.Iscountable=''YES''
		INNER JOIN InvGroupMaster IGM1 WITH(NOLOCK) ON IGM1.GroupID=IOG1.AttGroupID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''GRP''
		UNION ALL
		-- Group content is group and it''s non-countable. child is single test and it''s countable
		SELECT @OrgID AS OrgID,IOG1.AttGroupID AS AttID,''INV'' AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvGroupMapMaster IGMM (NOLOCK) ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent=''Y'' AND ISNULL(IGMM.Active,''Y'')=''Y''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IGMM.InvestigationID AND IOG1.Iscountable=''NO''
		INNER JOIN InvGroupMapMaster IGMM1 (NOLOCK) ON IGMM1.GroupID=IOG1.OrgGroupID AND IGMM1.Parent=''N'' AND ISNULL(IGMM1.Active,''Y'')=''Y''
		INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=IGMM1.InvestigationID AND IOM.Iscountable=''YES'' AND IOM.OrgID=@OrgID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''GRP''
		UNION ALL
		-- Group content is group and it''s non-countable. child is group and it''s countable
		SELECT @OrgID AS OrgID,IOG1.AttGroupID AS AttID,IGM1.Type AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvGroupMapMaster IGMM (NOLOCK) ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent=''Y'' AND ISNULL(IGMM.Active,''Y'')=''Y''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IGMM.InvestigationID AND IOG1.Iscountable=''NO''
		INNER JOIN InvGroupMapMaster IGMM1 (NOLOCK) ON IGMM1.GroupID=IOG1.OrgGroupID AND IGMM1.Parent=''Y'' AND ISNULL(IGMM1.Active,''Y'')=''Y''
		INNER JOIN InvOrgGroup IOG2 WITH(NOLOCK) ON IOG2.OrgGroupID=IGMM1.InvestigationID AND IOG2.Iscountable=''YES''
		INNER JOIN InvGroupMaster IGM1 WITH(NOLOCK) ON IGM1.GroupID=IOG2.AttGroupID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''GRP''
		UNION ALL
		-- Group content is group and it''s non-countable. child is group and it''s non-countable. grand child is single test and it''s countable
		SELECT @OrgID AS OrgID,IOM.InvestigationID AS AttID,''INV'' AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvGroupMapMaster IGMM (NOLOCK) ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent=''Y'' AND ISNULL(IGMM.Active,''Y'')=''Y''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IGMM.InvestigationID AND IOG1.Iscountable=''NO''
		INNER JOIN InvGroupMapMaster IGMM1 (NOLOCK) ON IGMM1.GroupID=IOG1.OrgGroupID AND IGMM1.Parent=''N'' AND ISNULL(IGMM1.Active,''Y'')=''Y''
		INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=IGMM1.InvestigationID AND IOM.Iscountable=''YES'' AND IOM.OrgID=@OrgID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''GRP''
	END
	ELSE IF (@type=''PKG'')
	BEGIN
		INSERT INTO @retChildCountable
		-- Package content is single test and it''s countable
		SELECT @OrgID AS OrgID,IOM.InvestigationID AS AttID,''INV'' AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type=''INV''
		INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=IPM.ID AND IOM.Iscountable=''YES'' AND IOM.OrgID=@OrgID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''PKG''
		UNION ALL
		-- Package content is group and it''s countable
		SELECT @OrgID AS OrgID,IOG1.AttGroupID AS AttID,IGM1.Type AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type=''GRP''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IPM.ID AND IOG1.Iscountable=''YES''
		INNER JOIN InvGroupMaster IGM1 WITH(NOLOCK) ON IGM1.GroupID=IOG1.AttGroupID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''PKG''
		UNION ALL
		-- Package content is group and it''s non-countable. child is single test and it''s countable
		SELECT @OrgID AS OrgID,IOG1.AttGroupID AS AttID,''INV'' AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type=''GRP''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IPM.ID AND IOG1.Iscountable=''NO''
		INNER JOIN InvGroupMapMaster IGMM1 (NOLOCK) ON IGMM1.GroupID=IOG1.OrgGroupID AND IGMM1.Parent=''N'' AND ISNULL(IGMM1.Active,''Y'')=''Y''
		INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=IGMM1.InvestigationID AND IOM.Iscountable=''YES'' AND IOM.OrgID=@OrgID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''PKG''
		UNION ALL
		-- Package content is group and it''s non-countable. child is group and it''s countable
		SELECT @OrgID AS OrgID,IOG1.AttGroupID AS AttID,IGM1.Type AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type=''GRP''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IPM.ID AND IOG1.Iscountable=''NO''
		INNER JOIN InvGroupMapMaster IGMM1 (NOLOCK) ON IGMM1.GroupID=IOG1.OrgGroupID AND IGMM1.Parent=''Y'' AND ISNULL(IGMM1.Active,''Y'')=''Y''
		INNER JOIN InvOrgGroup IOG2 WITH(NOLOCK) ON IOG2.OrgGroupID=IGMM1.InvestigationID AND IOG2.Iscountable=''YES''
		INNER JOIN InvGroupMaster IGM1 WITH(NOLOCK) ON IGM1.GroupID=IOG2.AttGroupID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''PKG''
		UNION ALL
		-- Package content is group and it''s non-countable. child is group and it''s non-countable. grand child is single test and it''s countable
		SELECT @OrgID AS OrgID,IOM.InvestigationID AS AttID,''INV'' AS AttType FROM InvOrgGroup IOG (NOLOCK)
		INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON IGM.GroupID=IOG.AttGroupID
		INNER JOIN InvPackageMapping IPM (NOLOCK) ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type=''GRP''
		INNER JOIN InvOrgGroup IOG1 WITH(NOLOCK) ON IOG1.OrgGroupID=IPM.ID AND IOG1.Iscountable=''NO''
		INNER JOIN InvGroupMapMaster IGMM1 (NOLOCK) ON IGMM1.GroupID=IOG1.OrgGroupID AND IGMM1.Parent=''N'' AND ISNULL(IGMM1.Active,''Y'')=''Y''
		INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=IGMM1.InvestigationID AND IOM.Iscountable=''YES'' AND IOM.OrgID=@OrgID
		WHERE IOG.Iscountable=''NO'' AND ISNULL(IOG.IsNonOrderable,''N'')=''N'' AND IOG.OrgID=@OrgID AND IOG.AttGroupID=@AttGroupID AND IGM.Type=''PKG''
	END
	ELSE
	BEGIN
		RETURN
	END
	RETURN
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetTestName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetTestName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE Function [dbo].[Fn_GetTestName](@visitid INT,@orgid int)  
Returns nvarchar(100)  
  
AS  
BEGIN  
	Declare @name nvarchar(max)  
	SET @name=''''  
	/*SELECT @name=coalesce(@name,InvestigationName+'','','''') from   
	PatientInvestigation OI ,PatientVisit PV   
	where OI.PatientVisitId= PV.PatientVisitId and OI.PatientVisitId=@visitid  
	*/  
	select @name=STUFF((SELECT '','' +                             
	   CASE ISNULL(OI.name,''N'') WHEN ''Y'' THEN   OI.name+''*''                             
	   ELSE   OI.name END                             
		AS [text()] FROM OrderedInvestigations OI ,PatientVisit PV   
	where OI.VisitID= PV.PatientVisitId and OI.VisitID=@visitid  and OI.OrgID=@orgid  and Status NOt in(''Cancel'')                
	  --WHERE A.BarcodeNumber = B.BarcodeNumber AND A.Location=B.Location-- AND A.DeptCode=B.DeptCode                                  
	  -- Group by B.TestCode,B.IsStat,B.SampleType,B.ContainerName--,B.DeptCode                                   
	  -- --order by B.DeptCode     
	   for xml PATH(''''), root(''TC''), type                 
		).value(''/TC[1]'',''nvarchar(max)'')                 
	   , 1, 1, '''')         
	   
	   REturn @name  
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetTestNamebak]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fn_GetTestNamebak]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE function [dbo].[Fn_GetTestNamebak](@AssignNo bigint)      
returns nvarchar(max)      
as       
begin      
	 declare @rolename  nvarchar(max)      
	 declare @GetRole table(rowno int identity(1,1),Name nvarchar(max),status nvarchar(max))      
	 insert into @GetRole(name,status)     
	 ------------------Get Table wise Record ----------------------    
	 select Name,status from (select ROW_NUMBER()over(partition by OI.VisitID,PV.PatientVisitId order by PV.PatientVisitId asc ) as rowno,Name as name,Status from orderedinvestigations OI inner join patientvisit PV
	 on OI.VisitID=PV.PatientVisitId  where OI.AccessionNumber=@AssignNo) TEMP where rowno=1      
	 declare @rocount int       
	 select @rocount=COUNT(Status) from @GetRole      
	 declare @count int =1      
	 set @rolename=''<table style="border-style: solid;border-color: #A9BCF5;background-color:#F5A9A9">''     
	 if(@rocount=0)      
	 begin      
		 set @rolename=@rolename+''<tr><td style="border: 1px solid black"></td><td style="border: 1px solid black"></td></tr>''      
	 end       
	 while(@rocount>0)      
	 begin      
		 declare @Role nvarchar(max)    
		 declare @LoginName nvarchar(max)    
		 select @LoginName=name,@Role=status from @GetRole where rowno=@count    
		 set @rolename=@rolename+''<tr><td style="border: 1px solid black">''+@Role+''</td><td style="border: 1px solid black">''+@LoginName+''</td></tr>''      
		         
		 set @count=@count+1      
		 set @rocount=@rocount-1      
	 end       
	 set @rolename=@rolename+''</table>''      
	 return @rolename      
end

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[FN_getVisitNumberTAT_DIXIT]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_getVisitNumberTAT_DIXIT]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[FN_getVisitNumberTAT_DIXIT]
(
    @OrgID int
	, @invisitid bigint
)
RETURNS datetime
AS
BEGIN
	DECLARE @ptat datetime
	SELECT TOP 1 
       @ptat = fb.ReportDateTime 
       FROM FinalBill fb (nolock) 
       INNER join VisitClientMapping VCM With(nolock)
                    on VCM.FinalBillID = FB.FinalBillID
                    and VCM.IsActive is null
                    and VCM.OrgID = FB.OrgID
       WHERE VCM.VisitID = @invisitid
       AND VCM.OrgID = @OrgID
    RETURN(@ptat);
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_mydbr_column_exists]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_mydbr_column_exists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create function [dbo].[fn_mydbr_column_exists]( @table sysname, @column sysname )
returns tinyint
as
begin
declare @ret tinyint

if exists (
  select * 
  from INFORMATION_SCHEMA.COLUMNS c
  where c.TABLE_CATALOG=db_name() and c.TABLE_NAME=@table and c.COLUMN_NAME=@column)
  select @ret=1
else 
  select @ret=0

return @ret
end


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[FN_OrderbleDept]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_OrderbleDept]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'  
CREATE FUNCTION [dbo].[FN_OrderbleDept] (@Orgid INT)

RETURNS @DeptTest TABLE (

	Id BIGINT

	,Type VARCHAR(50)

	,Orgid INT

	,DeptName VARCHAR(100)

	)

AS

BEGIN

	INSERT INTO @DeptTest 

	   (

		Id

		,Type

		,Orgid

		,DeptName

		)

	SELECT IOM.Investigationid

		,''INV'' AS Testtype

		,IOM.Orgid

		,Dept.Deptname

	FROM InvestigationOrgMapping IOM(NOLOCK)

	INNER JOIN InvDeptMaster Dept(NOLOCK) ON IOM.Orgid = Dept.Orgid

		AND IOM.Deptid = Dept.Deptid

	WHERE IOM.Orgid = @Orgid

	

	UNION ALL

	

	SELECT Grp.Groupid

		,Grp.type

		,grporg.Orgid

		,max(Dept.Deptname) AS Deptname

	FROM invgroupmaster Grp(NOLOCK)

	INNER JOIN invorggroup Grporg(NOLOCK) ON grp.groupid = grporg.attgroupid

	INNER JOIN invgroupmapmaster IMap(NOLOCK) ON GRPorg.Orggroupid = Imap.Groupid

	INNER JOIN investigationorgmapping IOM(NOLOCK) ON Grporg.Orgid = IOM.Orgid

		AND IMap.Investigationid = IOM.Investigationid

	INNER JOIN invdeptmaster dept(NOLOCK) ON IOM.Deptid = Dept.Deptid

		AND IOM.Orgid = Dept.Orgid

	WHERE isnull(IMap.active, ''Y'') = ''Y''

		AND IMap.parent = ''N''

		AND Grp.Type = ''GRP''

		AND Grporg.Orgid = @Orgid

	GROUP BY Grp.Groupid

		,Grp.type

		,grporg.Orgid

	

	UNION ALL

	

	SELECT Grp.Groupid

		,Grp.type

		,grporg.Orgid

		,Max(Dept.Deptname) AS DeptName

	FROM invgroupmaster Grp(NOLOCK)

	INNER JOIN invorggroup Grporg(NOLOCK) ON grp.groupid = grporg.attgroupid

	INNER JOIN invgroupmapmaster IMap(NOLOCK) ON GRPorg.Orggroupid = Imap.Groupid

	INNER JOIN invorggroup Grporg2(NOLOCK) ON Imap.investigationid = grporg2.Orggroupid

	INNER JOIN invgroupmapmaster IMap2(NOLOCK) ON GRPorg2.Orggroupid = Imap2.Groupid

	INNER JOIN investigationorgmapping IOM(NOLOCK) ON Grporg2.Orgid = IOM.Orgid

		AND IMap2.Investigationid = IOM.Investigationid

	INNER JOIN invdeptmaster dept(NOLOCK) ON IOM.Deptid = Dept.Deptid

		AND IOM.Orgid = Dept.Orgid

	WHERE isnull(IMap.active, ''Y'') = ''Y''

		AND IMap.parent = ''Y''

		AND Grp.Type = ''GRP''

		AND isnull(IMap2.active, ''Y'') = ''Y''

		AND IMap2.parent = ''N''

		AND Grporg.Orgid = @Orgid

	GROUP BY Grp.Groupid

		,Grp.type

		,grporg.Orgid

	

	UNION ALL

	

	SELECT Grp.Groupid

		,Grp.type

		,grporg.Orgid

		,Max(Dept.Deptname) AS DeptName

	FROM invgroupmaster Grp(NOLOCK)

	INNER JOIN invorggroup Grporg(NOLOCK) ON grp.groupid = grporg.attgroupid

	INNER JOIN InvPackageMapping IMap(NOLOCK) ON GRPorg.Orggroupid = Imap.packageid

	INNER JOIN investigationorgmapping IOM(NOLOCK) ON Grporg.Orgid = IOM.Orgid

		AND IMap.ID = IOM.Investigationid

	INNER JOIN invdeptmaster dept(NOLOCK) ON IOM.Deptid = Dept.Deptid

		AND IOM.Orgid = Dept.Orgid

	WHERE isnull(IMap.active, ''A'') = ''A''

		AND IMap.type = ''INV''

		AND Grp.Type = ''PKG''

		AND Grporg.Orgid = @Orgid

	GROUP BY Grp.Groupid

		,Grp.type

		,grporg.Orgid

	

	UNION ALL

	

	SELECT Grp.Groupid

		,Grp.type

		,grporg.Orgid

		,Max(Dept.Deptname) AS DeptName

	FROM invgroupmaster Grp(NOLOCK)

	INNER JOIN invorggroup Grporg(NOLOCK) ON grp.groupid = grporg.attgroupid

	INNER JOIN InvPackageMapping IMap(NOLOCK) ON GRPorg.Orggroupid = Imap.packageid

	INNER JOIN invgroupmapmaster grpmap(NOLOCK) ON Imap.ID = grpmap.Groupid

	INNER JOIN investigationorgmapping IOM(NOLOCK) ON Grporg.Orgid = IOM.Orgid

		AND grpmap.investigationid = IOM.Investigationid

	INNER JOIN invdeptmaster dept(NOLOCK) ON IOM.Deptid = Dept.Deptid

		AND IOM.Orgid = Dept.Orgid

	WHERE isnull(IMap.active, ''A'') = ''A''

		AND IMap.type = ''GRP''

		AND Grp.Type = ''PKG''

		AND isnull(grpmap.active, ''Y'') = ''Y''

		AND grpmap.parent = ''N''

		AND Grporg.Orgid = @Orgid

	GROUP BY Grp.Groupid

		,Grp.type

		,grporg.Orgid

	

	UNION ALL

	

	SELECT Grp.Groupid

		,Grp.type

		,grporg.Orgid

		,Max(Dept.Deptname) AS DeptName

	FROM invgroupmaster Grp(NOLOCK)

	INNER JOIN invorggroup Grporg(NOLOCK) ON grp.groupid = grporg.attgroupid

	INNER JOIN InvPackageMapping IMap(NOLOCK) ON GRPorg.Orggroupid = Imap.packageid

	INNER JOIN invgroupmapmaster grpmap(NOLOCK) ON Imap.ID = grpmap.Groupid

	INNER JOIN invgroupmapmaster grpmap2(NOLOCK) ON grpmap.investigationid = grpmap2.Groupid

	INNER JOIN investigationorgmapping IOM(NOLOCK) ON Grporg.Orgid = IOM.Orgid

		AND grpmap2.investigationid = IOM.Investigationid

	INNER JOIN invdeptmaster dept(NOLOCK) ON IOM.Deptid = Dept.Deptid

		AND IOM.Orgid = Dept.Orgid

	WHERE isnull(IMap.active, ''A'') = ''A''

		AND IMap.type = ''GRP''

		AND Grp.Type = ''PKG''

		AND isnull(grpmap.active, ''Y'') = ''Y''

		AND grpmap.parent = ''Y''

		AND isnull(grpmap2.active, ''Y'') = ''Y''

		AND grpmap2.parent = ''N''

		AND Grporg.Orgid = @Orgid

	GROUP BY Grp.Groupid

		,Grp.type

		,grporg.Orgid



	RETURN

END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[FN_OrderbleTest]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_OrderbleTest]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

CREATE Function [dbo].[FN_OrderbleTest]

(

@P_Orgid Int

)

Returns @Tbl_OrderbleTest table

(

Tcode Varchar(100),

Type Varchar(50),

ID BigInt,

TestName Varchar(255)

)



As

Begin





Declare @CodeSchemeID Int

 Select @CodeSchemeID= Codetypeid from CodingSchemeOrgMapping(Nolock) where Orgid=@P_Orgid and Isprimary=''Y''

 



Insert Into @Tbl_OrderbleTest(Tcode,Type,ID,TestName)

Select cm.Codename,''INV'' as Type,IOM.Investigationid,IOM.DisplayText from CodeMaster CM (Nolock)

INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 

INNER Join InvestigationOrgMapping IOM (Nolock) ON IOM.InvestigationID=CP.IdentifyingID 

INNER JOIN InvestigationOrgAttributes IOA (Nolock) ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 

INNER JOIN InvestigationMaster IM (Nolock) ON IM.InvestigationID =IOM.InvestigationID 

WHERE CM.CodeSchemeID =@CodeSchemeID 

AND CP.IdentifyingType =''Investigations'' 

AND IOM.OrgID =@P_Orgid

AND Isnull(IOM.Display,''Y'')=''Y''



Union all



Select CM.CodeName,''GRP'' as Type,IOM.Attgroupid,IOM.DisplayText from CodeMaster CM (Nolock)

INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 

INNER Join InvOrgGroup  IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 

INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  

WHERE CM.CodeSchemeID =@CodeSchemeID

AND CP.IdentifyingType =''GRP'' 

AND IOM.OrgID =@P_Orgid

AND ISNULL(IOM.IsNonOrderable,''N'')=''N''



Union all



Select CM.CodeName,''PKG'' as Type,IOM.Attgroupid,IOM.DisplayText from CodeMaster CM (Nolock)

INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 

INNER Join InvOrgGroup IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 

INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  

WHERE CM.CodeSchemeID =@CodeSchemeID

AND CP.IdentifyingType =''PKG'' 

AND IOM.OrgID =@P_Orgid

AND ISNULL(IOM.IsNonOrderable,''N'')=''N''





Return



End





' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[FN_REMOVE_SPECIAL_CHARACTER]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FN_REMOVE_SPECIAL_CHARACTER]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[FN_REMOVE_SPECIAL_CHARACTER] (      
 @INPUT_STRING nvarchar(300))    
RETURNS nvarchar(300)    
AS     
BEGIN    
     
--declare @testString nvarchar(100),    
DECLARE @NEWSTRING nvarchar(100)     
-- set @teststring = ''@san?poojari(darsh)''    
 SET @NEWSTRING = @INPUT_STRING ;     
With SPECIAL_CHARACTER as    
(    
SELECT ''>'' as item    
UNION ALL     
SELECT ''<'' as item    
UNION ALL     
SELECT ''('' as item    
UNION ALL     
SELECT '')'' as item    
UNION ALL     
SELECT ''!'' as item    
UNION ALL     
SELECT ''?'' as item    
UNION ALL     
SELECT ''@'' as item    
UNION ALL     
SELECT ''*'' as item    
UNION ALL     
SELECT ''%'' as item    
UNION ALL     
SELECT ''$'' as item   
UNION ALL     
SELECT ''&'' as item  
UNION ALL     
SELECT '':'' as item  
UNION ALL     
SELECT ''#'' as item 
UNION ALL     
SELECT '';'' as item 
UNION ALL     
SELECT ''&#x0D;'' as item 
UNION ALL     
SELECT ''#'' as item
UNION ALL     
SELECT ''!'' as item
UNION ALL     
SELECT ''^'' as item

 )    
SELECT @NEWSTRING = Replace(@NEWSTRING, ITEM, '''') FROM SPECIAL_CHARACTER      
return @NEWSTRING     
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_seconds_to_time]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_seconds_to_time]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create function [dbo].[fn_seconds_to_time] ( @secs int )
returns datetime
as
begin
  if (@secs is null) return null

  return convert( datetime, CONVERT(nvarchar(6), @secs/3600)
  + '':'' + RIGHT(''0'' + CONVERT(nvarchar(2), (@secs % 3600) / 60), 2)
  + '':'' + RIGHT(''0'' + CONVERT(nvarchar(2), @secs % 60), 2) )
end


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_seconds_to_time_str]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_seconds_to_time_str]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create function [dbo].[fn_seconds_to_time_str]( @secs int )
returns nvarchar(8)
as
begin
  if (@secs is null) return null

  return RIGHT(''0'' + CONVERT(nvarchar(6), @secs/3600), 2)
  + '':'' + RIGHT(''0'' + CONVERT(nvarchar(2), (@secs % 3600) / 60), 2)
  + '':'' + RIGHT(''0'' + CONVERT(nvarchar(2), @secs % 60), 2)
end


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_ShowInQMSDashboard]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_ShowInQMSDashboard]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE function [dbo].[fn_ShowInQMSDashboard]
(@fromDate datetime, @Date datetime,@toDate datetime,@checDiff int)
returns  int
as
BEGIN
declare @out int=0
if @checDiff=0 and @Date=@fromDate
begin
set @out=1
end
if @checDiff=1 and @Date >=@fromDate and @Date <=@toDate
begin
set @out=1
end
return @out
end

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_SplitExact]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_SplitExact]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_SplitExact](
 @sInputList nvarchar(MAX), -- List of delimited items      
 @sDelimiter nvarchar(MAX) = '','', -- delimiter that separates items    
 @Particularrow int 
)
returns nvarchar(50)
as
begin
DECLARE @FinalNetAmount  decimal(18,2)
	DECLARE @tmpBill_1 AS TABLE                                                  
	(  
		RowID    int  IDENTITY,                                              
		Discount nvarchar(50)                                              
	)  
DECLARE @sItem nvarchar(max)    
WHILE CHARINDEX(@sDelimiter,@sInputList,0) <> 0     
BEGIN     
 SELECT      
  @sItem=RTRIM(LTRIM(SUBSTRING(@sInputList,1,CHARINDEX(@sDelimiter,@sInputList,0)-1))),      
  @sInputList=RTRIM(LTRIM(SUBSTRING(@sInputList,CHARINDEX(@sDelimiter,@sInputList,0)+LEN(@sDelimiter),LEN(@sInputList))))      
     
 IF LEN(@sItem) > 0      
  INSERT INTO @tmpBill_1     
  SELECT @sItem     
 END     
 IF LEN(@sInputList) > 0     
  INSERT INTO @tmpBill_1 SELECT @sInputList -- Put the last item in    
     
	SET @FinalNetAmount = (Select T.Discount from @tmpBill_1 T where RowID=@Particularrow)
	 
    Return @FinalNetAmount
end;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_SplitString]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_SplitString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--SELECT dbo.fn_SplitString(''/Reception/PatientVisit.aspx'')
CREATE FUNCTION [dbo].[fn_SplitString] 
(
@str nvarchar(255)
)
RETURNS nvarchar(255)
AS
BEGIN
		DECLARE @str1 nvarchar(255)
		SET @str = substring(@str,charindex(''/'',@str)+1,len(@str))  
		SET @str1= substring(@str,1,(charindex(''/'',@str)-1)) 
		Return @str1
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_StripCharacters]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_StripCharacters]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_StripCharacters]
(
    @String NVARCHAR(MAX), 
    @MatchExpression VARCHAR(255)
)
RETURNS NVARCHAR(MAX)
AS
BEGIN
    SET @MatchExpression =  ''%[''+@MatchExpression+'']%''

    WHILE PatIndex(@MatchExpression, @String) > 0
        SET @String = Stuff(@String, PatIndex(@MatchExpression, @String), 1, '''')

    RETURN @String

END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_XML]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_XML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE  FUNCTION [dbo].[fn_XML]    
(    
 @StrXML nvarchar(500)  
  
)    
RETURNS nvarchar(50)    
AS    
BEGIN    
    
declare @Data xml
DECLARE @VID as nvarchar(50)
select @Data = @StrXML

return(
SELECT T.C.value(''data(.)'', ''nvarchar(128)'') as [Data]
from @Data.nodes(''/ContextInfo/VisitID'') as T(C) );
    
END  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnCheckConsumableQuantity]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnCheckConsumableQuantity]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
/******  [dbo].[fnCheckConsumableQuantity]  ******/  

CREATE FUNCTION [dbo].[fnCheckConsumableQuantity]    
(    
    @OrgID BIGINT,                                                    
 @OrgAddressID BIGINT,      
    @LocationID INT,  
    @InputItemsBasket  AS InventoryItemsMapping  READONLY  
)    
RETURNS  @OutputItemsBasket TABLE(StockInHandID bigint,  
         ProductID bigint,  
         Batch nvarchar(20),  
         Quantity decimal(18,2),  
         InHandQuantity decimal(18,2),  
         Status nvarchar(10))  
           
AS    
BEGIN  
       
 INSERT INTO @OutputItemsBasket(ProductID,  
    Batch,Quantity,  
    StockInHandID,  
    InHandQuantity,Status)  
 SELECT IIB.ProductID,  
    IIB.BatchNo,IIB.Quantity,        
    IIB.ID,  
    (ISNULL(SIH.TotalStockReceived,0)-(ISNULL(SIH.TotalStockIssued,0)+                          
    ISNULL(SIH.TotalLocationIssued,0)+ISNULL(SIH.TotalStockDamage,0)+                         
    ISNULL(SIH.TotalStockReturn,0))) AS InHandQuantity,  
   CASE WHEN ((ISNULL(SIH.TotalStockReceived,0)-(ISNULL(SIH.TotalStockIssued,0)+                          
    ISNULL(SIH.TotalLocationIssued,0)+ISNULL(SIH.TotalStockDamage,0)+                         
    ISNULL(SIH.TotalStockReturn,0))) < IIB.Quantity)  
    THEN   
     ''Y''  
    ELSE   
     ''N''  
    END AS Description  FROM @InputItemsBasket IIB   
    INNER JOIN StockInHand SIH ON IIB.ID=SIH.StockInHandID            
 WHERE SIH.ProductId=IIB.ProductID AND SIH.OrgID=@OrgID   
  AND SIH.OrgAddressID=@OrgAddressID AND SIH.LocationId=@LocationID  
  AND SIH.BatchNo=IIB.BatchNo     
    
RETURN    
    
END;




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnConvertIntToRoman]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnConvertIntToRoman]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnConvertIntToRoman](@i INT)
RETURNS nvarchar(100)
AS
BEGIN
    RETURN Replicate(''M'', @i/1000) 
			+ REPLACE(REPLACE(REPLACE(
                  Replicate(''C'', @i%1000/100),
                  Replicate(''C'', 9), ''CM''),
                  Replicate(''C'', 5), ''D''),
                  Replicate(''C'', 4), ''CD'')
             + REPLACE(REPLACE(REPLACE(
                  Replicate(''X'', @i%100 / 10),
                  Replicate(''X'', 9),''XC''),
                  Replicate(''X'', 5), ''L''),
                  Replicate(''X'', 4), ''XL'')
             + REPLACE(REPLACE(REPLACE(
                  Replicate(''I'', @i%10),
                  Replicate(''I'', 9),''IX''),
                  Replicate(''I'', 5), ''V''),
                  Replicate(''I'', 4),''IV'')
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnFormatDate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnFormatDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnFormatDate] (@Datetime DATETIME, @FormatMask nvarchar(32),@ResetBy int)      

RETURNS nvarchar(32)        
AS        
BEGIN        
        
    DECLARE @StringDate nvarchar(32)        
    SET @StringDate = @FormatMask        
    IF (CHARINDEX (''YYYY'',@StringDate) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''YYYY'',DATENAME(YY, @Datetime))            
            
    ELSE IF (CHARINDEX (''YY'',@StringDate) > 0)            
      -- SET @StringDate = REPLACE(@StringDate, ''YY'', RIGHT(DATENAME(YY, @Datetime),2))   
     BEGIN  
     DECLARE @MONTH smalldatetime   
     DECLARE @YEAR nvarchar(20)   
     DECLARE @yyyy nvarchar(20)  
     SET @YEAR  = CAST(YEAR(GETDATE()) AS int)  
     SET @MONTH = CAST(MONTH(GETDATE())AS int)   

     IF (@ResetBy =null or @ResetBy =0 or @ResetBy ='''')

     BEGIN

		set @ResetBy = 3

     END  

     IF(@MONTH > = @ResetBy )  
     BEGIN   
     select @Datetime =DATEADD(YY , DATEDIFF(YY, 0,DATEADD(YY, 0, GETDATE())),0)  
     END  
     ELSE   
     BEGIN   
     select @Datetime=DATEADD(YY , DATEDIFF(YY, 0,DATEADD(YY, 0, GETDATE())),0)  
     END       
     set @yyyy = DATEPART(YY, @Datetime)  
     set @StringDate = RIGHT(@yyyy,2)          
       --SET @StringDate = REPLACE(@StringDate, ''YY'', RIGHT(DATENAME(YY, @Datetime),2))     
       END             
            
    ELSE IF (CHARINDEX (''Month'',@StringDate) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''Month'',DATENAME(MM, @Datetime))            
            
    ELSE IF (CHARINDEX (''MON'',@StringDate COLLATE SQL_Latin1_General_CP1_CS_AS)>0)            
       SET @StringDate = REPLACE(@StringDate, ''MON'',LEFT(UPPER(DATENAME(MM, @Datetime)),3))            
            
    ELSE IF (CHARINDEX (''MMM'',@StringDate COLLATE SQL_Latin1_General_CP1_CS_AS) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''MMM'',LEFT(DATENAME(MM, @Datetime),3))            
            
    ELSE IF (CHARINDEX (''MM'',@StringDate) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''MM'',RIGHT(''0''+CONVERT(nvarchar,DATEPART(MM, @Datetime)),2))            
            
    ELSE IF (CHARINDEX (''M'',@StringDate) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''M'',CONVERT(nvarchar,DATEPART(MM, @Datetime)))            
            
    ELSE IF (CHARINDEX (''DD'',@StringDate) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''DD'',RIGHT(''0''+DATENAME(DD, @Datetime),2))            
            
    ELSE IF (CHARINDEX (''D'',@StringDate) > 0)            
       SET @StringDate = REPLACE(@StringDate, ''D'',DATENAME(DD, @Datetime))          
        
RETURN @StringDate        
END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnFormatDate_Invoice]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnFormatDate_Invoice]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnFormatDate_Invoice] (@Datetime DATETIME, @FormatMask nvarchar(32))        
RETURNS nvarchar(32)          
AS          
BEGIN          
          
    DECLARE @StringDate nvarchar(32)          
    SET @StringDate = @FormatMask          
    IF (CHARINDEX (''YYYY'',@StringDate) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''YYYY'',DATENAME(YY, @Datetime))              
              
    ELSE IF (CHARINDEX (''YY'',@StringDate) > 0)              
      -- SET @StringDate = REPLACE(@StringDate, ''YY'', RIGHT(DATENAME(YY, @Datetime),2))     
     BEGIN    
     DECLARE @MONTH smalldatetime     
     DECLARE @YEAR nvarchar(20)     
     DECLARE @yyyy nvarchar(20)    
     SET @YEAR  = CAST(YEAR(GETDATE()) AS int)    
     SET @MONTH = CAST(MONTH(GETDATE())AS int)     
     IF(@MONTH>4 )    
     BEGIN     
     select @Datetime =DATEADD(YY , DATEDIFF(YY, 0,DATEADD(YY, 0, GETDATE())),0)    
     END    
     ELSE     
     BEGIN     
     select @Datetime=DATEADD(YY , DATEDIFF(YY, 0,DATEADD(YY, -1, GETDATE())),0)    
     END         
     set @yyyy = DATEPART(YY, @Datetime)    
     set @StringDate = RIGHT(@yyyy,2)            
       --SET @StringDate = REPLACE(@StringDate, ''YY'', RIGHT(DATENAME(YY, @Datetime),2))       
       END               
              
    ELSE IF (CHARINDEX (''Month'',@StringDate) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''Month'',DATENAME(MM, @Datetime))              
              
    ELSE IF (CHARINDEX (''MON'',@StringDate COLLATE SQL_Latin1_General_CP1_CS_AS)>0)              
       SET @StringDate = REPLACE(@StringDate, ''MON'',LEFT(UPPER(DATENAME(MM, @Datetime)),3))              
              
    ELSE IF (CHARINDEX (''MMM'',@StringDate COLLATE SQL_Latin1_General_CP1_CS_AS) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''MMM'',LEFT(DATENAME(MM, @Datetime),3))              
              
    ELSE IF (CHARINDEX (''MM'',@StringDate) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''MM'',RIGHT(''0''+CONVERT(nvarchar,DATEPART(MM, @Datetime)),2))              
              
    ELSE IF (CHARINDEX (''M'',@StringDate) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''M'',CONVERT(nvarchar,DATEPART(MM, @Datetime)))              
              
    ELSE IF (CHARINDEX (''DD'',@StringDate) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''DD'',RIGHT(''0''+DATENAME(DD, @Datetime),2))              
              
    ELSE IF (CHARINDEX (''D'',@StringDate) > 0)              
       SET @StringDate = REPLACE(@StringDate, ''D'',DATENAME(DD, @Datetime))            
          
RETURN @StringDate          
END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGeneratePatientNumberCustomLogic]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGeneratePatientNumberCustomLogic]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'/****** Object:  UserDefinedFunction [dbo].[fnGeneratePatientNumberCustomLogic]    Script Date: 25 March 2013 ******/
/* Purpose: This is called inside fnGetIDWithPattern to generate Patient Number based on custom logic instead of generation based on inbuilt pattern.
This is specifically written for Sanglah */
Create Function [dbo].[fnGeneratePatientNumberCustomLogic] (@Input nvarchar(50)) Returns nvarchar(50)
As
Begin
	DECLARE @PatternTable  TABLE(RowNo INT IDENTITY(1,1), PatternValue Int)
	Declare @PatternText nvarchar(50)
	INSERT @PatternTable SELECT item from  dbo.[fnSplit] (@Input, ''.'')    
	--select * from @PatternTable
	SELECT @PatternText = COALESCE(@PatternText, '''') + CAST(PatternValue as nvarchar(2)) + ''.'' from @PatternTable
	SELECT @PatternText = Ltrim(Rtrim(Reverse(Substring(REVERSE(@PatternText), 2, LEN(@PatternText)))))
	--SELECT @PatternText ''Current Number''
	
	Declare @count int, @TotalCount int, @LoopNumber Int, @CheckBit Int, @Cascade bit
	Set @LoopNumber = 1
	Select @TotalCount = Count(1) From @PatternTable
	Set @count = @TotalCount
	While (@count > @LoopNumber)
	Begin
			Select @CheckBit = PatternValue From @PatternTable Where RowNo = @count
			If (@count = @TotalCount)
			Begin
				IF (@CheckBit = 99)
				Begin
					Update @PatternTable Set PatternValue = 1 Where RowNo = @count
					Set @count = @count - 1
					Set @Cascade = 1
				End
				Else
				Begin 
					Set @CheckBit = @CheckBit + 1
					Update @PatternTable Set PatternValue =@CheckBit Where RowNo = @count
					Break
				End
			End
			Else If (@Cascade = 1)
			Begin
				Set @Cascade = 0
				Select @CheckBit = PatternValue From @PatternTable Where RowNo = @count
				IF (@CheckBit = 99)
				Begin
					Update @PatternTable Set PatternValue = 1 Where RowNo = @count
					Set @count = @count - 1
					Set @Cascade = 1
				End
				Else
				Begin 
					Select @CheckBit = @CheckBit + 1
					Update @PatternTable Set PatternValue = @CheckBit Where RowNo = @count
					Break
				End
			End
			Else 
			Begin
				Set @count = @count - 1
			End
	End
	-- select * from @PatternTable
	--select Convert(nvarchar, PatternValue) + ''.'' from @PatternTable for xml path('''')
	SELECT @PatternText = ''''
	SELECT @PatternText = COALESCE(@PatternText, '''') + CAST(PatternValue as nvarchar(2)) + ''.'' from @PatternTable
	SELECT @PatternText = Ltrim(Rtrim(Reverse(Substring(REVERSE(@PatternText), 2, LEN(@PatternText)))))
	Return @PatternText
End



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetAmtReceivedDtls]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetAmtReceivedDtls]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetAmtReceivedDtls]            
(            
    @porgID INT,        
     @pCurrencyID INT,             
    @pfDate DATETIME,             
    @ptDate DATETIME            
)            
RETURNS   @AmtRcvdDtlsTbl TABLE (            
    FinalBillID BIGINT,             
    VisitID BIGINT,             
    BillDate DATETIME,            
    AmtReceived DECIMAL(18,2),            
    CASH DECIMAL(18,2),             
    Cheque DECIMAL(18,2),             
    DemandDraft DECIMAL(18,2),             
    Cards DECIMAL(18,2),        
     PaidCurrency  nvarchar(100),          
  PaidCurrencyAmount DECIMAL(18,2),      
  DepositUsed DECIMAL(18,2)               
    )            
AS            
BEGIN               
   IF ( @pCurrencyID = 0)        
     SET @pCurrencyID = NULL          
INSERT INTO  @AmtRcvdDtlsTbl (FinalBillID, VisitID, BillDate, AmtReceived, CASH, Cheque, DemandDraft, Cards,PaidCurrency,PaidCurrencyAmount,DepositUsed)            
            
SELECT   FinalBillID AS FinalBillID,             
    VisitID,             
    CONVERT(nvarchar,CreatedAt,103) as BillDate,            
    (isNull(SUM([CASH]),0)) + (isNull(SUM([Cheque]),0)) + (isNull(Sum([DemandDraft]),0)) + (isNull(SUM([Cards]),0))  AS AmtReceived,            
    SUM([CASH]) AS CASH, SUM([Cheque]) AS Cheque, Sum([DemandDraft]) AS DemandDraft, SUM([Cards]) AS Cards, PaidCurrencyCode ,sum(PaidCurrencyAmount),sum(DepositUsed)             
FROM            
(            
 SELECT  ARD.FinalBillID, FB.VisitID, (ARD.AmtReceived - ISNULL(PDU.AmountUsed,0)) AS AmtReceived, ARD.CreatedAt,            
    CASE             
     WHEN PT.PaymentName NOT IN(''CASH'',''Cheque'',''Demand Draft'') THEN ''Cards''                  
    ELSE  PT.PaymentName END as PaymentName        
     , ISNULL(CM.CurrencyCode,        
         (SELECT CM.CurrencyCode FROM CurrencyOrgMapping COM INNER JOIN CurrencyMaster CM ON COM.CurrencyID = CM.CurrencyID AND COM.OrgID = @pOrgId AND COM.IsBaseCurrency = ''Y'')        
         ) AS PaidCurrencyCode,        
          ISNULL(ARD.OtherCurrencyAmount,ARD.AmtReceived) AS PaidCurrencyAmount,PDU.AmountUsed AS DepositUsed             
 FROM  AmountReceivedDetails ARD             
    INNER JOIN PaymentType PT ON ARD.TypeID = PT.PaymentTypeID            
    INNER JOIN FinalBill FB ON ARD.FinalBillID = FB.FinalBillID            
    INNER JOIN PatientVisit PV ON FB.VisitID = PV.PatientVisitId          
    LEFT JOIN CurrencyMaster CM ON CM.CurrencyID = ARD.PaidCurrencyID        
   LEFT JOIN PatientDepositUsage PDU ON PDU.PatientID = PV.PatientID AND PDU.OrgID = PV.OrgID AND (PDU.ReceiptNo = ARD.ReceiptNO OR ARD.ReceiptNO IS NULL OR PDU.ReceiptNo IS NULL) AND (PDU.FinalBillID = ARD.FinalBillID OR PDU.FinalBillID = FB.FinalBillID)                      
 WHERE  PV.OrgID = @porgID            
    AND PV.VisitType = 1            
    AND ARD.CreatedAt BETWEEN @pfDate AND @ptDate        
     AND (ARD.PaidCurrencyID = COALESCE(@pCurrencyID,ARD.PaidCurrencyID) OR  ARD.PaidCurrencyID IS NULL)                  
             
            
) ps            
PIVOT            
(            
 SUM(ps.AmtReceived) FOR PaymentName IN ([CASH], [Cheque], [DemandDraft], [Cards])            
)AS PVT             
GROUP BY FinalBillID, VisitID, CONVERT(nvarchar,CreatedAt,103) ,PaidCurrencyCode              
ORDER BY  CONVERT(datetime,CONVERT(nvarchar,CreatedAt,103))            
            
RETURN            
            
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetBillWiseReceived]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetBillWiseReceived]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetBillWiseReceived]            
(            
    @porgID INT, 
     @pCurrencyID INT,            
    @pfDate DATETIME,             
    @ptDate DATETIME            
)            
RETURNS   @AmtRcvdDtlsTbl TABLE (            
    FinalBillID BIGINT,             
    VisitID BIGINT,             
    BillDate DATETIME,            
    AmtReceived DECIMAL(18,2),            
    CASH DECIMAL(18,2),             
    Cheque DECIMAL(18,2),             
    DemandDraft DECIMAL(18,2),             
    Cards DECIMAL(18,2),
     PaidCurrency  nvarchar(100),  
  PaidCurrencyAmount DECIMAL(18,2)             
    )            
AS            
BEGIN  
IF ( @pCurrencyID = 0)
     SET @pCurrencyID = NULL              
--SELECT 1 FROM dbo.fnGetBillWiseReceived (26,''19/07/2010 00:00:00'',''19/07/2010 23:59:59'')           
INSERT INTO  @AmtRcvdDtlsTbl (FinalBillID, VisitID, BillDate, AmtReceived, CASH, Cheque, DemandDraft, Cards,PaidCurrency,PaidCurrencyAmount)            
            
SELECT FinalBillID,             
    VisitID,             
    CONVERT(nvarchar,CreatedAt,103) as BillDate,            
    (isNull(SUM([CASH]),0)) + (isNull(SUM([Cheque]),0)) + (isNull(Sum([DemandDraft]),0)) + (isNull(SUM([Cards]),0))  AS AmtReceived,            
    SUM([CASH]) AS CASH, SUM([Cheque]) AS Cheque, Sum([DemandDraft]) AS DemandDraft, SUM([Cards]) AS Cards, PaidCurrencyCode ,sum(PaidCurrencyAmount)           
FROM            
(            
 SELECT  ARD.FinalBillID, FB.VisitID, ARD.AmtReceived,   
 ARD.CreatedAt,            
 --FB.CreatedAt,  
    CASE             
     WHEN PT.PaymentName NOT IN(''CASH'',''Cheque'',''Demand Draft'') THEN ''Cards''                  
    ELSE  PT.PaymentName END as PaymentName
    , ISNULL(CM.CurrencyCode,
         (SELECT CM.CurrencyCode FROM CurrencyOrgMapping COM INNER JOIN CurrencyMaster CM ON COM.CurrencyID = CM.CurrencyID AND COM.OrgID = @pOrgId AND COM.IsBaseCurrency = ''Y'')
         ) AS PaidCurrencyCode,
          ISNULL(ARD.OtherCurrencyAmount,ARD.AmtReceived) AS PaidCurrencyAmount          
 FROM  AmountReceivedDetails ARD             
    INNER JOIN PaymentType PT ON ARD.TypeID = PT.PaymentTypeID            
    INNER JOIN FinalBill FB ON ARD.FinalBillID = FB.FinalBillID            
    INNER JOIN PatientVisit PV ON FB.VisitID = PV.PatientVisitId
    LEFT JOIN CurrencyMaster CM ON CM.CurrencyID = ARD.PaidCurrencyID                
 WHERE  PV.OrgID = @porgID            
    AND PV.VisitType = 1            
    AND ARD.CreatedAt BETWEEN @pfDate AND @ptDate            
    AND (ARD.PaidCurrencyID = COALESCE(@pCurrencyID,ARD.PaidCurrencyID) OR  ARD.PaidCurrencyID IS NULL)          
            
) ps            
PIVOT            
(            
 SUM(ps.AmtReceived) FOR PaymentName IN ([CASH], [Cheque], [DemandDraft], [Cards])            
)AS PVT             
GROUP BY FinalBillID, VisitID, CONVERT(nvarchar,CreatedAt,103) ,PaidCurrencyCode           
ORDER BY  CONVERT(datetime,CONVERT(nvarchar,CreatedAt,103))            
        
INSERT INTO  @AmtRcvdDtlsTbl (FinalBillID, VisitID, BillDate, AmtReceived, CASH, Cheque, DemandDraft, Cards,PaidCurrency,PaidCurrencyAmount)            
            
SELECT FB.FinalBillID,             
    FB.VisitID,             
    CONVERT(nvarchar,FB.CreatedAt,103) as BillDate,            
    0,0,0,0,0
    , ISNULL(CM.CurrencyCode,
         (SELECT CM.CurrencyCode FROM CurrencyOrgMapping COM INNER JOIN CurrencyMaster CM ON COM.CurrencyID = CM.CurrencyID AND COM.OrgID = @pOrgId AND COM.IsBaseCurrency = ''Y'')
         ) AS PaidCurrencyCode,
          ISNULL(ARD.OtherCurrencyAmount,ARD.AmtReceived) AS PaidCurrencyAmount          
FROM  FinalBill FB         
 INNER JOIN PatientVisit PV ON FB.VisitID = PV.PatientVisitId 
 LEFT JOIN AmountReceivedDetails ARD ON ARD.FinalBillID = FB.FinalBillID AND ARD.OrgID = FB.OrgID 
  LEFT JOIN CurrencyMaster CM ON CM.CurrencyID = ARD.PaidCurrencyID             
WHERE  PV.OrgID = @porgID            
    AND PV.VisitType = 1            
    AND FB.CreatedAt BETWEEN @pfDate AND @ptDate         
    AND FB.FinalBillID not in (SELECT  ARD.FinalBillID FROM AmountReceivedDetails ARD WHERE ARD.CreatedAT BETWEEN @pfDate AND @ptDate) 
    AND (ARD.PaidCurrencyID = COALESCE(@pCurrencyID,ARD.PaidCurrencyID) OR  ARD.PaidCurrencyID IS NULL)          
RETURN            
            
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fngetcountablelist]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fngetcountablelist]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Fngetcountablelist] (@pAttGroupID BIGINT,
                                           @OrgID       INT,
                                           @Type        nvarchar(50))
RETURNS @List TABLE (
  OrgGroupID BIGINT,
  AttGroupID BIGINT,
  Type       nvarchar(5))
  BEGIN
      DECLARE @pOrgGroupID BIGINT=NULL
      DECLARE @IsCountable nvarchar(5)=NULL

      SELECT @pOrgGroupID = OrgGroupID,
             @IsCountable = Iscountable
      FROM   InvOrgGroup with(NOLOCK)
      WHERE  AttGroupID = @pAttGroupID
             AND OrgID = @OrgID

      DECLARE @TempinvList AS TABLE
        (
           OrgGroupID BIGINT,
           AttGroupID BIGINT,
           Type       nvarchar(5)
        )
      DECLARE @TempGrpList AS TABLE
        (
           OrgGroupID BIGINT,
           AttGroupID BIGINT
        )

      iF( @IsCountable = ''NO'' )
        BEGIN
            IF( @Type = ''PKG'' )
              BEGIN
                  INSERT INTO @TempGrpList
                  SELECT DISTINCT IOG.OrgGroupID,
                                  IOG.AttGroupID
                  FROM   InvPackageMapping IPM with(NOLOCK)
                         INNER JOIN InvOrgGroup IOG WITH(NOLOCK)
                                 ON IOG.OrgGroupID = IPM.ID
                                    AND IOG.OrgID = @OrgID
                  WHERE  Type = ''GRP''
                         AND Active = ''A''
                         AND PackageID = @pOrgGroupID

                  INSERT INTO @TempinvList
                  SELECT DISTINCT ID,
                                  ID,
                                  ''INV''
                  FROM   InvPackageMapping IGMM with(NOLOCK)
                  WHERE  Type = ''INV''
                         AND Active = ''A''
                         AND PackageID = @pOrgGroupID

                  Declare @OrgGroupID bigint = Null
                  Declare @AttGroupID bigint = Null
                  DECLARE TableCursor CURSOR FOR
                    Select OrgGroupID,
                           AttGroupID
                    FROM   @TempGrpList

                  OPEN TableCursor

                  FETCH NEXT FROM TableCursor INTO @OrgGroupID, @AttGroupID

                  WHILE @@FETCH_STATUS = 0
                    BEGIN
                        IF EXISTS(SELECT 1
                                  FROM   InvOrgGroup WITH(NOLOCK)
                                  WHERE  OrgGroupID = @OrgGroupID
                                         AND Isnull(Iscountable, ''YES'') <> ''YES'')
                          BEGIN
                              INSERT INTO @TempinvList
                                          (OrgGroupID,
                                           AttGroupID,
                                           Type)
                              SELECT DISTINCT OrgGroupID,
                                              AttGroupID,
                                              Type
                              FROM   Fngetcountablelist(@AttGroupID, @OrgID, ''GRP'')
                          END
                        ELSE
                          BEGIN
                              INSERT INTO @TempinvList
                                          (OrgGroupID,
                                           AttGroupID,
                                           Type)
                              VALUES      (@OrgGroupID,
                                           @AttGroupID,
                                           ''GRP'')
                          END

                        FETCH NEXT FROM TableCursor INTO @OrgGroupID, @AttGroupID
                    END

                  CLOSE TableCursor

                  DEALLOCATE TableCursor
              END

            IF( @Type = ''GRP'' )
              BEGIN
                  INSERT INTO @TempGrpList
                  SELECT DISTINCT IOG.OrgGroupID,
                                  IOG.AttGroupID
                  FROM   InvGroupMapMaster IGMM with(NOLOCK)
                         INNER JOIN InvOrgGroup IOG WITH(NOLOCK)
                                 ON IOG.OrgGroupID = IGMM.InvestigationID
                                    AND IOG.OrgID = @OrgID
                  WHERE  Parent = ''Y''
                         AND Active = ''Y''
                         AND GroupID = @pOrgGroupID

                  INSERT INTO @TempinvList
                  SELECT DISTINCT InvestigationID,
                                  InvestigationID,
                                  ''INV''
                  FROM   InvGroupMapMaster IGMM with(NOLOCK)
                  WHERE  Parent = ''N''
                         AND Active = ''Y''
                         AND GroupID = @pOrgGroupID

                  Declare @OrgGroupID1 bigint = Null
                  Declare @AttGroupID1 bigint = Null
                  DECLARE TableCursor CURSOR FOR
                    Select OrgGroupID,
                           AttGroupID
                    FROM   @TempGrpList

                  OPEN TableCursor

                  FETCH NEXT FROM TableCursor INTO @OrgGroupID1, @AttGroupID1

                  WHILE @@FETCH_STATUS = 0
                    BEGIN
                        IF EXISTS(SELECT 1
                                  FROM   InvOrgGroup WITH(NOLOCK)
                                  WHERE  OrgGroupID = @OrgGroupID1
                                         AND Isnull(Iscountable, ''YES'') <> ''YES'')
                          BEGIN
                              INSERT INTO @TempinvList
                                          (OrgGroupID,
                                           AttGroupID,
                                           Type)
                              SELECT DISTINCT OrgGroupID,
                                              AttGroupID,
                                              Type
                              FROM   Fngetcountablelist(@AttGroupID1, @OrgID, ''GRP'')
                          END
                        ELSE
                          BEGIN
                              INSERT INTO @TempinvList
                                          (OrgGroupID,
                                           AttGroupID,
                                           Type)
                              VALUES      (@OrgGroupID1,
                                           @AttGroupID1,
                                           ''GRP'')
                          END

                        FETCH NEXT FROM TableCursor INTO @OrgGroupID1, @AttGroupID1
                    END

                  CLOSE TableCursor

                  DEALLOCATE TableCursor
              END
        END
      ELSE
        BEGIN
            INSERT INTO @TempinvList
            SELECT @pOrgGroupID,
                   @pAttGroupID,
                   @Type
        END

      IF (SELECT Count(1)
          FROM   @TempinvList) > 0
        INSERT INTO @List
        SELECT OrgGroupID,
               AttGroupID,
               Type
        FROM   @TempinvList

      RETURN
  END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fngetgroupcountablelist]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fngetgroupcountablelist]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Fngetgroupcountablelist] (@pAttGroupID BIGINT,
                                                @OrgID       INT)
RETURNS @List TABLE (
  OrgGroupID BIGINT,
  AttGroupID BIGINT,
  Type       nvarchar(5))
  BEGIN
      DECLARE @pOrgGroupID BIGINT=NULL

      SELECT @pOrgGroupID = OrgGroupID
      FROM   InvOrgGroup with(NOLOCK)
      WHERE  AttGroupID = @pAttGroupID
             AND OrgID = @OrgID

      DECLARE @TempinvList AS TABLE
        (
           OrgGroupID BIGINT,
           AttGroupID BIGINT,
           Type       nvarchar(5)
        )
      DECLARE @TempGrpList AS TABLE
        (
           OrgGroupID BIGINT,
           AttGroupID BIGINT
        )

      INSERT INTO @TempGrpList
      SELECT DISTINCT IOG.OrgGroupID,
                      IOG.AttGroupID
      FROM   InvGroupMapMaster IGMM with(NOLOCK)
             INNER JOIN InvOrgGroup IOG WITH(NOLOCK)
                     ON IOG.OrgGroupID = IGMM.InvestigationID
                        AND IOG.OrgID = @OrgID
      WHERE  Parent = ''Y''
             AND Active = ''Y''
             AND GroupID = @pOrgGroupID

      INSERT INTO @TempinvList
      SELECT DISTINCT InvestigationID,
                      InvestigationID,
                      ''INV''
      FROM   InvGroupMapMaster IGMM with(NOLOCK)
      WHERE  Parent = ''N''
             AND Active = ''Y''
             AND GroupID = @pOrgGroupID

      Declare @OrgGroupID bigint = Null
      Declare @AttGroupID bigint = Null
      DECLARE TableCursor CURSOR FOR
        Select OrgGroupID,
               AttGroupID
        FROM   @TempGrpList

      OPEN TableCursor

      FETCH NEXT FROM TableCursor INTO @OrgGroupID, @AttGroupID

      WHILE @@FETCH_STATUS = 0
        BEGIN
            IF EXISTS(SELECT 1
                      FROM   InvOrgGroup WITH(NOLOCK)
                      WHERE  OrgGroupID = @OrgGroupID
                             AND Isnull(Iscountable, ''YES'') <> ''YES'')
              BEGIN
                  INSERT INTO @TempinvList
                              (OrgGroupID,
                               AttGroupID,
                               Type)
                  SELECT DISTINCT OrgGroupID,
                                  AttGroupID,
                                  Type
                  FROM   Fngetgroupcountablelist(@AttGroupID, @OrgID)
              END
            ELSE
              BEGIN
                  INSERT INTO @TempinvList
                              (OrgGroupID,
                               AttGroupID,
                               Type)
                  VALUES     (@OrgGroupID,
                              @AttGroupID,
                              ''GRP'')
              END

            FETCH NEXT FROM TableCursor INTO @OrgGroupID, @AttGroupID
        END

      CLOSE TableCursor

      DEALLOCATE TableCursor

      IF (SELECT Count(1)
          FROM   @TempinvList) > 0
        INSERT INTO @List
        SELECT OrgGroupID,
               AttGroupID,
               Type
        FROM   @TempinvList

      RETURN
  END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetGroupName]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetGroupName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetGroupName] 
(
	@pInvestigationID bigint, 
	@pPatientVisitID bigint 
)
RETURNS
nvarchar(255) 
BEGIN
DECLARE @GroupName nvarchar(255) 
SELECT @GroupName = GroupName FROM PatientInvestigation WHERE InvestigationID = @pInvestigationID AND PatientVisitID = @pPatientVisitID 
return @GroupName 
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Fngetidwithpattern]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fngetidwithpattern]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Fngetidwithpattern] (@porgID         BIGINT,
                                            @pOrgAddressID  BIGINT,
                                            @pID            BIGINT,
                                            @pCategoryID    BIGINT,
                                            @IsReset        CHAR,
                                            @RefID          BIGINT =-1,
                                            @RefType        NVARCHAR(55) = '''',
                                            @NumberOfDigits INT = -1)
RETURNS NVARCHAR(256)
AS
  BEGIN
      DECLARE @IDwithPattern NVARCHAR(256)
      DECLARE @FullPattern NVARCHAR(256)
      DECLARE @ResetNumber BIGINT
      DECLARE @LastNumber NVARCHAR(50)
      DECLARE @PatternTable TABLE
        (
           RowNo        INT IDENTITY(1, 1),
           PatternValue NVARCHAR(256)
        )
      DECLARE @Count INT = 0
      DECLARE @loop INT = 1
      DECLARE @Pattern NVARCHAR(256)
      DECLARE @ResultPattern NVARCHAR(256) = ''''
      DECLARE @LocationCode NVARCHAR(50)
      DECLARE @DateFormat NVARCHAR(32)
      DECLARE @VisitCount NVARCHAR(32)
      DECLARE @VisitType NVARCHAR(32) = 0
      DECLARE @VisitSpecialityID NVARCHAR(32)
      DECLARE @VisitDeptID NVARCHAR(32)
      DECLARE @PatientVisitID BIGINT =-1
      DECLARE @IsPatternAutoGenerated CHAR(1)
      DECLARE @CityCode NVARCHAR(50)
      DECLARE @CentreCode NVARCHAR(50)
      DECLARE @HCODE NVARCHAR(10) = ''''
      DECLARE @GROUPHCODE NVARCHAR(10) =''''
      DECLARE @ResetBy BIGINT
	  DECLARE @externalvisitid NVARCHAR(max)  
	  DECLARE @CategoryCode NVARCHAR(100)
	  
	  Set @CategoryCode = (Select CategoryCode From MasterCategories where OrgID=@porgID and CategoryID = @pCategoryID)

      IF EXISTS(SELECT ''X''
                FROM   IDPatternMaster (nolock)
                WHERE  CategoryID = @pCategoryID
                       AND OrgID = @porgID
                       AND Pattern IS NOT NULL
                       AND Isnull(OrgAddressID, @pOrgAddressID) = @pOrgAddressID)
        BEGIN
            SELECT @FullPattern = Pattern,
                   @ResetNumber = ResetNumber,
                   @IsReset = IsReset,
                   @LastNumber = LastGeneratedNumber,
                   @ResetBy = ResetBy,
                   @IsPatternAutoGenerated = IsPatternAutoGenerated
            FROM   IDPatternMaster (nolock)
            WHERE  CategoryID = @pCategoryID
                   AND OrgID = @porgID
                   AND Pattern IS NOT NULL
                   AND Isnull(OrgAddressID, @pOrgAddressID) = @pOrgAddressID
        END
      ELSE
        BEGIN
            RETURN @pID
        END

      IF ( @IsPatternAutoGenerated = ''N'' )
        BEGIN
            IF EXISTS (SELECT 1
                       FROM   Sys.Objects
                       WHERE  Name = ''fnGeneratePatientNumberCustomLogic''
                              AND Type = ''Fn'')
              DECLARE @NextID NVARCHAR(50)
            SELECT @NextID = dbo.Fngeneratepatientnumbercustomlogic (@LastNumber)

            RETURN @NextID
        END



      SELECT @PatientVisitID = Max(PatientVisitID)
      FROM   PatientVisit (nolock)
      WHERE  PatientID = @RefID
             AND OrgID = @pOrgID

      INSERT @PatternTable
      SELECT Ltrim(Rtrim(Replace(item, ''{'', ''''))) item
      FROM   dbo.[Fnsplit] (@FullPattern, ''}'')

      --SELECT * FROM @PatternTable                    
      SELECT @Count = Count(1)
      FROM   @PatternTable

      WHILE( @loop <= @Count )
        BEGIN
            SELECT @Pattern = PatternValue
            FROM   @PatternTable
            WHERE  RowNo = @loop

            IF @Pattern = ''YYYY''
              BEGIN
                  SELECT @DateFormat = dbo.Fnformatdate (Getdate(), @Pattern, @ResetBy)

                  SET @ResultPattern = @ResultPattern + @DateFormat
              END
            ELSE IF @Pattern = ''YY''
              BEGIN
                  SELECT @DateFormat = dbo.Fnformatdate (Getdate(), @Pattern, @ResetBy)
				  IF(@CategoryCode = ''PVN'')
				  BEGIN
				   IF EXISTS(SELECT 1 FROM DatePatternValue (NOLOCK) WHERE OrgID=@porgID AND PatternType=''YY''  
				  AND [Key]=@DateFormat)  
				  BEGIN   
					  SELECT @ResultPattern = @ResultPattern + [Value]    
				   FROM DatePatternValue (NOLOCK) WHERE OrgID=@porgID AND PatternType=''YY''  
					  AND [Key]=@DateFormat  
				  END  
				  END
				  ELSE   
				  BEGIN 

                  SET @ResultPattern = @ResultPattern + @DateFormat
				  END
              END
            -------------added by sudhakar for MLNO Based-----
            ELSE IF @Pattern = ''HCODE''
              BEGIN
                  SET @ResultPattern = @RefType
              END
            -------------end ML NO-----               
            ELSE IF @Pattern = ''DD''
              BEGIN
                  SELECT @DateFormat = dbo.Fnformatdate (Getdate(), @Pattern, @ResetBy)

                  SET @ResultPattern = @ResultPattern + @DateFormat
              END
            ELSE IF @Pattern = ''MMM''
              BEGIN
                  SELECT @DateFormat = dbo.Fnformatdate (Getdate(), @Pattern, @ResetBy)

                  SET @ResultPattern = @ResultPattern + @DateFormat
              END
            ELSE IF @Pattern = ''MM''
              BEGIN
                  SELECT @DateFormat = dbo.Fnformatdate (Getdate(), @Pattern, @ResetBy)
				  IF(@CategoryCode = ''PVN'')
				  BEGIN
				  IF EXISTS(SELECT 1 FROM DatePatternValue (NOLOCK) WHERE OrgID=@porgID AND PatternType=''MM''  
				  AND [Key]=@DateFormat)  
				  BEGIN   
					  SELECT @ResultPattern = @ResultPattern + [Value]    
				   FROM DatePatternValue (NOLOCK) WHERE OrgID=@porgID AND PatternType=''MM''  
					  AND [Key]=@DateFormat  
				  END  
				  END
				  ELSE   
				  BEGIN   

					SET @ResultPattern = @ResultPattern + @DateFormat
				  END
              END
			   ELSE IF @Pattern = ''MONAlBHA''
              BEGIN
			       Declare @Mon as nVarchar(10)				   
				   Declare @Monalb as nVarchar(10) 	  
				   select @Mon= month(GETDATE())  
				  		   
				   select @Monalb=Case when @Mon=1 then ''A''
				                    when @Mon=2 then ''B''
									when @Mon=3 then ''C''
									when @Mon=4 then ''D''
									when @Mon=5 then ''E''
									when @Mon=6 then ''F''
									when @Mon=7 then ''G''
									when @Mon=8 then ''H''
									when @Mon=9 then ''I''
									when @Mon=10 then ''J''
									when @Mon=11 then ''K''
									when @Mon=12 then ''L''
									Else ''M''									
									end              
                  SET @ResultPattern = @ResultPattern + @Monalb
              END
			   ELSE IF @Pattern = ''YEARAlBHA''
              BEGIN
			       
				   Declare @Yea as nVarchar(10)				  
				   Declare @Yeaalb as nVarchar(10)				   
				   select @Yea= Year(GETDATE())	 
				   
                  select @Yeaalb=Case when @Yea=2012 then ''A''
				                    when @Yea=2013 then ''B''
									when @Yea=2014 then ''C''
									when @Yea=2015 then ''D''
									when @Yea=2016 then ''E''
									when @Yea=2017 then ''F''
									when @Yea=2018 then ''G''
									when @Yea=2019 then ''H''
									when @Yea=2020 then ''I''
									when @Yea=2021 then ''J''
									when @Yea=2022 then ''K''
									when @Yea=2023 then ''L''
									when @Yea=2024 then ''M''
									when @Yea=2025 then ''N''
									Else ''O''									
									end
									SET @ResultPattern = @ResultPattern + @Yeaalb
              END



            ELSE IF @Pattern = ''LOC''
              BEGIN
                  IF @pOrgAddressID IS NULL
                      OR @pOrgAddressID = -1
                    SET @pOrgAddressID = NULL

                  SELECT TOP 1 @LocationCode = ( CASE
                                                   WHEN Len(Isnull(LocationCode, '''')) > 0 THEN Rtrim(Ltrim(LocationCode))
                                                   ELSE Substring(Location, 0, 4)
                                                 END )
                  FROM   OrganizationAddress (nolock)
                  WHERE  OrgID = @porgID
                         AND AddressID = COALESCE(@pOrgAddressID, AddressID)

                  SET @ResultPattern = @ResultPattern + @LocationCode
              END
            ELSE IF @Pattern = ''CCODE''
              BEGIN
                  IF @pOrgAddressID IS NULL
                      OR @pOrgAddressID = -1
                    SET @pOrgAddressID = NULL

                  SELECT TOP 1 @CityCode = ( CASE
                                               WHEN Len(Isnull(CityCode, '''')) > 0 THEN CityCode
                                               ELSE Substring(City, 0, 4)
                                             END )
                  FROM   OrganizationAddress (nolock)
                  WHERE  OrgID = @porgID
                         AND AddressID = COALESCE(@pOrgAddressID, AddressID)

                  SET @ResultPattern = @ResultPattern + @CityCode
              END
            ELSE IF @Pattern = ''ORGCENTRECODE''
              BEGIN
                  IF @pOrgAddressID IS NULL
                      OR @pOrgAddressID = -1
                    SET @pOrgAddressID = NULL

                  SELECT TOP 1 @CentreCode = Isnull(Rtrim(Ltrim(CentreCode)), '''')
                  FROM   Organization (nolock)
                  WHERE  OrgID = @porgID

                  --AND AddressID=COALESCE(@pOrgAddressID,AddressID)                          
                  SET @ResultPattern = @ResultPattern + @CentreCode
              END
              
              ELSE IF @Pattern = ''EXTVSTID''       
  BEGIN  
   SELECT @externalvisitid = PV.ExternalVisitID
   FROM PatientVisit(NOLOCK) PV  
   WHERE OrgID = @pOrgID
    AND PatientVisitID = @RefID 
   SET @ResultPattern = @ResultPattern + @externalvisitid      
      
  END      
              
              
            ELSE IF @Pattern = ''VIC''
               AND @RefType = ''PT''
              BEGIN
                  SELECT @VisitCount = Count(1)
                  FROM   PatientVisit (nolock)
                  WHERE  PatientID = @RefID
                         AND OrgID = @porgID

                  SET @ResultPattern = @ResultPattern + @VisitCount
              END
            ELSE IF @Pattern = ''VIT''
               AND @RefType = ''PT''
              BEGIN
                  SELECT @VisitType = CASE
                                        WHEN VisitType = 0 THEN ''OP''
                                        ELSE ''IP''
                                      END
                  FROM   PatientVisit (nolock)
                  WHERE  OrgID = @pOrgID
                         AND PatientVisitID = @PatientVisitID

                  SET @ResultPattern = @ResultPattern + @VisitType
              END
            ELSE IF @Pattern = ''SPE''
               AND @RefType = ''PT''
              BEGIN
                  SELECT @VisitSpecialityID = Isnull(SpecialityID, 0)
                  FROM   PatientVisit (nolock)
                  WHERE  OrgID = @pOrgID
                         AND PatientVisitID = @PatientVisitID

                  SET @ResultPattern = @ResultPattern + @VisitSpecialityID
              END
            ELSE IF @Pattern = ''DEP''
               AND @RefType = ''PT''
              BEGIN
                  SELECT @VisitDeptID = Isnull(EmpDeptCode, 0)
                  FROM   PatientVisit (nolock)
                  WHERE  OrgID = @pOrgID
                         AND PatientVisitID = @PatientVisitID

                  SET @ResultPattern = @ResultPattern + @VisitDeptID
              END
            ELSE IF @Pattern = ''DEP''
               AND @RefType = ''PT''
              BEGIN
                  SELECT @VisitDeptID = Isnull(EmpDeptCode, 0)
                  FROM   PatientVisit (nolock)
                  WHERE  OrgID = @pOrgID
                         AND PatientVisitID = @PatientVisitID

                  SET @ResultPattern = @ResultPattern + @VisitDeptID
              END
            ELSE IF @Pattern = ''P''
              BEGIN
                  SELECT @VisitDeptID = ''P''

                  SET @ResultPattern = @ResultPattern + @VisitDeptID
              END
            ELSE IF @Pattern = ''Number''
              BEGIN
                  IF( @NumberOfDigits = -1 )
                    BEGIN
                        SET @ResultPattern = @ResultPattern + CONVERT(NVARCHAR, @pID)
                    END
                  ELSE
                    BEGIN
                        SET @ResultPattern = @ResultPattern + CASE WHEN (@NumberOfDigits - Len(@pID))>0 THEN Replicate(''0'', (@NumberOfDigits - Len(@pID)))+ CONVERT(NVARCHAR, @pID)ELSE CONVERT(NVARCHAR, @pID) END
                    END
              --SET @ResultPattern = @ResultPattern + case when  (6 - len(@pID))>0  then  replicate(''0'',(6 - len(@pID)))+ CONVERT(varchar,@pID)Else CONVERT(varchar,@pID) end       
              END
            ELSE
              BEGIN
                  SET @ResultPattern = @ResultPattern + @Pattern
              END

            SET @loop=@loop + 1
        END

      SELECT @IDwithPattern = @ResultPattern

      RETURN @IDwithPattern
  END;


' 
END

GO
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetIDwithPattern_Invoice]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetIDwithPattern_Invoice]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetIDwithPattern_Invoice]                                                          
(                                                                  
    @porgID BIGINT,                        
    @pOrgAddressID BIGINT,                                                              
    @pID BIGINT,                                                          
    @pCategoryID BIGINT,                                                      
    @IsReset nchar,                      
    @RefID BIGINT =-1,                      
    @RefType nvarchar(8) = ''''  ,      
    @NumberOfDigits INT = -1                    
)                       
RETURNS  nvarchar(256)                        
 AS                                                      
BEGIN                        
DECLARE @IDwithPattern nvarchar(256)                      
DECLARE @FullPattern nvarchar(256)                       
DECLARE @ResetNumber Bigint                      
DECLARE @LastNumber nvarchar(50)                      
DECLARE @PatternTable  TABLE(RowNo INT IDENTITY(1,1),PatternValue nvarchar(256))                                              
DECLARE @Count int = 0                                                 
DECLARE @loop int = 1                        
DECLARE @Pattern nvarchar(256)                      
DECLARE @ResultPattern nvarchar(256) = ''''                      
DECLARE @LocationCode nvarchar(50)                      
DECLARE @DateFormat nvarchar(32)                      
DECLARE @VisitCount nvarchar(32)                      
DECLARE @VisitType nvarchar(32) = 0                      
DECLARE @VisitSpecialityID nvarchar(32)                      
DECLARE @VisitDeptID nvarchar(32)                      
DECLARE @PatientVisitID BIGINT =-1                    
DECLARE @IsPatternAutoGenerated nchar(1)                  
DECLARE @CityCode nvarchar(50)          
DECLARE @CentreCode nvarchar(50)                  
                       
    IF EXISTS(SELECT ''X''FROM IDPatternMaster WHERE CategoryID=@pCategoryID AND OrgID=@porgID AND Pattern IS NOT NULL                
 AND  ISNULL(OrgAddressID,@pOrgAddressID)=@pOrgAddressID  )              
 BEGIN              
 SELECT  @FullPattern=Pattern ,@ResetNumber=ResetNumber,@IsReset=IsReset,@LastNumber=LastGeneratedNumber, @IsPatternAutoGenerated = IsPatternAutoGenerated                     
 FROM IDPatternMaster WHERE CategoryID=@pCategoryID AND OrgID=@porgID AND Pattern IS NOT NULL                
 AND  ISNULL(OrgAddressID,@pOrgAddressID)=@pOrgAddressID                
 END              
 ELSE              
 BEGIN               
 Return @pID              
 END              
                
IF (@IsPatternAutoGenerated = ''N'')                
BEGIN                
IF EXISTS (SELECT 1 FROM Sys.Objects Where Name = ''fnGeneratePatientNumberCustomLogic'' And Type = ''Fn'')                
 Declare @NextID nvarchar(50)                
 Select @NextID = dbo.fnGeneratePatientNumberCustomLogic (@LastNumber)                
 Return @NextID                
END                
                       
  SELECT @PatientVisitID= MAX(PatientVisitID) from PatientVisit WHERE PatientID = @RefID                      
            AND OrgID = @pOrgID                      
 INSERT @PatternTable                      
 SELECT lTrim(Rtrim(REPLACE(item,''{'',''''))) item  from  dbo.[fnSplit] (@FullPattern,''}'')                      
                       
 --SELECT 1 FROM @PatternTable                      
  SELECT @Count = COUNT(1) from @PatternTable                      
                        
  WHILE(@loop<=@Count)                                                  
  BEGIN                                    
 SELECT @Pattern = PatternValue FROM @PatternTable WHERE RowNo=@loop                            
 IF @Pattern = ''YYYY''                      
 BEGIN                      
  SELECT @DateFormat = dbo.fnFormatDate_Invoice (getdate(), @Pattern)                      
  SET @ResultPattern = @ResultPattern  + @DateFormat                      
 END                      
 ELSE IF @Pattern = ''YY''                      
 BEGIN                  
  SELECT @DateFormat = dbo.fnFormatDate_Invoice (getdate(), @Pattern)                      
  SET @ResultPattern = @ResultPattern  + @DateFormat                      
 END                      
 ELSE IF @Pattern = ''DD''                      
 BEGIN                      
  SELECT @DateFormat = dbo.fnFormatDate_Invoice (getdate(), @Pattern)                  
  SET @ResultPattern = @ResultPattern  + @DateFormat                      
 END                      
 ELSE IF @Pattern = ''MMM''                      
 BEGIN                      
  SELECT @DateFormat = dbo.fnFormatDate_Invoice (getdate(), @Pattern)                      
  SET @ResultPattern = @ResultPattern  + @DateFormat                      
 END                      
 ELSE IF @Pattern = ''MM''                      
 BEGIN                      
  SELECT @DateFormat = dbo.fnFormatDate_Invoice (getdate(), @Pattern)                      
  SET @ResultPattern = @ResultPattern  + @DateFormat                      
 END                      
 ELSE IF @Pattern = ''LOC''                      
 BEGIN                      
  IF @pOrgAddressID is null OR @pOrgAddressID = -1                  
 SET @pOrgAddressID = NULL                  
                   
  SELECT TOP 1 @LocationCode = (CASE WHEN LEN(ISNULL(LocationCode,''''))>0 THEN RTRIM(LTRIM(LocationCode)) ELSE SUBSTRING(Location,0,4) END)                       
     FROM OrganizationAddress WHERE OrgID=@porgID AND AddressID=COALESCE(@pOrgAddressID,AddressID)                        
  SET @ResultPattern = @ResultPattern + @LocationCode                      
 END          
 ELSE IF @Pattern = ''CCODE''                      
 BEGIN                      
  IF @pOrgAddressID is null OR @pOrgAddressID = -1                  
 SET @pOrgAddressID = NULL                  
                   
  SELECT TOP 1 @CityCode = (CASE WHEN LEN(ISNULL(CityCode,''''))>0 THEN CityCode ELSE SUBSTRING(City,0,4) END)                       
     FROM OrganizationAddress WHERE OrgID=@porgID AND AddressID=COALESCE(@pOrgAddressID,AddressID)                        
  SET @ResultPattern = @ResultPattern + @CityCode                      
 END       
ELSE IF @Pattern = ''ORGCENTRECODE''                          
 BEGIN                          
  IF @pOrgAddressID is null OR @pOrgAddressID = -1                      
 SET @pOrgAddressID = NULL                      
                       
  SELECT TOP 1 @CentreCode =  isnull(RTRIM(LTRIM(CentreCode)),'''')   FROM Organization WHERE OrgID =@porgID        
     --AND AddressID=COALESCE(@pOrgAddressID,AddressID)                            
  SET @ResultPattern = @ResultPattern + @CentreCode                          
 END                        
 ELSE IF @Pattern = ''VIC'' AND @RefType = ''PT''                      
 BEGIN                      
  SELECT @VisitCount = COUNT(1) FROM PatientVisit WHERE PatientID = @RefID AND OrgID = @porgID                      
  SET @ResultPattern = @ResultPattern + @VisitCount                      
 END                      
                          
 ELSE IF @Pattern = ''VIT'' AND @RefType = ''PT''                      
 BEGIN                      
  SELECT @VisitType = CASE WHEN VisitType = 0                       
        THEN ''OP'' ELSE ''IP''                       
       END                       
       FROM PatientVisit WHERE                        
        OrgID = @pOrgID AND PatientVisitID =@PatientVisitID                      
  SET @ResultPattern = @ResultPattern + @VisitType                      
 END                       
                       
 ELSE IF @Pattern = ''SPE'' AND @RefType = ''PT''                      
 BEGIN                      
  SELECT @VisitSpecialityID = ISNULL(SpecialityID,0)                       
       FROM PatientVisit WHERE                        
        OrgID = @pOrgID AND PatientVisitID = @PatientVisitID                      
  SET @ResultPattern = @ResultPattern + @VisitSpecialityID                      
 END                       
                       
 ELSE IF @Pattern = ''DEP'' AND @RefType = ''PT''                      
 BEGIN                      
  SELECT @VisitDeptID = ISNULL(EmpDeptCode,0)                      
       FROM PatientVisit WHERE                        
        OrgID = @pOrgID AND PatientVisitID = @PatientVisitID                      
                              
SET @ResultPattern = @ResultPattern + @VisitDeptID                      
 END                       
                       
 ELSE IF @Pattern = ''DEP'' AND @RefType = ''PT''                      
 BEGIN                      
  SELECT @VisitDeptID = ISNULL(EmpDeptCode,0)                      
       FROM PatientVisit WHERE                        
        OrgID = @pOrgID AND PatientVisitID = @PatientVisitID                      
                              
  SET @ResultPattern = @ResultPattern + @VisitDeptID                      
 END   
 ELSE IF @Pattern = ''P''                        
 BEGIN                        
  SELECT @VisitDeptID=''P''                       
                                
  SET @ResultPattern = @ResultPattern + @VisitDeptID                        
 END                        
 ELSE IF @Pattern = ''Number''                        
 BEGIN                      
                         
  IF(@NumberOfDigits = -1)      
  BEGIn      
   SET @ResultPattern = @ResultPattern + convert(nvarchar,@pID)            
  END      
  ELSE      
  BEGIN      
   SET @ResultPattern = @ResultPattern + case when  (@NumberOfDigits - len(@pID))>0  then  replicate(''0'',(@NumberOfDigits - len(@pID)))+       
   CONVERT(nvarchar,@pID)Else CONVERT(nvarchar,@pID) end         
  END      
        
  --SET @ResultPattern = @ResultPattern + case when  (6 - len(@pID))>0  then  replicate(''0'',(6 - len(@pID)))+ CONVERT(nvarchar,@pID)Else CONVERT(nvarchar,@pID) end         
 END                       
 ELSE                      
 BEGIN                      
  SET @ResultPattern = @ResultPattern + @Pattern                      
 END                      
                       
                        
  SET @loop=@loop+1                      
  END                     
  SELECT @IDwithPattern=@ResultPattern                      
                        
  RETURN   @IDwithPattern                      
                      
END; 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetInvComments]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetInvComments]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetInvComments]   
 (  
 @pInvestigationID bigint,   
 @pPatientVisitID bigint,  
 @orgID int   
)  
RETURNS nvarchar(255) BEGIN  
DECLARE @Comments nvarchar(255)   
  
  SELECT  @Comments = case  Reason  
          
        When ''Comments'' then ''''  
        else Reason  
        end   
  FROM  PatientInvestigation   
  WHERE  InvestigationID = @pInvestigationID   
  AND   PatientVisitID = @pPatientVisitID   
  AND   OrgID=@orgID  
  
return @Comments   
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetPatientDemogHistory]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientDemogHistory]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetPatientDemogHistory](@input VARCHAR(Max),@OrgID bigint,@domain varchar(50),@langCode varchar(10),@prefix nvarchar(100),@sufix nvarchar(100))
RETURNS NVARCHAR(Max)
AS BEGIN
    DECLARE @Work VARCHAR(250)
DECLARE @tbl AS TABLE 
( 
MDDomain NVARCHAR(255), 
MDKey    NVARCHAR(255), 
MDValue  NVARCHAR(255) 
) 
DECLARE @p1 dbo.UDTMETADATA 
INSERT INTO @p1 
VALUES      (0, 
@domain, 
N'''', 
N'''', 
N'''') 
INSERT INTO @tbl 
--exec pLoadMetaDataOrgMappingLis @pDomain=@p1,@pOrgID=86,@pLangCode=@pLangCode,@ContextInfo=@ContextInfo
SELECT DISTINCT MD.Domain, 
MD.Code, 
MDM.DisPlayText 
FROM   MetaDataOrgMapping MDM WITH(NOLOCK) 
INNER JOIN Metadata MD WITH(NOLOCK) 
ON MDM.MetadataID = MD.MetaDataID 
INNER JOIN @p1 UMD 
ON MD.Domain = UMD.Domain 
AND MDM.OrgID = @OrgID 
where Isnull(MDM.LangCode, ''en-GB'') =@langCode
set @work= Stuff((select '','' + MDvalue from splitfunc(@input,'','') fn 
inner join @tbl tb on tb.MDKey=Discount
 FOR XML PATH('''')), 1, 1, '''') 
 RETURN @prefix+ '' ''+ @work+'' ''+@sufix
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetRoomFee]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetRoomFee]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create FUNCTION [dbo].[fnGetRoomFee](@pOrgAddID int, @pBedID int)
RETURNS decimal(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN 
	DECLARE @feeAmount Decimal(18,2)
	
	Select @feeAmount= SUM(RTFM.Amount) from 
		BedMaster BM                                                               
		INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID           
		INNER JOIN FloorMaster FM ON FM.FloorID = RM.FloorID                                                
		INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                                          
		INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                          
	WHERE BM.BedID=@pBedID  
	GROUP BY  RTFM.RoomTypeID
	
	return @feeAmount
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetSlotsWithTokenNumber]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetSlotsWithTokenNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetSlotsWithTokenNumber]    
(    
 @pScheduleID bigint,    
 @pStartTime time,    
 @pEndTime time,    
 @pSlotDuration int,  
 @pResourceID bigint  
)    
RETURNS @FreeSlotTable table (    
  [ScheduleID] [bigint],     
  [SlotTime] [time],     
  [TokenNumber] [int],
  [EndTime][time]
)    
  
AS    
BEGIN    
  
 DECLARE @NoOfSlots  INT  
 DECLARE @intFlag  INT  
   
 SET @NoOfSlots = DATEDIFF(MINUTE,@pStartTime,@pEndTime)/@pSlotDuration  
 SET @intFlag = 1  
     SET @pEndTime =  DATEADD(MINUTE,@pSlotDuration,@pStartTime)
 WHILE (@intFlag <=@NoOfSlots)  
 BEGIN  
  IF(@intFlag=1)  
  BEGIN  
    INSERT INTO @FreeSlotTable (ScheduleID,SlotTime,TokenNumber,EndTime)  
    SELECT @pScheduleID,@pStartTime, @intFlag,@pEndTime
  END  
  ELSE  
  BEGIN  
    INSERT INTO @FreeSlotTable (ScheduleID,SlotTime,TokenNumber,EndTime)  
    SELECT @pScheduleID,@pStartTime, @intFlag,@pEndTime
  END  
  
   SET @pStartTime = DATEADD(MINUTE,@pSlotDuration,@pStartTime) 
    SET @pEndTime =  DATEADD(MINUTE,@pSlotDuration,@pStartTime)
   SET @intFlag = @intFlag + 1  
 END  
     
 RETURN    
     
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetSplitedValues]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetSplitedValues]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetSplitedValues] (@strSplitChar as nchar(1),@strSearchText as nvarchar(2000)) returns @KeyTable table (KeyValue nvarchar(2000)) as
BEGIN
  DECLARE @pos AS INT
  SELECT @pos = CHARINDEX(@strSplitChar, @strSearchText)
  WHILE @pos > 0
  BEGIN
    INSERT INTO @KeyTable (KeyValue) VALUES (SUBSTRING (@strSearchText, 1, @pos-1))
    SELECT @strSearchText = SUBSTRING (@strSearchText, @pos+1, 2000)
    SELECT @pos = CHARINDEX(@strSplitChar, @strSearchText)
  END
  INSERT INTO @KeyTable (KeyValue) VALUES (@strSearchText)
  RETURN
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockStatusForDesc]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockStatusForDesc]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetStockStatusForDesc](@StockStatus [nvarchar](50), @pOrgID [bigint], @pLanguageCode [nvarchar](10) = ''en-GB'', @StockTypeID [bigint])
RETURNS [nvarchar](250) WITH EXECUTE AS CALLER
AS 
BEGIN        
DECLARE @StockStatusID INT        
DECLARE @StockStatusName NVARCHAR(250)                        
  
IF(@StockStatus is not null and @StockStatus != '''')                
BEGIN      
       SELECT @StockStatusID = StockStatusID  FROM StockStatus WHERE StockTypeID = @StockTypeID AND StockStatusName = @StockStatus  
END      
  
IF EXISTS (SELECT 1 FROM StockStatusMapping WHERE StockStatusID = @StockStatusID AND  OrgID=@pOrgID AND LanguageCode=@pLanguageCode)                            
 BEGIN                     
  SELECT @StockStatusName = DisplayText FROM StockStatusMapping WHERE @StockStatusID=StockStatusID AND  OrgID=@pOrgID                 
  AND LanguageCode=@pLanguageCode                      
 END                           
 ELSE                             
 BEGIN                          
  SELECT @StockStatusName  = StockStatusName  FROM StockStatus WHERE @StockStatusID=StockStatusID                 
 END                            
 RETURN @StockStatusName                       
END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockStatusForID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockStatusForID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetStockStatusForID]  
(             
 @StockStatusID INT,                       
 @pOrgID bigint,                    
 @pLanguageCode nvarchar(10) = ''en-GB''                   
) RETURNS nvarchar(250)                     
AS                        
BEGIN                 
DECLARE @StockStatusName nvarchar(250)                  
IF EXISTS (SELECT 1 FROM StockStatusMapping WHERE @StockStatusID=StockStatusID AND  OrgID=@pOrgID AND LanguageCode=@pLanguageCode)                        
 BEGIN                 
 SELECT @StockStatusName = DisplayText FROM StockStatusMapping WHERE @StockStatusID=StockStatusID AND  OrgID=@pOrgID             
 AND LanguageCode=@pLanguageCode                  
 END                       
 ELSE                         
 BEGIN                      
  SELECT @StockStatusName = StockStatusName FROM StockStatus WHERE @StockStatusID=StockStatusID             
 END                        
 RETURN @StockStatusName                    
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockTypeForDesc]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockTypeForDesc]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetStockTypeForDesc]                            
(                   
 @pStockTypeName nvarchar(20),                  
 @pOrgID BIGINT,                        
 @pLanguageCode nvarchar(10) = ''en-GB''                        
)           
RETURNS nvarchar(255)            
AS                            
BEGIN               
DECLARE @StockTypeName nvarchar(255)      
DECLARE @StockTypeID BIGINT   
  
IF(@pStockTypeName is not null and @pStockTypeName != '''')  
BEGIN  
      SELECT @StockTypeID = StockTypeID FROM StockType WHERE StockTypeName=@pStockTypeName;        
END  
                       
IF EXISTS (SELECT 1 FROM StockTypeMapping WHERE StockTypeID=@StockTypeID AND OrgID=@pOrgID and LanguageCode=@pLanguageCode)           
BEGIN          
 SELECT @StockTypeName = DisplayText  FROM StockTypeMapping WHERE StockTypeID=@StockTypeID           
 AND OrgID=@pOrgID and LanguageCode=@pLanguageCode            
END          
ELSE              
BEGIN                  
 SELECT @StockTypeName = StockTypeName FROM StockType WHERE StockTypeID= @StockTypeID            
END          
 RETURN  @StockTypeName            
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnGetStockTypeForID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetStockTypeForID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetStockTypeForID]  
(                   
 @pStockTypeID BIGINT,                  
 @pOrgID BIGINT,                        
 @pLanguageCode nvarchar(10) = ''en-GB''                      
)           
RETURNS nvarchar(255)            
AS                            
BEGIN               
DECLARE @StockTypeName nvarchar(255)            
                        
 IF EXISTS (SELECT 1 FROM StockTypeMapping WHERE StockTypeID=@pStockTypeID AND OrgID=@pOrgID and LanguageCode=@pLanguageCode)           
 BEGIN          
  SELECT @StockTypeName = DisplayText  FROM StockTypeMapping WHERE StockTypeID=@pStockTypeID           
  AND OrgID=@pOrgID and LanguageCode=@pLanguageCode            
 END          
 ELSE              
 BEGIN                  
  SELECT @StockTypeName = StockTypeName FROM StockType WHERE StockTypeID= @pStockTypeID            
 END          
 RETURN  @StockTypeName            
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnMakeReminderEntry]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnMakeReminderEntry]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnMakeReminderEntry]
(
	@pReminderTemplateID bigint,
	@pUserID bigint,
	@pRoleID int,
	@pStartDate datetime,
	@pEndDate datetime,
	@pFreq nvarchar(10),
	@pDiff int
)
RETURNS @ReminderTable table (
		[RemindDate] [datetime], 
		[ReminderTemplateID] [bigint], 
		[UserID] [bigint],
		[RoleID] [bigint], 
		[Status] [nchar] (10)
)
AS
BEGIN
	DECLARE @cnt int
	DECLARE @pDate Datetime
	SET @cnt = 1
	

	WHILE (@cnt <= @pDiff)
	BEGIN
		IF (@pFreq = ''Daily'') 
		BEGIN
		
			SELECT @pDate = DateAdd(D,@cnt,@pStartDate)
			 
			IF not exists(SELECT 1 FROM Reminder Where RemindDate=@pDate AND ReminderTemplateID=@pReminderTemplateID)
				 IF @pDate<=@pEndDate
					INSERT INTO @ReminderTable (ReminderTemplateID, RemindDate, UserID,RoleID,[Status]) VALUES (@pReminderTemplateID, @pDate, @pUserID, @pRoleID, ''U'')
				
		END
		ELSE IF (@pFreq = ''Weekly'')
		BEGIN
			
			SELECT @pDate = DateAdd(WEEK,@cnt,@pStartDate)
			 
			IF not exists(SELECT 1 FROM Reminder Where RemindDate=@pDate AND ReminderTemplateID=@pReminderTemplateID)
				IF @pDate<=@pEndDate
					INSERT INTO @ReminderTable (ReminderTemplateID, RemindDate, UserID,RoleID,[Status]) VALUES (@pReminderTemplateID, @pDate, @pUserID, @pRoleID, ''U'')
				
		END
		ELSE IF (@pFreq = ''Monthly'')
		BEGIN
			
			SELECT @pDate = DateAdd(MONTH,@cnt,@pStartDate)
			 
			IF not exists(SELECT 1 FROM Reminder Where RemindDate=@pDate AND ReminderTemplateID=@pReminderTemplateID)
				IF @pDate<=@pEndDate
					INSERT INTO @ReminderTable (ReminderTemplateID, RemindDate, UserID,RoleID,[Status]) VALUES (@pReminderTemplateID, @pDate, @pUserID, @pRoleID, ''U'')
			
		END
		ELSE IF (@pFreq = ''Yearly'')
		BEGIN
			
			SELECT @pDate = DateAdd(YEAR,@cnt,@pStartDate)
			 
			IF not exists(SELECT 1 FROM Reminder Where RemindDate=@pDate AND ReminderTemplateID=@pReminderTemplateID)
				IF @pDate<=@pEndDate
					INSERT INTO @ReminderTable (ReminderTemplateID, RemindDate, UserID,RoleID,[Status]) VALUES (@pReminderTemplateID, @pDate, @pUserID, @pRoleID, ''U'')
		
		END
		ELSE IF (@pFreq = ''Quarterly'')
		BEGIN
			
			SELECT @pDate = DateAdd(QUARTER,@cnt,@pStartDate)
			 
			IF not exists(SELECT 1 FROM Reminder Where RemindDate=@pDate AND ReminderTemplateID=@pReminderTemplateID)
				IF @pDate<=@pEndDate
					INSERT INTO @ReminderTable (ReminderTemplateID, RemindDate, UserID,RoleID,[Status]) VALUES (@pReminderTemplateID, @pDate, @pUserID, @pRoleID, ''U'')
		
		END
		ELSE IF (@pFreq = ''HalfYearly'')
		BEGIN
			
			SELECT @pDate = DateAdd(Month,@cnt*6,@pStartDate)
			 
			IF not exists(SELECT 1 FROM Reminder Where RemindDate=@pDate AND ReminderTemplateID=@pReminderTemplateID)
				IF @pDate<=@pEndDate
					INSERT INTO @ReminderTable (ReminderTemplateID, RemindDate, UserID,RoleID,[Status]) VALUES (@pReminderTemplateID, @pDate, @pUserID, @pRoleID, ''U'')
		
		END
		
		SET @cnt = @cnt + 1
	END
	
	RETURN
	
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnPadNumber]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnPadNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnPadNumber](@n [nvarchar](max), @length [tinyint])
RETURNS [nvarchar](max) WITH EXECUTE AS CALLER
AS 
BEGIN 

IF(len(@n)>=@length)
Begin
	RETURN @n
End


RETURN (replicate(''0'',@length - len(@n))) + @n 

END




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnSplit]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSplit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnSplit]    
(        
 @sInputList nvarchar(MAX), -- List of delimited items      
 @sDelimiter nvarchar(MAX) = '','' -- delimiter that separates items    
)     
RETURNS @List TABLE (item nvarchar(max))    
BEGIN    
DECLARE @sItem nvarchar(max)    
WHILE CHARINDEX(@sDelimiter,@sInputList,0) <> 0     
BEGIN     
 SELECT      
  @sItem=RTRIM(LTRIM(SUBSTRING(@sInputList,1,CHARINDEX(@sDelimiter,@sInputList,0)-1))),      
  @sInputList=RTRIM(LTRIM(SUBSTRING(@sInputList,CHARINDEX(@sDelimiter,@sInputList,0)+LEN(@sDelimiter),LEN(@sInputList))))      
     
 IF LEN(@sItem) > 0      
  INSERT INTO @List     
  SELECT @sItem     
 END     
 IF LEN(@sInputList) > 0     
  INSERT INTO @List SELECT @sInputList -- Put the last item in    
 RETURN    
 END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnsplitcalinv]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnsplitcalinv]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnsplitcalinv]    
(        
 @sInputList nvarchar(MAX)
 )     
RETURNS @List TABLE (item nvarchar(max))    
BEGIN    
/* 
select * from dbo.[fnsplitcalinv](''([5281]-[5279])'')
*/
DECLARE @sItem nvarchar(max)    
WHILE CHARINDEX(''['',@sInputList,0) <> 0     
BEGIN     
 SELECT      
  @sItem=RTRIM(LTRIM(SUBSTRING(@sInputList,CHARINDEX(''['',@sInputList,0),CHARINDEX('']'',@sInputList,0)-CHARINDEX(''['',@sInputList,0)+1))),      
  @sInputList=REPLACE(@sInputList,@sItem,'''')
     
 IF LEN(@sItem) > 0      
  INSERT INTO @List     
  SELECT @sItem     
 END     
  
 RETURN    
 END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnSplitString]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSplitString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[fnSplitString]     
(     
    @string NVARCHAR(MAX),     
    @delimiter nchar(1)     
)     
RETURNS @output TABLE(splitdata NVARCHAR(MAX)     
)     
BEGIN     
    DECLARE @start INT, @end INT     
    SELECT @start = 1, @end = CHARINDEX(@delimiter, @string)     
    WHILE @start < LEN(@string) + 1 
    BEGIN     
        IF @end = 0      
            SET @end = LEN(@string) + 1    
           
        INSERT INTO @output (splitdata)      
        VALUES(SUBSTRING(@string, @start, @end - @start))     
        SET @start = @end + 1     
        SET @end = CHARINDEX(@delimiter, @string, @start)   
    END  
    RETURN 
        
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fnTATDelayPriority]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnTATDelayPriority]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create Function [dbo].[fnTATDelayPriority]      
(      
@VisitID bigint,      
@pDeptID bigint     
)      
Returns int      
As      
Begin     
    
IF(@pDeptID=-1)    
BEGIN    
 SET @pDeptID=NULL    
END    
   
Return      
(      
      
Select top 1 Priority  from      
(      
select ReportDateTime,Case when cast(ReportDateTime as date) < Cast(Getdate() as date) then ''1''      
                           when cast(ReportDateTime as date) = Cast(Getdate() as date) then ''2''      
                           when cast(ReportDateTime as date) = Cast(Getdate()+1 as date) then ''3'' End as Priority      
                           from OrderedInvestigations ORD (NOLOCK)    
                           INNER JOIN PatientInvestigation PINV (NOLOCK) ON PINV.AccessionNumber=ORD.AccessionNumber    
                           INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=PINV.InvestigationID AND IOM.OrgID=PINV.OrgID     
         where VisitID =@VisitID and IOM.DeptID=ISNULL(@pDeptID,IOM.DeptID) AND ISNULL(ORD.PkgID,0)=0      
Union      
Select BD.ReportDateTime,Case when cast(bd.ReportDateTime as date) < Cast(Getdate() as date) then ''1''      
                           when cast(bd.ReportDateTime as date) = Cast(Getdate() as date) then ''2''      
                           when cast(bd.ReportDateTime as date) = Cast(Getdate()+1 as date) then ''3'' End as Priority      
                             from       
      (      
       select distinct PkgID,VisitID from OrderedInvestigations ORD (NOLOCK)    
                           INNER JOIN PatientInvestigation PINV (NOLOCK) ON PINV.AccessionNumber=ORD.AccessionNumber    
                           INNER JOIN InvestigationOrgMapping IOM (NOLOCK) ON IOM.InvestigationID=PINV.InvestigationID AND IOM.OrgID=PINV.OrgID     
         where VisitID =@VisitID and IOM.DeptID=ISNULL(@pDeptID,IOM.DeptID) AND ISNULL(ORD.PkgID,0)<>0    
       ) t Inner Join FinalBill FB (NOLOCK) ON FB.VisitID = t.VisitID       
      Inner Join BillingDetails BD (NOLOCK) ON FB.FinalBillID = BD.FinalBillID       
      AND BD.FeeId = t.PkgID and BD.FeeType =''PKG''      
) t1 order by Priority       
)      
End;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Getaddressdetails]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Getaddressdetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--DROP function [GetAddressDetails]        
--SELECT dbo.GetAddressDetails (5845,''Add'',86)                  
CREATE FUNCTION [dbo].[Getaddressdetails] (@ClientID BIGINT,
                                           @pType    nvarchar(10),
                                           @pOrgID   INT)
RETURNS NVARCHAR(MAX)
WITH EXECUTE AS CALLER
AS
  BEGIN
      DECLARE @pResult AS NVARCHAR(MAX)
      DECLARE @AddressDetails AS TABLE
        (
           BillTo nvarchar(MAX),
           ShipTo nvarchar(MAX)
        )
      DECLARE @PhoneDetails AS TABLE
        (
           BillingMobile  nvarchar(MAX),
           ShippingMobile nvarchar(MAX)
        )
      DECLARE @EmailDetails AS TABLE
        (
           BillingEmail  nvarchar(MAX),
           ShippingEmail nvarchar(MAX)
        )
      DECLARE @pCount AS INT
      DECLARE @pTempData AS NVARCHAR(MAX)
      DECLARE @pTable AS NVARCHAR(MAX)
      DECLARE @pTableRow AS NVARCHAR(MAX)
      DECLARE @pTempTable AS NVARCHAR(MAX)
      DECLARE @ColumnVal nvarchar(10)

      SELECT @pTable = ''<table width="100%" border = "1" style="border:solid 0px block;font-size:10px;border-spacing:1px;" >''

      IF( @pType = ''Add'' )
        BEGIN
            BEGIN
                INSERT INTO @AddressDetails
                SELECT (SELECT TOP 1 CASE ISNULL(Address1, ''-'')
                                 WHEN '''' THEN ''-''
                                 ELSE Address1
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 1
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS BillTo,
                       (SELECT TOP 1 CASE ISNULL(Address1, ''-'')
                                 WHEN '''' THEN ''-''
                                 ELSE Address1
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 2
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS ShipTo
                FROM   AddressDetails (NOLOCK)
                WHERE  ReferenceID = @ClientID AND OrgID=@pOrgID
                GROUP  BY ReferenceID

                UPDATE Ad
                SET    AD.BillTo = ''Bill To Address Not Specified''
                FROM   @AddressDetails AD
                WHERE  AD.BillTo is NULL

                UPDATE Ad
                SET    AD.ShipTo = ''Ship To Address Not Specified''
                FROM   @AddressDetails AD
                WHERE  AD.ShipTo is NULL
            END

            SELECT @pCount = Count(*)
            FROM   @AddressDetails

            IF( @pCount > 0 )
              BEGIN
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th  align="left">Billing Address</th> </tr>''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + BillTo + ''</td></tr>''
                  FROM   @AddressDetails

                  SELECT @pTempTable = @pTableRow + @pTempData

                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Address </th> </tr>''
                  SET @pTempData=''''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + ShipTo + ''</td></tr>''
                  FROM   @AddressDetails

                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData
              END
        END

      IF( @pType = ''Mobile'' )
        BEGIN
            BEGIN
                INSERT INTO @PhoneDetails
                SELECT (SELECT TOP 1 CASE
                                 WHEN ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') <> '''' then Phone + ''-'' + Mobile
                                 When ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') = '''' then Phone
                                 When ISNULL(Phone, '''') = ''''
                                      and ISNULL(Mobile, '''') <> '''' then Mobile
                                 ELSE ''-''
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 1
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS BillingMobile,
                       (SELECT TOP 1 CASE
                                 WHEN ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') <> '''' then Phone + ''-'' + Mobile
                                 When ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') = '''' then Phone
                                 When ISNULL(Phone, '''') = ''''
                                      and ISNULL(Mobile, '''') <> '''' then Mobile
                                 ELSE ''-''
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 2
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS ShippingMobile
                FROM   AddressDetails (NOLOCK)
                WHERE  ReferenceID = @ClientID AND OrgID=@pOrgID
                GROUP  BY ReferenceID

                UPDATE Ad
                SET    AD.BillingMobile = ''Bill To Number Not Specified''
                FROM   @PhoneDetails AD
                WHERE  AD.BillingMobile is NULL

                UPDATE Ad
                SET    AD.ShippingMobile = ''Ship To Number Not Specified''
                FROM   @PhoneDetails AD
                WHERE  AD.ShippingMobile is NULL
            END

            SELECT @pCount = COUNT(*)
            FROM   @PhoneDetails

            IF( @pCount > 0 )
              BEGIN
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th  align="left">Billing Contact Number </th> </tr>''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + BillingMobile + ''</td></tr>''
                  FROM   @PhoneDetails

                  SELECT @pTempTable = @pTableRow + @pTempData

                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Contact Number </th> </tr>''
                  SET @pTempData=''''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + ShippingMobile + ''</td></tr>''
                  FROM   @PhoneDetails

                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData
              END
        END

      IF( @pType = ''Email'' )
        BEGIN
            BEGIN
                INSERT INTO @EmailDetails
                SELECT (SELECT TOP 1 Case ISNULL(EmailID, ''-'')
                                 When '''' Then ''-''
                                 Else EmailID
                               End
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 1
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS BillingEmail,
                       (SELECT TOP 1 Case ISNULL(EmailID, ''-'')
                                 When '''' Then ''-''
                                 Else EmailID
                               End
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 2
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS ShippingEmail
                FROM   AddressDetails (NOLOCK)
                WHERE  ReferenceID = @ClientID AND OrgID=@pOrgID
                GROUP  BY ReferenceID

                UPDATE Ad
                SET    AD.BillingEmail = ''Bill To Email Not Specified''
                FROM   @EmailDetails AD
                WHERE  AD.BillingEmail is NULL

                UPDATE Ad
                SET    AD.ShippingEmail = ''Ship To Email Not Specified''
                FROM   @EmailDetails AD
                WHERE  AD.ShippingEmail is NULL
            END

            SELECT @pCount = Count(*)
            FROM   @EmailDetails

            IF( @pCount > 0 )
              BEGIN
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th  align="left">Billing Email </th> </tr>''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + BillingEmail + ''</td></tr>''
                  FROM   @EmailDetails

                  SELECT @pTempTable = @pTableRow + @pTempData

                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Email </th> </tr>''
                  SET @pTempData=''''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + ShippingEmail + ''</td></tr>''
                  FROM   @EmailDetails

                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData
              END
        END

      SELECT @pResult = @pTable + @pTempTable + ''</table>''

      RETURN @pResult
  END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Getaddressdetails1]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Getaddressdetails1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--DROP function [GetAddressDetails]        
--SELECT dbo.GetAddressDetails (5845,''Add'',86)                  
CREATE FUNCTION [dbo].[Getaddressdetails1] (@ClientID BIGINT,
                                           @pType    nvarchar(10),
                                           @pOrgID   INT)
RETURNS NVARCHAR(MAX)
WITH EXECUTE AS CALLER
AS
  BEGIN
      DECLARE @pResult AS NVARCHAR(MAX)
      DECLARE @AddressDetails AS TABLE
        (
           BillTo nvarchar(MAX),
           ShipTo nvarchar(MAX)
        )
      DECLARE @PhoneDetails AS TABLE
        (
           BillingMobile  nvarchar(MAX),
           ShippingMobile nvarchar(MAX)
        )
      DECLARE @EmailDetails AS TABLE
        (
           BillingEmail  nvarchar(MAX),
           ShippingEmail nvarchar(MAX)
        )
      DECLARE @pCount AS INT
      DECLARE @pTempData AS NVARCHAR(MAX)
      DECLARE @pTable AS NVARCHAR(MAX)
      DECLARE @pTableRow AS NVARCHAR(MAX)
      DECLARE @pTempTable AS NVARCHAR(MAX)
      DECLARE @ColumnVal nvarchar(10)

      SELECT @pTable = ''<table width="100%" border = "1" style="border:solid 0px block;font-size:10px;border-spacing:1px;" >''

      IF( @pType = ''Add'' )
        BEGIN
            BEGIN
                INSERT INTO @AddressDetails
                SELECT (SELECT TOP 1 CASE ISNULL(Address1, ''-'')
                                 WHEN '''' THEN ''-''
                                 ELSE Address1
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 1
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS BillTo,
                       (SELECT TOP 1 CASE ISNULL(Address1, ''-'')
                                 WHEN '''' THEN ''-''
                                 ELSE Address1
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 2
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS ShipTo
                FROM   AddressDetails (NOLOCK)
                WHERE  ReferenceID = @ClientID AND OrgID=@pOrgID
                GROUP  BY ReferenceID

                UPDATE Ad
                SET    AD.BillTo = ''Bill To Address Not Specified''
                FROM   @AddressDetails AD
                WHERE  AD.BillTo is NULL

                UPDATE Ad
                SET    AD.ShipTo = ''Ship To Address Not Specified''
                FROM   @AddressDetails AD
                WHERE  AD.ShipTo is NULL
            END

            SELECT @pCount = Count(*)
            FROM   @AddressDetails

            IF( @pCount > 0 )
              BEGIN
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th  align="left">Billing Address</th> </tr>''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + BillTo + ''</td></tr>''
                  FROM   @AddressDetails

                  SELECT @pTempTable = @pTableRow + @pTempData

                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Address </th> </tr>''
                  SET @pTempData=''''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + ShipTo + ''</td></tr>''
                  FROM   @AddressDetails

                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData
              END
        END

      IF( @pType = ''Mobile'' )
        BEGIN
            BEGIN
                INSERT INTO @PhoneDetails
                SELECT (SELECT TOP 1 CASE
                                 WHEN ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') <> '''' then Phone + ''-'' + Mobile
                                 When ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') = '''' then Phone
                                 When ISNULL(Phone, '''') = ''''
                                      and ISNULL(Mobile, '''') <> '''' then Mobile
                                 ELSE ''-''
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 1
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS BillingMobile,
                       (SELECT TOP 1 CASE
                                 WHEN ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') <> '''' then Phone + ''-'' + Mobile
                                 When ISNULL(Phone, '''') <> ''''
                                      and ISNULL(Mobile, '''') = '''' then Phone
                                 When ISNULL(Phone, '''') = ''''
                                      and ISNULL(Mobile, '''') <> '''' then Mobile
                                 ELSE ''-''
                               END
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 2
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS ShippingMobile
                FROM   AddressDetails (NOLOCK)
                WHERE  ReferenceID = @ClientID AND OrgID=@pOrgID
                GROUP  BY ReferenceID

                UPDATE Ad
                SET    AD.BillingMobile = ''Bill To Number Not Specified''
                FROM   @PhoneDetails AD
                WHERE  AD.BillingMobile is NULL

                UPDATE Ad
                SET    AD.ShippingMobile = ''Ship To Number Not Specified''
                FROM   @PhoneDetails AD
                WHERE  AD.ShippingMobile is NULL
            END

            SELECT @pCount = COUNT(*)
            FROM   @PhoneDetails

            IF( @pCount > 0 )
              BEGIN
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th  align="left">Billing Contact Number </th> </tr>''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + BillingMobile + ''</td></tr>''
                  FROM   @PhoneDetails

                  SELECT @pTempTable = @pTableRow + @pTempData

                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Contact Number </th> </tr>''
                  SET @pTempData=''''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + ShippingMobile + ''</td></tr>''
                  FROM   @PhoneDetails

                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData
              END
        END

      IF( @pType = ''Email'' )
        BEGIN
            BEGIN
                INSERT INTO @EmailDetails
                SELECT (SELECT TOP 1 Case ISNULL(EmailID, ''-'')
                                 When '''' Then ''-''
                                 Else EmailID
                               End
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 1
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS BillingEmail,
                       (SELECT TOP 1 Case ISNULL(EmailID, ''-'')
                                 When '''' Then ''-''
                                 Else EmailID
                               End
                        FROM   AddressDetails (NOLOCK)
                        WHERE  AddressTypeID = 2
                               AND ReferenceID = @ClientID AND OrgID=@pOrgID) AS ShippingEmail
                FROM   AddressDetails (NOLOCK)
                WHERE  ReferenceID = @ClientID AND OrgID=@pOrgID
                GROUP  BY ReferenceID

                UPDATE Ad
                SET    AD.BillingEmail = ''Bill To Email Not Specified''
                FROM   @EmailDetails AD
                WHERE  AD.BillingEmail is NULL

                UPDATE Ad
                SET    AD.ShippingEmail = ''Ship To Email Not Specified''
                FROM   @EmailDetails AD
                WHERE  AD.ShippingEmail is NULL
            END

            SELECT @pCount = Count(*)
            FROM   @EmailDetails

            IF( @pCount > 0 )
              BEGIN
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th  align="left">Billing Email </th> </tr>''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + BillingEmail + ''</td></tr>''
                  FROM   @EmailDetails

                  SELECT @pTempTable = @pTableRow + @pTempData

                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Email </th> </tr>''
                  SET @pTempData=''''

                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''
                                      + ShippingEmail + ''</td></tr>''
                  FROM   @EmailDetails

                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData
              END
        END

      SELECT @pResult = @pTable + @pTempTable + ''</table>''

      RETURN @pResult
  END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetaddressdetailsB]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetaddressdetailsB]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--DROP function [GetAddressDetails]        
--SELECT dbo.GetAddressDetailsB (3361,''Add'',93)                  
CREATE FUNCTION [dbo].[GetaddressdetailsB] (@ClientID BIGINT,        
                                          @pType    nvarchar(10),        
                                          @pOrgID   INT)        
RETURNS NVARCHAR(MAX)        
WITH EXECUTE AS CALLER        
AS        
  BEGIN        
      DECLARE @pResult AS NVARCHAR(MAX)        
      DECLARE @AddressDetails AS TABLE        
        (        
           BillTo nvarchar(100),        
           ShipTo nvarchar(100)        
        )        
      DECLARE @PhoneDetails AS TABLE        
        (        
           BillingMobile nvarchar(100),        
           ShippingMobile nvarchar(100)        
        )        
      DECLARE @EmailDetails AS TABLE        
        (        
           BillingEmail nvarchar(100),        
           ShippingEmail nvarchar(100)        
        )        
      DECLARE @pCount AS INT        
      DECLARE @pTempData AS NVARCHAR(MAX)        
      DECLARE @pTable AS NVARCHAR(MAX)        
      DECLARE @pTableRow AS NVARCHAR(MAX)        
      DECLARE @pTempTable AS NVARCHAR(MAX)        
      DECLARE @ColumnVal nvarchar(10)        
        
      SELECT @pTable = ''<table width="100%" border = "1" style="border:solid 0px block;font-size:10px;border-spacing:1px;" >''        
        
      IF( @pType = ''Add'' )        
        BEGIN        
            BEGIN        
                    
                INSERT INTO @AddressDetails      
                --select ''a''  
                SELECT (SELECT   case  Isnull(address1, ''-'') when '''' then ''-''        
                Else address1 end        
                        FROM   addressdetails        
                        WHERE  addresstypeid = 1        
                               AND Referenceid = @ClientID) AS BillTo,        
                       (SELECT case Isnull(address1, ''-'')  when '''' then ''-''         
                       Else address1 end        
                        FROM   addressdetails        
                        WHERE  addresstypeid = 2        
                               AND Referenceid = @ClientID) AS ShipTo        
                FROM   addressdetails        
                WHERE  ReferenceID = @ClientID        
                GROUP  BY ReferenceID     
                
                   
                    
            END        
        
            SELECT @pCount = Count(*)        
            FROM   @AddressDetails        
        
            IF( @pCount > 0 )        
              BEGIN        
                  SET @pTempData=''''        
        
                        
                        SET @pTableRow = ''<tr> <th  align="left">Billing Address</th> </tr>''        
        
                        SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''        
                                            + BillTo + ''</td></tr>''        
                        FROM   @AddressDetails        
        
                        SELECT @pTempTable = @pTableRow + @pTempData        
                          
                      
                        SET @pTableRow = ''<tr> <th  align="left"> Shipping Address </th> </tr>''        
                        SET @pTempData=''''        
        
                        SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''        
                                            + ShipTo + ''</td></tr>''        
                        FROM   @AddressDetails        
        
                        SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData        
                           
              END        
        END        
        
      IF( @pType = ''Mobile'' )        
        BEGIN        
            BEGIN        
                INSERT INTO @PhoneDetails        
                SELECT (SELECT CASE WHEN ISNULL(Phone,'''')<>'''' and ISNULL(Mobile,'''')<>'''' then Phone +''-''+Mobile    
           When ISNULL(Phone,'''')<>'''' and ISNULL(Mobile,'''')='''' then Phone    
           When ISNULL(Phone,'''')='''' and ISNULL(Mobile,'''')<>'''' then Mobile     
ELSE ''-''  END        
                        FROM   addressdetails        
                        WHERE  addresstypeid = 1        
                               AND Referenceid = @ClientID) AS BillingMobile,        
                       (SELECT CASE WHEN ISNULL(Phone,'''')<>'''' and ISNULL(Mobile,'''')<>'''' then Phone +''-''+Mobile    
           When ISNULL(Phone,'''')<>'''' and ISNULL(Mobile,'''')='''' then Phone    
           When ISNULL(Phone,'''')='''' and ISNULL(Mobile,'''')<>'''' then Mobile     
           ELSE ''-''  END        
                        FROM   addressdetails        
                        WHERE  addresstypeid = 2        
                               AND Referenceid = @ClientID) AS ShippingMobile        
                FROM   addressdetails        
                WHERE  ReferenceID = @ClientID        
                GROUP  BY ReferenceID        
            END        
        
            SELECT @pCount = Count(*)        
            FROM   @PhoneDetails        
        
     IF( @pCount > 0 )        
              BEGIN        
                  SET @pTempData=''''        
                  SET @pTableRow = ''<tr> <th  align="left">Billing Contact Number </th> </tr>''        
        
                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''        
                                      + BillingMobile + ''</td></tr>''        
                  FROM   @PhoneDetails        
        
                  SELECT @pTempTable = @pTableRow + @pTempData        
        
                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Contact Number </th> </tr>''        
                  SET @pTempData=''''        
        
                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''        
                                      + ShippingMobile + ''</td></tr>''        
                  FROM   @PhoneDetails        
        
                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData        
              END        
        END        
        
      IF( @pType = ''Email'' )        
        BEGIN        
            BEGIN        
                INSERT INTO @EmailDetails        
                SELECT (SELECT Case ISNULL(EmailID,''-'') When '''' Then ''-''         
                                                        Else EmailID  End        
                        FROM   addressdetails        
                        WHERE  addresstypeid = 1        
                               AND Referenceid = @ClientID) AS BillingEmail,        
                       (SELECT Case ISNULL(EmailID,''-'') When '''' Then ''-''        
                        Else EmailID End        
                        FROM   addressdetails        
                        WHERE  addresstypeid = 2        
                               AND Referenceid = @ClientID) AS ShippingEmail        
                FROM   addressdetails        
                WHERE  ReferenceID = @ClientID        
                GROUP  BY ReferenceID        
            END        
        
            SELECT @pCount = Count(*)        
            FROM   @EmailDetails        
        
            IF( @pCount > 0 )        
              BEGIN        
                  SET @pTempData=''''        
                  SET @pTableRow = ''<tr> <th  align="left">Billing Email </th> </tr>''        
        
                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''        
                                      + BillingEmail + ''</td></tr>''        
                  FROM   @EmailDetails        
        
                  SELECT @pTempTable = @pTableRow + @pTempData        
        
                  SET @pTableRow = ''<tr> <th  align="left"> Shipping Email </th> </tr>''        
                  SET @pTempData=''''        
        
                  SELECT @pTempData = @pTempData + ''<tr> <td align="left"> ''        
                                      + ShippingEmail + ''</td></tr>''        
                  FROM   @EmailDetails        
        
                  SELECT @pTempTable = @pTempTable + @pTableRow + @pTempData    
              END        
        END        
        
      SELECT @pResult = @pTable + @pTempTable + ''</table>''        
        
      RETURN @pResult        
  END 




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetAdvanceAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAdvanceAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetAdvanceAmount] (@Vid bigint,@FeeId bigint)      
RETURNS decimal(18,2)      
WITH EXECUTE AS CALLER      
AS      
BEGIN      
     DECLARE @AmountPaid decimal(18,2)      
     IF @FeeId = ''''  
     BEGIN  
  select @AmountPaid=SUM(AdvanceAmount) from AdvancePaidDetails APD where APD.VisitID=@Vid   
  END  
  ELSE  
  BEGIN  
  select @AmountPaid=SUM(AdvanceAmount) from AdvancePaidDetails APD where APD.VisitID=@Vid and APD.AdvanceTypeID=@FeeId    
     END  
     SET @AmountPaid = ISNULL(@AmountPaid,0)      
     RETURN(@AmountPaid);      
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetAmountForLedgerHeads]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAmountForLedgerHeads]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'        
CREATE FUNCTION [dbo].[GetAmountForLedgerHeads] (@OrgID int,@ClientCode varchar(20),@type varchar(10))                
RETURNS decimal(18,2)                
WITH EXECUTE AS CALLER                
AS                
BEGIN                
    DECLARE @amount decimal(18,2)                
                  
       if @type = ''OB''            
    begin            
       SELECT @amount = ISNULL(ClosingBalance,0) FROM ClientMonthClosing WHERE SourceCode=@ClientCode and OrgID = @OrgID AND MONTH(MONTH)=MONTH(GETDATE())-1           
       AND YEAR(MONTH)=(CASE WHEN MONTH(GETDATE())=1 THEN YEAR(GETDATE())-1 ELSE YEAR(GETDATE()) END)           
       end            
       else if @type = ''Bills''           
       begin            
       SELECT @amount = ISNULL(SUM(Amount),0)  FROM ClientBill WHERE SourceCode=@ClientCode and OrgID = @OrgID AND MONTH(CreatedAt)=MONTH(GETDATE())            
       AND YEAR(CreatedAt)=YEAR(GETDATE())        
       end            
       else if @type = ''Debits''            
       begin            
       SELECT @amount = ISNULL(SUM(Amount),0) FROM ClientDebit WHERE SourceCode=@ClientCode AND STATUS=''Approved'' and OrgID = @OrgID AND MONTH(CreatedAt)=MONTH(GETDATE())            
       AND YEAR(CreatedAt)=YEAR(GETDATE())        
          
       end            
       else if @type = ''Credits''            
       begin            
       SELECT @amount = ISNULL(SUM(Amount),0)  FROM ClientCredit WHERE SourceCode=@ClientCode AND STATUS=''Approved'' and OrgID = @OrgID AND MONTH(CreatedAt)=MONTH(GETDATE())            
       AND YEAR(CreatedAt)=YEAR(GETDATE())    
       end            
       else if @type = ''Receipts''            
       begin            
       SELECT @amount = ISNULL(SUM(Amount),0) FROM ClientReceipt WHERE SourceCode=@ClientCode and OrgID = @OrgID AND MONTH(CreatedAt)=MONTH(GETDATE())            
       AND YEAR(CreatedAt)=YEAR(GETDATE())  AND ResponseCode =''0''        
       end                 
                     
                     
    RETURN(@amount);                
END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetAsciiValue]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAsciiValue]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create  FUNCTION [dbo].[GetAsciiValue] (@Value VARCHAR(255))
RETURNS NVARCHAR(255)
AS
BEGIN                                     
	DECLARE @Str AS VARCHAR(100) = @Value
	DECLARE @ConCatValue AS NCHAR(3) = ''''
	DECLARE @cnt AS INT = 1
	DECLARE @length AS INT = len(@Str)
	DECLARE @suptemp AS TABLE (
	Id NCHAR(10)
	,Value NCHAR(10)
	,SupValue NCHAR(10)
	)
	INSERT INTO @suptemp
		SELECT ''1''		,185		,NCHAR(185)
	UNION
		SELECT ''0''		,186		,NCHAR(186)
	UNION
		SELECT ''2''		,178		,NCHAR(178)
	UNION
		SELECT ''3''		,179		,NCHAR(179)
	UNION
		SELECT ''4''		,8308		,NCHAR(8308)
	UNION
		SELECT ''5''		,8309		,NCHAR(8309)
	UNION
		SELECT ''6''		,8310		,NCHAR(8310)
	UNION
		SELECT ''7''		,8311		,NCHAR(8311)
	UNION
		SELECT ''8''		,8312		,NCHAR(8312)
	UNION
		SELECT ''9''		,8313		,NCHAR(186)
	WHILE (@cnt <= @length)
	BEGIN
		DECLARE @whereValue AS VARCHAR(100) = SUBSTRING(@str, @cnt, 1)
		DECLARE @SelStr AS NCHAR(10) = (
			SELECT NCHAR(Value)
			FROM @suptemp
			WHERE ID = @whereValue
		)
		IF (@ConCatValue <> '''')
			SET @ConCatValue = LTRIM(RTRIM(@ConCatValue)) + LTRIM(RTRIM(@SelStr))
		ELSE
			SET @ConCatValue = @SelStr
		SET @cnt = @cnt + 1
	END
	RETURN @ConCatValue 
END 

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement  = N' CREATE Function [dbo].[GetBillDescription]            
(            
@FinalBillID bigint,            
@VisitID bigint,            
@Type varchar(20),            
@ReceiptNo varchar(30),            
                                            @pOrgID      INT,
                                            @LangCode    NVARCHAR(20))
RETURNS NVARCHAR(MAX)                                                
WITH EXECUTE AS CALLER                                                
AS                                                
BEGIN             
DECLARE @pResult AS NVARCHAR(MAX)   ,@IsFranchisee nchar(1)
SELECT @IsFranchisee=IsFranchisee FROM Finalbill (NOLOCK) WHERE FinalbillID=@FinalBillID             
DECLARE @FeeDescription as Table                      
(                      
RowID bigint,                      
BilledFor varchar(100),            
Quanity Varchar(100),            
Amount Varchar(100),            
BilledAmt Varchar(100),              
FeeType Varchar(100),  
MRP   Varchar(100)          
)              
      DECLARE @tempMetadata AS TABLE
        (
           RowID       BIGINT,
           Code        VARCHAR(100),
           Description VARCHAR(100),
           LangCode    VARCHAR(100)
        )
      INSERT INTO @tempmetadata
                  (Code,
                   Description,
                   LangCode)
      SELECT M.Code,
             Mp.Displaytext,
             Mp.LangCode
      FROM   metadata M
             INNER JOIN Metadataorgmapping Mp
                     ON MP.metadataid = m.metadataid
      WHERE  m.domain = ''BillWiseDeptWise''
             AND Isnull(Mp.LangCode, ''en-GB'') = @LangCode
      DECLARE @Desc NVARCHAR(25)
      DECLARE @BillAmt NVARCHAR(25)
      DECLARE @FeeType NVARCHAR(25)
      DECLARE @MRP NVARCHAR(25)
      DECLARE @Ramt NVARCHAR(25)
      DECLARE @Damt NVARCHAR(25)
      SELECT @Desc = Description
      FROM   @tempmetadata
      WHERE  code = ''Des''
      SELECT @BillAmt = Description
      FROM   @tempmetadata
      WHERE  code = ''BAMT''
      SELECT @FeeType = Description
      FROM   @tempmetadata
      WHERE  code = ''FT''
      SELECT @MRP = Description
      FROM   @tempmetadata
      WHERE  code = ''MRP''
      SELECT @Ramt = Description
      FROM   @tempmetadata
      WHERE  code = ''RAmt''
      SELECT @Damt = Description
      FROM   @tempmetadata
      WHERE  code = ''DAmt''
DECLARE @intFlag INT                        
DECLARE @pCount AS INT                       
DECLARE @pTempData AS NVARCHAR(MAX)               
DECLARE @pTable AS NVARCHAR(MAX)               
DECLARE @pTableRow AS NVARCHAR(MAX)               
SET @intFlag = 1                  
IF @Type = ''Bill''             
BEGIN    
IF @IsFranchisee=''Y''
BEGIN
	INSERT INTO @FeeDescription                       
	SELECT ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,BD.Quantity),CONVERT(Varchar,BD.Amount)            
	,CONVERT(Varchar,SUM(convert(decimal(18,2),BD.Quantity * BD.Amount))),            
	CASE                                                                        
	WHEN BD.FeeType = ''CON'' THEN ''Consultation''                                                                       
	WHEN BD.FeeType = ''PRO'' THEN ''Procedure''                                                    
	WHEN BD.FeeType = ''PRM'' THEN ''Pharmacy''                                                
	WHEN BD.FeeType = ''REG'' THEN ''Registration''                                                               
	WHEN BD.FeeType = ''OTH'' THEN ''Others''                                                                       
	WHEN BD.FeeType = ''ROM'' THEN ''Room''                                                                        
	WHEN BD.FeeType = ''PKG'' THEN ''Packages''                                                                        
	WHEN BD.FeeType = ''CAS'' THEN ''Casualty''        
	WHEN BD.FeeType = ''GRP'' THEN ''Lab''                                                                        
	WHEN BD.FeeType = ''SOI'' THEN ''Surgery Items''                                                                        
	WHEN BD.FeeType = ''SUR'' THEN ''Surgery''                                                                        
	WHEN BD.FeeType = ''SPKG'' THEN ''Surgery Package''                                                                        
	WHEN BD.FeeType = ''GEN'' THEN ''General''                                                                        
	WHEN BD.FeeType = ''IND'' THEN ''Indents''                                                         
	WHEN BD.FeeType = ''Miscellaneous'' THEN ''Misc''                                                                        
	WHEN BD.FeeType = ''LCON'' THEN ''LCON''                                                                       
	WHEN BD.FeeType = ''DUE'' THEN ''Due''                                                                        
	WHEN BD.FeeType = ''ADD'' THEN ''Additional''                                                                        
	WHEN BD.FeeType = ''INV'' THEN  ''LAB'' END    ,        
	CONVERT(Varchar,BD.ActualAmount)            
	FROM BillingDetails_Franchisee BD (NOLOCK) WHERE BD.FinalBillID = @FinalBillID             
	GROUP BY FinalBillID,FeeDescription,Quantity,FeeType,Amount,ActualAmount   
END    
ELSE
BEGIN    
	INSERT INTO @FeeDescription                       
	SELECT ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,BD.Quantity),CONVERT(Varchar,BD.Amount)            
	,CONVERT(Varchar,SUM(convert(decimal(18,2),BD.Quantity * BD.Amount))),            
	CASE                                                                        
	WHEN BD.FeeType = ''CON'' THEN ''Consultation''                                                                       
	WHEN BD.FeeType = ''PRO'' THEN ''Procedure''                                                    
	WHEN BD.FeeType = ''PRM'' THEN ''Pharmacy''                                                
	WHEN BD.FeeType = ''REG'' THEN ''Registration''                                                               
	WHEN BD.FeeType = ''OTH'' THEN ''Others''                                                                       
	WHEN BD.FeeType = ''ROM'' THEN ''Room''                                                                        
	WHEN BD.FeeType = ''PKG'' THEN ''Packages''                                                                        
	WHEN BD.FeeType = ''CAS'' THEN ''Casualty''                                                                        
	WHEN BD.FeeType = ''GRP'' THEN ''Lab''                                                                        
	WHEN BD.FeeType = ''SOI'' THEN ''Surgery Items''                                                                        
	WHEN BD.FeeType = ''SUR'' THEN ''Surgery''                                                                        
	WHEN BD.FeeType = ''SPKG'' THEN ''Surgery Package''                                                                        
	WHEN BD.FeeType = ''GEN'' THEN ''General''                                                                        
	WHEN BD.FeeType = ''IND'' THEN ''Indents''                                                         
	WHEN BD.FeeType = ''Miscellaneous'' THEN ''Misc''                                                                        
	WHEN BD.FeeType = ''LCON'' THEN ''LCON''                                                                       
	WHEN BD.FeeType = ''DUE'' THEN ''Due''                                                                        
	WHEN BD.FeeType = ''ADD'' THEN ''Additional''                                                                        
	WHEN BD.FeeType = ''INV'' THEN  ''LAB'' END    ,        
	CONVERT(Varchar,BD.ActualAmount)            
	FROM BillingDetails BD WHERE BD.FinalBillID = @FinalBillID             
	GROUP BY FinalBillID,FeeDescription,Quantity,FeeType,Amount,ActualAmount  
END           
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN    
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th> '' + @Desc + '' </th> <th>'' + @BillAmt
                                   + ''</td> <th>'' + @Feetype + '' </th> <th> '' + @MRP
                                   + ''</th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN              
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td> '' + FeeType + ''</td> <td> '' + MRP
                                                + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''              
END              
END            
IF @Type = ''Refund''             
BEGIN      
 IF @IsFranchisee=''Y''
 BEGIN
	INSERT INTO @FeeDescription                       
	SELECT ROW_NUMBER() OVER(ORDER BY  ARD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,ARD.Quantity),''0''            
	,CONVERT(Varchar,SUM(convert(decimal(18,2),AmtRefund))),'' (Refund)''            
	,        
	CONVERT(Varchar,BD.ActualAmount)   
	FROM AmountRefundDetails ARD            
	INNER JOIN BillingDetails_Franchisee BD ON ARD.FinalBillID = BD.FinalBillID AND ARD.BillingDetailsID = BD.BillingDetailsID    
	WHERE BD.FinalBillID = @FinalBillID             
	GROUP BY  ARD.FinalBillID,BD.FeeDescription,ARD.Quantity ,BD.ActualAmount
 END
 ELSE
 BEGIN      
	INSERT INTO @FeeDescription                       
	SELECT ROW_NUMBER() OVER(ORDER BY  ARD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,ARD.Quantity),''0''            
	,CONVERT(Varchar,SUM(convert(decimal(18,2),AmtRefund))),'' (Refund)''            
	,        
	CONVERT(Varchar,BD.ActualAmount)   
	FROM AmountRefundDetails ARD            
	INNER JOIN BillingDetails BD ON ARD.FinalBillID = BD.FinalBillID AND ARD.BillingDetailsID = BD.BillingDetailsID     
	INNER JOIN FInalBill FB(NOLOCK) ON FB.FinalBillID=BD.FInalBillID AND FB.IsFranchisee=0       
	WHERE BD.FinalBillID = @FinalBillID             
	GROUP BY  ARD.FinalBillID,BD.FeeDescription,ARD.Quantity ,BD.ActualAmount
 END             
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th>'' + @Desc + '' </th> <th> '' + @Ramt
                                   + '' </th> <th>'' + @Feetype + '' </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN                      
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                    + ''</td><td> '' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END            
IF @Type = ''Deposit''             
BEGIN            
INSERT INTO @FeeDescription                       
SELECT ROW_NUMBER() OVER(ORDER BY  PDH.ReceiptNo) AS RowID, ''Depsoit Collection'',''0'',''0''            
,CONVERT(Varchar,SUM(convert(decimal(18,2),AmountDeposited))),'' Deposit'',''''
FROM PatientDepositHistory PDH  
INNER JOIN Patient P ON P.PatientID = PDH.PatientID and PDH.OrgID = @pOrgID            
WHERE PDH.ReceiptNo = @FinalBillID             
GROUP BY   PDH.ReceiptNo            
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;">''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th> '' + @Desc + '' </th> <th> '' + @Damt
                                   + '' </th> <th>'' + @Feetype + '' </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN                   
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td> '' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END            
IF @Type = ''IP''             
BEGIN            
DECLARE @startBillingID bigint          
DECLARE @EndBillingID bigint          
SELECT @startBillingID = StartBillingDetailID,@EndBillingID = EndBillingDetaillID          
FROM   IPIntermediatePayments where VisitID = @VisitID and ReceiptNO = @ReceiptNo and OrgID = @pOrgID          
INSERT INTO @FeeDescription                       
SELECT  ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,BD.Quantity),CONVERT(Varchar,BD.Amount)            
,CONVERT(Varchar,SUM(convert(decimal(18,2),BD.Quantity * BD.Amount))),            
CASE                                                                        
WHEN BD.FeeType = ''CON'' THEN  ''Consultation''                                                                        
WHEN BD.FeeType = ''PRO'' THEN ''Procedure''                                                    
WHEN BD.FeeType = ''PRM'' THEN ''Pharmacy''                                                
WHEN BD.FeeType = ''REG'' THEN ''Registration''                                                               
WHEN BD.FeeType = ''OTH'' THEN ''Others''                                                                       
WHEN BD.FeeType = ''ROM'' THEN ''Room''                                                                        
WHEN BD.FeeType = ''PKG'' THEN ''Packages''                                                                        
WHEN BD.FeeType = ''CAS'' THEN ''Casualty''                                                                        
WHEN BD.FeeType = ''GRP'' THEN ''Lab''                                                                        
WHEN BD.FeeType = ''SOI'' THEN ''Surgery Items''                                                                        
WHEN BD.FeeType = ''SUR'' THEN ''Surgery''                                                                       
WHEN BD.FeeType = ''SPKG'' THEN ''Surgery Package''                                                              
WHEN BD.FeeType = ''GEN'' THEN ''General''                                                                        
WHEN BD.FeeType = ''IND'' THEN ''Indents''                                                         
WHEN BD.FeeType = ''Miscellaneous'' THEN ''Misc''                                                                        
WHEN BD.FeeType = ''LCON'' THEN ''LCON''                                        
WHEN BD.FeeType = ''DUE'' THEN ''Due''                                                                        
WHEN BD.FeeType = ''ADD'' THEN ''Additional''                                                                        
WHEN BD.FeeType = ''INV'' THEN  ''LAB'' END            
,CONVERT(Varchar,BD.ActualAmount)    
FROM  BillingDetails BD           
WHERE BD.FinalBillID = @FinalBillID and BD.BillingDetailsID between @startBillingID and @EndBillingID           
AND BD.FeeId not in(-2,-3,-4)          
GROUP BY FinalBillID,FeeDescription,Quantity,FeeType,Amount,ActualAmount             
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th> '' + @Desc + '' </th> <th> '' + @BillAmt
                                   + ''</td> <th>'' + @Feetype + ''  </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN                      
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td> '' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END          
IF @Type = ''IPItemRefund''             
BEGIN            
INSERT INTO @FeeDescription                       
SELECT ROW_NUMBER() OVER(ORDER BY  ARD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,ARD.Quantity),''0''           
,CONVERT(Varchar,SUM(convert(decimal(18,2),AmtRefund))),'' (Refund)''  ,''''          
FROM AmountRefundDetails ARD            
INNER JOIN BillingDetails BD ON ARD.FinalBillID = BD.FinalBillID AND ARD.BillingDetailsID = BD.BillingDetailsID          
WHERE ARD.RefundNo = @ReceiptNo and ARD.OrgID = @pOrgID            
GROUP BY  ARD.FinalBillID,BD.FeeDescription,ARD.Quantity              
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th>  '' + @Desc + '' </th> <th>'' + @BillAmt
                                   + '' </th> <th> '' + @Feetype + '' </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)           
BEGIN                      
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td>'' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END             
IF @Type = ''IPRefund''             
BEGIN            
INSERT INTO @FeeDescription                       
SELECT ROW_NUMBER() OVER(ORDER BY  ARD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,ARD.Quantity),''0''            
,CONVERT(Varchar,SUM(convert(decimal(18,2),AmtRefund))),''(Refund)'' ,''''           
FROM AmountRefundDetails ARD            
INNER JOIN BillingDetails BD ON ARD.FinalBillID = BD.FinalBillID AND ARD.BillingDetailsID = 0          
WHERE ARD.RefundNo = @ReceiptNo and ARD.OrgID = @pOrgID            
GROUP BY  ARD.FinalBillID,BD.FeeDescription,ARD.Quantity              
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                    
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th>'' + @Desc + '' </th> <th>'' + @Ramt
                                   + '' </th> <th> '' + @Feetype + '' </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN                      
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td>'' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END             
IF @Type = ''IPDue''             
BEGIN            
INSERT INTO @FeeDescription                       
SELECT  ROW_NUMBER() OVER(ORDER BY BD.VisitID) AS RowID, BD.Description,CONVERT(Varchar,BD.unit),CONVERT(Varchar,BD.Amount)            
,CONVERT(Varchar,SUM(convert(decimal(18,2),BD.unit * BD.Amount))),            
CASE                                                                        
WHEN BD.FeeType = ''CON'' THEN ''Consultation''                                                                        
WHEN BD.FeeType = ''PRO'' THEN ''Procedure''                                                    
WHEN BD.FeeType = ''PRM'' THEN ''Pharmacy''                                                
WHEN BD.FeeType = ''REG'' THEN ''Registration''                                                               
WHEN BD.FeeType = ''OTH'' THEN ''Others''                                                                       
WHEN BD.FeeType = ''ROM'' THEN ''Room''                                                                        
WHEN BD.FeeType = ''PKG'' THEN ''Packages''                                                                         WHEN BD.FeeType = ''CAS'' THEN ''Casualty''                                                                        
WHEN BD.FeeType = ''GRP'' THEN ''Lab''                                                                        
WHEN BD.FeeType = ''SOI'' THEN ''Surgery Items''                                                                        
WHEN BD.FeeType = ''SUR'' THEN ''Surgery''                                                                        
WHEN BD.FeeType = ''SPKG'' THEN ''Surgery Package''                                                                        
WHEN BD.FeeType = ''GEN'' THEN ''General''                                                                        
WHEN BD.FeeType = ''IND'' THEN ''Indents''                                                         
WHEN BD.FeeType = ''Miscellaneous'' THEN ''Misc''                                                                        
WHEN BD.FeeType = ''LCON'' THEN ''LCON''                                                                        
WHEN BD.FeeType = ''DUE'' THEN ''Due''                                                                        
WHEN BD.FeeType = ''ADD'' THEN ''Additional''                                                                        
WHEN BD.FeeType = ''INV'' THEN  ''LAB'' END            
,''''  
FROM  PatientDueChart BD           
INNER JOIN FinalBill F ON BD.VisitID = F.VisitID AND BD.InterimBillNo = @ReceiptNo    
WHERE BD.FeeId not in(-2,-3,-4)          
GROUP BY BD.VisitID,Description,unit,FeeType,Amount             
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th> '' + @Desc + '' </th> <th> '' + @BillAmt
                                   + '' </td> <th> '' + @Feetype + '' </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN                      
                            SELECT @pTempData = @pTempData + ''<tr> <td>'' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td> '' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END           
IF @Type = ''IPPharmaDue''             
BEGIN            
SELECT @startBillingID = StartBillingDetailID,@EndBillingID = EndBillingDetaillID          
FROM   IPIntermediatePayments where VisitID = @VisitID and ReceiptNO = @ReceiptNo and OrgID = @pOrgID          
INSERT INTO @FeeDescription                       
SELECT  ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, BD.FeeDescription,CONVERT(Varchar,BD.Quantity),CONVERT(Varchar,BD.Amount)            
,CONVERT(Varchar,SUM(convert(decimal(18,2),BD.Quantity * BD.Amount))),            
CASE                                                                        
WHEN BD.FeeType = ''CON'' THEN ''Consultation''                                                                        
WHEN BD.FeeType = ''PRO'' THEN ''Procedure''                                                    
WHEN BD.FeeType = ''PRM'' THEN ''Pharmacy''                           
WHEN BD.FeeType = ''REG'' THEN ''Registration''                                                               
WHEN BD.FeeType = ''OTH'' THEN ''Others''                                                                       
WHEN BD.FeeType = ''ROM'' THEN ''Room''                                                                        
WHEN BD.FeeType = ''PKG'' THEN ''Packages''                                                                        
WHEN BD.FeeType = ''CAS'' THEN ''Casualty''                                                                        
WHEN BD.FeeType = ''GRP'' THEN ''Lab''                                                                      
WHEN BD.FeeType = ''SOI'' THEN ''Surgery Items''                                                                        
WHEN BD.FeeType = ''SUR'' THEN ''Surgery''                                                                        
WHEN BD.FeeType = ''SPKG'' THEN ''Surgery Package''                                                                        
WHEN BD.FeeType = ''GEN'' THEN ''General''                                                                        
WHEN BD.FeeType = ''IND'' THEN ''Indents''                                                         
WHEN BD.FeeType = ''Miscellaneous'' THEN ''Misc''                                                                        
WHEN BD.FeeType = ''LCON'' THEN ''LCON''                                                   
WHEN BD.FeeType = ''DUE'' THEN ''Due''                                                                        
WHEN BD.FeeType = ''ADD'' THEN ''Additional''                                                                        
WHEN BD.FeeType = ''INV'' THEN  ''LAB'' END                                                 
,''''  
FROM  BillingDetails BD           
WHERE BD.FinalBillID = @FinalBillID and BD.BillingDetailsID between @startBillingID and @EndBillingID          
AND BD.FeeId not in(-2,-3,-4)          
GROUP BY FinalBillID,FeeDescription,Quantity,FeeType,Amount             
SELECT @pCount = COUNT(*) from @FeeDescription              
IF(@pCount>0)                  
BEGIN                
SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                     
                  SET @pTempData=''''
                  SET @pTableRow = ''<tr> <th> '' + @Desc + '' </th> <th> '' + @BillAmt
                                   + ''</td> <th> '' + @Feetype + '' </th> </tr>''
BEGIN                  
WHILE (@intFlag <= @pCount)                        
BEGIN                      
                            SELECT @pTempData = @pTempData + ''<tr> <td> '' + BilledFor
                                                + ''</td> <td align="right"> '' + BilledAmt
                                                + ''</td><td> '' + FeeType + ''</td>  </tr>''
                            FROM   @FeeDescription
                            WHERE  RowID = @intFlag
SET @intFlag = @intFlag + 1                        
END                   
END                  
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''               
END              
END          
RETURN @pResult               
END  




'
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetBillSplitDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetBillSplitDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[GetBillSplitDescription]          
(          
 @FinalBillID bigint,          
 @BillingDetailsID bigint,                      
 @pOrgID int          
)          
RETURNS NVARCHAR(MAX)                                              
WITH EXECUTE AS CALLER                                              
AS                                              
BEGIN           
            
 DECLARE @pResult AS NVARCHAR(MAX)              
             
 DECLARE @FeeDescription as Table                    
 ( 
  RowID Bigint,                                      
  FeeDescription nvarchar(Max),          
  Unit nvarchar(100), 
  Quanity nvarchar(100),                   
  Amount nvarchar(100)
 )            
DECLARE @intFlag INT                      
 DECLARE @pCount AS INT                     
 DECLARE @pTempData AS NVARCHAR(MAX)             
 DECLARE @pTable AS NVARCHAR(MAX)             
 DECLARE @pTableRow AS NVARCHAR(MAX)             
 SET @intFlag = 1 
 
  INSERT INTO @FeeDescription                
     Select ROW_NUMBER() OVER(ORDER BY BDS.BillingDetailsFeeSplitID) AS RowID, BDS.FeeDescription,CONVERT(nvarchar,ISNULL(BDS.Amount,1)) as UnitPrice,
     CONVERT(nvarchar,ISNULL(BD.Quantity,1)) as Quanity,CONVERT(nvarchar,(ISNULL(BD.Quantity,1) * BDS.Amount)) AS Amount            
     FROM  BillingDetails BD                 
     INNER JOIN BillingDetailsFeeSplit BDS ON BD.BillingDetailsID=BDS.BillingDetailsID    
     WHERE BDS.FinalBillID=@FinalBillID AND BDS.BillingDetailsID =@BillingDetailsID 
     AND BD.OrgID=@pOrgID  
            
          
  SELECT @pCount = COUNT(*) from @FeeDescription          
  
        
  IF(@pCount>0)                
  BEGIN              
   SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''                   
   SET @pTempData=''''            
   SET @pTableRow = ''<tr> <th> Description </th> <th> UnitPrice </td> <th> Quanity </th><th> Amount</th> </tr>''              
  BEGIN                
   WHILE (@intFlag <= @pCount)                      
    BEGIN            
    SELECT @pTempData = @pTempData + ''<tr> <td> ''+ FeeDescription +''</td> <td align="right"> ''+ Unit +''</td><td> ''+ Quanity +''</td> <td>''+ Amount +''</td></tr>''            
    from @FeeDescription Where RowID=@intFlag                      
    SET @intFlag = @intFlag + 1                      
   END                 
  END                
   SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''             
  END            
      
       
  RETURN @pResult             
            
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetClaimfromTPA]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetClaimfromTPA]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE  FUNCTION [dbo].[GetClaimfromTPA] -- 25432,''TPAGB''                                       
(                                    
 @pVisitID bigint,                                         
 @pAmountType nvarchar(10)                                         
)                                         
RETURNS DECIMAL(18,2)             
           
WITH EXECUTE AS CALLER                                                           
AS                                                           
BEGIN                                                           
 DECLARE @pTotalBilledAmount  DECIMAL(18,2);               
            
 DECLARE @GrossBillValue DECIMAL(18,2);              
 DECLARE @PreAuthAmount DECIMAL(18,2);              
 DECLARE @TaxAmount DECIMAL(18,2);               
            
 DECLARE @TPAAmount DECIMAL(18,2)            
 SELECT @TPAAmount = CEILING(TPAAmount) from FinalBill (nolock) WHERE VisitID = @pVisitID            
             
 IF(@pAmountType =''TPAGB'')                                                           
 BEGIN                 
  IF ISNULL(@TPAAmount,0) <= 0            
  BEGIN            
   SELECT @GrossBillValue=GrossBillValue from finalbill (nolock) where VisitID=@pVisitID                
   SELECT @PreAuthAmount=sum(isnull(PreAuthAmount,0)) from VisitClientMapping (nolock) where VisitID=@pVisitID              
   SELECT @TaxAmount=TaxAmount from finalbill (nolock) where VisitID=@pVisitID               
   IF(ISNULL(@PreAuthAmount,0)<ISNULL(@GrossBillValue,0))              
   BEGIN              
    SELECT @pTotalBilledAmount=(ISNULL(@PreAuthAmount,0)+ISNULL(@TaxAmount,0))                  
   END              
   ELSE              
   BEGIN              
    SELECT @pTotalBilledAmount=(ISNULL(@GrossBillValue,0)+ISNULL(@TaxAmount,0))               
   END              
  END            
  ELSE            
  BEGIN            
   SELECT @pTotalBilledAmount = @TPAAmount            
  END             
 END                                                               
             
 RETURN(@pTotalBilledAmount);                       
                                                                
END;    


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetConcatReceiptNo]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetConcatReceiptNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetConcatReceiptNo] (@ID BIGINT)  
RETURNS NVARCHAR(4000)  
AS  
BEGIN  
  
        DECLARE @OutputStr NVARCHAR(4000)  
        SELECT @OutputStr = ISNULL(@OutputStr+ '', '', '''') + CONVERT(NVARCHAR,ReceiptNo)  
        FROM AmountReceivedDetails  
        WHERE FinalBillID = @ID  
        ORDER BY ReceiptNo  
  
        RETURN @OutputStr  
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[getCond]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getCond]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[getCond](      
  @Field nvarchar(500),      
  @Value nvarchar(500),      
  @Code INT,      
  @AndOr INT)      
RETURNS nvarchar(100)      
AS      
BEGIN      
  DECLARE @rVal nvarchar(1000)      
  DECLARE @op1 nvarchar(10)      
  DECLARE @op2 nvarchar(10)      
  SET @rVal = ''''      
  SET @op2 = ''''      
  IF @Value <> ''''      
  BEGIN      
    IF @AndOr = 1 SET @rVal = @rVal + '' And '' ELSE SET @rVal = @rVal + '' Or ''      
    IF @Code = 1 BEGIN SET @op1 = ''='''''' SET @op2 = '''''''' END      
    IF @Code = 2 BEGIN SET @op1 = '' like '''''' SET @op2 = ''%'''''' END      
    IF @Code = 3 BEGIN SET @op1 = '' like ''''%'' SET @op2 = ''%'''''' END      
    IF @Code = 4 SET @op1 = ''=''      
    IF @Code = 5 SET @op1 = ''>''      
    IF @Code = 6 SET @op1 = ''>=''      
    IF @Code = 7 SET @op1 = ''<''      
    IF @Code = 8 SET @op1 = ''<=''      
    IF @Code = 9 BEGIN SET @op1 = ''>'''''' SET @op2 = '''''''' END  
    IF @Code = 10 BEGIN SET @op1 = ''>='''''' SET @op2 = '''''''' END  
    IF @Code = 11 BEGIN SET @op1 = ''<'''''' SET @op2 = '''''''' END  
    IF @Code = 12 BEGIN SET @op1 = ''<='''''' SET @op2 = '''''''' END  
    Set @rVal = @rVal + @Field + @op1 + @Value + @op2      
  END      
  RETURN @rVal      
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetDiscount]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetDiscount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetDiscount] (@FBID bigint)  
RETURNS decimal(18,2)  
WITH EXECUTE AS CALLER  
AS      
BEGIN      
         
     DECLARE @pPatientDiscount  decimal(18,2)        
     SELECT @pPatientDiscount=ISNULL(DiscountAmount,0) FROM FINALBILL (nolock) Where FinalBillID = @FBID                                         
     SELECT @pPatientDiscount = ISNULL(@pPatientDiscount,0)+(SUM(ISNULL(DiscountAmount,0))) from billingdetails  (nolock) where  finalbillid =    @FBID                                 
     RETURN(@pPatientDiscount);      
END;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetExonvalues_fn]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExonvalues_fn]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE function [dbo].[GetExonvalues_fn](@investigationid int,@patientvisitid int)          
returns nvarchar(500)          
as          
begin          
	 declare @value nvarchar(500)          
	 declare @correctvalue nvarchar(100)          
	 declare @Valuesequence table (rowid int,value nvarchar(500))      
	 insert into @Valuesequence (rowid,value)      
	 select Case Value when ''Wild Type'' then 1 when ''Mutant'' then 2 else 3 end,Value        
	 from InvestigationBulkData where InvestigationID =@investigationid       
	       
	 select @correctvalue=Value from InvestigationValues where InvestigationID= @investigationid and PatientVisitID=@patientvisitid           
	 select  @value=COALESCE(@value,'''','' '')+ case when @correctvalue=Value then ''<b>''+'' <u>''+value+''</u></b>''++'' |'' else '' ''+Value +'' |'' end           
	  from @Valuesequence  order by rowid asc       
	 return substring(@value,0,len(@value)-1)          
           
end

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetFeeDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetFeeDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE function [dbo].[GetFeeDescription]
( @CodeTypeID bigint, @pOrgID bigint, @pFeeID bigint, @pFeeType varchar(10),@CodeTypeName varchar(20),@pDescription nvarchar(max)
)
RETURNS NVARCHAR(MAX)                                  
WITH EXECUTE AS CALLER 
as
begin
Declare @rDescription nvarchar(max)
         
  if @CodeTypeName = ''TCODE''
  set @rDescription=@pDescription
  else
           if @pFeeType=''INV''
                SELECT TOP 1  @rDescription=Cm.CodeName + '' : ''+cm.CodeDesc    FROM   CodeMaster Cm WITH(NOLOCK)
                  INNER JOIN CodeMapper Cmap WITH(NOLOCK) ON Cm.CodeMasterID = Cmap.CodeMasterID
				  AND Cmap.IdentifyingID = @pFeeID AND Cm.CodeType = Cmap.IdentifyingType
                 WHERE  CMAP.IdentifyingType = ''investigations'' AND Cm.CodeSchemeID = @CodeTypeID
           else
    --END
	--else
	--begin
					 SELECT TOP 1 @rDescription=Cm.CodeName + '' : ''+cm.CodeDesc 
              FROM   CodeMaster Cm WITH(NOLOCK)
                     INNER JOIN CodeMapper Cmap WITH(NOLOCK)
                             ON Cm.CodeMasterID = Cmap.CodeMasterID
                
				INNER JOIN InvOrgGroup IOG  WITH(NOLOCK)
						ON Cmap.IdentifyingID=IOG.OrgGroupID 
						INNER JOIN InvGroupMaster IGM WITH(NOLOCK) ON
						IOG.AttGroupID=IGM.GroupID AND IGM.Type=@pFeeType
				               
              WHERE IGM.GroupID=@pFeeID AND CMAP.IdentifyingType =@pFeeType
					 AND IOG.OrgID=@pOrgID   and Cm.CodeSchemeID =@CodeTypeID
  --   else
	 --set @rDescription=@pDescription
					-- select * from codemaster where  CodeSchemeID=190 and CodeDesc like ''%sod%''
					-- select * from CodeMapper where codemasterid in (443564,448776,448793,448798)
					-- 448793

					 --insert into codemaster
					 --select ''WP0116'',''Investigations'',	226,''Sodium''

					 --insert into CodeMapper 
					 --select ''investigations'',	45959, 496384
					-- select * from codemaster where codename=''WP0116''



return (@rDescription);
end

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetINVIPRate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetINVIPRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetINVIPRate] (@ID bigint,@ClientID bigint,@type nchar(3),@OrgID int)  
RETURNS decimal(18,2)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
     DECLARE @rate decimal(18,2)  
     
     SELECT  @rate=RM.IPAmount FROM InvRateMaster RM  
     where RM.RateID = @ClientID AND RM.ID =(select OrgGroupID from InvOrgGroup where AttGroupID=@ID and OrgID=@OrgID )    
     and  RM.Type = @type  
     SET @rate = ISNULL(@rate,0)  
     RETURN(@rate);  
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetINVRate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetINVRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetINVRate] (@ID bigint,@ClientID bigint,@type nchar(3),@OrgID int)
RETURNS decimal(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @rate decimal(18,2)
     SELECT  @rate=RM.Rate FROM InvRateMaster RM
     where RM.RateID = @ClientID AND RM.ID =(select OrgGroupID from InvOrgGroup where AttGroupID=@ID and OrgID=@OrgID )  
     and  RM.Type = @type
     SET @rate = ISNULL(@rate,0)
     RETURN(@rate);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetIPBalance]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPBalance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetIPBalance]                                          
(                                    
 @pVisitID bigint,                                         
 @pAmountType nvarchar(15)                                         
)                                         
RETURNS DECIMAL(18,2)                                                           
WITH EXECUTE AS CALLER                                                           
AS                                                 
BEGIN                                                           
  DECLARE @pBalance decimal(18,2);                                                           
  SET @pBalance =0;                                                           
                                                       
  DECLARE @pTotalAdvance DECIMAL(18,2);                                                           
  DECLARE @pTotalSurgeryAdvance DECIMAL(18,2);                                                           
  DECLARE @pTotalReceived DECIMAL(18,2);                                                           
  DECLARE @pTotalDue DECIMAL(18,2);                                                           
  DECLARE @pPreviousRefund DECIMAL(18,2);                                                           
  DECLARE @pTotalSurgeryAmount DECIMAL(18,2);                                                           
  DECLARE @pPatientID  BIGINT;                                                           
  DECLARE @pTotalBilledAmount  DECIMAL(18,2);                                                           
  DECLARE @pServiceCharge AS DECIMAL(18,2);                                                           
  DECLARE @orgID INT;                                                           
  DECLARE @pFinalBillID AS BIGINT;                                                     
  DECLARE @pDiscount  DECIMAL(18,2);                                                         
   DECLARE @pPatientDiscount   DECIMAL(18,2)=0;                                                    
  DECLARE @pRateID bigint;                                      
  DECLARE @pRoundOFF  DECIMAL(18,2);      
  DECLARE @pISSurgeryPatient nvarchar(10);       
  DECLARE @ClientID Bigint;                              
  DECLARE @pPharmacyAmountReceived DECIMAL(18,2)                  
  DECLARE @pPharmacyAmountRefund DECIMAL(18,2)            
  DECLARE @pHospitalAmountReceived DECIMAL(18,2)                  
  DECLARE @pHospitalAmountRefund DECIMAL(18,2)                                  
        
 /* Mirror Tables (@Table) for holding the BillingDetails and PatientDueChart */        
 DECLARE @BillingDetails_Mirror TABLE              
 (              
 BillingDetailsID Bigint PRIMARY KEY, FinalBillID Bigint, FeeId Bigint,FeeType NVarchar(100), FeeDescription NVarchar(MAX), Amount Decimal (18, 2),              
 Quantity Decimal (18, 2),Rate Decimal (18, 2), CreatedAt Datetime, DiscountAmount Decimal (18, 2), BilledDate Datetime, BatchNo nvarchar(50),        
 Status nvarchar(10),RateID BIGINT        
 )             
 DECLARE @PatientDueChart_Mirror TABLE              
 (              
 DetailsID Bigint PRIMARY KEY,VisitID Bigint,PatientID Bigint,FeeType nvarchar(10),FeeID Bigint,Description nvarchar(255), Status nvarchar(15),            
 unit Numeric (18, 2),CreatedAt Datetime,Amount Decimal (18, 2), DiscountAmount Decimal (18, 2), BatchNo nvarchar(50) ,RateID bigint            
 )               
               
 SELECT @pPatientID = PatientID,@orgID= OrgID,@pISSurgeryPatient=ISNULL(IsSurgeryPatient,''N'') FROM PatientVisit WHERE PatientVisitId = @pVisitID                                                             
 SELECT @pFinalBillID = MAX(FinalBillID) FROM FINALBILL Where VisitID = @pVisitID                                   
 SELECT @pPatientDiscount=ISNULL(DiscountAmount,0),@pRoundOFF= ISNULL(roundoff,0)  FROM FINALBILL Where FinalBillID = @pFinalBillID        
 
 SELECT @pRateID=RateID,@ClientID=ISNULL(s.ClientID,0) FROM VisitClientMapping s left join BedBooking b on b.VisitID=s.VisitID  Where FinalBillID = @pFinalBillID        
         
 /* Mirror tables are populated here for the passed visitID */        
 INSERT @BillingDetails_Mirror              
 SELECT BillingDetailsID, BD.FinalBillID, FeeId, FeeType, FeeDescription, Amount, Quantity, Rate, BD.CreatedAt, BD.DiscountAmount,
  BilledDate, BatchNo, Status,RateID        
 FROM BillingDetails BD (Nolock)          
 WHERE FinalBillID = @pFinalBillID  and OrgID=@orgID      
         
 INSERT @PatientDueChart_Mirror              
 SELECT               
 DetailsID, PDC.VisitID, PDC.PatientID, FeeType, FeeID, Description, PDC.Status, unit, PDC.CreatedAt, Amount, PDC.DiscountAmount, BatchNo,RateID            
 FROM PatientDueChart PDC (Nolock)        
 WHERE PDC.VisitID = @pVisitID        and OrgID=@orgID
 AND PDC.PatientID = @pPatientID        
           
 SELECT @pPatientDiscount = ISNULL(@pPatientDiscount,0)+(SUM(ISNULL(DiscountAmount,0))) FROM @BillingDetails_Mirror where  finalbillid =    @pFinalBillID                                                 
 SELECT @pTotalAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') <>''SOI''                                                                                                   
 SELECT @pTotalSurgeryAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') = ''SOI''                                                                                             
 SELECT @pTotalReceived = ISNULL(SUM(AmountReceived),0) FROM IPIntermediatePayments WHERE VisitID=@pVisitID                                                                                                           
 SELECT @pTotalDue = ISNULL(SUM(FB.Due),0) FROM FinalBill FB INNER JOIN PatientVisit PV ON                                                                                                           
 FB.VisitID = PV.PatientVisitId WHERE PV.PatientID = @pPatientID  AND VisitID <>@pVisitID                
        
 SELECT @pPreviousRefund = ISNULL(SUM(AmountRefund),0) FROM FinalBill WHERE VisitID=@pVisitID                                                                          
 SELECT @pTotalSurgeryAmount  = ISNULL(SUM(PD.Amount),0) FROM @PatientDueChart_Mirror PD                                                 
 INNER JOIN SurgeryBillingMaster SB ON SB.SurgeryBillingID = PD.FeeID AND PD.FeeType =''SOI''                                                                                            
 WHERE VisitID = @pVisitID AND ISNULL(SB.IsCreditBill,''N'') = ''N''                                 
        
 SELECT @pServiceCharge = ISNULL(ServiceCharge,0) from IPIntermediatePayments Where VisitID = @pVisitID                                                                   
 AND PaymentDetailsID = (SELECT MAX(PaymentDetailsID) FROM IPIntermediatePayments WHERE VisitID = @pVisitID)                                                       
        
 ---Discount amount                                                        
        
         
 SELECT @pPharmacyAmountRefund = ISNULL(SUM(AmtRefund),0) from AmountRefundDetails Where FinalBillID=@pFinalBillID AND CreatedBy in                                                
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName=''Inventory'')                                      
        
        
 SELECT @pPharmacyAmountReceived = SUM(AmtReceived) - ISNULL(@pPharmacyAmountRefund,0) from AmountReceivedDetails Where FinalBillID=@pFinalBillID AND ReceivedBy in                                                
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName=''Inventory'')                                      
        
        
 SELECT @pHospitalAmountRefund = ISNULL(SUM(AmtRefund),0) from AmountRefundDetails Where FinalBillID=@pFinalBillID AND CreatedBy in                                                
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName not in(''Inventory''))                                      
        
        
 SELECT @pHospitalAmountReceived = SUM(AmtReceived) - ISNULL(@pHospitalAmountRefund,0) from AmountReceivedDetails Where FinalBillID=@pFinalBillID AND                   
 ReceivedBy in                                                
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName not in(''Inventory''))                  
        
 DECLARE @pTempAmount AS TABLE                                       
 (DetailsID BIGINT NULL,Amount Decimal(18,2) NULL)                       
        
 INSERT INTO @pTempAmount                                        
 Select ISNULL(PD1.DetailsID,0) AS DetailsID,                                                                                                                                               
 CASE WHEN PD1.Amount =0 THEN (                                                                                                               
 CASE                                                                                                                                                
 WHEN (PD1.FeeType =''INV'' ) THEN                                                        
 (Select ISNULL(IPAmount,0) from InvRateMaster IRM,FinalBill FB Where ID=FeeID AND IRM.Type =''INV''                                                                            
 AND IRM.rateID = PD1.RateID AND FB.OrgID =@orgID AND FB.VisitID = @pVisitID )                                                                                                         
 WHEN (PD1.FeeType =''GRP'' ) THEN                                                                                                                                          
 (Select ISNULL(IPAmount,0) from InvRateMaster IRM,InvOrgGroup IVG,FinalBill FB     
 Where IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                                                                                                            
 AND IRM.RateID = PD1.RateID AND IVG.OrgID =@orgID  AND FB.OrgID = @orgID                                       
 AND FB.VisitID = @pVisitID )                                                                              
 WHEN (PD1.FeeType =''CON'' ) THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID =FeeID )                                                                                             
 WHEN (FeeType =''PRO'' ) THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID =FeeID )                       
 WHEN (FeeType =''IND'' ) THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =FeeID )                                                                                              
 WHEN FeeType =''OTH'' THEN 0                                                                                                                                               
 END                                                                  
 )                                                                                                                                               
 WHEN PD1.Amount !=0 THEN Amount                                                                                                       
 END  *                                                                                                                                     
 ISNULL(PD1.Unit,1) AS Amount                                         
 from @PatientDueChart_Mirror PD1 Where PD1.VisitID=@pVisitID                                                                                                   
 AND PD1.Status not in(''Paid'',''Deleted'')                    
        
 --UNION                                                                           
 INSERT INTO @pTempAmount        
 SELECT ISNULL(BD.BillingDetailsID,0)AS DetailsID,                                                         
 CASE                                                                                        
 WHEN BD.Amount = 0 THEN                                                                                                                
 CASE                                                                                                                                             
 WHEN BD.FeeType =''INV'' THEN                                                                      
 (SELECT ISNULL(rate,0) FROM InvRateMaster IRM,PatientVisit PV                                                                            
 WHERE RateTypeID=BD.FeeID AND IRM.Type =''INV'' AND IRM.RateID = BD.RateID                                                                            
 AND PV.OrgID =@orgID AND PV.PatientVisitId = @pVisitID )                                                           
 WHEN BD.FeeType =''GRP'' THEN                                                                                                                  
 (SELECT ISNULL(rate,0) from InvRateMaster IRM,InvOrgGroup IVG,FinalBill FB                                                                                                                            
 WHERE IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                                          
 AND IRM.RateID = BD.RateID AND IVG.OrgID =@orgID AND FB.OrgID = @orgID                                                                                                                            
 AND FB.VisitID = @pVisitID)                                                                                                                            
 WHEN BD.FeeType =''CON'' THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID =BD.FeeId )                                                                                                                                                
 WHEN BD.FeeType =''PRO'' THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID =BD.FeeId )                                                                      
 WHEN BD.FeeType =''IND'' THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =BD.FeeId )                                                                                                                                     
 ELSE BD.Amount                                                                                                
 END ELSE BD.Amount                                                                                                                                     
 END *       
 --BD.Amount,      
 ISNULL(BD.Quantity,1) AS Unit                                       
 FROM @BillingDetails_Mirror BD INNER JOIN FinalBill FB ON FB.FinalBillID = BD.FinalBillID                                                                                   
 WHERE FB.VisitID = @pVisitID  AND BD.Status <>''Deleted''  AND BD.FeeID not in(-3,-4)      and OrgID=@orgID                                 
 --and  BD.FeeType <> ''rom''                                       
 --AND (BD.Status =''Ordered'' OR BD.Status =''Paid'' BD.Status =''Ordered'' )-- AND BD.FeeType!=''ROM''                                                                                                                 
        
 --UNION                                                                                                          
 INSERT INTO @pTempAmount        
 SELECT 0,Amount                                             
 FROM  registrationfeedetails                                                              
 WHERE patientID = @pPatientID AND VisitID = @pVisitID AND PaidYN =''N''                                                                                                             
        
 --UNION       
  IF(@pISSurgeryPatient!=''Y'')      
  BEGIN                                                                                                          
   INSERT INTO @pTempAmount        
   SELECT  BB.BookingID  AS DetailsID,                                                                                    
   (      
   CASE             
   when CFRC.DiscOrEnhanceType=''DISC'' Then             
   (Case            
    when CFRC.Applyby=''Value'' Then RTFM.Amount-CFRC.DiscOrEnhancePercent            
    when CFRC.Applyby=''Percent'' Then RTFM.Amount-(CFRC.DiscOrEnhancePercent*RTFM.Amount/100)            
    Else RTFM.Amount End            
   )            
   when CFRC.DiscOrEnhanceType=''ENHANCE'' Then             
   (Case            
    when CFRC.Applyby=''Value'' Then RTFM.Amount+CFRC.DiscOrEnhancePercent       
    when CFRC.Applyby=''Percent'' Then RTFM.Amount+(CFRC.DiscOrEnhancePercent*RTFM.Amount/100)            
    Else RTFM.Amount End            
   )            
   Else RTFM.Amount END) *(                                                                                             
   CASE                                          
   WHEN(ISNULL(RTFM.ISVariable,''N'') =''Y'')                                                          
   THEN (ISNULL(dbo.fn_getHalfDayDateDiff(BB.FromDate,                                         
   CASE                                          
   WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                           
   ELSE BB.ToDate                                           
   END),0.5))                                                                                     
   ELSE (CONVERT(decimal(18,2),ISNULL(dbo.fn_getFullDayDateDiff(BB.FromDate,                                         
   CASE                                          
   WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                                                                                                      
   ELSE BB.ToDate                                           
   END),1)))                                                          
   END ) AS Amount                                              
   FROM BedBooking BB INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                                                                         
   INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                                     
   INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                       
   INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID AND RateID = @pRateID                                                                                   
   INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID       
   LEFT JOIN ClientFeeTypeRateCustomization CFRC ON CFRC.RoomTypeID=RT.RoomTypeID             
   And CFRC.ClientID=@ClientID AND CFRC.FeeType=''ROM''                                                                                                                                                                                                         
  
     
                                                               
   WHERE BB.VisitID =@pVisitID                                          
   AND BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )                                                                                        
   AND BB.BookingID  NOT IN                          
   (Select Feeid from @PatientDueChart_Mirror where VisitID=@pVisitID AND FeeType=''ROM'' UNION                                                                        
   Select Feeid from @BillingDetails_Mirror where FinalBillID=@pFinalBillID)      
  END                       
        
 DECLARE @pTotal AS DECIMAL(18,2)                                                            
 SELECT @pTotal = SUM(Amount) FROM @pTempAmount                                                           
 IF(@pAmountType =''GROSS'')                                           
 BEGIN                                                 
 --SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)),0)                                       
  SELECT @pTotalBilledAmount =   ISNULL(@pTotal,0)                                       
 END                                                             
 ELSE IF((@pAmountType =''TPA'' OR @pAmountType =''TPAGB'') )                                    
 BEGIN                                        
  SET @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)),0)--+ISNULL(@pTotalDue,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0)),0)                                                       
  if (@pTotalBilledAmount>0)                                     
  begin                                                     
  SELECT @pTotalBilledAmount=@pTotalBilledAmount--ISNULL((@pDiscount/100*@pTotalBilledAmount),0)                                                     
  end                                                     
 END                                                        
 ELSE  IF((@pAmountType =''TPA'' OR @pAmountType =''TPAGB'')  )                                                           
 BEGIN                                                      
  SET @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)),0)--+ISNULL(@pTotalDue,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0)),0)                                               
  if (@pTotalBilledAmount>0)                                                     
  begin                                                     
   SELECT @pTotalBilledAmount=@pTotalBilledAmount--ISNULL(@pDiscount,0)                                                     
  end                                                     
 END                                                      
 ELSE  IF((@pAmountType =''TPA'' OR @pAmountType =''TPAGB'') )                                                           
 BEGIN                                   
  SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)),0)--+ISNULL(@pTotalDue,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0)),0)                                                          
  if (@pTotalBilledAmount>0)                                                     
  begin                                                     
   SELECT @pTotalBilledAmount=@pTotalBilledAmount--ISNULL(@pDiscount,0)                                                     
  end                             
 END                                                        
 ELSE  IF(@pAmountType =''NET'')                                                           
 BEGIN                                                           
  SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)-ISNULL(@pPatientDiscount,0)),0)                      
 END                                                           
 ELSE  IF(@pAmountType =''DUE'')                     
 BEGIN                                                           
  SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0))-ISNULL(@pPatientDiscount,0),0)                      
 END                                       
 ELSE  IF(@pAmountType =''RECEIVED'')                                                           
 BEGIN                                                           
  SELECT @pTotalBilledAmount = ISNULL( ISNULL(@pTotalAdvance,0)+ISNULL(@pTotalSurgeryAdvance,0)+ISNULL(@pTotalReceived,0),0)                                                           
 END                                       
        
 SELECT @pTotalBilledAmount =(CASE WHEN @pTotalBilledAmount>0 THEN @pTotalBilledAmount ELSE 0 END)                                                           
        
        
 IF(@pAmountType =''TPA'')                                   
 BEGIN                                   
  SELECT @pTotalBilledAmount = @pTotalBilledAmount - (ISNULL(@pPatientDiscount,0) + isNull(@pTotalReceived,0) + isNull(@pTotalAdvance,0))                            
  SELECT @pTotalBilledAmount = @pTotalBilledAmount - (isNull(SUM(Amount),0)+ ISNULL(SUM(TDS),0))                            
  FROM TPAPayments                                    
  WHERE FinalBillID=@pFinalBillID                                    
  GROUP BY FinalBillID               
 END                            
        
 IF(@pAmountType =''TPAGB'')                                       
 BEGIN                                         SELECT @pTotalBilledAmount = @pTotalBilledAmount                           
 END                                    
        
 IF (@pAmountType = ''PRM'')                  
 BEGIN                  
  SELECT @pTotalBilledAmount = SUM(Amount * Quantity) from @BillingDetails_Mirror WHERE FinalBillID = @pFinalBillID and FeeType = ''PRM'' and FeeId not in(-3) and Status not in (''Deleted'')                  
  SELECT @pTotalBilledAmount = ISNULL(@pTotalBilledAmount,0) + ISNULL(SUM(Amount * UNIT),0) from @PatientDueChart_Mirror WHERE VisitID = @pVisitID and FeeType = ''PRM'' and Status not in (''Paid'',''Deleted'')                  
 END                  
 IF (@pAmountType = ''HOS'')                  
 BEGIN                  
  SELECT @pTotalBilledAmount = SUM(Amount * Quantity) from @BillingDetails_Mirror WHERE FinalBillID = @pFinalBillID and FeeType not in(''PRM'') and FeeId not in(-2,-3,-4) and Status not in (''Deleted'')                  
  SELECT @pTotalBilledAmount = ISNULL(@pTotalBilledAmount,0) + ISNULL(SUM(Amount * UNIT),0) from @PatientDueChart_Mirror WHERE VisitID = @pVisitID and FeeType not in(''PRM'') and Status not in (''Paid'',''Deleted'')                  
 END                      
 IF (@pAmountType = ''PRMRECEIVED'')                  
 BEGIN                  
  SELECT @pTotalBilledAmount = ISNULL(@pPharmacyAmountReceived,0)                  
 END                  
 IF (@pAmountType = ''HOSRECEIVED'')                  
 BEGIN                  
  SELECT @pTotalBilledAmount = ISNULL(@pHospitalAmountReceived,0)                  
 END                      
 IF (@pAmountType = ''PRMREFUND'')                  
 BEGIN                  
  SELECT @pTotalBilledAmount = ISNULL(@pPharmacyAmountRefund,0)                  
 END                  
 IF (@pAmountType = ''HOSREFUND'')                  
 BEGIN                  
  SELECT @pTotalBilledAmount = ISNULL(@pHospitalAmountRefund,0)                  
 END                      
        
 RETURN(@pTotalBilledAmount);                                                           
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetIPBalanceAll]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPBalanceAll]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'/*---------------------------------------------------------------------------------------------------------------------------------  
File Header Comments                 
=======================================================================================                
 Copyright (C) 2007-2012 Attune Technologies, Adyar, Chennai                
========================================================================================                
 Purpose: Function to get the All Balance (due) for IP Patient  
 Author: <CODER NAME>                
 Date Created: <DATE>                
========================================================================================                
 File Change History (to be updated everytime this file is modified)                
 ---------------------------------------------------------------------------------------                
Date: 23-Apr-2012  
Author: Subramaniyan S  
Fix: Performance improvement.   
  1. This function is an enhancement of GetIPBalance Function.Based on VisitId,it returns balance amounts (Gross,Net,Due,Received etc)
	 as table value. 
  2. Better performance achieved since single call of the function gives balance amounts of all amount types.In pSaveIPFinalBill and pUpdateIPFinalBill
	 Multiple calls to the GetIPBalance is changed to single call of GetIPBalanceAll
       
----------------------------------------------------------------------------------------------------------------------------------- */   
CREATE FUNCTION [dbo].[GetIPBalanceAll]                                      
(                                
 @pVisitID bigint                                    
)     
Returns @Balancetemp Table(
amounttype  nvarchar(25),
amount   decimal(18,2)
)

AS                                                       
BEGIN                                                       
  DECLARE @pBalance decimal(18,2);                                                       
  SET @pBalance =0;                                                       
                                                   
  DECLARE @pTotalAdvance DECIMAL(18,2);                                                       
  DECLARE @pTotalSurgeryAdvance DECIMAL(18,2);                                                       
  DECLARE @pTotalReceived DECIMAL(18,2);                                                       
  DECLARE @pTotalDue DECIMAL(18,2);                                                       
  DECLARE @pPreviousRefund DECIMAL(18,2);                                                       
  DECLARE @pTotalSurgeryAmount DECIMAL(18,2);                                                       
  DECLARE @pPatientID  BIGINT;                                                       
  DECLARE @pTotalBilledAmount  DECIMAL(18,2);                                                       
  DECLARE @pServiceCharge AS DECIMAL(18,2);                                                       
  DECLARE @orgID INT;                                                       
  DECLARE @pFinalBillID AS BIGINT;                                                 
  DECLARE @pDiscount  DECIMAL(18,2);                                                     
  DECLARE @pDiscountType  nvarchar(255);                             
  DECLARE @pPatientDiscount   DECIMAL(18,2)=0;                                                
  DECLARE @pRateID bigint;                                  
  DECLARE @pRoundOFF  DECIMAL(18,2);  
  DECLARE @pISSurgeryPatient nvarchar(10);   
  DECLARE @ClientID Bigint;                          
  DECLARE @pPharmacyAmountReceived DECIMAL(18,2)              
DECLARE @pPharmacyAmountRefund DECIMAL(18,2)                              
  DECLARE @pHospitalAmountReceived DECIMAL(18,2)              
  DECLARE @pHospitalAmountRefund DECIMAL(18,2)                              
    
 /* Mirror Tables (@Table) for holding the BillingDetails and PatientDueChart */    
 DECLARE @BillingDetails_Mirror TABLE          
 (          
 BillingDetailsID Bigint PRIMARY KEY, FinalBillID Bigint, FeeId Bigint,FeeType NVarchar(100), FeeDescription NVarchar(MAX), Amount Decimal (18, 2),          
 Quantity Decimal (18, 2),Rate Decimal (18, 2), CreatedAt Datetime, DiscountAmount Decimal (18, 2), BilledDate Datetime, BatchNo nvarchar(50),    
 Status nvarchar(10),RateID BIGINT   
 )         
 DECLARE @PatientDueChart_Mirror TABLE          
 (          
 DetailsID Bigint PRIMARY KEY,VisitID Bigint,PatientID Bigint,FeeType nvarchar(10),FeeID Bigint,Description nvarchar(255), Status nvarchar(15),        
 unit Numeric (18, 2),CreatedAt Datetime,Amount Decimal (18, 2), DiscountAmount Decimal (18, 2), BatchNo nvarchar(50) ,RateID BIGINT        
 )           
           
 SELECT @pPatientID = PatientID,@orgID= OrgID,@pISSurgeryPatient=ISNULL(IsSurgeryPatient,''N'') FROM PatientVisit WHERE PatientVisitId = @pVisitID                                                         
 SELECT @pFinalBillID = MAX(FinalBillID) FROM FINALBILL Where VisitID = @pVisitID                               
 SELECT @pPatientDiscount=ISNULL(DiscountAmount,0),@pRoundOFF= ISNULL(roundoff,0) FROM FINALBILL Where FinalBillID = @pFinalBillID    
 
 
     
 /* Mirror tables are populated here for the passed visitID */    
 INSERT @BillingDetails_Mirror          
 SELECT BillingDetailsID, BD.FinalBillID, FeeId, FeeType, FeeDescription, Amount, Quantity, Rate, BD.CreatedAt, BD.DiscountAmount,
  BilledDate, BatchNo, Status ,RateID   
 FROM BillingDetails BD (Nolock)      
 WHERE FinalBillID = @pFinalBillID    
     
 INSERT @PatientDueChart_Mirror          
 SELECT           
 DetailsID, PDC.VisitID, PDC.PatientID, FeeType, FeeID, Description, PDC.Status, unit, PDC.CreatedAt, Amount, 
 PDC.DiscountAmount, BatchNo,RateID        
 FROM PatientDueChart PDC (Nolock)    
 WHERE PDC.VisitID = @pVisitID    
 AND PDC.PatientID = @pPatientID    
       
 SELECT @pPatientDiscount = ISNULL(@pPatientDiscount,0)+(SUM(ISNULL(DiscountAmount,0))) FROM @BillingDetails_Mirror where  finalbillid =    @pFinalBillID                                             
 SELECT @pTotalAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') <>''SOI''                                                                                               
 SELECT @pTotalSurgeryAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') = ''SOI''                                                                                         
 SELECT @pTotalReceived = ISNULL(SUM(AmountReceived),0) FROM IPIntermediatePayments WHERE VisitID=@pVisitID                                                                                                       
 SELECT @pTotalDue = ISNULL(SUM(FB.Due),0) FROM FinalBill FB INNER JOIN PatientVisit PV ON                                                                                                       
 FB.VisitID = PV.PatientVisitId WHERE PV.PatientID = @pPatientID  AND VisitID <>@pVisitID            
    
 SELECT @pPreviousRefund = ISNULL(SUM(AmountRefund),0) FROM FinalBill WHERE VisitID=@pVisitID                                                                      
 SELECT @pTotalSurgeryAmount  = ISNULL(SUM(PD.Amount),0) FROM @PatientDueChart_Mirror PD                                             
 INNER JOIN SurgeryBillingMaster SB ON SB.SurgeryBillingID = PD.FeeID AND PD.FeeType =''SOI''                                                                                        
 WHERE VisitID = @pVisitID AND ISNULL(SB.IsCreditBill,''N'') = ''N''                             
    
 SELECT @pServiceCharge = ISNULL(ServiceCharge,0) from IPIntermediatePayments Where VisitID = @pVisitID                                                               
 AND PaymentDetailsID = (SELECT MAX(PaymentDetailsID) FROM IPIntermediatePayments WHERE VisitID = @pVisitID)                                                   
    
 ---Discount amount                                                    
    
 --SELECT @pDiscountType=DiscountType,@pDiscount=Discount FROM RateMaster WHERE  orgid=@orgID  and RateId=@pRateID               
    
 SELECT @pPharmacyAmountRefund = ISNULL(SUM(AmtRefund),0) from AmountRefundDetails Where FinalBillID=@pFinalBillID AND CreatedBy in                                            
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName=''Inventory'')                                  
    
    
 SELECT @pPharmacyAmountReceived = SUM(AmtReceived) - ISNULL(@pPharmacyAmountRefund,0) from AmountReceivedDetails Where FinalBillID=@pFinalBillID AND ReceivedBy in                                            
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName=''Inventory'')                                  
    
    
 SELECT @pHospitalAmountRefund = ISNULL(SUM(AmtRefund),0) from AmountRefundDetails Where FinalBillID=@pFinalBillID AND CreatedBy in                                            
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName not in(''Inventory''))                                  
    
    
 SELECT @pHospitalAmountReceived = SUM(AmtReceived) - ISNULL(@pHospitalAmountRefund,0) from AmountReceivedDetails Where FinalBillID=@pFinalBillID AND               
 ReceivedBy in                                            
 (SELECT LoginID from LoginRole LR INNER JOIN Role R ON LR.RoleID=R.RoleID AND R.RoleName not in(''Inventory''))              
    
 DECLARE @pTempAmount AS TABLE                                   
 (DetailsID BIGINT NULL,Amount Decimal(18,2) NULL)                                                       
    
 INSERT INTO @pTempAmount                                    
 Select ISNULL(PD1.DetailsID,0) AS DetailsID,                                                                                                                                           
 CASE WHEN PD1.Amount =0 THEN (                                                                                                           
 CASE                                                                                                                                            
 WHEN (PD1.FeeType =''INV'' ) THEN                                                    
 (Select ISNULL(IPAmount,0) from InvRateMaster IRM  Where ID=FeeID AND IRM.Type =''INV''                                                                        
 AND IRM.rateID = PD1.RateID  )                                                                                                     
 WHEN (PD1.FeeType =''GRP'' ) THEN                                                                                                                                      
 (Select ISNULL(IPAmount,0) from InvRateMaster IRM,InvOrgGroup IVG                                                                                                                       
  Where IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                                                                                                        
 AND IRM.RateID = PD1.RateID AND IVG.OrgID =@orgID                                     
   )                                                                          
 WHEN (PD1.FeeType =''CON'' ) THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID =FeeID )                                                                                         
 WHEN (FeeType =''PRO'' ) THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID =FeeID )                                                                                                                                      
 WHEN (FeeType =''IND'' ) THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =FeeID )                                                                                          
 WHEN FeeType =''OTH'' THEN 0                                                                                                                                           
 END                                                              
 )                                                                                                                                           
 WHEN PD1.Amount !=0 THEN Amount                                                                                                   
 END  *                                                                                                                                 
 ISNULL(PD1.Unit,1) AS Amount                                     
 from @PatientDueChart_Mirror PD1 INNER JOIN FinalBill FB on FB.VisitID =PD1.VisitID and FB.PatientID =PD1.PatientID Where PD1.VisitID=@pVisitID 
                                                                                               
 AND PD1.Status not in(''Paid'',''Deleted'')                
    
 --UNION                                                                       
 INSERT INTO @pTempAmount    
 SELECT ISNULL(BD.BillingDetailsID,0)AS DetailsID,                                                     
 CASE                                                                                    
 WHEN BD.Amount = 0 THEN                                                                                                            
 CASE                                                                                                                                         
 WHEN BD.FeeType =''INV'' THEN                                                                  
 (SELECT ISNULL(rate,0) FROM InvRateMaster IRM                                                                        
 WHERE RateTypeID=BD.FeeID AND IRM.Type =''INV'' AND IRM.RateID = BD.RateID                                                                        
   )                                                       
 WHEN BD.FeeType =''GRP'' THEN                                                                                                              
 (SELECT ISNULL(rate,0) from InvRateMaster IRM,InvOrgGroup IVG                                                                                                                       
 WHERE IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                                      
 AND IRM.RateID = BD.RateID AND IVG.OrgID =@orgID                                                                                                                        
  )                                                                                                                        
 WHEN BD.FeeType =''CON'' THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID =BD.FeeId )                                                                                                                                            
 WHEN BD.FeeType =''PRO'' THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID =BD.FeeId )                                                                  
 WHEN BD.FeeType =''IND'' THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =BD.FeeId )                                                                                                                                 
 ELSE BD.Amount                                                                                            
 END ELSE BD.Amount                                                            
 END *                                                                                          
 --BD.Amount,                  
 ISNULL(BD.Quantity,1) AS Unit                                   
 FROM @BillingDetails_Mirror BD INNER JOIN FinalBill FB ON FB.FinalBillID = BD.FinalBillID                                                                               
 WHERE FB.VisitID = @pVisitID  AND BD.Status <>''Deleted''  AND BD.FeeID not in(-3,-4)                                   
 --and  BD.FeeType <> ''rom''                                   
 --AND (BD.Status =''Ordered'' OR BD.Status =''Paid'' BD.Status =''Ordered'' )-- AND BD.FeeType!=''ROM''                                                                                                             
    
 --UNION                                                                                                      
 INSERT INTO @pTempAmount    
 SELECT 0,Amount                                         
 FROM  registrationfeedetails                                                          
 WHERE patientID = @pPatientID AND VisitID = @pVisitID AND PaidYN =''N''                                                                                                         
    
 --UNION   
  IF(@pISSurgeryPatient!=''Y'')  
  BEGIN                                                                                                      
   INSERT INTO @pTempAmount    
   SELECT  BB.BookingID  AS DetailsID,                                                                                
   (  
   CASE         
   when CFRC.DiscOrEnhanceType=''DISC'' Then         
   (Case        
    when CFRC.Applyby=''Value'' Then RTFM.Amount-CFRC.DiscOrEnhancePercent        
    when CFRC.Applyby=''Percent'' Then RTFM.Amount-(CFRC.DiscOrEnhancePercent*RTFM.Amount/100)        
    Else RTFM.Amount End        
   )        
   when CFRC.DiscOrEnhanceType=''ENHANCE'' Then         
   (Case        
    when CFRC.Applyby=''Value'' Then RTFM.Amount+CFRC.DiscOrEnhancePercent        
    when CFRC.Applyby=''Percent'' Then RTFM.Amount+(CFRC.DiscOrEnhancePercent*RTFM.Amount/100)        
    Else RTFM.Amount End        
   )        
   Else RTFM.Amount END) *(                                                                                         
   CASE                                      
   WHEN(ISNULL(RTFM.ISVariable,''N'') =''Y'')                                                      
   THEN (ISNULL(dbo.fn_getHalfDayDateDiff(BB.FromDate,                                     
   CASE                                      
   WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                       
   ELSE BB.ToDate                                       
   END),0.5))                                                                                 
   ELSE (CONVERT(decimal(18,2),ISNULL(dbo.fn_getFullDayDateDiff(BB.FromDate,                                     
   CASE                                      
   WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                                                                                                  
   ELSE BB.ToDate                                       
   END),1)))                                                      
   END ) AS Amount                                          
   FROM BedBooking BB INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                                                                     
   INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                                 
   INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                   
   INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                                           
   INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID   
   LEFT JOIN ClientFeeTypeRateCustomization CFRC ON CFRC.RoomTypeID=RT.RoomTypeID   
   INNER JOIN VisitClientMapping vc on vc.VisitID=bb.VisitID and vc.ClientID =bb.ClientID   AND RTFM.RateID = VC.RateID          
     AND CFRC.FeeType=''ROM''                                                                                                                                                                                                         
                                                                                                 
   WHERE BB.VisitID =@pVisitID                                      
   AND BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )                                                                                    
   AND BB.BookingID  NOT IN                      
   (Select Feeid from @PatientDueChart_Mirror where VisitID=@pVisitID AND FeeType=''ROM'' UNION                                                                    
   Select Feeid from @BillingDetails_Mirror where FinalBillID=@pFinalBillID)  
  END                   
    
 DECLARE @pTotal AS DECIMAL(18,2)                                                        
 SELECT @pTotal = SUM(Amount) FROM @pTempAmount       
 insert into @Balancetemp values(''GROSS'', isnull(@pTotal,0))                               
 insert into @Balancetemp values (''TPAGB'',ISNULL((ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)),0))   
 insert into @Balancetemp values (''NET'',ISNULL((ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)-ISNULL(@pPatientDiscount,0)),0)) 
 insert into @Balancetemp values (''DUE'',ISNULL((ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0))-ISNULL(@pPatientDiscount,0),0))
 insert into @Balancetemp values (''RECEIVED'',ISNULL( ISNULL(@pTotalAdvance,0)+ISNULL(@pTotalSurgeryAdvance,0)+ISNULL(@pTotalReceived,0),0))    
  
    
                      
 BEGIN                               
  SELECT @pTotalBilledAmount =  ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)),0) - (ISNULL(@pPatientDiscount,0) + isNull(@pTotalReceived,0) + isNull(@pTotalAdvance,0))                        
  SELECT @pTotalBilledAmount = @pTotalBilledAmount - (isNull(SUM(Amount),0)+ ISNULL(SUM(TDS),0))                        
  FROM TPAPayments                                
  WHERE FinalBillID=@pFinalBillID                                
  GROUP BY FinalBillID           
 END                        
    
    insert into @Balancetemp values(''TPA'',@pTotalBilledAmount)
                           
    
 BEGIN              
  SELECT @pTotalBilledAmount = SUM(Amount * Quantity) from @BillingDetails_Mirror WHERE FinalBillID = @pFinalBillID and FeeType = ''PRM'' and FeeId not in(-3) and Status not in (''Deleted'')              
  SELECT @pTotalBilledAmount = ISNULL(@pTotalBilledAmount,0) + ISNULL(SUM(Amount * UNIT),0) from @PatientDueChart_Mirror WHERE VisitID = @pVisitID and FeeType = ''PRM'' and Status not in (''Paid'',''Deleted'')              
 END 
 insert into @Balancetemp values (''PRM'', @pTotalBilledAmount)         
 BEGIN              
  SELECT @pTotalBilledAmount = SUM(Amount * Quantity) from @BillingDetails_Mirror WHERE FinalBillID = @pFinalBillID and FeeType not in(''PRM'') and FeeId not in(-2,-3,-4) and Status not in (''Deleted'')              
  SELECT @pTotalBilledAmount = ISNULL(@pTotalBilledAmount,0) + ISNULL(SUM(Amount * UNIT),0) from @PatientDueChart_Mirror WHERE VisitID = @pVisitID and FeeType not in(''PRM'') and Status not in (''Paid'',''Deleted'')              
 END   
 insert into @Balancetemp values (''HOS'', @pTotalBilledAmount)                    
 BEGIN              
  SELECT @pTotalBilledAmount = ISNULL(@pPharmacyAmountReceived,0)              
 END       
  insert into @Balancetemp values (''PRMRECEIVED'', @pTotalBilledAmount)                    
       
 BEGIN              
  SELECT @pTotalBilledAmount = ISNULL(@pHospitalAmountReceived,0)              
 END    
   insert into @Balancetemp values (''HOSRECEIVED'', @pTotalBilledAmount)                    
 BEGIN              
  SELECT @pTotalBilledAmount = ISNULL(@pPharmacyAmountRefund,0)              
 END    
 insert into @Balancetemp values (''PRMREFUND'', @pTotalBilledAmount)                
 BEGIN              
  SELECT @pTotalBilledAmount = ISNULL(@pHospitalAmountRefund,0)              
 END                  
    insert into @Balancetemp values (''HOSREFUND'', @pTotalBilledAmount)                
  
 RETURN;                                                       
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetIPBillAmtByDate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPBillAmtByDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetIPBillAmtByDate] (@pOrgID int, @pFDate DATETIME,@pTDdate DATETIME, @pType nvarchar(10))      
RETURNS   @BillAmtTbl TABLE (    
    FinalBillID BIGINT,     
    VisitID BIGINT,     
    BillDate DATETIME,    
    BillAmt DECIMAL(18,2))    
AS      
BEGIN      
-- Select * from dbo.GetIPBillAmtByDate (12,''28 Mar 2010 00:00:00'',''06 Apr 2010 23:59:59'',''GRS'')    
    
 --Surgery Amount         
 INSERT INTO @BillAmtTbl (FinalBillID, VisitID, BillDate,BillAmt)    
 SELECT FB.FinalBillID, FB.VisitID, Convert(nvarchar,PD.CreatedAt,103), ISNULL(SUM(PD.Amount),0)     
 FROM PatientDueChart PD    
  INNER JOIN FinalBill FB ON PD.VisitID=FB.VisitID    
  INNER JOIN SurgeryBillingMaster SB ON SB.SurgeryBillingID = PD.FeeID AND PD.FeeType =''SOI''    
  INNER JOIN PatientVisit PV ON FB.VisitID = PV.PatientVisitID    
 WHERE PD.CreatedAt BETWEEN @pFDate AND @pTDdate    
  AND FB.OrgID=@pOrgID AND PV.VisitType = 1    
 GROUP BY FB.FinalBillID, FB.VisitID,Convert(nvarchar,PD.CreatedAt,103)    
        
       
 INSERT INTO @BillAmtTbl (FinalBillID, VisitID, BillDate, BillAmt)    
 Select       
  FB.FinalBillID,    
  PDC.VisitID,    
  Convert(nvarchar,PDC.CreatedAt,103),    
  (CASE     
  WHEN PDC.Amount =0 THEN (                                                            
  CASE                                                             
   WHEN (PDC.FeeType =''INV'' ) THEN     
     (Select ISNULL(IPAmount,0)     
     FROM InvRateMaster IRM      
     WHERE ID=PDC.FeeID AND IRM.Type =''INV'' AND     
    IRM.RateID = PDC.RateID )                              
   WHEN (PDC.FeeType =''GRP'' ) THEN                                                       
     (Select ISNULL(IPAmount,0)     
     FROM InvRateMaster IRM,InvOrgGroup IVG   
     WHERE IVG.AttGroupID=PDC.FeeID AND  IVG.OrgGroupID=IRM.ID     
    AND IRM.Type =''GRP''                                         
    AND IRM.RateID = PDC.RateID)                                           
   WHEN (PDC.FeeType =''CON'' ) THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID = PDC.FeeID )                                                             
   WHEN (PDC.FeeType =''PRO'' ) THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID = PDC.FeeID )                                                            
   WHEN (PDC.FeeType =''IND'' ) THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID = PDC.FeeID )                                                             
   WHEN PDC.FeeType =''OTH'' THEN 0                                                            
  END                                                            
  )             
  WHEN PDC.Amount !=0 THEN PDC.Amount                                                 
  END ) * PDC.unit AS Amount      
 FROM PatientDueChart PDC    
  INNER JOIN FinalBill FB ON PDC.VisitID=FB.VisitID    
  INNER JOIN PatientVisit PV ON FB.VisitID = PV.PatientVisitID    
 WHERE PDC.CreatedAt BETWEEN @pFDate AND @pTDdate AND PV.VisitType = 1-- AND PDC.Status=''Pending''    
                      AND FB.OrgID = @pOrgID                    
  UNION ALL                    
                                                
  SELECT       
  FB.FinalBillID,    
  FB.VisitID,    
  Convert(nvarchar,BD.CreatedAt,103),       
  (CASE                                      
  WHEN BD.Amount = 0 THEN                                                  
  CASE                                                          
  WHEN BD.FeeType =''INV'' THEN     
     (Select ISNULL(IPAmount,0)     
     FROM InvRateMaster IRM     
     Where ID=BD.FeeID AND IRM.Type =''INV'' AND IRM.RateID = BD.RateID      
     )                        
  
  WHEN BD.FeeType =''GRP'' THEN                                                       
     (Select ISNULL(IPAmount,0)     
     FROM InvRateMaster IRM,InvOrgGroup IVG                                    
     WHERE IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                         
    AND IRM.RateID = BD.RateID  )                                         
  WHEN BD.FeeType =''CON'' THEN     
     (Select ISNULL(IPAmount,0)     
     FROM PhysicianFee     
     WHERE PhysicianFeeID =BD.FeeId )                                                             
  WHEN BD.FeeType =''PRO'' THEN     
     (Select ISNULL(IPAmount,0)     
     FROM ProcedureFee     
     WHERE ProcedureFeeID =BD.FeeId )                                                            
  WHEN BD.FeeType =''IND'' THEN     
     (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =BD.FeeId )                                                             
  ELSE BD.Amount                                                  
  END                                                  
  ELSE BD.Amount                                                  
  END)* BD.Quantity AS Amount      
 FROM BillingDetails BD INNER JOIN FinalBill FB ON FB.FinalBillID = BD.FinalBillID      
  INNER JOIN PatientVisit PV ON FB.VisitID = PV.PatientVisitID    
 WHERE FB.VisitID = FB.VisitID  AND BD.Status <>''Deleted'' --AND (BD.Status =''Ordered'' OR BD.Status =''Paid'' BD.Status =''Ordered'' )-- AND BD.FeeType!=''ROM''                                                              
 AND BD.FeeType <>''ROM''   AND BD.CreatedAt BETWEEN @pFDate AND @pTDdate    
 AND PV.VisitType = 1    AND FB.OrgID = @pOrgID
      
UNION ALL                        
    
 SELECT     
  FB.FinalBillID,    
  FB.VisitID,    
  Convert(nvarchar,RFD.CreatedAt,103), RFD.Amount      
 FROM registrationfeedetails RFD INNER JOIN FinalBill FB    
  ON  RFD.VisitID = FB.VisitID INNER JOIN PatientVisit PV    
  ON  FB.VisitID = PV.PatientVisitID    
 WHERE PaidYN =''N''    
  AND RFD.CreatedAt BETWEEN @pFDate AND @pTDdate    
  AND FB.OrgID = @pOrgID AND PV.VisitType = 1    
                
UNION ALL    
     
 --SELECT      
 -- FB.FinalBillID,    
 -- FB.VisitID,    
 -- Convert(nvarchar,@pFDate,103),    
 -- RTFM.Amount *     
 --  (dbo.fn_getHalfDayDateDiff(@pFDate,     
 --     CASE     
 --    WHEN @pTDdate<=BB.ToDate AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN @pTDdate  
 --    WHEN BB.ToDate=''1900-01-01 00:00:00.000'' THEN GetDate()    
 --    ELSE @pFDate    
 --     END ))        
 --FROM BedBooking BB     
 -- INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                            
 -- INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                            
 -- INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                                        
 -- INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                        
 -- INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID     
 -- INNER JOIN FinalBill FB ON BB.VisitID = FB.VisitID  
 --WHERE  BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )      
 --  AND ((@pFDate Between BB.FromDate AND @pTDDate ) OR (@pTDDate=''1900-01-01 00:00:00.000''))  
 --  AND FB.OrgID=@pOrgID  
   
 SELECT      
  FB.FinalBillID,    
  FB.VisitID,    
  Convert(nvarchar,@pFDate,103),    
  RTFM.Amount *   
		(dbo.fn_getHalfDayDateDiff(@pFDate,   
		   CASE 
				WHEN BB.ToDate<=@pTDdate AND Convert(nvarchar,BB.ToDate,103)=Convert(nvarchar,@pTDdate,103) AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN BB.ToDate   
				WHEN @pTDdate<=BB.ToDate AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN @pTDdate
				WHEN BB.ToDate=''1900-01-01 00:00:00.000'' THEN @pTDdate  
				ELSE @pFDate  
		   END ))      
FROM BedBooking BB   
	INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                          
	INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                          
	INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                                      
	INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                      
	INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID   
	INNER JOIN FinalBill FB ON BB.VisitID = FB.VisitID
WHERE  BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )    
		AND ((@pTDdate Between Convert(datetime,(Convert(nvarchar,BB.FromDate,103) + '' 00:00:00'')) AND 
					Convert(datetime,(Convert(nvarchar,BB.ToDate,103) + '' 23:59:59'')))
				OR (BB.ToDate=''1900-01-01 00:00:00.000'')
			)
		AND FB.OrgID=@pOrgID  
     
  
     
   RETURN      
           
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetIPDueExcludeAdvance]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPDueExcludeAdvance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetIPDueExcludeAdvance] (@pVisitID bigint,@pAmountType nvarchar(10))      
RETURNS DECIMAL(18,2)      
WITH EXECUTE AS CALLER      
AS      
BEGIN      
 DECLARE @pBalance decimal(18,2);      
 SET @pBalance =0;      
    
 DECLARE @pTotalAdvance DECIMAL(18,2);      
 DECLARE @pTotalSurgeryAdvance DECIMAL(18,2);      
 DECLARE @pTotalReceived DECIMAL(18,2);      
 DECLARE @pTotalDue DECIMAL(18,2);      
 DECLARE @pPreviousRefund DECIMAL(18,2);      
 DECLARE @pTotalSurgeryAmount DECIMAL(18,2);      
 DECLARE @pPatientID  BIGINT;      
 DECLARE @pTotalBilledAmount  DECIMAL(18,2);      
 DECLARE @pServiceCharge AS DECIMAL(18,2);      
 DECLARE @orgID INT;      
 DECLARE @pFinalBillID AS BIGINT;    
 SELECT @pPatientID = PatientID,@orgID= OrgID FROM PatientVisit WHERE PatientVisitId = @pVisitID        
 SELECT @pFinalBillID = MAX(FinalBillID) FROM FINALBILL Where VisitID = @pVisitID    
     
 SELECT @pTotalAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') <>''SOI''                                              
 SELECT @pTotalSurgeryAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') = ''SOI''                                        
 SELECT @pTotalReceived = ISNULL(SUM(AmountReceived),0) FROM IPIntermediatePayments WHERE VisitID=@pVisitID                                                      
 SELECT @pTotalDue = ISNULL(SUM(FB.Due),0) FROM FinalBill FB INNER JOIN PatientVisit PV ON                                                      
 FB.VisitID = PV.PatientVisitId WHERE PV.PatientID = @pPatientID  AND VisitID <>@pVisitID      
    
 SELECT @pPreviousRefund = ISNULL(SUM(AmountRefund),0) FROM FinalBill WHERE VisitID=@pVisitID                                                      
 SELECT @pTotalSurgeryAmount  = ISNULL(SUM(PD.Amount),0) FROM PatientDueChart PD                                      
 INNER JOIN SurgeryBillingMaster SB ON SB.SurgeryBillingID = PD.FeeID AND PD.FeeType =''SOI''                                       
 WHERE VisitID = @pVisitID AND ISNULL(SB.IsCreditBill,''N'') = ''N''           
    
 SELECT @pServiceCharge = ISNULL(ServiceCharge,0) from IPIntermediatePayments Where VisitID = @pVisitID              
 AND PaymentDetailsID = (SELECT MAX(PaymentDetailsID) FROM IPIntermediatePayments WHERE VisitID = @pVisitID)      
    
 DECLARE @pTempAmount AS TABLE       
 (DetailsID BIGINT NULL,Amount Decimal(18,2) NULL)      
-------------------------------------------------------------------------------------------------------          
 INSERT INTO @pTempAmount      
    
 SELECT ISNULL(DetailsID,0)AS DetailsID,                                                                
  (CASE WHEN Amount =0 THEN (                                                                
  CASE                                                                 
  WHEN (FeeType =''INV'' ) THEN (Select ISNULL(rate,0)     
  from InvRateMaster IRM   Where ID=FeeID     
  AND IRM.Type =''INV'' AND IRM.RateID = S.RateID    
  )                                  
  WHEN (FeeType =''GRP'' ) THEN                                                           
  (Select ISNULL(rate,0) from InvRateMaster IRM,InvOrgGroup IVG  Where IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                             
  AND IRM.RateID = S.RateID   )                                               
  WHEN (FeeType =''CON'' ) THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID =FeeID )                                                                 
  WHEN (FeeType =''PRO'' ) THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID =FeeID )                                         
  WHEN (FeeType =''IND'' ) THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =FeeID )                                                                 
  WHEN FeeType =''OTH'' THEN 0                                                                
  END ) WHEN Amount !=0 THEN Amount END )*ISNULL(Unit,0)    
 FROM PatientDueChart s WHERE VisitID=@pVisitID                                                                 
 AND STATUS = ''Pending''                               
                           
 UNION                            
    
	 SELECT ISNULL(BD.BillingDetailsID,0)AS DetailsID,     
	 (CASE  WHEN BD.Amount = 0 THEN                                                      
	 CASE  WHEN BD.FeeType =''INV'' THEN (Select ISNULL(rate,0)     
	 FROM InvRateMaster IRM     
	 Where ID=BD.FeeID AND IRM.Type =''INV'' AND IRM.RateID = BD.RateID      
	   )                             
	 WHEN BD.FeeType =''GRP'' THEN                                                           
	 (Select ISNULL(rate,0) from InvRateMaster IRM,InvOrgGroup IVG                                            
	 Where IVG.AttGroupID=FeeID AND  IVG.OrgGroupID=IRM.ID AND IRM.Type =''GRP''                                             
	 AND IRM.RateID = BD.RateID  )                                             
	 WHEN BD.FeeType =''CON'' THEN (Select ISNULL(IPAmount,0) from PhysicianFee Where PhysicianFeeID =BD.FeeId )                                                                 
	 WHEN BD.FeeType =''PRO'' THEN (Select ISNULL(IPAmount,0) from ProcedureFee Where ProcedureFeeID =BD.FeeId )                                                                
	 WHEN BD.FeeType =''IND'' THEN (Select ISNULL(IPAmount,0) from MedicalIndents Where ItemID =BD.FeeId )                                                                 
	 ELSE BD.Amount                                                      
	 END                                                      
	 ELSE BD.Amount                                                      
	 END)*ISNULL(BD.Quantity,0) AS Amount     
	 FROM BillingDetails BD INNER JOIN FinalBill FB ON FB.FinalBillID = BD.FinalBillID                                                                 
	 WHERE FB.VisitID = @pVisitID  AND BD.Status <>''Deleted''     
                      
 UNION                               
 SELECT 0,Amount    
 FROM  registrationfeedetails                              
 WHERE patientID = @pPatientID AND VisitID = @pVisitID AND PaidYN =''N''                              
    
 UNION    
    
 SELECT  BB.BookingID  AS DetailsID,                                                                
 RTFM.Amount *(                
 CASE WHEN   (ISNULL(RTFM.ISVariable,''N'') =''Y'') THEN (dbo.fn_getHalfDayDateDiff(BB.FromDate , BB.ToDate ))        
 ELSE ( dbo.fn_getFullDayDateDiff(BB.FromDate,BB.ToDate))END)  AS Amount    
      
 FROM  BedBooking BB INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                
    INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                                
    INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                                            
    INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                            
    INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID                                                            
 WHERE  BB.VisitID =@pVisitID AND BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )           
 AND BB.BookingID NOT IN (Select Feeid from BillingDetails where FinalBillID=@pFinalBillID)        
 UNION                            
                                                    
  SELECT ISNULL(BD.FeeId,0)AS DetailsID,                                                   
  ( BD.Amount *                                                                
  ISNULL(BD.Quantity,0) ) AS Amount    
  from BillingDetails BD         
  INNER JOIN FinalBill FB ON FB.FinalBillID = BD.FinalBillID          
  INNER JOIN BedBooking BB ON BB.BookingID = BD.FeeId INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                
	INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                                
	INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                                            
	INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                            
	INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID                                                            
 WHERE  FB.VisitID = @pVisitID  AND BD.Status <>''Deleted'' AND BD.FeeType=''ROM''     
         
     DECLARE @pTotal AS DECIMAL(18,2)       
     SELECT @pTotal = SUM(Amount) FROM @pTempAmount      
           

	SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pTotalDue,0)-ISNULL(@pTotalReceived,0)),0)      
    
	SELECT @pTotalBilledAmount =(CASE WHEN @pTotalBilledAmount>0 THEN @pTotalBilledAmount ELSE 0 END)      
	   
	RETURN(@pTotalBilledAmount);      
           
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetIPRate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetIPRate] (@ID bigint,@ClientID bigint,@type nchar(3))  
RETURNS decimal(18,2)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
     DECLARE @rate decimal(18,2)  
     SELECT @rate = RM.IPAmount FROM InvRateMaster RM  
     where RM.RateID = @ClientID AND RM.ID = @ID AND RM.Type = @type     
     SET @rate = ISNULL(@rate,0)  
     RETURN(@rate);  
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetIPReceiptAmountByDate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIPReceiptAmountByDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetIPReceiptAmountByDate]             
( @pOrgID int,          
@pCurrencyID INT,               
 @pFDate DATETIME,            
 @pTDate DATETIME,            
 @pVisitType int            
)                    
RETURNS @BillAmtTbl TABLE (                  
   FinalBillID BIGINT,            
   VisitID BIGINT,                   
   VisitType int,                   
   BillDate DATETIME,                  
   BillAmt DECIMAL(18,2),        
     PaidCurrency  nvarchar(100),          
  PaidCurrencyAmount DECIMAL(18,2),      
  DepositUsed DECIMAL(18,2) )               
-- SELECT 1 FROM  [dbo].[GetIPReceiptAmountByDate] (26,''01 Aug 2010'',''01 Aug 2010'',1)            
AS                    
BEGIN           
IF ( @pCurrencyID = 0)        
     SET @pCurrencyID = NULL          
  INSERT INTO @BillAmtTbl (FinalBillID, VisitID, VisitType, BillDate,BillAmt,PaidCurrency,PaidCurrencyAmount,DepositUsed)                    
  SELECT BM.PaymentDetailsID,             
    PV.PatientVisitID,            
    @pVisitType,                             
    BM.CreatedAt,                     
    (BM.AmountReceived - ISNULL(PDU.AmountUsed,0)) AS AmountReceived,ISNULL(CM.CurrencyCode,        
         (SELECT CM.CurrencyCode FROM CurrencyOrgMapping COM INNER JOIN CurrencyMaster CM ON COM.CurrencyID = CM.CurrencyID AND COM.OrgID = @pOrgId AND COM.IsBaseCurrency = ''Y'')        
         ) AS PaidCurrency,        
          ISNULL(BM.OtherCurrencyAmount,0) AS PaidCurrencyAmount,PDU.AmountUsed AS DepositUsed              
  FROM IPIntermediatePayments BM                              
    INNER JOIN PatientVisit PV ON BM.VisitID = PV.PatientVisitId                              
    INNER JOIN Patient P ON PV.PatientID = P.PatientID                              
    INNER JOIN Salutation S ON P.TITLECode = S.TitleID         
     LEFT JOIN CurrencyMaster CM ON CM.CurrencyID = BM.PaidCurrencyID       
       LEFT JOIN PatientDepositUsage PDU ON PDU.PatientID = PV.PatientID AND PDU.OrgID = PV.OrgID AND (PDU.ReceiptNo = BM.ReceiptNO OR PDU.ReceiptNo IS NULL)                    
  WHERE ISNULL(BM.ReceiptNO,'''')<>''''             
    AND P.OrgID=@pOrgID            
    AND PV.VisitType=@pVisitType              
    AND BM.CreatedAt BETWEEN Convert(datetime, Convert(nvarchar,@pFDate,103) + '' 00:00:00'') AND Convert(datetime, Convert(nvarchar,@pTDate,103) + '' 23:59:59'')            
    AND (BM.PaidCurrencyID = COALESCE(@pCurrencyID,BM.PaidCurrencyID) OR  BM.PaidCurrencyID IS NULL)          
           
  UNION             
  SELECT BM.PatientID,            
    PV.PatientVisitID,                              
    @pVisitType,                             
    BM.CreatedAt,                     
    (BM.AdvanceAmount - ISNULL(PDU.AmountUsed,0)) AS AdvanceAmount,        
     ISNULL(CM.CurrencyCode,        
         (SELECT CM.CurrencyCode FROM CurrencyOrgMapping COM INNER JOIN CurrencyMaster CM ON COM.CurrencyID = CM.CurrencyID AND COM.OrgID = @pOrgId AND COM.IsBaseCurrency = ''Y'')        
         ) AS PaidCurrency,        
          ISNULL(BM.OtherCurrencyAmount,0) AS PaidCurrencyAmount,PDU.AmountUsed AS DepositUsed                          
  FROM AdvancePaidDetails BM                              
    INNER JOIN PatientVisit PV ON BM.VisitID = PV.PatientVisitId                              
    INNER JOIN Patient P ON PV.PatientID = P.PatientID                              
    INNER JOIN Salutation S ON P.TITLECode = S.TitleID         
     LEFT JOIN CurrencyMaster CM ON CM.CurrencyID = BM.PaidCurrencyID       
       LEFT JOIN PatientDepositUsage PDU ON PDU.PatientID = PV.PatientID AND PDU.OrgID = PV.OrgID AND (PDU.ReceiptNo = BM.ReceiptNO OR PDU.ReceiptNo IS NULL)                    
  WHERE ISNULL(BM.ReceiptNO,'''')<>''''             
    AND P.OrgID=@pOrgID             
    AND PV.VisitType=@pVisitType            
    AND  BM.CreatedAt BETWEEN Convert(datetime, Convert(nvarchar,@pFDate,103) + '' 00:00:00'') AND Convert(datetime, Convert(nvarchar,@pTDate,103) + '' 23:59:59'')                
    AND (BM.PaidCurrencyID = COALESCE(@pCurrencyID,BM.PaidCurrencyID) OR  BM.PaidCurrencyID IS NULL)         
   RETURN             
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetPaymentBalance]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPaymentBalance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetPaymentBalance] (@patientID bigint)
RETURNS int
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @cnt decimal;
     SET @cnt=0;
     SELECT @cnt = SUM(Amount - AmountReceived) FROM PatientPayments WHERE PatientID=@patientID
     
     RETURN(@cnt);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetRate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[GetRate] (@ID bigint,@ClientID bigint,@type nchar(3))
RETURNS decimal(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @rate decimal(18,2)
     SELECT @rate = RM.Rate FROM InvRateMaster RM (NOLOCK)
     where RM.RateID = @ClientID AND RM.ID = @ID AND RM.Type = @type   
     SET @rate = ISNULL(@rate,0)
     RETURN(@rate);
END;




' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetRatePCClient]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRatePCClient]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetRatePCClient] (@ID bigint,@OrgID int,@RefOrgID bigint,@RefPhyID int,@ClientID bigint,@type nchar(3))    
RETURNS DECIMAL(18,2)    
WITH EXECUTE AS CALLER    
AS    
BEGIN    
     DECLARE @rate DECIMAL(18,2)    
       
     SET @rate = 0  
       
     SELECT @rate = ISNULL(PCCPM.Rate,0) FROM PCCustomPriceMapping PCCPM  
     WHERE PCCPM.RefPhyID = @RefPhyID AND PCCPM.RefOrgID = @RefOrgID AND PCCPM.OrgID = @OrgID AND PCCPM.ID = @ID AND PCCPM.Type = @type  
       
     IF @rate = 0  
     BEGIN  
       
     SELECT @rate = RM.Rate FROM InvRateMaster RM    
     WHERE RM.RateID = @ClientID AND RM.ID = @ID AND RM.Type = @type       
       
     END  
       
     SET @rate = ISNULL(@rate,0)    
     RETURN(@rate);    
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetReceivedFromTPA]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetReceivedFromTPA]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetReceivedFromTPA] (@VID bigint)    
RETURNS decimal(18,2)    
WITH EXECUTE AS CALLER    
AS    
BEGIN        
     --DECLARE @TPAAmount decimal(18,2)            
     --SELECT @TPAAmount=sum(Amount) FROM TPAPayments WHERE VisitID=@VID        
     --SET @TPAAmount = ISNULL(@TPAAmount,0)        
     --RETURN(@TPAAmount);       
     DECLARE @TPAAmount decimal(18,2)              
     SELECT @TPAAmount=isnull(sum(Amount),0) FROM TPAPayments (nolock) WHERE VisitID=@VID          
     SET @TPAAmount = ISNULL(@TPAAmount,0)          
     RETURN(@TPAAmount);         
END;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetRoomCollectionByDate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRoomCollectionByDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetRoomCollectionByDate] (@pOrgID int, @pOrgAddID BIGINT, @pFDate DATETIME,@pTDdate DATETIME)            
RETURNS   @RoomCollectionTbl TABLE (          
		FinalBillID BIGINT,  
		DetailsID bigint,
		FeeID bigint,
		BookingID bigint,         
		VisitID BIGINT,     
		RoomName nvarchar(255),          
		FromDate DATETIME,    
		Qty nvarchar(10),          
		Amount DECIMAL(18,2))          
AS            
BEGIN        

-- Select * from dbo.[GetRoomCollectionByDate] (78, 80, ''13 Oct 2012 00:00:00'',''13 Oct 2012 23:59:59'') Where VisitID=161325         
               
	 INSERT INTO @RoomCollectionTbl (FinalBillID, DetailsID,FeeID,BookingID, VisitID, RoomName, FromDate, Qty, Amount)          
	 SELECT		FB.FinalBillID,          
				PDC.DetailsID, 
				BD.FeeID, 
				BB.BookingID,
				FB.VisitID,          
				IsNull(BM.BedName,'''') + ''/'' + IsNull(RM.RoomName,'''') + ''/'' + IsNull(RT.RoomTypeName,'''') ,    
				--Convert(nvarchar,@pFDate,103),    
				BB.FromDate,
				COALESCE(PDC.unit,BD.Quantity,
				dbo.fn_getHalfDayDateDiff(@pFDate,         
				CASE       
					WHEN	BB.ToDate<=@pTDdate AND Convert(nvarchar,BB.ToDate,103)=Convert(nvarchar,@pTDdate,103)     
												AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN BB.ToDate         
					WHEN	@pTDdate<=BB.ToDate AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN @pTDdate      
					WHEN	BB.ToDate=''1900-01-01 00:00:00.000'' THEN @pTDdate        
					ELSE	@pFDate        
				END)) ,         
		   Coalesce(PDC.Amount, BD.Amount, dbo.fnGetRoomFee
		   (@pOrgAddID,BB.BedID)) *         
			  (COALESCE(PDC.unit,BD.Quantity,dbo.fn_getHalfDayDateDiff(@pFDate,         
			   CASE       
				   WHEN		BB.ToDate<=@pTDdate AND Convert(nvarchar,BB.ToDate,103)=Convert(nvarchar,@pTDdate,103)     
												AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN BB.ToDate         
				   WHEN		@pTDdate<=BB.ToDate AND BB.ToDate<>''1900-01-01 00:00:00.000'' THEN @pTDdate      
				   WHEN		BB.ToDate=''1900-01-01 00:00:00.000'' THEN @pTDdate        
				   ELSE		@pFDate        
			   END)))            
	FROM	BedBooking BB         
			INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                
			INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID             
			INNER JOIN FloorMaster FM ON FM.FloorID = RM.FloorID                                               
			INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                                            
			INNER JOIN FinalBill FB ON BB.VisitID = FB.VisitID 
			LEFT JOIN BillingDetails BD ON BD.FeeId=BB.BookingID AND BD.FinalBillID=FB.FinalBillID AND BD.FeeType=''ROM''     
			LEFT JOIN PatientDueChart PDC ON PDC.FeeID=BB.BookingID AND PDC.VisitID=FB.VisitID AND PDC.FeeType=''ROM'' AND Upper(PDC.Status) != ''PAID''
	WHERE	BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )          
			AND 
			BB.FromDate Between @pFDate AND @pTDdate
			--(
			--	 (    
			--	  (@pTDdate Between Convert(datetime,(Convert(nvarchar,BB.FromDate,103) + '' 00:00:00'')) AND       
			--	   Convert(datetime,(Convert(nvarchar,BB.ToDate,103) + '' 23:59:59''))    
			--	  )      
			--	  OR     
			--	  (BB.ToDate=''1900-01-01 00:00:00.000'')    
			--	 )    
			--)      
			AND FB.OrgID=@pOrgID        
           
   RETURN            
                 
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetRoomDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRoomDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetRoomDetails]             
		(       
			@pVisitID bigint,
			@pFeeID bigint    
		)            
		RETURNS nvarchar(MAX) 
		WITH EXECUTE AS CALLER 
		AS
		BEGIN
			DECLARE @pRoomName AS NVARCHAR(MAX)
			SELECT @pRoomName=''Room :'' + RM.RoomName + ''--'' + RT.RoomTypeName FROM PatientDueChart BD
				INNER JOIN FinalBill FB ON FB.VisitID = BD.VisitID                                                                                                            
				INNER JOIN BedBooking BB ON BB.VisitID  = BD.VisitID  
				INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                                                                                                            
				INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                  
				INNER JOIN RoomType RT ON RT.RoomTypeID = BD.RoomTypeID                                                                                                                                          
				INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID                                                                                                                                                              
				INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID                                                                                                                     
				WHERE FB.VisitID = @pVisitID  AND BD.FeeID =@pFeeID 
				GROUP BY RM.RoomName,RT.RoomTypeName 
			RETURN (@pRoomName);
		END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetSpeciality]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSpeciality]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetSpeciality] (@FEEID bigint)
RETURNS nvarchar(30)
WITH EXECUTE AS CALLER
AS
BEGIN

     DECLARE @SpecialityName nvarchar(30)
     SELECT @SpecialityName=S.SpecialityName FROM Speciality S inner join PhysicianFee PF ON S.SpecialityID=PF.SpecialityID where PF.PhysicianFeeID=@FEEID    

    
     SET @SpecialityName = ISNULL(@SpecialityName,'''')
     RETURN(@SpecialityName);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetSpecialityID]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSpecialityID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetSpecialityID] (@FEEID bigint)  
RETURNS BIGINT  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
  
     DECLARE @SpecialityID BIGINT  
     SELECT @SpecialityID=S.SpecialityID FROM Speciality S inner join PhysicianFee PF ON S.SpecialityID=PF.SpecialityID where PF.PhysicianFeeID=@FEEID      
  
      
     SET @SpecialityID = ISNULL(@SpecialityID,0)  
     RETURN(@SpecialityID);  
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetSPKGSplitupDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSPKGSplitupDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetSPKGSplitupDetails]                 
(           
 @pVisitID bigint,          
 @pPackageID BIGINT           
)                
RETURNS NVARCHAR(MAX)                                  
WITH EXECUTE AS CALLER                                  
AS                                  
BEGIN    
 --select dbo.[GetSPKGSplitupDetails](0,675)                                     
 DECLARE @pTempData AS NVARCHAR(MAX)       
     
     
 DECLARE @pTable AS NVARCHAR(MAX)      
     
 DECLARE @pResult AS NVARCHAR(MAX)      
   
 DECLARE @pPackageName NVARCHAR(500)     
 
 
           
  DECLARE @pTEmpTable AS TABLE           
  (           
 SNO INT NULL,          
 FeeDescrip nvarchar(MAX) NULL,          
 Amount DECIMAL(18,2) NULL           
   )          
      
  --SELECT @pPackageName=ISNULL(PackageName,'''') FROM SurgeryPackageMaster WHERE PackageID=@pPackageID        
  
    DECLARE @pServiceCode NVARCHAR(200)  
    SELECT @pPackageName=ISNULL(PackageName,'''')   
                       FROM CommonSurgeryPackage   
                       WHERE 
                          SurgeryPackageID =(SELECT SurgeryPackageID 
                                                   FROM SurgeryPackageMaster 
                                                        WHERE PackageID= @pPackageID )     
                            
    SELECT @pServiceCode=ISNULL(ServiceCode,'''') FROM SurgeryPackageMaster WHERE PackageID=@pPackageID   
      
    IF @pServiceCode<>'''' and @pServiceCode<>''0'' SET @pPackageName=@pPackageName+'' (''+@pServiceCode+'' )''  
      
  INSERT INTO @pTEmpTable    
  SELECT ROW_NUMBER() OVER(ORDER BY SPKGD.DetailsID) AS Sno,SPKGD.ItemName,ISNULL(SPKGD.Amount,0)    
  FROM SurgeryPackageMaster SPKGM    
  INNER JOIN    
  SurgeryPackageDetails SPKGD    
  ON SPKGM.PackageID=SPKGD.PackageID    
  WHERE SPKGM.PackageID=@pPackageID    
      
  DECLARE @intFlag INT          
  DECLARE @pCount AS INT          
  SET @intFlag = 1    
        
  SELECT @pCount = COUNT(*) from @pTEmpTable    
        
	IF(@pCount>0)    
	 BEGIN    
		 SELECT @pTable= ''<table width="100%" class="dataheaderInvCtrl" style="font-size:10px;border-style:solid;border-spacing:1px;" >''       
		 SET @pTempData=''''  
		 BEGIN    
		  WHILE (@intFlag <= @pCount)          
		   BEGIN          
		    SELECT @pTempData = @pTempData + ''<tr> <td> ''+Feedescrip +''</td><td> :</td><td>''+CONVERT(nvarchar,Amount)+''</td></tr>''  from @pTEmpTable Where SNO=@intFlag          
		    SET @intFlag = @intFlag + 1          
		   END     
		 END    
		  SELECT @pResult=@pPackageName+@pTable+@pTempData+''</table>''       
	 END    
	    
	 ELSE    
	  BEGIN    
	   SELECT @pResult=@pPackageName    
	  END     
    
     RETURN(@pResult);           
    
           
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetSPKGSplitupDetailsTemp]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSPKGSplitupDetailsTemp]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetSPKGSplitupDetailsTemp]                   
(                 
 @pVisitID bigint,                
 @pPackageID BIGINT                 
)                      
RETURNS NVARCHAR(MAX)                                        
WITH EXECUTE AS CALLER                                        
AS                                        
BEGIN          
 --select dbo.[GetSPKGSplitupDetails](0,675)                                           
            
     Declare @data as nvarchar(10)      
           
 DECLARE @pTempData AS NVARCHAR(MAX)                 
     DECLARE @pTempData1 AS NVARCHAR(MAX)          
      DECLARE @pTempData2 AS NVARCHAR(MAX)             
               
 DECLARE @pTable AS NVARCHAR(MAX)       
  DECLARE @pTable1 AS NVARCHAR(MAX)       
   DECLARE @pTable2 AS NVARCHAR(MAX)           
           
 DECLARE @pResult AS NVARCHAR(MAX)            
         
 DECLARE @pPackageName NVARCHAR(500)           
                 
  DECLARE @pTEmpTable AS TABLE                 
  (                 
 SNO INT NULL,                
 FeeDescrip nvarchar(MAX) NULL,                
 Amount DECIMAL(18,2) NULL                 
   )                
            
   --SELECT @pPackageName=ISNULL(PackageName,'''') FROM SurgeryPackageMaster WHERE PackageID=@pPackageID            
      
      
      DECLARE @pServiceCode NVARCHAR(200)  
      SELECT @pPackageName=ISNULL(PackageName,'''')   
                         FROM CommonSurgeryPackage    
                         WHERE 
                             SurgeryPackageID=(SELECT SurgeryPackageID 
                                                      FROM SurgeryPackageMaster 
                                                            WHERE PackageID= @pPackageID )    
                             
       SELECT @pServiceCode=ISNULL(ServiceCode,'''') FROM SurgeryPackageMaster WHERE PackageID=@pPackageID  
                              
      IF @pServiceCode<>'''' and @pServiceCode<>''0'' SET @pPackageName=@pPackageName+'' (''+@pServiceCode+'' )''             
            
  INSERT INTO @pTEmpTable          
  SELECT ROW_NUMBER() OVER(ORDER BY SPKGD.DetailsID) AS Sno,SPKGD.ItemName,ISNULL(SPKGD.Amount,0)          
  FROM SurgeryPackageMaster SPKGM          
  INNER JOIN          
  SurgeryPackageDetails SPKGD          
  ON SPKGM.PackageID=SPKGD.PackageID          
  WHERE SPKGM.PackageID=@pPackageID          
            
 DECLARE @intFlag INT         
    DECLARE @intFlag1 INT       
      DECLARE @intFlag2 INT                  
        
        
  DECLARE @pCount AS INT                    
  SET @intFlag = 1              
  SET @intFlag1 = 1      
  SET @intFlag2 = 1        
              
  SELECT @pCount = COUNT(*) from @pTEmpTable          
              
 IF(@pCount>0)       
       
  set @data =  ''y''      
  --first table      
  BEGIN          
   SELECT @pTable= ''<table width="100%" class="dataheaderInvCtrl" style="font-size:10px;border-style:solid;border-spacing:1px;" >''             
   SET @pTempData=''''        
   BEGIN          
    WHILE (@intFlag <= @pCount)                
     BEGIN                
      SELECT @pTempData = @pTempData + ''<tr> <td> ''+Feedescrip +''</td><td> :</td><td>''+CONVERT(nvarchar,Amount)+''</td></tr>''  from @pTEmpTable Where SNO=@intFlag                
      SET @intFlag = @intFlag + 1                
     END           
   END          
           
  END        
  --second table      
   BEGIN          
   SELECT @pTable1= ''<table width="100%" class="dataheaderInvCtrl" style="font-size:10px;border-style:solid;border-spacing:1px;" >''             
   SET @pTempData1=''''        
   BEGIN          
    WHILE (@intFlag1 <= @pCount)                
     BEGIN                
      SELECT @pTempData1 = @pTempData1 + ''<tr> <td> ''+Feedescrip +''</td></tr>''  from @pTEmpTable Where SNO=@intFlag1                
      SET @intFlag1 = @intFlag1 + 1                
     END           
   END                 
  END        
  --Third table      
        
   BEGIN          
   SELECT @pTable2= ''<table width="100%" class="dataheaderInvCtrl" style="font-size:10px;border-style:solid;border-spacing:1px;" >''             
   SET @pTempData2=''''        
   BEGIN          
    WHILE (@intFlag2 <= @pCount)                
     BEGIN                
      SELECT @pTempData2 = @pTempData2 + ''<tr><td>''+CONVERT(nvarchar,Amount)+''</td></tr>''  from @pTEmpTable Where SNO=@intFlag2                
      SET @intFlag2 = @intFlag2 + 1                
     END           
   END          
               
  END          
  --check condition      
        
           
    if(@data=''y'')      
    begin      
     SELECT @pResult=@pPackageName+@pTable+@pTempData+''</table>'' +''~'' +@pPackageName+@pTable1+@pTempData1+''</table>''+''~'' +@pTable2+@pTempData2+''</table>''         
    end      
    else      
    begin      
        SELECT @pResult=@pPackageName       
    end      
          
          
          
     RETURN(@pResult);  
             
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetStockOutFlowQty]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockOutFlowQty]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetStockOutFlowQty] (@pStartDt datetime,@pEndDt datetime,@ID bigint,@ProId bigint,@OrgID int)
RETURNS decimal(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN
 DECLARE @Qty decimal(18,2)
     BEGIN
    SELECT	@Qty=SUM(SOD.Quantity)
    
	FROM	StockOutFlowDetails SOD INNER JOIN StockOutFlow SO
			ON SOD.StockOutFlowID=SO.StockOutFlowID
			INNER JOIN StockOutFlowTypes SOT ON SO.StockOutFlowTypeID=SOT.StockOutFlowTypeId and SOD.OrgID= @OrgID
	WHERE	SOD.StockOutFlowDate between @pStartDt AND @pEndDt +1
	AND SO.StockOutFlowTypeID=@ID 
	AND SOD.ProductID=@ProId 
	GROUP BY ProductID, SOT.StockOutFlowType
	ORDER BY ProductID,SOT.StockOutFlowType
	
	SET @Qty = ISNULL(@Qty,0)
	
	END
     
   RETURN(@Qty);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetStockRecdQty]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockRecdQty]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create FUNCTION [dbo].[GetStockRecdQty] (@pStartDt datetime,@pEndDt datetime,@ProId bigint,@OrgID int)  
RETURNS decimal(18,2)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
 DECLARE @Qty decimal(18,2)  
     BEGIN  
    SELECT @Qty=SUM(SRD.RcvdLSUQty)  
      
  FROM StockReceivedDetails SRD   
  WHERE  SRD.OrgID= @OrgID AND SRD.StockReceivedDate between @pStartDt AND @pEndDt +1  
  AND SRD.ProductID=@ProId   
  GROUP BY ProductID  
  ORDER BY ProductID  
  SET @Qty = ISNULL(@Qty,0)  
   
 END  
       
   RETURN(@Qty);  
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetSurgerySplitupDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSurgerySplitupDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetSurgerySplitupDetails]             
(       
 @pVisitID bigint,      
 @pSurgeryBillingID BIGINT       
)            
RETURNS NVARCHAR(MAX)                              
WITH EXECUTE AS CALLER                              
AS                              
BEGIN                              
 DECLARE @pTempData AS NVARCHAR(MAX)       
       
  DECLARE @pTEmpTable AS TABLE       
  (       
 SNO INT NULL,      
 FeeDescrip nvarchar(MAX) NULL,      
 Amount DECIMAL(18,2) NULL       
   )      
         
 Select @pTempData=(SBM.TreatmentName+    
 ''<table width="100%" class="dataheaderInvCtrl" style="font-size:10px;border-style:solid;border-spacing:1px;" >''+    
 CASE WHEN ISNULL(SBM.SurgicalFee,0)>0 THEN ''<tr> <td> Surgical Fee</td><td> : </td><td>''+CONVERT(nvarchar,SBM.SurgicalFee)+''</td></tr>''  ELSE ''''  END     
 +      
 CASE WHEN ISNULL(SBM.ChiefSurgeonFee,0)>0 THEN ''<tr> <td> Chief Surgeon Fee</td><td> : </td><td>''+CONVERT(nvarchar,SBM.ChiefSurgeonFee)+''</td></tr>''  ELSE ''''  END     
 +      
 CASE WHEN ISNULL(SBM.OTCharges,0)>0 THEN ''<tr> <td> OT Charges</td><td> : </td><td>''+CONVERT(nvarchar,SBM.OTCharges)+''</td></tr>''  ELSE ''''  END     
 +      
 CASE WHEN ISNULL(SBM.RoomCharges,0)>0 THEN ''<tr> <td>Recovery Room Charges</td><td> : </td><td>''+CONVERT(nvarchar,SBM.RoomCharges)+''</td></tr>''  ELSE ''''  END     
 +      
 CASE WHEN ISNULL(SBM.Consumables,0)>0 THEN ''<tr> <td> Consumables</td><td> : </td><td>''+CONVERT(nvarchar,SBM.Consumables)+''</td></tr>''  ELSE ''''  END    
 +      
 CASE WHEN ISNULL(SBM.ProsthesisFee,0)>0 THEN ''<tr> <td> Prosthesis Fee</td><td> : </td><td>''+CONVERT(nvarchar,SBM.ProsthesisFee)+''</td></tr>''  ELSE ''''  END )         
      
 from surgerybillingmaster SBM   WITH(NOLOCK)  where SBM.PatientVisitID = @pvisitID AND SBM.SurgerybillingID = @pSurgeryBillingID      
       
 INSERT INTO @pTEmpTable      
  Select ROW_NUMBER() over(order by SBT.SurgeryBillingID ) as SNo,SBT.Description,SBT.Value         
 from surgerybillingmaster SBM   WITH(NOLOCK) 
 INNER JOIN SurgeryBillingDetails SBT   WITH(NOLOCK) ON SBM.SurgeryBillingID = SBT.SurgeryBillingID       
 where SBM.PatientVisitID = @pvisitID AND SBM.SurgerybillingID = @pSurgeryBillingID      
       
       
       
DECLARE @intFlag INT      
DECLARE @pCount AS INT      
SET @intFlag = 1      
SELECT @pCount = COUNT(*) from @pTEmpTable      
WHILE (@intFlag <= @pCount)      
BEGIN      
 Select @pTempData = @pTempData + ''<tr> <td> ''+Feedescrip +''</td><td> :</td><td>''+CONVERT(nvarchar,Amount)+''</td></tr>''  from @pTEmpTable Where SNO=@intFlag      
SET @intFlag = @intFlag + 1      
END      
 Select @pTempData = @pTempData + ''</table>''    
     RETURN(@pTempData);                              
                                   
END;  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetTDSAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTDSAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetTDSAmount] (@VID bigint)  
RETURNS decimal(18,2)  
WITH EXECUTE AS CALLER  
AS  
BEGIN      
     DECLARE @TDSAmount decimal(18,2)          
     SELECT @TDSAmount=sum(TDS) FROM TPAPayments (nolock) WHERE VisitID=@VID      
     SET @TDSAmount = ISNULL(@TDSAmount,0)      
     RETURN(@TDSAmount);      
END;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetTPAAmount] (@VID bigint)  
RETURNS decimal(18,2)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
     --DECLARE @TPAAmount decimal(18,2)      
     --SELECT @TPAAmount=sum(Amount) FROM TPAPayments WHERE VisitID=@VID  
     --SET @TPAAmount = ISNULL(@TPAAmount,0)  
     --RETURN(@TPAAmount); 
     DECLARE @TPAAmount decimal(18,2)        
     SELECT @TPAAmount=isnull(sum(Amount),0)+isnull(sum(TDS),0) FROM TPAPayments WHERE VisitID=@VID    
     SET @TPAAmount = ISNULL(@TPAAmount,0)    
     RETURN(@TPAAmount);   
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAbalance]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAbalance]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetTPAbalance]        --SELECT [dbo].[GetTPAbalance] (49351,''TPAGB'')                                       
(                                        
 @pVisitID bigint,                                             
 @pAmountType nvarchar(10)                                             
)                                             
RETURNS DECIMAL(18,2)                                                               
WITH EXECUTE AS CALLER                                                               
AS                                                               
BEGIN                                                               
 DECLARE @pBalance decimal(18,2);                                                               
 SET @pBalance =0;                                                               
                                                          
 DECLARE @pTotalAdvance DECIMAL(18,2);                                                               
 DECLARE @pTotalSurgeryAdvance DECIMAL(18,2);                                                               
 DECLARE @pTotalReceived DECIMAL(18,2);                                                               
 DECLARE @pTotalDue DECIMAL(18,2);                                                               
 DECLARE @pPreviousRefund DECIMAL(18,2);                                                               
 DECLARE @pTotalSurgeryAmount DECIMAL(18,2);                                                               
 DECLARE @pPatientID  BIGINT;                                                               
 DECLARE @pTotalBilledAmount  DECIMAL(18,2);                                                               
 DECLARE @pServiceCharge AS DECIMAL(18,2);                                                               
 DECLARE @orgID INT;                                                               
 DECLARE @pFinalBillID AS BIGINT;                                                         
 DECLARE @pDiscount  DECIMAL(18,2);                                                             
 DECLARE @pDiscountType  nvarchar(255);                                     
 DECLARE @pPatientDiscount   DECIMAL(18,2)=0;                                                        
 DECLARE @pRoundOFF  DECIMAL(18,2);                         
 DECLARE @Reimbursable   DECIMAL(18,2);                         
 DECLARE @NonReimbursable   DECIMAL(18,2);                      
 DECLARE @PayerID INT;                                               
                                                            
 SELECT @pPatientID = PatientID,@orgID= OrgID,@PayerID=PayerID FROM PatientVisit (nolock)  WHERE PatientVisitId = @pVisitID                                                                 
 SELECT @pFinalBillID = MAX(FinalBillID)FROM FINALBILL (nolock)  Where VisitID = @pVisitID                                       
 SELECT @pPatientDiscount=ISNULL(DiscountAmount,0),@pRoundOFF= ISNULL(roundoff,0)  FROM FINALBILL (nolock)  Where FinalBillID = @pFinalBillID                                                             
 SELECT @pPatientDiscount = ISNULL(@pPatientDiscount,0)+(SUM(ISNULL(DiscountAmount,0))) from billingdetails (nolock)  where  finalbillid = @pFinalBillID                                                     
                                        
 SELECT @pTotalAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails (nolock)  WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') <>''SOI''                                                                                                       
 SELECT @pTotalSurgeryAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails (nolock)  WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') = ''SOI''                                                                                                 
 SELECT @pTotalReceived = ISNULL(SUM(AmountReceived),0) FROM IPIntermediatePayments (nolock)  WHERE VisitID=@pVisitID                SELECT @pTotalDue = 0.00                                                   
                                                              
 SELECT @pPreviousRefund = ISNULL(SUM(AmountRefund),0) FROM FinalBill (nolock) WHERE VisitID=@pVisitID                                    
 SELECT @pTotalSurgeryAmount  = ISNULL(SUM(PD.Amount),0) FROM PatientDueChart PD     (nolock)                        
 INNER JOIN SurgeryBillingMaster SB (nolock) ON SB.SurgeryBillingID = PD.FeeID AND PD.FeeType =''SOI''                                                                                                
 WHERE VisitID = @pVisitID AND ISNULL(SB.IsCreditBill,''N'') = ''N''                                                                    
                                                      
 SELECT @pServiceCharge = ISNULL(ServiceCharge,0) from IPIntermediatePayments (nolock) Where VisitID = @pVisitID                                                                           
 AND PaymentDetailsID = (SELECT MAX(PaymentDetailsID) FROM IPIntermediatePayments (nolock) WHERE VisitID = @pVisitID)                  
                                                            
 DECLARE @pTempAmount AS TABLE                                           
 (DetailsID BIGINT NULL,Amount Decimal(18,2) NULL,IsReimbursable nchar(5))                                                               
                        
 INSERT INTO @pTempAmount                                            
 Select ISNULL(PD1.DetailsID,0) AS DetailsID,PD1.Amount*ISNULL(CASE WHEN PD1.VersionNo = ''1.0'' THEN                                                                                                                      
  ISNULL(PD1.unit,0)   
   ELSE  
  ISNULL(PD1.unit,0) - ISNULL(PD1.ReturnQuantity,0) END  
   ,1) AS Amount,                                                                                                                                                   
                 
PD1.IsReimbursable                                              
                                                                
 from PatientDueChart PD1 (nolock)                            
 Where PD1.VisitID=@pVisitID                                                                                                        
 AND PD1.Status in(''Pending'',''Saved'')            
                                                                                                                                 
  UNION                                                                               
                                                                                                                                       
  SELECT ISNULL(BD.BillingDetailsID,0)AS DetailsID,BD.Amount*ISNULL(CASE WHEN BD.VersionNo = ''1.0'' THEN                                                                                                                      
  ISNULL(BD.Quantity,0)   
   ELSE  
  ISNULL(BD.Quantity,0) - ISNULL(BD.ReturnQuantity,0) END,1) AS Unit,                                                             
                                                                                                                                                     
  BD.IsReimbursable                                                       
                                            
  FROM BillingDetails BD (nolock) INNER JOIN FinalBill FB (nolock) ON FB.FinalBillID = BD.FinalBillID                                                                                           
  WHERE FB.VisitID = @pVisitID  AND BD.Status <>''Deleted''  AND BD.FeeId not in(-2,-3,-4)                                               
                                                                   
                                                                
  UNION                                                                                                                  
 SELECT 0,Amount ,''Y''                                                    
 FROM  registrationfeedetails  (nolock)                           
 WHERE patientID = @pPatientID AND VisitID = @pVisitID AND PaidYN =''N''                                                                                                                 
                                              
   UNION                                                                                                               
                                                                                         
 SELECT  BB.BookingID  AS DetailsID,                                                                                        
                                                                                                                                                    
    RTFM.Amount *(                                                                                                 
    CASE                                              
    WHEN(ISNULL(RTFM.ISVariable,''N'') =''Y'')                                                              
      THEN (ISNULL(dbo.fn_getHalfDayDateDiff(BB.FromDate,                                             
        CASE                                              
         WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                 
         ELSE BB.ToDate                                               
        END),0.5))                                                                                         
     ELSE (CONVERT(decimal(18,2),ISNULL(dbo.fn_getFullDayDateDiff(BB.FromDate,                                             
        CASE                                              
         WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                                                                                                          
         ELSE BB.ToDate                                
        END),1)))                                                              
    END ) AS Amount,''Y''                                                  
 FROM BedBooking BB (nolock) INNER JOIN BedMaster BM (nolock) ON BM.BedID = BB.BedID                                                                                                                                 
   INNER JOIN RoomMaster RM (nolock) ON RM.RoomID = BM.RoomID                                                                             
   INNER JOIN RoomType RT (nolock) ON RT.RoomTypeID = RM.RoomTypeID                                               
   INNER JOIN RoomTypeFeeMapping RTFM (nolock) ON RTFM.RoomTypeID = RT.RoomTypeID                    
   INNER JOIN RoomFeeType RFT (nolock) ON RFT.FeeID=RTFM.FeeID    
   INNER JOIN VisitClientMapping vc (nolock) on vc.VisitID=BB.VisitID and vc. OrgID=@orgID  and VC.ClientID=BB.ClientID     AND RTFM.RateID=vc.RateID                       
 WHERE BB.VisitID =@pVisitID                                                  
   AND BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )                                                                                            
   AND BB.BookingID NOT IN (Select Feeid from PatientDueChart (nolock) where VisitID=@pVisitID AND FeeType=''ROM'' UNION                                                    
     Select Feeid from BillingDetails (nolock) where FinalBillID=@pFinalBillID)                    
                                
     DECLARE @pTotal AS DECIMAL(18,2)                                                                
     SELECT @pTotal = SUM(Amount) FROM @pTempAmount                           
                             
                            
 SELECT @pTotal=ISNULL(SUM(Amount),0) FROM @pTempAmount                          
 SELECT @Reimbursable=ISNULL(SUM(Amount),0) FROM @pTempAmount  WHERE IsReimbursable=''Y''                        
 SELECT @NonReimbursable=ISNULL(SUM(Amount),0)  FROM @pTempAmount  WHERE IsReimbursable=''N''                    
                   
   DECLARE @LabConfig int                
   SELECT @LabConfig = ISNULL( COM.ConfigValue,0)  from ConfigKeyMaster CKM (nolock) INNER JOIN ConfigOrgMaster COM  (nolock)   
   ON COM.ConfigKeyID=CKM.ConfigKeyID where CKM.ConfigKey=''TPAFORLAB'' and COM.OrgID=@orgID                    
                    
  IF(@LabConfig =1)                                                               
  BEGIN                                                               
  SELECT @pTotalBilledAmount = [dbo].[GetTPAbalanceLab] (@pVisitID,@pPatientID,@pFinalBillID,@orgID,@pAmountType)                  
  END                                                       
  ELSE IF(@pAmountType =''GROSS'')                                               
  BEGIN                                 
    SELECT @pTotalBilledAmount =   ISNULL(@pTotal,0)                     
  END                                                                 
  ELSE  IF(@pAmountType =''TPAGB'')                                                               
   BEGIN                     
   SELECT @pTotalBilledAmount = @Reimbursable                       
    -- SELECT @pTotalBilledAmount = @Reimbursable-ISNULL(@pServiceCharge,0)-ISNULL(@pPatientDiscount,0)                        
   END                                               
  ELSE  IF(@pAmountType =''NET'')                                                               
   BEGIN                                                               
  SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0) +ISNULL(@pTotalDue,0)-ISNULL(@pPatientDiscount,0)),0)                        
   END                                                              
    ELSE  IF(@pAmountType =''DUE'')                    
   BEGIN                                                               
  SELECT @pTotalBilledAmount = ISNULL( (ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)+ISNULL(@pTotalDue,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0))-ISNULL(@pPatientDiscount,0),0)               
             
   END                                           
 ELSE  IF(@pAmountType =''RECEIVED'')                                                               
  BEGIN                                  
  SELECT @pTotalBilledAmount = ISNULL( ISNULL(@pTotalAdvance,0)+ISNULL(@pTotalSurgeryAdvance,0)+ISNULL(@pTotalReceived,0),0)                                                               
  END                     
  ELSE  IF(@pAmountType =''NONMEDICAL'')                                                               
  BEGIN                                                               
  SELECT @pTotalBilledAmount = ISNULL(@NonReimbursable,0)                    
  END                  
 RETURN(@pTotalBilledAmount)                                                              
                                                                    
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAbalanceAll]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAbalanceAll]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'/*---------------------------------------------------------------------------------------------------------------------------------  
File Header Comments                 
=======================================================================================                
 Copyright (C) 2007-2012 Attune Technologies, Adyar, Chennai                
========================================================================================                
 Purpose: Function to get the All Balance (due) for IP Patient  
 Author: <CODER NAME>                
 Date Created: <DATE>                
========================================================================================                
 File Change History (to be updated everytime this file is modified)                
 ---------------------------------------------------------------------------------------                
Date: 23-Apr-2012  
Author: Subramaniyan S  
Fix: Performance improvement.   
  1. This function is an enhancement of GetTPAbalance Function.Based on VisitId,it returns balance amounts (TPAGBN,NonMedical,Due,Received etc)
	 as table value. 
  2. Better performance achieved since single call of the function gives balance amounts of all amount types.In pSaveIPFinalBill and pUpdateIPFinalBill
	 Multiple calls to the GetTPAbalance is changed to single call of GetTPAbalanceAll
       
----------------------------------------------------------------------------------------------------------------------------------- */    
      
            
CREATE FUNCTION [dbo].[GetTPAbalanceAll]        --SELECT [dbo].[GetTPAbalance] (49351,''TPAGB'')                                         
(                                          
 @pVisitID bigint                                               
)     
Returns @Balancetemp Table(
amounttype  nvarchar(25),
amount   decimal(18,2)
)
AS                                                                 
BEGIN                                                                 
 DECLARE @pBalance decimal(18,2);                                                                 
 SET @pBalance =0;                                                                 
                                                            
 DECLARE @pTotalAdvance DECIMAL(18,2);                                                                 
 DECLARE @pTotalSurgeryAdvance DECIMAL(18,2);                                                                 
 DECLARE @pTotalReceived DECIMAL(18,2);                                                                 
 DECLARE @pTotalDue DECIMAL(18,2);                                                                 
 DECLARE @pPreviousRefund DECIMAL(18,2);                                                                 
 DECLARE @pTotalSurgeryAmount DECIMAL(18,2);                                                                 
 DECLARE @pPatientID  BIGINT;                                                                 
 DECLARE @pTotalBilledAmount  DECIMAL(18,2);                                                                 
 DECLARE @pServiceCharge AS DECIMAL(18,2);                                                                 
 DECLARE @orgID INT;                                                                 
 DECLARE @pFinalBillID AS BIGINT;                                                           
 DECLARE @pDiscount  DECIMAL(18,2);                                                               
 DECLARE @pPatientDiscount   DECIMAL(18,2)=0;                                                          
 DECLARE @pRoundOFF  DECIMAL(18,2);                           
 DECLARE @Reimbursable   DECIMAL(18,2);                           
 DECLARE @NonReimbursable   DECIMAL(18,2);                        
 DECLARE @PayerID INT;                                                 
                                                              
 SELECT @pPatientID = PatientID,@orgID= OrgID,@PayerID=PayerID FROM PatientVisit WHERE PatientVisitId = @pVisitID                                                                   
 SELECT @pFinalBillID = MAX(FinalBillID) FROM FINALBILL Where VisitID = @pVisitID                                         
 SELECT @pPatientDiscount=ISNULL(DiscountAmount,0),@pRoundOFF= ISNULL(roundoff,0) FROM FINALBILL Where FinalBillID = @pFinalBillID                                                               
 SELECT @pPatientDiscount = ISNULL(@pPatientDiscount,0)+(SUM(ISNULL(DiscountAmount,0))) from billingdetails where  finalbillid = @pFinalBillID                                                       
                                          
 SELECT @pTotalAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') <>''SOI''                                                                                                         
 SELECT @pTotalSurgeryAdvance = ISNULL(SUM(AdvanceAmount),0) FROM AdvancePaidDetails WHERE VisitID=@pVisitID AND ISNULL(AdvanceType,'''') = ''SOI''                                                                                                   
 SELECT @pTotalReceived = ISNULL(SUM(AmountReceived),0) FROM IPIntermediatePayments WHERE VisitID=@pVisitID                SELECT @pTotalDue = 0.00                                                     
 --SELECT @pTotalDue = ISNULL(SUM(FB.Due),0) FROM FinalBill FB INNER JOIN PatientVisit PV ON                                                              
 --FB.VisitID = PV.PatientVisitId WHERE PV.PatientID = @pPatientID  AND VisitID <>@pVisitID                                    
                                                               
 SELECT @pPreviousRefund = ISNULL(SUM(AmountRefund),0) FROM FinalBill WHERE VisitID=@pVisitID                                  
 SELECT @pTotalSurgeryAmount  = ISNULL(SUM(PD.Amount),0) FROM PatientDueChart PD                           
 INNER JOIN SurgeryBillingMaster SB ON SB.SurgeryBillingID = PD.FeeID AND PD.FeeType =''SOI''                                                                                                  
 WHERE VisitID = @pVisitID AND ISNULL(SB.IsCreditBill,''N'') = ''N''                                                                      
                                                        
 SELECT @pServiceCharge = ISNULL(ServiceCharge,0) from IPIntermediatePayments Where VisitID = @pVisitID                                                                         
 AND PaymentDetailsID = (SELECT MAX(PaymentDetailsID) FROM IPIntermediatePayments WHERE VisitID = @pVisitID)                
               
                                                            
                                                            
 ---Discount amount                                                              
                                                           
                                                             
 DECLARE @pTempAmount AS TABLE                                             
 (DetailsID BIGINT NULL,Amount Decimal(18,2) NULL,IsReimbursable nchar(5))                                                                 
                          
 INSERT INTO @pTempAmount                                              
 Select ISNULL(PD1.DetailsID,0) AS DetailsID,PD1.Amount*ISNULL(CASE WHEN PD1.VersionNo = ''1.0'' THEN                                                                                                                        
  ISNULL(PD1.unit,0)     
   ELSE    
  ISNULL(PD1.unit,0) - ISNULL(PD1.ReturnQuantity,0) END    
   ,1) AS Amount,                                                                                                                                                     
                        
 CASE  WHEN isnull(NRI.FeeID ,0)<>0                          
 THEN ''N''                          
 ELSE ''Y''                          
 END AS   IsReimbursable                                                
                                                              
 from PatientDueChart PD1                           
 LEFT JOIN NonReimbursableItems NRI                          
 on NRI.FeeID=PD1.FeeID and NRI.FeeType=PD1.FeeType and NRI.OrgID= @orgID                        
 Where PD1.VisitID=@pVisitID                                                                                                          
 AND PD1.Status in(''Pending'',''Saved'')              
                                                                                                                                   
  UNION                                                                                 
                                                                                                                                         
  SELECT ISNULL(BD.BillingDetailsID,0)AS DetailsID,BD.Amount*ISNULL(CASE WHEN BD.VersionNo = ''1.0'' THEN                                                                                                                        
  ISNULL(BD.Quantity,0)     
   ELSE    
  ISNULL(BD.Quantity,0) - ISNULL(BD.ReturnQuantity,0) END,1) AS Unit,                                                               
                                                                                                                                                       
       
 BD.IsReimbursable                                                         
                                              
  FROM BillingDetails BD INNER JOIN FinalBill FB ON FB.FinalBillID = BD.FinalBillID                                                                                         
  WHERE FB.VisitID = @pVisitID  AND BD.Status <>''Deleted''  AND BD.FeeId not in(-2,-3,-4)                                                 
          
                                                                    
                                                                  
  UNION                                                                                                                    
 SELECT 0,Amount ,''Y''                                                  
 FROM  registrationfeedetails                                                                    
 WHERE patientID = @pPatientID AND VisitID = @pVisitID AND PaidYN =''N''                                                                                                                   
                                                
   UNION                                                                                                                 
                                                                                           
 SELECT  BB.BookingID  AS DetailsID,                                                                                          
                                                                                                                                                      
    RTFM.Amount *(                                                                                                   
    CASE                                                
    WHEN(ISNULL(RTFM.ISVariable,''N'') =''Y'')                                                                
      THEN (ISNULL(dbo.fn_getHalfDayDateDiff(BB.FromDate,                                               
        CASE                                                
         WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                   
         ELSE BB.ToDate                                                 
        END),0.5))                                                                                           
     ELSE (CONVERT(decimal(18,2),ISNULL(dbo.fn_getFullDayDateDiff(BB.FromDate,                                               
        CASE                                                
         WHEN BB.FromDate > ISNULL(BB.ToDate,''01/01/1900'') THEN GETDATE()                                                                                                                            
         ELSE BB.ToDate                                  
        END),1)))                                                                
    END ) AS Amount,''Y''                                                    
 FROM BedBooking BB INNER JOIN BedMaster BM ON BM.BedID = BB.BedID                                                                                                                               
   INNER JOIN RoomMaster RM ON RM.RoomID = BM.RoomID                                                                           
   INNER JOIN RoomType RT ON RT.RoomTypeID = RM.RoomTypeID                                             
   INNER JOIN RoomTypeFeeMapping RTFM ON RTFM.RoomTypeID = RT.RoomTypeID             
   INNER JOIN RoomFeeType RFT ON RFT.FeeID=RTFM.FeeID  
   INNER JOIN VisitClientMapping vc on vc.VisitID=bb.VisitID and vc.ClientID=bb. ClientID    AND RTFM.RateID=vc.RateID                             
 WHERE BB.VisitID =@pVisitID                                                
   AND BB.Status IN (''Occupied'' ,''Transfered'',''Discharged'' )                                                                                              
   AND BB.BookingID NOT IN (Select Feeid from PatientDueChart where VisitID=@pVisitID AND FeeType=''ROM'' UNION                                                  
     Select Feeid from BillingDetails where FinalBillID=@pFinalBillID)                  
                              
     DECLARE @pTotal AS DECIMAL(18,2)                                                                  
     SELECT @pTotal = SUM(Amount) FROM @pTempAmount                             
                               
                              
 SELECT @pTotal=ISNULL(SUM(Amount),0) FROM @pTempAmount                            
 SELECT @Reimbursable=ISNULL(SUM(Amount),0) FROM @pTempAmount  WHERE IsReimbursable=''Y''                          
 SELECT @NonReimbursable=ISNULL(SUM(Amount),0)  FROM @pTempAmount  WHERE IsReimbursable=''N''                      
                     
   DECLARE @LabConfig int                  
   SELECT @LabConfig = ISNULL( COM.ConfigValue,0)  from ConfigKeyMaster CKM INNER JOIN ConfigOrgMaster COM ON COM.ConfigKeyID=CKM.ConfigKeyID where CKM.ConfigKey=''TPAFORLAB'' and COM.OrgID=@orgID                  
                  
   
 insert into @Balancetemp values(''GROSS'', isnull(@pTotal,0))                               
 insert into @Balancetemp values (''TPAGB'',ISNULL(@Reimbursable,0))   
 insert into @Balancetemp values (''NET'',ISNULL((ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)-ISNULL(@pPatientDiscount,0)),0)) 
 insert into @Balancetemp values (''DUE'',ISNULL((ISNULL(@pTotal,0)+ISNULL(@pServiceCharge,0)+ISNULL(@pRoundOFF,0)-ISNULL(@pTotalAdvance,0)-ISNULL(@pTotalSurgeryAdvance,0)-ISNULL(@pTotalReceived,0))-ISNULL(@pPatientDiscount,0),0))
 insert into @Balancetemp values (''RECEIVED'',ISNULL( ISNULL(@pTotalAdvance,0)+ISNULL(@pTotalSurgeryAdvance,0)+ISNULL(@pTotalReceived,0),0))
 insert into @Balancetemp values (''NONMEDICAL'',ISNULL(@NonReimbursable,0))   

 
                         
 	
                                                  
 RETURN;                                                              
                                                                      
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAbalanceLab]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAbalanceLab]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetTPAbalanceLab]  
(  
 @pVisitID bigint,  
 @pPatientID bigint,  
 @pFinalBillID bigint,   
 @POrgID int,                             
 @pAmountType nvarchar(10)  
)      
 RETURNS DECIMAL(18,2)                                               
WITH EXECUTE AS CALLER                                 
AS                                                
BEGIN    
 DECLARE @pTotalBilledAmount  DECIMAL(18,2);  
 IF(@pAmountType=''GROSS'')  
 BEGIN  
       SELECT @pTotalBilledAmount = ISNULL((SELECT NetValue  FROM FinalBill WHERE FinalBillID=@pFinalBillID and PatientID= @pPatientID),0)   
 END   
 IF(@pAmountType=''TPAGB'')  
 BEGIN   
        SELECT @pTotalBilledAmount = ISNULL((SELECT Amount FROM TPAPayments where FinalBillID=@pFinalBillID and VisitID =@pVisitID and OrgID=@POrgID),0)    
 END         
  
RETURN(@pTotalBilledAmount);   
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[GetTPAPaymentDetails]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTPAPaymentDetails]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[GetTPAPaymentDetails]                 
(           
 @pVisitID bigint          
          
)                
RETURNS NVARCHAR(MAX)                                  
WITH EXECUTE AS CALLER                                  
AS                                  
BEGIN    

 --select dbo.[GetTPAPaymentDetails](36075)                                     
 
  DECLARE @pResult AS NVARCHAR(MAX)  
 
  DECLARE @payDetails as Table        
  (        
	 RowID bigint,        
	 TPAAmount nvarchar(100),
	 PaymentType nvarchar(100),
	 TDSAmount nvarchar(100),
	 PaymentMode nvarchar(100),
	 PaidDate nvarchar(100)
  )
  
  INSERT INTO @payDetails         
  SELECT ROW_NUMBER() OVER(ORDER BY TPA.VisitID) AS RowID, CONVERT(nvarchar,TPA.Amount)      
  ,CONVERT(nvarchar,CASE TPA.TypeID WHEN 2 THEN ''Cheque'' ELSE ''DemandDraft'' END) AS Type       
  ,CONVERT(nvarchar,TPA.TDS)        
  ,CONVERT(nvarchar,TPA.BankNameorCardType) + ''-'' +  CONVERT(nvarchar,TPA.ChequeorCardNumber) AS Paymode      
  ,CONVERT(nvarchar,TPA.CreatedAt,103)       
  from TPAPayments TPA with(nolock) where TPA.VisitID =  @pVisitID
  
  DECLARE @intFlag INT          
  DECLARE @pCount AS INT         
  DECLARE @pTempData AS NVARCHAR(MAX) 
  DECLARE @pTable AS NVARCHAR(MAX) 
  DECLARE @pTableRow AS NVARCHAR(MAX) 
  SET @intFlag = 1    
  
  SELECT @pCount = COUNT(*) from @payDetails
 
  
  IF(@pCount>0)    
  BEGIN  
	 SELECT @pTable= ''<table width="100%" border = "1" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:10px;border-spacing:1px;" >''       
		 SET @pTempData=''''
		 SET @pTableRow = ''<tr> <td> TPAAmount </td> <td> Payment Type </td> <td> TDS</td> <td> Payment Mode </td> <td> Paid Date </td> </tr>''  
		 BEGIN    
		  WHILE (@intFlag <= @pCount)          
		   BEGIN        
			SELECT @pTempData = @pTempData + ''<tr> <td> ''+ TPAAmount +''</td> <td>''+ PaymentType +''</td> <td> ''+ TDSAmount +''</td> <td> ''+ PaymentMode +''</td><td> ''+ PaidDate +''</td>  </tr>''  from @payDetails Where RowID=@intFlag          
		   SET @intFlag = @intFlag + 1          
		   END     
		 END    
		  SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>'' 
  END

    
 --select @pResult = CONVERT(nvarchar,TPA.Amount) + ''-'' + CONVERT(nvarchar,CASE TPA.TypeID WHEN 2 THEN ''Cheque'' ELSE ''DemandDraft'' END) 
	--				+ ''-'' + CONVERT(nvarchar,TPA.TDS)  + ''-'' +  CONVERT(nvarchar,TPA.ChequeorCardNumber) + ''-'' + 
	--				 CONVERT(nvarchar,TPA.BankNameorCardType) + ''-''  + CONVERT(nvarchar,TPA.CreatedAt,103)
 -- from TPAPayments TPA where TPA.VisitID = @pVisitID   
  
  
 
  RETURN @pResult          
    
           
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[getunitcost]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getunitcost]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[getunitcost](@PID BIGINT ,@Bno nvarchar(50),@locationid int) RETURNS DECIMAL(18,2)  
AS  
BEGIN  
DECLARE @unitPrice DECIMAL(18,2)  
SELECT @unitPrice=UnitPrice FROM StockReceivedDetails where ProductId=@PID and BatchNo=COALESCE(@Bno,BatchNo) and LocationID=@locationid and isnull(UnitPrice,0)<>0
  
  
RETURN @unitPrice  
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[HasChild]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasChild]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[HasChild] (@nodeID int)
RETURNS int
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @cnt int;
     SET @cnt=0;
     IF EXISTS(SELECT ExaminationID FROM Examination where ParentID = @nodeID)
     BEGIN
     SET @cnt=1;
     END
     
     RETURN(@cnt);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[HasChildExamination]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasChildExamination]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[HasChildExamination] (@nodeID int)
RETURNS int
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @cnt int;
     SET @cnt=0;
     IF EXISTS(SELECT ExaminationID FROM Examination where ParentID = @nodeID)
     BEGIN
     SET @cnt=1;
     END
     
     RETURN(@cnt);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[HasChildHistory]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasChildHistory]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[HasChildHistory] (@nodeID int)
RETURNS int
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @cnt int;
     SET @cnt=0;
     IF EXISTS(SELECT HistoryID FROM History where ParentID = @nodeID)
     BEGIN
     SET @cnt=1;
     END
     
     RETURN(@cnt);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[InitCap]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InitCap]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[InitCap] ( @InputString nvarchar(4000) )
RETURNS nvarchar(4000)
AS
BEGIN

	DECLARE @Index          INT
	DECLARE @nchar           nchar(1)
	DECLARE @PrevChar       nchar(1)
	DECLARE @OutputString   nvarchar(255)

	SET @OutputString = LOWER(@InputString)
	SET @Index = 1

	WHILE @Index <= LEN(@InputString)
	BEGIN
		SET @nchar     = SUBSTRING(@InputString, @Index, 1)
		SET @PrevChar = CASE WHEN @Index = 1 THEN '' ''
							 ELSE SUBSTRING(@InputString, @Index - 1, 1)
						END

		IF @PrevChar IN ('' '', '';'', '':'', ''!'', ''?'', '','', ''.'', ''_'', ''-'', ''/'', ''&'', '''''''', ''('')
		BEGIN
			IF @PrevChar != '''''''' OR UPPER(@nchar) != ''S''
				SET @OutputString = STUFF(@OutputString, @Index, 1, UPPER(@nchar))
		END

		SET @Index = @Index + 1
	END

	RETURN @OutputString

END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[InitialCap]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InitialCap]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create FUNCTION [dbo].[InitialCap](@String nvarchar(max))
RETURNS nvarchar(max)
AS
 BEGIN 
	DECLARE @Position INT;
	SELECT @String   = STUFF(LOWER(@String),1,1,UPPER(LEFT(@String,1))) COLLATE Latin1_General_Bin,
                    @Position = PATINDEX(''%[^A-Za-z''''][a-z]%'',@String COLLATE Latin1_General_Bin);
					WHILE @Position > 0
    SELECT @String   = STUFF(@String,@Position,2,UPPER(SUBSTRING(@String,@Position,2))) COLLATE Latin1_General_Bin,
                    @Position = PATINDEX(''%[^A-Za-z''''][a-z]%'',@String COLLATE Latin1_General_Bin);
    RETURN @String;
 END ;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[InvoiceBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[InvoiceBillDescription]                  
(                  
 @FinalBillID bigint,                  
 @VisitID bigint,                  
 @Type nvarchar(20),                  
 @ReceiptNo nvarchar(30),                  
 @pOrgID int ,      
 @pClientID bigint                
)         
-- exec InvoiceBillDescription   @FinalBillID=4,@VisitID=0,@Type=''Bill'',@ReceiptNo='''',@pOrgID=67,@pClientID=91             
RETURNS NVARCHAR(MAX)                                                      
WITH EXECUTE AS CALLER                                                      
AS                                                      
BEGIN                   
                    
 DECLARE @pResult AS NVARCHAR(MAX)                      
                     
 DECLARE @FeeDescription as Table                            
 (                            
  RowID bigint,       
  ServiceCode nvarchar(10),                          
  BilledFor nvarchar(100),                  
  Quanity nvarchar(100),                  
  Amount nvarchar(100),                  
  BilledAmt nvarchar(100)                
 )                    
 DECLARE @intFlag INT                              
 DECLARE @pCount AS INT                             
 DECLARE @pTempData AS NVARCHAR(MAX)                     
 DECLARE @pTable AS NVARCHAR(MAX)                     
 DECLARE @pTableRow AS NVARCHAR(MAX)                     
 SET @intFlag = 1                        
                
    Declare @TranferRate nvarchar(2)    
 select @TranferRate=TransferRate  from InvClientMaster where ClientID=@pClientID     
 if(ISNULL(@TranferRate,'''')='''') SET @TranferRate=''N''    
 IF @Type = ''Bill''                   
  BEGIN                  
    if(@TranferRate <> ''Y'')          
     BEGIN                  
  INSERT INTO @FeeDescription                             
   SELECT ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, ISNULL(CMS.SCode,'''') ServiceCode,BD.FeeDescription,CONVERT(nvarchar,BD.Quantity),CONVERT(nvarchar,BD.Amount)                  
   ,CONVERT(nvarchar,SUM(convert(decimal(18,2),BD.Quantity * BD.Amount)))               
   FROM BillingDetails BD
          left join AmountRefundDetails ARD WITH (NOLOCK) ON BD.BillingDetailsID=ARD.BillingDetailsID 
   Left Join ClientMappingService CMS on CMS.FeeID=BD.FeeId and 
   CMS.ClientId=@pClientID and CMS.ReferenceType=''SC'' AND BD.FeeType IN(''INV'',''GRP'',''PKG'') 
        
   WHERE BD.FinalBillID = @FinalBillID and isnull(ARD.BillStatus,'''')not in (''CANCELLED'')   
                   
   GROUP BY BD.FinalBillID,CMS.SCode,FeeDescription,BD.Quantity,BD.FeeType,BD.Amount                   
    end    
    else    
    begin    
        
      INSERT INTO @FeeDescription                               
    SELECT ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, ISNULL(CMS.SCode,'''') ServiceCode,BD.FeeDescription,CONVERT(nvarchar,BD.Quantity),CONVERT(nvarchar,BD.TransferAmount)                    
    ,CONVERT(nvarchar,SUM(convert(decimal(18,2),BD.Quantity * BD.TransferAmount )))                 
    FROM BillingDetails BD  
    left join AmountRefundDetails ARD WITH (NOLOCK) ON BD.BillingDetailsID=ARD.BillingDetailsID        
    Left Join ClientMappingService CMS on CMS.FeeID=BD.FeeId and CMS.ClientId=@pClientID and CMS.ReferenceType=''SC'' AND BD.FeeType IN(''INV'',''GRP'',''PKG'')         
    WHERE BD.FinalBillID = @FinalBillID  and isnull(ARD.BillStatus,'''')not in (''CANCELLED'')   
    GROUP BY BD.FinalBillID,CMS.SCode,FeeDescription,BD.Quantity,BD.FeeType,TransferAmount      
        
    end       
                  
  SELECT @pCount = COUNT(*) from @FeeDescription                    
                  
  IF(@pCount>0)                        
  BEGIN                      
   SELECT @pTable= ''<table width="100%" border = "0" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:12px;border-spacing:1px;" >''                           
   SET @pTempData=''''                    
   SET @pTableRow = ''<tr> <th> </th> <th> </td> </tr>''                      
  BEGIN                        
   WHILE (@intFlag <= @pCount)                              
    BEGIN                    
    SELECT @pTempData = @pTempData + ''<tr> <td> ''+ ServiceCode + ''</td> <td>'' +  BilledFor +''</td> <td align="right"> ''+ BilledAmt +''</td></tr>''                    
    from @FeeDescription Where RowID=@intFlag                              
SET @intFlag = @intFlag + 1                              
   END                         
  END                        
   SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''                     
  END                    
  END                  
                     
  RETURN @pResult                     
                    
END  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[InvoiceWatersBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceWatersBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[InvoiceWatersBillDescription]                  
(                  
 @FinalBillID bigint,                  
 @VisitID bigint,                  
 @Type nvarchar(20),                  
 @ReceiptNo nvarchar(30),                  
 @pOrgID int ,      
 @pClientID bigint                
)
RETURNS NVARCHAR(MAX)                                                      
WITH EXECUTE AS CALLER                                                      
AS                                                      
BEGIN                   
                    
 DECLARE @pResult AS NVARCHAR(MAX)                      
                     
 DECLARE @FeeDescription as Table                            
 (                            
  RowID bigint,       
  ServiceCode nvarchar(10),                          
  BilledFor nvarchar(100),                  
  Quanity nvarchar(100),                  
  Amount nvarchar(100),                  
  BilledAmt nvarchar(100)                
 )                    
 DECLARE @intFlag INT                              
 DECLARE @pCount AS INT                             
 DECLARE @pTempData AS NVARCHAR(MAX)                     
 DECLARE @pTable AS NVARCHAR(MAX)                     
 DECLARE @pTableRow AS NVARCHAR(MAX)                     
 SET @intFlag = 1                        
                
    Declare @TranferRate nvarchar(2)    
 select @TranferRate=TransferRate  from InvClientMaster where ClientID=@pClientID     
 if(ISNULL(@TranferRate,'''')='''') SET @TranferRate=''N''    
 IF @Type = ''Bill''                   
  BEGIN                  
    if(@TranferRate <> ''Y'')          
     BEGIN                  
  INSERT INTO @FeeDescription                             
   SELECT ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, ISNULL(CMS.SCode,'''') ServiceCode, BD.FeeDescription+''-''+PQI.SampleTypeID+''-''+CONVERT(nvarchar,BD.Quantity) ,CONVERT(nvarchar,BD.Quantity),CONVERT(nvarchar,BD.Amount)                  
   ,CONVERT(nvarchar,BD.Rate)               
   FROM BillingDetails  BD  inner join  FinalBill FB on FB.FinalBillID=BD.FinalBillID and FB.OrgID=BD.OrgID
   inner join PreQuotationInvestigations PQI on  PQI.visitID=FB.VisitID and (PQI.ID=BD.FeeId OR PQI.PkgID=BD.FeeId) and PQI.OrgID=BD.OrgID
          left join AmountRefundDetails ARD WITH (NOLOCK) ON BD.BillingDetailsID=ARD.BillingDetailsID 
   Left Join ClientMappingService CMS on CMS.FeeID=BD.FeeId and 
   CMS.ClientId=@pClientID and CMS.ReferenceType=''SC'' AND BD.FeeType IN(''INV'',''GRP'',''PKG'') 
        
   WHERE BD.FinalBillID = @FinalBillID and isnull(ARD.BillStatus,'''')not in (''CANCELLED'')   
                   
   GROUP BY BD.FinalBillID,CMS.SCode,FeeDescription,BD.Quantity,BD.FeeType,BD.Amount,PQI.SampleTypeID,BD.Rate   
   
   
   
    end    
    else    
    begin    
        
      INSERT INTO @FeeDescription                               
    SELECT ROW_NUMBER() OVER(ORDER BY BD.FinalBillID) AS RowID, ISNULL(CMS.SCode,'''') ServiceCode,BD.FeeDescription,CONVERT(nvarchar,BD.Quantity),CONVERT(nvarchar,BD.TransferAmount)                    
    ,CONVERT(nvarchar,BD.Rate)               
    FROM BillingDetails BD  
    left join AmountRefundDetails ARD WITH (NOLOCK) ON BD.BillingDetailsID=ARD.BillingDetailsID        
    Left Join ClientMappingService CMS on CMS.FeeID=BD.FeeId and CMS.ClientId=@pClientID and CMS.ReferenceType=''SC'' AND BD.FeeType IN(''INV'',''GRP'',''PKG'')         
    WHERE BD.FinalBillID = @FinalBillID  and isnull(ARD.BillStatus,'''')not in (''CANCELLED'')   
    GROUP BY BD.FinalBillID,CMS.SCode,FeeDescription,BD.Quantity,BD.FeeType,TransferAmount,BD.Rate      
    
    end    
	
	              
  SELECT @pCount = COUNT(*) from @FeeDescription                    
                  
  IF(@pCount>0)                        
  BEGIN                      
   SELECT @pTable= ''<table width="100%" border = "0" class="dataheaderInvCtrl" style="border:solid 1px block;font-size:12px;border-spacing:1px;" >''                           
   SET @pTempData=''''                    
   SET @pTableRow = ''<tr> <th> </th> <th> </td> </tr>''                      
  BEGIN                        
   WHILE (@intFlag <= @pCount)                              
    BEGIN                    
    SELECT @pTempData = @pTempData + ''<tr> <td> ''+ ServiceCode + ''</td> <td>'' +  BilledFor +''</td> <td align="right"> ''+ BilledAmt +''</td></tr>''                    
    from @FeeDescription Where RowID=@intFlag                              
SET @intFlag = @intFlag + 1                              
   END                         
  END                        
   SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table>''                     
  END                    
  END                  
                     
  RETURN @pResult                     
                    
END  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[IsAllowed]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsAllowed]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[IsAllowed] (@input VARCHAR(MAX)) RETURNS BIT
-- Returns 1 if string is allowed, 0 otherwise.
-- Usages: SELECT dbo.IsAllowed(''Hello''); -- returns 1
--         SELECT dbo.IsAllowed(''Hello, world!''); -- returns 0
-- Note CHARINDEX is not case sensitive so @allowables doesn''t need both.
--      VARCHAR(MAX) is different under SQL Server 2005 than 2008+
---     and use of defined VARCHAR size might be necessary.
AS
BEGIN
  DECLARE @allowables char(29) = ''abcdefghijklmnopqrstuvwxyz- _'';
  DECLARE @allowed int = 0; 
  DECLARE @index int = 1;
  WHILE @index <= LEN(@input)
    BEGIN
    IF CHARINDEX(SUBSTRING(@input,@index,1),@allowables)=0
      BEGIN
      SET @allowed = 0;
      BREAK;
      END
    ELSE
      BEGIN
      SET @allowed = 1;
      SET @index = @index+1;
      END
    END
  RETURN @allowed
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Isdeleteable]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Isdeleteable]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Isdeleteable](@pCategoryID [int])
RETURNS [nchar](1) WITH EXECUTE AS CALLER
AS 
BEGIN    
     
 DECLARE @IsDeleteable NCHAR(1)    
 DECLARE @NoActiveProduct BigInt    
 SELECT @NoActiveProduct=COUNT(*) FROM Products P INNER JOIN ProductCategories PC ON P.CategoryID=PC.CategoryID Where PC.ParentCategorieID=@pCategoryID AND ISNULL(P.IsDeleted,''N'')!=''Y''
 IF(@NoActiveProduct>0)    
  set @IsDeleteable=''N''    
  Else    
   set @IsDeleteable=''Y''    
    
 RETURN @IsDeleteable    
    
END    


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[mydbr_style]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mydbr_style]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create function [dbo].[mydbr_style]( @inStyle nvarchar(150) )
returns nvarchar(400) 
as
begin
declare @vRet nvarchar(400)

select @vRet = definition
from mydbr_styles
where name = @inStyle

return @vRet
end


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWords]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWords]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N' CREATE FUNCTION [dbo].[NumbertToWords] (        
 @Number Numeric (38,0) -- Input number with as many as 18 digits        
 ) RETURNS nvarchar(max)        
 AS BEGIN        
 DECLARE @inputNumber nvarchar(38)        
 DECLARE @NumbersTable TABLE (number nchar(2), word nvarchar(10))        
 DECLARE @outputString nvarchar(4000)        
 DECLARE @length INT ,@counter INT, @loops INT, @position INT        
 DECLARE @chunk nchar(3) -- for chunks of 3 numbers        
 DECLARE @tensones nchar(2),@hundreds nchar(1), @tens nchar(1), @ones nchar(1)        
 IF @Number = 0 Return ''ZERO''        
 IF @Number< 0
 BEGIN  
 SELECT @Number=@Number*(-1)
 END
 -- initialize the variables        
 SELECT @inputNumber = CONVERT(nvarchar(38), @Number)        
 , @outputString = ''''        
 , @counter = 1        
 SELECT @length = LEN(@inputNumber)        
 , @position = LEN(@inputNumber) - 2        
 , @loops = LEN(@inputNumber)/3        
 -- make sure there is an extra loop added for the remaining numbers        
 IF LEN(@inputNumber) % 3 <> 0 SET @loops = @loops + 1        
 -- insert data for the numbers and words        
 INSERT INTO @NumbersTable SELECT ''00'', ''''        
 UNION ALL SELECT ''01'', ''ONE'' UNION ALL SELECT ''02'', ''TWO''        
 UNION ALL SELECT ''03'', ''THREE'' UNION ALL SELECT ''04'', ''FOUR''        
 UNION ALL SELECT ''05'', ''FIVE'' UNION ALL SELECT ''06'', ''SIX''        
 UNION ALL SELECT ''07'', ''SEVEN'' UNION ALL SELECT ''08'', ''EIGHT''        
 UNION ALL SELECT ''09'', ''NINE'' UNION ALL SELECT ''10'', ''TEN''        
 UNION ALL SELECT ''11'', ''ELEVEN'' UNION ALL SELECT ''12'', ''TWELVE''        
 UNION ALL SELECT ''13'', ''THIRTEEN'' UNION ALL SELECT ''14'', ''FOURTEEN''        
 UNION ALL SELECT ''15'', ''FIFTEEN'' UNION ALL SELECT ''16'', ''SIXTEEN''        
 UNION ALL SELECT ''17'', ''SEVENTEEN'' UNION ALL SELECT ''18'', ''EIGHTEEN''        
 UNION ALL SELECT ''19'', ''NINETEEN'' UNION ALL SELECT ''20'', ''TWENTY''        
 UNION ALL SELECT ''30'', ''THIRTY'' UNION ALL SELECT ''40'', ''FORTY''        
 UNION ALL SELECT ''50'', ''FIFTY'' UNION ALL SELECT ''60'', ''SIXTY''        
 UNION ALL SELECT ''70'', ''SEVENTY'' UNION ALL SELECT ''80'', ''EIGHTY''        
 UNION ALL SELECT ''90'', ''NINETY''        
 WHILE @counter <= @loops BEGIN        
 -- get chunks of 3 numbers at a time, padded with leading zeros        
 SET @chunk = RIGHT(''000'' + SUBSTRING(@inputNumber, @position, 3), 3)        
 IF @chunk <> ''000'' BEGIN        
 SELECT @tensones = SUBSTRING(@chunk, 2, 2)        
 , @hundreds = SUBSTRING(@chunk, 1, 1)        
 , @tens = SUBSTRING(@chunk, 2, 1)        
 , @ones = SUBSTRING(@chunk, 3, 1)        
 -- If twenty or less, use the word directly from @NumbersTable        
 IF CONVERT(INT, @tensones) <= 20 OR @Ones=''0'' BEGIN        
 SET @outputString = (SELECT word        
 FROM @NumbersTable        
 WHERE @tensones = number)        
 + CASE @counter WHEN 1 THEN '''' -- No name        
 WHEN 2 THEN '' THOUSAND '' WHEN 3 THEN '' MILLION ''        
 WHEN 4 THEN '' BILLION '' WHEN 5 THEN '' TRILLION ''        
 WHEN 6 THEN '' QUADRILLION '' WHEN 7 THEN '' QUINTILLION ''        
 WHEN 8 THEN '' SIXTILLION '' WHEN 9 THEN '' SEPTILLION ''        
 WHEN 10 THEN '' OCTILLION '' WHEN 11 THEN '' NONILLION ''        
 WHEN 12 THEN '' DECILLION '' WHEN 13 THEN '' UNDECILLION ''        
 ELSE '''' END        
 + @outputString        
 END        
 ELSE BEGIN -- break down the ones and the tens separately        
 SET @outputString = '' ''        
 + (SELECT word        
 FROM @NumbersTable        
 WHERE @tens + ''0'' = number)        
 + ''-''        
 + (SELECT word        
 FROM @NumbersTable        
 WHERE ''0''+ @ones = number)        
 + CASE @counter WHEN 1 THEN '''' -- No name        
 WHEN 2 THEN '' THOUSAND '' WHEN 3 THEN '' MILLION ''        
 WHEN 4 THEN '' BILLION '' WHEN 5 THEN '' TRILLION ''        
 WHEN 6 THEN '' QUADRILLION '' WHEN 7 THEN '' QUINTILLION ''        
 WHEN 8 THEN '' SIXTILLION '' WHEN 9 THEN '' SEPTILLION ''        
 WHEN 10 THEN '' OCTILLION '' WHEN 11 THEN '' NONILLION ''        
 WHEN 12 THEN '' DECILLION '' WHEN 13 THEN '' UNDECILLION ''        
 ELSE '''' END        
 + @outputString        
 END        
 -- now get the hundreds        
 IF @hundreds <> ''0'' BEGIN   
 SET @outputString = (SELECT word        
 FROM @NumbersTable        
 WHERE ''0'' + @hundreds = number)        
 + CASE WHEN @outputString='''' THEN '' HUNDRED '' when @outputString <>'''' and @counter=1 
 then'' HUNDRED AND ''
 else '' LAKHS ''
 END      
 + @outputString        
 END        
 END        
 SELECT @counter = @counter + 1        
 , @position = @position - 3        
 END        
 -- Remove any double spaces        
 SET @outputString = LTRIM(RTRIM(REPLACE(@outputString, '' '', '' '')))        
 SET @outputstring = UPPER(LEFT(@outputstring, 1)) + SUBSTRING(@outputstring, 2, 4000)        
 RETURN @outputString -- return the result        
 END  
 

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWords_bak]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWords_bak]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N' CREATE FUNCTION [dbo].[NumbertToWords_bak] (        
 @Number Numeric (38,0) -- Input number with as many as 18 digits        
 ) RETURNS nvarchar(max)        
 AS BEGIN        
 DECLARE @inputNumber nvarchar(38)        
 DECLARE @NumbersTable TABLE (number nchar(2), word nvarchar(10))        
 DECLARE @outputString nvarchar(4000)        
 DECLARE @length INT ,@counter INT, @loops INT, @position INT        
 DECLARE @chunk nchar(3) -- for chunks of 3 numbers        
 DECLARE @tensones nchar(2),@hundreds nchar(1), @tens nchar(1), @ones nchar(1)        
 IF @Number = 0 Return ''ZERO''        
 IF @Number< 0
 BEGIN  
 SELECT @Number=@Number*(-1)
 END
 -- initialize the variables        
 SELECT @inputNumber = CONVERT(nvarchar(38), @Number)        
 , @outputString = ''''        
 , @counter = 1        
 SELECT @length = LEN(@inputNumber)        
 , @position = LEN(@inputNumber) - 2        
 , @loops = LEN(@inputNumber)/3        
 -- make sure there is an extra loop added for the remaining numbers        
 IF LEN(@inputNumber) % 3 <> 0 SET @loops = @loops + 1        
 -- insert data for the numbers and words        
 INSERT INTO @NumbersTable SELECT ''00'', ''''        
 UNION ALL SELECT ''01'', ''ONE'' UNION ALL SELECT ''02'', ''TWO''        
 UNION ALL SELECT ''03'', ''THREE'' UNION ALL SELECT ''04'', ''FOUR''        
 UNION ALL SELECT ''05'', ''FIVE'' UNION ALL SELECT ''06'', ''SIX''        
 UNION ALL SELECT ''07'', ''SEVEN'' UNION ALL SELECT ''08'', ''EIGHT''        
 UNION ALL SELECT ''09'', ''NINE'' UNION ALL SELECT ''10'', ''TEN''        
 UNION ALL SELECT ''11'', ''ELEVEN'' UNION ALL SELECT ''12'', ''TWELVE''        
 UNION ALL SELECT ''13'', ''THIRTEEN'' UNION ALL SELECT ''14'', ''FOURTEEN''        
 UNION ALL SELECT ''15'', ''FIFTEEN'' UNION ALL SELECT ''16'', ''SIXTEEN''        
 UNION ALL SELECT ''17'', ''SEVENTEEN'' UNION ALL SELECT ''18'', ''EIGHTEEN''        
 UNION ALL SELECT ''19'', ''NINETEEN'' UNION ALL SELECT ''20'', ''TWENTY''        
 UNION ALL SELECT ''30'', ''THIRTY'' UNION ALL SELECT ''40'', ''FORTY''        
 UNION ALL SELECT ''50'', ''FIFTY'' UNION ALL SELECT ''60'', ''SIXTY''        
 UNION ALL SELECT ''70'', ''SEVENTY'' UNION ALL SELECT ''80'', ''EIGHTY''        
 UNION ALL SELECT ''90'', ''NINETY''        
 WHILE @counter <= @loops BEGIN        
 -- get chunks of 3 numbers at a time, padded with leading zeros        
 SET @chunk = RIGHT(''000'' + SUBSTRING(@inputNumber, @position, 3), 3)        
 IF @chunk <> ''000'' BEGIN        
 SELECT @tensones = SUBSTRING(@chunk, 2, 2)        
 , @hundreds = SUBSTRING(@chunk, 1, 1)        
 , @tens = SUBSTRING(@chunk, 2, 1)        
 , @ones = SUBSTRING(@chunk, 3, 1)        
 -- If twenty or less, use the word directly from @NumbersTable        
 IF CONVERT(INT, @tensones) <= 20 OR @Ones=''0'' BEGIN        
 SET @outputString = (SELECT word        
 FROM @NumbersTable        
 WHERE @tensones = number)        
 + CASE @counter WHEN 1 THEN '''' -- No name        
 WHEN 2 THEN '' THOUSAND '' WHEN 3 THEN '' MILLION ''        
 WHEN 4 THEN '' BILLION '' WHEN 5 THEN '' TRILLION ''        
 WHEN 6 THEN '' QUADRILLION '' WHEN 7 THEN '' QUINTILLION ''        
 WHEN 8 THEN '' SIXTILLION '' WHEN 9 THEN '' SEPTILLION ''        
 WHEN 10 THEN '' OCTILLION '' WHEN 11 THEN '' NONILLION ''        
 WHEN 12 THEN '' DECILLION '' WHEN 13 THEN '' UNDECILLION ''        
 ELSE '''' END        
 + @outputString        
 END        
 ELSE BEGIN -- break down the ones and the tens separately        
 SET @outputString = '' ''        
 + (SELECT word        
 FROM @NumbersTable        
 WHERE @tens + ''0'' = number)        
 + ''-''        
 + (SELECT word        
 FROM @NumbersTable        
 WHERE ''0''+ @ones = number)        
 + CASE @counter WHEN 1 THEN '''' -- No name        
 WHEN 2 THEN '' THOUSAND '' WHEN 3 THEN '' MILLION ''        
 WHEN 4 THEN '' BILLION '' WHEN 5 THEN '' TRILLION ''        
 WHEN 6 THEN '' QUADRILLION '' WHEN 7 THEN '' QUINTILLION ''        
 WHEN 8 THEN '' SIXTILLION '' WHEN 9 THEN '' SEPTILLION ''        
 WHEN 10 THEN '' OCTILLION '' WHEN 11 THEN '' NONILLION ''        
 WHEN 12 THEN '' DECILLION '' WHEN 13 THEN '' UNDECILLION ''        
 ELSE '''' END        
 + @outputString        
 END        
 -- now get the hundreds        
 IF @hundreds <> ''0'' BEGIN   

 SET @outputString = (SELECT word        
 FROM @NumbersTable        
 WHERE ''0'' + @hundreds = number)        
 + CASE WHEN @outputString='''' THEN '' HUNDRED '' 
 when @outputString <>'''' and @counter=1 
 then'' HUNDRED AND ''
 else '' LAKHS ''
 END 
 + @outputString        
 END        
 END        
 SELECT @counter = @counter + 1        
 , @position = @position - 3        
 END        
 -- Remove any double spaces        
 SET @outputString = LTRIM(RTRIM(REPLACE(@outputString, '' '', '' '')))        
 SET @outputstring = UPPER(LEFT(@outputstring, 1)) + SUBSTRING(@outputstring, 2, 4000)        
 RETURN @outputString -- return the result        
 END  
 

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWords_t]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWords_t]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--select dbo.NumbertToWords_T(123456) 

CREATE FUNCTION [dbo].[NumbertToWords_t] (
	@Number NUMERIC(38, 0) -- Input number with as many as 18 digits        
	)
RETURNS NVARCHAR(max)
AS
BEGIN
	DECLARE @inputNumber NVARCHAR(38)
	DECLARE @NumbersTable TABLE (
		number NCHAR(2)
		,word NVARCHAR(10)
		)
	DECLARE @outputString NVARCHAR(4000)
	DECLARE @length INT
		,@counter INT
		,@loops INT
		,@position INT
	DECLARE @chunk NCHAR(3) -- for chunks of 3 numbers        
	DECLARE @tensones NCHAR(2)
		,@hundreds NCHAR(1)
		,@tens NCHAR(1)
		,@ones NCHAR(1)

	IF @Number = 0
		RETURN ''ZERO''

	IF @Number < 0
	BEGIN
		SELECT @Number = @Number * (- 1)
	END

	-- initialize the variables        
	SELECT @inputNumber = CONVERT(NVARCHAR(38), @Number)
		,@outputString = ''''
		,@counter = 1

	SELECT @length = LEN(@inputNumber)
		,@position = LEN(@inputNumber) - 2
		,@loops = LEN(@inputNumber) / 3

	-- make sure there is an extra loop added for the remaining numbers        
	IF LEN(@inputNumber) % 3 <> 0
		SET @loops = @loops + 1

	-- insert data for the numbers and words        
	INSERT INTO @NumbersTable
	SELECT ''00''
		,''''
	
	UNION ALL
	
	SELECT ''01''
		,''ONE''
	
	UNION ALL
	
	SELECT ''02''
		,''TWO''
	
	UNION ALL
	
	SELECT ''03''
		,''THREE''
	
	UNION ALL
	
	SELECT ''04''
		,''FOUR''
	
	UNION ALL
	
	SELECT ''05''
		,''FIVE''
	
	UNION ALL
	
	SELECT ''06''
		,''SIX''
	
	UNION ALL
	
	SELECT ''07''
		,''SEVEN''
	
	UNION ALL
	
	SELECT ''08''
		,''EIGHT''
	
	UNION ALL
	
	SELECT ''09''
		,''NINE''
	
	UNION ALL
	
	SELECT ''10''
		,''TEN''
	
	UNION ALL
	
	SELECT ''11''
		,''ELEVEN''
	
	UNION ALL
	
	SELECT ''12''
		,''TWELVE''
	
	UNION ALL
	
	SELECT ''13''
		,''THIRTEEN''
	
	UNION ALL
	
	SELECT ''14''
		,''FOURTEEN''
	
	UNION ALL
	
	SELECT ''15''
		,''FIFTEEN''
	
	UNION ALL
	
	SELECT ''16''
		,''SIXTEEN''
	
	UNION ALL
	
	SELECT ''17''
		,''SEVENTEEN''
	
	UNION ALL
	
	SELECT ''18''
		,''EIGHTEEN''
	
	UNION ALL
	
	SELECT ''19''
		,''NINETEEN''
	
	UNION ALL
	
	SELECT ''20''
		,''TWENTY''
	
	UNION ALL
	
	SELECT ''30''
		,''THIRTY''
	
	UNION ALL
	
	SELECT ''40''
		,''FORTY''
	
	UNION ALL
	
	SELECT ''50''
		,''FIFTY''
	
	UNION ALL
	
	SELECT ''60''
		,''SIXTY''
	
	UNION ALL
	
	SELECT ''70''
		,''SEVENTY''
	
	UNION ALL
	
	SELECT ''80''
		,''EIGHTY''
	
	UNION ALL
	
	SELECT ''90''
		,''NINETY''

	WHILE @counter <= @loops
	BEGIN
		-- get chunks of 3 numbers at a time, padded with leading zeros        
		SET @chunk = RIGHT(''000'' + SUBSTRING(@inputNumber, @position, 3), 3)

		IF @chunk <> ''000''
		BEGIN
			SELECT @tensones = SUBSTRING(@chunk, 2, 2)
				,@hundreds = SUBSTRING(@chunk, 1, 1)
				,@tens = SUBSTRING(@chunk, 2, 1)
				,@ones = SUBSTRING(@chunk, 3, 1)

			-- If twenty or less, use the word directly from @NumbersTable        
			IF CONVERT(INT, @tensones) <= 20
				OR @Ones = ''0''
			BEGIN
				SET @outputString = (
						SELECT word
						FROM @NumbersTable
						WHERE @tensones = number
						) + CASE @counter
						WHEN 1
							THEN '''' -- No name        
						WHEN 2
							THEN '' THOUSAND ''
						WHEN 3
							THEN '' MILLION ''
						WHEN 4
							THEN '' BILLION ''
						WHEN 5
							THEN '' TRILLION ''
						WHEN 6
							THEN '' QUADRILLION ''
						WHEN 7
							THEN '' QUINTILLION ''
						WHEN 8
							THEN '' SIXTILLION ''
						WHEN 9
							THEN '' SEPTILLION ''
						WHEN 10
							THEN '' OCTILLION ''
						WHEN 11
							THEN '' NONILLION ''
						WHEN 12
							THEN '' DECILLION ''
						WHEN 13
							THEN '' UNDECILLION ''
						ELSE ''''
						END + @outputString
			END
			ELSE
			BEGIN -- break down the ones and the tens separately        
				SET @outputString = '' '' + (
						SELECT word
						FROM @NumbersTable
						WHERE @tens + ''0'' = number
						) + ''-'' + (
						SELECT word
						FROM @NumbersTable
						WHERE ''0'' + @ones = number
						) + CASE @counter
						WHEN 1
							THEN '''' -- No name        
						WHEN 2
							THEN '' THOUSAND ''
						WHEN 3
							THEN '' MILLION ''
						WHEN 4
							THEN '' BILLION ''
						WHEN 5
							THEN '' TRILLION ''
						WHEN 6
							THEN '' QUADRILLION ''
						WHEN 7
							THEN '' QUINTILLION ''
						WHEN 8
							THEN '' SIXTILLION ''
						WHEN 9
							THEN '' SEPTILLION ''
						WHEN 10
							THEN '' OCTILLION ''
						WHEN 11
							THEN '' NONILLION ''
						WHEN 12
							THEN '' DECILLION ''
						WHEN 13
							THEN '' UNDECILLION ''
						ELSE ''''
						END + @outputString
			END

			-- now get the hundreds        
			IF @hundreds <> ''0''
			BEGIN
				SET @outputString = (
						SELECT word
						FROM @NumbersTable
						WHERE ''0'' + @hundreds = number
						) + CASE 
						WHEN @outputString = ''''
							THEN '' HUNDRED ''
						when @outputString <>'''' and @counter=1 
						then'' HUNDRED AND ''
						else '' LAKHS ''
						END + @outputString
			END
		END

		SELECT @counter = @counter + 1
			,@position = @position - 3
	END

	-- Remove any double spaces        
	SET @outputString = LTRIM(RTRIM(REPLACE(@outputString, '' '', '' '')))
	SET @outputstring = UPPER(LEFT(@outputstring, 1)) + SUBSTRING(@outputstring, 2, 4000)

	RETURN @outputString -- return the result        
END

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[pGetAmountReceivedForVisit]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetAmountReceivedForVisit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[pGetAmountReceivedForVisit] (@pFinalBillID BIGINT)
RETURNS DECIMAL(18, 2)
WITH EXECUTE AS CALLER
AS
  BEGIN
      DECLARE @pTotalReceived DECIMAL(18, 2)
      DECLARE @pTotalRefund DECIMAL(18, 2)
      DECLARE @ptempReceived DECIMAL(18, 2)
      DECLARE @ptempDepositUsed DECIMAL(18, 2)
      DECLARE @ptempTotalDuePaidAmount DECIMAL(18, 2),@DueAmount DECIMAL(18,2)
	  DECLARE @ptempBillAMount DECIMAL(18, 2),@iSFranchisee BIT

	  SELECT @iSFranchisee=ISNULL(IsFranchisee,0) FROM Finalbill (NOLOCK) WHERE FinalbillID=@pFinalBillID
      SELECT @ptempDepositUsed = Sum(Isnull(AmountUsed, 0))
      FROM   PatientDepositUsage  WITH(NOLOCK) 
      WHERE  FinalBillID = @pFinalBillID

      SELECT @ptempReceived = Sum(Isnull(AmtReceived,0))
      FROM   AmountReceivedDetails WITH(NOLOCK) 
      WHERE  FinalBillID = @pFinalBillID

      SELECT @pTotalRefund = SUM(ISNULL(Cancelamount,0))--CASE WHEN Sum(Isnull(AmtRefund,0))=0 THEN  SUM(ISNULL(Cancelamount,0)) ELSE Sum(Isnull(AmtRefund,0)) END-- -Sum(Isnull(DiscountAdjustedAmt,0))
      FROM   AmountRefundDetails  WITH(NOLOCK) 
      WHERE  FinalBillID = @pFinalBillID

      --SELECT @ptempTotalDuePaidAmount = Sum(Isnull(PaidAmount, 0))
      --FROM   duepaiddetail pdd with(nolock)
      --WHERE  pdd.DueBillNo = @pFinalBillID
	  
	  SELECT @DueAmount=SUM(ISNULL(DueAmount,0)-ISNULL(DuePaidAmt,0)-ISNULL(DiscountAmt,0)-ISNULL(RefundedAmount,0))
      FROM PatientDueDetails (NOLOCK)
      WHERE FinalBillID = @pFinalBillID
	 
	  IF @iSFranchisee=0
	  BEGIN
		  SELECT @ptempBillAMount = Isnull(Netvalue, 0)
		  FROM   Finalbill  WITH(NOLOCK) 
		  WHERE  FinalBillID = @pFinalBillID
	  END
	  ELSE
	  BEGIN
	    SELECT @ptempBillAMount = Isnull(Netvalue, 0)
		  FROM   Finalbill_Franchisee  WITH(NOLOCK) 
		  WHERE  FinalBillID = @pFinalBillID
	  END
	  
	  select @pTotalReceived = case when Isnull(@ptempReceived,0) >0 then (Isnull(@ptempBillAMount,0) - (Isnull(@pTotalRefund,0)))-Isnull(@DueAmount,0) Else Isnull(@ptempReceived,0) End

     -- SELECT @pTotalReceived = Sum(Isnull(@ptempDepositUsed, 0)
     --                              + Isnull(@ptempReceived, 0)
     --                              + Isnull(@ptempTotalDuePaidAmount, 0)) - Isnull(@pTotalRefund, 0)
	  IF @pTotalReceived<0
	     SET @pTotalReceived=0
      RETURN( @pTotalReceived );
  END 


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Pgetamountreceivedforvisit_arun]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pgetamountreceivedforvisit_arun]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Pgetamountreceivedforvisit_arun] (@pFinalBillID BIGINT)
RETURNS DECIMAL(18, 2)
WITH EXECUTE AS CALLER
AS
  BEGIN
      DECLARE @pTotalReceived DECIMAL(18, 2)
	   DECLARE @pTotalReceived1 DECIMAL(18, 2)
      DECLARE @pTotalRefund DECIMAL(18, 2)
      DECLARE @ptempReceived DECIMAL(18, 2)
      DECLARE @ptempDepositUsed DECIMAL(18, 2)
	     DECLARE @ptempTotalReceived1 DECIMAL(18, 2)
		    DECLARE @ptempTotalReceived2 DECIMAL(18, 2)

      SELECT @ptempDepositUsed = Sum(Isnull(AmountUsed, 0))
      FROM   PatientDepositUsage
      WHERE  FinalBillID = @pFinalBillID

      SELECT @ptempReceived = Sum(AmtReceived)
      FROM   AmountReceivedDetails
      WHERE  FinalBillID = @pFinalBillID

      SELECT @pTotalRefund = Sum(AmtRefund)
      FROM   AmountRefundDetails
      WHERE  FinalBillID = @pFinalBillID

	  SELECT @ptempTotalReceived1 =  Sum(Isnull(PaidAmount,0)) 
	  FROM duepaiddetail pdd with(nolock) WHERE pdd.DueBillNo=@pFinalBillID

	  
      SELECT @pTotalReceived1 = Sum(Isnull(@ptempDepositUsed, 0)
                                   + Isnull(@ptempReceived, 0))

if (@pTotalReceived1<@pTotalRefund)
begin

      SELECT @pTotalReceived = Sum((@ptempTotalReceived1 + Isnull(@ptempReceived,0))  - Isnull(@pTotalRefund, 0)) from finalbill
	   WHERE  FinalBillID = @pFinalBillID



end
else
begin

      SELECT @pTotalReceived = Sum(Isnull(@ptempDepositUsed, 0)
                                   + Isnull(@ptempReceived, 0)) - Isnull(@pTotalRefund, 0)
end

      RETURN(@pTotalReceived  );
  END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Pgetamountreceivedforvisit_S]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pgetamountreceivedforvisit_S]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Pgetamountreceivedforvisit_S] (@pFinalBillID BIGINT)
RETURNS DECIMAL(18, 2)
WITH EXECUTE AS CALLER
AS
  BEGIN
      DECLARE @pTotalReceived DECIMAL(18, 2)
      DECLARE @pTotalRefund DECIMAL(18, 2)
      DECLARE @ptempReceived DECIMAL(18, 2)
      DECLARE @ptempDepositUsed DECIMAL(18, 2)
      DECLARE @ptempTotalDuePaidAmount DECIMAL(18, 2)

      SELECT @ptempDepositUsed = Sum(Isnull(AmountUsed, 0))
      FROM   PatientDepositUsage WITH(NOLOCK) 
      WHERE  FinalBillID = @pFinalBillID

      SELECT @ptempReceived = Sum(Isnull(AmtReceived,0))
      FROM   AmountReceivedDetails WITH(NOLOCK) 
      WHERE  FinalBillID = @pFinalBillID

      SELECT @pTotalRefund = Sum(Isnull(AmtRefund,0))
      FROM   AmountRefundDetails  WITH(NOLOCK) 
      WHERE  FinalBillID = @pFinalBillID

      --SELECT @ptempTotalDuePaidAmount = Sum(Isnull(PaidAmount, 0))
      --FROM   duepaiddetail pdd with(nolock)
      --WHERE  pdd.DueBillNo = @pFinalBillID


      SELECT @pTotalReceived = Sum(Isnull(@ptempDepositUsed, 0)
                                   + Isnull(@ptempReceived, 0)
                                   + Isnull(@ptempTotalDuePaidAmount, 0)) - Isnull(@pTotalRefund, 0)

      RETURN( @pTotalReceived );
  END 



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[pGetCoPayandClaimAmount]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetCoPayandClaimAmount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[pGetCoPayandClaimAmount]
(
	@pVisitID bigint,
	@pFinalBillID bigint,
	@pType nvarchar(10)
)
RETURNS decimal(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN

	DECLARE @totalPaid DECIMAL(18,2)
	DECLARE @totalNonMedical DECIMAL(18,2)
	DECLARE @totalMedical DECIMAL(18,2)
	DECLARE @Pre_AuthAmount DECIMAL(18,2)
	DECLARE @Co_PaymentPercentage DECIMAL(18,2)
	DECLARE @Co_PaymentLogic int
	DECLARE @DeductionLogic int
	
	DECLARE @_totNonMedicalAmt DECIMAL(18,2) = 0
	DECLARE @_balAfterNonMedicalAmt DECIMAL(18,2) = 0
	DECLARE @_balAfterNonMedicalCoPayment DECIMAL(18,2) = 0
	DECLARE @_actualCoPayment DECIMAL(18,2) = 0
	DECLARE @_totCoPaymentToPay DECIMAL(18,2) = 0
	DECLARE @_diffInBillledVsPreAuth DECIMAL(18,2) = 0
	DECLARE @_grandTotal DECIMAL(18,2) = 0
	DECLARE @_grossBill DECIMAL(18,2) = 0
	DECLARE @_claimAmount DECIMAL(18,2) = 0
	DECLARE @_amountReceivable DECIMAL(18,2) = 0
	DECLARE @_totRefund DECIMAL(18,2) = 0
	DECLARE @pCopayandClaim DECIMAL(18,2)
	
	SELECT @totalMedical = dbo.GetIPBalance(@pVisitID,''ROM'')        
	SELECT @totalMedical = @totalMedical + ISNULL(SUM(ISNULL(PDC.Amount,0) * ISNULL(PDC.unit,1)),0)from PatientDueChart PDC WHERE PDC.VisitID = @pVisitID AND PDC.IsReimbursable = ''Y'' AND Status not in(''Paid'')
	SELECT @totalNonMedical = ISNULL(SUM(ISNULL(PDC.Amount,0) * ISNULL(PDC.unit,1)),0) from PatientDueChart PDC WHERE PDC.VisitID = @pVisitID AND PDC.IsReimbursable = ''N''  AND Status not in(''Paid'')
	SELECT @totalMedical = ISNULL(@totalMedical,0) + ISNULL(SUM(ISNULL(BD.Quantity,0) * ISNULL(BD.Quantity,1)),0) from BillingDetails BD WHERE BD.IsReimbursable = ''Y'' and FeeId > -2 AND BD.FinalBillID = @pFinalBillID
	SELECT @totalNonMedical = ISNULL(@totalNonMedical,0) + ISNULL(SUM(ISNULL(BD.Amount,0) * ISNULL(BD.Quantity,1)),0) from BillingDetails BD WHERE BD.IsReimbursable = ''N'' and FeeID > -2 AND BD.FinalBillID = @pFinalBillID
	
	SELECT @Co_PaymentPercentage = CopaymentPercent, @Co_PaymentLogic = CoPaymentLogic,@DeductionLogic = ClaimLogic,@Pre_AuthAmount = PreAuthAmount from VisitClientMapping where FinalBillID = @pFinalBillID and VisitID=@pVisitID
		
	
	SELECT @_totRefund = ISNULL(SUM(AmtRefund),0) from AmountRefundDetails where FinalBillID = @pFinalBillID
	SELECT @totalPaid =  ISNULL(SUM(AmtReceived),0) - @_totRefund  from AmountReceivedDetails where FinalBillID = @pFinalBillID
	
	SELECT @_grossBill = @totalMedical + @totalNonMedical
	
	IF @totalPaid > @totalNonMedical
		SET @_totNonMedicalAmt = 0
	ELSE
		SET @_totNonMedicalAmt = (@totalNonMedical - @totalPaid)
		
	IF @totalPaid - @totalNonMedical > 0
		SET @_balAfterNonMedicalAmt = @totalPaid - @totalNonMedical
	ELSE
		SET @_balAfterNonMedicalAmt = 0
	
	IF @Co_PaymentLogic = 0
	BEGIN
		IF @totalMedical < @Pre_AuthAmount
			SET @_actualCoPayment = @totalMedical * (@Co_PaymentPercentage /100)
		ELSE
			SET @_actualCoPayment = @Pre_AuthAmount * (@Co_PaymentPercentage /100)
	END
	IF @Co_PaymentLogic = 1
	BEGIN
		SET @_actualCoPayment = @totalMedical * (@Co_PaymentPercentage / 100)
	END
	IF @Co_PaymentLogic = 2
	BEGIN
		SET @_actualCoPayment = @Pre_AuthAmount * (@Co_PaymentPercentage / 100)
	END
	
	
	IF @DeductionLogic = 1
	BEGIN
		SET @_claimAmount = @totalMedical - @_actualCoPayment
		
		IF @_claimAmount > @Pre_AuthAmount
			SET @_claimAmount = @Pre_AuthAmount
		
		ELSE
			SET @_claimAmount = @totalMedical - @_actualCoPayment
		
	END
	
	IF @DeductionLogic = 2
	BEGIN
		SET @_claimAmount = @Pre_AuthAmount - @_actualCoPayment
		IF @_claimAmount > @totalMedical
			SET @_claimAmount = @totalMedical
	END

	IF @pType = ''COPAY''
		SET @pCopayandClaim = @_actualCoPayment
	IF @pType = ''CLAIM''
		SET @pCopayandClaim = @_claimAmount
		
	RETURN(@pCopayandClaim);
END;



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[PGetRateValueBasedonRate]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PGetRateValueBasedonRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[PGetRateValueBasedonRate]  
(  
@PClientid int,  
@PRateid int,  
@PParentid bigint,  
@PRateRefid bigint,  
@PFeeType nvarchar(100),  
@PFeeid bigint  
)  
Returns Decimal(18,2)   
Begin  
/*  
Select    parentid,RateRefid  
FROM InvClientMaster ICM WITH(NOLOCK)  
inner join RateRefOrgMapping R WITH(NOLOCK) ON R.RateID=ICM.RateID AND ICM.OrgID = 67  
WHERE R.OrgID=67   and ICM.ClientID=42 and ICM.Rateid = 26  
select dbo.PGetRateValueBasedonRate(42,26,0,26,''INV'',9226)  
*/  
--Set Nocount on  
Declare @Amount Decimal(18,2) = 0.0  
IF @PFeeType = ''INV''  
Begin  
   Select @Amount = R.Rate  
  From InvRateMaster R WITH(NOLOCK)   
  Where  R.RateID  = @PRateid and R.RateRefid= @PRateRefid  
  and R.Type=@PFeeType and R.ID = @pFeeID   
End  
IF @pFeeType = ''GRP'' OR @pFeeType = ''PKG''   
Begin  
 Select   @Amount = IRM.Rate  
 From InvOrgGroup IOG   
 INNER JOIN InvRateMaster IRM ON IOG.OrgGroupID=IRM.ID AND IRM.RateRefID  = @PRateRefid and IRM.RateID= @PRateid  
  WHERE IRM.Type=@pFeeType                                
  and IOG.AttGroupID= @PFeeid  
End  
IF @pFeeType = ''GEN''  
Begin  
 Select   @Amount = R.Rate  
    From GeneralBillingItems R WITH(NOLOCK)   
    Where R.RateRefID  = @PRateRefid and R.RateID = @PRateid  
    and R.GenBillID = @pFeeID         
End  
Return (@Amount)  
--Set Nocount off  
End  
  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[pGetStockinHand]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetStockinHand]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[pGetStockinHand](@pProductID [bigint], @pOrgID [bigint])
RETURNS [decimal](18, 0) WITH EXECUTE AS CALLER
AS 
BEGIN  
	DECLARE @Quantity bigint  
	SELECT @Quantity = SUM(TotalStockReceived)-SUM(TotalStockIssued)-SUM(TotalStockReturn)-SUM(TotalLocationIssued) from StockInHand    
	where ProductID=@pProductID and OrgID=@pOrgID  
	Return @Quantity  
	END  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[PMSGetBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PMSGetBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[PMSGetBillDescription] (
@FinalBillID BIGINT
,@VisitID BIGINT
,@Type VARCHAR(20)
,@ReceiptNo VARCHAR(30)
,@pOrgID INT
)
RETURNS @FeeDescription TABLE (
FinalBillid VARCHAR(50)
,Billnumber VARCHAR(50)
,RowID BIGINT
,BilledFor VARCHAR(100)
,Quanity VARCHAR(100)
,BilledAmount VARCHAR(100)
,MRPAmt VARCHAR(100)
,Discount FLOAT
,SpecialDiscount DECIMAL(18, 2)
,FeeType VARCHAR(100)
,CancelAmount DECIMAL(18, 2)
,DepartmentName VARCHAR(250)
)
WITH EXECUTE AS CALLER
AS
BEGIN
DECLARE @pResult AS NVARCHAR(MAX)
DECLARE @tempTable TABLE (
FinalBillID VARCHAR(50)
,Billnumber VARCHAR(50)
,RowID BIGINT
,BilledFor VARCHAR(100)
,Quanity VARCHAR(100)
,BilledAmount VARCHAR(100)
,MRPAmt VARCHAR(100)
,Discount FLOAT
,SpecialDiscount FLOAT
,FeeType VARCHAR(100)
,CancelAmount FLOAT
)
DECLARE @intFlag INT
DECLARE @pCount AS INT
DECLARE @pTempData AS NVARCHAR(MAX)
DECLARE @pTable AS NVARCHAR(MAX)
DECLARE @pTableRow AS NVARCHAR(MAX)
SET @intFlag = 1
IF @Type = ''Bill''
BEGIN
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,Discount
,FeeType
,CancelAmount
,DepartmentName
)
SELECT @FinalBillid
,FB.Billnumber
,ROW_NUMBER() OVER (
ORDER BY BD.FinalBillID
) AS RowID
,BD.FeeDescription
,CONVERT(VARCHAR, BD.Quantity)
,CONVERT(VARCHAR, BD.Amount)
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), BD.Quantity * BD.ActualAmount)))
,CONVERT(VARCHAR, BD.DiscountAmount)
,CASE 
WHEN BD.FeeType = ''CON''
THEN ''Consultation''
WHEN BD.FeeType = ''PRO''
THEN ''Procedure''
WHEN BD.FeeType = ''PRM''
THEN ''Pharmacy''
WHEN BD.FeeType = ''REG''
THEN ''Registration''
WHEN BD.FeeType = ''OTH''
THEN ''Others''
WHEN BD.FeeType = ''ROM''
THEN ''Room''
WHEN BD.FeeType = ''PKG''
THEN ''Packages''
WHEN BD.FeeType = ''CAS''
THEN ''Casualty''
WHEN BD.FeeType = ''GRP''
THEN ''Lab''
WHEN BD.FeeType = ''SOI''
THEN ''Surgery Items''
WHEN BD.FeeType = ''SUR''
THEN ''Surgery''
WHEN BD.FeeType = ''SPKG''
THEN ''Surgery Package''
WHEN BD.FeeType = ''GEN''
THEN ''General''
WHEN BD.FeeType = ''IND''
THEN ''Indents''
WHEN BD.FeeType = ''Miscellaneous''
THEN ''Misc''
WHEN BD.FeeType = ''LCON''
THEN ''LCON''
WHEN BD.FeeType = ''DUE''
THEN ''Due''
WHEN BD.FeeType = ''ADD''
THEN ''Additional''
WHEN BD.FeeType = ''INV''
THEN ''LAB''
END
--,CONVERT(VARCHAR, AFD.CancelAmount)
,0 as CancelAmount
,D.deptname
FROM BillingDetails BD
INNER JOIN Finalbill FB ON BD.Finalbillid = FB.Finalbillid
AND BD.Orgid = FB.Orgid
INNER JOIN VW_TestwithDept D ON D.InvestigationID = BD.feeid
AND BD.FeeType = d.TestType
AND Bd.orgid = D.orgid
--LEFT JOIN amountrefunddetails AFD ON BD.Finalbillid = AFD.Finalbillid
--	AND BD.Orgid = AFD.Orgid
WHERE BD.FinalBillID = @FinalBillID
GROUP BY BD.FinalBillID
,FeeDescription
,BD.Quantity
,FeeType
,Amount
,FB.Billnumber
,BD.DiscountAmount
--,CancelAmount
,D.deptname
END
IF @Type = ''Refund''
BEGIN
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,FB.Billnumber
,ROW_NUMBER() OVER (
ORDER BY ARD.FinalBillID
) AS RowID
,BD.FeeDescription
,CONVERT(VARCHAR, ARD.Quantity)
,''0''
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), AmtRefund)))
,'' (Refund)''
,''1''
FROM AmountRefundDetails ARD
INNER JOIN BillingDetails BD ON ARD.FinalBillID = BD.FinalBillID
AND ARD.BillingDetailsID = BD.BillingDetailsID
INNER JOIN Finalbill FB ON BD.Finalbillid = FB.Finalbillid
AND BD.Orgid = FB.Orgid
WHERE BD.FinalBillID = @FinalBillID
GROUP BY ARD.FinalBillID
,BD.FeeDescription
,ARD.Quantity
,FB.Billnumber
END
IF @Type = ''Deposit''
BEGIN
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,FB.BillNumber
,ROW_NUMBER() OVER (
ORDER BY PDH.ReceiptNo
) AS RowID
,''Depsoit Collection''
,''0''
,''0''
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), AmountDeposited)))
,''Deposit''
,''2''
FROM PatientDepositHistory PDH
INNER JOIN Patient P ON P.PatientID = PDH.PatientID
AND PDH.OrgID = @pOrgID
INNER JOIN Finalbill FB ON PDH.ReceiptNo = FB.Finalbillid
AND PDH.Orgid = FB.Orgid
WHERE PDH.ReceiptNo = @FinalBillID
GROUP BY PDH.ReceiptNo
,FB.BillNumber
END
IF @Type = ''IP''
BEGIN
DECLARE @startBillingID BIGINT
DECLARE @EndBillingID BIGINT
SELECT @startBillingID = StartBillingDetailID
,@EndBillingID = EndBillingDetaillID
FROM IPIntermediatePayments
WHERE VisitID = @VisitID
AND ReceiptNO = @ReceiptNo
AND OrgID = @pOrgID
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,FB.Billnumber
,ROW_NUMBER() OVER (
ORDER BY BD.FinalBillID
) AS RowID
,BD.FeeDescription
,CONVERT(VARCHAR, BD.Quantity)
,CONVERT(VARCHAR, BD.Amount)
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), BD.Quantity * BD.Amount)))
,CASE 
WHEN BD.FeeType = ''CON''
THEN ''Consultation''
WHEN BD.FeeType = ''PRO''
THEN ''Procedure''
WHEN BD.FeeType = ''PRM''
THEN ''Pharmacy''
WHEN BD.FeeType = ''REG''
THEN ''Registration''
WHEN BD.FeeType = ''OTH''
THEN ''Others''
WHEN BD.FeeType = ''ROM''
THEN ''Room''
WHEN BD.FeeType = ''PKG''
THEN ''Packages''
WHEN BD.FeeType = ''CAS''
THEN ''Casualty''
WHEN BD.FeeType = ''GRP''
THEN ''Lab''
WHEN BD.FeeType = ''SOI''
THEN ''Surgery Items''
WHEN BD.FeeType = ''SUR''
THEN ''Surgery''
WHEN BD.FeeType = ''SPKG''
THEN ''Surgery Package''
WHEN BD.FeeType = ''GEN''
THEN ''General''
WHEN BD.FeeType = ''IND''
THEN ''Indents''
WHEN BD.FeeType = ''Miscellaneous''
THEN ''Misc''
WHEN BD.FeeType = ''LCON''
THEN ''LCON''
WHEN BD.FeeType = ''DUE''
THEN ''Due''
WHEN BD.FeeType = ''ADD''
THEN ''Additional''
WHEN BD.FeeType = ''INV''
THEN ''LAB''
END
--,CONVERT(VARCHAR, AFD.CancelAmount)
,''200''
FROM BillingDetails BD
INNER JOIN Finalbill FB ON BD.Finalbillid = FB.Finalbillid
AND BD.Orgid = FB.Orgid
LEFT JOIN amountrefunddetails AFD ON BD.Finalbillid = AFD.Finalbillid
AND BD.Orgid = AFD.Orgid
WHERE BD.FinalBillID = @FinalBillID
AND BD.BillingDetailsID BETWEEN @startBillingID
AND @EndBillingID
AND BD.FeeId NOT IN (
- 2
,- 3
,- 4
)
GROUP BY BD.FinalBillID
,FeeDescription
,BD.Quantity
,FeeType
,Amount
,FB.Billnumber
,AFD.CancelAmount
END
IF @Type = ''IPItemRefund''
BEGIN
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,FB.Billnumber
,ROW_NUMBER() OVER (
ORDER BY ARD.FinalBillID
) AS RowID
,BD.FeeDescription
,CONVERT(VARCHAR, ARD.Quantity)
,''0''
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), AmtRefund)))
,''(Refund)''
,''3''
FROM AmountRefundDetails ARD
INNER JOIN BillingDetails BD ON ARD.FinalBillID = BD.FinalBillID
AND ARD.BillingDetailsID = BD.BillingDetailsID
INNER JOIN Finalbill FB ON BD.Finalbillid = FB.Finalbillid
AND BD.Orgid = FB.Orgid
WHERE ARD.RefundNo = @ReceiptNo
AND ARD.OrgID = @pOrgID
GROUP BY ARD.FinalBillID
,BD.FeeDescription
,ARD.Quantity
,FB.Billnumber
END
IF @Type = ''IPRefund''
BEGIN
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,FB.Billnumber
,ROW_NUMBER() OVER (
ORDER BY ARD.FinalBillID
) AS RowID
,BD.FeeDescription
,CONVERT(VARCHAR, ARD.Quantity)
,''0''
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), AmtRefund)))
,''(Refund)''
,''4''
FROM AmountRefundDetails ARD
INNER JOIN BillingDetails BD ON ARD.FinalBillID = BD.FinalBillID
AND ARD.BillingDetailsID = 0
INNER JOIN Finalbill FB ON BD.Finalbillid = FB.Finalbillid
AND BD.Orgid = FB.Orgid
WHERE ARD.RefundNo = @ReceiptNo
AND ARD.OrgID = @pOrgID
GROUP BY ARD.FinalBillID
,BD.FeeDescription
,ARD.Quantity
,FB.Billnumber
END
IF @Type = ''IPDue''
BEGIN
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,F.billnumber
,ROW_NUMBER() OVER (
ORDER BY BD.VisitID
) AS RowID
,BD.Description
,CONVERT(VARCHAR, BD.unit)
,CONVERT(VARCHAR, BD.Amount)
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), BD.unit * BD.Amount)))
,CASE 
WHEN BD.FeeType = ''CON''
THEN ''Consultation''
WHEN BD.FeeType = ''PRO''
THEN ''Procedure''
WHEN BD.FeeType = ''PRM''
THEN ''Pharmacy''
WHEN BD.FeeType = ''REG''
THEN ''Registration''
WHEN BD.FeeType = ''OTH''
THEN ''Others''
WHEN BD.FeeType = ''ROM''
THEN ''Room''
WHEN BD.FeeType = ''PKG''
THEN ''Packages''
WHEN BD.FeeType = ''CAS''
THEN ''Casualty''
WHEN BD.FeeType = ''GRP''
THEN ''Lab''
WHEN BD.FeeType = ''SOI''
THEN ''Surgery Items''
WHEN BD.FeeType = ''SUR''
THEN ''Surgery''
WHEN BD.FeeType = ''SPKG''
THEN ''Surgery Package''
WHEN BD.FeeType = ''GEN''
THEN ''General''
WHEN BD.FeeType = ''IND''
THEN ''Indents''
WHEN BD.FeeType = ''Miscellaneous''
THEN ''Misc''
WHEN BD.FeeType = ''LCON''
THEN ''LCON''
WHEN BD.FeeType = ''DUE''
THEN ''Due''
WHEN BD.FeeType = ''ADD''
THEN ''Additional''
WHEN BD.FeeType = ''INV''
THEN ''LAB''
END
,''5''
FROM PatientDueChart BD
INNER JOIN FinalBill F ON BD.VisitID = F.VisitID
AND BD.InterimBillNo = @ReceiptNo
WHERE BD.FeeId NOT IN (
- 2
,- 3
,- 4
)
GROUP BY BD.VisitID
,Description
,unit
,FeeType
,Amount
,F.billnumber
END
IF @Type = ''IPPharmaDue''
BEGIN
SELECT @startBillingID = StartBillingDetailID
,@EndBillingID = EndBillingDetaillID
FROM IPIntermediatePayments
WHERE VisitID = @VisitID
AND ReceiptNO = @ReceiptNo
AND OrgID = @pOrgID
INSERT INTO @FeeDescription (
FinalBillid
,Billnumber
,RowID
,BilledFor
,Quanity
,BilledAmount
,MRPAmt
,FeeType
,CancelAmount
)
SELECT @FinalBillid
,FB.Billnumber
,ROW_NUMBER() OVER (
ORDER BY BD.FinalBillID
) AS RowID
,BD.FeeDescription
,CONVERT(VARCHAR, BD.Quantity)
,CONVERT(VARCHAR, BD.Amount)
,CONVERT(VARCHAR, SUM(convert(DECIMAL(18, 2), BD.Quantity * BD.ActualAmount)))
,CASE 
WHEN BD.FeeType = ''CON''
THEN ''Consultation''
WHEN BD.FeeType = ''PRO''
THEN ''Procedure''
WHEN BD.FeeType = ''PRM''
THEN ''Pharmacy''
WHEN BD.FeeType = ''REG''
THEN ''Registration''
WHEN BD.FeeType = ''OTH''
THEN ''Others''
WHEN BD.FeeType = ''ROM''
THEN ''Room''
WHEN BD.FeeType = ''PKG''
THEN ''Packages''
WHEN BD.FeeType = ''CAS''
THEN ''Casualty''
WHEN BD.FeeType = ''GRP''
THEN ''Lab''
WHEN BD.FeeType = ''SOI''
THEN ''Surgery Items''
WHEN BD.FeeType = ''SUR''
THEN ''Surgery''
WHEN BD.FeeType = ''SPKG''
THEN ''Surgery Package''
WHEN BD.FeeType = ''GEN''
THEN ''General''
WHEN BD.FeeType = ''IND''
THEN ''Indents''
WHEN BD.FeeType = ''Miscellaneous''
THEN ''Misc''
WHEN BD.FeeType = ''LCON''
THEN ''LCON''
WHEN BD.FeeType = ''DUE''
THEN ''Due''
WHEN BD.FeeType = ''ADD''
THEN ''Additional''
WHEN BD.FeeType = ''INV''
THEN ''LAB''
END
,''6''
FROM BillingDetails BD
INNER JOIN Finalbill FB ON BD.Finalbillid = FB.Finalbillid
AND BD.Orgid = FB.Orgid
WHERE BD.FinalBillID = @FinalBillID
AND BD.BillingDetailsID BETWEEN @startBillingID
AND @EndBillingID
AND BD.FeeId NOT IN (
- 2
,- 3
,- 4
)
GROUP BY BD.FinalBillID
,FeeDescription
,Quantity
,FeeType
,Amount
,FB.Billnumber
END
--      insert into @tempTable(FinalBillID,Billnumber,RowID,BilledFor,Quanity,BilledAmount,MRPAmt,Discount,SpecialDiscount,FeeType)          
--      select T.FinalBillid,T.Billnumber,T.RowID,T.BilledFor,T.Quanity,T.BilledAmount,T.MRPAmt,BD.DiscountAmount as Discount,cast(T.MRPAmt as decimal(18,2))-cast(T.BilledAmount as decimal(18,2)) as SpecialDiscount,T.Feetype
--from @FeeDescription T 
--inner join BillingDetails BD on T.FinalBillID=BD.FinalBillID
--insert into @FeeDescription (FinalBillid,Billnumber,RowID,BilledFor,Quanity,BilledAmount,MRPAmt,Discount,SpecialDiscount,FeeType)
--select FinalBillID,Billnumber,RowID,BilledFor,Quanity,BilledAmount,MRPAmt,Discount,SpecialDiscount,FeeType from @tempTable
UPDATE @FeeDescription
SET SpecialDiscount = cast(MRPAmt AS DECIMAL(18, 2)) - cast(BilledAmount AS DECIMAL(18, 2))
RETURN
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[posSubString]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[posSubString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[posSubString]
(@source nvarchar(MAX), @pattern nvarchar(MAX), @start int, @from_occurance int)
RETURNS int
WITH EXEC AS CALLER
AS
BEGIN
DECLARE @hit int
DECLARE @len int
SELECT @hit=0,@start=ISNULL(@start,1),@source=ISNULL(@source,''''),@from_occurance=ISNULL(@from_occurance,0),@len=LEN(ISNULL(@source,''''))
WHILE @start<=@len
	BEGIN
	SET @start=CHARINDEX(@pattern,@source,@start)
	IF @start=0
		BREAK
	SET @hit = @hit + 1
	IF @hit = @from_occurance
		BREAK
	SET @start=@start+1
	END
    RETURN @start
END


' 
END

GO


/****** Object:  UserDefinedFunction [dbo].[PrintReportPdf]    Script Date: 7/19/2018 12:53:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--SELECT DBO.PrintReportPdf   (89,163,1933,2545)   
--out ("89","163","1975","2545","Yes");       
Create Function [dbo].[PrintReportPdf]                              
(  
@pOrgID int,
 @pOrgAddressID    bigint,
 @VisitID bigint, 
 @RoleId varchar(7)                  
)                     
RETURNS NVARCHAR(500)                                                                  
WITH EXECUTE AS CALLER                                                                  
AS                                                                  
BEGIN                               
	DECLARE @pResult AS NVARCHAR(MAX)                                  
	DECLARE @REPORTPDFFOLDERPATH VARCHAR(500) = ''
	Declare @duestatus varchar(50) ='' 
	SELECT @REPORTPDFFOLDERPATH=Value FROM CommunicationConfig WITH (NOLOCK) WHERE Name='REPORTPDFFOLDERPATH' AND InstanceID=1
	SELECT @duestatus=status from PatientDueDetails WITH (NOLOCK) where VisitID=@VisitID
	IF @duestatus='Open' SET @VisitID=0;
	SELECT @pResult='"'+convert(varchar(10),@pOrgID)+'"'+','+'"'+convert(varchar(20),@pOrgAddressID)+'"'+','+'"'+convert(varchar(20),@VisitID)+'"'+','+'"'+@RoleId+'"'+','
	IF exists(select visitid from ReportSnapshot WITH (NOLOCK) where VisitID=@VisitID and OrgID=@pOrgID and type='roundbpdf')  
		SET	@pResult = @pResult +'"Yes"'
	ELSE  
		SET @pResult = @pResult +'"No'                    
RETURN @pResult
END 
GO
/****** Object:  UserDefinedFunction [dbo].[properCase]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[properCase]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create function [dbo].[properCase](@string nvarchar(max)) returns nvarchar(max) as
begin
		
	set @string = lower(@string)
	
	declare @i int
	set @i = ascii(''a'')
	
	while @i <= ascii(''z'')
	begin
	
		set @string = replace( @string, '''' + nchar(@i), '''' + nchar(@i-32))
		set @i = @i + 1
	end
	
	set @string = nchar(ascii(left(@string, 1))-32) + right(@string, len(@string)-1)
	
	return @string
end;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[RemoveNonNumerics]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveNonNumerics]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[RemoveNonNumerics](@in nvarchar(255))
RETURNS nvarchar(255)
AS
BEGIN
    DECLARE @out nvarchar(255)

    IF (@in IS NOT NULL)
    BEGIN
        SET @out = ''''

        WHILE (@in <> '''')
        BEGIN
            IF (@in LIKE ''[0-9]%'')
                SET @out = @out + SUBSTRING(@in, 1, 1)

            SET @in = SUBSTRING(@in, 2, LEN(@in) - 1)
        END
    END

    RETURN(@out)
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[ReportBillDescription]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportBillDescription]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[ReportBillDescription]                        
(                                             
@VisitID bigint,                        
@pOrgID int,
@LangCode nvarchar(20)
)               
--SELECT DBO.ReportBillDescription   (22,70)               
RETURNS NVARCHAR(MAX)                                                            
WITH EXECUTE AS CALLER                                                            
AS                                                            
BEGIN                         
DECLARE @pResult AS NVARCHAR(MAX)                            
DECLARE @FeeDescription as Table                                  
(                                  
RowID bigint,             
TestDescription nvarchar(max),  
status nvarchar(25)                     
)                          
DECLARE @tempMetadata AS TABLE
(
RowID     BIGINT,
Code VARCHAR(100),
Description   VARCHAR(100),
LangCode    VARCHAR(100)           
)
insert into @tempMetadata(Code,Description,LangCode)
select M.Code,Mp.Displaytext,Mp.LangCode from metadata M inner join Metadataorgmapping Mp on MP.metadataid=m.metadataid where m.domain=''BillWiseDeptWise''
and isnull(Mp.LangCode,''en-GB'')=@LangCode
Declare @OrdServices nvarchar(25)
Declare @Status nvarchar(25)
select @OrdServices=Description from @tempmetadata where code=''OrdS''
select @Status=Description from @tempmetadata where code=''Status''
DECLARE @intFlag INT                                    
DECLARE @pCount AS INT                                   
DECLARE @pTempData AS NVARCHAR(MAX)                           
DECLARE @pTable AS NVARCHAR(MAX)                           
DECLARE @pTableRow AS NVARCHAR(MAX)                           
SET @intFlag = 1                              
INSERT INTO @FeeDescription                                   
SELECT ROW_NUMBER() OVER(ORDER BY VISITID) AS RowID,Name,Status   
from (select ORD.VisitID ,CASE WHEN PKGID >0 THEN ORD.Name +''(''+ORD.PkgName+'')'' ELSE ORD.Name END AS name,ISM.DisplayText as Status                  
FROM OrderedInvestigations ORD    
INNER JOIN Invstatusorgmapping ISM on ISM.Status =ORD.status and ISM.OrgID=ORD.OrgID 
WHERE ORD.VisitID=@VisitID and ord.OrgID=@pOrgID and ord.Type IN(''INV'',''GRP'')  and isnull(ISM.LangCode,''en-GB'')=@LangCode 
)T  
SELECT @pCount = COUNT(*) from @FeeDescription                          
IF(@pCount>0)                              
BEGIN                            
SELECT @pTable= ''<div class="orderedServices"><table width="100%" border = "0" class="gridView " style="border:solid 1px block;font-size:12px;border-spacing:1px;" >''                                
SET @pTempData=''''                
SET @pTableRow = ''<tr> <th>''+@OrdServices+''</th><th>''+@Status+''</th> </tr>''                            
BEGIN                              
WHILE (@intFlag <= @pCount)                                    
BEGIN                          
SELECT @pTempData = @pTempData+''<tr><td>''+ TestDescription +''</td> <td align="right"> ''+ status +''</td></tr>''                        
from @FeeDescription Where RowID=@intFlag                                    
SET @intFlag = @intFlag + 1                                    
END                               
END                              
SELECT @pResult= @pTable + @pTableRow + @pTempData+''</table></div>''                           
END                          
RETURN @pResult                                
END


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[ReportPdfPath]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportPdfPath]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[ReportPdfPath]                              
(                                                   
@VisitID bigint,                              
@pOrgID int                  
)                     
--SELECT DBO.ReportPdfPath   (50,70)                     
RETURNS NVARCHAR(MAX)                                                                  
WITH EXECUTE AS CALLER                                                                  
AS                                                                  
BEGIN                               
DECLARE @pResult AS NVARCHAR(MAX)                                  
DECLARE @REPORTPDFFOLDERPATH nvarchar(500) = ''''                
SELECT @REPORTPDFFOLDERPATH=Value FROM CommunicationConfig(NOLOCK) WHERE Name=''REPORTPDFFOLDERPATH'' AND InstanceID=1            
if exists(select 1 from ReportSnapshot with (nolock) where VisitID=@VisitID and OrgID=@pOrgID and type=''Pdf'')  
begin  
SELECT @pResult=REPLACE(@REPORTPDFFOLDERPATH,''\'',''\\'')+Replace(ReportPath ,''\'',''\\'')                   
FROM ReportSnapshot WITH (NOLOCK) WHERE OrgID=@pOrgID and VisitID=@VisitID AND TYPE=''Pdf''  order by CreatedAt desc                  
end  
else  
begin  
select @pResult=''Empty''  
end                        
RETURN @pResult                                 
END;


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[SpiltDrugDruration]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpiltDrugDruration]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--Select  dbo.[SpiltDrugDruration](''1 Week(s)'')
CREATE FUNCTION [dbo].[SpiltDrugDruration]
(	
	@List nvarchar(2000)
)
RETURNS INT
AS
BEGIN

Declare @cunt int
Declare @StrinID int
Declare @SplitID nvarchar(20)
Declare @SplitValue nvarchar(20)
--select charindex('' '', ''15 week(s)'')
--select substring(''15 week(s)'', 1, 2)
--select substring(''15 week(s)'', 3, LEN(''15 week(s)''))
set @StrinID=charindex('' '', @List)
--print @StrinID
set @SplitID=substring(@List, 1, @StrinID-1)
--print @SplitID
set @SplitValue=substring(@List, @StrinID, LEN(@List))
--print RTRIM(ltrim(@SplitValue)) 
set @SplitValue=RTRIM(ltrim(@SplitValue))   
    if(@SplitValue=''Day(s)'')
    begin
    set @cunt=(1*@SplitID)
    end
    if(@SplitValue=''Week(s)'')
    begin
    set @cunt=7*@SplitID
    end
    if(@SplitValue=''Month(s)'')
    begin
    set @cunt=30*@SplitID
    end
    if(@SplitValue=''Year(s)'')
    begin
    set @cunt=365*@SplitID
    end
    --Select @cunt=count(Value) from @RtnValue
    
    Return @cunt
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[SpiltDrugFrequence]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpiltDrugFrequence]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'--select [dbo].[SpiltDrugFrequence] ''1-1-1'',''-'',''15 week(s)''
CREATE FUNCTION [dbo].[SpiltDrugFrequence]    
(     
 @List nvarchar(Max),    
 @SplitOn nvarchar(5),    
 @ListDuration nvarchar(Max)    
    
)    
RETURNS INT    
AS    
BEGIN  
   -----------------------------------------------Duration  
 if(@List='''')  
 Begin          
  Declare @cunt int        
  Declare @StrinID int        
  Declare @SplitID nvarchar(20)        
  Declare @SplitValue nvarchar(20)        
  set @StrinID=charindex('' '', @ListDuration)         
  set @SplitID=substring(@ListDuration, 1, @StrinID-1)          
  set @SplitValue=substring(@ListDuration, @StrinID, LEN(@ListDuration))          
  set @SplitValue=RTRIM(ltrim(@SplitValue))           
          
 if(@SplitValue=''Day(s)'')        
 begin        
  set @cunt=(1*@SplitID)        
 end        
 if(@SplitValue=''Week(s)'')        
 begin        
  set @cunt=7*@SplitID        
 end        
 if(@SplitValue=''Month(s)'')        
 begin        
  set @cunt=30*@SplitID        
 end        
 if(@SplitValue=''Year(s)'')        
 begin        
  set @cunt=365*@SplitID        
 end        
    ------------------------------------------------------       
END   
ELSE  
BEGIN  
 Declare @RtnValue table (    
 Id int identity(1,1),    
 Value DECIMAl(18,2)    
 )    
 While (Charindex(@SplitOn,@List)>0)    
 Begin     
 Insert Into @RtnValue (value)    
 Select     
 Value = ltrim(rtrim(Substring(@List,1,Charindex(@SplitOn,@List)-1)))     
 Set @List = Substring(@List,Charindex(@SplitOn,@List)+len(@SplitOn),len(@List))    
 End     
  
 Insert Into @RtnValue (Value)    
 Select Value = ltrim(rtrim(@List))    
 Select @cunt=sum(Value) from @RtnValue    
END   
  
    Return (@cunt)      
END



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[Splitfunc]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Splitfunc]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[Splitfunc](@String nvarchar(100), @Delimiter nchar(1))       
returns @temptable TABLE (Discount nvarchar(100))       
as       
begin       
    declare @idx int       
    declare @slice nvarchar(max)       
      
    select @idx = 1       
        if len(@String)<1 or @String is null  return       
      
    while @idx!= 0       
    begin       
        set @idx = charindex(@Delimiter,@String)       
        if @idx!=0       
            set @slice = left(@String,@idx - 1)       
        else       
            set @slice = @String       
          
        if(len(@slice)>0)  
            insert into @temptable(Discount) values(@slice)       
  
        set @String = right(@String,len(@String) - @idx)       
        if len(@String) = 0 break       
    end   
return       
end



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[StripHTML]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StripHTML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
-------------------------------Histo mis-------------
create function [dbo].[StripHTML]( @text varchar(max) ) returns varchar(max) as
begin
    declare @textXML xml
    declare @result varchar(max)
    set @textXML = REPLACE( @text, ''&'', '''' );
    with doc(contents) as
    (
        select chunks.chunk.query(''.'') from @textXML.nodes(''/'') as chunks(chunk)
    )
    select @result = contents.value(''.'', ''varchar(max)'') from doc
    return @result
end

' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[udf_DayOfMonth]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DayOfMonth]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[udf_DayOfMonth](@FDayofCurMonth DATETIME,@LDayofCurMonth DATETIME,@mDayofMonth INT)
RETURNS DateTime  
AS  
BEGIN 
DECLARE @rtDayofMonth INT  
DECLARE @ReturnDate DateTime  

WHILE @LDayofCurMonth >= @FDayofCurMonth  
BEGIN  
SELECT @rtDayofMonth = Datepart(DD, @FDayofCurMonth)  

IF @rtDayofMonth = @mDayofMonth  
BEGIN  
SET @ReturnDate= @FDayofCurMonth  
END  

SET @FDayofCurMonth=@FDayofCurMonth + 1  
END  

RETURN ( @ReturnDate )  
END   



' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[udf_DayOfWeek]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DayOfWeek]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[udf_DayOfWeek](@StartDate DATETIME,
                                 @EndDate   DATETIME,
                                 @DateType  INT)
RETURNS DateTime
AS
  BEGIN
      DECLARE @rtDayofWeek INT
      DECLARE @ReturnDate DateTime

      WHILE @EndDate >= @StartDate
        BEGIN
            SELECT @rtDayofWeek = Datepart(DW, @StartDate)
            
            IF @rtDayofWeek = @DateType
              BEGIN
                  SET @ReturnDate= @StartDate
              END

            SET @StartDate=@StartDate + 1
        END

      RETURN ( @ReturnDate )
  END





' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[udf_TitleCase]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_TitleCase]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[udf_TitleCase] (@InputString nvarchar(4000) )  
RETURNS nvarchar(4000)  
AS  
BEGIN  
DECLARE @Index INT  
DECLARE @nchar nchar(1)  
DECLARE @OutputString nvarchar(255)  
SET @OutputString = LOWER(@InputString)  
SET @Index = 2  
SET @OutputString =  
STUFF(@OutputString, 1, 1,UPPER(SUBSTRING(@InputString,1,1)))  
WHILE @Index <= LEN(@InputString)  
BEGIN  
SET @nchar = SUBSTRING(@InputString, @Index, 1)  
IF @nchar IN ('' '', '';'', '':'', ''!'', ''?'', '','', ''.'', ''_'', ''-'', ''/'', ''&'','''''''',''('')  
IF @Index + 1 <= LEN(@InputString)  
BEGIN  
IF @nchar != ''''''''  
OR  
UPPER(SUBSTRING(@InputString, @Index + 1, 1)) != ''S''  
SET @OutputString =  
STUFF(@OutputString, @Index + 1, 1,UPPER(SUBSTRING(@InputString, @Index + 1, 1)))  
END  
SET @Index = @Index + 1  
END  
RETURN ISNULL(@OutputString,'''')  
END  


' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[ufsFormat]    Script Date: 6/25/2018 4:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ufsFormat]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[ufsFormat]  
(  
@Date datetime,  
@fORMAT nvarchar(80)  
)  
RETURNS NVARCHAR(80)  
AS  
BEGIN  
DECLARE @Dateformat INT  
DECLARE @ReturnedDate nvarchar(80)  
DECLARE @TwelveHourClock INT  
DECLARE @Before INT  
DECLARE @pos INT  
DECLARE @Escape INT  
 
SELECT @ReturnedDate=''error! unrecognised format ''+@format  
SELECT @DateFormat=CASE @format  
WHEN ''mmm dd yyyy hh:mm AM/PM'' THEN 100  
WHEN ''mm/dd/yy'' THEN 1  
WHEN ''mm/dd/yyyy'' THEN 101  
WHEN ''yy.mm.dd'' THEN 2  
WHEN ''dd/mm/yy'' THEN 3  
WHEN ''dd.mm.yy'' THEN 4  
WHEN ''dd-mm-yy'' THEN 5  
WHEN ''dd Mmm yy'' THEN 6  
WHEN ''Mmm dd, yy'' THEN 7  
WHEN ''hh:mm:ss'' THEN 8  
WHEN ''yyyy.mm.dd'' THEN 102  
WHEN ''dd/mm/yyyy'' THEN 103  
WHEN ''dd.mm.yyyy'' THEN 104  
WHEN ''dd-mm-yyyy'' THEN 105  
WHEN ''dd Mmm yyyy'' THEN 106  
WHEN ''Mmm dd, yyyy'' THEN 107  
WHEN ''Mmm dd yyyy hh:mm:ss:ms AM/PM'' THEN 9  
WHEN ''Mmm dd yyyy hh:mi:ss:mmm AM/PM'' THEN 9  
WHEN ''Mmm dd yy hh:mm:ss:ms AM/PM'' THEN 109  
WHEN ''mm-dd-yy'' THEN 10  
WHEN ''mm-dd-yyyy'' THEN 110  
WHEN ''yy/mm/dd'' THEN 11  
WHEN ''yyyy/mm/dd'' THEN 111  
WHEN ''yymmdd'' THEN 12  
WHEN ''yyyymmdd'' THEN 112  
WHEN ''dd Mmm yyyy hh:mm:ss:Ms'' THEN 113  
WHEN ''hh:mm:ss:Ms'' THEN 14  
WHEN ''yyyy-mm-dd hh:mm:ss'' THEN 120  
WHEN ''yyyy-mm-dd hh:mm:ss.Ms'' THEN 121  
WHEN ''yyyy-mm-ddThh:mm:ss.Ms'' THEN 126  
WHEN ''dd Mmm yyyy hh:mm:ss:ms AM/PM'' THEN 130  
WHEN ''dd/mm/yy hh:mm:ss:ms AM/PM'' THEN 131  
WHEN ''RFC822'' THEN 2  
WHEN ''dd Mmm yyyy hh:mm'' THEN 4  
ELSE 1 END  
SELECT @ReturnedDate=''error! unrecognised format '' +@format+CONVERT(nvarchar(10),@DateFormat)  
IF @DateFormat>=0  
SELECT @ReturnedDate=CONVERT(nvarchar(80),@Date,@DateFormat)  
--check for favourite and custom formats that can be done quickly  
ELSE IF @DateFormat=-2--then it is RFC822 format  
SELECT @ReturnedDate=LEFT(DATENAME(dw, @Date),3) + '', '' + STUFF(CONVERT(NVARCHAR,@Date,113),21,4,'' GMT'')  
ELSE IF @DateFormat=-4--then it is european day format with minutes  
SELECT @ReturnedDate=CONVERT(nchar(17),@Date,113)  
ELSE  
BEGIN  
SELECT @Before=LEN(@format)  
SELECT @Format=REPLACE(REPLACE(REPLACE( @Format,''AM/PM'',''#''),''AM'',''#''),''PM'',''#'')  
SELECT @TwelveHourClock=CASE WHEN @Before >LEN(@format) THEN 109 ELSE 113 END, @ReturnedDate=''''  
WHILE (1=1)--forever  
BEGIN  
SELECT @pos=PATINDEX(''%[yqmidwhs:#]%'',@format+'' '')  
IF @pos=0--no more date format strings  
BEGIN  
SELECT @ReturnedDate=@ReturnedDate+@format  
BREAK  
END  
IF @pos>1--some stuff to pass through first  
BEGIN  
SELECT @escape=CHARINDEX (''\'',@Format+''\'') --is it a literal character that is escaped?  
IF @escape<@pos BEGIN  
SET @ReturnedDate=@ReturnedDate+SUBSTRING(@Format,1,@escape-1) +SUBSTRING(@format,@escape+1,1)  
SET @format=RTRIM(SUBSTRING(@Format,@Escape+2,80))  
CONTINUE  
END  
SET @ReturnedDate=@ReturnedDate+SUBSTRING(@Format,1,@pos-1)  
SET @format=RTRIM(SUBSTRING(@Format,@pos,80))  
END  
SELECT @pos=PATINDEX(''%[^yqmidwhs:#]%'',@format+'' '')--get the end  
SELECT @ReturnedDate=@ReturnedDate+--''(''+substring(@Format,1,@pos-1)+'')''+  
CASE SUBSTRING(@Format,1,@pos-1)  
--Mmmths as 1--12  
WHEN ''M'' THEN CONVERT(nvarchar(2),DATEPART(MONTH,@Date))  
--Mmmths as 01--12  
WHEN ''Mm'' THEN CONVERT(nchar(2),@Date,101)  
--Mmmths as Jan--Dec  
WHEN ''Mmm'' THEN CONVERT(nchar(3),DATENAME(MONTH,@Date))  
--Mmmths as January--December  
WHEN ''Mmmm'' THEN DATENAME(MONTH,@Date)  
--Mmmths as the first letter of the Mmmth  
WHEN ''Mmmmm'' THEN CONVERT(nchar(1),DATENAME(MONTH,@Date))  
--Days as 1--31  
WHEN ''D'' THEN CONVERT(nvarchar(2),DATEPART(DAY,@Date))  
--Days as 01--31  
WHEN ''Dd'' THEN CONVERT(nchar(2),@date,103)  
--Days as Sun--Sat  
WHEN ''Ddd'' THEN CONVERT(nchar(3),DATENAME(weekday,@Date))  
--Days as Sunday--Saturday  
WHEN ''Dddd'' THEN DATENAME(weekday,@Date)  
--Years as 00--99  
WHEN ''Yy'' THEN CONVERT(nchar(2),@Date,12)  
--Years as 1900--9999  
WHEN ''Yyyy'' THEN DATENAME(YEAR,@Date)  
WHEN ''hh:mm:ss'' THEN SUBSTRING(CONVERT(nchar(30),@date,@TwelveHourClock),13,8)  
WHEN ''hh:mm:ss:ms'' THEN SUBSTRING(CONVERT(nchar(30),@date,@TwelveHourClock),13,12)  
WHEN ''h:mm:ss'' THEN SUBSTRING(CONVERT(nchar(30),@date,@TwelveHourClock),13,8)  
--tthe SQL Server BOL syntax, for compatibility  
WHEN ''hh:mi:ss:mmm'' THEN SUBSTRING(CONVERT(nchar(30),@date,@TwelveHourClock),13,12)  
WHEN ''h:mm:ss:ms'' THEN SUBSTRING(CONVERT(nchar(30),@date,@TwelveHourClock),13,12)  
WHEN ''H:m:s'' THEN SUBSTRING(REPLACE('':''+SUBSTRING(CONVERT(nchar(30), @Date,@TwelveHourClock),13,8),'':0'','':''),2,30)  
WHEN ''H:m:s:ms'' THEN SUBSTRING(REPLACE('':''+SUBSTRING(CONVERT(nchar(30), @Date,@TwelveHourClock),13,12),'':0'','':''),2,30)  
--Hours as 00--23  
WHEN ''hh'' THEN REPLACE(SUBSTRING(CONVERT(nchar(30), @Date,@TwelveHourClock),13,2),'' '',''0'')  
--Hours as 0--23  
WHEN ''h'' THEN LTRIM(SUBSTRING(CONVERT(nchar(30), @Date,@TwelveHourClock),13,2))  
--Minutes as 00--59  
WHEN ''Mi'' THEN DATENAME(minute,@date)  
WHEN ''mm'' THEN DATENAME(minute,@date)  
WHEN ''m'' THEN CONVERT(nvarchar(2),DATEPART(minute,@date))  
--Seconds as 0--59  
WHEN ''ss'' THEN DATENAME(second,@date)  
--Seconds as 0--59  
WHEN ''S'' THEN CONVERT(nvarchar(2),DATEPART(second,@date))  
--AM/PM  
WHEN ''ms'' THEN DATENAME(millisecond,@date)  
WHEN ''mmm'' THEN DATENAME(millisecond,@date)  
WHEN ''dy'' THEN DATENAME(dy,@date)  
WHEN ''qq'' THEN DATENAME(qq,@date)  
WHEN ''ww'' THEN DATENAME(ww,@date)  
WHEN ''#'' THEN REVERSE(SUBSTRING(REVERSE(CONVERT(nchar(26), @date,109)),1,2))  
ELSE  
SUBSTRING(@Format,1,@pos-1)  
END  
SET @format=RTRIM(SUBSTRING(@Format,@pos,80))  
END  
END  
RETURN @ReturnedDate  
END

' 
END

GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Getoutputinvcode]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create Function [dbo].[Getoutputinvcode](@INVid int,@orgid int)      
returns varchar(50)      
as      
      
begin        
    declare @OutputInvestigationCode varchar(50)      
    select @OutputInvestigationCode=OutputInvestigationCode from InvestigationOrgMapping where InvestigationID =@INVid and OrgID=@orgid      
 return @OutputInvestigationCode      
end
' 
END

GO

--------------------- Seetha Start -- Report Readiness sMs Clientlevel and Dept level function----------------------

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getclientlevelSMS]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create function [dbo].[fn_getclientlevelSMS]
(
@VISITID bigint,

@OrgID int
)
RETURNS Nvarchar(2) 
AS
BEGIN
Declare @IspatientSMS Nvarchar(2)

set @IsPatientSMS = (Select Top 1 ISNULL(CAD.value,''N'') from PatientVisit PV     
inner join visitclientmapping vcm on vcm.visitid=PV.PatientVisitid and PV.orgid=VCM.orgid and isnull(VCM.isactive,''Y'')=''Y''    
inner join Clientmaster CM on CM.clientid=VCM.ClientID and CM.orgid=VCM.orgid   
inner join ClientAttributesDetails CAD on CAD.Clientid=CM.ClientID and CAD.Orgid=CM.Orgid     
Inner join ClientAttributes CA on CA.AttributeID=CAD.AttributesID and isnull(CA.LangCode,''en-GB'')=''en-GB''   and CA.attributestype=''Notify''    
Where PV.PatientVisitID=@VISITID and CA.AttributeCode=''CL_SMS'' and PV.Orgid=@OrgID  and ISNULL(PV.VisitType,0)=0  
 ) 

 RETURN @IspatientSMS

END
' 
END

GO




------------------------------------ Dept Level Funtion -----------------------------------------


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getDeptlevelSMS]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create function [dbo].[fn_getDeptlevelSMS]
(
@VISITID bigint,

@OrgID int
)
RETURNS Nvarchar(2) 
AS
BEGIN
DECLARE @TblDeptlevelSMS TABLE (  
  Testname varchar(100)
  ,Deptname varchar(50)  
 ,IsClientSMS bit      
 ,Status VarCHAR(50)
 ,Accessionnumber bigint      
 )     

Declare @smsaccessionnumber nvarchar(max),@smsaccessionnumberoutput nvarchar(max),@accessionno bigint
 select @smsaccessionnumber=AdditionalContext from notifications where orgid=@OrgID and identityid=@VISITID and actiontype=''SMS'' and status=''Completed''
set @smsaccessionnumberoutput= dbo.fnsplitaccessionnumber(@smsaccessionnumber)

Declare @tblaccessionno table (Accessionnumber bigint)

Insert into @tblaccessionno
select * from dbo.fnsplit(@smsaccessionnumberoutput,'','')
  Insert into @TblDeptlevelSMS
select  OI.Name,IDM.DeptName,IDM.IsClientSMS, OI.Status,OI.AccessionNumber from Orderedinvestigations OI
Inner join MISOrderedinvestigations MOI on 
MOI.AccessionNumber= OI.AccessionNumber and MoI.Orgid=OI.OrgID
Inner Join MISordereddept MOID on MOID.AccessionNumber=MOI.AccessionNumber

Inner Join InvDeptMaster IDM on IDM.DeptID=MOID.Deptid  and IDM.OrgID=MOI.Orgid

where OI.visitID=@VISITID and OI.OrgID=@OrgID and OI.Status not in (''OutSource'')



delete from @TblDeptlevelSMS where IsClientSMS=0 and Accessionnumber in (select Accessionnumber from @tblaccessionno )

Declare @TrueFlagcount  int, @FalseFlagcount int 

select @TrueFlagcount= (select Count(*) from @TblDeptlevelSMS where IsClientSMS =1) 
Select @FalseFlagcount= (select Count(*) from @TblDeptlevelSMS where IsClientSMS =0)

Declare @IsDeptlevelSMSTrue char(1) = ''N'',@IsDeptlevelSMSFalse char(1) = ''N''


IF (@TrueFlagcount = (select Count(*) from @TblDeptlevelSMS where IsClientSMS =1 and status=''Approve''))
BEGIN
Set @IsDeptlevelSMSTrue =''Y''
ENd
else 
BEGIN
Set @IsDeptlevelSMSTrue =''N''
ENd


If Exists(select 1 from @TblDeptlevelSMS where IsClientSMS =0 and status=''Approve'')
BEGIN
Set @IsDeptlevelSMSFalse =''Y''
END

If(@IsDeptlevelSMSFalse = ''Y'')
BEGIN
Set @IsDeptlevelSMSTrue=@IsDeptlevelSMSFalse
END

RETURN @IsDeptlevelSMSTrue

END
' 
END

GO


----------------------------------------------- Seetha End --------------------------------------------------

---------------------------- Accessionnumeber split funtion ---------------

     
     IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnsplitaccessionnumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create function dbo.fnsplitaccessionnumber
     (
      @String Nvarchar(max)
     )
     Returns nvarchar(Max)  
     AS  
     BEGIN  
      DECLARE @xml XML;
      SET @xml=@String;
      Declare @ano nvarchar(max)
      SELECT @ano = @xml.value(''(/ContextInfo/AccessionNumber)[1]'', ''varchar(max)'')    

     Return @ano
     END' 
END

GO

----------------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_getDeptlevelEMail]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
Create function [dbo].[fn_getDeptlevelEmail]
(
@VISITID bigint,

@OrgID int
)
RETURNS Nvarchar(2) 
AS
BEGIN
DECLARE @TblDeptlevelEMail TABLE (  
  Testname varchar(100)
  ,Deptname varchar(50)  
 ,IsDeptEmail bit      
 ,Status VarCHAR(50)
 ,Accessionnumber bigint      
 )     

Declare @Emailaccessionnumber nvarchar(max),@Emailaccessionnumberoutput nvarchar(max),@accessionno bigint
 select @Emailaccessionnumber=AdditionalContext from notifications where orgid=@OrgID and identityid=@VISITID and actiontype=''Email'' and status=''Completed''
set @Emailaccessionnumberoutput= dbo.fnsplitaccessionnumber(@Emailaccessionnumber)

Declare @tblaccessionno table (Accessionnumber bigint)

Insert into @tblaccessionno
select * from dbo.fnsplit(@Emailaccessionnumberoutput,'','')
 
 
 Insert into @TblDeptlevelEMail
select  OI.Name,IDM.DeptName,IDM.IsDeptLevelEMail, OI.Status,OI.AccessionNumber from Orderedinvestigations OI
Inner join MISOrderedinvestigations MOI on 
MOI.AccessionNumber= OI.AccessionNumber and MoI.Orgid=OI.OrgID
Inner Join MISordereddept MOID on MOID.AccessionNumber=MOI.AccessionNumber

Inner Join InvDeptMaster IDM on IDM.DeptID=MOID.Deptid  and IDM.OrgID=MOI.Orgid
Inner Join InvestigationStatusConfig ISC on ISC.Status=OI.Status and  ISC.OrgID=OI.OrgID and ISC.Statustype=''Include'' and ISC.Actiontype=''Email'' 

where OI.visitID=@VISITID and OI.OrgID=@OrgID and OI.Status Not in (''Cancel'',''Retest'')





delete from @TblDeptlevelEMail where IsDeptEmail=0 and Accessionnumber in (select Accessionnumber from @tblaccessionno )

Declare @TrueFlagcount  int, @FalseFlagcount int 

select @TrueFlagcount= (select Count(*) from @TblDeptlevelEMail where IsDeptEmail =1) 
Select @FalseFlagcount= (select Count(*) from @TblDeptlevelEMail where IsDeptEmail =0)

Declare @IsDeptlevelEmailTrue char(1) = ''N'',@IsDeptlevelEmailFalse char(1) = ''N''


IF (@TrueFlagcount = (select Count(*) from @TblDeptlevelEMail where IsDeptEmail =1 and status=''Approve''))
BEGIN
Set @IsDeptlevelEmailTrue =''Y''
ENd
else 
BEGIN
Set @IsDeptlevelEmailTrue =''N''
ENd


If Exists(select 1 from @TblDeptlevelEMail where IsDeptEmail =0 and status=''Approve'')
BEGIN
Set @IsDeptlevelEmailFalse =''Y''
END

If(@IsDeptlevelEmailFalse = ''Y'')
BEGIN
Set @IsDeptlevelEmailTrue=@IsDeptlevelEmailFalse
END
RETURN @IsDeptlevelEmailTrue
END
' 
END

GO

--------------------------------------------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_SplitString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fn_SplitString] 
(
@str nvarchar(255)
)
RETURNS nvarchar(255)
AS
BEGIN
		DECLARE @str1 nvarchar(255)
		SET @str = substring(@str,charindex(''/'',@str)+1,len(@str))  
		SET @str1= CASE WHEN charindex(''/'',@str) >0 THEN  substring(@str,1,(charindex(''/'',@str)-1)) ELSE @str END
		Return @str1
END
'
END

GO

------------------------- HomeCollection Start -------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
   DROP FUNCTION [dbo].[fnGetPatientID]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetPatientID]
(
	@BookingID bigint,
	@OrgID int
)
  RETURNS bigint
AS
BEGIN
	DECLARE @PatientID bigint,    @ExtRefNo nvarchar(50),  @HHubID nvarchar(50),
           @Name nvarchar(300),  @Gender nchar(2),        @Mob nvarchar(50),
           @DOB nvarchar(10),    @UrnNo nvarchar(30),     @BkID bigint,
		   @Email nvarchar(30),  @PID  bigint,@ERPPatientNumber NVARCHAR(300)
   
   SELECT @BkID = BookingID,                     @Name = PatientName,              @Mob = RIGHT(PhoneNumber,10),     @Gender = Sex,          
	      @DOB = CONVERT(VARCHAR(10), DOB, 103), @Email = Isnull(LTRIM(Email),''''),  @HHubID = Isnull(HealthHubID,''''), @UrnNo = isnull(LTRIM(Urno),''''),
		  @ExtRefNo = ExternalRefNo,             @PatientID = ISNULL(PatientID,-1) , @ERPPatientNumber=ISNULL(ERPPatientNumber,'''')
   FROM Bookings with(nolock) WHERE BookingID = @BookingID and OrgID = @OrgID

   IF (@HHubID !='''')
     BEGIN
       IF EXISTS (SELECT 1 FROM Patient with(Nolock) WHERE LTRIM(HealthHubID) = @HHubID and OrgID = @OrgID)
	     BEGIN
		    SELECT TOP 1 @PatientID = PatientID FROM Patient with(Nolock) WHERE LTRIM(HealthHubID) = @HHubID and OrgID = @OrgID
		 END
     END
   ELSE IF (@UrnNo !='''')
     BEGIN
	   IF EXISTS (SELECT 1 FROM Patient with(Nolock) WHERE LTRIM(URNO) = @UrnNo and OrgID = @OrgID)
	     BEGIN
		    SELECT TOP 1 @PatientID = PatientID FROM Patient with(Nolock) WHERE LTRIM(URNO) = @UrnNo and OrgID = @OrgID
		 END
	 END
	  ELSE IF @ERPPatientNumber!=''''
	 BEGIN
		SELECT TOP 1 @PatientID = PatientID FROM Patient with(Nolock) WHERE LTRIM(PatientNumber) = @ERPPatientNumber AND OrgID=@OrgID
	 END
   ELSE IF (@Name !='''' AND @DOB !='''' AND @Mob !='''' AND @Gender !='''' AND @Email !='''')
     BEGIN
	   IF EXISTS (SELECT 1 FROM Patient P with(Nolock) 
	              INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID
	               WHERE P.Name = @Name
					  AND CONVERT(VARCHAR(10),P.DOB, 103) = @DOB
					  AND P.SEX = @Gender 
				      AND LTRIM(P.Email) = @Email
					  AND RIGHT(PA.MobileNumber,10) = @Mob and OrgID = @OrgID)
	     BEGIN
		    SELECT TOP 1 @PatientID = P.PatientID 
			    FROM Patient P with(Nolock) 
			    INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID
			    WHERE P.Name = @Name 
				     AND CONVERT(VARCHAR(10),DOB, 103) = @DOB 
			         AND P.Sex = @Gender 
					 AND LTRIM(Email) = @Email
			         AND RIGHT(PA.MobileNumber,10) = @Mob and OrgID = @OrgID
		 END
	 END

   IF (@PatientID !='''' -1)
	 SET @PID = @PatientID   -- PatientID
   ELSE 
	 SET @PID = -1   -- Not PatientID
  
    RETURN @PID
END
' 
END

------------------------- HomeCollection End ---------------------


---------------------- Lab code funtion -- Start -----------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FngetLabcodePattern]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[FngetLabcodePattern] (@porgID         BIGINT,
                                            @pID  BIGINT,
                                            @Type            Nvarchar(10)
											)
                                            
RETURNS NVARCHAR(256)
AS
  BEGIN

Declare @Temp VarChar(2), @TempFinal varchar(2)
Set @Temp =  (select IncCharacter from LabCodePattern where OrgID=@porgID and ID=@pID and Type=@Type)

Select @Temp = Case When @Temp = ''ZZ'' 
            Then ''AA''
            Else Case When Right(@Temp, 1) 

= ''Z'' 
                      Then Char(ASCII(Left(@Temp, 1)) + 1) + ''A''
                      Else left(@Temp, 1) + Char(ASCII(Right(@Temp, 1)) + 1)
                      End
            End

			SELECT @TempFinal = @Temp
			RETURN @TempFinal
END' 
END

GO

---------------------- Lab code funtion -- End -------------------------------

--------------------------------------------------------------------------------------------------------------

/****** Object:  UserDefinedFunction [dbo].[NumbertToWordsVietnam]    Script Date: 10/12/2020 3:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NumbertToWordsVietnam]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'  CREATE FUNCTION [dbo].[NumbertToWordsVietnam] (        
 @Number Numeric (38,0) -- Input number with as many as 18 digits        
 ) RETURNS nvarchar(max)        
 AS BEGIN        
 DECLARE @inputNumber nvarchar(38)        
 DECLARE @NumbersTable TABLE (number nchar(2), word nvarchar(10))        
 DECLARE @outputString nvarchar(4000)        
 DECLARE @length INT ,@counter INT, @loops INT, @position INT        
 DECLARE @chunk nchar(3) -- for chunks of 3 numbers        
 DECLARE @tensones nchar(2),@hundreds nchar(1), @tens nchar(1), @ones nchar(1)        
 IF @Number = 0 Return N''SỐ KHÔNG''        
 IF @Number< 0
 BEGIN  
 SELECT @Number=@Number*(-1)
 END
 -- initialize the variables        
 SELECT @inputNumber = CONVERT(nvarchar(38), @Number)        
 , @outputString = ''''        
 , @counter = 1        
 SELECT @length = LEN(@inputNumber)        
 , @position = LEN(@inputNumber) - 2        
 , @loops = LEN(@inputNumber)/3        
 -- make sure there is an extra loop added for the remaining numbers        
 IF LEN(@inputNumber) % 3 <> 0 SET @loops = @loops + 1        
 -- insert data for the numbers and words        
 INSERT INTO @NumbersTable SELECT ''00'', ''''        
 UNION ALL SELECT ''01'', N''MỘT'' UNION ALL SELECT ''02'', N''HAI''        
 UNION ALL SELECT ''03'', N''SỐ BA'' UNION ALL SELECT ''04'', N''BỐN''        
 UNION ALL SELECT ''05'', N''SỐ NĂM'' UNION ALL SELECT ''06'', N''SÁU''        
 UNION ALL SELECT ''07'', N''BẢY'' UNION ALL SELECT ''08'', N''TÁM''        
 UNION ALL SELECT ''09'', N''CHÍN'' UNION ALL SELECT ''10'', N''MƯỜI''        
 UNION ALL SELECT ''11'', N''THANG'' UNION ALL SELECT ''12'', N''MƯỜI HAI''        
 UNION ALL SELECT ''13'', N''THỨ BA'' UNION ALL SELECT ''14'', N''MƯỜI BỐN''        
 UNION ALL SELECT ''15'', N''MƯỜI LĂM'' UNION ALL SELECT ''16'', N''SIXTEEN''        
 UNION ALL SELECT ''17'', N''SEVENTEEN'' UNION ALL SELECT ''18'', N''EIGHTEEN''        
 UNION ALL SELECT ''19'', N''MƯỜI CHÍN'' UNION ALL SELECT ''20'', N''HAI MƯƠI''        
 UNION ALL SELECT ''30'', N''BA MƯƠI'' UNION ALL SELECT ''40'', N''BỐN MƯƠI''        
 UNION ALL SELECT ''50'', N''NĂM MƯƠI'' UNION ALL SELECT ''60'', N''SIXTY''        
 UNION ALL SELECT ''70'', N''BẢY MƯƠI'' UNION ALL SELECT ''80'', N''EIGHTY''        
 UNION ALL SELECT ''90'', N''NINETY''        
 WHILE @counter <= @loops BEGIN        
 -- get chunks of 3 numbers at a time, padded with leading zeros        
 SET @chunk = RIGHT(''000'' + SUBSTRING(@inputNumber, @position, 3), 3)        
 IF @chunk <> ''000'' BEGIN        
 SELECT @tensones = SUBSTRING(@chunk, 2, 2)        
 , @hundreds = SUBSTRING(@chunk, 1, 1)        
 , @tens = SUBSTRING(@chunk, 2, 1)        
 , @ones = SUBSTRING(@chunk, 3, 1)        
 -- If twenty or less, use the word directly from @NumbersTable        
 IF CONVERT(INT, @tensones) <= 20 OR @Ones=''0'' BEGIN        
 SET @outputString = (SELECT word        
 FROM @NumbersTable        
 WHERE @tensones = number)        
 + CASE @counter WHEN 1 THEN '''' -- No name        
 WHEN 2 THEN N'' NGÀN '' WHEN 3 THEN N'' TRIỆU ''        
 WHEN 4 THEN N'' HÀNG TRIỆU '' WHEN 5 THEN N'' TRIỆU ''        
 WHEN 6 THEN N'' TRIỆU TỶ '' WHEN 7 THEN N'' HÀNG TRIỆU ''        
 WHEN 8 THEN N'' SIXTILLION '' WHEN 9 THEN N'' NGHÌN TỶ TỶ ''        
 WHEN 10 THEN N'' TRIỆU ĐỒNG '' WHEN 11 THEN N'' HÀNG TRIỆU ''        
 WHEN 12 THEN N'' QUYẾT ĐỊNH '' WHEN 13 THEN N'' UNDECILLION ''        
 ELSE '''' END        
 + @outputString        
 END        
 ELSE BEGIN -- break down the ones and the tens separately        
 SET @outputString = '' ''        
 + (SELECT word        
 FROM @NumbersTable        
 WHERE @tens + ''0'' = number)        
 + ''-''        
 + (SELECT word        
 FROM @NumbersTable        
 WHERE ''0''+ @ones = number)        
 + CASE @counter WHEN 1 THEN '''' -- No name        
 WHEN 2 THEN N'' NGÀN '' WHEN 3 THEN N'' TRIỆU ''        
 WHEN 4 THEN N'' HÀNG TRIỆU '' WHEN 5 THEN N'' TRIỆU ''        
 WHEN 6 THEN N'' TRIỆU TỶ '' WHEN 7 THEN N'' HÀNG TRIỆU ''        
 WHEN 8 THEN N'' SIXTILLION '' WHEN 9 THEN N'' NGHÌN TỶ TỶ ''        
 WHEN 10 THEN N'' TRIỆU ĐỒNG '' WHEN 11 THEN N'' HÀNG TRIỆU ''        
 WHEN 12 THEN N'' QUYẾT ĐỊNH '' WHEN 13 THEN N'' UNDECILLION ''        
 ELSE '''' END        
 + @outputString        
 END        
 -- now get the hundreds        
 IF @hundreds <> ''0'' BEGIN   
 SET @outputString = (SELECT word        
 FROM @NumbersTable        
 WHERE ''0'' + @hundreds = number)        
 + CASE WHEN @outputString='''' THEN N'' HÀNG TRĂM '' when @outputString <>'''' and @counter=1 
 then N'' HÀNG TRĂM VÀ ''
 else N'' LAKHS ''
 END      
 + @outputString        
 END        
 END        
 SELECT @counter = @counter + 1        
 , @position = @position - 3        
 END        
 -- Remove any double spaces        
 SET @outputString = LTRIM(RTRIM(REPLACE(@outputString, '' '', '' '')))        
 SET @outputstring = UPPER(LEFT(@outputstring, 1)) + SUBSTRING(@outputstring, 2, 4000)        
 RETURN @outputString -- return the result        
 END  
 
' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[NumbertToWordsVietnam]    Script Date: 6/25/2018 4:03:34 PM ******/


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSplitNew]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnSplitNew]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSplitNew]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
 CREATE FUNCTION [dbo].[fnSplitNew](@sInputList [nvarchar](max), @sDelimiter [nvarchar](max) = '','')
RETURNS @List TABLE ( ID INT IDENTITY(1,1),
	[item] [nvarchar](4000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) WITH EXECUTE AS CALLER
AS 
BEGIN    
DECLARE @sItem NVARCHAR(4000)    
WHILE CHARINDEX(@sDelimiter,@sInputList,0) <> 0     
BEGIN     
 SELECT      
  @sItem=RTRIM(LTRIM(SUBSTRING(@sInputList,1,CHARINDEX(@sDelimiter,@sInputList,0)-1))),      
  @sInputList=RTRIM(LTRIM(SUBSTRING(@sInputList,CHARINDEX(@sDelimiter,@sInputList,0)+LEN(@sDelimiter),LEN(@sInputList))))      
     
 IF LEN(@sItem) > 0      
  INSERT INTO @List     
  SELECT @sItem     
 END     
 IF LEN(@sInputList) > 0     
  INSERT INTO @List SELECT @sInputList -- Put the last item in    
 RETURN    
 END 

  ' 
END

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientNumber_BulkRegistration]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetPatientNumber_BulkRegistration]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientNumber_BulkRegistration]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetPatientNumber_BulkRegistration]      
(      
      
@BulkRegValidateParam [BulkRegValidateParam] readonly       
)      
  RETURNS NVARCHAR(200)      
AS      
BEGIN      
 DECLARE @PatientID bigint,  @HHubID nvarchar(50),      
           @Name nvarchar(300),  @Gender nchar(2), @Mob nvarchar(50),      
           @DOB nvarchar(10),    @UrnNo nvarchar(30),      
     @PID  bigint,@ERPPatientNumber NVARCHAR(300),      
     @EmployeeID NVARCHAR(50),@PatientNumber NVARCHAR(200),      
     @PNo NVARCHAR(200),      
     @OrgId INT , @PassportNo   NVARCHAR(50)   
   SET @PNo=''''      
   SELECT @Name = PatientName,                    
   @Mob = RIGHT(MobileNo,10),     
   @Gender = Sex,                
       @DOB = CONVERT(VARCHAR(10), DOB, 103),       
    @HHubID = Isnull(HealthHubID,''''),       

    @EmployeeID=ISNULL(EmployeeID,''''),      
    @OrgId=OrgId   ,@PassportNo = PassportNo   
   FROM @BulkRegValidateParam        
   
      
   IF (@HHubID !='''')      
     BEGIN      
       IF EXISTS (SELECT 1 FROM Patient with(Nolock) WHERE LTRIM(HealthHubID) = @HHubID and OrgID = @OrgID)      
      BEGIN      
      SELECT TOP 1 @PNo = PatientNumber       
   FROM Patient with(Nolock)       
   WHERE LTRIM(HealthHubID) = @HHubID and OrgID = @OrgID      
   END      
     END      

 if(len(@PNo)<=1)      
 BEGIN      
     
  IF (@EmployeeID!='''' AND @Name !='''' AND  @Gender !='''')      
  BEGIN      
  SELECT TOP 1 @PNo = PatientNumber  FROM Patient P with(Nolock)      
 INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID      
  WHERE TRIM(EmployeeID) = @EmployeeID       
  AND OrgID=@OrgID      
  AND Sex = @Gender        
  AND Name = @Name      

 END      
 END      
   
 if(len(@PNo)<=1)      
 begin      
  IF (trim(@Name) !='''' AND trim(@Mob) !='''' AND @Gender !='''' )   
     BEGIN      
    IF EXISTS (SELECT 1 FROM Patient P with(Nolock)       
               INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID      
                WHERE trim(P.Name) = @Name      
       AND P.SEX = @Gender       
          AND RIGHT(PA.MobileNumber,10) = @Mob and OrgID = @OrgID)      
      BEGIN      
      
          
      SELECT TOP 1 @PNo = PatientNumber       
       FROM Patient P with(Nolock)       
       INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID      
       WHERE P.Name = @Name       
             
            AND P.Sex = @Gender       
      AND RIGHT(PA.MobileNumber,10) = @Mob and OrgID = @OrgID      
           
   END      
  END      
 end      
  if(len(@PNo)<=1)      
 begin      
    IF (@UrnNo !='''' and @Name !='''')      
     BEGIN      
    IF EXISTS (SELECT 1 FROM Patient with(Nolock) WHERE TRIM(URNO) = @UrnNo and OrgID = @OrgID)      
      BEGIN      
      SELECT TOP 1 @PNo = PatientNumber  FROM Patient with(Nolock) WHERE TRIM(URNO) = @UrnNo and OrgID = @OrgID      
   and Name =@Name      
   END      
  END      
  end     
    
  if(len(@PNo)<=1)      
 begin      
    IF (@PassportNo !='''' and @Name !='''')      
     BEGIN      
    IF EXISTS (SELECT 1 FROM Patient P with(Nolock) Inner Join Patientvisit PV on PV.PatientID=P.PatientID  
 WHERE TRIM(Pv.PassportNumber) = @PassportNo and P.OrgID = @OrgID)      
      BEGIN      
      SELECT TOP 1 @PNo = PatientNumber  FROM Patient P with(Nolock)   
   Inner Join Patientvisit PV on PV.PatientID=P.PatientID  
   WHERE TRIM(Pv.PassportNumber) = @PassportNo and P.OrgID = @OrgID      
   and Name =@Name      
   END      
  END      
  end   

      
        
       
      
       
          
      
   IF (@PNo !='''' )      
  SET @PatientNumber = @PNo   
   ELSE       
  SET @PatientNumber = ''''      
        
    RETURN @PatientNumber      
END      
        
  ' 
END

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnGetPatientNumber]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnGetPatientNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[fnGetPatientNumber]      
      
(      
      
                @BookingID bigint,      
      
                @OrgID int      
      
)      
      
  RETURNS NVARCHAR(200)      
      
AS      
      
BEGIN      
      
                DECLARE @PatientID bigint,    @ExtRefNo nvarchar(50),  @HHubID nvarchar(50),      
      
           @Name nvarchar(300),  @Gender nchar(2),        @Mob nvarchar(50),      
      
           @DOB nvarchar(10),    @UrnNo nvarchar(30),     @BkID bigint,      
      
                                   @Email nvarchar(30),  @PID  bigint,@ERPPatientNumber NVARCHAR(300),      
      
                                   @EmployeeID NVARCHAR(50),@PatientNumber NVARCHAR(200),@PNo NVARCHAR(200)      
      
   SET @PNo=''''      
      
   SELECT @BkID = BookingID,                     @Name = PatientName,                   
      
   @Mob = RIGHT(PhoneNumber,10),     @Gender = Sex,               
      
                      @DOB = CONVERT(VARCHAR(10), DOB, 103), @Email = Isnull(TRIM(Email),''),  @HHubID = Isnull(HealthHubID,''), @UrnNo = isnull(TRIM(Urno),''),      
      
                                  @ExtRefNo = ExternalRefNo,             @PatientID = ISNULL(PatientID,-1) , @ERPPatientNumber=ISNULL(ERPPatientNumber,''),      
      
                                  @EmployeeID=ISNULL(EmployeeID,''),@PatientNumber=ISNULL(PatientNumber,'')      
      
   FROM Bookings with(nolock) WHERE BookingID = @BookingID and OrgID = @OrgID      
      
       
      
   IF (@HHubID !='''')      
      
     BEGIN      
      
       IF EXISTS (SELECT 1 FROM Patient with(Nolock) WHERE LTRIM(HealthHubID) = @HHubID and OrgID = @OrgID)      
      
                     BEGIN      
      
                                    SELECT TOP 1 @PNo = PatientNumber      
      
                                                FROM Patient with(Nolock)      
      
                                                WHERE LTRIM(HealthHubID) = @HHubID and OrgID = @OrgID      
      
                                END      
      
     END      
      
                if(len(@PNo)<=1)      
      
BEGIN      
      
  IF (@EmployeeID!='''' AND @Name !='''' AND  @Gender !='''')      
      
                BEGIN      
      
                                SELECT TOP 1 @PNo = PatientNumber  FROM Patient P with(Nolock)      
    
            
                              INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID      
      
                                WHERE TRIM(EmployeeID) = @EmployeeID      
      
                                AND OrgID=@OrgID      
      
                                AND Sex = @Gender       
      
                                AND Name = @Name      
    
            --AND RIGHT(PA.MobileNumber,10) = @Mob     
      
 END      
      
end      
      
if(len(@PNo)<=1)      
      
BEGIN      
      
   IF (@Name !='''' AND @Mob !='''' AND @Gender !='''' )----- DOB removed since DOB is calculated DOB      
      
     BEGIN      
      
                   IF EXISTS (SELECT 1 FROM Patient P with(Nolock)      
      
                              INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID      
      
                               WHERE P.Name = @Name      
      
                                                                                  AND P.SEX = @Gender      
      
                                                                      AND RIGHT(PA.MobileNumber,10) = @Mob and OrgID = @OrgID)      
      
                     BEGIN      
      
                                    SELECT TOP 1 @PNo = PatientNumber      
      
                                                    FROM Patient P with(Nolock)      
      
                                                    INNER JOIN patientaddress PA with(Nolock) ON P.PatientID = PA.PatientID      
      
                                                    WHERE P.Name = @Name      
      
                                                                     --AND CONVERT(VARCHAR(10),DOB, 103) = @DOB      
      
                                                         AND P.Sex = @Gender      
      
                                                                                 AND RIGHT(PA.MobileNumber,10) = @Mob and OrgID = @OrgID      
      
                                END      
      
                END      
      
                end      
      
                if(len(@PNo)<=1)      
      
BEGIN      
      
    IF (@UrnNo !='''')      
      
     BEGIN      
      
                   IF EXISTS (SELECT 1 FROM Patient with(Nolock) WHERE TRIM(URNO) = @UrnNo and OrgID = @OrgID)      
      
                     BEGIN      
      
                                    SELECT TOP 1 @PNo = PatientNumber  FROM Patient with(Nolock) WHERE TRIM(URNO) = @UrnNo and OrgID = @OrgID      
      
                                END      
      
                END      
      
                end      
      
                if(len(@PNo)<=1)      
      
BEGIN      
      
                IF @ERPPatientNumber!=''''      
      
                BEGIN      
      
                                SELECT TOP 1 @PNo = PatientNumber  FROM Patient with(Nolock) WHERE LTRIM(PatientNumber) = @ERPPatientNumber AND OrgID=@OrgID      
      
                END      
      
                ----      
      
                end      
      
       
      
       
      
   IF (@PNo !='''' )      
      
                SET @PatientNumber = @PNo  -- PatietNumber      
      
   ELSE      
      
                 SET @PatientNumber = ''''   -- Not PatientNumber      
      
       
      
    RETURN @PatientNumber      
      
       
      
END
  ' 
END

GO
