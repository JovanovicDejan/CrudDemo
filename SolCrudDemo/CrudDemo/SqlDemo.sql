-- Table Production.Products
--CRUD Operations
-- 1. Insert
USE TSQL;

GO

ALTER PROC Production.ProductsInsert
	@productname nvarchar(40),
	@supplierid int,
	@categoryid int,
	@unitprice money,
	@discontinued bit = 0
AS
SET LOCK_TIMEOUT 3000
BEGIN TRY
	--Check if supplierid exists
	IF NOT EXISTS(SELECT supplierid FROM Production.Suppliers
	WHERE supplierid=@supplierid)
	BEGIN 
		RETURN -1
	END
	--Check if categoryid exists
	IF NOT EXISTS(SELECT categoryid FROM Production.Categories
	WHERE categoryid=@categoryid)
	BEGIN
		RETURN -2
	END
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


-- SP For Delete

GO

ALTER PROC Production.ProductDelete

	@productid int

AS
SET LOCK_TIMEOUT 3000
-- Chek if productid extists in OrderdDetails
IF EXISTS(SELECT productid FROM Sales.OrderDetails
WHERE productid=@productid)
BEGIN
	RETURN -1
END
IF NOT EXISTS(SELECT productid FROM Production.Products WHERE productid=@productid)
BEGIN
	RETURN -2
END
BEGIN TRY
	DELETE FROM Production.Products WHERE productid=@productid
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER()
END CATCH
GO


--SP For Update product

GO

CREATE PROC Production.ProductsUpdate
	@productid int,
	@productname nvarchar(40),
	@supplierid int,
	@categoryid int,
	@unitprice money,
	@discontinued bit = 0
AS
SET LOCK_TIMEOUT 3000

IF NOT EXISTS ( SELECT productid FROM Production.Products WHERE productid = @productid)
BEGIN
	RETURN -1
END
BEGIN TRY
	UPDATE Production.Products
	SET 
		productname = @productname, 
		supplierid = @supplierid, 
		categoryid = @categoryid, 
		unitprice = @unitprice, 
		discontinued = @discontinued
	WHERE productid = @productid
	RETURN 0;
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER()
END CATCH
GO