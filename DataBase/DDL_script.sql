CREATE TABLE articulos (
	sku NUMERIC(6, 0) PRIMARY KEY,
	articulo VARCHAR(15) NOT NULL,
	marca VARCHAR(15) NOT NULL,
	modelo VARCHAR(20) NOT NULL,
	departamento NUMERIC(1, 0) NOT NULL,
	clase NUMERIC(2, 0) NOT NULL,
	familia NUMERIC(3, 0) NOT NULL,
	fecha_de_alta DATE DEFAULT GETDATE() NOT NULL,
	stock NUMERIC(9, 0) NOT NULL,
	cantidad NUMERIC(9, 0) NOT NULL,
	descontinuado BIT DEFAULT 0 NOT NULL,
	fecha_baja AS CASE WHEN descontinuado = 0 THEN '1900-01-01' END
)

CREATE TABLE departamentos (
	numero_departamento NUMERIC(1, 0) PRIMARY KEY,
	departamento VARCHAR(80),
)

CREATE TABLE clases (
	numero_clase NUMERIC(2, 0),
	clase VARCHAR(80),
	numero_departamento NUMERIC(1,0),
	clase_departamento AS convert(varchar(2), numero_clase) + convert(varchar(2), numero_departamento)
)

CREATE TABLE familias (
	numero_familia NUMERIC(3, 0),
	familia VARCHAR(80),
	clase_departamento NUMERIC(3, 0)
)