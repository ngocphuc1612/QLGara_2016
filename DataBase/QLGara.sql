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
	@email varchar(100),
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
			insert into USERS values(@count, @username, @email, @pass, @role, @gender, @birthday, @full_name, @phone, @direction)
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
--/////////////////----