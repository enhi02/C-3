create database QLHOCSINH
go
use QLHOCSINH
go
drop table HocSinh
select * from HocSinh
create table HocSinh(
	MaHS Nvarchar(10)  Primary Key,
	TenHS Nvarchar(255),
	NgaySinh date,
	DiaChi Nvarchar(255),
	DTB float,
	MaLop Nvarchar(10)
);
drop table Lop
create table Lop( 
	 MaLop Nvarchar(10) Primary Key,
	 TenLop Nvarchar(225),
	 SiSo float
);
alter table HocSinh add constraint hs_l foreign key(MaLop) references Lop(MaLop)
insert into Lop values('C1','CNTT','4')
insert into Lop values('C2','TKDH','30')
insert into Lop values('C3','QTKD','3')
insert into Lop values('C4','DLKS','10')
insert into Lop values('C5','AITTNT','1')
insert into HocSinh values('01','Khoa','2001/2/10','HCM','8','C1')
insert into HocSinh values('02','Long','2001/4/11','HN','8','C2')
insert into HocSinh values('03','Khiêm','2001/2/19','HCM','8','C3')
insert into HocSinh values('04','Cường','2001/2/1','QN','8','C4')
insert into HocSinh values('05','Tuấn','2001/9/10','HN','8','C5')