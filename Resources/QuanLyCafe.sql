-- 1. Create  Database and Constraint

-- 1.1. Create database

CREATE DATABASE QuanLyCafe
GO

USE QuanLyCafe
GO

CREATE TABLE Ban(
	ID NVARCHAR(10) PRIMARY KEY,
	TenBan NVARCHAR(10) NOT NULL,
	SoLuong INT NOT NULL DEFAULT 0,
	MaxSoLuong INT NOT NULL DEFAULT 4
)
GO

CREATE TABLE KhoHang(
	ID NVARCHAR(10) PRIMARY KEY,
	Ten NVARCHAR(50) NOT NULL,
	DonViTinh NVARCHAR(50) NOT NULL,
	soLuong INT NOT NULL,
	DonGia REAL NOT NULL,
	CONSTRAINT CHK_KhoHang_DonGia CHECK (DonGia>0)
)
GO

CREATE TABLE NhanVien(
	ID NVARCHAR(10) PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	SDT NVARCHAR(10) NOT NULL,
	CMND NVARCHAR(10) NOT NULL,
	DiaChi NVARCHAR(500) NULL,
	NgayVaoLam DATE NOT NULL DEFAULT GETDATE(),
	NgayNghiViec DATE NULL,	
	LuongCoBan REAL NOT NULL DEFAULT 1500000,
	CONSTRAINT CHK_NhanVien_NgayNghiViec CHECK (NgayNghiViec= NULL OR NgayNghiViec>NgayVaoLam)
)
GO

CREATE TABLE BangLuong(
	IDnhanVien NVARCHAR(10) NOT NULL,
	Thang INT NOT NULL,
	Nam INT NOT NULL,
	Luong REAL DEFAULT 1500000,
	PRIMARY KEY (IDnhanVien, Thang, Nam),
	FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID) ON DELETE CASCADE  ON UPDATE CASCADE
)
GO


CREATE TABLE ThanhVien(
	ID NVARCHAR(10) PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	SDT NVARCHAR(10) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	CMND NVARCHAR(10) NOT NULL,
	DiaChi NVARCHAR(500) NULL,
	NgayTao DATE NOT NULL DEFAULT GETDATE()
)
GO

CREATE TABLE LoaiThucDon(
	ID NVARCHAR(10) PRIMARY KEY,
	TenloaiThucDon NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE ThucDon(
	ID NVARCHAR(10) PRIMARY KEY,
	Ten NVARCHAR(50) NOT NULL,
	DonViTinh NVARCHAR(10) NOT NULL,
	DonGia REAL NOT NULL,
	IDloaiThucDon NVARCHAR(10) DEFAULT NULL,
	FOREIGN KEY (IDloaiThucDon) REFERENCES LoaiThucDon(ID),
	CONSTRAINT CHK_ThucDon_DonGia CHECK (DonGia>0)
)
GO

CREATE TABLE LoginNhanVien(
	IDNhanVien NVARCHAR(10),
	LoginName NVARCHAR(50) PRIMARY KEY,
	Password NVARCHAR(50) NOT NULL DEFAULT N'123456',
	Permission BIT NOT NULL DEFAULT 0,	--1.Admin	0.Staff
	Ngaytao DATE NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID) ON DELETE CASCADE  ON UPDATE CASCADE
)
GO

CREATE TABLE HoaDonBanHang(
	ID NVARCHAR(10) PRIMARY KEY,
	IDnhanVien NVARCHAR(10),
	IDthanhVien NVARCHAR(10),
	IDban NVARCHAR(10),
	Ngaytao DATETIME NOT NULL DEFAULT GETDATE(),
	DaThanhToan BIT NOT NULL DEFAULT 0,	--1.Da thanh toan	0.Chua thanh toan
	FOREIGN KEY (IDban)  REFERENCES Ban(ID) ON UPDATE CASCADE,
	FOREIGN KEY (IDnhanVien) REFERENCES NhanVien(ID) ON DELETE SET NULL ON UPDATE CASCADE,
	FOREIGN KEY (IDthanhVien) REFERENCES ThanhVien(ID) ON DELETE SET NULL ON UPDATE CASCADE
)
GO

CREATE TABLE ChiTietHoaDonBanHang(
	IDhoaDonBH NVARCHAR(10),
	IDthucDon NVARCHAR(10),
	soLuong INT NOT NULL DEFAULT 1,
	PRIMARY KEY (IDhoaDonBH,IDthucDon),
	CONSTRAINT CHK_ChiTietHoaDonBanHang_soLuong CHECK (soLuong>0),
	FOREIGN KEY (IDhoaDonBH) REFERENCES HoaDonBanHang(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (IDthucDon) REFERENCES ThucDon(ID)  ON UPDATE CASCADE
)
GO

CREATE TABLE HoaDonNhapHang(
	ID NVARCHAR(10) PRIMARY KEY,
	IDnhanVien NVARCHAR(10),
	NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY (IDnhanVien)  REFERENCES NhanVien(ID) ON DELETE SET NULL  ON UPDATE CASCADE
)
GO

CREATE TABLE ChiTietHoaDonNhapHang(
	IDhoaDonNH NVARCHAR(10),
	IDhang NVARCHAR(10),
	soLuong INT NOT NULL DEFAULT N'1',
	PRIMARY KEY(IDhoaDonNH, IDhang),
	CONSTRAINT CHK_ChiTietHoaDonNhapHang_soLuong CHECK (soLuong>0),
	FOREIGN KEY (IDhoaDonNH) REFERENCES HoaDonNhapHang(ID) ON DELETE CASCADE  ON UPDATE CASCADE,
	FOREIGN KEY (IDhang) REFERENCES KhoHang(ID) ON UPDATE CASCADE
)
GO

-- 1.2. Create foreign constraint

-- 2. Create Stored Procedure
-- 2.1 Insert, Update, Delete LoginNhanVien bang quyen admin
-- 2.1.1 Insert
EXECUTE sp_addrole 'db_staff'
GO

CREATE PROCEDURE sp_Insert_LoginNhanVien
@IDNhanVien NVARCHAR(10), 
@LoginName NVARCHAR(50), 
@Password NVARCHAR(50),
@Permission BIT,
@Ngaytao DATE
AS
BEGIN
	DECLARE @SQL NVARCHAR(MAX), @COUNT INT
	SET @COUNT = (SELECT COUNT(*) FROM LoginNhanVien WHERE IDNhanVien = @IDNhanVien)
	IF(@COUNT = 0)
	BEGIN
		BEGIN TRAN
		IF(@Permission = 1)
		BEGIN
			SET @SQL = 'CREATE LOGIN [' + @LoginName + ']WITH PASSWORD= ''' + @Password + ''', DEFAULT_DATABASE=[QuanLyCafe],
			CHECK_EXPIRATION=ON, CHECK_POLICY=ON ;ALTER SERVER ROLE [securityadmin] ADD MEMBER [' + @LoginName + ']; CREATE
			USER[' + @LoginName + '] FOR LOGIN[' + @LoginName + '];ALTER ROLE [db_owner] ADD MEMBER [' + @LoginName + ']';
			EXEC(@SQL);
			PRINT 'EXCE Admin'
		END
		ELSE
		BEGIN 
			SET @SQL = 'CREATE LOGIN [' + @LoginName + ']WITH PASSWORD= ''' + @Password + ''', DEFAULT_DATABASE=[QuanLyCafe],
			CHECK_EXPIRATION=ON, CHECK_POLICY=ON ;ALTER SERVER ROLE [securityadmin] ADD MEMBER [' + @LoginName + ']; CREATE
			USER[' + @LoginName + '] FOR LOGIN[' + @LoginName + '];ALTER ROLE [db_datareader] ADD MEMBER [' + @LoginName + '];
			ALTER ROLE [db_datawriter] ADD MEMBER [' + @LoginName + '];
			ALTER ROLE[db_staff] ADD MEMBER [' + @Loginname + ']';
			EXEC(@SQL);
			PRINT 'EXCE Staff'
		END
		IF (@@ERROR <> 0)
		BEGIN
			RAISERROR(N'Đã xảy ra lỗi không tạo tài khoản này trên hệ thống! Vui lòng kiểm tra và thử lại sau!', 16, 1)
			ROLLBACK
		END
		INSERT INTO dbo.LoginNhanVien VALUES (@IDNhanVien, @LoginName, @Password, @Permission, @Ngaytao)
		COMMIT TRAN
	END
END
GO

-- 2.1.2 Update
CREATE PROCEDURE sp_Update_LoginNhanVien	
@IDNhanVien NVARCHAR(10), 
@LoginName NVARCHAR(50), 
@Password NVARCHAR(50),
@Permission BIT,
@Ngaytao DATE
AS
BEGIN
	DECLARE @SQL NVARCHAR(MAX), @oldPassword NVARCHAR(50), @oldPermission BIT
	SELECT @oldPassword = Password, @oldPermission = Permission
	FROM LoginNhanVien
	WHERE LoginName = @LoginName
	BEGIN TRAN
	IF(@Password != @oldPassword)
	BEGIN
		SET @SQL = 'ALTER LOGIN [' + @LoginName + ']WITH PASSWORD= ''' + @Password + '''';
		EXEC(@SQL);
	END
	IF(@oldPermission != @Permission)
	BEGIN
		IF(@Permission = 1)
			SET @SQL = 'ALTER ROLE[db_owner] ADD MEMBER [' + @Loginname + '];
						ALTER ROLE [db_datareader] DROP MEMBER [' + @LoginName + '];
						ALTER ROLE [db_datawriter] DROP MEMBER [' + @LoginName + '];
						ALTER ROLE[db_staff] DROP MEMBER [' + @Loginname + ']';
		ELSE 
			SET @SQL = 'ALTER ROLE[db_owner] DROP MEMBER [' + @Loginname + '];
						ALTER ROLE [db_datareader] ADD MEMBER [' + @LoginName + '];
						ALTER ROLE [db_datawriter] ADD MEMBER [' + @LoginName + '];
						ALTER ROLE[db_staff] ADD MEMBER [' + @Loginname + ']';
		EXEC(@SQL);
	END
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR(N'Đã xảy ra lỗi trên hệ thống! Vui lòng kiểm tra và thử lại sau!', 16, 1)
			ROLLBACK
		END
	UPDATE LoginNhanVien SET IDNhanVien=@IDNhanVien, Password=@Password, Permission=@Permission,Ngaytao=@Ngaytao WHERE LoginName=@LoginName
	COMMIT TRAN
END
GO

-- 2.1.3 Delete
CREATE PROCEDURE sp_Delete_LoginNhanVien
@LoginName NVARCHAR(50)
AS
BEGIN
	DECLARE @SQL1 NVARCHAR(MAX), @SQL2 NVARCHAR(MAX)
	BEGIN TRAN
	SET @SQL1 = 'DROP USER ' + @LoginName +''
	SET @SQL2 = 'DROP LOGIN ' + @LoginName +''
	EXEC(@SQL1)
	EXEC(@SQL2)
	IF (@@ERROR <> 0)
		BEGIN
			RAISERROR(N'Đã xảy ra lỗi trên hệ thống! Vui lòng kiểm tra và thử lại sau!', 16, 1)
			ROLLBACK
		END
	DELETE FROM LoginNhanVien WHERE LoginName = @LoginName
	COMMIT TRAN
END
GO

-- 2.2. Insert, Update, Delete NhanVien
-- 2.2.1. Insert
CREATE PROCEDURE sp_Insert_NhanVien
@ID NVARCHAR(10),
@HoTen NVARCHAR(50),
@SDT NVARCHAR(10),
@CMND NVARCHAR(10),
@DiaChi NVARCHAR(500),
@NgayVaoLam DATE,
@NgayNghiViec DATE,
@LuongCoBan REAL
AS 
BEGIN
	INSERT INTO NhanVien VALUES(@ID, @HoTen, @SDT, @CMND, @DiaChi, @NgayVaoLam, @NgayNghiViec, @LuongCoBan)
END
GO

-- 2.2.2. Update
CREATE PROCEDURE sp_Update_NhanVien
@ID NVARCHAR(10),
@HoTen NVARCHAR(50),
@SDT NVARCHAR(10),
@CMND NVARCHAR(10),
@DiaChi NVARCHAR(500),
@NgayVaoLam DATE,
@NgayNghiViec DATE,
@LuongCoBan REAL
AS 
BEGIN
	UPDATE NhanVien SET HoTen = @HoTen, SDT = @SDT, CMND = @CMND, DiaChi = @DiaChi, NgayVaoLam = @NgayVaoLam, NgayNghiViec = @NgayNghiViec, LuongCoBan = @LuongCoBan
	WHERE ID = @ID
END
GO

-- 2.2.3. Delete
CREATE PROCEDURE sp_Delete_NhanVien
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM NhanVien WHERE ID = @ID
END
GO

-- 2.3. Insert, Update, Delete ThucDon
-- 2.3.1. Insert
CREATE PROCEDURE sp_Insert_ThucDon
@ID NVARCHAR(10),
@Ten NVARCHAR(50),
@DonViTinh NVARCHAR(10),
@DonGia REAL,
@IDloaiThucDon NVARCHAR(10)
AS 
BEGIN
	INSERT INTO ThucDon VALUES(@ID, @Ten, @DonViTinh, @DonGia, @IDloaiThucDon)
END
GO

-- 2.3.2. Update
CREATE PROCEDURE sp_Update_ThucDon
@ID NVARCHAR(10),
@Ten NVARCHAR(50),
@DonViTinh NVARCHAR(10),
@DonGia REAL,
@IDloaiThucDon NVARCHAR(10)
AS 
BEGIN
	UPDATE ThucDon SET Ten = @Ten, DonViTinh = @DonViTinh, DonGia = @DonGia, IDloaiThucDon = @IDloaiThucDon
	WHERE ID = @ID
END
GO

-- 2.3.3. Delete
CREATE PROCEDURE sp_Delete_ThucDon
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM ThucDon WHERE ID = @ID
END
GO
-- 2.4. Insert, Update, Delete Ban
-- 2.4.1. Insert
CREATE PROCEDURE sp_Insert_Ban
@ID NVARCHAR(10),
@TenBan NVARCHAR(10),
@MaxSoLuong INT
AS 
BEGIN
	INSERT INTO Ban VALUES(@ID, @TenBan, DEFAULT, @MaxSoLuong)
END
GO

-- 2.4.2. Update
CREATE PROCEDURE sp_Update_Ban
@ID NVARCHAR(10),
@TenBan NVARCHAR(10),
@SoLuong INT,
@MaxSoLuong INT
AS 
BEGIN
	UPDATE Ban SET TenBan = @TenBan, SoLuong = @SoLuong, MaxSoLuong = @MaxSoLuong
	WHERE ID = @ID
END
GO

-- 2.4.3. Delete
CREATE PROCEDURE sp_Delete_Ban
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM Ban WHERE ID = @ID
END
GO
-- 2.5. Insert, Update, Delete HoaDonBanHang

-- 2.5.1. Insert
CREATE PROCEDURE sp_Insert_HoaDonBanHang
@ID NVARCHAR(10),
@IDnhanVien NVARCHAR(10),
@IDthanhVien NVARCHAR(10),
@IDban NVARCHAR(10),
@Ngaytao DATETIME
AS 
BEGIN
	INSERT INTO HoaDonBanHang VALUES(@ID, @IDnhanVien, @IDthanhVien, @IDban, @Ngaytao, DEFAULT)
END
GO

-- 2.5.2. Update
CREATE PROCEDURE sp_Update_HoaDonBanHang
@ID NVARCHAR(10),
@IDnhanVien NVARCHAR(10),
@IDthanhVien NVARCHAR(10),
@IDban NVARCHAR(10),
@Ngaytao DATETIME,
@DaThanhToan BIT
AS 
BEGIN
	UPDATE HoaDonBanHang SET IDnhanVien = @IDnhanVien, IDthanhVien = @IDthanhVien, IDban = @IDban, Ngaytao = @Ngaytao, DaThanhToan = @DaThanhToan
	WHERE ID = @ID
END
GO

CREATE PROCEDURE sp_Update_TrangThaiHoanDonBanHang
@ID NVARCHAR(10),
@DaThanhToan BIT
AS 
BEGIN
	UPDATE HoaDonBanHang SET DaThanhToan = @DaThanhToan
	WHERE ID = @ID
END
GO

-- 2.5.4. Delete
CREATE PROCEDURE sp_Delete_HoaDonBanHang
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM HoaDonBanHang WHERE ID = @ID
END
GO
-- 2.6. Insert, Update, Delete HoaDonNhapHang
-- 2.6.1. Insert
CREATE PROCEDURE sp_Insert_HoaDonNhapHang
@ID NVARCHAR(10),
@IDnhanVien NVARCHAR(10),
@NgayTao DATETIME
AS 
BEGIN
	INSERT INTO HoaDonNhapHang VALUES(@ID, @IDnhanVien, @NgayTao)
END
GO

-- 2.6.2. Update
CREATE PROCEDURE sp_Update_HoaDonNhapHang
@ID NVARCHAR(10),
@IDnhanVien NVARCHAR(10),
@NgayTao DATETIME
AS 
BEGIN
	UPDATE HoaDonNhapHang SET IDnhanVien = @IDnhanVien, NgayTao = @NgayTao
	WHERE ID = @ID
END
GO

-- 2.6.3. Delete
CREATE PROCEDURE sp_Delete_HoaDonNhapHang
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM HoaDonNhapHang WHERE ID = @ID
END
GO
-- 2.7. Insert, Update, Delete KhoHang bang quyen admin
-- 2.7.1. Insert
CREATE PROCEDURE sp_Insert_KhoHang
@ID NVARCHAR(10),
@Ten NVARCHAR(50),
@DonViTinh NVARCHAR(50),
@soLuong INT,
@DonGia REAL
AS 
BEGIN
	INSERT INTO KhoHang VALUES(@ID, @Ten, @DonViTinh, @soLuong, @DonGia)
END
GO

-- 2.7.2. Update
CREATE PROCEDURE sp_Update_KhoHang
@ID NVARCHAR(10),
@Ten NVARCHAR(50),
@DonViTinh NVARCHAR(50),
@soLuong INT,
@DonGia REAL
AS 
BEGIN
	UPDATE KhoHang SET Ten = @Ten, DonViTinh = @DonViTinh, soLuong = @soLuong, DonGia = @DonGia
	WHERE ID = @ID
END
GO

-- 2.7.3. Delete
CREATE PROCEDURE sp_Delete_KhoHang
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM KhoHang WHERE ID = @ID
END
GO

-- 2.8. Insert, Update, Delete ChiTietHoaDonBanHang
-- 2.8.1. Insert
CREATE PROCEDURE sp_Insert_ChiTietHoaDonBanHang
@IDhoaDonBH NVARCHAR(10),
@IDthucDon NVARCHAR(10),
@soLuong INT
AS 
BEGIN
	INSERT INTO ChiTietHoaDonBanHang VALUES(@IDhoaDonBH, @IDthucDon, @soLuong)
END
GO

-- 2.8.2. Update
CREATE PROCEDURE sp_Update_ChiTietHoaDonBanHang
@IDhoaDonBH NVARCHAR(10),
@IDthucDon NVARCHAR(10),
@soLuong INT
AS 
BEGIN
	UPDATE ChiTietHoaDonBanHang SET soLuong = @soLuong
	WHERE IDhoaDonBH = @IDhoaDonBH AND IDthucDon = @IDthucDon
END
GO

-- 2.8.3. Delete
CREATE PROCEDURE sp_Delete_ChiTietHoaDonBanHang
@IDhoaDonBH NVARCHAR(10),
@IDthucDon NVARCHAR(10)
AS
BEGIN
	DELETE FROM ChiTietHoaDonBanHang WHERE IDhoaDonBH = @IDhoaDonBH AND IDthucDon = @IDthucDon
END
GO
-- 2.9. Insert, Update, Delete ChiTietHoaDonNhapHang
-- 2.9.1. Insert
CREATE PROCEDURE sp_Insert_ChiTietHoaDonNhapHang
@IDhoaDonNH NVARCHAR(10),
@IDhang NVARCHAR(10),
@soLuong INT
AS 
BEGIN
	INSERT INTO ChiTietHoaDonNhapHang VALUES(@IDhoaDonNH, @IDhang, @soLuong)
END
GO

-- 2.9.2. Update
CREATE PROCEDURE sp_Update_ChiTietHoaDonNhapHang
@IDhoaDonNH NVARCHAR(10),
@IDhang NVARCHAR(10),
@soLuong INT
AS 
BEGIN
	UPDATE ChiTietHoaDonNhapHang SET soLuong = @soLuong
	WHERE IDhoaDonNH = @IDhoaDonNH AND IDhang = @IDhang
END
GO

-- 2.9.3. Delete
CREATE PROCEDURE sp_Delete_ChiTietHoaDonNhapHang
@IDhoaDonNH NVARCHAR(10),
@IDhang NVARCHAR(10)
AS
BEGIN
	DELETE FROM ChiTietHoaDonNhapHang WHERE IDhoaDonNH = @IDhoaDonNH AND IDhang = @IDhang
END
GO

-- 2.10. Insert, Update, Delete Thanh Vien
-- 2.10.1. Insert
CREATE PROCEDURE sp_Insert_ThanhVien
@ID NVARCHAR(10),
@HoTen NVARCHAR(50),
@SDT NVARCHAR(10),
@Email NVARCHAR(50),
@CMND NVARCHAR(10),
@DiaChi NVARCHAR(500),
@NgayTao DATE
AS 
BEGIN
	INSERT INTO ThanhVien VALUES(@ID, @HoTen, @SDT, @Email, @CMND, @DiaChi, @NgayTao)
END
GO

-- 2.10.2. Update
CREATE PROCEDURE sp_Update_ThanhVien
@ID NVARCHAR(10),
@HoTen NVARCHAR(50),
@SDT NVARCHAR(10),
@Email NVARCHAR(50),
@CMND NVARCHAR(10),
@DiaChi NVARCHAR(500),
@NgayTao DATE
AS 
BEGIN
	UPDATE ThanhVien SET HoTen = @HoTen, SDT = @SDT, Email = @Email, CMND = @CMND, DiaChi = @DiaChi, NgayTao = @NgayTao
	WHERE ID = @ID
END
GO

-- 2.10.3. Delete
CREATE PROCEDURE sp_Delete_ThanhVien
@ID NVARCHAR(10)
AS
BEGIN
	DELETE FROM ThanhVien WHERE ID = @ID
END
GO

-- 2.11. Insert, Update, Delete Bang Luong
-- 2.11.1. Insert
CREATE PROCEDURE sp_Insert_BangLuong
@ID NVARCHAR(10),
@Thang INT,
@Nam INT,
@Luong REAL
AS 
BEGIN
	INSERT INTO BangLuong VALUES(@ID, @Thang, @Nam, @Luong)
END
GO

-- 2.11.2. Update
CREATE PROCEDURE sp_Update_BangLuong
@IDnhanVien NVARCHAR(10),
@Thang INT,
@Nam INT,
@Luong REAL
AS 
BEGIN
	UPDATE BangLuong SET Luong = @Luong
	WHERE IDnhanVien = @IDnhanVien AND Thang = @Thang AND Nam = @Nam
END
GO

-- 2.11.3. Delete
CREATE PROCEDURE sp_Delete_BangLuong
@IDnhanVien NVARCHAR(10),
@Thang INT,
@Nam INT
AS
BEGIN
	DELETE FROM BangLuong WHERE IDnhanVien = @IDnhanVien AND Thang = @Thang AND Nam = @Nam
END
GO

-- 3. Create trigger

-- 3.1. Tao trigger dam bao ten cac thuc don khong duoc trung nhau
CREATE TRIGGER tg_ThucDon ON ThucDon
AFTER UPDATE,INSERT
AS
BEGIN
	DECLARE @TenThucDon NVARCHAR(50), @DonViTinh NVARCHAR(50),@Temp INT
	SELECT @TenThucDon=ne.Ten,@DonViTinh=ne.DonViTinh  FROM inserted ne
	SELECT @Temp=COUNT(*) FROM ThucDon WHERE ThucDon.Ten=@TenThucDon AND DonViTinh=@DonViTinh
	IF(@Temp>1)
	BEGIN
		RAISERROR(N'Thực Đơn Đã Tồn Tại',16, 1)
		ROLLBACK
	END
END
GO

-- 3.2. Tao trigger dam bao ten cac kho hang khong duoc trung nhau
CREATE TRIGGER tg_KhoHang ON KhoHang
AFTER UPDATE,INSERT
AS
BEGIN
	DECLARE @TenKhoHang NVARCHAR(50),@Temp INT
	SELECT @TenKhoHang=ne.Ten FROM inserted ne
	SELECT @Temp=COUNT(*) FROM KhoHang WHERE KhoHang.Ten=@TenKhoHang
	IF(@Temp>1)
	BEGIN
		RAISERROR(N'Kho Hàng Đã Tồn Tại',16, 1)
		ROLLBACK
	END
END
GO

-- 3.3. Tao trigger dam bao khi insert, update hay delete ChiTietHoaDonNhapHang không vi pham qui chuan soLuong trong KhoHang luon khong am
CREATE TRIGGER tg_ChiTietHoaDonNhapHang_soLuong ON ChiTietHoaDonNhapHang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @IDhoaDonNH NVARCHAR(10), @IDhang NVARCHAR(10), @NewsoLuong INT, @ChecksoLuong INT
	-- Update
	IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
	BEGIN
		DECLARE @OldsoLuong INT
		SELECT @IDhoaDonNH=ne.IDhoaDonNH, @IDhang=ne.IDhang, @NewsoLuong=ne.soLuong, @OldsoLuong=ol.soLuong
		FROM inserted ne,deleted ol
		SELECT @ChecksoLuong=soLuong
		FROM KhoHang
		WHERE ID=@IDhang
		IF(@ChecksoLuong+@OldsoLuong-@NewsoLuong<0)
		BEGIN
			RAISERROR(N'Lỗi Cập Nhật Số Lượng Không Phù Hợp',16, 1)
			ROLLBACK
		END
		ELSE
		BEGIN
			UPDATE KhoHang SET soLuong=soLuong+@OldsoLuong-@NewsoLuong WHERE KhoHang.ID=@IDhang
		END
	END
	-- INSERT
	ELSE IF EXISTS (SELECT * FROM inserted)
	BEGIN
		SELECT @IDhoaDonNH=ne.IDhoaDonNH, @IDhang=ne.IDhang, @NewsoLuong=ne.soLuong
		FROM inserted ne
		SELECT @ChecksoLuong=soLuong
		FROM KhoHang
		WHERE ID=@IDhang
		IF(@ChecksoLuong-@NewsoLuong<0)
		BEGIN
			RAISERROR(N'Số Lượng Hàng Trong Kho Hàng Không Đủ Cung Cấp',16, 1)
			ROLLBACK
		END
		ELSE
		BEGIN
			UPDATE KhoHang SET soLuong=soLuong-@NewsoLuong WHERE KhoHang.ID=@IDhang
		END
	END
	-- Delete
	ELSE 
	BEGIN
		SELECT @IDhoaDonNH=ol.IDhoaDonNH, @IDhang=ol.IDhang, @OldsoLuong=ol.soLuong
		FROM deleted ol
		SELECT @ChecksoLuong=soLuong
		FROM KhoHang
		WHERE ID=@IDhang
		UPDATE KhoHang SET soLuong=soLuong+@OldsoLuong WHERE KhoHang.ID=@IDhang
	END
END
GO

-- 3.4. Tao trigger Insert, Update, Delete HoaDonBanHang co lien quan den tinh trang thanh toan cung cap nhat theo
-- 3.4.1. Insert
use QuanLyCafe
go
CREATE TRIGGER tg_insHoaDonBanHang ON HoaDonBanHang
AFTER INSERT
AS
BEGIN
	DECLARE @IDban NVARCHAR(10)
	DECLARE @SoLuong INT
	DECLARE @MaxSoLuong INT
	DECLARE @IDnhanVien NVARCHAR(10)
	DECLARE @Thang INT
	DECLARE @Nam INT
	SELECT @IDban = ne.IDban, @IDnhanVien = IDnhanVien, @Thang = CONVERT(INT, MONTH(ne.NgayTao)), @Nam = CONVERT(INT, YEAR(ne.NgayTao)) FROM inserted ne
	SELECT @SoLuong = SoLuong, @MaxSoLuong = MaxSoLuong FROM Ban WHERE ID = @IDban
	IF(@SoLuong = @MaxSoLuong)
	BEGIN
		RAISERROR(N'Bàn này đã đủ số lượng người! Không thể thêm',16, 1)
		ROLLBACK
	END
	SET @SoLuong = @SoLuong + 1
	UPDATE Ban SET SoLuong = @SoLuong WHERE ID = @IDban
	IF NOT EXISTS (SELECT * FROM BangLuong WHERE IDnhanVien = @IDnhanVien AND @Thang = Thang AND @Nam = Nam)
	BEGIN
		INSERT INTO BangLuong VALUES(@IDnhanVien, @Thang, @Nam, DEFAULT)
	END
END
GO

-- 3.4.2. Update
CREATE TRIGGER tg_updHoaDonBanHang ON HoaDonBanHang
AFTER UPDATE
AS
BEGIN
	DECLARE @IDban NVARCHAR(10), @TrangThaiMoi BIT, @TrangThaiCu BIT
	SELECT @IDban = ne.IDban, @TrangThaiMoi = ne.DaThanhToan, @TrangThaiCu = ol.DaThanhToan FROM inserted ne, deleted ol
	IF(@TrangThaiMoi != @TrangThaiCu)
	BEGIN
		DECLARE @SoLuong INT, @MaxSoLuong INT
		SELECT @SoLuong = SoLuong, @MaxSoLuong = MaxSoLuong FROM Ban WHERE ID = @IDban
		IF @TrangThaiMoi = 1
		BEGIN
			IF(@SoLuong = 0)
				ROLLBACK
			SET @SoLuong = @SoLuong - 1
		END
		ELSE
		BEGIN
			IF(@SoLuong = @MaxSoLuong)
			BEGIN
				RAISERROR(N'Bàn này đã đủ số lượng người! Không thể thêm',16, 1)
				ROLLBACK
			END
			SET @SoLuong = @SoLuong + 1
		END
		UPDATE Ban SET SoLuong = @SoLuong WHERE ID = @IDban
	END
END
GO

-- 3.4.3. Delete
CREATE TRIGGER tg_delHoaDonBanHang ON HoaDonBanHang
AFTER DELETE
AS
BEGIN
	DECLARE @IDban NVARCHAR(10)
	SELECT @IDban = ol.IDban FROM deleted ol
	DECLARE @SoLuong INT
	SELECT @SoLuong = SoLuong FROM Ban WHERE ID = @IDban
	SET @SoLuong = @SoLuong - 1
	IF(@SoLuong != -1)
	UPDATE Ban SET SoLuong = @SoLuong WHERE ID = @IDban
END
GO


-- 5. Create procedure

-- 6. Create function

-- 6.1. Su dung function de tinh tong tien cua mot hoa don ban hang
CREATE FUNCTION f_TinhTienHoaDonBH() 
RETURNS @table TABLE(
	ID NVARCHAR(10),
	TongGia REAL
)
AS
BEGIN
	INSERT @table SELECT ct.IDhoaDonBH, SUM(ct.soLuong*DonGia) FROM ThucDon td INNER JOIN ChiTietHoaDonBanHang ct ON td.ID = ct.IDthucDon GROUP BY ct.IDhoaDonBH
	RETURN
END
GO

-- 6.2. Su dung function de tinh tong tien cua mot hoa don nhap hang
CREATE FUNCTION f_TinhTienHoaDonNH()
RETURNS @table TABLE(
	ID NVARCHAR(10),
	TongGia REAL
)
AS
BEGIN
	INSERT @table SELECT ct.IDhoaDonNH AS ID, SUM(ct.soLuong*DonGia) AS TONGGIA FROM KhoHang kh INNER JOIN ChiTietHoaDonNhapHang ct ON kh.ID = ct.IDhang GROUP BY ct.IDhoaDonNH
	RETURN
END
GO

-- 6.3. Su dung function de lay thong tin loginNhanVien
CREATE FUNCTION f_LayThongTinNhanVien(@ID NVARCHAR(10)) RETURNS TABLE
AS
	RETURN 
	(SELECT n.ID, n.HoTen, n.DiaChi, n.CMND, n.SDT, n.NgayVaoLam, l.LoginName, l.Permission, l.Ngaytao
	FROM LoginNhanVien l INNER JOIN NhanVien n ON l.IDNhanVien = n.ID WHERE n.ID = @ID)
GO

-- 6.4. Su dung function de lay chi tiet hoa don cua HoaDonBanHang bat ki
CREATE FUNCTION f_LayCTHoaDonBanHang(@IDhoaDonBH NVARCHAR(10)) RETURNS TABLE
AS
	RETURN
	(SELECT IDthucDon, soLuong FROM ChiTietHoaDonBanHang WHERE IDhoaDonBH = @IDhoaDonBH)
GO

-- 6.5. Su dung function de lay chi tiet hoa don cua HoaDonNhapHang bat ki
CREATE FUNCTION f_LayCTHoaDonNhapHang(@IDhoaDonNH NVARCHAR(10)) RETURNS TABLE
AS
	RETURN
	(SELECT IDhang, soLuong FROM ChiTietHoaDonNhapHang WHERE IDhoaDonNH = @IDhoaDonNH)
GO

-- 6.6. Su dung function de lay tat ca ThucDon theo ID LoaiThucDon bat ki
CREATE FUNCTION f_LayCTLoaiThucDon(@IDloaiThucDon NVARCHAR(10)) 
RETURNS @table TABLE (ID NVARCHAR(10), Ten NVARCHAR(50), DonViTinh NVARCHAR(10), DonGia REAL)
AS
BEGIN
	IF (@IDloaiThucDon = '00')
		INSERT @table SELECT ID, Ten, DonViTinh, DonGia FROM ThucDon
	ELSE
		INSERT @table SELECT ID, Ten, DonViTinh, DonGia FROM ThucDon WHERE IDloaiThucDon = @IDloaiThucDon
	RETURN
END
GO

-- 6.7
-- 6.8
-- 6.9

-- 6.10
CREATE FUNCTION f_TaoIDHoaDonBanHangMoi() 
RETURNS @table TABLE(
	IDHDMoi NVARCHAR(10)
	)
AS
BEGIN
	DECLARE @SoHD INT = 0, @IDhoaDon NVARCHAR(10)
	SELECT @SoHD = COUNT(*) FROM HoaDonBanHang
	IF (@SoHD = 0)
	BEGIN
		SET @IDhoaDon = N'00'
	END
	ELSE
	BEGIN
		SELECT @SoHD = MAX(CONVERT(INT, ID)) FROM HoaDonBanHang
		SET @SoHD = @SoHD + 1
		SET @IDhoaDon = CONVERT(NVARCHAR(10), @SoHD)
		IF (@SoHD < 10)
			SET @IDhoaDon = CONCAT(N'0', @IDhoaDon)
	END
	INSERT INTO @table VALUES(@IDhoaDon)
	RETURN
END
GO



-- 6.11
CREATE FUNCTION f_TaoIDHoaDonNhapHangMoi() 
RETURNS @table TABLE(
	IDHDMoi NVARCHAR(10)
	)
AS
BEGIN
	DECLARE @SoHD INT = 0, @IDhoaDon NVARCHAR(10)
	SELECT @SoHD = COUNT(*) FROM HoaDonNhapHang
	IF (@SoHD = 0)
	BEGIN
		SET @IDhoaDon = N'00'
	END
	ELSE
	BEGIN
		SELECT @SoHD = MAX(CONVERT(INT, ID)) FROM HoaDonNhapHang
		SET @SoHD = @SoHD + 1
		SET @IDhoaDon = CONVERT(NVARCHAR(10), @SoHD)
		IF (@SoHD < 10)
			SET @IDhoaDon = CONCAT(N'0', @IDhoaDon)
	END
	INSERT INTO @table VALUES(@IDhoaDon)
	RETURN
END
GO

-- 6.12
CREATE FUNCTION f_ChiTietHoaDonBanHang(@IDHoaDonBH NVARCHAR(10))
RETURNS @table TABLE(
	IDThucDon NVARCHAR(10),
	TenThucDon NVARCHAR(50),
	SoLuong INT,
	DonGia REAL,
	ThanhTien REAL,
	DonViTinh NVARCHAR(50)
	)
AS
BEGIN
	INSERT @table 
	SELECT td.ID ,td.Ten, ct.soLuong, td.DonGia, td.DonGia*ct.soLuong, td.DonViTinh
	FROM ChiTietHoaDonBanHang ct INNER JOIN ThucDon td ON ct.IDthucDon = td.ID
	WHERE ct.IDhoaDonBH = @IDHoaDonBH
	RETURN
END
GO

-- 6.13
CREATE FUNCTION f_ChiTietHoaDonNhapHang(@IDHoaDonNH NVARCHAR(10))
RETURNS @table TABLE(
	IDHang NVARCHAR(10),
	TenHang NVARCHAR(50),
	SoLuong INT,
	DonGia REAL,
	ThanhTien REAL,
	DonViTinh NVARCHAR(50)
	)
AS
BEGIN
	INSERT @table 
	SELECT kh.ID, kh.Ten, ct.soLuong, kh.DonGia, kh.DonGia*ct.soLuong, kh.DonViTinh
	FROM ChiTietHoaDonNhapHang ct INNER JOIN KhoHang kh ON ct.IDhang = kh.ID
	WHERE ct.IDhoaDonNH = @IDHoaDonNH
	RETURN
END
GO

-- 6.13
CREATE FUNCTION f_KiemTraLoGin(@LoginName NVARCHAR(50), @Password NVARCHAR(50))
RETURNS @table TABLE(
	LoginName NVARCHAR(50), 
	Password NVARCHAR(50),
	Invalid BIT
)
AS
BEGIN
	DECLARE @CorrectPassword NVARCHAR(50), @Invalid BIT
	IF EXISTS (SELECT * FROM LoginNhanVien WHERE LoginName = @LoginName)
	BEGIN
		SELECT @CorrectPassword = Password FROM LoginNhanVien WHERE LoginName = @LoginName
		IF(@Password = @CorrectPassword)
			SET @Invalid = 1
		ELSE 
			SET @Invalid = 0
	END
	ELSE
		SET @Invalid = 0
	INSERT INTO @table VALUES(@LoginName, @Password, @Invalid)
	RETURN
END
GO
-- 7. Create view
-- Su dung chuc nang lam bao cao doanh thu
CREATE VIEW BaoCaoBanHang
AS
SELECT  hd.ID,hd.IDNhanVien,hd.Ngaytao,(SELECT TongGia FROM dbo.f_TinhTienHoaDonBH() tt WHERE tt.ID = hd.ID) AS ThanhTien
FROM HoaDonBanHang hd
GO


CREATE VIEW BaoCaoNhapHang
AS
SELECT  hd.ID,hd.IDNhanVien,hd.Ngaytao,(SELECT TongGia FROM dbo.f_TinhTienHoaDonNH() tt WHERE tt.ID = hd.ID) AS ThanhTien
FROM HoaDonNhapHang hd
GO

-- 6.7.
CREATE FUNCTION f_DoanhThuNgay_BanHang(@date DATE) RETURNS TABLE
AS
	RETURN
	(SELECT Ngaytao, SUM(ThanhTien) AS ThuNhap
	FROM BaoCaoBanHang 
	WHERE 
	CONVERT(DATE,Ngaytao) = @date
	GROUP BY Ngaytao)
GO

-- 6.8
CREATE FUNCTION f_DoanhThuNgay_NhapHang(@date DATE) RETURNS TABLE
AS
	RETURN
	(SELECT Ngaytao, SUM(ThanhTien) AS ChiPhi
	FROM BaoCaoNhapHang 
	WHERE 
	CONVERT(DATE,Ngaytao) = @date
	GROUP BY Ngaytao)
GO

-- 6.9
CREATE FUNCTION f_DoanhThu(@daybegin DATE, @dayend DATE)
RETURNS @result table(
	ngay DATE,
	tienBanHang INT,
	tienNhapHang INT,
	thunhap INT
	)
AS
BEGIN
	declare @date DATE = @daybegin
	declare @thunhap INT =  0; 
	DECLARE @Vao REAL = 0
	DECLARE @Ra REAL = 0
	while @date between @daybegin and @dayend
	begin
		SELECT @Vao=SUM(ThuNhap) 
		FROM dbo.f_DoanhThuNgay_BanHang(@date)
		WHERE CONVERT(DATE,Ngaytao) = @date
		IF @Vao IS NULL SET @vao = 0
		SELECT @Ra=SUM(ChiPhi)
		FROM dbo.f_DoanhThuNgay_NhapHang(@date)
		WHERE CONVERT(DATE,Ngaytao) = @date
		IF @ra IS NULL SET @ra =0
		IF(@Vao != 0 OR @Ra != 0)
		BEGIN
			SET @thunhap = @vao - @Ra
			INSERT INTO @result VALUES(@date, @vao, @Ra, @thunhap)
		END
		SET @date = DATEADD(day, 1, @date)
	END
	RETURN
END
GO

CREATE FUNCTION [dbo].[f_DoanhThuThang_BanHang](@monthDate INT, @yearDate INT) RETURNS REAL
AS
BEGIN
	DECLARE @TongTien REAL
	SELECT @TongTien = SUM(ThanhTien)
	FROM BaoCaoBanHang 
	WHERE YEAR(Ngaytao) = @yearDate AND MONTH(Ngaytao) = @monthDate
	IF @TongTien IS NULL RETURN 0
	RETURN @TongTien
END
GO

CREATE FUNCTION [dbo].[f_DoanhThuThang_NhapHang](@monthDate INT, @yearDate INT) RETURNS REAL
AS
BEGIN
	DECLARE @TongTien REAL
	SELECT @TongTien = SUM(ThanhTien)
	FROM BaoCaoNhapHang 
	WHERE YEAR(Ngaytao) = @yearDate AND MONTH(Ngaytao) = @monthDate
	IF @TongTien IS NULL RETURN 0
	RETURN @TongTien
END
GO

CREATE FUNCTION [dbo].[f_DoanhThuThang](@monthBegin INT, @yearBegin INT, @monthEnd INT, @yearEnd INT)
RETURNS @result table(
	ngay NVARCHAR(10),
	tienBanHang INT,
	tienNhapHang INT,
	thunhap INT
	)
AS
BEGIN
	DECLARE @monthDate INT = @monthBegin
	DECLARE @yearDate INT = @yearBegin
	DECLARE @date NVARCHAR(10)
	DECLARE @thunhap INT =  0; 
	DECLARE @Vao REAL = 0
	DECLARE @Ra REAL = 0
	WHILE (@yearDate < @yearEnd OR (@yearDate = @yearEnd AND @monthDate <= @monthEnd))
	BEGIN
		SET @Vao = dbo.f_DoanhThuThang_BanHang(@monthDate, @yearDate)
		IF @Vao IS NULL SET @vao = 0
		SET @Ra = dbo.f_DoanhThuThang_NhapHang(@monthDate, @yearDate)
		IF @ra IS NULL SET @ra =0
		SET @thunhap = @vao - @Ra
		SET @date = CONCAT(CONVERT(NVARCHAR(10), @monthDate), N'/', CONVERT(NVARCHAR(10), @yearDate))
		INSERT INTO @result VALUES(@date, @vao, @Ra, @thunhap)
		SET @monthDate = @monthDate + 1
		IF (@monthDate = 13)
		BEGIN
			SET @monthDate = 1
			SET @yearDate = @yearDate + 1
		END
	END
	RETURN
END
GO

CREATE FUNCTION f_LaySoLuongThucDonTheoNgay(@day INT, @month INT, @year INT) 
RETURNS @table TABLE(
	IDThucDon NVARCHAR(10),
	SoLuong REAL
)
AS
BEGIN
	INSERT @table SELECT ct.IDthucDon, SUM(ct.soLuong) 
	FROM HoaDonBanHang hd INNER JOIN ChiTietHoaDonBanHang ct ON hd.ID = ct.IDhoaDonBH
	WHERE YEAR(Ngaytao) = @year AND (@month = 0 OR MONTH(Ngaytao) = @month) AND (@day = 0 OR DAY(Ngaytao) = @day)
	GROUP BY ct.IDthucDon
	RETURN
END
GO

CREATE FUNCTION f_TopThucDon(@day INT, @month INT, @year INT)
RETURNS @table TABLE(
	TenThucDon NVARCHAR(50),
	SoLuong REAL)
AS
BEGIN
	DECLARE @table1 TABLE(
	IDThucDon NVARCHAR(10),
	SoLuong REAL)
	DECLARE @TenThucDon NVARCHAR(50) = N'Khác'
	DECLARE @SoLuong REAL
	INSERT @table1 SELECT TOP(5) * FROM f_LaySoLuongThucDonTheoNgay(@day, @month, @year) ORDER BY SoLuong DESC
	SELECT @SoLuong = SUM(SoLuong) FROM f_LaySoLuongThucDonTheoNgay(@day, @month, @year) WHERE IDThucDon NOT IN (SELECT IDThucDon FROM @table1)
	INSERT @table SELECT td.Ten, t.SoLuong
	FROM ThucDon td INNER JOIN @table1 t ON td.ID = t.IDThucDon
	IF(@SoLuong IS NULL) SET @SoLuong = 0
	INSERT INTO @table VALUES(@TenThucDon, @SoLuong)
	RETURN
END
GO

CREATE FUNCTION f_LaySoLuongHoaDonNhanVienThanhToanTheoNgay(@day INT, @month INT, @year INT) 
RETURNS @table TABLE(
	IDNhanVien NVARCHAR(10),
	SoLuong REAL
)
AS
BEGIN
	INSERT @table SELECT IDnhanVien, COUNT(ID) 
	FROM HoaDonBanHang
	WHERE YEAR(Ngaytao) = @year AND (@month = 0 OR MONTH(Ngaytao) = @month) AND (@day = 0 OR DAY(Ngaytao) = @day)
	GROUP BY IDnhanVien
	RETURN
END
GO

CREATE FUNCTION f_TopNhanVien(@day INT, @month INT, @year INT)
RETURNS @table TABLE(
	TenNhanVien NVARCHAR(50),
	SoLuong REAL)
AS
BEGIN
	DECLARE @table1 TABLE(
	IDNhanVien NVARCHAR(10),
	SoLuong REAL)
	DECLARE @TenNhanVien NVARCHAR(50) = N'Khác'
	DECLARE @SoLuong REAL
	INSERT @table1 SELECT TOP(5) * FROM f_LaySoLuongHoaDonNhanVienThanhToanTheoNgay(@day, @month, @year) ORDER BY SoLuong DESC
	SELECT @SoLuong = SUM(SoLuong) FROM f_LaySoLuongHoaDonNhanVienThanhToanTheoNgay(@day, @month, @year) WHERE IDNhanVien NOT IN (SELECT IDNhanVien FROM @table1)
	INSERT @table SELECT nv.HoTen, t.IDNhanVien
	FROM NhanVien nv INNER JOIN @table1 t ON nv.ID = t.IDNhanVien
	IF(@SoLuong IS NULL) SET @SoLuong = 0
	INSERT INTO @table VALUES(@TenNhanVien, @SoLuong)
	RETURN
END
GO

CREATE FUNCTION f_LaySoLuongHoaDonThanhVienThanhToanTheoNgay(@day INT, @month INT, @year INT) 
RETURNS @table TABLE(
	IDThanhVien NVARCHAR(10),
	SoLuong REAL
)
AS
BEGIN
	INSERT @table SELECT IDthanhVien, COUNT(ID) 
	FROM HoaDonBanHang
	WHERE YEAR(Ngaytao) = @year AND (@month = 0 OR MONTH(Ngaytao) = @month) AND (@day = 0 OR DAY(Ngaytao) = @day)
	GROUP BY IDthanhVien
	RETURN
END
GO

CREATE FUNCTION f_TopThanhVien(@day INT, @month INT, @year INT)
RETURNS @table TABLE(
	TenThanhVien NVARCHAR(50),
	SoLuong REAL)
AS
BEGIN
	DECLARE @table1 TABLE(
	IDthanhVien NVARCHAR(10),
	SoLuong REAL)
	DECLARE @TenThangVien NVARCHAR(50) = N'Khác'
	DECLARE @SoLuong REAL
	INSERT @table1 SELECT TOP(6) * FROM f_LaySoLuongHoaDonThanhVienThanhToanTheoNgay(@day, @month, @year) ORDER BY SoLuong DESC
	IF '00' IN (SELECT IDthanhVien FROM @table1)
	BEGIN
		DELETE FROM @table1 WHERE IDthanhVien = '00'
	END
	ELSE 
	BEGIN
		DECLARE @IDthanhVien NVARCHAR(10)
		SELECT TOP(1) @IDthanhVien = IDthanhVien FROM @table1 ORDER BY SoLuong ASC
		DELETE FROM @table1 WHERE IDthanhVien = @IDthanhVien
	END
	SELECT @SoLuong = SUM(SoLuong) FROM f_LaySoLuongHoaDonThanhVienThanhToanTheoNgay(@day, @month, @year) WHERE IDthanhVien NOT IN (SELECT IDthanhVien FROM @table1)
	INSERT @table SELECT tv.HoTen, t.SoLuong
	FROM ThanhVien tv INNER JOIN @table1 t ON tv.ID = t.IDthanhVien
	IF(@SoLuong IS NULL) SET @SoLuong = 0
	INSERT INTO @table VALUES(@TenThangVien, @SoLuong)
	RETURN
END
GO

CREATE FUNCTION f_LayThanhVienTheoBan(@IDban NVARCHAR(10))
RETURNS @table TABLE(
	ID NVARCHAR(10),
	HoTen NVARCHAR(50),
	SDT NVARCHAR(10),
	Email NVARCHAR(50),
	IDHoaDon NVARCHAR(10)
)
AS
BEGIN
	INSERT @table 
	SELECT tv.ID, tv.HoTen, tv.SDT, tv.Email, hd.ID
	FROM ThanhVien tv INNER JOIN HoaDonBanHang hd ON hd.IDthanhVien = tv.ID
	WHERE hd.IDban = @IDban AND hd.DaThanhToan = 0
	RETURN
END
GO

GRANT EXECUTE ON dbo.sp_Update_LoginNhanVien TO db_staff
GRANT EXECUTE ON dbo.sp_Update_NhanVien TO db_staff
GRANT EXECUTE ON sp_Update_Ban TO db_staff
GRANT EXECUTE ON sp_Insert_HoaDonBanHang TO db_staff
GRANT EXECUTE ON sp_Update_HoaDonBanHang TO db_staff
GRANT EXECUTE ON sp_Update_TrangThaiHoanDonBanHang TO db_staff
GRANT EXECUTE ON sp_Delete_HoaDonBanHang TO db_staff
GRANT EXECUTE ON sp_Insert_ThanhVien TO db_staff
GRANT EXECUTE ON sp_Update_ThanhVien TO db_staff
GRANT EXECUTE ON sp_Delete_ThanhVien TO db_staff
GRANT EXECUTE ON sp_Insert_HoaDonNhapHang TO db_staff
GRANT EXECUTE ON sp_Update_HoaDonNhapHang TO db_staff
GRANT EXECUTE ON sp_Delete_HoaDonNhapHang TO db_staff
GRANT EXECUTE ON sp_Update_KhoHang TO db_staff
GRANT EXECUTE ON sp_Insert_ChiTietHoaDonBanHang TO db_staff
GRANT EXECUTE ON sp_Update_ChiTietHoaDonBanHang TO db_staff
GRANT EXECUTE ON sp_Delete_ChiTietHoaDonBanHang TO db_staff
GRANT EXECUTE ON sp_Insert_ChiTietHoaDonNhapHang TO db_staff
GRANT EXECUTE ON sp_Update_ChiTietHoaDonNhapHang TO db_staff
GRANT EXECUTE ON sp_Delete_ChiTietHoaDonNhapHang TO db_staff
GRANT SELECT ON f_TinhTienHoaDonBH TO db_staff
GRANT SELECT ON f_TinhTienHoaDonNH TO db_staff
GRANT SELECT ON f_LayThongTinNhanVien TO db_staff
GRANT SELECT ON f_LayCTHoaDonBanHang TO db_staff
GRANT SELECT ON f_LayCTHoaDonNhapHang TO db_staff
GRANT SELECT ON f_LayCTLoaiThucDon TO db_staff
GRANT SELECT ON f_TaoIDHoaDonBanHangMoi TO db_staff
GRANT SELECT ON f_TaoIDHoaDonNhapHangMoi TO db_staff
GRANT SELECT ON f_ChiTietHoaDonBanHang TO db_staff
GRANT SELECT ON f_ChiTietHoaDonNhapHang TO db_staff
GRANT SELECT ON f_KiemTraLoGin TO db_staff
GRANT SELECT ON f_DoanhThuNgay_BanHang TO db_staff
GRANT SELECT ON f_DoanhThuNgay_NhapHang TO db_staff
GRANT SELECT ON f_DoanhThu TO db_staff
GRANT SELECT ON BaoCaoBanHang TO db_staff
GRANT SELECT ON BaoCaoNhapHang TO db_staff
GO

-- NhanVien
INSERT INTO NhanVien VALUES('01', N'minh phuong', '0013423412', '301740555', N'hcm', DEFAULT, DEFAULT, DEFAULT);
INSERT INTO NhanVien VALUES('02', N'hoang nguyen', '0013423412', '301740555', N'hcm', DEFAULT, DEFAULT, DEFAULT);
INSERT INTO NhanVien VALUES('03', N'huu nam', '0013423412', '301740555', N'hcm', DEFAULT, DEFAULT, DEFAULT);
INSERT INTO NhanVien VALUES('04', N'quoc danh', '0013423412', '301740555', N'hcm', DEFAULT, DEFAULT, DEFAULT);
INSERT INTO NhanVien VALUES('05', N'trung hao', '0013423412', '301740555', N'hcm', DEFAULT, DEFAULT, DEFAULT);


-- LoginNhanVien

--DECLARE @date DATE = GETDATE()
--EXEC sp_Insert_LoginNhanVien '01' , 'admin', '12345', 1 , @date
--EXEC sp_Insert_LoginNhanVien '02', 'admin1', '12345', 1 , @date
--EXEC sp_Insert_LoginNhanVien '03', 'user1', '12345', 0 , @date
--EXEC sp_Insert_LoginNhanVien '04', 'user2', '12345', 0 , @date
--EXEC sp_Insert_LoginNhanVien '05', 'user3', '12345', 0 , @date

-- LoaiThucDon

INSERT INTO LoaiThucDon VALUES('00', N'All');
INSERT INTO LoaiThucDon VALUES('01', N'Cà phê đá xay');
INSERT INTO LoaiThucDon VALUES('02', N'Nước ép');
INSERT INTO LoaiThucDon VALUES('03', N'Sinh tố');
INSERT INTO LoaiThucDon VALUES('04', N'Milkshake');
-- ThucDon
--Category 1:Cà phê đá xay
INSERT INTO ThucDon VALUES('01', N'Cà phê đá xay', N'ly', 25000, '01');
INSERT INTO ThucDon VALUES('02', N'Bánh Oreo á xay', N'ly',  22000, '01');
INSERT INTO ThucDon VALUES('03', N'Sôcôla chuối', N'ly', 25000, '01');
INSERT INTO ThucDon VALUES('04', N'Dark Sôcôla chips', N'ly', 25000, '01');
INSERT INTO ThucDon VALUES('05', N'White Sôcôla chips', N'ly', 25000, '01');
INSERT INTO ThucDon VALUES('06', N'Cookies Quế', N'ly', 25000, '01');
INSERT INTO ThucDon VALUES('07', N'Cookies Mocha(Vodka)', N'ly', 28000, '01');
INSERT INTO ThucDon VALUES('08', N'Đá me', N'ly', 15000, '01');
INSERT INTO ThucDon VALUES('09', N'Bạc xỉu', N'ly', 15000, '01');
INSERT INTO ThucDon VALUES('10', N'Cacao nóng/đá', N'ly', 15000, '01');
INSERT INTO ThucDon VALUES('11', N'Cà phê sữa Balley', N'ly', 18000, '01');
INSERT INTO ThucDon VALUES('12', N'sữa tươi', N'ly', 15000, '01');
INSERT INTO ThucDon VALUES('13', N'Trà thảo dược (nóng)', N'ly', 15000, '01');
INSERT INTO ThucDon VALUES('14', N'Lipton chanh dây', N'ly', 15000, '01');
INSERT INTO ThucDon VALUES('15', N'Lipton sữa chanh dây', N'ly', 17000, '01');
INSERT INTO ThucDon VALUES('16', N'Trà sữa đào (kem tươi', N'ly', 18000, '01');
INSERT INTO ThucDon VALUES('17', N'Trà sữa Matcha', N'ly', 20000, '01');
INSERT INTO ThucDon VALUES('18', N'Chai latte Ấn Độ', N'ly', 18000, '01');
INSERT INTO ThucDon VALUES('19', N'sữa gưng mật ong', N'ly', 18000, '01');
INSERT INTO ThucDon VALUES('20', N'Cà phê sữa Blue Sky', N'ly', 20000, '01');

--Category 2:Nước ép
INSERT INTO ThucDon VALUES('21', N'Cam', N'ly', 20000, '02');
INSERT INTO ThucDon VALUES('22', N'Ổi', N'ly', 18000, '02');
INSERT INTO ThucDon VALUES('23', N'Táo', N'ly', 20000, '02');
INSERT INTO ThucDon VALUES('24', N'Dưa hấu', N'ly', 17000, '02');
INSERT INTO ThucDon VALUES('25', N'Thơm + Cà rốt', N'ly', 20000, '02');
INSERT INTO ThucDon VALUES('26', N'Ổi + Cam', N'ly', 20000, '02');
INSERT INTO ThucDon VALUES('27', N'Dâu + Cam', N'ly', 22000, '02');
INSERT INTO ThucDon VALUES('28', N'Dâu + Cam + Dưa leo', N'ly', 22000, '02');
INSERT INTO ThucDon VALUES('29', N'Kiwi + Cam +Dưa leo', N'ly', 22000, '02');

--Category 3:Sinh tố
INSERT INTO ThucDon VALUES('30', N'Dưa', N'ly', 20000, '03');
INSERT INTO ThucDon VALUES('31', N'Bơ', N'ly', 22000, '03');
INSERT INTO ThucDon VALUES('32', N'Xoài', N'ly', 17000, '03');
INSERT INTO ThucDon VALUES('33', N'Dâu', N'ly', 20000, '03');
INSERT INTO ThucDon VALUES('34', N'Cà chua', N'ly', 17000, '03');
INSERT INTO ThucDon VALUES('35', N'Chuối', N'ly', 15000, '03');
INSERT INTO ThucDon VALUES('36', N'Dưa Tiramisu', N'ly', 22000, '03');
INSERT INTO ThucDon VALUES('37', N'Coco Beach', N'ly', 22000, '03');
INSERT INTO ThucDon VALUES('38', N'Kiwi mật ong', N'ly', 22000, '03');
INSERT INTO ThucDon VALUES('39', N'Mãng cầu + Dâu', N'ly', 22000, '03');

--Category 4:Milkshake
INSERT INTO ThucDon VALUES('40', N'Thơm + Bạc Hà', N'dia', 22000, '04');
INSERT INTO ThucDon VALUES('41', N'Sầu riêng', N'dia', 22000, '04');
INSERT INTO ThucDon VALUES('42', N'Xoài tươi', N'dia', 22000, '04');
INSERT INTO ThucDon VALUES('43', N'Hoa hồng', N'dia', 22000, '04');
INSERT INTO ThucDon VALUES('44', N'Trà xanh matcha', N'dia', 22000, '04');
INSERT INTO ThucDon VALUES('45', N'Dâu + Dưa', N'dia', 24000, '04');

-- Ban
INSERT INTO Ban VALUES('01', '001', 0, 4);
INSERT INTO Ban VALUES('02', '002', 0, 4);
INSERT INTO Ban VALUES('03', '003', 0, 4);
INSERT INTO Ban VALUES('04', '004', 0, 2);
INSERT INTO Ban VALUES('05', '005', 0, 2);
INSERT INTO Ban VALUES('06', '006', 0, 2);
INSERT INTO Ban VALUES('07', '007', 0, 1);
INSERT INTO Ban VALUES('08', '008', 0, 1);
INSERT INTO Ban VALUES('09', '009', 0, 1);

-- KhoHang
INSERT INTO KhoHang VALUES('01', N'Đường', N'Kg', 100, 22000);
INSERT INTO KhoHang VALUES('02', N'Sữa đặc', N'Hộp', 100, 18000);
INSERT INTO KhoHang VALUES('03', N'Đá viên', N'Bịch', 200, 7000);
INSERT INTO KhoHang VALUES('04', N'Cà phê bột', N'Kg', 100, 70000);
INSERT INTO KhoHang VALUES('05', N'Sữa tươi không đường', N'Hộp giấy 1L', 200, 32000);
INSERT INTO KhoHang VALUES('06', N'Bột socola', N'Gói 1 Kg', 100, 175000);
INSERT INTO KhoHang VALUES('07', N'Kem Rich', N'Hộp', 100, 25000);
INSERT INTO KhoHang VALUES('08', N'Kem Base', N'Hộp', 100, 70000);
INSERT INTO KhoHang VALUES('09', N'Kem Vani', N'Hộp  1L', 100, 76000);
INSERT INTO KhoHang VALUES('10', N'Bột matcha,', N'100gram', 100, 80000);
INSERT INTO KhoHang VALUES('11', N'Sốt dark chocolate', N'1.89L', 100, 395000);
INSERT INTO KhoHang VALUES('12', N'Sốt caramel', N'630gram', 100, 59000);
INSERT INTO KhoHang VALUES('13', N'Siro hoa quả', N'500ml', 100, 27000);
INSERT INTO KhoHang VALUES('14', N'Mứt hoa quả', N'Hộp', 100, 65000);
INSERT INTO KhoHang VALUES('15', N'Chanh tươi', N'1Kg', 100, 10000);
INSERT INTO KhoHang VALUES('16', N'Trà túi lọc Cozy', N'Gói', 1000, 1500);
INSERT INTO KhoHang VALUES('17', N'Trứng gà', N'Quả', 1000, 3000);
INSERT INTO KhoHang VALUES('18', N'Muối IOT', N'Kg', 100, 7000);
INSERT INTO KhoHang VALUES('19', N'Whipping cream', N'250ml', 1000, 7000);
INSERT INTO KhoHang VALUES('20', N'Topping cream', N'500g', 1000, 35000);
INSERT INTO KhoHang VALUES('21', N'Bơ động vật', N'1Kg', 100, 110000);
INSERT INTO KhoHang VALUES('22', N'Bơ thực vật', N'100g', 1000, 10000);
INSERT INTO KhoHang VALUES('23', N'Bột mì', N'100g', 1000, 4500);
INSERT INTO KhoHang VALUES('24', N'Bột gạo', N'100g', 1000, 25000);
INSERT INTO KhoHang VALUES('25', N'Bột nở', N'50g', 1000, 60000);
INSERT INTO KhoHang VALUES('26', N'Bột năng', N'100g', 1000, 7000);

DECLARE @date1 DATE = GETDATE()
INSERT INTO ThanhVien VALUES('00', N'Anonymous', '09334424', N' ', '34123412', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('01', N'Ngô Hữu Hàn', '09424329', N'phuongdorc@gmail.com', '048320944', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('02', N'Lê Chí Hữu', '09343249', N'phuongdorg@gmail.com', '04842344', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('03', N'Ngô Hữu Tế', '0935203849', N'phuongdorv@gmail.com', '42342344', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('04', N'Lê Tùng Anh', '093524234', N'phuongdorx@gmail.com', '04234244', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('05', N'Hàn Quốc Tế', '093442349', N'phuongdorm@gmail.com', '0424244', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('06', N'Triệu Tư', '0935244239', N'dangquan.x001@gmail.com', '03244244', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('07', N'Ngã Mân', '09343249', N'danhkha.2001@gmail.com', '1424132', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('08', N'Ngô Tiếu Tế', '0935324249', N'tung@gmail.com', '13412421', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('09', N'Trùng Quốc', '09352342349', N'giatu@gmail.com', '1432141', 'HCM', @date1);
INSERT INTO ThanhVien VALUES('10', N'Lê Chí Hùng', '093423449', N'lenga@gmail.com', '13412411', 'HCM', @date1);