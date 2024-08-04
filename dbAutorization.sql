create database [ChatAuthorization];

use [ChatAuthorization];

create table [dbo].[Table]
(
	[Login] NVARCHAR(20) NOT NULL CONSTRAINT PK_Table_Login PRIMARY KEY([Login]) CONSTRAINT CK_Table_Login CHECK([Login] != N''),
	[Password] NVARCHAR(20) NOT NULL CONSTRAINT CK_Table_Password CHECK([Password] != N''),
	[UserName] NVARCHAR(20) NOT NULL CONSTRAINT CK_Table_UserName CHECK([UserName] != N'')
)

insert [dbo].[Table]
values (N'admin',N'admin',N'Администратор')