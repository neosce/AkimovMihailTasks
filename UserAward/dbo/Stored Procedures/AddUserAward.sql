CREATE PROCEDURE AddUserAward
	@IdUser int,
	@IdAward int
AS
BEGIN
	Insert into [UserAndAward] (IdUser, IdAward)
	Values(@IdUser, @IdAward)
END