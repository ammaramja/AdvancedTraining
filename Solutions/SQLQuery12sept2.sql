/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *
  FROM [Assignment_sep12].[dbo].[Employee]

  insert into [Assignment_sep12].[dbo].[Employee] values(10,'Tasnim',100050,20);

  alter table [Assignment_sep12].[dbo].[Employee]
  add Grade char NULL;

  update [Assignment_sep12].[dbo].[Employee] 
  set Grade='D'
  where Salary > 50000 and Salary <= 100000;

   update [Assignment_sep12].[dbo].[Employee] 
  set Salary = Salary + (Salary*0.10)
  where Grade = 'B';

  delete from 