
Truncate Table InvClientMaster
insert into InvClientMaster(ClientID,OrgID,ClientName,ClientTypeID,ActiveYN)values(1,28,'LP',1,'Y')
insert into InvClientMaster(ClientID,OrgID,ClientName,ClientTypeID,ActiveYN)values(2,28,'SP',1,'Y')

update PCClientMapping set ClientID =2 where ClientID =1801 and OrgID =28
update PCClientMapping set ClientID =1 where ClientID =1802 and OrgID =28

Truncate table LabConsumables

insert into LabConsumables(ConsumableID,ConsumableName,OrgID)values(1,'MS CD (PER DISC)',28)
insert into LabConsumables(ConsumableID,ConsumableName,OrgID)values(2,'MS CONTRAST FOR CT, ADDITIONAL (PER 50 MLS)',28)
insert into LabConsumables(ConsumableID,ConsumableName,OrgID)values(3,'MS CONTRAST INJECTION FOR MRI',28)
insert into LabConsumables(ConsumableID,ConsumableName,OrgID)values(4,'MS FILM REPRINT (PER SHEET)',28)
insert into LabConsumables(ConsumableID,ConsumableName,OrgID)values(5,'MS REPORT',28)


    update RoleDeptMap set DeptID= 1 where DeptID =1711
    update RoleDeptMap set DeptID= 2 where DeptID =1712
    update RoleDeptMap set DeptID= 3 where DeptID =1713
    update RoleDeptMap set DeptID= 4 where DeptID =1714