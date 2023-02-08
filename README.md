-- Car Manufacturers
;WITH RECURSIVE t(n) AS ( VALUES (1) UNION ALL SELECT n+1 FROM t WHERE n < 1000 ) INSERT INTO public."CarManufacturers" ("C_Name") SELECT 'Производитель машин ' || n FROM t;

-- Cars
;WITH RECURSIVE t(n) AS ( VALUES (1) UNION ALL SELECT n+1 FROM t WHERE n < 1000 ) INSERT INTO public."Cars" ("CarManufacturerId", "YearOfManufacture", "C_Model") SELECT random() * 999 + 1, timestamp '2000-01-01 00:00:00' + random() * (timestamp '2023-02-07 00:00:00' - timestamp '2000-01-01 00:00:00'), 'Model ' || n FROM t;

-- Suppliers
;WITH RECURSIVE t(n) AS ( VALUES (1) UNION ALL SELECT n+1 FROM t WHERE n < 1000 ) INSERT INTO public."Suppliers" ("C_Name") SELECT 'Suppliers ' || n FROM t;

-- PartTypes
;WITH RECURSIVE t(n) AS ( VALUES (1) UNION ALL SELECT n+1 FROM t WHERE n < 1000 ) INSERT INTO public."PartTypes" ("C_Description") SELECT gen_random_uuid() FROM t;

-- Part Manufacturers
;WITH RECURSIVE t(n) AS ( VALUES (1) UNION ALL SELECT n+1 FROM t WHERE n < 1000 ) INSERT INTO public."PartManufacturers" ("C_Name") SELECT 'Производитель запчастей ' || n FROM t;

-- Part Levels
;WITH RECURSIVE t(n) AS ( VALUES (1) UNION ALL SELECT n+1 FROM t WHERE n < 1000 ) INSERT INTO public."PartLevels" ("C_Description") SELECT gen_random_uuid() FROM t;

-- Parts 
;WITH RECURSIVE t(n) AS
(
	VALUES (1)
	UNION ALL
	SELECT n+1 FROM t WHERE n < 1000
)
	INSERT INTO
		public."Parts"
		("CarId",
		 "ParentPartId",
		 "PartLevelId",
		 "PartManufacturerId",
		 "PartTypeId",
		 "SupplierId",
		 "C_Name",
		 "Weight",
		 "C_Condition",
		 "MileageDonorVehicle",
		 "C_Details")
	SELECT 
		random() * 999 + 1,	
		1,
		random() * 999 + 1,
		random() * 999 + 1,
		random() * 999 + 1,
		random() * 999 + 1,
		'Запчасть ' || floor(random() * 999 + 1),
		random() * 100 + 1,
		'Состояние ' || floor(random() * 10 + 1),
		random() * 500000 + 1,
		gen_random_uuid()
	FROM t;
	
