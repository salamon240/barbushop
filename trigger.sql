
 CREATE TRIGGER TR_delAuser ON dbo.[Users]
 
AFTER DELETE
AS
BEGIN

insert into dbo.UsersAudit
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
  D.[Password],
  USER_NAME(),
  'D'
  FROM Deleted D
  end;
 
  go
  
   CREATE TRIGGER TR_UPDAuser ON  dbo.[Users]
AFTER Update
AS
BEGIN
insert into dbo.[UsersAudit]
(
    UserID,
    FName,    
    LName ,     
    Address,     
    phonNumber, 
    Email,    
    Password , 
    ModifiedBy, 
    ModifiedDate,  
    Operation
)
select 

  D.UserID,
  D.FName,    
  D.LName ,     
  D.Address,     
   D.phonNumber, 
  D.Email ,    
  D.Password , 
  USER_NAME(),
  'B'
  FROM Deleted D;
  insert into dbo.[UsersAudit]
(
    UserID,
     FName,    
    LName ,     
    Address,     
    phonNumber, 
    Email,    
    Password , 
    ModifiedBy, 
    ModifiedDate,  
    Operation
)
select
  i.UserID,
  i.FName,    
  i.LName ,     
  i.Address,     
   I.phonNumber, 
  i.Email ,    
  i.Password , 
  USER_NAME(),
  'A'
  FROM inserted i;
  end;
  go
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
  go