CREATE PROC SP_selectClasesFamiliasPertenecientesADepartamento @numero_departamento NUMERIC(1, 0)
AS
SELECT dep.*, clases.numero_clase, clases.clase, familias.numero_familia, familias.familia  FROM departamentos AS dep
INNER JOIN clases ON clases.numero_departamento = dep.numero_departamento
INNER JOIN familias ON familias.clase_departamento = clases.clase_departamento
WHERE dep.numero_departamento = @numero_departamento
GO