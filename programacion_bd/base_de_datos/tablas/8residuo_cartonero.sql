CREATE TABLE residuo_cartonero (
id_res_carton INT NOT NULL AUTO_INCREMENT,
id_cartonero INT NOT NULL,
id_residuo INT NOT NULL,
PRIMARY KEY (id_res_carton),
UNIQUE ukres_cart (id_cartonero, id_residuo),
FOREIGN KEY fk_cartoonero (id_cartonero) REFERENCES cartonero (id_cartonero),
FOREIGN KEY fk_residuoo (id_residuo) REFERENCES residuo (id_residuo)
)