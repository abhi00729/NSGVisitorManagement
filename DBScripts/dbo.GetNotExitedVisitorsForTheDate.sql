USE NSGVisitorManagement
GO

--DROP TABLE ParameterCheck
--CREATE TABLE ParameterCheck
--(
--	ParameterCheckId INT IDENTITY,
--	FromDate DATETIME,
--	ToDate DATETIME,
--	VisitorID BIGINT,
--	VisitorName VARCHAR(500),
--	CheckExitTime BIT
--)

IF EXISTS(SELECT 1 FROM sys.procedures (NOLOCK) WHERE name = 'GetNotExitedVisitorsForTheDate')
BEGIN
	DROP PROCEDURE dbo.GetNotExitedVisitorsForTheDate
END
GO

CREATE PROCEDURE dbo.GetNotExitedVisitorsForTheDate
(
	@ForDate DATETIME
)
AS
/*
exec dbo.GetNotExitedVisitorsForTheDate '2018-10-01 00:00:00.000'
SELECT * FROM ParameterCheck
*/
BEGIN
	SET NOCOUNT ON
    
	SELECT @ForDate = CAST(CAST(@ForDate AS DATE) AS DATETIME)
	
	SELECT
		V.VisitorID,
		V.FirstName,
		V.LastName,
		V.MobileNo,
		V.InTime,
		V.ValidTill,
		CIT.IdentityType,
		V.IdentityNumber,
		CC.CityName,
		CS.StateName,
		V.VehicleNumber,
		V.Purpose,
		V.PersonName,
		V.VisitedPersonMobile,
		CR.RankName,
		CU.UnitName,
		ISNULL(CV.CoVisitors, 0) AS CoVisitors,
		CUREN.FirstName + ' ' + CUREN.LastName AS EntryBy,
		V.MachineID
	FROM dbo.Visitor (NOLOCK) V
	INNER JOIN dbo.CoreIdentityType (NOLOCK) CIT 
		ON V.IdentityTypeID = cit.IdentityTypeID
	INNER JOIN dbo.CoreState (NOLOCK) CS
		ON CS.StateID = V.StateID
	INNER JOIN dbo.CoreRank (NOLOCK) CR 
		ON CR.RankID = V.RankID
	INNER JOIN dbo.CoreUnit (NOLOCK) CU 
		ON CU.UnitID = V.UnitID
	INNER JOIN dbo.CoreUser (NOLOCK) CUREN
		ON CUREN.CoreUserID = V.EntryUserID
	LEFT JOIN dbo.CoreCity (NOLOCK) CC 
		ON CC.CityID = V.CityID
	LEFT JOIN (SELECT VisitorID, COUNT(CoVisitorID) AS CoVisitors FROM dbo.CoVisitor (NOLOCK) GROUP BY VisitorID) AS CV
		ON CV.VisitorID = V.VisitorID
	WHERE V.InTime >= @ForDate
		AND V.OutTime IS NULL 
		AND V.ValidTill < GETDATE()

	SET NOCOUNT OFF
END
GO

