CREATE TABLE [dbo].[UserInfo] (
    [UserId]        INT           IDENTITY (1, 1) NOT NULL,
    [UserName]      VARCHAR (60)  NOT NULL,
    [FirstName]     VARCHAR (45)  NOT NULL,
    [MiddleName]    VARCHAR (45)  CONSTRAINT [DF__UserInfo__Middle__239E4DCF] DEFAULT (NULL) NULL,
    [LastName]      VARCHAR (45)  NOT NULL,
    [Email]         VARCHAR (101) NOT NULL,
    [Password]      VARCHAR (60)  NOT NULL,
    [ContactNo]     VARCHAR (12)  CONSTRAINT [DF__UserInfo__Contac__24927208] DEFAULT (NULL) NULL,
    [Theme]         VARCHAR (15)  CONSTRAINT [DF__UserInfo__Theme__25869641] DEFAULT (NULL) NULL,
    [ProfileUrl]    VARCHAR (500) CONSTRAINT [DF__UserInfo__Profil__267ABA7A] DEFAULT (NULL) NULL,
    [IsVerified]    BINARY (1)    NOT NULL,
    [IsActive]      BINARY (1)    NOT NULL,
    [CreatedOn]     DATETIME2 (0) CONSTRAINT [DF__UserInfo__Create__276EDEB3] DEFAULT (getdate()) NOT NULL,
    [LastUpdatedOn] DATETIME2 (0) CONSTRAINT [DF__UserInfo__LastUp__286302EC] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

