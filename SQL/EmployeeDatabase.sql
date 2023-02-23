
use Company;
/*Create Employee Table*/
CREATE TABLE Employee (
ID int ,
Name nvarchar(50),
Address nvarchar(50),
Gender nvarchar(50),
Salary money,
 DNO int,
CONSTRAINT EmployeePK PRIMARY KEY(ID),);
/*Create Department Table*/
CREATE TABLE Department (
DNO int,
DeptName nvarchar(50),
MgrID int,
CONSTRAINT DepartmentPK PRIMARY KEY(DNO),
CONSTRAINT DepartmentFK FOREIGN KEY(MgrID) REFERENCES Employee(id)  );

ALTER TABLE Employee ADD CONSTRAINT EmployeeFK FOREIGN KEY (DNO) REFERENCES Department (DNO);

/*Create Department Location table*/
CREATE TABLE DeptLocation (
DNO int,
DLoc nvarchar(50),
CONSTRAINT DeptLocationPK PRIMARY KEY (DNO,DLoc),
CONSTRAINT DeptLoctionFK FOREIGN KEY (DNO) REFERENCES Department (DNO) );

/*Create Project table*/
CREATE TABLE Project(
 ProjID int,
 DNO int,
 ProjName nvarchar(50),
 ProjLocation nvarchar(50),
 CONSTRAINT ProjectPK PRIMARY KEY(ProjID),
 CONSTRAINT ProjectFK FOREIGN KEY (DNO) REFERENCES Department (DNO));

 /*Create Works_on Table*/
 CREATE TABLE Works_on (
ID int,
ProjID int,
NumOfHours int,
    CONSTRAINT Works_onPK PRIMARY KEY (ID,ProjID),
    CONSTRAINT FKS FOREIGN KEY (ID) REFERENCES Employee (ID) ,
    CONSTRAINT FKP FOREIGN KEY (ProjID) REFERENCES Project (ProjID) );

/*Insert values into Employee table*/
insert into Employee (ID,Name,Address,Gender,Salary) Values (1,'Supriya','Bangalore','Female',8500000);
insert into Employee (ID,Name,Address,Gender,Salary) Values (2,'Max','Hyderbad','Male',6500000);
insert into Employee (ID,Name,Address,Gender,Salary) Values (3,'Romeo','Mangalore','Male',100000);
insert into Employee (ID,Name,Address,Gender,Salary) Values (4,'Vincent','Bangalore','Male',1100000);
insert into Employee (ID,Name,Address,Gender,Salary) Values (5,'Lily','Bangalore','Female',90000);
insert into Employee (ID,Name,Address,Gender,Salary) Values (6,'Robin','Chennai','Female',9500000);
insert into Employee (ID,Name,Address,Gender,Salary) Values (7,'Marshall','Bangalore','Male',65000);
select * from Employee;

insert into Department(DNO,DeptName,MgrID) Values(1,'Production Team',1);
insert into Department(DNO,DeptName,MgrID) Values(2,'Technical Team',2);
insert into Department(DNO,DeptName,MgrID) Values(3,'Design Team',3);
insert into Department(DNO,DeptName,MgrID) Values(4,'Testing Team',4);

insert into DeptLocation (DNO,DLoc) Values (1,'Bangalore');
insert into DeptLocation (DNO,DLoc) Values (2,'Chennai');
insert into DeptLocation (DNO,DLoc) Values (3,'Bangalore');
insert into DeptLocation (DNO,DLoc) Values (4,'Chennai');

UPDATE employee SET DNO=1 WHERE ID=1;
UPDATE employee SET DNO=2 WHERE ID=2;
UPDATE employee SET DNO=3 WHERE ID=3;
UPDATE employee SET DNO=4 WHERE ID=4;
UPDATE employee SET DNO=1 WHERE ID=5;
UPDATE employee SET DNO=2 WHERE ID=6;
UPDATE employee SET DNO=3 WHERE ID=7;

insert into Project(ProjID,Projame,ProjLocation,DNO) Values (2,'Clinic Management','Bangalore',3);
insert into Project(ProjID,Projame,ProjLocation,DNO) Values (3,'Food Management','Bangalore',4);
insert into Project(ProjID,Projame,ProjLocation,DNO) Values (4,'IOT','Bangalore',2);

insert into Works_on (ID,ProjID,NumOfHours) Values (2,1,22);
insert into Works_on (ID,ProjID,NumOfHours) Values (6,1,22);
insert into Works_on (ID,ProjID,NumOfHours) Values (3,2,55);
insert into Works_on (ID,ProjID,NumOfHours) Values (7,2,55);
insert into Works_on (ID,ProjID,NumOfHours) Values (4,3,72);

/*Get the Name and salary of manager using inner join*/
Select e.ID,e.Name,e.Salary from Employee e INNER JOIN Department d on e.ID=d.MgrID;

/*get minimum salary,maximum salary,average salary of Technical team*/
SELECT SUM(e.Salary) AS SUM_SAL,MAX(e.Salary) AS MAX_SAL,MIN(e.Salary) AS MIN_SAL,AVG(e.Salary) AS AVG_SAL 
FROM Employee e,Department d 
WHERE d.DNO=d.DNO AND d.DeptName='Technical Team';


CREATE PROCEDURE spvalidateEmployee
@ID int,
@Name nvarchar(50),
@Address nvarchar(50),
@Gender nvarchar(50),
@Salary money,
@DNO int
as
if exists (select * from Department where DNO=@DNO)
begin
insert into Employee
values
(
@ID ,
@Name ,
@Address ,
@Gender ,
@Salary ,
@DNO 
)
end
else
begin
raiserror( 'It is not a Department id',1,1)
return -100
end

declare @return_value int
exec @return_value=spvalidateEmployee
9,'Pixi','Delhi','Female',3456000,7
print 'Return code:'+convert(varchar,@return_value)

delete from Employee where ID=9;

CREATE INDEX EmpNameIndex on Employee(Name);
sp_helpindex 'Employee'
CREATE UNIQUE INDEX DNOIndex on Department(DNO);
DROP INDEX DNOIndex ON Department;



DECLARE @ProjID int ,@Projame  nvarchar(50);
DECLARE Project_cursor CURSOR FOR     
SELECT ProjID,Projame   
FROM Project  
order by ProjID;

OPEN  Project_cursor;

FETCH NEXT FROM Project_cursor     
INTO @ProjID, @Projame  
print 'Project_ID  Project_Name'   

WHILE @@FETCH_STATUS = 0    
BEGIN    
    print '   ' + CAST(@ProjID as varchar(10)) +'        '+  
        cast(@Projame as varchar(20))
    FETCH NEXT FROM Project_cursor
INTO @ProjID,@Projame
END

CLOSE Project_cursor;
DEALLOCATE Project_cursor;


Create table LogTable
(id int NOT NULL PRIMARY KEY IDENTITY(1, 1),
EmpId int,
EmpName nvarchar(50),
EmpGender nvarchar(50),
TriggerAction nvarchar(50),
ActionTime datetime);

CREATE TRIGGER EmployeeInsertTrigger 
on Employee  
FOR INSERT  
as  
declare @EmpId int, @EmpName nvarchar(50), @EmpGender nvarchar(50);  
select @EmpId = Insrt.ID, @EmpName = Insrt.Name, @EmpGender = Insrt.Gender from inserted Insrt;  
insert into LogTable(EmpId, EmpName, EmpGender, TriggerAction, ActionTime)  
values(@EmpId, @EmpName, @EmpGender, 'Record inserted', GETDATE());  
print 'Trigger fired - After Insert'  