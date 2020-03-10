
CREATE PROCEDURE GetByIdUser
	@Id int
AS
BEGIN
	Select [Id] ,[LoginEmail] ,[FirstName] ,[LastName] ,[DateOfBirthday] ,[Address] ,[Money] ,[CreditsCardNumber] ,[UserLogo] ,[UserRights]
	from [User]
	where [Id] = @Id
END