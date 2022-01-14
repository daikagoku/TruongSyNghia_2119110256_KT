use master
go
drop database if exists HR
go
create database HR
go

use HR 
go

drop table if exists Employee
go
create table Employee(
	id varchar(10)  primary key,
	name nvarchar(30),
	date_birth date,
	gender bit,
	place_birth nvarchar(100),
	department_id  varchar(10)
)

go
drop table if exists Department
go 
create table Department(
	id varchar(10)  primary key,
	name nvarchar(30)
)



go
drop procedure if exists pr_getEmployees
go
create procedure pr_getEmployees 
as
begin
	select *
	from Employee e
end
go
drop procedure if exists pr_getEmployee
go
create procedure pr_getEmployee
@id varchar(10)
as
begin
	select *
	from Employee e
	where id like @id
end


go
drop procedure if exists pr_postEmployee
go
create procedure pr_postEmployee
	@id varchar(10),
	@name nvarchar(30),
	@date_birth date,
	@gender bit,
	@place_birth nvarchar(100),
	@department_id  varchar(10)
as
begin
	insert into Employee(id,name,date_birth,gender,place_birth,department_id) values(@id,@name,@date_birth,@gender,@place_birth,@department_id)
end

go
drop procedure if exists pr_putEmployee
go
create procedure pr_putEmployee
	@id varchar(10),
	@name nvarchar(30),
	@date_birth date,
	@gender bit,
	@place_birth nvarchar(100),
	@department_id  varchar(10)
as
begin
	update Employee
	set name = @name,
		date_birth = @date_birth,
		gender = @gender,
		place_birth = @place_birth,
		department_id = @department_id
	where id like @id
end

go
drop procedure if exists pr_deleteEmployee
go
create procedure pr_deleteEmployee
	@id varchar(10)
as
begin
	delete 
	from Employee
	where id like @id
end


go
drop procedure if exists pr_getDepartments
go
create procedure pr_getDepartments 
as
begin
	select *
	from Department d
end
go
drop procedure if exists pr_getDepartment
go
create procedure pr_getDepartment
@id varchar(10)
as
begin
	select *
	from Department d
	where id like @id
end
go
drop procedure if exists pr_postDepartment
go
create procedure pr_postDepartment
	@id varchar(10),
	@name nvarchar(30)
as
begin
	insert into Department(id,name) values(@id,@name)
end
go
 
exec pr_postDepartment 'IT',N'Công nghệ thông tin';
exec pr_postDepartment 'KT',N'Kế toán';
exec pr_postDepartment 'KSNB',N'Kiểm soát nội bộ';

go
drop procedure if exists pr_putDepartment
go
create procedure pr_putDepartment
	@id varchar(10),
	@name nvarchar(30)
as
begin
	update Department set name = @name where id like @id
end

go
drop procedure if exists pr_deleteDepartment
go
create procedure pr_deleteDepartment
	@id varchar(10)
as
begin
	delete from Department where id like @id
end

go
exec pr_getEmployees;
exec pr_getDepartments;