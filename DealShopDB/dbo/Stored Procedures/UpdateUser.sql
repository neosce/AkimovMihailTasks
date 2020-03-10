
CREATE PROCEDURE [dbo].[UpdateUser]
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
	@Id int	
AS
BEGIN
	Update [User]
	set LoginEmail = @LoginEmail,
	Password = @Password,
	FirstName = @FirstName,
	LastName = @LastName,
	DateOfBirthday = @DateOfBirthday,
	Address = @Address,
	Age = @Age,
	Money = @Money,
	CreditsCardNumber = @CreditsCardNumber,
	UserLogo = @UserLogo,
	UserRights = @UserRights
	where Id = @Id
END