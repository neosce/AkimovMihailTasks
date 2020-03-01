CREATE PROCEDURE DeleteAward
	@IdAward int
AS
BEGIN
	Delete from [Award] where [IdAward] = @IdAward;
END