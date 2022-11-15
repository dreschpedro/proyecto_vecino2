-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.0.13-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para vecino_sustentable
CREATE DATABASE IF NOT EXISTS `vecino_sustentable` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `vecino_sustentable`;

-- Volcando estructura para tabla vecino_sustentable.asistencia
CREATE TABLE IF NOT EXISTS `asistencia` (
  `id_asistencia` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `hora_entrada` time DEFAULT NULL,
  `hora_salida` time DEFAULT NULL,
  `id_personal` int(11) NOT NULL,
  `id_ecopunto` int(11) NOT NULL,
  PRIMARY KEY (`id_asistencia`),
  UNIQUE KEY `uk_asistencia` (`fecha`,`id_personal`,`id_ecopunto`),
  KEY `fk_personal` (`id_personal`),
  KEY `fk_eco` (`id_ecopunto`),
  CONSTRAINT `fk_eco` FOREIGN KEY (`id_ecopunto`) REFERENCES `ecopunto` (`id_ecopunto`),
  CONSTRAINT `fk_personal` FOREIGN KEY (`id_personal`) REFERENCES `personal` (`id_personal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.asistencia: ~0 rows (aproximadamente)
DELETE FROM `asistencia`;

-- Volcando estructura para tabla vecino_sustentable.cartonero
CREATE TABLE IF NOT EXISTS `cartonero` (
  `id_cartonero` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(20) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `tipo_transporte` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_cartonero`),
  UNIQUE KEY `uk_ape_nom` (`apellido`,`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.cartonero: ~0 rows (aproximadamente)
DELETE FROM `cartonero`;

-- Volcando estructura para tabla vecino_sustentable.ecopunto
CREATE TABLE IF NOT EXISTS `ecopunto` (
  `id_ecopunto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `ubicacion` varchar(100) DEFAULT NULL,
  `horario` time DEFAULT NULL,
  `dia` date DEFAULT NULL,
  `id_personal` int(11) NOT NULL,
  PRIMARY KEY (`id_ecopunto`),
  UNIQUE KEY `uk_nombre` (`nombre`),
  KEY `fk_responsable` (`id_personal`),
  CONSTRAINT `fk_responsable` FOREIGN KEY (`id_personal`) REFERENCES `personal` (`id_personal`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.ecopunto: ~21 rows (aproximadamente)
DELETE FROM `ecopunto`;
INSERT INTO `ecopunto` (`id_ecopunto`, `nombre`, `ubicacion`, `horario`, `dia`, `id_personal`) VALUES
	(1, 'Chacra 32-33 Feria Franca', NULL, NULL, NULL, 0),
	(2, 'Cruz Roja', NULL, NULL, NULL, 0),
	(3, 'B° Alta Gracia', NULL, NULL, NULL, 0),
	(4, 'Club de los Abuelos', NULL, NULL, NULL, 0),
	(5, 'Cancha Guarani', NULL, NULL, NULL, 0),
	(6, 'Mercado Concentrador ', NULL, NULL, NULL, 0),
	(7, 'Murga de La Estacion', NULL, NULL, NULL, 0),
	(8, 'AgroRiegos-Optimus', NULL, NULL, NULL, 0),
	(9, 'Villa Cabello', NULL, NULL, NULL, 0),
	(10, 'Manantiales, Hijos del Rey', NULL, NULL, NULL, 0),
	(11, 'Chacra 83 Kiosco de Ada', NULL, NULL, NULL, 0),
	(12, 'Chacra 193 B° Laurel', NULL, NULL, NULL, 0),
	(13, 'Chacra 92 Centro Jubilados', NULL, NULL, NULL, 0),
	(14, 'Chacra 189 Comisión Vecinal', NULL, NULL, NULL, 0),
	(15, 'B° A-4', NULL, NULL, NULL, 0),
	(16, 'Centro de Educación Ambiental', NULL, NULL, NULL, 0),
	(17, 'B° San Jorge', NULL, NULL, NULL, 0),
	(18, 'B° San Pedro', NULL, NULL, NULL, 0),
	(19, 'B° Mini City', NULL, NULL, NULL, 0),
	(20, 'B° Sur Argentino ', NULL, NULL, NULL, 0),
	(21, 'B° El Porvenir I', NULL, NULL, NULL, 0);

-- Volcando estructura para tabla vecino_sustentable.ecopunto_cartonero
CREATE TABLE IF NOT EXISTS `ecopunto_cartonero` (
  `id_eco_carton` int(11) NOT NULL AUTO_INCREMENT,
  `id_cartonero` int(11) NOT NULL,
  `id_ecopunto` int(11) NOT NULL,
  PRIMARY KEY (`id_eco_carton`),
  UNIQUE KEY `uk_carton_eco` (`id_cartonero`,`id_ecopunto`),
  KEY `fk_ecop` (`id_ecopunto`),
  CONSTRAINT `fk_carton` FOREIGN KEY (`id_cartonero`) REFERENCES `cartonero` (`id_cartonero`),
  CONSTRAINT `fk_ecop` FOREIGN KEY (`id_ecopunto`) REFERENCES `ecopunto` (`id_ecopunto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.ecopunto_cartonero: ~0 rows (aproximadamente)
DELETE FROM `ecopunto_cartonero`;

-- Volcando estructura para tabla vecino_sustentable.personal
CREATE TABLE IF NOT EXISTS `personal` (
  `id_personal` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(20) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `usuario` varchar(20) NOT NULL,
  `pass` varchar(15) NOT NULL,
  `rol` varchar(15) NOT NULL,
  PRIMARY KEY (`id_personal`),
  UNIQUE KEY `uk_ape_nom` (`apellido`,`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.personal: ~15 rows (aproximadamente)
DELETE FROM `personal`;
INSERT INTO `personal` (`id_personal`, `apellido`, `nombre`, `telefono`, `usuario`, `pass`, `rol`) VALUES
	(1, 'Maradona', 'Diego', '1565165', 'dieguito', 'diego1', 'Voluntario'),
	(2, 'Messi', 'Lionel', '65165165', 'leoM', 'messirve', 'Responsable'),
	(3, 'De Arco', 'Juana', '36513651', 'arcor', 'juanita', 'Voluntario'),
	(4, 'Miller', 'Adolf', '3651651', 'panzer', 'jabon', 'Voluntario'),
	(5, 'Fernandez', 'Martina', '365165', 'martina', 'polenta', 'Responsable'),
	(6, 'Johnson', 'Carl', '3141516', 'grove', 'street', 'Voluntario'),
	(7, 'Stark', 'Tony', '55555555', 'iron', 'tuAbuela', 'Voluntario'),
	(8, 'Dresch', 'Pedro', '3216351', 'pedrito', 'pedro', 'Responsable'),
	(17, 'DON', 'RAMON', '1651465', 'admin', 'admin', 'Administrador'),
	(18, 'dfv', 'dvfv', '61615', 'qwerty', '123456', 'Voluntario'),
	(22, 'dfghfdghdfgh', 'fdghdfghfdgh', '3453245345', 'dfgdhgfd', 'hgfdfghfdgh', 'Administrador'),
	(23, 'dgfsdfgsgdfsgsfdsad', 'dfgsfdgdfgsf', '2344234234', 'asdfsafasdfsxcv', 'cbxedfgsdgfsdfa', 'Administrador'),
	(24, 'gfdsaergfg', 'gfewer', '885547', 'sdfgfdsdfg', 'fgdsdfgfds', 'Responsable'),
	(25, 'saeafgff', 'sdfasf', '584748', 'sdfgfdsgf', 'fgdsdfgfsd', 'Administrador'),
	(26, 'dfsgsdfg', 'sdfgdfg', '889965', 'sdfgfds', 'gfdsdfg', 'Voluntario');

-- Volcando estructura para tabla vecino_sustentable.registros_hoy
CREATE TABLE IF NOT EXISTS `registros_hoy` (
  `id_eco_resid` int(11) NOT NULL AUTO_INCREMENT,
  `id_residuo` int(11) NOT NULL,
  `id_ecopunto` int(11) NOT NULL,
  `cantidad_residuo` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_eco_resid`),
  UNIQUE KEY `uk_res_eco_fecha` (`id_residuo`,`id_ecopunto`,`fecha`),
  KEY `fk_ecopun` (`id_ecopunto`),
  CONSTRAINT `fk_ecopun` FOREIGN KEY (`id_ecopunto`) REFERENCES `ecopunto` (`id_ecopunto`),
  CONSTRAINT `fk_res` FOREIGN KEY (`id_residuo`) REFERENCES `residuo` (`id_residuo`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.registros_hoy: ~18 rows (aproximadamente)
DELETE FROM `registros_hoy`;
INSERT INTO `registros_hoy` (`id_eco_resid`, `id_residuo`, `id_ecopunto`, `cantidad_residuo`, `fecha`) VALUES
	(33, 2, 8, 3, NULL),
	(38, 15, 1, 2, NULL),
	(64, 8, 1, 2, NULL),
	(71, 6, 1, 2, NULL),
	(74, 7, 3, 3, NULL),
	(85, 4, 4, 4, NULL),
	(89, 5, 1, 2, NULL),
	(90, 17, 1, 2, NULL),
	(91, 4, 2, 4, NULL),
	(92, 4, 2, 4, NULL),
	(93, 4, 2, 4, NULL),
	(94, 4, 1, 4, NULL),
	(95, 4, 1, 4, NULL),
	(96, 7, 2, 9, NULL),
	(97, 17, 2, 5, NULL),
	(98, 19, 2, 4, NULL),
	(99, 19, 2, 4, NULL),
	(100, 19, 2, 2, NULL);

-- Volcando estructura para tabla vecino_sustentable.residuo
CREATE TABLE IF NOT EXISTS `residuo` (
  `id_residuo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_residuo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_residuo`),
  UNIQUE KEY `uk_nom_res` (`nombre_residuo`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.residuo: ~24 rows (aproximadamente)
DELETE FROM `residuo`;
INSERT INTO `residuo` (`id_residuo`, `nombre_residuo`) VALUES
	(18, 'Aceite Vegetal'),
	(5, 'Aluminio'),
	(13, 'Anteojos - Estuches'),
	(19, 'Bolsa de Alimento'),
	(9, 'Botella de Amor'),
	(23, 'Botella de Vidrio'),
	(4, 'Botella Plastica'),
	(7, 'Botella salsa Tomate'),
	(11, 'Botellas Aplastadas'),
	(3, 'Cartón'),
	(24, 'Corcho'),
	(20, 'Electrodomestico'),
	(14, 'Foco LED'),
	(6, 'Frasco de Vidrio'),
	(10, 'Lata Hojalata'),
	(16, 'Llave de bronce'),
	(12, 'Maple de Huevo'),
	(2, 'Papel'),
	(21, 'Pila'),
	(15, 'Radiografía'),
	(8, 'Tapitas Plasticas'),
	(17, 'Tela'),
	(22, 'Telgopor'),
	(1, 'TetraPack');

-- Volcando estructura para tabla vecino_sustentable.residuo_cartonero
CREATE TABLE IF NOT EXISTS `residuo_cartonero` (
  `id_res_carton` int(11) NOT NULL AUTO_INCREMENT,
  `id_cartonero` int(11) NOT NULL,
  `id_residuo` int(11) NOT NULL,
  PRIMARY KEY (`id_res_carton`),
  UNIQUE KEY `ukres_cart` (`id_cartonero`,`id_residuo`),
  KEY `fk_residuoo` (`id_residuo`),
  CONSTRAINT `fk_cartoonero` FOREIGN KEY (`id_cartonero`) REFERENCES `cartonero` (`id_cartonero`),
  CONSTRAINT `fk_residuoo` FOREIGN KEY (`id_residuo`) REFERENCES `residuo` (`id_residuo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.residuo_cartonero: ~0 rows (aproximadamente)
DELETE FROM `residuo_cartonero`;

-- Volcando estructura para tabla vecino_sustentable.salida_residuo
CREATE TABLE IF NOT EXISTS `salida_residuo` (
  `id_res_reti` int(11) NOT NULL AUTO_INCREMENT,
  `id_cartonero` int(11) NOT NULL,
  `id_residuo` int(11) NOT NULL,
  `id_ecopunto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_res_reti`),
  UNIQUE KEY `uk_resEcoCartFec` (`id_cartonero`,`id_residuo`,`id_ecopunto`,`fecha`),
  KEY `fkResid` (`id_residuo`),
  KEY `fk_ecopuntrr` (`id_ecopunto`),
  CONSTRAINT `fkCartn` FOREIGN KEY (`id_cartonero`) REFERENCES `cartonero` (`id_cartonero`),
  CONSTRAINT `fkResid` FOREIGN KEY (`id_residuo`) REFERENCES `residuo` (`id_residuo`),
  CONSTRAINT `fk_ecopuntrr` FOREIGN KEY (`id_ecopunto`) REFERENCES `ecopunto` (`id_ecopunto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla vecino_sustentable.salida_residuo: ~0 rows (aproximadamente)
DELETE FROM `salida_residuo`;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
