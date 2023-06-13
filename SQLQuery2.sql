USE Nature;

CREATE TABLE Register1
(
Id INT PRIMARY KEY,FirstName VARCHAR(255),
LastName VARCHAR(50),DateOfBirth DATE,
Age INT,Gender VARCHAR(10),PhoneNumber VARCHAR(255),
Address VARCHAR(255),State VARCHAR(50),City VARCHAR(50),
UserName VARCHAR(50),Password VARCHAR(50)
);
INSERT INTO Register1 VALUES(1,'JULIE','JAIN','1996-01-28',27,'FEMALE',6787878,'KOLLAM','KERALA','KOTTARAKKARA','JUL','JUL');
INSERT INTO Register1 VALUES(2,'JUBY','JAIN','1999-01-02',21,'FEMALE',6787888,'KOLLAM','KERALA','OVM','JUB','JUB');
INSERT INTO Register1 VALUES(3,'ALBIN','THAMPI','1990-08-20',35,'MALE',8987878,'EKM','KERALA','KOCHI','ALB','ALB');
INSERT INTO Register1 VALUES(4,'ATHI','NAIR','1995-09-18',27,'MALE',6726878,'ALP','KERALA','MVLKRA','ATH','ATH');
INSERT INTO Register1 VALUES(5,'ACHU','UNNI','1994-05-08',27,'FEMALE',1787878,'KTM','KERALA','PALA','ACH','ACH');

DROP TABLE Register;
UPDATE Register1
SET FirstName = 'Alfred', City= 'Vaikom'
WHERE Id = 5;
SELECT *FROM Register1;
SELECT FirstName FROM Register1 WHERE Id=1;
DELETE FROM Register1 WHERE FirstName='Alfred';
SELECT *FROM Register1;

CREATE TABLE Employee1
(
Id INT PRIMARY KEY,FirstName VARCHAR(255),
LastName VARCHAR(50),
Salary INT,Department VARCHAR(50),PhoneNumber VARCHAR(255)
);
INSERT INTO Employee1 VALUES(1,'JULIE','JAIN',27000,'watcher grade 1',6787878);
INSERT INTO Employee1  VALUES(2,'JUBY','JAIN',21000,'guide',6787888);
INSERT INTO Employee1  VALUES(3,'ALBIN','THAMPI',35000,'guide grade2',8987878);
INSERT INTO Employee1  VALUES(4,'ATHI','NAIR',27500,'officer',6726878);
INSERT INTO Employee1 VALUES(5,'ACHU','UNNI',40000,'police',1787878);
select * from Employee1 where Salary=(select Max(Salary) from Employee1);
SELECT MAX(Salary) FROM Employee1 WHERE Salary < (SELECT MAX(Salary) FROM Employee1);
DROP TABLE Employee;
DROP TABLE Department;
ALTER TABLE Register1
ADD FOREIGN KEY (Id) REFERENCES Employee1(Id);

CREATE TABLE Department
(
Dept_Id INT PRIMARY KEY,Dept_Name VARCHAR(255),
Dept_loc VARCHAR(50),

);
select * from Employee1;

INSERT INTO Department VALUES(1,'watcher grade 1','ktr');
INSERT INTO Department  VALUES(2,'guide','pnlr');
INSERT INTO Department  VALUES(3,'guide grade2','ayoor');
INSERT INTO Department VALUES(4,'officer','pnlr');
INSERT INTO Department VALUES(5,'police','tmla');
select * from Department;
SELECT Dept_Name, COUNT(*)
  FROM Department
  GROUP BY Dept_Name;
  SELECT Employee1.Id, Department.Dept_Name,Dept_loc
FROM Employee1
INNER JOIN Department ON Employee1.Id = Department.Dept_Id;
 SELECT Employee1.Id,Employee1.FirstName, Department.Dept_Name,Dept_loc
FROM Employee1
LEFT JOIN Department ON Employee1.Id = Department.Dept_Id;

SELECT Employee1.Id, Department.Dept_Name,Dept_loc
FROM Employee1
RIGHT JOIN Department ON Employee1.Id = Department.Dept_Id;

SELECT Employee1.Id, Department.Dept_Name,Dept_loc
FROM Employee1
FULL OUTER JOIN Department ON Employee1.Id = Department.Dept_Id;