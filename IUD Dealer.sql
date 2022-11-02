--- Table Dealer---
create or Alter Procedure InsertDrugDealer
	@EmpName varchar(20) , @CompanyName varchar (50), @Tel varchar(20)
	as
	begin 
		Insert Into Dealer
		Values(@EmpName , @CompanyName ,@Tel)
	end
go
---------------------------------------------------------
create or Alter Procedure UpdateDrugDealer
	@DealerID int,@EmpName varchar(20) , @CompanyName varchar (50), @Tel varchar(20)
	as
	begin 
		Update Dealer set EmpName = @EmpName ,CompanyName = @CompanyName ,Tel = @Tel
		where DealerID = @DealerID
	end
go
----------------------------------------------------------
create or Alter Procedure DeleteDrugDealer
	@DealerID int
	as
	begin
		Delete from Dealer
		where DealerID = @DealerID
	end
go

