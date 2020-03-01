CREATE PROCEDURE [dbo].[DeleteUser]
	@Id int
AS
BEGIN
	Delete from [UserAndAward] where IdUser = @Id;
	Delete from [User] where Id = @Id
END