CREATE PROCEDURE usp_getUserDetailsByEmail (@email VARCHAR(101))   
AS
BEGIN
   SET NOCOUNT ON;
	select UserId, UserName, FirstName, MiddleName, LastName, Email, Password, ContactNo, Theme, ProfileUrl, IsVerified, IsActive
	from UserInfo 
	WHERE Email = @email;
END