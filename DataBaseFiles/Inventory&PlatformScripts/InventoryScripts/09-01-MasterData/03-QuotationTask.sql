declare @TaskActionID int
declare @RoleID int
declare @OrgID int=112
select @RoleID=RoleID from Role where OrgID=@OrgID and RoleName='InventoryAdmin'
declare @StockTypeID int=10




declare @searchtypeID int

if not exists (select * from StockStatus where StockTypeID=@StockTypeID and StockStatusName='Pending')
begin  
Insert into StockStatus(StockStatusID,StockStatusName,StockTypeID)
select MAX(stockstatusid)+1,'Pending',@StockTypeID from StockStatus
end

if not exists (select * from StockStatus where StockTypeID=@StockTypeID and StockStatusName='Completed')
begin  
Insert into StockStatus(StockStatusID,StockStatusName,StockTypeID)
select MAX(stockstatusid)+1,'Completed',@StockTypeID from StockStatus
end



 


If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=@StockTypeID and MinAmount=0)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select @StockTypeID,0,5000,@OrgID,getdate(),99999
End
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=@StockTypeID and MinAmount=5001)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select @StockTypeID,5001,10000,@OrgID,getdate(),99999
end
If not exists (select * from RuleMaster where OrgID=@OrgID and TypeID=@StockTypeID and MinAmount=10001)
Begin
insert into RuleMaster (TypeID,MinAmount,MaxAmount,OrgID,CreatedAt,CreatedBy)
select @StockTypeID,10001,50000,@OrgID,getdate(),99999
End



IF Not Exists (select * from TaskActions where ActionName='Quotation')
Begin
INSERT [dbo].[TaskActions] ([TaskActionID], [ActionName], [RedirectURL], [DisplayTextTemplate], [OrgID], [Category], [RoleID], [ModuleID], [IsShareable],
 [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) 
 select max(TaskActionID)+1, N'Quotation', N'~\Quotation\ProductSupplierRateMapping.aspx?QID={ID}&SID={SID}&QNO={No}','Quotation Approval for  for (QNO:{No})(SupplierName:{SupplierName})', 0, N'Approval Mechanism', 0, NULL, N'N', NULL, NULL, NULL, NULL
	from Taskactions
End
select @TaskActionID=TaskActionID from TaskActions where ActionName='Quotation'

If Not exists (select * from TaskActionOrgMapping where TaskActionID=@TaskActionID and RoleID=@RoleID)
begin
	Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID,createdat,CreatedBy)
	select @TaskActionID,@RoleID,@OrgID,GETDATE(),99999
End

      

declare @StatusID int= (select Max(StockStatusID) from StockStatus where StockTypeID=@StockTypeID and StockStatusName='Pending')
     
	insert into RuleApprovelMaster(RuleID,SeqNo,StatusID,IsActive,NextActionID,OrgID,NextStatusID,RoleID)
	select distinct RM.RuleID,1,@StatusID ,1,@TaskActionID,@OrgID,6,@RoleID from RuleMaster RM 
	left join RuleApprovelMaster RAM on RM.RuleID=RAM.RuleID  and RAM.OrgID=@OrgID  AND NextActionID=@TaskActionID
	 where  RM.TypeID=@StockTypeID and RAM.RuleApprovelID is null
	
	
	set  @StatusID = (select Max(StockStatusID) from StockStatus where StockTypeID=@StockTypeID and StockStatusName='Completed')
     
	insert into RuleApprovelMaster(RuleID,SeqNo,StatusID,IsActive,NextActionID,OrgID,NextStatusID,RoleID)
	select distinct RM.RuleID,1,@StatusID ,1,@TaskActionID,@OrgID,6,@RoleID from RuleMaster RM 
	left join RuleApprovelMaster RAM on RM.RuleID=RAM.RuleID  and RAM.OrgID=@OrgID  AND NextActionID=@TaskActionID
	 where  RM.TypeID=@StockTypeID and RAM.RuleApprovelID is null


--select StockStatusID from StockStatus where StockTypeID=10 and StockStatusName='Pending'

