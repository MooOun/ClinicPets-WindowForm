use master
--- ตรวจสอบว่ามีฐานข้อมูล
if exists (select * from sysdatabases where name ='Clinic106')
		drop database Clinic106
go
---สร้าง ฐานข้อมูล
Create Database Clinic106
go
---ปรับปรุงโค้ดภาษาไทย
Alter Database Clinic106 Collate Thai_CI_AS
go
---ใช้ฐานข้อมูลที่สร้างขึ้นชื่อ Clinic
use Clinic106
go
---สร้างตารางข้อมูล Clinic
--- Table สัตว์เเพทย์
create table Veterinarys
	(VeterrinaryID int identity(1,1),
	Title varchar(20) Not Null,
	FirstName Varchar(50) Not Null,
	LastName varchar(50) Not Null,
	Position varchar (50) Not Null, 
	Address varchar(100),
	Tel varchar(20),
	VetExp varchar(150),
	Username varchar(50),
	Password varchar(50),
	PRIMARY KEY(VeterrinaryID))
go
--- Table เจ้าของสัตว์
create table Customers
	(CustomerID char(13) Not Null,
	CustomerName varchar(30) Not Null,
	Address varchar(100),
	Tel Varchar(20),
	PRIMARY KEY(CustomerID))
go
--- Table สัตว์
create table Pets
	(PetID int identity(1,1),
	PetName Varchar(20) Not Null,
	AnimalType varchar(50),
	Description varchar(150),
	Color varchar(50),
	Age char(3),
	Species char(50),
	CustomerID char(13) Not Null,
	PRIMARY KEY(PetID),
	FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID))
go
--- Table การรักษา
create table Treatment 
	(TreatmentID int identity(1,1),
	DateCure date,
	Symptom varchar(200),
	Imprement varchar(200),
	TreatmentPrice money Default 0,
	TotalPrice money Default 0,
	VeterrinaryID int,
	PetID int,
	PRIMARY KEY(TreatmentID),
	FOREIGN KEY(VeterrinaryID) REFERENCES Veterinarys(VeterrinaryID),
	FOREIGN KEY(PetID) REFERENCES Pets(PetID))
go
--- Table ตัวเเทนจำหน่ายยา
create table Dealer
	(DealerID int identity(1,1),
	EmpName Varchar(20) Not Null,
	CompanyName Varchar(50),
	Tel Varchar(20),
	PRIMARY KEY(DealerID))
go
--- Table ยา
create table Drug
	(DrugID int identity(1,1),
	DrugName Varchar(50) Not Null,
	Quantity int Default 0,
	UnitPrice money Default 0,
	Size varchar(10),
	DealerID int,
	PRIMARY KEY(DrugID),
	FOREIGN KEY(DealerID) REFERENCES Dealer(DealerID))
go
---- Table รายการการจ่ายยา
create table DispenseDrugs
	(TreatmentID int,
	QuantitiyDrug int Default 0,
	UnitPrice money Default 0,
	DrugID int ,
	PRIMARY KEY(TreatmentID,DrugID),
	FOREIGN KEY(TreatmentID) REFERENCES Treatment(TreatmentID),
	FOREIGN KEY(DrugID) REFERENCES Drug(DrugID))
go



---------------- Insert Data To Table ------------------
-- เพิ่มข้อมูล Veterinary (สัตว์แพทย์)
select * from Veterinarys
insert into Veterinarys Values('ส.พ.ญ','ไก่จิกเด็กตาย','เด็กตายบนปากโอ่ง','Veterinary','จ.อุดรธานี','0875175214','รักษาสัตว์น้ำ','vet1','1234')
insert into Veterinarys Values('ส.พ.ญ','ใครขาย','ไข่ไก่','Veterinary','จ.หนองคาย','0845261152','รักษาสุุนัข','vet2','1234') 
insert into Veterinarys Values('ส.พ','กงบง','เสเรอเกอ','Veterinary','จ.ขอนเก่น','0896325874','รักษานก','vet3','1234') 
insert into Veterinarys Values('ส.พ','กันต์พงษ์','อุปมา','Veterinary','จ.อุดรธานี','0954123652','รวย','vet4','1234') 
go

--เพิ่มข้อมูล Customers (เจ้าของสัตว์)
select * from Customers
insert into Customers Values('1104300221593','ธาม','จ.อุดรธานี','0988982275')
insert into Customers Values('1419902025352','เเคร์','จ.อุดรธานี','0634160080')
insert into Customers Values('1100110011001','ลาวา','จ.อุดรธานี','0612345678')
go

--เพิ่มข้อมูล Animals (สัตว์เลี้ยง)
select * from Pets
insert into Pets Values('บิ๋งบิ๋ง','สัตว์บก','สุนัข','ขาว','4M','ชิสุ','1104300221593')
insert into Pets Values('หมูอ้วน','สัตว์บก','สุนัข','น้ำตาล','2Y','ชิสุ','1419902025352')
insert into Pets Values('เอ็ดเวิร์ด','สัตว์บก','สุนัข','ขาวดำ','2M','ไซบีเรียน','1100110011001')
insert into Pets Values('ซีเเม็ก','สัตว์บก','สุนัข','ขาว','1Y','ปอม','1104300221593')
go

--เพิ่มข้อมูล Cure (การรักษา)
select * from Treatment
insert into Treatment Values('2022-08-08','โรค...','นอนรพ',3000,3750,1,1)
insert into Treatment Values('2022-09-09','โรค...','ฉีดยา',1000,1500,2,2)
insert into Treatment Values('2022-10-10','โรค...','ฉีดยา',1000,1600,3,3)
insert into Treatment Values('2022-10-11','โรค...','ฉีดยา',2000,2600,2,4)
go

--เพิ่มข้อมูล DrugDealer (ตัวเเทนจำหน่ายยา)
select * from Dealer
insert into Dealer Values('นาย.ก','บริษัท ก','0985623124')
insert into Dealer Values('นาย.ข','บริษัท ข','0987541236')
insert into Dealer Values('นาย.ค','บริษัท ค','0685214523')
go

--เพิ่มข้อมูล Drug (ยา)
select * from Drug
insert into Drug Values('ยาเเก้แพ้',50,75,'5',1)
insert into Drug Values('ยาเเก้หวัด',50,50,'5',2)
insert into Drug Values('ยาแก้อะไรบุ๊',50,60,'5',3)
go

--เพิ่มข้อมูล DispenseMedList
select * from DispenseDrugs
insert into DispenseDrugs Values(1,10,75,1)
insert into DispenseDrugs Values(2,10,50,2)
insert into DispenseDrugs Values(3,10,60,3)
insert into DispenseDrugs Values(4,10,60,3)
go

