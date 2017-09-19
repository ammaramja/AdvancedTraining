delete from Employee 
where Salary<2000 and Grade='A';

select MAX(Salary) as second from Employee
where Salary not in (
select MAX(Salary) from Employee);


CREATE TABLE SalesDetails(
SalesOrderId varchar(10) Primary key,
UnitPrice int,
OrderQty int,
Area varchar(10));

ALTER TABLE SalesDetails
ADD PRIMARY KEY(SalesOrderId)

ALTER TABLE SalesDetails
ALTER COLUMN SalesOrderId varchar not null;

SELECT *
FROM SalesDetails;

INSERT INTO SalesDetails VALUES(1,100,10,'South');
INSERT INTO SalesDetails VALUES(2,10,120,'East');
INSERT INTO SalesDetails VALUES(3,290,50,'North');
INSERT INTO SalesDetails VALUES(4,150,100,'West');

INSERT INTO SalesDetails VALUES(5,10,120,'South');
INSERT INTO SalesDetails VALUES(6,1,1250,'East');
INSERT INTO SalesDetails VALUES(7,90,530,'North');
INSERT INTO SalesDetails VALUES(8,10,800,'West');

SELECT Area,SUM(OrderQty * UnitPrice) AS total_sales
FROM SalesDetails
GROUP BY Area;

SELECT AREA
FROM SalesDetails
WHERE 

SELECT top 1 Area, SUM(OrderQty * UnitPrice) As largest from SalesDetails 
Group By Area
order by largest desc;