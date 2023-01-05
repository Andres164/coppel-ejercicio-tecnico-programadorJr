CREATE TABLE articulos (
	sku NUMERIC(6, 0), -- PRIMARY KEY
	articulo VARCHAR(15),
	marca VARCHAR(15),
	modelo VARCHAR(20),
	departamento NUMERIC(1, 0),
	clase NUMERIC(2, 0),
	familia NUMERIC(3, 0),
	fecha_de_alta DATE DEFAULT GETDATE(),
	stock NUMERIC(9, 0),
	cantidad NUMERIC(9, 0),
	descontinuado BIT DEFAULT 0,
	fecha_baja DATE DEFAULT '1900-01-01'
)

CREATE TABLE departamentos (
	numero_departamento NUMERIC(1, 0),
	departamento VARCHAR(80)
)

CREATE TABLE clases (
	numero_clase NUMERIC(2, 0),
	clase VARCHAR(80)
)

CREATE TABLE familias (
	numero_familia NUMERIC(3, 0),
	familia VARCHAR(80)
)
