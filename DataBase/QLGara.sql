Ecreate database QLGara
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
	@dongXeId int,
	@mau nvarchar(50),
	@mota nvarchar(1000),
	@mauTrong nvarchar(50),
	@namXX varchar(50),
	@xuatXu nvarchar(50)
	AS
	BEGIN
		INSERT INTO XE VALUES(@bs, @userId, @ngayTN, @dongXeId, @mau, @mota, @mauTrong, @namXX, @xuatXu, GETDATE(), null, 'active')
	END
	

---UPDate Xe----
CREATE PROC SP_UPDATE_XE
	@bs varchar(50),
	@userId int,
	@ngayTN smalldatetime,
	@dongXeId int,
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
	@hieuXe int,
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

----/////////////////////////////////-----
