USE [master]
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'POCassessment')
    DROP DATABASE POCassessment
GO
CREATE DATABASE POCassessment
GO 
USE POCassessment
GO

CREATE TABLE Employee (
	EmpNumber int primary key identity(1,1) not null,
	EmpName varchar(100) not null,
	EmpSurname varchar(100) not null,
	EmpDOB date not null,
	EmpSalary decimal(10,2) not null,
	RoleDesc varchar(20) not null,
	ReportingLine int
);