
CREATE PROCEDURE [dbo].[AddProduct]
	@NameProduct nvarchar(50),
	@Price decimal(18, 0),
	@Color nvarchar(50),
	@Gender nvarchar(50),
	@Description nvarchar(MAX),
	@QuantityOfGoods int,
	@Category nvarchar(50),
	@Size int,
	@ImageProduct binary(50),
	@Id int output
AS
BEGIN
	INSERT INTO [Product] (NameProduct, Price, Color, Gender, Description, QuantityOfGoods, Category, Size, ImageProduct)
	Values (@NameProduct, @Price, @Color, @Gender, @Description, @QuantityOfGoods, @Category, @Size, @ImageProduct)

	SET @Id = SCOPE_IDENTITY();
END