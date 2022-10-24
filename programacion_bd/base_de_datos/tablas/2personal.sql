CREATE TABLE personal (
id_personal INT NOT NULL AUTO_INCREMENT,
apellido VARCHAR(20) NOT NULL,
nombre VARCHAR(30) NOT NULL,
telefono VARCHAR (15),
usuario VARCHAR(20) NOT NULL,
pass VARCHAR(15) NOT NULL,
rol VARCHAR(15) NOT NULL,
PRIMARY KEY (id_personal),
UNIQUE uk_ape_nom (apellido, nombre)
)