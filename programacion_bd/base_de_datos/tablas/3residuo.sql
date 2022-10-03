CREATE TABLE residuo (
id_residuo INT NOT NULL AUTO_INCREMENT,
nombre_residuo VARCHAR(100),
PRIMARY KEY (id_residuo),
UNIQUE uk_nom_res (nombre_residuo)
)