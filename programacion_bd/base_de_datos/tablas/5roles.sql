CREATE TABLE roles (
id_rol INT NOT NULL AUTO_INCREMENT,
id_personal INT NOT NULL,
id_ecopunto INT NOT NULL,
rol VARCHAR (15),
PRIMARY KEY (id_rol),
UNIQUE uk_rol_per_eco (rol, id_personal, id_ecopunto),
FOREIGN KEY fk_per (id_personal) REFERENCES personal (id_personal)
)