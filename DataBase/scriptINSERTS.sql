-- DEPARTAMENTOS
INSERT INTO departamentos(numero_departamento, departamento) VALUES (1, 'DOMESTICOS')
INSERT INTO departamentos(numero_departamento, departamento) VALUES (2, 'ELECTRONICA')
INSERT INTO departamentos(numero_departamento, departamento) VALUES (3, 'MUEBLE SUELTO')
INSERT INTO departamentos(numero_departamento, departamento) VALUES (4, 'SALAS, RECAMARAS, COMEDORES')

/* CLASES */
-- DOMESTICOS
INSERT INTO clases(numero_clase, clase) VALUES (1, 'COMESTIBLES')
INSERT INTO clases(numero_clase, clase) VALUES (2, 'LICUADORAS')
INSERT INTO clases(numero_clase, clase) VALUES (3, 'BATIDORAS')
INSERT INTO clases(numero_clase, clase) VALUES (4, 'CAFETERIAS')

-- ELECTRONICA
INSERT INTO clases(numero_clase, clase) VALUES (1, 'APLIFICADORES CAR AUDIO')
INSERT INTO clases(numero_clase, clase) VALUES (2, 'AUTO STEREOS')

-- MUEBLE SUELTO
INSERT INTO clases(numero_clase, clase) VALUES (1, 'COLCHON')
INSERT INTO clases(numero_clase, clase) VALUES (2, 'JUEGO BOX')

-- SALAS, RECAMARAS, COMEDORES
INSERT INTO clases(numero_clase, clase) VALUES (1, 'SALAS')
INSERT INTO clases(numero_clase, clase) VALUES (2, 'COMPLEMENTOS PARA SALA')
INSERT INTO clases(numero_clase, clase) VALUES (3, 'SOFAS CAMA')


/* FAMILIAS */

--COMESTIBLES
INSERT INTO familias(numero_familia, familia) VALUES (00, 'SIN NOMBRE')

-- LICUADORAS
INSERT INTO familias(numero_familia, familia) VALUES (01, 'LICUADORAS')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'EXPLUSIVO COPPEL.COM')

-- BATIDORAS
INSERT INTO familias(numero_familia, familia) VALUES (01, 'BATIDORA MANUAL')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'PROCESADOR')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'PICADORA')
INSERT INTO familias(numero_familia, familia) VALUES (04, 'BATIDORA PEDESTAL')
INSERT INTO familias(numero_familia, familia) VALUES (05, 'BATIDORA FUENTE')
INSERT INTO familias(numero_familia, familia) VALUES (06, 'MULTIPLACTICOS')
INSERT INTO familias(numero_familia, familia) VALUES (07, 'EXLUSIVO COPPEL.COM')
					
-- CAFETERAS		
INSERT INTO familias(numero_familia, familia) VALUES (01, 'CAFETERAS')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'PERCOLADORAS')

-- AMPLIFICAROES CAR AUDIO
INSERT INTO familias(numero_familia, familia) VALUES (01, 'AMPLIFICADOR/RECEPTOR')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'KIT DE INSTALACION')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'APLIFICADORES COPPEL')

-- AUTO STEREOS
INSERT INTO familias(numero_familia, familia) VALUES (01, 'AUTOESTEREO CD')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'ACCESORIOS CAR AUDIO')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'AMPLIFICADOR')
INSERT INTO familias(numero_familia, familia) VALUES (04, 'ALARMA AUTO/CASA')
INSERT INTO familias(numero_familia, familia) VALUES (05, 'SIN MECANISMO')
INSERT INTO familias(numero_familia, familia) VALUES (06, 'CON CD')
INSERT INTO familias(numero_familia, familia) VALUES (07, 'MULTIMEDIA')
INSERT INTO familias(numero_familia, familia) VALUES (08, 'PAQUETE SIN MECANISMO')
INSERT INTO familias(numero_familia, familia) VALUES (09, 'PAQUETE CON CD')

-- COLCHON
INSERT INTO familias(numero_familia, familia) VALUES (01, 'PILLOW TOP KS')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'PILLOW TOP DOBLE KS')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'HULE ESPUMA KS')

-- JUEGO BOX
INSERT INTO familias(numero_familia, familia) VALUES (01, 'ESTANDAR INDIVIDUAL')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'PILLOW TOP INDIVIDUAL')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'PILLOW TOP DOBLE')

-- SALAS
INSERT INTO familias(numero_familia, familia) VALUES (01, 'ESQUINERAS SUPEROORES')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'TIPO L SECCIONAL')

-- COMPLEMENTOS PARA SALA
INSERT INTO familias(numero_familia, familia) VALUES (01, 'SILLON OCASIONAL')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'PUFF')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'BAUL')
INSERT INTO familias(numero_familia, familia) VALUES (04, 'TABURETE')

-- SOFAS CAMA
INSERT INTO familias(numero_familia, familia) VALUES (01, 'SOFACAMA TAPIZADO')
INSERT INTO familias(numero_familia, familia) VALUES (02, 'SOFACAMA CLASICO')
INSERT INTO familias(numero_familia, familia) VALUES (03, 'ESTUDIO')