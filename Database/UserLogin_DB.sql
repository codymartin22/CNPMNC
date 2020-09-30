create database LoginCNPMNC
use LoginCNPMNC
create table UserLogin(
	Account varchar(20),
	Pass varbinary(20),
	Email varchar(100),
	UserName varchar(50)
)
go

create procedure Add_User @UserAcc varchar(20),@Pass varchar(20),@Email varchar(100), @UserName varchar(50)
as
begin
	insert into UserLogin values (@UserAcc,HASHBYTES('MD5',@Pass),@Email,@UserName)
end
go
create proc User_Login @UserAcc varchar(20),@Pass varchar(20)
as
begin
	select * from UserLogin where Account = @UserAcc and Pass = HASHBYTES('MD5',@Pass)
end