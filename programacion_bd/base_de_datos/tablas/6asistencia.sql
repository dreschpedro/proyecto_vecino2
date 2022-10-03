CREATE TABLE asistencia (
id_asistencia INT NOT NULL AUTO_INCREMENT,
fecha DATE,
hora_entrada TIME,
hora_salida TIME,
id_personal INT NOT NULL,
id_ecopunto INT NOT NULL,
PRIMARY KEY (id_asistencia),
UNIQUE uk_asistencia (fecha, id_personal, id_ecopunto),
FOREIGN KEY fk_personal (id_personal) REFERENCES personal (id_personal),
FOREIGN KEY fk_eco (id_ecopunto) REFERENCES ecopunto (id_ecopunto)

)