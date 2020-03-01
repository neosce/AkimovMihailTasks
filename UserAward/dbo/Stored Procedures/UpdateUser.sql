CREATE PROCEDURE [dbo].[UpdateUser]
	@Name nvarchar(50),
	@DateTime nvarchar(50),
	@Age int,
	@Id int
AS
BEGIN
	Update [User]
	set Name = @Name,
	DateTime = @DateTime,
	Age = @Age
	where Id = @Id
END