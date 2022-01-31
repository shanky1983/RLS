
--------------------------------------------------Tables script---------------------------------------------
if not exists (select * from sysobjects where name='RuleMaster' and xtype='U')
   BEGIN
 
CREATE TABLE [dbo].[RuleMaster](
	[RuleID] [int] IDENTITY(1,1) NOT NULL,
	[TypeID] [int] NULL,
	[MinAmount] [varchar](150) NULL,
	[MaxAmount] [varchar](150) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]

END
GO
   


if not exists (select * from sysobjects where name='RuleApprovelMaster' and xtype='U')
  BEGIN

CREATE TABLE [dbo].[RuleApprovelMaster](
	[RuleApprovelID] [int] IDENTITY(1,1) NOT NULL,
	[RuleID] [int] NULL,
	[SeqNo] [int] NULL,
	[StatusID] [int] NULL,
	[IsActive] [bit] NULL,
	[NextActionID] [int] NULL,
	[OrgID] [int] NULL,
	[NextStatusID] [int] NULL,
	[RoleID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO




---------

Declare @RuleID int
Declare @OrgID int
Declare @RoleID int
Declare @TaskActionID int


Set @OrgID=112
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=2 and MinAmount=0)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select 2,0,5000,@OrgID,getdate(),99999
End
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=2 and MinAmount=5001)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select 2,5001,10000,@OrgID,getdate(),99999
end
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=2 and MinAmount=10001)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select 2,10001,50000,@OrgID,getdate(),99999
End

select @RuleID=RuleID from RuleMaster where TypeID=2 and OrgID=@OrgID
select @RoleID=RoleID from Role where OrgID=@OrgID and RoleName='InventoryAdmin'

IF Not Exists (select * from TaskActions where ActionName='StockReceiveApprovel')
Begin
INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable]) 
 select max(TaskActionID)+1, N'StockReceiveApprovel', N'~\CentralReceiving\UpdateStockReceivedByCategory.aspx?ID={ID}&SRDNo={No}&SeqNo={SeqNo}&RuleID={RuleID}&StatusID={StatusID}', N'Approve StockReceive for (SRDNo:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N' 	from Taskactions
End
select @TaskActionID=TaskActionID from TaskActions where ActionName='StockReceiveApprovel'

If Not exists (select * from TaskActionOrgMapping where TaskActionID=@TaskActionID and RoleID=@RoleID)
begin
	Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)
	select @TaskActionID,@RoleID,@OrgID
End
--INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (82, N'PurchaseOrderApprovel', N'~\Inventory\CentralPurchaseOrder.aspx?ID={ID}&PONo={No}&SeqNo={SeqNo}&RuleID={RuleID}&StatusID={StatusID}', N'Approve Purchase Order for (PONo:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N', NULL, NULL, NULL, NULL)
--INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (83, N'StockReceiveApprovel', N'~\Inventory\UpdateStockReceivedByCategory.aspx?ID={ID}&SRDNo={No}&SeqNo={SeqNo}&RuleID={RuleID}&StatusID={StatusID}', N'Approve StockReceive for (SRDNo:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N', NULL, NULL, NULL, NULL)

	insert into RuleApprovelMaster(RuleID,SeqNo,StatusID,IsActive,NextActionID,OrgID,NextStatusID,RoleID)
	select RM.RuleID,1,9,1,@TaskActionID,@OrgID,6,@RoleID from RuleMaster RM 
	left join RuleApprovelMaster RAM on RM.RuleID=RAM.RuleID  and RAM.OrgID=@OrgID 
	 where  RM.TypeID=2 and RAM.RuleApprovelID is null
	


-----------------------------------------------------------------------------------------------------------------------------------------------------------

GO
Declare @RuleID int
Declare @OrgID int
Declare @RoleID int
Declare @TaskActionID int


Set @OrgID=112
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=1 and MinAmount=0)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select 1,0,5000,@OrgID,getdate(),99999
End
	
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=1 and MinAmount=5001)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select 1,5001,10000,@OrgID,getdate(),99999
end

If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=1 and MinAmount=10001)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select 1,10001,50000,@OrgID,getdate(),99999
End

select @RuleID=RuleID from RuleMaster where TypeID=1 and OrgID=@OrgID
select @RoleID=RoleID from Role where OrgID=@OrgID and RoleName='InventoryAdmin'

IF Not Exists (select * from TaskActions where ActionName='PurchaseOrderApprovel')
Begin
INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable] ) 
 select max(TaskActionID)+1, N'PurchaseOrderApprovel', N'~\CentralPurchasing\CentralPurchaseOrder.aspx?ID={ID}&PONo={No}&SeqNo={SeqNo}&RuleID={RuleID}&StatusID={StatusID}', N'Approve Purchase Order for (PONo:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N'
	from Taskactions
End
select @TaskActionID=TaskActionID from TaskActions where ActionName='PurchaseOrderApprovel'

If Not exists (select * from TaskActionOrgMapping where TaskActionID=@TaskActionID and RoleID=@RoleID)
begin
	Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)
	select @TaskActionID,@RoleID,@OrgID
End
--INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (12, N'PurchaseOrderApprovel', N'~\Inventory\CentralPurchaseOrder.aspx?ID={ID}&PONo={No}&SeqNo={SeqNo}&RuleID={RuleID}&StatusID={StatusID}', N'Approve Purchase Order for (PONo:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N', NULL, NULL, NULL, NULL)
--INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (13, N'StockReceiveApprovel', N'~\Inventory\UpdateStockReceivedByCategory.aspx?ID={ID}&SRDNo={No}&SeqNo={SeqNo}&RuleID={RuleID}&StatusID={StatusID}', N'Approve StockReceive for (SRDNo:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N', NULL, NULL, NULL, NULL)

	insert into RuleApprovelMaster(RuleID,SeqNo,StatusID,IsActive,NextActionID,OrgID,NextStatusID,RoleID,CreatedAt,CreatedBy)
	select RM.RuleID,1,5,1,@TaskActionID,@OrgID,1,@RoleID,GETDATE(),99999 from RuleMaster RM 
	left join RuleApprovelMaster RAM on RM.RuleID=RAM.RuleID and RM.OrgID=Ram.OrgID and RM.OrgID=@OrgID
	 where RM.TypeID=1 and RAM.RuleApprovelID is null
---------------------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------
