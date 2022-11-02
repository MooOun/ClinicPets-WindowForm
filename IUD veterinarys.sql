--- Table Veterinary ---
create or Alter Procedure InsertVeterinary
	@Title varchar (20),@FirstName varchar(50) , @LastName varchar(50), @Position varchar(50), @Address varchar (100), 
	@Tel varchar(20),@VetExp varchar(150),
	@Username varchar(50) , @Password varchar(50)
	as
	begin 
		Insert Into Veterinarys
		Values(@Title,@FirstName,@LastName,@Position,@Address,@Tel,@VetExp,@Username,@Password)
	end
go
---------------------------------------------------------
create or Alter Procedure UpdateVeterinary
	@VeterrinaryID int, @Title varchar (20),@FirstName varchar(50) , @LastName varchar(50), @Position varchar(50), @Address varchar (100),
	@Tel varchar(20),@VetExp varchar(150),
	@Username varchar(50) , @Password varchar(50)
	as
	begin 
		Update Veterinarys set Title = @Title,FirstName = @FirstName , LastName = @LastName , Position = @Position , Address = @Address , Tel = @Tel , VetExp = @VetExp,
		UserName = @Username , Password = @Password
		where VeterrinaryID = @VeterrinaryID
	end
go
----------------------------------------------------------
create or Alter Procedure DeleteVeterinary
	@VeterrinaryID int
	as
	begin
		Delete from Veterinarys
		where VeterrinaryID = @VeterrinaryID
	end
go

