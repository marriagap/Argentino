CREATE DATABASE  IF NOT EXISTS `milton_sis` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `milton_sis`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: milton_sis
-- ------------------------------------------------------
-- Server version	5.5.19

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
-- Table structure for table `mercaderia`
--

DROP TABLE IF EXISTS `mercaderia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mercaderia` (
  `idMercaderia` int(11) NOT NULL AUTO_INCREMENT,
  `codInternoMercaderia` varchar(45) DEFAULT NULL,
  `nomMercaderia` varchar(50) NOT NULL,
  `descripcionMercaderia` varchar(200) NOT NULL,
  `proveedorMercaderia` varchar(50) NOT NULL,
  `stockDisponible` int(11) NOT NULL,
  `precioXUnidadMedida` decimal(11,2) NOT NULL,
  `fechaAdquisicionProduccion` date NOT NULL,
  `precioAdquisicion` decimal(11,2) NOT NULL,
  `codigoGrupoMercaderia` int(11) NOT NULL,
  `codigoLote` varchar(45) NOT NULL,
  `tipoLote` varchar(20) NOT NULL,
  `minXLote` int(11) NOT NULL,
  `fechaVencimiento` date NOT NULL,
  `ubicacionLote` varchar(45) NOT NULL,
  `estadoMercaderia` varchar(45) NOT NULL,
  `unidadmedida_idUnidadMedida` int(10) unsigned NOT NULL,
  `mercaderia_idMercaderia` int(11) NOT NULL,
  `mercaderia_idMercaderia1` int(11) NOT NULL,
  PRIMARY KEY (`idMercaderia`),
  UNIQUE KEY `codInternoMercaderia_UNIQUE` (`codInternoMercaderia`),
  KEY `fk_mercaderia_unidadmedida1` (`unidadmedida_idUnidadMedida`),
  KEY `fk_mercaderia_mercaderia1` (`mercaderia_idMercaderia`),
  KEY `fk_mercaderia_mercaderia2` (`mercaderia_idMercaderia1`),
  CONSTRAINT `fk_mercaderia_mercaderia2` FOREIGN KEY (`mercaderia_idMercaderia1`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_mercaderia_mercaderia1` FOREIGN KEY (`mercaderia_idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_mercaderia_unidadmedida1` FOREIGN KEY (`unidadmedida_idUnidadMedida`) REFERENCES `unidadmedida` (`idUnidadMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mercaderia`
--

LOCK TABLES `mercaderia` WRITE;
/*!40000 ALTER TABLE `mercaderia` DISABLE KEYS */;
/*!40000 ALTER TABLE `mercaderia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL AUTO_INCREMENT,
  `primerNombre` varchar(45) DEFAULT NULL,
  `segundoNombre` varchar(45) NOT NULL COMMENT 'Apellido para una persona natural, razonSocial cuando sea una persona juridica',
  `fechaNacimiento` date DEFAULT NULL,
  `direccionRasonSocial` varchar(60) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `nroIdentificacion` varchar(20) NOT NULL,
  `tipoIdentificacion` char(1) NOT NULL COMMENT 'RUC = J; DNI = N; CodigoInterno de Empleado = E',
  `fechaRegistro` date NOT NULL COMMENT 'Puede prestarse para: Fecha_Ingreso => Proveedor, Fecha_Contrato => Empleado, Fecha_Registro => Cliente',
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacen`
--

DROP TABLE IF EXISTS `almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `almacen` (
  `idAlmacen` int(11) NOT NULL AUTO_INCREMENT,
  `capacidadMaxDeLotes` int(11) NOT NULL,
  PRIMARY KEY (`idAlmacen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacen`
--

LOCK TABLES `almacen` WRITE;
/*!40000 ALTER TABLE `almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento` (
  `idMovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `tipoMovimiento` varchar(20) NOT NULL,
  `cantidadItemsMovimiento` int(11) NOT NULL,
  `codInterno` varchar(20) DEFAULT NULL,
  `tipoComprobante` varchar(20) NOT NULL,
  `montoPago` decimal(11,2) NOT NULL,
  `persona_idPersona` int(11) NOT NULL,
  `persona_idPersona1` int(11) NOT NULL,
  `ofertas_idOfertas` int(11) NOT NULL,
  PRIMARY KEY (`idMovimiento`),
  UNIQUE KEY `codInterno_UNIQUE` (`codInterno`),
  KEY `fk_movimiento_persona1` (`persona_idPersona`),
  KEY `fk_movimiento_persona2` (`persona_idPersona1`),
  KEY `fk_movimiento_ofertas1` (`ofertas_idOfertas`),
  CONSTRAINT `fk_movimiento_ofertas1` FOREIGN KEY (`ofertas_idOfertas`) REFERENCES `ofertas` (`idOfertas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_persona1` FOREIGN KEY (`persona_idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_persona2` FOREIGN KEY (`persona_idPersona1`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento`
--

LOCK TABLES `movimiento` WRITE;
/*!40000 ALTER TABLE `movimiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallefactoresmercaderia`
--

DROP TABLE IF EXISTS `detallefactoresmercaderia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallefactoresmercaderia` (
  `mercaderia_idMercaderia` int(11) NOT NULL,
  `factores_idFactores` int(11) NOT NULL,
  PRIMARY KEY (`mercaderia_idMercaderia`,`factores_idFactores`),
  KEY `fk_detallefactoresmercaderia_mercaderia1` (`mercaderia_idMercaderia`),
  KEY `fk_detallefactoresmercaderia_factores1` (`factores_idFactores`),
  CONSTRAINT `fk_detallefactoresmercaderia_factores1` FOREIGN KEY (`factores_idFactores`) REFERENCES `factores` (`idFactores`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detallefactoresmercaderia_mercaderia1` FOREIGN KEY (`mercaderia_idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallefactoresmercaderia`
--

LOCK TABLES `detallefactoresmercaderia` WRITE;
/*!40000 ALTER TABLE `detallefactoresmercaderia` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallefactoresmercaderia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidadmedida`
--

DROP TABLE IF EXISTS `unidadmedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidadmedida` (
  `idUnidadMedida` int(10) unsigned NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `valor` int(11) NOT NULL,
  `unidadMedida_idUnidadMedida` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idUnidadMedida`),
  KEY `fk_unidadMedida_unidadMedida1_idx` (`unidadMedida_idUnidadMedida`),
  CONSTRAINT `fk_unidadMedida_unidadMedida1` FOREIGN KEY (`unidadMedida_idUnidadMedida`) REFERENCES `unidadmedida` (`idUnidadMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidadmedida`
--

LOCK TABLES `unidadmedida` WRITE;
/*!40000 ALTER TABLE `unidadmedida` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidadmedida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ofertas`
--

DROP TABLE IF EXISTS `ofertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ofertas` (
  `idOfertas` int(11) NOT NULL AUTO_INCREMENT,
  `factorOfertas` varchar(20) NOT NULL,
  `fechaInicioAplicacion` date NOT NULL,
  `fechaFinAplicacion` date NOT NULL,
  `tipoOferta` varchar(45) NOT NULL,
  `factores_idFactores` int(11) NOT NULL,
  PRIMARY KEY (`idOfertas`),
  KEY `fk_ofertas_factores1` (`factores_idFactores`),
  CONSTRAINT `fk_ofertas_factores1` FOREIGN KEY (`factores_idFactores`) REFERENCES `factores` (`idFactores`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ofertas`
--

LOCK TABLES `ofertas` WRITE;
/*!40000 ALTER TABLE `ofertas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ofertas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallemovimientomercancia`
--

DROP TABLE IF EXISTS `detallemovimientomercancia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallemovimientomercancia` (
  `mercaderia_idMercaderia` int(11) NOT NULL,
  `movimiento_idMovimiento` int(11) NOT NULL,
  `cantidadItemsXTipo` int(11) DEFAULT NULL,
  `precioXTipoItems` decimal(11,2) DEFAULT NULL,
  PRIMARY KEY (`mercaderia_idMercaderia`,`movimiento_idMovimiento`),
  KEY `fk_detallemovimientomercancia_mercaderia1` (`mercaderia_idMercaderia`),
  KEY `fk_detallemovimientomercancia_movimiento1` (`movimiento_idMovimiento`),
  CONSTRAINT `fk_detallemovimientomercancia_mercaderia1` FOREIGN KEY (`mercaderia_idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detallemovimientomercancia_movimiento1` FOREIGN KEY (`movimiento_idMovimiento`) REFERENCES `movimiento` (`idMovimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallemovimientomercancia`
--

LOCK TABLES `detallemovimientomercancia` WRITE;
/*!40000 ALTER TABLE `detallemovimientomercancia` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallemovimientomercancia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factores`
--

DROP TABLE IF EXISTS `factores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factores` (
  `idFactores` int(11) NOT NULL AUTO_INCREMENT,
  `tabla` varchar(45) DEFAULT NULL,
  `concepto` varchar(45) DEFAULT NULL,
  `monto` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idFactores`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factores`
--

LOCK TABLES `factores` WRITE;
/*!40000 ALTER TABLE `factores` DISABLE KEYS */;
/*!40000 ALTER TABLE `factores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallemovalmacen`
--

DROP TABLE IF EXISTS `detallemovalmacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallemovalmacen` (
  `movimiento_idMovimiento` int(11) NOT NULL,
  `almacen_idAlmacen` int(11) NOT NULL,
  PRIMARY KEY (`movimiento_idMovimiento`,`almacen_idAlmacen`),
  KEY `fk_detallemovalmacen_movimiento1` (`movimiento_idMovimiento`),
  KEY `fk_detallemovalmacen_almacen1` (`almacen_idAlmacen`),
  CONSTRAINT `fk_detallemovalmacen_movimiento1` FOREIGN KEY (`movimiento_idMovimiento`) REFERENCES `movimiento` (`idMovimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detallemovalmacen_almacen1` FOREIGN KEY (`almacen_idAlmacen`) REFERENCES `almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallemovalmacen`
--

LOCK TABLES `detallemovalmacen` WRITE;
/*!40000 ALTER TABLE `detallemovalmacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallemovalmacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'milton_sis'
--

--
-- Dumping routines for database 'milton_sis'
--
/*!50003 DROP PROCEDURE IF EXISTS `Consultar_Factores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `Consultar_Factores`(in par_busqueda varchar(20),in tipo_busqueda varchar(20))
BEGIN
    
    if tipo_busqueda = "codigo" then 
        select * from factores where idFactores = parbusqueda;
    else
        if tipo_busqueda = "tabla" then
            select * from factores where tabla = par_busqueda;
        else
            if tipo_busqueda = "concepto" then
                select * from factores where concepto = par_busqueda;
            else
                if tipo_busqueda = "monto" then
                    select * from factores where monto=par_busqueda;
                end if;
            end if;
        end if;
    end if;    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-04-20 20:09:17
