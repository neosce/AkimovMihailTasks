CREATE PROCEDURE GetUserId
	@Name nvarchar(50)
AS
BEGIN
	Select [Id] from [User] where [Name] = @Name
END