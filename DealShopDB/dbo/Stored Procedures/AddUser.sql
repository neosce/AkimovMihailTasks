
CREATE PROCEDURE [dbo].[AddUser]
	@LoginEmail nvarchar(50),
	@Password nvarchar(50),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DateOfBirthday nvarchar(50),
	@Address nvarchar(50),
	@Age int,
	@Money decimal(18, 0),
	@CreditsCardNumber int,
	@UserLogo binary(50),
	@UserRights nvarchar(50),
	@Id int	output
AS
BEGIN
	INSERT INTO [User] (LoginEmail, Password, FirstName, LastName, DateOfBirthday, Address, Age, Money, CreditsCardNumber, UserLogo, UserRights)
	Values(@LoginEmail, @Password, @FirstName, @LastName, @DateOfBirthday, @Address, @Age, @Money, @CreditsCardNumber, @UserLogo, @UserRights)

	SET @Id = SCOPE_IDENTITY();
END