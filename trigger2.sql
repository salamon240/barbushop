/*
Deployment script for C:\USERS\SALAM\BARBUSHOP\BARBUSHOP\APP_DATA\DATABASE1.MDF

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "C:\USERS\SALAM\BARBUSHOP\BARBUSHOP\APP_DATA\DATABASE1.MDF"
:setvar DefaultFilePrefix "C_\USERS\SALAM\BARBUSHOP\BARBUSHOP\APP_DATA\DATABASE1.MDF_"
:setvar DefaultDataPath "C:\Users\salam\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\salam\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO

IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
BEGIN TRANSACTION
GO
PRINT N'Dropping unnamed constraint on [dbo].[UsersAudit]...';


GO
ALTER TABLE [dbo].[UsersAudit] DROP CONSTRAINT [DF__UsersAudi__Modif__793DFFAF];


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Creating unnamed constraint on [dbo].[UsersAudit]...';


GO
ALTER TABLE [dbo].[UsersAudit]
    ADD DEFAULT getdate() FOR [ModifiedDate];


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Creating [dbo].[TR_delAuser]...';


GO

 CREATE TRIGGER TR_delAuser ON dbo.[Users]
 
AFTER DELETE
AS
BEGIN

insert into dbo.[UsersAudit]
(
    [UserID],
    [FName],    
    [LName] ,     
    [Address],     
    [phonNumber], 
    [Email],    
    [Password] , 
    [ModifiedBy], 
    [ModifiedDate],  
    [Operation]
)
select 

  D.[UserID],
  D.[FName],    
  D.[LName] ,     
  D.[Address],     
   D.[phonNumber], 
  D.[Email] ,    
  D.[Password] , 
  USER_NAME(),
  'D'
  FROM Deleted D
  end;
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Creating [dbo].[TR_InselAuser]...';


GO
     CREATE TRIGGER TR_InselAuser ON dbo.[Users]
AFTER INSERT
AS
BEGIN
insert into dbo.[UsersAudit]
(
    [UserID],
    [FName],    
    [LName] ,     
    [Address],     
    [phonNumber], 
    [Email],    
    [Password] , 
    [ModifiedBy], 
    [ModifiedDate],  
    [Operation]
)
select 

  I.[UserID],
  I.[FName],    
  I.[LName] ,     
  I.[Address],     
   I.[phonNumber], 
  I.[Email] ,    
  I.[Password] , 
  USER_NAME(),
  'I'
  FROM inserted I;
  end;
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Creating [dbo].[TR_UPDAuser]...';


GO
  
   CREATE TRIGGER TR_UPDAuser ON  dbo.[Users]
AFTER Update
AS
BEGIN
insert into dbo.[UsersAudit]
(
    [UserID],
    [FName],    
    [LName] ,     
    [Address],     
    [phonNumber], 
    [Email],    
    [Password] , 
    [ModifiedBy], 
    [ModifiedDate],  
    [Operation]
)
select 

  D.[UserID],
  D.[FName],    
  D.[LName] ,     
  D.[Address],     
   D.[phonNumber], 
  D.[Email] ,    
  D.[Password] , 
  USER_NAME(),
  'B'
  FROM Deleted D;
  insert into dbo.[UsersAudit]
(
    [UserID],
    [FName],    
    [LName] ,     
    [Address],     
    [phonNumber], 
    [Email],    
    [Password] , 
    [ModifiedBy], 
    [ModifiedDate],  
    [Operation]
)
select
  i.[UserID],
  i.[FName],    
  i.[LName] ,     
  i.[Address],     
   I.[phonNumber], 
  i.[Email] ,    
  i.[Password] , 
  USER_NAME(),
  'A'
  FROM inserted i;
  end;
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT N'The transacted portion of the database update succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT N'The transacted portion of the database update failed.'
GO
IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
GO
PRINT N'Update complete.';


GO
