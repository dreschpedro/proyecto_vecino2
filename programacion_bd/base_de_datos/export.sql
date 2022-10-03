-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.0.13-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for vecino_sustentable
DROP DATABASE IF EXISTS `vecino_sustentable`;
CREATE DATABASE IF NOT EXISTS `vecino_sustentable` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `vecino_sustentable`;

-- Dumping structure for table vecino_sustentable.asistencia
DROP TABLE IF EXISTS `asistencia`;
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
  CONSTRAINT `fk_personal` FOREIGN KEY (`id_personal`) REFERENCES `personal` (`id_personal`),
  CONSTRAINT `fk_eco` FOREIGN KEY (`id_ecopunto`) REFERENCES `ecopunto` (`id_ecopunto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table vecino_sustentable.asistencia: ~0 rows (approximately)

-- Dumping structure for table vecino_sustentable.cartonero
DROP TABLE IF EXISTS `cartonero`;
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

-- Dumping data for table vecino_sustentable.cartonero: ~0 rows (approximately)

-- Dumping structure for table vecino_sustentable.ecopunto
DROP TABLE IF EXISTS `ecopunto`;
CREATE TABLE IF NOT EXISTS `ecopunto` (
  `id_ecopunto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `ubicacion` varchar(100) DEFAULT NULL,
  `horario` time DEFAULT NULL,
  `dia` date DEFAULT NULL,
  PRIMARY KEY (`id_ecopunto`),
  UNIQUE KEY `uk_nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

-- Dumping data for table vecino_sustentable.ecopunto: ~21 rows (approximately)
INSERT INTO `ecopunto` (`id_ecopunto`, `nombre`, `ubicacion`, `horario`, `dia`) VALUES
	(1, 'Chacra 32-33 Feria Franca', NULL, NULL, NULL),
	(2, 'Cruz Roja', NULL, NULL, NULL),
	(3, 'B° Alta Gracia', NULL, NULL, NULL),
	(4, 'Club de los Abuelos', NULL, NULL, NULL),
	(5, 'Cancha Guarani', NULL, NULL, NULL),
	(6, 'Mercado Concentrador ', NULL, NULL, NULL),
	(7, 'Murga de La Estacion', NULL, NULL, NULL),
	(8, 'AgroRiegos-Optimus', NULL, NULL, NULL),
	(9, 'Villa Cabello', NULL, NULL, NULL),
	(10, 'Manantiales, Hijos del Rey', NULL, NULL, NULL),
	(11, 'Chacra 83 Kiosco de Ada', NULL, NULL, NULL),
	(12, 'Chacra 193 B° Laurel', NULL, NULL, NULL),
	(13, 'Chacra 92 Centro Jubilados', NULL, NULL, NULL),
	(14, 'Chacra 189 Comisión Vecinal', NULL, NULL, NULL),
	(15, 'B° A-4', NULL, NULL, NULL),
	(16, 'Centro de Educación Ambiental', NULL, NULL, NULL),
	(17, 'B° San Jorge', NULL, NULL, NULL),
	(18, 'B° San Pedro', NULL, NULL, NULL),
	(19, 'B° Mini City', NULL, NULL, NULL),
	(20, 'B° Sur Argentino ', NULL, NULL, NULL),
	(21, 'B° El Porvenir I', NULL, NULL, NULL);

-- Dumping structure for table vecino_sustentable.ecopunto_cartonero
DROP TABLE IF EXISTS `ecopunto_cartonero`;
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

-- Dumping data for table vecino_sustentable.ecopunto_cartonero: ~0 rows (approximately)

-- Dumping structure for table vecino_sustentable.personal
DROP TABLE IF EXISTS `personal`;
CREATE TABLE IF NOT EXISTS `personal` (
  `id_personal` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(20) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_personal`),
  UNIQUE KEY `uk_ape_nom` (`apellido`,`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table vecino_sustentable.personal: ~0 rows (approximately)

-- Dumping structure for table vecino_sustentable.registros_hoy
DROP TABLE IF EXISTS `registros_hoy`;
CREATE TABLE IF NOT EXISTS `registros_hoy` (
  `id_eco_resid` int(11) NOT NULL AUTO_INCREMENT,
  `id_residuo` int(11) NOT NULL,
  `id_ecopunto` int(11) NOT NULL,
  `cantidad_residuo` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_eco_resid`),
  UNIQUE KEY `uk_res_eco_fecha` (`id_residuo`,`id_ecopunto`,`fecha`),
  KEY `fk_ecopun` (`id_ecopunto`),
  CONSTRAINT `fk_res` FOREIGN KEY (`id_residuo`) REFERENCES `residuo` (`id_residuo`),
  CONSTRAINT `fk_ecopun` FOREIGN KEY (`id_ecopunto`) REFERENCES `ecopunto` (`id_ecopunto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table vecino_sustentable.registros_hoy: ~0 rows (approximately)
INSERT INTO `registros_hoy` (`id_eco_resid`, `id_residuo`, `id_ecopunto`, `cantidad_residuo`, `fecha`) VALUES
	(1, 3, 5, 4, NULL);

-- Dumping structure for table vecino_sustentable.residuo
DROP TABLE IF EXISTS `residuo`;
CREATE TABLE IF NOT EXISTS `residuo` (
  `id_residuo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_residuo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_residuo`),
  UNIQUE KEY `uk_nom_res` (`nombre_residuo`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

-- Dumping data for table vecino_sustentable.residuo: ~24 rows (approximately)
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

-- Dumping structure for table vecino_sustentable.residuo_cartonero
DROP TABLE IF EXISTS `residuo_cartonero`;
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

-- Dumping data for table vecino_sustentable.residuo_cartonero: ~0 rows (approximately)

-- Dumping structure for table vecino_sustentable.roles
DROP TABLE IF EXISTS `roles`;
CREATE TABLE IF NOT EXISTS `roles` (
  `id_rol` int(11) NOT NULL AUTO_INCREMENT,
  `id_personal` int(11) NOT NULL,
  `id_ecopunto` int(11) NOT NULL,
  `rol` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_rol`),
  UNIQUE KEY `uk_rol_per_eco` (`rol`,`id_personal`,`id_ecopunto`),
  KEY `fk_per` (`id_personal`),
  CONSTRAINT `fk_per` FOREIGN KEY (`id_personal`) REFERENCES `personal` (`id_personal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table vecino_sustentable.roles: ~0 rows (approximately)

-- Dumping structure for table vecino_sustentable.salida_residuo
DROP TABLE IF EXISTS `salida_residuo`;
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

-- Dumping data for table vecino_sustentable.salida_residuo: ~0 rows (approximately)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
