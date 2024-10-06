-- SQLINES FOR EVALUATION USE ONLY (14 DAYS)
CREATE PROCEDURE usp_userDetails_UI ( 
	@userId INT,
	@userName VARCHAR(60), 
	@firstName VARCHAR(45), 
	@middleName VARCHAR(45), 
	@lastName VARCHAR(45), 
	@email VARCHAR(101),
	@password VARCHAR(120), 
	@contactNo VARCHAR(12), 
	@theme VARCHAR(15), 
	@profileUrl VARCHAR(500)
)   
AS
   BEGIN
   SET NOCOUNT ON;

IF (@userId > 0) BEGIN
		UPDATE UserInfo
        SET FirstName = @firstName,
            MiddleName = @middleName,
            LastName = @lastName,
            ContactNo = @contactNo,
            Theme = @theme,
            ProfileUrl = @profileUrl,
            LastUpdatedOn =  GETDATE()
		WHERE UserId = @userId;
    END
    ELSE BEGIN
        INSERT INTO UserInfo (UserName, FirstName, MiddleName, LastName, Email, Password, ContactNo, Theme, ProfileUrl, IsVerified, IsActive)
		VALUES (@userName, @firstName, @middleName, @lastName, @email, @password, @contactNo, @theme, @profileUrl, 1, 1);
	END 
END