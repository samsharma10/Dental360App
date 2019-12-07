CREATE TABLE [dbo].[Patient]
(
	[PatientPhone] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [PatientFirstName] NVARCHAR(50) NOT NULL, 
    [PatientLastName] NVARCHAR(50) NOT NULL, 
    [PatientEmail] NVARCHAR(50) NOT NULL
)
