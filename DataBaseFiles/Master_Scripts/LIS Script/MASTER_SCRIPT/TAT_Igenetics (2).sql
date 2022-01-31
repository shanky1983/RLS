

declare @orgid int=69,
        @frdate datetime,
        @todate datetime

select @frdate = '2016-03-01 00:00:00'
select @todate = '2015-11-31 00:00:00'


CREATE TABLE #temp
(
	orgid				INT,
	orgaddressid		INT,
	patientvisitid		BIGINT,
	refervisitid		BIGINT,
	visitnumber			VARCHAR(30),
	orderedtestid		BIGINT,	
	orderedtestname		VARCHAR(255),
	orderedtesttype		VARCHAR(3),
	investigationid		BIGINT,
	investigationname	VARCHAR(255),
	collecteddatetime	DATETIME,
	receiveddatetime	DATETIME,
	approveddatetime	DATETIME,
	CollectedLocID		INT,
	RecSampleLocID		INT,
	status				VARCHAR(100),
	sampleid			BIGINT,
	barcodenumber		VARCHAR(50)
)

INSERT INTO #temp
		(
			orgid,
			orgaddressid,
			patientvisitid,
			visitnumber,
			refervisitid,
			orderedtestid,
			orderedtesttype,
			orderedtestname,
			investigationid,
			investigationname,
			collecteddatetime,
			receiveddatetime,
			approveddatetime,
			status,
			CollectedLocID,
			RecSampleLocID,
			sampleid,
			barcodenumber
		)

SELECT	pv.OrganizationID,
		pv.OrgAddressID,
		pv.PatientVisitId,
		pv.VisitNumber,
		pv.ReferVisitID,
		oi.ID,
		oi.type,
		oi.Name as OrderedTestName,
		pinv.InvestigationID,
		pinv.InvestigationName ,
		pis.CollectedDateTime,
		pis.CollectedDateTime,
		pinv.ApprovedAt,
		oi.Status,
		pis.CollectedLocID,
		pis.RecSampleLocID,
		pis.sampleid,
		pis.BarcodeNumber
FROM	PatientVisit pv(nolock)
		INNER JOIN OrderedInvestigations OI(nolock) ON	pv.PatientVisitId=OI.VisitID
		AND	pv.OrganizationID=OI.OrgID
		INNER JOIN PatientInvestigation pinv(nolock) ON pv.PatientVisitId=pinv.PatientVisitID
		AND	pinv.AccessionNumber=oi.AccessionNumber AND	pv.OrganizationID=pinv.OrgID
		INNER JOIN patientinvsample pis (nolock) ON pis.PatientVisitID	=pinv.PatientVisitID
		INNER JOIN patientinvsamplemapping pism(nolock) ON	pis.PatientVisitID=pism.VisitID
		AND	pis.SampleCode =	pism.SampleID AND pis.SampleID = pism.SID AND pism.ID = oi.ID AND oi.UID = pism.UID
		AND	pis.BarcodeNumber	=	pism.Barcode
WHERE	pv.OrganizationID	=	@orgid
AND OI.Status='Approve'
AND	CONVERT(DATE,pv.VisitDate) BETWEEN @frdate and @todate


UPDATE	tmp 
SET		tmp.collecteddatetime = null 
FROM	#temp tmp 
WHERE	CollectedLocID <> RecSampleLocID



UPDATE  tmp
SET		tmp.collecteddatetime	=	st.CreatedAt
FROM	#temp tmp 
		INNER JOIN sampletracker st (NOLOCK) ON	tmp.patientvisitid = st.PatientVisitID
		AND st.InvSampleStatusID	= 3  
		AND tmp.sampleid			= st.SampleID
		AND	tmp.CollectedLocID		<> tmp.RecSampleLocID 

--SELECT * FROM OrganizationAddress WHERE AddressID = 107

--1ST FLOOR, KRISLON HOUSE	MARWA RD, GANESH NAGAR	MAROL, ANDHERI EAST	400072	75	MUMBAI 

select 
    visitnumber,
	orderedtestname,
	orderedtesttype,
	orgaddressid,
	max(collecteddatetime) [Recived DateTime],
	max(receiveddatetime) [Collected DateTime],
	max(approveddatetime) [ApproveDateTime],
	tmp.status,
    oa.Location 
from #temp tmp
     inner join OrganizationAddress oa (nolock) on tmp.orgaddressid = oa.AddressID
group by 
     visitnumber,
	 orderedtestname,
	 orderedtesttype,
	 orgaddressid,
	 tmp.status,
	 oa.Location

drop table #temp
