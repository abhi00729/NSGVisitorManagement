
IF NOT EXISTS(SELECT 1 FROM sys.databases (NOLOCK) WHERE name = 'NSGVisitorManagement')
BEGIN
	CREATE DATABASE NSGVisitorManagement
END
GO

USE NSGVisitorManagement
GO

IF NOT EXISTS(SELECT 1 FROM sys.tables (NOLOCK) WHERE name = 'CoreUser')
BEGIN
	CREATE TABLE dbo.CoreUser
	(
		CoreUserID INT IDENTITY NOT NULL PRIMARY KEY CLUSTERED,
		UserName VARCHAR(100) NOT NULL,
		UserPassword VARCHAR(100) NOT NULL,
		EmployeeID VARCHAR(100) NULL,
		FirstName VARCHAR(250) NULL,
		LastName VARCHAR(250) NULL,
		IsActive BIT NOT NULL CONSTRAINT DF_CoreUser_IsActive DEFAULT(1),
		EntryUserID INT NOT NULL,
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreUser_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL,
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT 1 FROM sys.tables (NOLOCK) WHERE name = 'CoreIdentityType')
BEGIN
	CREATE TABLE dbo.CoreIdentityType
	(
		IdentityTypeID INT IDENTITY NOT NULL PRIMARY KEY CLUSTERED,
		IdentityType VARCHAR(250) NOT NULL,
		IsActive BIT NOT NULL CONSTRAINT DF_IdentityType_IsActive DEFAULT(1),
		EntryUserID INT NOT NULL CONSTRAINT FK_IdentityType_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_IdentityType_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_IdentityType_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT NAME FROM sys.tables WHERE name ='CoreState')
BEGIN
	CREATE TABLE dbo.CoreState
	(
		StateID INT IDENTITY(1,1) PRIMARY KEY,
		StateName NVARCHAR(100),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoreState_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreState_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoreState_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END

IF NOT EXISTS(SELECT NAME FROM sys.tables WHERE name ='CoreCity')
BEGIN
	CREATE TABLE dbo.CoreCity
	(
		CityID BIGINT IDENTITY(1,1) PRIMARY KEY,
		StateID INT NOT NULL CONSTRAINT FK_CoreCity_StateID_CoreState_StateID FOREIGN KEY REFERENCES dbo.CoreState(StateID),
		CityName NVARCHAR(100),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoreCity_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreCity_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoreCity_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT NAME FROM sys.tables WHERE name ='CoreRelationship')
BEGIN
	CREATE TABLE dbo.CoreRelationship
	(
		RelationshipID INT IDENTITY NOT NULL PRIMARY KEY,
		Relationship VARCHAR(100),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoreRelationship_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreRelationship_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoreRelationship_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END

IF NOT EXISTS(SELECT NAME FROM sys.tables WHERE name ='CoreRank')
BEGIN
	CREATE TABLE dbo.CoreRank
	(
		RankID INT IDENTITY NOT NULL PRIMARY KEY,
		RankName VARCHAR(100),
		IsActive BIT NOT NULL CONSTRAINT DF_CoreRank_IsActive DEFAULT(1),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoreRank_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreRank_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoreRank_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT NAME FROM sys.tables WHERE name ='CoreUnit')
BEGIN
	CREATE TABLE dbo.CoreUnit
	(
		UnitID INT IDENTITY NOT NULL PRIMARY KEY,
		UnitName VARCHAR(100),
		IsActive BIT NOT NULL CONSTRAINT DF_CoreUnit_IsActive DEFAULT(1),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoreUnit_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreUnit_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoreUnit_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT NAME FROM sys.tables WHERE name ='CoreQuarterType')
BEGIN
	CREATE TABLE dbo.CoreQuarterType
	(
		QuarterTypeID INT IDENTITY NOT NULL PRIMARY KEY,
		QuarterTypeName VARCHAR(100),
		MaxQuarterNumber INT NOT NULL,
		IsActive BIT NOT NULL CONSTRAINT DF_CoreQuarterType_IsActive DEFAULT(1),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoreQuarterType_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoreQuarterType_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoreQuarterType_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END

IF NOT EXISTS(SELECT 1 FROM sys.tables (NOLOCK) WHERE name = 'NSGEmployee')
BEGIN
	CREATE TABLE dbo.NSGEmployee
	(
		NSGEmployeeID BIGINT IDENTITY NOT NULL PRIMARY KEY CLUSTERED,
		NSGEmployeeCode VARCHAR(250) NOT NULL,
		FirstName VARCHAR(250) NOT NULL,
		LastName VARCHAR(250) NULL,
		Gender VARCHAR(10) NOT NULL,
		RankID INT NULL CONSTRAINT FK_NSGEmployee_RankID_CoreRank_RankID FOREIGN KEY REFERENCES dbo.CoreRank(RankID),
		UnitID INT NULL CONSTRAINT FK_NSGEmployee_UnitID_CoreUnit_UnitID FOREIGN KEY REFERENCES dbo.CoreUnit(UnitID),
		QuarterTypeID INT NULL CONSTRAINT FK_NSGEmployee_QuarterTypeID_CoreQuarterType_QuarterTypeID FOREIGN KEY REFERENCES dbo.CoreQuarterType(QuarterTypeID),
		QuarterNumber INT NULL,
		IsActive BIT NOT NULL CONSTRAINT DF_NSGEmployee_IsActive DEFAULT(1),
		EntryUserID INT NOT NULL CONSTRAINT FK_NSGEmployee_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_NSGEmployee_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_NSGEmployee_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT 1 FROM sys.tables (NOLOCK) WHERE name = 'Visitor')
BEGIN
	CREATE TABLE dbo.Visitor
	(
		VisitorID BIGINT IDENTITY NOT NULL PRIMARY KEY CLUSTERED,
		MachineID VARCHAR(250) NOT NULL,
		FirstName VARCHAR(250) NOT NULL,
		LastName VARCHAR(250) NULL,
		Gender VARCHAR(10) NOT NULL,
		MobileNo VARCHAR(15) NULL,
		IdentityTypeID INT NOT NULL CONSTRAINT FK_Visitor_IdentityTypeID_CoreIdentityType_IdentityTypeID FOREIGN KEY REFERENCES dbo.CoreIdentityType(IdentityTypeID),
		IdentityNumber VARCHAR(250) NOT NULL,
		VisitorAddress VARCHAR(500) NULL,
		CityID BIGINT NULL CONSTRAINT FK_Visitor_CityID_CoreCity_CityID FOREIGN KEY REFERENCES dbo.CoreCity(CityID),
		StateID INT NULL CONSTRAINT FK_Visitor_StateID_CoreState_StateID FOREIGN KEY REFERENCES dbo.CoreState(StateID),
		VehicleNumber VARCHAR(250) NULL,
		Purpose VARCHAR(500) NULL,
		PersonEmpCode VARCHAR(50) NULL,
		PersonName VARCHAR(250) NULL,
		RankID INT NULL CONSTRAINT FK_Visitor_RankID_CoreRank_RankID FOREIGN KEY REFERENCES dbo.CoreRank(RankID),
		UnitID INT NULL CONSTRAINT FK_Visitor_UnitID_CoreUnit_UnitID FOREIGN KEY REFERENCES dbo.CoreUnit(UnitID),
		QuarterTypeID INT NULL CONSTRAINT FK_Visitor_QuarterTypeID_CoreQuarterType_QuarterTypeID FOREIGN KEY REFERENCES dbo.CoreQuarterType(QuarterTypeID),
		QuarterNumber INT NULL,
		InTime DATETIME NOT NULL,
		OutTime DATETIME NULL,
		VisitorPhoto IMAGE NULL,
		EntryUserID INT NOT NULL CONSTRAINT FK_Visitor_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_Visitor_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_Visitor_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END


IF NOT EXISTS(SELECT 1 FROM sys.tables (NOLOCK) WHERE name = 'CoVisitor')
BEGIN
	CREATE TABLE dbo.CoVisitor
	(
		CoVisitorID BIGINT IDENTITY NOT NULL PRIMARY KEY CLUSTERED,
		VisitorID BIGINT NOT NULL CONSTRAINT FK_CoVisitor_VisitorID_Visitor_VisitorID FOREIGN KEY REFERENCES dbo.Visitor(VisitorID),
		CoVisitorName VARCHAR(500) NOT NULL,
		IdentityTypeID INT NULL CONSTRAINT FK_CoVisitor_EntryUserID_CoreIdentityType_IdentityTypeID FOREIGN KEY REFERENCES dbo.CoreIdentityType(IdentityTypeID),
		IdentityNumber VARCHAR(250) NULL,
		Gender VARCHAR(10) NOT NULL,
		VisitorAddress VARCHAR(500) NOT NULL,
		RelationshipID INT NOT NULL CONSTRAINT FK_CoVisitor_RelationshipID_CoreRelationship_RelationshipID FOREIGN KEY REFERENCES dbo.CoreRelationship(RelationshipID),
		EntryUserID INT NOT NULL CONSTRAINT FK_CoVisitor_EntryUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		EntryDate DATETIME NOT NULL CONSTRAINT DF_CoVisitor_EntryDate DEFAULT(GETDATE()),
		UpdateUserID INT NULL CONSTRAINT FK_CoVisitor_UpdateUserID_CoreUser_CoreUserID FOREIGN KEY REFERENCES dbo.CoreUser(CoreUserID),
		UpdateDate DATETIME NULL
	)
END
GO


IF NOT EXISTS(SELECT 1 FROM sys.tables WHERE NAME = 'ErrorLog')
BEGIN
	CREATE TABLE dbo.ErrorLog
	(
		ErrorLogID INT IDENTITY(1,1) PRIMARY KEY,
		SPName VARCHAR(500),
		ErrorNumber INT,
		ErrorSeverity INT,
		ErrorState INT,
		ErrorMessage NVARCHAR(4000),
		ErrorTime DATETIME DEFAULT GETDATE()
	)
END
GO

IF NOT EXISTS(SELECT 1 FROM dbo.CoreUser (NOLOCK) CU WHERE CU.UserName = 'NSGAdmin')
BEGIN
	INSERT INTO dbo.CoreUser(UserName, UserPassword, EmployeeID, FirstName, LastName, EntryUserID)
	VALUES ('NSGAdmin', 'nsg@2016', '1', 'System', 'Administrator', 1)
END


IF NOT EXISTS(SELECT 1 FROM dbo.CoreRank (NOLOCK) CR WHERE CR.RankName = 'R 1')
BEGIN
	INSERT INTO dbo.CoreRank (RankName, EntryUserID)
	VALUES ('R 1', 1), ('R 2', 1), ('AC 1', 1), ('AC 2', 1), ('AC 3', 1), ('Team Commander', 1), ('Squadron Commander', 1), ('Group Commander', 1), ('DIG', 1), ('IG', 1), ('DG', 1), ('OTHERS', 1)
END

IF NOT EXISTS(SELECT 1 FROM dbo.CoreUnit (NOLOCK) CU WHERE CU.UnitName = 'FHQ')
BEGIN
	INSERT INTO dbo.CoreUnit (UnitName, EntryUserID)
	VALUES ('FHQ', 1), ('Comm. Grp.', 1), ('KV', 1), ('SWS', 1), ('51 SAG', 1), ('11 SRG', 1), ('12 SRG', 1), ('13 SRG', 1), ('TC', 1), ('ESG', 1), ('Logistics Grp.', 1),
		('R & R Sqn.', 1), ('TN Sqn.', 1), ('Ordn. Sqn.', 1), ('Supply Sqn.', 1), ('Station HQ', 1), ('CH', 1), ('NSG Primary School', 1), ('Const. Grp.', 1)
END

IF NOT EXISTS(SELECT 1 FROM dbo.CoreQuarterType (NOLOCK) CQT WHERE CQT.QuarterTypeName = 'Type-1')
BEGIN
	INSERT INTO dbo.CoreQuarterType (QuarterTypeName, MaxQuarterNumber, EntryUserID)
	VALUES ('Type-1', 46, 1), ('Type-2', 1020, 1), ('Type-2 New', 329, 1), ('Type-3', 426, 1), ('Type-3 New', 115, 1), ('Type-4', 117, 1), ('Type-4 New', 31, 1), ('Type-4 New Spl', 14, 1), ('Type-5', 70, 1), ('Type-6', 4, 1), ('DU', 387, 1), ('KV', 20, 1)
END

IF NOT EXISTS(SELECT 1 FROM dbo.CoreIdentityType (NOLOCK) CIT WHERE CIT.IdentityType = 'PAN Card')
BEGIN
	INSERT INTO dbo.CoreIdentityType(IdentityType, EntryUserID)
	VALUES  ( 'PAN Card', 1), ('Passport', 1), ('Driving License', 1), ('Voter ID', 1), ('Aadhar Card', 1), ('Govt. Emp. ID', 1), ('Others', 1)
END

IF NOT EXISTS(SELECT 1 FROM dbo.CoreRelationship (NOLOCK) CR WHERE CR.Relationship = 'Brother')
BEGIN
	INSERT INTO dbo.CoreRelationship (Relationship, EntryUserID)
	VALUES ('Brother', 1), ('Sister', 1), ('Mother', 1), ('Father', 1), ('Wife', 1), ('Husband', 1), ('Daughter', 1), ('Son', 1), ('Uncle', 1), ('Aunty', 1), ('Friend', 1)
END


IF NOT EXISTS(SELECT 1 FROM dbo.CoreCity (NOLOCK))
BEGIN
	DECLARE @ID INT,
			@state VARCHAR(500),
			@stateId INT,
			@city VARCHAR(500),
			@cityId INT
	
	SELECT TOP 1 @ID = ID, @state = StateName, @city = CityName FROM IndianStatesAndCities WHERE Used = 0
	
	WHILE(@ID IS NOT NULL)
	BEGIN
		SELECT @stateId = CS.StateID FROM dbo.CoreState (NOLOCK) CS WHERE CS.StateName = @state

		IF(@stateId IS NULL)
		BEGIN
			INSERT INTO dbo.CoreState(StateName, EntryUserID)
			VALUES  ( @state, 1)
			SELECT @stateId = CS.StateID FROM dbo.CoreState (NOLOCK) CS WHERE CS.StateName = @state
		END
    
		SELECT @cityId = CC.CityID FROM dbo.CoreCity (NOLOCK) CC WHERE CC.StateID = @stateId AND CC.CityName = @city

		IF(@cityId IS NULL)
		BEGIN
			INSERT INTO dbo.CoreCity(StateID, CityName, EntryUserID)
			VALUES (@stateId, @city, 1)
		END

		UPDATE IndianStatesAndCities SET Used = 1 WHERE ID = @ID

		SELECT @ID = NULL, @state = NULL, @stateId = NULL, @city = NULL, @cityId = NULL

		SELECT TOP 1 @ID = ID, @state = StateName, @city = CityName FROM IndianStatesAndCities WHERE Used = 0
	END
END

select * from sys.tables