CREATE TABLE [dbo].[Clienti]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nume] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Data Nasterii] DATETIME NULL, 
    [Parola] VARCHAR(20) NULL, 
    [CNP] VARCHAR(13) NULL, 
    [Numar Telefon] VARCHAR(10) NULL, 
    [CartAbon] VARCHAR(10) NULL, 
    [Retea] VARCHAR(30) NULL
)
