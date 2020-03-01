CREATE PROCEDURE [dbo].[AddUser]
	@Name nvarchar(50),
	@DateTime nvarchar(50),
	@Age int,
	@Id int output
AS
BEGIN
	INSERT INTO [User] (Name, DateTime, Age)
	Values(@Name, @DateTime, @Age)
	
	SET @Id = SCOPE_IDENTITY();
END