CREATE TABLE registros_hoy (
id_eco_resid INT NOT NULL AUTO_INCREMENT,
id_residuo INT NOT NULL,
id_ecopunto INT NOT NULL,
cantidad_residuo INT NOT NULL,
fecha DATE,
PRIMARY KEY (id_eco_resid),
UNIQUE uk_res_eco_fecha (id_residuo, id_ecopunto, fecha),
FOREIGN KEY fk_res (id_residuo) REFERENCES residuo (id_residuo),
FOREIGN KEY fk_ecopun (id_ecopunto) REFERENCES ecopunto (id_ecopunto)
)