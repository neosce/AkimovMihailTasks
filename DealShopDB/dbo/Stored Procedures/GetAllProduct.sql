
CREATE PROCEDURE [dbo].[GetAllProduct]
AS
BEGIN
	Select [Id], [NameProduct], [Price], [Color], [Gender], [Description], [QuantityOfGoods], [Category], [Size], [ImageProduct]
	From [Product] 
END