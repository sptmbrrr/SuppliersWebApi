## Stored procedures
```ssh
create or replace procedure Fill_CarManufacturers(quant int)
language plpgsql
as $procedure$
begin
	WITH RECURSIVE t(n) AS 
	( 
		VALUES (1)
		UNION ALL
		SELECT n+1
		FROM t
		WHERE n < quant
	)
	INSERT INTO public."CarManufacturers" ("C_Name")
		SELECT 'Производитель машин ' || n FROM t;
end;
$procedure$;
```
```ssh
create or replace procedure Fill_Cars(quant int)
language plpgsql
as $procedure$
begin
	WITH RECURSIVE t(n) AS 
	( 
		VALUES (1)
		UNION ALL
		SELECT n+1
		FROM t
		WHERE n < quant
	)
	INSERT INTO public."Cars" ("CarManufacturerId", "YearOfManufacture", "C_Model") 
	SELECT random() * 999 + 1,
		   timestamp '2000-01-01 00:00:00' + random() * (timestamp '2023-02-07 00:00:00' - timestamp '2000-01-01 00:00:00'),
		   'Model ' || n
	FROM t;
end;
$procedure$;
```
```ssh
create or replace procedure Fill_Suppliers(quant int)
language plpgsql
as $procedure$
begin
	WITH RECURSIVE t(n) AS 
	( 
		VALUES (1)
		UNION ALL
		SELECT n+1
		FROM t
		WHERE n < quant
	)
	INSERT INTO public."Suppliers" ("C_Name")
	SELECT 'Suppliers ' || n
	FROM t;
end;
$procedure$;
```
```ssh
create or replace procedure Fill_PartTypes(quant int)
language plpgsql
as $procedure$
begin
	WITH RECURSIVE t(n) AS 
	( 
		VALUES (1)
		UNION ALL
		SELECT n+1
		FROM t
		WHERE n < quant
	)
	INSERT INTO public."PartTypes" ("C_Description") 
	SELECT 'Part' || gen_random_uuid() 
	FROM t;
end;
$procedure$;
```
```ssh
create or replace procedure Fill_PartManufacturers(quant int)
language plpgsql
as $procedure$
begin
	WITH RECURSIVE t(n) AS 
	( 
		VALUES (1)
		UNION ALL
		SELECT n+1
		FROM t
		WHERE n < quant
	)
	INSERT INTO public."PartManufacturers" ("C_Name")
	SELECT 'Производитель запчастей ' || n 
	FROM t;
end;
$procedure$;
```
```ssh
create or replace procedure Fill_PartLevels(quant int)
language plpgsql
as $procedure$
begin
	WITH RECURSIVE t(n) AS 
	( 
		VALUES (1)
		UNION ALL
		SELECT n+1
		FROM t
		WHERE n < quant
	)
	INSERT INTO public."PartLevels" ("C_Description")
	SELECT 'Уровень детали ' || n 
	FROM t;
end;
$procedure$;

	for i in 1..quant loop
		insert into public."Parts" (CarId,
                            ParentPartId,
                            PartLevelId,
                            PartManufacturerId,
                            PartTypeId,
                            SupplierId,
                            C_Name,
                            Weight,
                            C_Condition,
                            MileageDonorVehicle)
			VALUES 
			(
				i,
				null,
				random() * 999999 + 1,
				random() * 999999 + 1,
				random() * 999999 + 1,
				random() * 999999 + 1,
				'Деталь ' || i+1,
				floor(random() * 99 + 1),
				'Состояние ' || floor(random() * 9 + 1),
				floor(random() * 999999 + 1)
			);
		
	end loop;
  ```
