select * from loginlocationmapping where orgid=69
select * from sys.tables where name like '%Login%'
select * from LoginDeptMap

select * from roledeptmap

select * from role 


select * from users where organisationid=69

select * from users 

select * from login where organisationid=69 and loginname not like '%P1%'

select * into BKA_LOGIN_69 from login where loginid in (
select  distinct loginid from loginrole where roleid in (select roleid from role where orgid=69) and  roleid<>3097)

select U.* into BKA_Users_69 from users U
inner join #tmp T on U.LoginID=T.loginID
where U.organisationid=69

select  * into #tmp1 from loginrole where roleid in (select roleid from role where orgid=69) and  roleid<>3097


select * from #tmp1 

select R.rolename,L.Loginname,T.* into BKA_loginrole_69 from #tmp1 T
inner join Role R on T.Roleid=R.RoleID
inner join Login L on L.Loginid=T.Loginid

select * from  BKA_loginrole_69

select U.Name,UA.* into BKA_Useraddress from BKA_Users_69 U
inner join useraddress UA on UA.Userid=U.Userid

select * from BKA_LOGIN_69
select * from BKA_Users_69
select * from BKA_loginrole_69
select * from BKA_Useraddress

select * from role where orgid=69

select * from login where loginid=4138