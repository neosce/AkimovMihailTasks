CREATE PROCEDURE DeleteUserAward
	@IdUser int,
	@IdAward int
AS
BEGIN
	Delete from [UserAndAward] where IdUser = @IdUser and IdAward = @IdAward
END