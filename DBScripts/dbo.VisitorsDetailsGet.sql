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

IF EXISTS(SELECT 1 FROM sys.procedures (NOLOCK) WHERE name = 'VisitorsDetailsGet')
BEGIN
	DROP PROCEDURE dbo.VisitorsDetailsGet
END
GO

CREATE PROCEDURE dbo.VisitorsDetailsGet
(
	@FromDate DATETIME,
	@ToDate DATETIME,
	@VisitorID BIGINT = NULL,
	@VisitorName VARCHAR(500) = NULL,
	@VisiedPerson VARCHAR(500) = NULL,
	@CheckExitTime BIT = 0,
	@MobileNo VARCHAR(15),
	@MaxRows INT = 100
)
AS
/*
exec dbo.VisitorsDetailsGet '2016-07-22 00:00:00.000', '2016-07-23 23:59:59.000', null, null, 1
SELECT * FROM ParameterCheck
*/
BEGIN
	SET NOCOUNT ON
    
	SET @VisitorName = '%' + ISNULL(@VisitorName, '') + '%'
	SET @VisiedPerson = '%' + ISNULL(@VisiedPerson, '') + '%'

	IF(@ToDate IS NOT NULL)
	BEGIN
		SELECT @ToDate = DATEADD(SECOND, -1, CAST(CAST(@ToDate + 1 AS DATE) AS DATETIME))
	END

	IF(@MobileNo = '')
	BEGIN
		SELECT @MobileNo = NULL 
	END

	SELECT TOP (@MaxRows)
		V.VisitorID,
		V.FirstName,
		V.LastName,
		V.InTime,
		V.OutTime,
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
		CASE WHEN V.OutTime IS NOT NULL THEN ISNULL(CUREX.FirstName, '') + ISNULL(' ' + CUREX.LastName, '') ELSE '' END AS ExitBy,
		V.MachineID,
		CASE ISNULL(BLV.IsBlackListed, 0) WHEN 1 THEN 'Yes' ELSE 'No' END AS BlackListed
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
	LEFT JOIN dbo.CoreUser (NOLOCK) CUREX
		ON CUREX.CoreUserID = V.UpdateUserID
	LEFT JOIN dbo.CoreCity (NOLOCK) CC 
		ON CC.CityID = V.CityID
	LEFT JOIN (SELECT VisitorID, COUNT(CoVisitorID) AS CoVisitors FROM dbo.CoVisitor (NOLOCK) GROUP BY VisitorID) AS CV
		ON CV.VisitorID = V.VisitorID
	LEFT JOIN dbo.BlackListedVisitor (NOLOCK) BLV
		ON BLV.VisitorID = V.VisitorID
	WHERE (V.InTime >= @FromDate OR @CheckExitTime = 1)
		AND (V.InTime <= @ToDate OR @CheckExitTime = 1)
		AND (V.OutTime >= @FromDate OR @CheckExitTime = 0)
		AND (V.OutTime <= @ToDate OR @CheckExitTime = 0)
		AND (V.VisitorID = @VisitorID OR @VisitorID IS NULL)
		AND (V.FirstName LIKE @VisitorName OR V.LastName LIKE @VisitorName)
		AND (V.PersonName LIKE @VisiedPerson)
		AND (V.MobileNo = @MobileNo OR @MobileNo IS NULL)
	ORDER BY V.EntryDate DESC

	SET NOCOUNT OFF
END
GO

