
CREATE PROCEDURE AddOrder
	@IdProduct int,
	@IdUser int,
	@Status nvarchar(50),
	@Order int output 
AS
BEGIN
	INSERT INTO [Table_Order] (IdProduct, IdUser, Status)
	Values (@IdProduct, @IdUser, @Status)

	Set @Order = SCOPE_IDENTITY();
END