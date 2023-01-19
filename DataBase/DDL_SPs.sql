-- ALTA
CREATE PROC SP_altaArticulo @sku NUMERIC(6,0), @articulo VARCHAR(15), @marca VARCHAR(15), @modelo VARCHAR(20), @departamento NUMERIC(1,0), 
	@clase NUMERIC(2,0), @familia NUMERIC(3,0), @stock NUMERIC(9,0), @cantidad NUMERIC(9,0)
AS
INSERT INTO articulos(sku, articulo, marca, modelo, departamento, clase, familia, stock, cantidad)
VALUES(@sku, @articulo, @marca, @modelo, @departamento, @clase, @familia, @stock, @cantidad)
GO

-- BAJA
CREATE PROC SP_bajaArticulo @sku NUMERIC(6, 0)
AS
DELETE FROM articulos 
WHERE sku = @sku
GO

-- CAMBIO
CREATE PROC SP_cambioArticulo @sku NUMERIC(6,0), @articulo VARCHAR(15), @marca VARCHAR(15), @modelo VARCHAR(20), @departamento NUMERIC(1,0), 
	@clase NUMERIC(2,0), @familia NUMERIC(3,0), @stock NUMERIC(9,0), @cantidad NUMERIC(9,0), @descontinuado BIT
AS
DECLARE @fecha_baja DATE
IF @descontinuado = 0
	SET @fecha_baja = '1900-01-01'
ELSE
	SET @fecha_baja = GETDATE()

UPDATE articulos 
SET articulo = @articulo, marca = @marca, modelo = @modelo, departamento = @departamento, clase = @clase, familia = @familia, 
    stock = @stock, cantidad = @cantidad, descontinuado = @descontinuado, fecha_baja = @fecha_baja
WHERE sku = @sku
GO

-- CONSULTA
CREATE PROC SP_consultarArticulo @sku NUMERIC(6, 0)
AS
SELECT * FROM articulos WHERE sku = @sku
GO

-- Consultar todos
CREATE PROC SP_consultarTodosArticulos
AS
SELECT * FROM articulos
GO

-- SELECT ClasesEnDepartamento
CREATE PROC SP_ClasesEnDepartamento @numero_departamento NUMERIC(1, 0)
AS
SELECT * FROM clases
WHERE numero_departamento = @numero_departamento;
GO

-- SELECT FamiliasEnClase
CREATE PROC SP_FamiliasEnClase @numero_clase NUMERIC(2, 0), @numero_departamento NUMERIC(1, 0)
AS
SET @numero_departamento = CONVERT(CHAR(1), @numero_departamento)
SET @numero_clase = CONVERT(VARCHAR(2), @numero_clase)

DECLARE @clase_departamento NUMERIC(3, 0)
SET @clase_departamento = CONVERT(NUMERIC(3,0), @numero_clase + @numero_departamento)
SELECT * FROM familias
WHERE clase_departamento = @clase_departamento
GO

EXEC SP_ClasesEnDepartamento 2
EXEC SP_FamiliasEnClase 2, 2

-- CONSULTA DEPARTAMENTOS
CREATE PROC SP_consultarTodosLosDepartamentos
AS
SELECT * FROM departamentos
GO