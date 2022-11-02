--- Table Drug ---
create or Alter Procedure InsertDrug
	@DrugName varchar(50) , @Quantity int, @UnitPrice money , @Size varchar(10) , @DealerID int
	as
	begin 
		Insert Into Drug
		Values(@DrugName, @Quantity, @UnitPrice , @Size , @DealerID )
	end
go
---------------------------------------------------------
create or Alter Procedure UpdateDrug
	@DrugID int ,@DrugName varchar(50) , @Quantity int, @UnitPrice money , @Size varchar(10) , @DealerID int
	as
	begin 
		Update Drug set DrugName = @DrugName ,Quantity = @Quantity ,UnitPrice = @UnitPrice , Size = @Size , DealerID =@DealerID
		where DrugID = @DrugID
	end
go
----------------------------------------------------------
create or Alter Procedure DeleteDrug
	@DrugID int
	as
	begin
		Delete from Drug
		where DrugID = @DrugID
	end
go

