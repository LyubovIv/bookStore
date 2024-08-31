create database [Store];

use [Store];

create table [dbo].[Books](
	[Id] INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Books_Id PRIMARY KEY([Id]),
	[Name] NVARCHAR(20) NOT NULL CONSTRAINT CK_Books_Name CHECK([Name] != N''),
	[Author] NVARCHAR(50) NOT NULL CONSTRAINT CK_Books_Author CHECK([Author] != N''),
	[Publisher] NVARCHAR(20) NOT NULL CONSTRAINT CK_Books_Publisher CHECK([Publisher] != N''),
	[Pages] INT NOT NULL CONSTRAINT CK_Books_Pages CHECK([Pages] > 0),
	[Genre] NVARCHAR(20) NOT NULL CONSTRAINT CK_Books_Genre CHECK([Genre] != N''),
	[Date] DATE NOT NULL,
	[CostPrise] MONEY NOT NULL CONSTRAINT CK_Books_CostPrise CHECK([CostPrise] > 0),
	[Price] MONEY NOT NULL CONSTRAINT CK_Books_Price CHECK([Price] > 0),
	[Series] NVARCHAR(20) NOT NULL CONSTRAINT CK_Books_Series CHECK([Series] != N'')
)

insert into [dbo].[Books] ([Name]
      ,[Author]
      ,[Publisher]
      ,[Pages]
      ,[Genre]
      ,[Date]
      ,[CostPrise]
      ,[Price]
      ,[Series])
values (N'Процесс', N'Франц Кафка',N'Текст',150,N'антиутопия','01-01-2024',200,560,N'нет')
	,(N'От первого лица', N'Харуки мураками',N'Эксмо',192,N'рассказы','01-01-2022',100,218,N'нет')
	,(N'Убийсво командора', N'Харуки мураками',N'Эксмо',432,N'фэнткзи','01-01-2019',688,829,N'книга 2')
	,(N'Квартирная симфония', N'Оксана Даровская',N'Азбука',280,N'повседневность','01-06-2024',581,709,N'нет')
	,(N'Искусство любить', N'Эрих Фромм',N'АСТ',221,N'психология','01-01-2020',288,349,N'нет')

create table [dbo].[Sales](
	[Id] INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Sales_Id PRIMARY KEY([Id]),
	[DateOfSale] DATE NOT NULL,
	[BookID] INT NOT NULL CONSTRAINT FK_Sales_BookID REFERENCES [Books]([Id]),
	[Quantity] INT NOT NULL CONSTRAINT CK_Sales_Quantity CHECK([Quantity] > 0)
)

insert into [dbo].[Sales]([DateOfSale],[BookID],[Quantity])
values (N'2019-07-01', (select [Id] from [dbo].[Books] where [Name] = N'Убийсво командора'),200)
	,(N'2024-06-01', (select [Id] from [dbo].[Books] where [Name] = N'От первого лица'),500)
	,(N'2024-06-13', (select [Id] from [dbo].[Books] where [Name] = N'Искусство любить'),400)


--тригер на удаление продаж при удалении книги
--(иначе не даст удалить книгу, по которой есть продажи)
CREATE TRIGGER [DeleteBook]
ON [dbo].[Books]
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @BookId INT
		SELECT @BookId = [Id]
		FROM deleted
	IF EXISTS(SELECT * FROM [dbo].[Sales] AS S WHERE [BookID] = @BookId)
		BEGIN
		DELETE [dbo].[Sales]
		WHERE [BookID] = @BookId
		DELETE [dbo].[Books]
		WHERE [Id] = @BookId
		END
	ELSE
		BEGIN
		DELETE [dbo].[Books]
		WHERE [Id] = @BookId
		END
END

-- функционал - продать
create proc sp_sellBook
@id int,
@quantity int
as
insert [dbo].[Sales]([DateOfSale],[BookID],[Quantity])(select getdate(),@id,@quantity)

-- функционал - сделать скидку
create proc sp_discount
@id int
as
update [dbo].[Books]
set [Price] = [Price]/100*90
where [Id] = @id

create table [dbo].[Managers]
(
	[Login] NVARCHAR(20) NOT NULL CONSTRAINT PK_Managers_Login PRIMARY KEY([Login]) CONSTRAINT CK_Table_Login CHECK([Login] != N''),
	[Password] NVARCHAR(20) NOT NULL CONSTRAINT CK_Managers_Password CHECK([Password] != N''),
	[Name] NVARCHAR(20) NOT NULL CONSTRAINT CK_Managers_UserName CHECK([Name] != N''),
	[AccessLevel] INT NOT NULL CONSTRAINT CK_Managers_AccessLevel CHECK([AccessLevel] > 0)
)

insert [dbo].[Managers]
values (N'admin',N'admin',N'Администратор',1),
	(N'manager',N'manager',N'Менеджер',2)