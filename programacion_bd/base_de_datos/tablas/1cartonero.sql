CREATE TABLE cartonero (
id_cartonero INT NOT NULL AUTO_INCREMENT,
apellido VARCHAR(20) NOT NULL,
nombre VARCHAR(30) NOT NULL,
telefono VARCHAR(15),
direccion VARCHAR(60),
tipo_transporte VARCHAR(20),
PRIMARY KEY (id_cartonero),
UNIQUE uk_ape_nom (apellido, nombre)
)