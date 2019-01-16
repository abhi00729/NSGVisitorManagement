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

IF EXISTS(SELECT 1 FROM sys.procedures (NOLOCK) WHERE name = 'BlackListedVisitorDetailsGet')
BEGIN
	DROP PROCEDURE dbo.BlackListedVisitorDetailsGet
END
GO

CREATE PROCEDURE dbo.BlackListedVisitorDetailsGet
(
	@FromDate DATETIME,
	@ToDate DATETIME,
	@VisitorName VARCHAR(500) = NULL,
	@VisiedPerson VARCHAR(500) = NULL,
	@MobileNo VARCHAR(15),
	@UnListed BIT = 0,
	@MaxRows INT = 100
)
AS
/*
exec dbo.TimeExpiredVisitorDetailsGet '2016-07-22 00:00:00.000', '2016-07-23 23:59:59.000', null, null, 1
SELECT * FROM ParameterCheck
*/
BEGIN
	SET NOCOUNT ON
    
	SET @VisitorName = '%' + ISNULL(@VisitorName, '') + '%'
	SET @VisiedPerson = '%' + ISNULL(@VisiedPerson, '') + '%'

	IF(@FromDate IS NOT NULL)
	BEGIN
		SELECT @FromDate = CAST(CAST(@FromDate AS DATE) AS DATETIME)
	END

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
		BLV.EntryDate AS BlackListedOn,
		CUREN.FirstName + ' ' + CUREN.LastName AS BlackListedBy,
		CASE WHEN BLV.IsBlackListed = 0 THEN BLV.UpdateDate ELSE NULL END AS UnListedOn,
		CASE WHEN BLV.IsBlackListed = 0 THEN ISNULL(CUREX.FirstName, '') + ISNULL(' ' + CUREX.LastName, '') ELSE '' END AS UnListedBy,
		V.InTime,
		V.OutTime,
		V.ValidTill,
		CASE WHEN GETDATE() > V.ValidTill THEN (DATEDIFF(MINUTE, V.ValidTill, ISNULL(V.OutTime, GETDATE())) / 60) ELSE 0 END AS OverDueHours,
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
		V.MachineID
	FROM dbo.BlackListedVisitor (NOLOCK) BLV
	INNER JOIN dbo.Visitor (NOLOCK) V 
		ON BLV.VisitorID = V.VisitorID
	INNER JOIN dbo.CoreIdentityType (NOLOCK) CIT 
		ON V.IdentityTypeID = cit.IdentityTypeID
	INNER JOIN dbo.CoreState (NOLOCK) CS
		ON CS.StateID = V.StateID
	INNER JOIN dbo.CoreRank (NOLOCK) CR 
		ON CR.RankID = V.RankID
	INNER JOIN dbo.CoreUnit (NOLOCK) CU 
		ON CU.UnitID = V.UnitID
	INNER JOIN dbo.CoreUser (NOLOCK) CUREN
		ON CUREN.CoreUserID = BLV.EntryUserID
	LEFT JOIN dbo.CoreUser (NOLOCK) CUREX
		ON CUREX.CoreUserID = BLV.UpdateUserID
	LEFT JOIN dbo.CoreCity (NOLOCK) CC 
		ON CC.CityID = V.CityID
	LEFT JOIN (SELECT VisitorID, COUNT(CoVisitorID) AS CoVisitors FROM dbo.CoVisitor (NOLOCK) GROUP BY VisitorID) AS CV
		ON CV.VisitorID = V.VisitorID
	WHERE(BLV.EntryDate BETWEEN @FromDate AND @ToDate OR (@FromDate IS NULL AND @ToDate IS NULL))
		AND (BLV.IsBlackListed = 1 OR @UnListed = 1)
		AND (V.FirstName LIKE @VisitorName OR V.LastName LIKE @VisitorName)
		AND (V.PersonName LIKE @VisiedPerson)
		AND (V.MobileNo = @MobileNo OR @MobileNo IS NULL)
		AND BLV.IsBlackListed != @UnListed
	ORDER BY BLV.EntryDate DESC

	SET NOCOUNT OFF
END
GO

