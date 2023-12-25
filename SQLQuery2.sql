/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[name]
      ,[start_time_utc]
      ,[end_time_utc]
      ,[entry_notes]
      ,[deleted_on]
      ,[hours_worked]
  FROM [rare_crew_database].[dbo].[employee_data]

  update employee_data set hours_worked = (select CAST(ROUND(CAST(DATEDIFF(minute, e.start_time_utc, e.end_time_utc) as decimal)/(CAST(60 as decimal)),0) as int) as hours_wirked from employee_data as e where employee_data.id=e.id);

  select start_time_utc, end_time_utc, DATEDIFF(second, start_time_utc, end_time_utc) as hours_wirked from employee_data;
  select * , DATEDIFF(second, start_time_utc, end_time_utc) as result from employee_data where DATEDIFF(second, start_time_utc, end_time_utc)<0;
  select * from employee_data;
  select *,CAST(ROUND(CAST(DATEDIFF(minute, e.start_time_utc, e.end_time_utc) as decimal)/(CAST(60 as decimal)),0) as int) as hours_wirked_round from employee_data as e;