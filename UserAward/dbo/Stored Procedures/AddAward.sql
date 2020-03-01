CREATE PROCEDURE AddAward
	@Title nvarchar(50),
	@IdAward int output
AS
BEGIN
	Insert into [Award] (Title)
	Values(@Title)

	Set @IdAward = SCOPE_IDENTITY();
END