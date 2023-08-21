IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Candidate] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(50) NOT NULL,
    [LastName] nvarchar(50) NOT NULL,
    [IsEnrollment] bit NOT NULL,
    CONSTRAINT [PK_Candidate] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230816063419_CandidateModelAdd', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Candidate] ADD [Address] nvarchar(70) NULL;
GO

ALTER TABLE [Candidate] ADD [Age] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Candidate] ADD [AliasNames] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [BirthCity] nvarchar(70) NULL;
GO

ALTER TABLE [Candidate] ADD [BirthCountry] nvarchar(70) NULL;
GO

ALTER TABLE [Candidate] ADD [BirthCounty] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [BirthPlace] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [BirthState] nvarchar(2) NULL;
GO

ALTER TABLE [Candidate] ADD [BusinessStructure] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [BusinessStructureOther] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [City] nvarchar(70) NULL;
GO

ALTER TABLE [Candidate] ADD [County] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [DOB] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [DriverLicenseExpiration] datetime2 NULL;
GO

ALTER TABLE [Candidate] ADD [DriverLicenseNumber] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [DriverLicenseState] nvarchar(2) NULL;
GO

ALTER TABLE [Candidate] ADD [Email] nvarchar(254) NULL;
GO

ALTER TABLE [Candidate] ADD [EyeColor] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [Gender] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [HairColor] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [Height] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [HeightFeet] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [HeightInches] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [HomePhone] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [LicenseNumber] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [MaritalStatus] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [MiddleName] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [MobilePhone] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [NameSuffix] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [OfficeAddress] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [OfficeCity] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [OfficeState] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [Photo] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [PhysicalMarks] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [PostalCode] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [PrimaryPhone] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [SSN] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [SecondaryPhone] nvarchar(35) NULL;
GO

ALTER TABLE [Candidate] ADD [State] nvarchar(2) NULL;
GO

ALTER TABLE [Candidate] ADD [UsCitizen] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [Weight] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [WorkFax] nvarchar(max) NULL;
GO

ALTER TABLE [Candidate] ADD [WorkPhone] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230816083920_CandidateColumnAdd', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Candidate] ADD [ConcurrentcyToken] rowversion NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230820054237_RowVersion', N'7.0.10');
GO

COMMIT;
GO

