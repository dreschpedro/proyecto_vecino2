CREATE TABLE salida_residuo (
id_salida INT NOT NULL AUTO_INCREMENT,
id_cartonero  INT NOT NULL,
id_residuo INT NOT NULL,
id_ecopunto INT NOT NULL,
cantidad INT NOT NULL,
fecha DATE,
PRIMARY KEY (id_salida),
UNIQUE uk_resEcoCartFec (id_cartonero, id_residuo, id_ecopunto, fecha),
FOREIGN KEY fkCartn (id_cartonero) REFERENCES cartonero (id_cartonero),
FOREIGN KEY fkResid (id_residuo) REFERENCES residuo (id_residuo),
FOREIGN KEY fk_ecopuntrr (id_ecopunto) REFERENCES ecopunto (id_ecopunto)
)