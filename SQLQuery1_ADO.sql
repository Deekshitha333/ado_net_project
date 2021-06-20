﻿CREATE  DATABASE ADO_NET_PROJECT;

 USE ADO_NET_PROJECT

 /*creation of employee table*/

CREATE TABLE EMPLOYEE
(

EMPID INT PRIMARY KEY,
EMPNAME VARCHAR(50),
DOB DATE,
PHONE VARCHAR(50),
MAIL VARCHAR(50),
SALARY FLOAT,
DEPTID  INT FOREIGN KEY   REFERENCES DEPT(DEPTID)



);

INSERT INTO EMPLOYEE VALUES(111,'ALTHAF','23-MAY-1998','7437483833','ALTHAF.66@gmail.com',70000,1);


INSERT INTO EMPLOYEE VALUES(222,'AVINASH','10-APR-1998','7546683833','AVINASH@gmail.com',50000,2);

INSERT INTO EMPLOYEE VALUES(333,'AKASH','12-NOV-1998','9437483833','AKASH@gmail.com',40000,2);


INSERT INTO EMPLOYEE VALUES(444,'RACHANA','18-AUG-1999','6437483833','RACHANA@gmail.com',70000,1);

INSERT INTO EMPLOYEE VALUES(555,'DEEKSHITHA','24-OCT-1997','9988874833','DEEKSHITHA@gmail.com',30000,3);

INSERT INTO EMPLOYEE VALUES(666,'SANJAY','13-MAY-1996','7437483833','SANJAY@gmail.com',70000,4);


INSERT INTO EMPLOYEE VALUES(777,'TARA','15-FEB-1998','7437483833','TARA@gmail.com',60000,3);

INSERT INTO EMPLOYEE VALUES(888,'SHILPA','03-JAN-1998','5437483833','SHILPA@gmail.com',50000,4);




SELECT * FROM EMPLOYEE;
SELECT * FROM DEPT;



/* creation of department table*/


CREATE TABLE DEPT
(
DEPTID INT PRIMARY KEY,
DEPTNAME VARCHAR(50),
DEPTLOC VARCHAR(50),
MGR_ID INT
);


INSERT INTO DEPT VALUES(1,'CIVIL','HYDERABAD',100);

INSERT INTO DEPT VALUES(2,'CSE','BANGLORE',101);

INSERT INTO DEPT VALUES(3,'ECE','UDUPI',102);

INSERT INTO DEPT VALUES(4,'EEE','KOLKATA',111);


/*procedure creation for four quries*/


CREATE PROCEDURE EMP_INSERT
(
@EMPID INT,
@EMPNAME VARCHAR(50),
@DOB DATE,
@PHONE VARCHAR(50),
@MAIL VARCHAR(50),
@SALARY FLOAT,
@DEPTID INT
)
AS 
BEGIN

INSERT INTO EMPLOYEE VALUES(@EMPID,@EMPNAME,@DOB,@PHONE,@MAIL,@SALARY,@DEPTID);

END








CREATE PROCEDURE DEPT_INSERT
(
@DEPTID INT,
@DEPTNAME VARCHAR(50),
@DEPTLOC VARCHAR(50),
@MGR_ID INT
)
AS 
BEGIN

INSERT INTO DEPT VALUES(@DEPTID,@DEPTNAME,@DEPTLOC,@MGR_ID);

END



CREATE PROCEDURE EMP_UPDATE
(
@EMPID INT,
@EMPNAME VARCHAR(50),
@DOB DATETiME,
@PHONE VARCHAR(50),
@MAIL VARCHAR(50),
@SALARY FLOAT,
@DEPTID INT
)
AS 
BEGIN

UPDATE EMPLOYEE SET EMPNAME=@EMPNAME,DOB=@DOB,PHONE=@PHONE,MAIL=@MAIL,SALARY=@SALARY,DEPTID=@DEPTID WHERE EMPID=@EMPID;

END





CREATE PROCEDURE EMP_DELETE(
@EMPID INT)
AS 
BEGIN
DELETE FROM EMPLOYEE WHERE EMPID=@EMPID;
END



