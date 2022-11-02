--- Table Treatment ---
create or Alter Procedure InsertTreatment
	@DateCure datetime , @Symptom varchar(200) , @Imprement varchar (200), @TreatmentPrice Money , @TotalPrice Money , @VeterrinaryID int , @PetID int
	as
	begin 
		Insert Into Treatment
		Values(@DateCure , @Symptom , @Imprement, @TreatmentPrice , @TotalPrice , @VeterrinaryID , @PetID )
	end
go
---------------------------------------------------------
create or Alter Procedure UpdateTreatment
	@TreatmentID int, @DateCure datetime , @Symptom varchar(200) , @Imprement varchar (200), @TreatmentPrice Money , @TotalPrice Money , @VeterrinaryID int , @PetID int
	as
	begin 
		Update Treatment set DateCure = @DateCure ,Symptom = @Symptom ,Imprement = @Imprement , TreatmentPrice = @TreatmentPrice , TotalPrice = @TotalPrice , VeterrinaryID = @VeterrinaryID , PetID = @PetID
		where TreatmentID = @TreatmentID
	end
go
----------------------------------------------------------
create or Alter Procedure DeleteTreatment
	@TreatmentID int
	as
	begin
		Delete from Treatment
		where TreatmentID = @TreatmentID
	end
go

---------------------Dispense ทำเเค่ Insert อย่างเดียว------------------------------------
create or Alter Procedure InsertDispenseDrug
	@TreatmentID int , @QuantityDrug int , @Unitprice money
	,@DrugID int 
	as
	begin
		Insert into DispenseDrugs
		Values (@TreatmentID, @QuantityDrug, @UnitPrice, @DrugID)
	end
go


