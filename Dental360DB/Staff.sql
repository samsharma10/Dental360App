CREATE TABLE [dbo].[Staff]
(
	[StaffId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StaffPhoneNumber] VARCHAR(50) NOT NULL, 
    [StaffFirstName] VARCHAR(50) NOT NULL, 
    [StaffLastName] VARCHAR(50) NOT NULL, 
    [StaffEmail] VARCHAR(50) NULL,
	CONSTRAINT AK_FirstNameID UNIQUE(StaffFirstName)  
)
