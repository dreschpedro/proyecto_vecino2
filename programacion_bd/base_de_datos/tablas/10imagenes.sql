CREATE TABLE imagenes(
id_img INT NOT NULL AUTO_INCREMENT,
id_personal INT,
foto LONGBLOB,
tam_archivo DECIMAL,
nom_archivo VARCHAR(40),
PRIMARY KEY (id_img),
FOREIGN KEY (id_personal) REFERENCES personal (id_personal)
)