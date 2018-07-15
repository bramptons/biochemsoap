--select * from dbo.SYS_CURRENCY;
--select * from dbo.NL_ACCOUNTS;


select  * from dbo.NL_TRANSACTIONS x
inner join dbo.SL_PL_NL_DETAIL d on x.NT_HEADER_KEY=d.DET_HEADER_KEY
where X.NT_PRIMARY>=879107

--x.NT_DATE>='20180601' and NT_DESCRIPTION='Think Import Journal'