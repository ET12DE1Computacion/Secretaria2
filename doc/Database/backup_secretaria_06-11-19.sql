CREATE DATABASE  IF NOT EXISTS `proy_intoxica2` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */;
USE `proy_intoxica2`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: win2012-01    Database: proy_intoxica2
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alumno` (
  `legajo` int(10) unsigned NOT NULL,
  `idPersona` int(11) NOT NULL,
  `idCursoActual` tinyint(4) DEFAULT NULL,
  `libro` mediumint(9) DEFAULT NULL,
  `folio` mediumint(9) DEFAULT NULL,
  PRIMARY KEY (`legajo`),
  UNIQUE KEY `idPersona_UNIQUE` (`idPersona`),
  KEY `fk_Alumno_Curso1_idx` (`idCursoActual`),
  KEY `fk_Alumno_Persona1_idx` (`idPersona`),
  CONSTRAINT `fk_Alumno_Curso1` FOREIGN KEY (`idCursoActual`) REFERENCES `curso` (`idCurso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Alumno_Persona1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
INSERT INTO `alumno` VALUES (31568,2,1,789,321),(31897,5,3,897,312),(32191,4,3,231,564),(32232,1,3,123,456),(33645,3,2,654,987);
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aptomedico`
--

DROP TABLE IF EXISTS `aptomedico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aptomedico` (
  `idApto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `legajo` int(10) unsigned NOT NULL,
  `presentacion` date NOT NULL,
  `vencimiento` date NOT NULL,
  PRIMARY KEY (`idApto`,`legajo`),
  KEY `fk_Apto_Alumno1_idx` (`legajo`),
  CONSTRAINT `fk_Apto_Alumno1` FOREIGN KEY (`legajo`) REFERENCES `alumno` (`legajo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aptomedico`
--

LOCK TABLES `aptomedico` WRITE;
/*!40000 ALTER TABLE `aptomedico` DISABLE KEYS */;
INSERT INTO `aptomedico` VALUES (1,31568,'2019-03-12','2020-03-12'),(2,31897,'2019-05-17','2020-05-17'),(3,32191,'2019-04-03','2020-04-03'),(4,32232,'2019-03-27','2020-03-27'),(5,33645,'2019-06-14','2020-06-14');
/*!40000 ALTER TABLE `aptomedico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistenciacurso`
--

DROP TABLE IF EXISTS `asistenciacurso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistenciacurso` (
  `idCurso` tinyint(4) NOT NULL,
  `fecha` date NOT NULL,
  `idTipoFalta` tinyint(4) NOT NULL,
  PRIMARY KEY (`idCurso`,`fecha`,`idTipoFalta`),
  KEY `fk_AsistenciaCurso_TipoFalta1_idx` (`idTipoFalta`),
  CONSTRAINT `fk_AsistenciaCurso_Curso1` FOREIGN KEY (`idCurso`) REFERENCES `curso` (`idCurso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_AsistenciaCurso_TipoFalta1` FOREIGN KEY (`idTipoFalta`) REFERENCES `tipofalta` (`idTipoFalta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistenciacurso`
--

LOCK TABLES `asistenciacurso` WRITE;
/*!40000 ALTER TABLE `asistenciacurso` DISABLE KEYS */;
INSERT INTO `asistenciacurso` VALUES (1,'2019-08-26',1),(2,'2019-08-12',2),(3,'2019-06-14',3);
/*!40000 ALTER TABLE `asistenciacurso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cursada`
--

DROP TABLE IF EXISTS `cursada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cursada` (
  `legajo` int(10) unsigned NOT NULL,
  `idCurso` tinyint(4) NOT NULL,
  `fecha` date NOT NULL,
  `cicloLectivo` year(4) NOT NULL,
  PRIMARY KEY (`legajo`,`idCurso`,`fecha`),
  KEY `fk_Cursada_Curso1_idx` (`idCurso`),
  CONSTRAINT `fk_Cursada_Alumno1` FOREIGN KEY (`legajo`) REFERENCES `alumno` (`legajo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cursada_Curso1` FOREIGN KEY (`idCurso`) REFERENCES `curso` (`idCurso`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cursada`
--

LOCK TABLES `cursada` WRITE;
/*!40000 ALTER TABLE `cursada` DISABLE KEYS */;
INSERT INTO `cursada` VALUES (31568,1,'2019-03-03',2019),(31897,3,'2019-03-03',2019),(32191,3,'2019-03-03',2019),(32232,3,'2019-03-03',2019),(33645,2,'2019-03-03',2019);
/*!40000 ALTER TABLE `cursada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curso` (
  `idCurso` tinyint(4) NOT NULL AUTO_INCREMENT,
  `anio` tinyint(3) unsigned NOT NULL,
  `division` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`idCurso`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
INSERT INTO `curso` VALUES (1,4,7),(2,5,7),(3,6,7);
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `domicilio`
--

DROP TABLE IF EXISTS `domicilio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `domicilio` (
  `idDomicilio` int(11) NOT NULL,
  `idLocalidad` tinyint(4) NOT NULL,
  `calle` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `altura` smallint(5) unsigned DEFAULT NULL,
  `piso` tinyint(3) unsigned DEFAULT NULL,
  `departamento` varchar(3) COLLATE utf8_spanish_ci DEFAULT NULL,
  `codigoPostal` varchar(8) COLLATE utf8_spanish_ci DEFAULT NULL,
  `observacionDomicilio` varchar(60) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`idDomicilio`),
  KEY `fk_Domicilio_Localidad1_idx` (`idLocalidad`),
  CONSTRAINT `fk_Domicilio_Localidad1` FOREIGN KEY (`idLocalidad`) REFERENCES `localidad` (`idLocalidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `domicilio`
--

LOCK TABLES `domicilio` WRITE;
/*!40000 ALTER TABLE `domicilio` DISABLE KEYS */;
INSERT INTO `domicilio` VALUES (1,1,'Lima',1693,4,'32','1138',''),(2,2,'Avenida Hipólito Yrigoyen',214,1,'11','1828',''),(3,3,'Alberdi',802,1,'1','1878',''),(4,1,'Uspallata',466,2,'B','1143',NULL),(5,1,'Casa',321,1,'1','1104',NULL);
/*!40000 ALTER TABLE `domicilio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dominiomail`
--

DROP TABLE IF EXISTS `dominiomail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dominiomail` (
  `idDominioMail` tinyint(4) NOT NULL AUTO_INCREMENT,
  `dominio` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idDominioMail`),
  UNIQUE KEY `dominio_UNIQUE` (`dominio`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dominiomail`
--

LOCK TABLES `dominiomail` WRITE;
/*!40000 ALTER TABLE `dominiomail` DISABLE KEYS */;
INSERT INTO `dominiomail` VALUES (1,'gmail.com'),(2,'hotmail.com'),(3,'yahoo.com');
/*!40000 ALTER TABLE `dominiomail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `falta`
--

DROP TABLE IF EXISTS `falta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `falta` (
  `legajo` int(10) unsigned NOT NULL,
  `idTipoFalta` tinyint(4) NOT NULL,
  `idTipoAusencia` tinyint(4) NOT NULL,
  `fecha` date NOT NULL,
  `falta` float unsigned NOT NULL,
  `justificada` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`legajo`,`idTipoFalta`,`idTipoAusencia`,`fecha`),
  KEY `fk_Falta_Alumno1_idx` (`legajo`),
  KEY `fk_Falta_TipoFalta1_idx` (`idTipoAusencia`),
  KEY `fk_Falta_TipoFalta2_idx` (`idTipoFalta`),
  CONSTRAINT `fk_Falta_Alumno1` FOREIGN KEY (`legajo`) REFERENCES `alumno` (`legajo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Falta_TipoAusencia` FOREIGN KEY (`idTipoAusencia`) REFERENCES `tipoausencia` (`idTipoAusencia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Falta_TipoFalta` FOREIGN KEY (`idTipoFalta`) REFERENCES `tipofalta` (`idTipoFalta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `falta`
--

LOCK TABLES `falta` WRITE;
/*!40000 ALTER TABLE `falta` DISABLE KEYS */;
INSERT INTO `falta` VALUES (31568,2,3,'2019-05-22',1,0),(31897,1,1,'2019-03-15',1,1),(32191,4,3,'2019-08-12',1,0),(32232,1,1,'2019-08-26',1,1),(33645,3,2,'2019-06-03',1,1);
/*!40000 ALTER TABLE `falta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `localidad`
--

DROP TABLE IF EXISTS `localidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `localidad` (
  `idLocalidad` tinyint(4) NOT NULL AUTO_INCREMENT,
  `localidad` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idLocalidad`),
  UNIQUE KEY `localidad_UNIQUE` (`localidad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `localidad`
--

LOCK TABLES `localidad` WRITE;
/*!40000 ALTER TABLE `localidad` DISABLE KEYS */;
INSERT INTO `localidad` VALUES (1,'CABA'),(3,'Lomas De Zamora'),(2,'Quilmes');
/*!40000 ALTER TABLE `localidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nacionalidad`
--

DROP TABLE IF EXISTS `nacionalidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nacionalidad` (
  `idNacionalidad` tinyint(4) NOT NULL AUTO_INCREMENT,
  `Nacionalidad` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idNacionalidad`),
  UNIQUE KEY `Nacionalidadcol_UNIQUE` (`Nacionalidad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nacionalidad`
--

LOCK TABLES `nacionalidad` WRITE;
/*!40000 ALTER TABLE `nacionalidad` DISABLE KEYS */;
INSERT INTO `nacionalidad` VALUES (1,'Argentino'),(2,'Paraguayo'),(3,'Venezolano');
/*!40000 ALTER TABLE `nacionalidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL AUTO_INCREMENT,
  `idTipoDocumento` tinyint(4) NOT NULL,
  `nroDocumento` int(10) unsigned NOT NULL,
  `idNacionalidad` tinyint(4) NOT NULL,
  `idDominioMail` tinyint(4) DEFAULT NULL,
  `nombre` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `apellido` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `nacimiento` date NOT NULL,
  `telefono1` bigint(20) unsigned DEFAULT NULL,
  `telefono2` bigint(20) unsigned DEFAULT NULL,
  `mail` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `idDomicilio` int(11) NOT NULL,
  PRIMARY KEY (`idPersona`),
  UNIQUE KEY `uq_Persona_idTipoDocumento_nroDocumento` (`idTipoDocumento`,`nroDocumento`) COMMENT 'Unicidad en el tipo de documento y nro por persona.',
  KEY `fk_Persona_Nacionalidad1_idx` (`idNacionalidad`),
  KEY `fk_Persona_DominioMail1_idx` (`idDominioMail`),
  KEY `fk_Persona_Domicilio1_idx` (`idDomicilio`),
  CONSTRAINT `fk_Persona_Domicilio1` FOREIGN KEY (`idDomicilio`) REFERENCES `domicilio` (`idDomicilio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_DominioMail1` FOREIGN KEY (`idDominioMail`) REFERENCES `dominiomail` (`idDominioMail`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_Nacionalidad1` FOREIGN KEY (`idNacionalidad`) REFERENCES `nacionalidad` (`idNacionalidad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_TipoDocumento1` FOREIGN KEY (`idTipoDocumento`) REFERENCES `tipodocumento` (`idTipoDocumento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,1,42817216,1,1,'Alex ','Williams','2000-08-14',43068949,1130300828,'thejigsawmaster13@gmail.com',1),(2,1,43256478,2,2,'Sarah','Striker','2001-11-13',43078848,1128294216,'sarahstriker@hotmail.com',2),(3,1,43564868,3,3,'Atrathiel','Falled','2000-08-11',43185694,1132541269,'atrathielfalled@yahoo.com',3),(4,1,43087538,1,1,'Daniel','Cardoso','2001-01-30',NULL,1124611144,'danielcardoso935@gmail.com',4),(5,1,42562603,1,1,'Veronica','Choque','2000-03-24',NULL,1133573783,'choqueveronicaj@gmail.com',5);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seguimiento`
--

DROP TABLE IF EXISTS `seguimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seguimiento` (
  `idObservacion` smallint(6) NOT NULL,
  `legajo` int(10) unsigned NOT NULL,
  `observacion` varchar(500) COLLATE utf8_spanish_ci NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`idObservacion`,`legajo`),
  KEY `fk_Observacion_Alumno1_idx` (`legajo`),
  CONSTRAINT `fk_Observacion_Alumno1` FOREIGN KEY (`legajo`) REFERENCES `alumno` (`legajo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seguimiento`
--

LOCK TABLES `seguimiento` WRITE;
/*!40000 ALTER TABLE `seguimiento` DISABLE KEYS */;
INSERT INTO `seguimiento` VALUES (1,31568,'Prueba','2019-08-28'),(2,32191,'Prueba','2019-08-27'),(3,31897,'Prueba','2019-08-26');
/*!40000 ALTER TABLE `seguimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoausencia`
--

DROP TABLE IF EXISTS `tipoausencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoausencia` (
  `idTipoAusencia` tinyint(4) NOT NULL AUTO_INCREMENT,
  `tipoAusencia` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `falta` float unsigned NOT NULL,
  PRIMARY KEY (`idTipoAusencia`),
  UNIQUE KEY `TipoFalta_UNIQUE` (`tipoAusencia`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoausencia`
--

LOCK TABLES `tipoausencia` WRITE;
/*!40000 ALTER TABLE `tipoausencia` DISABLE KEYS */;
INSERT INTO `tipoausencia` VALUES (1,'Ausente',1),(2,'Ausente con presencia',1),(3,'Tarde',0.5);
/*!40000 ALTER TABLE `tipoausencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipodocumento`
--

DROP TABLE IF EXISTS `tipodocumento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipodocumento` (
  `idTipoDocumento` tinyint(4) NOT NULL AUTO_INCREMENT,
  `TipoDocumento` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idTipoDocumento`),
  UNIQUE KEY `TipoDocumentocol_UNIQUE` (`TipoDocumento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipodocumento`
--

LOCK TABLES `tipodocumento` WRITE;
/*!40000 ALTER TABLE `tipodocumento` DISABLE KEYS */;
INSERT INTO `tipodocumento` VALUES (1,'DNI'),(2,'Pasaporte');
/*!40000 ALTER TABLE `tipodocumento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipofalta`
--

DROP TABLE IF EXISTS `tipofalta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipofalta` (
  `idTipoFalta` tinyint(4) NOT NULL AUTO_INCREMENT,
  `tipoFalta` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idTipoFalta`),
  UNIQUE KEY `tipoFalta_UNIQUE` (`tipoFalta`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipofalta`
--

LOCK TABLES `tipofalta` WRITE;
/*!40000 ALTER TABLE `tipofalta` DISABLE KEYS */;
INSERT INTO `tipofalta` VALUES (3,'Educacion Fisica'),(4,'Laboratorio'),(2,'Taller'),(1,'Teoria');
/*!40000 ALTER TABLE `tipofalta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipotutor`
--

DROP TABLE IF EXISTS `tipotutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipotutor` (
  `idTipoTutor` tinyint(4) NOT NULL AUTO_INCREMENT,
  `TipoTutor` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idTipoTutor`),
  UNIQUE KEY `TipoTutor_UNIQUE` (`TipoTutor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipotutor`
--

LOCK TABLES `tipotutor` WRITE;
/*!40000 ALTER TABLE `tipotutor` DISABLE KEYS */;
INSERT INTO `tipotutor` VALUES (2,'Madre'),(1,'Padre'),(3,'Tutor');
/*!40000 ALTER TABLE `tipotutor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tutor`
--

DROP TABLE IF EXISTS `tutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tutor` (
  `legajo` int(10) unsigned NOT NULL,
  `idPersona` int(11) NOT NULL,
  `idTipoTutor` tinyint(4) NOT NULL,
  PRIMARY KEY (`legajo`,`idPersona`),
  KEY `fk_Tutor_Persona1_idx` (`idPersona`),
  KEY `fk_Tutor_TipoTutor1_idx` (`idTipoTutor`),
  CONSTRAINT `fk_Tutor_Alumno1` FOREIGN KEY (`legajo`) REFERENCES `alumno` (`legajo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tutor_Persona1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tutor_TipoTutor1` FOREIGN KEY (`idTipoTutor`) REFERENCES `tipotutor` (`idTipoTutor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tutor`
--

LOCK TABLES `tutor` WRITE;
/*!40000 ALTER TABLE `tutor` DISABLE KEYS */;
INSERT INTO `tutor` VALUES (32232,1,1),(32191,4,2),(31897,5,3);
/*!40000 ALTER TABLE `tutor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-28 10:43:16
