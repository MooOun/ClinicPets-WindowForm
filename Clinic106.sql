use master
--- ��Ǩ�ͺ����հҹ������
if exists (select * from sysdatabases where name ='Clinic106')
		drop database Clinic106
go
---���ҧ �ҹ������
Create Database Clinic106
go
---��Ѻ��ا��������
Alter Database Clinic106 Collate Thai_CI_AS
go
---��ҹ�����ŷ�����ҧ��鹪��� Clinic
use Clinic106
go
---���ҧ���ҧ������ Clinic
--- Table �ѵ���ྷ��
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
--- Table ��Ңͧ�ѵ��
create table Customers
	(CustomerID char(13) Not Null,
	CustomerName varchar(30) Not Null,
	Address varchar(100),
	Tel Varchar(20),
	PRIMARY KEY(CustomerID))
go
--- Table �ѵ��
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
--- Table ����ѡ��
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
--- Table ����෹��˹�����
create table Dealer
	(DealerID int identity(1,1),
	EmpName Varchar(20) Not Null,
	CompanyName Varchar(50),
	Tel Varchar(20),
	PRIMARY KEY(DealerID))
go
--- Table ��
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
---- Table ��¡�á�è�����
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
-- ���������� Veterinary (�ѵ��ᾷ��)
select * from Veterinarys
insert into Veterinarys Values('�.�.�','��ԡ�硵��','�硵�º��ҡ���','Veterinary','�.�شøҹ�','0875175214','�ѡ���ѵ����','vet1','1234')
insert into Veterinarys Values('�.�.�','�â��','����','Veterinary','�.˹ͧ���','0845261152','�ѡ����عѢ','vet2','1234') 
insert into Veterinarys Values('�.�','����','�������','Veterinary','�.�͹��','0896325874','�ѡ�ҹ�','vet3','1234') 
insert into Veterinarys Values('�.�','�ѹ�쾧��','�ػ��','Veterinary','�.�شøҹ�','0954123652','���','vet4','1234') 
go

--���������� Customers (��Ңͧ�ѵ��)
select * from Customers
insert into Customers Values('1104300221593','���','�.�شøҹ�','0988982275')
insert into Customers Values('1419902025352','����','�.�شøҹ�','0634160080')
insert into Customers Values('1100110011001','����','�.�شøҹ�','0612345678')
go

--���������� Animals (�ѵ������§)
select * from Pets
insert into Pets Values('��맺��','�ѵ�캡','�عѢ','���','4M','����','1104300221593')
insert into Pets Values('�����ǹ','�ѵ�캡','�عѢ','��ӵ��','2Y','����','1419902025352')
insert into Pets Values('��������','�ѵ�캡','�عѢ','��Ǵ�','2M','䫺����¹','1100110011001')
insert into Pets Values('������','�ѵ�캡','�عѢ','���','1Y','���','1104300221593')
go

--���������� Cure (����ѡ��)
select * from Treatment
insert into Treatment Values('2022-08-08','�ä...','�͹þ',3000,3750,1,1)
insert into Treatment Values('2022-09-09','�ä...','�մ��',1000,1500,2,2)
insert into Treatment Values('2022-10-10','�ä...','�մ��',1000,1600,3,3)
insert into Treatment Values('2022-10-11','�ä...','�մ��',2000,2600,2,4)
go

--���������� DrugDealer (����෹��˹�����)
select * from Dealer
insert into Dealer Values('���.�','����ѷ �','0985623124')
insert into Dealer Values('���.�','����ѷ �','0987541236')
insert into Dealer Values('���.�','����ѷ �','0685214523')
go

--���������� Drug (��)
select * from Drug
insert into Drug Values('�������',50,75,'5',1)
insert into Drug Values('�������Ѵ',50,50,'5',2)
insert into Drug Values('�������ú��',50,60,'5',3)
go

--���������� DispenseMedList
select * from DispenseDrugs
insert into DispenseDrugs Values(1,10,75,1)
insert into DispenseDrugs Values(2,10,50,2)
insert into DispenseDrugs Values(3,10,60,3)
insert into DispenseDrugs Values(4,10,60,3)
go

