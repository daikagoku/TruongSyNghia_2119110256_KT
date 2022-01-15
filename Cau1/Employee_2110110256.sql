use master
go
drop database if exists HR
go
create database HR
go

use HR 
go

drop table if exists Employee_2119110256
go
create table Employee_2119110256(
	id varchar(10)  primary key,
	name nvarchar(30),
	date_birth date,
	gender bit,
	place_birth nvarchar(100),
	department_id  varchar(10)
)

go
drop table if exists Department_2119110256
go 
create table Department_2119110256(
	id varchar(10)  primary key,
	name nvarchar(30)
)



go
drop procedure if exists pr_getEmployees_2119110256
go
create procedure pr_getEmployees_2119110256 
as
begin
	select *
	from Employee_2119110256 e
end
go
drop procedure if exists pr_getEmployee_2119110256
go
create procedure pr_getEmployee_2119110256
@id varchar(10)
as
begin
	select *
	from Employee_2119110256 e
	where id like @id
end


go
drop procedure if exists pr_postEmployee_2119110256
go
create procedure pr_postEmployee_2119110256
	@id varchar(10),
	@name nvarchar(30),
	@date_birth date,
	@gender bit,
	@place_birth nvarchar(100),
	@department_id  varchar(10)
as
begin
	insert into Employee_2119110256(id,name,date_birth,gender,place_birth,department_id) values(@id,@name,@date_birth,@gender,@place_birth,@department_id)
end

go
drop procedure if exists pr_putEmployee_2119110256
go
create procedure pr_putEmployee_2119110256
	@id varchar(10),
	@name nvarchar(30),
	@date_birth date,
	@gender bit,
	@place_birth nvarchar(100),
	@department_id  varchar(10)
as
begin
	update Employee_2119110256
	set name = @name,
		date_birth = @date_birth,
		gender = @gender,
		place_birth = @place_birth,
		department_id = @department_id
	where id like @id
end

go
drop procedure if exists pr_deleteEmployee_2119110256
go
create procedure pr_deleteEmployee_2119110256
	@id varchar(10)
as
begin
	delete 
	from Employee_2119110256
	where id like @id
end


go
drop procedure if exists pr_getDepartments_2119110256
go
create procedure pr_getDepartments_2119110256 
as
begin
	select *
	from Department_2119110256 d
end
go
drop procedure if exists pr_getDepartment_2119110256
go
create procedure pr_getDepartment_2119110256
@id varchar(10)
as
begin
	select *
	from Department_2119110256 d
	where id like @id
end
go
drop procedure if exists pr_postDepartment_2119110256
go
create procedure pr_postDepartment_2119110256
	@id varchar(10),
	@name nvarchar(30)
as
begin
	insert into Department_2119110256(id,name) values(@id,@name)
end
go
 
exec pr_postDepartment_2119110256 'IT',N'Công nghệ thông tin';
exec pr_postDepartment_2119110256 'KT',N'Kế toán';
exec pr_postDepartment_2119110256 'KSNB',N'Kiểm soát nội bộ';

go
drop procedure if exists pr_putDepartment_2119110256
go
create procedure pr_putDepartment_2119110256
	@id varchar(10),
	@name nvarchar(30)
as
begin
	update Department_2119110256 set name = @name where id like @id
end

go
drop procedure if exists pr_deleteDepartment_2119110256
go
create procedure pr_deleteDepartment_2119110256
	@id varchar(10)
as
begin
	delete from Department_2119110256 where id like @id
end

go
exec pr_getEmployees_2119110256;
exec pr_getDepartments_2119110256;