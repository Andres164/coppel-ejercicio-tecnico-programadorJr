-- DEPARTAMENTOS
INSERT INTO departamentos(numero_departamento, departamento) VALUES (1, 'DOMESTICOS')
INSERT INTO departamentos(numero_departamento, departamento) VALUES (2, 'ELECTRONICA')
INSERT INTO departamentos(numero_departamento, departamento) VALUES (3, 'MUEBLE SUELTO')
INSERT INTO departamentos(numero_departamento, departamento) VALUES (4, 'SALAS, RECAMARAS, COMEDORES')


/* CLASES */
-- DOMESTICOS
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (1, 'COMESTIBLES', 1)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (2, 'LICUADORAS', 1)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (3, 'BATIDORAS', 1)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (4, 'CAFETERIAS', 1)

-- ELECTRONICA
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (1, 'APLIFICADORES CAR AUDIO', 2)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (2, 'AUTO STEREOS', 2)

-- MUEBLE SUELTO
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (1, 'COLCHON', 3)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (2, 'JUEGO BOX', 3)

-- SALAS, RECAMARAS, COMEDORES
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (1, 'SALAS', 4)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (2, 'COMPLEMENTOS PARA SALA', 4)
INSERT INTO clases(numero_clase, clase, numero_departamento) VALUES (3, 'SOFAS CAMA', 4)


/* FAMILIAS */

--COMESTIBLES
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (00, 'SIN NOMBRE', 11)

-- LICUADORAS
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'LICUADORAS', 21)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'EXPLUSIVO COPPEL.COM', 21)

-- BATIDORAS
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'BATIDORA MANUAL', 31)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'PROCESADOR', 31)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'PICADORA', 31)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (04, 'BATIDORA PEDESTAL', 31)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (05, 'BATIDORA FUENTE', 31)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (06, 'MULTIPLACTICOS', 31)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (07, 'EXLUSIVO COPPEL.COM', 31)
					
-- CAFETERAS		
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'CAFETERAS', 41)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'PERCOLADORAS', 41)

-- AMPLIFICAROES CAR AUDIO
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'AMPLIFICADOR/RECEPTOR', 12)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'KIT DE INSTALACION', 12)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'APLIFICADORES COPPEL', 12)

-- AUTO STEREOS
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'AUTOESTEREO CD', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'ACCESORIOS CAR AUDIO', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'AMPLIFICADOR', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (04, 'ALARMA AUTO/CASA', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (05, 'SIN MECANISMO', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (06, 'CON CD', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (07, 'MULTIMEDIA', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (08, 'PAQUETE SIN MECANISMO', 22)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (09, 'PAQUETE CON CD', 22)

-- COLCHON
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'PILLOW TOP KS', 13)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'PILLOW TOP DOBLE KS', 13)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'HULE ESPUMA KS', 13)

-- JUEGO BOX
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'ESTANDAR INDIVIDUAL', 23)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'PILLOW TOP INDIVIDUAL', 23)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'PILLOW TOP DOBLE', 23)

-- SALAS
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'ESQUINERAS SUPEROORES', 14)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'TIPO L SECCIONAL', 14)

-- COMPLEMENTOS PARA SALA
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'SILLON OCASIONAL', 24)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'PUFF', 24)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'BAUL', 24)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (04, 'TABURETE', 24)

-- SOFAS CAMA
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (01, 'SOFACAMA TAPIZADO', 34)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (02, 'SOFACAMA CLASICO', 34)
INSERT INTO familias(numero_familia, familia, clase_departamento) VALUES (03, 'ESTUDIO', 34)

