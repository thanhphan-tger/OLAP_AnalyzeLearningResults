-- Bảng Người dùng
CREATE TABLE NguoiDung (
    MaNguoiDung INT PRIMARY KEY IDENTITY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(50) NOT NULL
);

-- Bảng Vai trò
CREATE TABLE VaiTro (
    MaVaiTro INT PRIMARY KEY IDENTITY,
    TenVaiTro NVARCHAR(50) UNIQUE NOT NULL
);

-- Bảng Phân quyền
CREATE TABLE PhanQuyen (
    MaPhanQuyen INT PRIMARY KEY IDENTITY,
    TenPhanQuyen NVARCHAR(50) UNIQUE NOT NULL
);

-- Bảng Người dùng - Vai trò
CREATE TABLE NguoiDung_VaiTro (
    MaNguoiDung_VaiTro INT PRIMARY KEY IDENTITY,
    MaNguoiDung INT,
    MaVaiTro INT,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro)
);

-- Bảng Vai trò - Phân quyền
CREATE TABLE VaiTro_PhanQuyen (
    MaVaiTro_PhanQuyen INT PRIMARY KEY IDENTITY,
    MaVaiTro INT,
    MaPhanQuyen INT,
    FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro),
    FOREIGN KEY (MaPhanQuyen) REFERENCES PhanQuyen(MaPhanQuyen)
);




-- Thêm dữ liệu cho bảng VaiTro (Roles)
INSERT INTO VaiTro (TenVaiTro)
VALUES (N'Sinh viên'), (N'Giảng viên'), (N'Admin');

-- Thêm dữ liệu cho bảng PhanQuyen (Permissions)
INSERT INTO PhanQuyen (TenPhanQuyen)
VALUES (N'Xem'), (N'Phân tích'), (N'Thao tác dữ liệu');

INSERT INTO NguoiDung(TenDangNhap, MatKhau)
VALUES 
(N'2001207034', 'PTT123'), 
(N'GV0001', 'DTM123'), 
(N'Admin', '1234');

select MaVaiTro from NguoiDung_VaiTro where MaNguoiDung = (select MaNguoiDung from NguoiDung where TenDangNhap = '2001207034')

