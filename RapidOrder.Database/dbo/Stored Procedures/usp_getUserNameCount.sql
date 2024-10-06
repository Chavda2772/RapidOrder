-- SQLINES FOR EVALUATION USE ONLY (14 DAYS)
CREATE PROCEDURE usp_getUserNameCount ( @userName NVARCHAR(60))   
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Count(1) as UserNameCount 
    FROM UserInfo 
    WHERE UserName = @userName;
END