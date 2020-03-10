
CREATE PROCEDURE GetByIdProduct
	@Id int
AS
BEGIN
	Select [Id], [NameProduct], [Price], [Color], [Gender], [Description], [QuantityOfGoods], [Category], [Size], [ImageProduct]
	From [Product]
	where [Id] = @Id
END