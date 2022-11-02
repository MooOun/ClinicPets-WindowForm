--- Table Pets ---
create or Alter Procedure InsertPets
	@PetName varchar(20) , @AnimalType varchar(20), @Description varchar(150) , @Color varchar(50),
	@Age char(3), @Species char(50), @CustomerID char(13)
	as
	begin 
		Insert Into Pets
		Values(@PetName ,@AnimalType , @Description ,@Color ,@Age ,@Species, @CustomerID)
	end
go
---------------------------------------------------------
create or Alter Procedure UpdatePets
	@PetID int,@PetName varchar(20) , @AnimalType varchar(20), @Description varchar(150) , @Color varchar(50),
	@Age char(3), @Species char(50), @CustomerID char(13)
	as
	begin 
		Update Pets set PetName = @PetName , AnimalType = @AnimalType ,Description = @Description , Color = @Color , 
		Age = @Age , Species = @Species ,CustomerID = @CustomerID
		where PetID = @PetID
	end
go
----------------------------------------------------------
create or Alter Procedure DeletePets
	@PetID int
	as
	begin
		Delete from Pets
		where PetID = @PetID 
	end
go

