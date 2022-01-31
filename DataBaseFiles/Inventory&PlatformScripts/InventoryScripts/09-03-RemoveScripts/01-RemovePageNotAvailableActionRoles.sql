declare @orgid int =112
delete ARM from ActionRoleMapping ARM 
inner join  SearchTypeMaster STM on stm.SearchTypeID=arm.SearchTypeID
inner join Role R on r.RoleID=arm.RoleID
left join pages p on p.PageID =arm.RedirectPageID
 where  r.OrgID=@orgid and    p.PageID is null and   SearchTypeName in (
'PurchaseOrder',
'StockReceive',
'StockDamage',
'StockIssued',
'StockReturn',
'IntendSearch',
'Quotation'
)
