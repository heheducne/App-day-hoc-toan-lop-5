﻿CREATE DATABASE LEARNING
USE LEARNING
---------------chạy hết code dưới này
DROP TABLE ACCOUNT
CREATE TABLE ACCOUNT(
TDN NVARCHAR(255) NOT NULL PRIMARY KEY,
NAME_STUDENT NVARCHAR(255),
CLASS VARCHAR(255),
SCHOOL VARCHAR(255),
PASS VARCHAR(255) NOT NULL,
CATE INT NOT NULL,
EMAIL VARCHAR(255),
IMAGE_PATH VARCHAR(255)
)
select * from dbo.ACCOUNT where TDN ='tuanct'

------đừng chạy code dưới
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
------------chạy hết code dưới mới chạy dc app
CREATE TABLE DANHGIA1(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CMT NVARCHAR(255),
STAR INT
);
CREATE TABLE DANHGIA2(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CMT NVARCHAR(255),
STAR INT
);
CREATE TABLE DANHGIA3(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CMT NVARCHAR(255),
STAR INT
);
CREATE TABLE DANHGIA4(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CMT NVARCHAR(255),
STAR INT
);
CREATE TABLE DANHGIA5(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CMT NVARCHAR(255),
STAR INT
);
CREATE TABLE DANHGIA6(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CMT NVARCHAR(255),
STAR INT
);

CREATE TABLE XEPHANG1(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CLASS NVARCHAR(255) NOT NULL,
SCHOOL NVARCHAR(255) NOT NULL,
SCORE NVARCHAR(255),
TIME_PLAY NVARCHAR(255)
);
CREATE TABLE XEPHANG2(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CLASS NVARCHAR(255) NOT NULL,
SCHOOL NVARCHAR(255) NOT NULL,
SCORE NVARCHAR(255),
TIME_PLAY NVARCHAR(255)
);
CREATE TABLE XEPHANG3(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CLASS NVARCHAR(255) NOT NULL,
SCHOOL NVARCHAR(255) NOT NULL,
SCORE NVARCHAR(255),
TIME_PLAY NVARCHAR(255)
);
CREATE TABLE XEPHANG4(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CLASS NVARCHAR(255) NOT NULL,
SCHOOL NVARCHAR(255) NOT NULL,
SCORE NVARCHAR(255),
TIME_PLAY NVARCHAR(255)
);
CREATE TABLE XEPHANG5(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CLASS NVARCHAR(255) NOT NULL,
SCHOOL NVARCHAR(255) NOT NULL,
SCORE NVARCHAR(255),
TIME_PLAY NVARCHAR(255)
);
CREATE TABLE XEPHANG6(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255) NOT NULL,
CLASS NVARCHAR(255) NOT NULL,
SCHOOL NVARCHAR(255) NOT NULL,
SCORE NVARCHAR(255),
TIME_PLAY NVARCHAR(255)
);

select * from XEPHANG2