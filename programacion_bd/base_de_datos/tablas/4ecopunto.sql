CREATE TABLE ecopunto (
id_ecopunto INT NOT NULL AUTO_INCREMENT,
nombre VARCHAR (100) NOT NULL,
ubicacion VARCHAR (100),
horario TIME,
dia DATE,
id_personal VARCHAR(50) NOT NULL,
PRIMARY KEY (id_ecopunto),
UNIQUE uk_nombre (nombre)
)