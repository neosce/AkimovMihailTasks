
CREATE PROCEDURE [dbo].[GetAllUser]
AS
BEGIN
	Select [Id] ,[LoginEmail], [Password] ,[FirstName] ,[LastName] ,[DateOfBirthday] ,[Address] ,[Money] ,[CreditsCardNumber] ,[UserLogo] ,[UserRights]
from [User]
END