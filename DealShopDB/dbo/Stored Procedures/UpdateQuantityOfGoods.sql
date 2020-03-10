
CREATE PROCEDURE UpdateQuantityOfGoods
	@QuantityOfGoods int,
	@Id int
AS
BEGIN
	Update [Product]
	Set QuantityOfGoods = @QuantityOfGoods
	where Id = @Id
END