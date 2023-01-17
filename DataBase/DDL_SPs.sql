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

-- SELECT CLASE-FAMILIA DEL DEPARTAMENTO
CREATE PROC SP_selectClasesFamiliasPertenecientesADepartamento @numero_departamento NUMERIC(1, 0)
AS
SELECT dep.*, clases.numero_clase, clases.clase, familias.numero_familia, familias.familia  FROM departamentos AS dep
INNER JOIN clases ON clases.numero_departamento = dep.numero_departamento
INNER JOIN familias ON familias.clase_departamento = clases.clase_departamento
WHERE dep.numero_departamento = @numero_departamento
GO