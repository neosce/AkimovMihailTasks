
CREATE PROCEDURE UpdateUserMoney
	@Money decimal(18, 0),
	@Id int	
AS
BEGIN
	Update [User]
	set Money = @Money
	where Id = @Id
END