CREATE TABLE ecopunto_cartonero (
id_eco_carton INT NOT NULL AUTO_INCREMENT,
id_cartonero INT NOT NULL,
id_ecopunto INT NOT NULL,
PRIMARY KEY (id_eco_carton),
UNIQUE uk_carton_eco (id_cartonero, id_ecopunto),
FOREIGN KEY fk_carton (id_cartonero) REFERENCES cartonero (id_cartonero),
FOREIGN KEY fk_ecop (id_ecopunto) REFERENCES ecopunto (id_ecopunto)
)