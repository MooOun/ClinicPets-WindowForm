--- Table Customer ---
create or Alter Procedure InsertCustomers
	@CustomerID char(13) , @CustomerName varchar(30) , @Address varchar (100), @Tel varchar(20)
	as
	begin 
		Insert Into Customers
		Values(@CustomerID ,@CustomerName , @Address ,@Tel)
	end
go
---------------------------------------------------------
create or Alter Procedure UpdateCustomers
	@CustomerID char(13),@CustomerName varchar(30) , @Address varchar (100), @Tel varchar(20), @NewCustomerID char(13)
	as
	begin 
		Update Customers set CustomerID = @NewCustomerID, CustomerName = @CustomerName ,Address = @Address ,Tel = @Tel
		where CustomerID = @CustomerID
	end
go
----------------------------------------------------------
create or Alter Procedure DeleteCustomers
	@CustomerID char(13)
	as
	begin
		Delete from Customers
		where CustomerID = @CustomerID
	end
go

