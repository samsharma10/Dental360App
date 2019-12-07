CREATE TABLE [dbo].[Service]
(
	[ServiceId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ServiceName] VARCHAR(50) NOT NULL, 
    [ServicePrice] DECIMAL(18, 2) NOT NULL, 
    [ServiceTimeTaken] INT NOT NULL
)
