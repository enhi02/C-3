create database PS18441_lab3;
use PS18441_lab3;
go

create table lop(
	malop nchar(10) primary key,
	tenlop nvarchar(50),
	siso int
);

create table hocsinh(
	maHS int primary key,
	tenHS nvarchar(255),
	ngaysinh date,
	diachi nvarchar(255),
	DTB float,
	malop nchar(10)
	constraint FK_HS_Lop foreign key (malop) references lop(malop)
);select * from lop
select * from hocsinh
