-- Table Production.Products
--CRUD Operations
-- 1. Insert
USE TSQL;

GO

CREATE PROC Production.ProductsInsert
	@productname nvarchar(40),
	@supplierid int,
	@categoryid int,
	@unitprice money,
	@discontinued bit = 0
AS

BEGIN TRY
	INSERT INTO Production.Products(productname,supplierid, categoryid, unitprice, discontinued)
	VALUES
	(@productname, @supplierid, @categoryid, @unitprice, @discontinued);
	-- Done without error
	RETURN 0
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER() --ERROR happends
END CATCH
GO

--test

DECLARE @Ret int
EXEC @Ret = Production.ProductsInsert N'New product', 1, 2, 100.00, DEFAULT

PRINT @Ret

SELECT * FROM Production.Products ORDER BY productid DESC

--ERROR
--categoryid 1-8
--supplierid 1-29
GO

DECLARE @Ret int
EXEC @Ret = Production.ProductsInsert N'New product', 1, 20, 100.00, DEFAULT

PRINT @Ret

SELECT * FROM master.sys.sysmessages WHERE error=547