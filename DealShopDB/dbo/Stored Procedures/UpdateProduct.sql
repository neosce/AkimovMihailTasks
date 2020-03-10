
CREATE PROCEDURE UpdateProduct
	@NameProduct nvarchar(50),
	@Price decimal(18, 0),
	@Color nvarchar(50),
	@Gender nchar(10),
	@Description nvarchar(MAX),
	@QuantityOfGoods int,
	@Category nvarchar(50),
	@Size int,
	@ImageProduct binary(50),
	@Id int
AS
BEGIN
	Update [Product]
	Set NameProduct = @NameProduct,
	Price = @Price,
	Color = @Color,
	Gender = @Gender,
	Description = @Description,
	QuantityOfGoods = @QuantityOfGoods,
	Category = @Category,
	Size = @Size,
	ImageProduct = @ImageProduct
	where Id = @Id
END