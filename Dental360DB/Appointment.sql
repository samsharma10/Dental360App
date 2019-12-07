CREATE TABLE [dbo].[Appointment]
(
	[AppointmentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PatientPhone] NVARCHAR(50) NOT NULL, 
    [ServiceId] INT NOT NULL, 
    [StaffId] INT NOT NULL, 
    [AppointmentDate] DATE NOT NULL, 
	[AppointmentStartTime] DATETIME NOT NULL,
    [AppointmentEndTime] DATETIME NOT NULL,
    CONSTRAINT [FK_BookingDetails_ToClient] FOREIGN KEY ([PatientPhone]) REFERENCES [Patient]([PatientPhone]) ON DELETE CASCADE,
	CONSTRAINT [FK_BookingDetails_ToService] FOREIGN KEY ([ServiceId]) REFERENCES [Service]([ServiceId]) ON DELETE CASCADE,
	CONSTRAINT [FK_BookingDetails_ToStaff] FOREIGN KEY ([StaffId]) REFERENCES [Staff]([StaffId]) ON DELETE CASCADE
)
