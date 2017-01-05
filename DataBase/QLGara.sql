create database QLGara
Go
use [QLGara]
go

--Table user
CREATE TABLE USERS
(
	USER_ID bigint PRIMARY KEY,
	USERNAME varchar(60),
	EMAIL varchar(100),
	PASS varchar(255),
	ROLE_ID tinyint,
	GENDER bit,
	BIRTHDAY date,
	FULL_NAME nvarchar(50),
	PHONE varchar(15),
	DIRECTION text --ADDRESS
)
--Table Roles
CREATE TABLE ROLES
(
	ROLE_ID tinyint primary key,
	ROLE_NAME nvarchar(50)
)

--Constraints
ALTER TABLE USERS ADD CONSTRAINT FK_USERS_ROLES FOREIGN KEY (ROLE_ID) REFERENCES ROLES(ROLE_ID)
ALTER TABLE XE ADD CONSTRAINT FK_XE_KHACHHANG FOREIGN KEY (USER_ID) REFERENCES KHACHHANG(KH_ID)
ALTER TABLE PHIEUSUACHUA ADD CONSTRAINT FK_PSC_XE FOREIGN KEY (BIENSO) REFERENCES XE(BIENSO)
ALTER TABLE PHIEUSUACHUA ADD CONSTRAINT FK_PSC_KHACHHANG FOREIGN KEY (USER_ID) REFERENCES KHACHHANG(KH_ID)

--Store procedur------------
----Get all row of table----
CREATE PROCEDURE SP_GETDATA
	@tableName varchar(128)
	AS
	BEGIN
		Declare @sql nvarchar(max);
		Set @sql = N'Select * from ' + @tableName
		Exec sp_executesql @sql
	END
----Register Procedure------ 
CREATE PROCEDURE SP_REGISTER
	@username varchar(60),
	@email varchar(50),
	@pass varchar(255),
	@role tinyint,
	@gender bit,
	@birthday date,
	@full_name nvarchar(50),
	@phone varchar(15),
	@direction text
	AS
	BEGIN
		DECLARE @count bigint
		set @count = (SELECT MAX(USER_ID) FROM USERS) + 1
		if (@username not in (select USERNAME FROM USERS))
		BEGIN
			insert into USERS values(@count, @username, @email, @pass, @role, @gender, @birthday, @full_name, @phone, @direction, GETDATE(), null, 'active')
		END
		ELSE
		BEGIN
			rollback tran
			return -1
		END
	END

-----Login and roles------------

CREATE PROCEDURE SP_LOGIN
	@username varchar(60),
	@pass varchar(255)
	AS
	BEGIN
		SELECT * FROM USERS WHERE (@username = USERNAME AND @pass = PASS)
	END

----Del user------
CREATE PROC SP_DEL_USER
	@username varchar(50)
	as
	begin
		DELETE FROM USERS WHERE USERNAME = @username
	end

----Search User---- drop proc SP_SEARCH_USER
CREATE PROC SP_SEARCH_USER
	@content varchar(20)
	as
	begin
		declare @searchString varchar(22)
		set @searchString = '%' + @content + '%'
		select * from USERS
		where (USERNAME like @searchString) or (EMAIL like @searchString)
	end

--///Hieu Xe///////----
---Insert HieuXe---
CREATE PROC SP_INSERT_HIEUXE
	@maHx int,
	@tenHx nvarchar(50)
	as
	begin
		DECLARE @date smalldatetime
		set @date = GETDATE()
		insert into HIEUXE values(@maHx, @tenHx, @date, null, 'active')
	end

---Delete hieuXe -----
CREATE PROC SP_DEL_HIEUXE
	@maHx int
	as
	begin
		delete from HIEUXE where MAHX = @maHx
---Update Hieu Xe----
CREATE PROC SP_UPDATE_HIEUXE
	@maHx int,
	@tenHx nvarchar(50)
	AS
	BEGIN
		UPDATE HIEUXE
		set TENHX = @tenHx, NGAY_CN_CUOI = GETDATE()
		WHERE MAHX = @maHx
	END
----Vat Tu Zone-----
-----Inset Vat Tu---
CREATE PROC SP_INSERT_VATTU
	@maVt int,
	@tenVt nvarchar(50),
	@donGia money,
	@sl int
	AS
	BEGIN
		INSERT INTO VATTU VALUES(@maVt, @tenVt, @donGia, @sl, GETDATE(), null, 'active')
	END


----Update Vat TU----
CREATE PROC SP_UPDATE_VATTU
	@maVt int,
	@tenVt nvarchar(50),
	@donGia money,
	@sl int
	AS
	BEGIN
		UPDATE VATTU
		SET TENVT = @tenVt, DONGIA = @donGia, SL = @sl, NGAY_CN_CUOI = GETDATE()
		WHERE MAVT = @maVt
	END
----DEL VAT TU-----
CREATE PROC SP_DEL_VATTU
	@maVt int
	AS
	BEGIN
		DELETE FROM VATTU WHERE MAVT = @maVt
	END

----Search Vat tu---- drop proc SP_SEARCH_VATTU

CREATE PROC SP_SEARCH_VATTU
	@content nvarchar(20)
	as
	begin
		declare @searchString nvarchar(30)
		set @searchString = N'%' + @content + N'%'
		print(@searchString)
		begin
			select * from VATTU 
			where TENVT like @searchString
		end
	end



----////KHACH HANG-----
----INSERT KHACH HANG----
CREATE PROC SP_INSERT_KHACHHANG
	@id int,
	@ten nvarchar(50),
	@sdt varchar(15),
	@email nvarchar(50),
	@diaChi nvarchar(200),
	@ngaySinh smalldatetime,
	@gender bit,
	@congNo money
	AS
	BEGIN
		INSERT INTO KHACHHANG VALUES(@id, @ten, @sdt, @email, @diaChi, @ngaySinh, @gender, @congNo, GETDATE(), null, 'active')
	END

----UPDATE KHACH HANG--- 
CREATE PROC SP_UPDATE_KHACHHANG
	@id int,
	@ten nvarchar(50),
	@sdt varchar(15),
	@email nvarchar(50),
	@diaChi nvarchar(200),
	@ngaySinh smalldatetime,
	@gender bit,
	@congNo money
	AS
	BEGIN
		UPDATE KHACHHANG
		SET KH_TEN = @ten, KH_SDT = @sdt, KH_EMAIL = @email, KH_DIACHI = @diaChi, KH_NGAYSINH = @ngaySinh, KH_GIOITINH = @gender, KH_CONGNO = @congNo, NGAY_CN_CUOI = GETDATE()
		WHERE KH_ID = @id
	END

---DEL Khach Hang
CREATE PROC SP_DEL_KHACHHANG
	@id int
	AS
	BEGIN
		DELETE FROM KHACHHANG WHERE KH_ID = @id
	END

----///// Xe ----------------\
---Insert Xe 
CREATE PROC SP_INSERT_XE
	@bs varchar(50),
	@userId int,
	@ngayTN smalldatetime,
	@dongXeId varchar(50),
	@mau nvarchar(50),
	@mota nvarchar(1000),
	@mauTrong nvarchar(50),
	@namXX varchar(50),
	@xuatXu nvarchar(50)
	AS
	BEGIN
		INSERT INTO XE VALUES(@bs, @userId, @ngayTN, @dongXeId, @mau, @mota, @mauTrong, @namXX, @xuatXu, GETDATE(), null, 'active')
	END
	

---UPDate Xe---- drop proc SP_UPDATE_XE
CREATE PROC SP_UPDATE_XE
	@bs varchar(50),
	@userId int,
	@ngayTN smalldatetime,
	@dongXeId varchar(50),
	@mau nvarchar(50),
	@mota nvarchar(1000),
	@mauTrong nvarchar(50),
	@namXX varchar(50),
	@xuatXu nvarchar(50)
	AS
	BEGIN
		UPDATE XE
		SET USER_ID = @userId, NGAYTN = @ngayTN, DONGXE_ID = @dongXeId, MAU_XE = @mau, MOTA = @mota, MAU_NOI_THAT = @mauTrong, NAM_XUAT_XU = @namXX, XUAT_XU = @xuatXu, NGAY_CN_CUOI = GETDATE()
		WHERE BIENSO = @bs
	END

----DEl xe
CREATE PROC SP_DEL_XE
	@bs varchar(50)
	AS
	BEGIN
		DELETE FROM XE WHERE BIENSO = @bs
	END

---Search----
CREATE PROC [dbo].[SP_SEARCH_XE]
	@content nvarchar(20)
	as
	begin
		delete from ##temp
		insert into ##temp(BIENSO, KH_TEN, DONGXE_ID, MAU_XE, MAU_NOI_THAT, NAM_XUAT_XU, XUAT_XU)
		select A.BIENSO, B.KH_TEN, A.DONGXE_ID, A.MAU_XE, A.MAU_NOI_THAT, A.NAM_XUAT_XU, A.XUAT_XU 
		from XE A, KHACHHANG B
		where B.KH_ID = A.USER_ID
		
		declare @searchString nvarchar(23)
		set @searchString = N'%' + @content + N'%'
		select * from ##temp
		where (A.USER_ID like @searchString) or (A.BIENSO like @searchString) or (A.XUAT_XU like @searchString) or (A.MOTA like @searchString)
	end


---/////DONG XE -------
---Insert hieu Xe
CREATE PROC SP_INSERT_DONGXE
	@id varchar(50),
	@hieuXe int,
	@tskt nvarchar(max)
	AS
	BEGIN
		INSERT INTO CACLOAIXE VALUES(@id, @hieuXe, @tskt, GETDATE(), null, 'active')
	END

---Update Dong Xe ----- 
CREATE PROC SP_UPDATE_DONGXE
	@id varchar(50),
	@hieuXe varchar(50),
	@tskt nvarchar(max)
	AS
	BEGIN
		UPDATE CACLOAIXE
		SET HIEU_XE = @hieuXe, THONG_SO_KY_THUAT = @tskt, NGAY_CN_CUOI = GETDATE()
		WHERE DONGXE_ID = @id
	END

---DEL Hieu Xe-----
CREATE PROC SP_DEL_DONGXE
	@id varchar(50)
	AS
	BEGIN
		DELETE FROM CACLOAIXE WHERE DONGXE_ID = @id
	END

----/////////HOA DOn////////////////----- drop proc SP_GETALL_PHIEUTT
---get all hoa don
CREATE PROC SP_GETALL_PHIEUTT
	@content varchar(10)
	as
	begin
		select B.MAPTT, A.MAPSC, A.NGAYSC, C.KH_TEN, A.BIENSO, A.TONGTIEN
		from PHIEUSUACHUA A, PHIEUTHANHTOAN B, KHACHHANG C
		where A.MAPSC = B.MAPSC and C.KH_ID = A.USER_ID
	end

----get khach hang
CREATE PROCEDURE [dbo].[SP_SELECT_KHACHHANG]
	@id int
	AS
	BEGIN
		SELECT * FROM KHACHHANG WHERE (@id = KH_ID )
	END

CREATE PROCEDURE [dbo].[SP_SELECT_PHIEUSUACHUA]
	@id int
	AS
	BEGIN
		SELECT * FROM PHIEUSUACHUA WHERE (@id = MAPSC )
	END

go
-----Search Hoa DOn----- drop proc SP_SEARCH_HOADON
create table ##temp(
			MAPTT int,
			MAPSC int,
			NGAYSC smalldatetime,
			KH_TEN nvarchar(50),
			BIENSO nvarchar(50),
			TONGTIEN money
			)

CREATE PROC SP_SEARCH_HOADON
	@content nvarchar(20)
	as
	begin
		delete from ##temp
		insert into ##temp(MAPTT, MAPSC, NGAYSC, KH_TEN, BIENSO, TONGTIEN)
		select B.MAPTT, A.MAPSC, A.NGAYSC, C.KH_TEN, A.BIENSO, A.TONGTIEN
		from PHIEUSUACHUA A, PHIEUTHANHTOAN B, KHACHHANG C
		where A.MAPSC = B.MAPSC and C.KH_ID = A.USER_ID

		declare @searchString nvarchar(25)
		set @searchString = N'%' + @content + N'%'
		select * from ##temp
		where KH_TEN like @searchString
	end

----///PHIEU SUA CHUA///---
---insert
CREATE PROC SP_INSERT_PSC
	@maPsc int,
	@bs varchar(50),
	@uid int
	as
	begin
		declare @tong money
		set @tong = (select SUM(DONGIA * SOLUONG) from CT_PHIEUSUACHUA where MAPSC = @maPsc)
		insert into PHIEUSUACHUA values(@maPsc, @bs, @uid, GETDATE(), @tong, GETDATE(), null, 'active')
	end

--update psc drop proc SP_UPDATE_PSC
CREATE PROC SP_UPDATE_PSC
	@maPsc int
	as
	begin
		declare @tong money
		set @tong = (select SUM(DONGIA) from CT_PHIEUSUACHUA where MAPSC = @maPsc)
		update PHIEUSUACHUA
		set TONGTIEN = @tong, NGAY_CN_CUOI = GETDATE()
		where MAPSC = @maPsc

	end
---DElete psc

create proc SP_DEL_PSC
	@maPsc int
	as
	begin
		delete from CT_PHIEUSUACHUA
		where MAPSC = @maPsc
		delete from PHIEUSUACHUA
		where MAPSC = @maPsc
	end

	--Insert cTPSC drop proc SP_INSERT_CTPSC
CREATE PROC SP_INSERT_CTPSC
	@maPsc int,
	@maVt int,
	@sl int
	as
	begin
		declare @donGia money
		set @donGia = (select DONGIA from VATTU where MAVT = @maVt)

		insert into CT_PHIEUSUACHUA values(@maPsc, @maVt, @sl, @donGia, GETDATE(), null, 'active')

		update VATTU
		set SL = SL - @sl, NGAY_CN_CUOI = GETDATE()
		where @maVt = MAVT
	end

----// INsert HOA DON -----
CREATE PROC SP_INSERT_HOADON
	@maPtt int,
	@maPsc int
	as
	begin
		insert into PHIEUTHANHTOAN values(@maPtt, @maPsc, GETDATE(), GETDATE(), null, 'active')
	end


----// Nhà cung cấp zone ----
---search ncc
CREATE PROC SP_SEARCH_NHACUNGCAP
	@content nvarchar(20)
	as
	begin
		declare @searchString nvarchar(30)
		set @searchString = N'%' + @content + N'%'
		select * from NHACUNGCAP
		where (NCC_EMAIL like @searchString) or (NCC_TEN like @searchString) or (NCC_DIACHI like @searchString)
	end

--Insert Nha cung cap---
CREATE PROC SP_INSERT_NCC
	@id int,
	@ten nvarchar(50),
	@email nvarchar(50),
	@sdt varchar(15),
	@diaChi nvarchar(200)
	as
	begin
		insert into NHACUNGCAP values(@id, @ten, @sdt, @email, @diaChi, GETDATE(), null, 'active')
	end

-----UPDATE PROFILE
CREATE PROC SP_UPDATE_PROFILE
	@id int,
	@email nvarchar(50),
	@sdt varchar(15),
	@pass varchar(50),
	@direction nvarchar(200)
	as
	begin
		update Users
		set EMAIL = @email, PHONE = @sdt, PASS = @pass, DIRECTION = @direction
		where USER_ID = @id
	end
		

CREATE PROC [dbo].[SP_SELECT_CTPSC]
	@content nvarchar(20)
	as
	begin
		delete from ##temp
		insert into ##temp(MAPSC, TENVT, SOLUONG, DONGIA, GIABAN, SL)
		select A.MAPSC, B.TENVT, A.SOLUONG, A.DONGIA, B.DONGIA, B.SL 
		from CT_PHIEUSUACHUA A, VATTU B
		where B.MAVT = A.MAVT
		
		declare @searchString nvarchar(23)
		set @searchString = N'%' + @content + N'%'
		select * from ##temp
		where (MAPSC = @searchString)
	end

-----get ct psc
