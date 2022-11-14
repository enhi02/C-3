create database ASM_C3
use ASM_C3
go



drop table Users
drop table Students
drop table Grade

create table Students(
	MASV nvarchar(20) primary key,
	HoTen nvarchar(50),
	Email nvarchar(50),
	SDT nvarchar(20),
	GioiTinh nvarchar(10),
	DiaChi nvarchar(255),
	Hinh nvarchar(200)
)

create table Grade(
	ID nvarchar(20) primary key,
	MASV nvarchar(20),
	TiengAnh int,
	TinHoc int,
	GDTC int
	constraint FK FOREIGN KEY (MASV) references Students(MASV)
)

create table users_login(
	ID_User nvarchar(20),
	username nvarchar(50),
	passwork nvarchar(50),
	roles nvarchar(50)
)
