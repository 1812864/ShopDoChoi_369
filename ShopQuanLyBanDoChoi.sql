use master
--drop database DoChoi
create database DoChoi
go

use DoChoi

create table DangNhap
(
	TenDangNhap nvarchar(30) primary key not null,
	MatKhau nvarchar(30) not null,
	TenNhanVien nvarchar(30),
	ChuCuaHang bit
)

insert into DangNhap values ('Admin', 'P@$$w0rd', N'Đinh Bá Thái Sơn', 1)
insert into DangNhap values ('NhanVien1', 'P@$$w0rd', N'Huỳnh Văn Trung', 0)
insert into DangNhap values ('NhanVien2', 'P@$$w0rd', N'Phạm Minh Tuấn', 0)
insert into DangNhap values ('NhanVien3', 'P@$$w0rd', N'Phạm Văn Tâm', 0)


create table LoaiDoChoi
(
	MaLoai char(5) primary key,
	TenLoai nvarchar(20)
)

insert into LoaiDoChoi values ('LDC01', N'Ô tô')
insert into LoaiDoChoi values ('LDC02', N'Mô hình hoạt hình')
insert into LoaiDoChoi values ('LDC03', N'Đất sét')
insert into LoaiDoChoi values ('LDC04', N'Đồ chơi gỗ')
insert into LoaiDoChoi values ('LDC05', N'Mô hình lắp ráp')
insert into LoaiDoChoi values ('LDC06', N'Trò chơi bán hàng')

create table DoChoi
(
	MaDoChoi char(5) primary key,
	TenDoChoi nvarchar(30),
	Gia int,
	SoLuong int,
	MaLoai char(5) references LoaiDoChoi (MaLoai)
)

insert into DoChoi values ('DC001', N'Xe đua F1', 300000, 10, N'LDC01')
insert into DoChoi values ('DC002', N'Pikachu', 5000, 100, N'LDC02')
insert into DoChoi values ('DC003', N'Đất sét màu ', 50000, 1000, N'LDC03')
insert into DoChoi values ('DC004', N'Gỗ xếp hình', 90000, 1000, N'LDC04')
insert into DoChoi values ('DC005', N'Lego', 500000, 100, N'LDC05')
insert into DoChoi values ('DC006', N'Bộ đồ chơi bán kem', 350000, 1000, N'LDC06')

create table HoaDon
(
	MaHoaDon char(5) primary key,
	NgayThanhToan datetime,
	MaNhanVien nvarchar(30) references DangNhap(TenDangNhap),
	TongTien int
)

create table ChiTietHoaDon
(
	MaChiTiet char(5) primary key,
	MaHoaDon char(5) references HoaDon(MaHoaDon),
	MaDoChoi char(5) references DoChoi(MaDoChoi),
	Gia int,
	SoLuong int
)

--------------------------------

create proc Them_LoaiDoChoi
	@MaLoai char(5),
	@TenLoai nvarchar(20)
as
insert into LoaiDoChoi values (@MaLoai, @TenLoai)
go

create proc Xoa_LoaiDoChoi
	@maLoai char(5)
as
delete from LoaiDoChoi where MaLoai = @maLoai
go

create proc CapNhat_LoaiDoChoi
	@maloai char(5),
	@tenloai char(5)
as
update LoaiDoChoi
set TenLoai = @tenloai
where MaLoai = @maloai

-------------------------------------------------------------------------

create proc Them_DoChoi
	@MaDoChoi char(5),
	@TenDoChoi nvarchar(30),
	@Gia int,
	@SoLuong int,
	@MaLoai char(5)
as
insert into DoChoi values (@MaDoChoi, @TenDoChoi, @Gia, @SoLuong, @MaLoai)
go

create proc Xoa_DoChoi
	@MaDoChoi char(5)
as
delete from DoChoi where MaDoChoi = @MaDoChoi
go

create proc CapNhat_DoChoi
	@MaDoChoi char(5),
	@TenDoChoi nvarchar(30),
	@Gia int,
	@SoLuong int,
	@MaLoai char(5)
as
update DoChoi
set TenDoChoi = @TenDoChoi,
	Gia = @Gia,
	SoLuong = @SoLuong,
	MaLoai = @MaLoai
where MaDoChoi = @MaDoChoi

----------------------------------------------------------------------------

create proc Them_ThongTinMuaHang
	@MaHoaDon char(5),
	@NgayThanhToan datetime,
	@MaNhanVien nvarchar(30),
	@TongTien int,
	@MaChiTiet char(5),
	@MaDoChoi char(5),
	@Gia int,
	@SoLuong int
as
insert into HoaDon values (@MaHoaDon, @NgayThanhToan, @MaNhanVien, @TongTien)
insert into ChiTietHoaDon values (@MaChiTiet, @MaHoaDon, @MaDoChoi, @Gia, @SoLuong)
go

create proc Xoa_ThongTinMuaHang
	@MaHoaDon char(5),
	@MaChiTiet char(5)
as
delete from HoaDon where MaHoaDon = @MaHoaDon
delete from ChiTietHoaDon where MaChiTiet = @MaChiTiet
go

create proc CapNhat_ThongTinMuaHang
	@MaHoaDon char(5),
	@NgayThanhToan datetime,
	@MaNhanVien nvarchar(30),
	@TongTien int,
	@MaChiTiet char(5),
	@MaDoChoi char(5),
	@Gia int,
	@SoLuong int
as
update HoaDon
set NgayThanhToan = @NgayThanhToan,
	MaNhanVien = @MaNhanVien,
	TongTien = @TongTien
where MaHoaDon = @MaHoaDon
update ChiTietHoaDon
set	MaHoaDon = @MaHoaDon,
	MaDoChoi = @MaDoChoi,
	Gia = @Gia,
	SoLuong = @SoLuong
where MaChiTiet = @MaChiTiet