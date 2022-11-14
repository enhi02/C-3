CREATE DATABASE thi;
use thi;
go

create table NhanVien
(
	maNV nvarchar(20) primary key,
	hoTenNV nvarchar(50),
	GioiTinh nvarchar(10),
	hinh nvarchar(255),
	matkhau nvarchar(20),
	vaitro nvarchar(255)
)

select *from NhanVien
drop table NhanVien
