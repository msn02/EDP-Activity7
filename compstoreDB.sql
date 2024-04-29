CREATE DATABASE  IF NOT EXISTS `compstore` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `compstore`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: compstore
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `zipcode` varchar(255) DEFAULT NULL,
  `contact_num` double DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Cesar Fernandez','Arkong Bato, Pampanga','1444',9836735858,'cesar.fernandz90@example.com\r'),(2,'Janelle Canoy','Isabela, Negros Occidental','6128',9982377035,'janellec4noy@example.com\r'),(3,'Gabriel Suarez','Cabugao, Ilocos Sur','2732',9323206305,'gabriel.suarez348@example.com\r'),(4,'Riley Alvarez','Nabua, Camarines Sur','4434',9285616064,'riley89.alz@example.com\r'),(5,'Dranreb Gomez','Poblacion, Muntinlupa City','1776',9830904139,'dranrebg567@example.com\r'),(6,'Jonas Ong','Santa Cruz, Makati','1205',9103320524,'jonas.ong@example.com\r'),(7,'Catherine Bellen','San Isidro, Isabela','3310',9337614659,'cbellen78@example.com\r'),(8,'Vivi Ramos','Buenavista, Masbate','5421',9192582152,'vivi9.ramos@example.com\r'),(9,'John Mark Carpio','General Tinio, Nueva Ecija','3104',9830933154,'johnmark0951@example.com\r'),(10,'Hailey Prado','Daet, Camarines Norte','4600',9290346766,'hy.prado45@example.com\r'),(11,'Gina Arellano','San Isidro, Isabela','3310',9374302279,'gina95arellano@example.com'),(12,'Daniel Lomibao','Nabua, Camarines Sur','4434',9023248659,'lomibao03D@example.com'),(13,'Ariel Magtangob','Poblacion, Muntinlupa City','1776',9340493127,'arielM21@example.com'),(14,'Jasmine Condat','Daraga, Albay','4501',9074850021,'jasmineCo45@example.com');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `delivery`
--

DROP TABLE IF EXISTS `delivery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery` (
  `id` int NOT NULL AUTO_INCREMENT,
  `contact_personnel` varchar(255) DEFAULT NULL,
  `contact_num` double DEFAULT NULL,
  `courier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery`
--

LOCK TABLES `delivery` WRITE;
/*!40000 ALTER TABLE `delivery` DISABLE KEYS */;
INSERT INTO `delivery` VALUES (1,'Nigel Aquino',9464458833,'JnT Express\r'),(2,'Sylvia Collado',9542125158,'GOGO Express\r'),(3,'Amelie Reyes',9421423562,'Ninja Van\r'),(4,'Russel Recamunda',9590776831,'Entrego\r'),(5,'Rhodette Mendoza',9922729670,'JnT Express\r'),(6,'Gregorio Morales',9541616575,'Entrego\r'),(7,'Mariel Velasquez',9848013748,'JRS Express\r'),(8,'Jason Ronquillo',9527799143,'Ninja Van\r'),(9,'Fred Sanchez',9392626983,'JnT Express\r'),(10,'Julia Herrera',9931994131,'JRS Express\r');
/*!40000 ALTER TABLE `delivery` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_name` varchar(255) DEFAULT NULL,
  `contact_num` double DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `job_code` int DEFAULT NULL,
  `employee_username` varchar(255) DEFAULT NULL,
  `employee_password` varchar(255) DEFAULT NULL,
  `security_question` varchar(255) DEFAULT NULL,
  `answer` varchar(255) DEFAULT NULL,
  `account_status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `job_code_idx` (`job_code`),
  CONSTRAINT `job_code` FOREIGN KEY (`job_code`) REFERENCES `employee_position` (`job_code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Ricardo Vazquez',9851203957,'rv527@example.com',1,'ricardoV','vazquez527','What was the first exam that I failed during highschool?','Physical Education','Active'),(2,'Joyce Crisostomo',9173071636,'cris.joyce91@example.com',2,'joyjoyce','jcrisostomo19','What was my first pet?','An orange cat','Active'),(3,'Aries Madrid',9370393168,'aries56@example.com',5,'madrid_a','aries56madrid','When did I go to Singapore?','September 8, 2018','Active'),(4,'Cristina Morales',9991920848,'cristinam923@example.com',3,'cris_nam','923cristina','I went on a date with *blank* during my 18th birthday.','Aries Madrid','Active'),(5,'Susana Ramos',9373399679,'susanaramos6@example.com',5,'susanaR6','susana5plus1','How many kids do I want to bear?','0','Inactive'),(6,'Sonia Ibarra',9852209276,'ibarra72@example.com',3,'sonia72','ibarra_s72','Who was my mortal enemy in highschool?','Ronmae Alcantara','Active'),(7,'Angelie Alonso',9921665964,'alonso12.angelie@example.com',4,'angie12','alonsoangie12','When did I confess to my first love?','October 27, 2013','Active'),(8,'Juan Manuel Flores',9089350802,'jm.flores47@example.com',5,'juanManuel','JMflores','Where did my father and mother first met?','Supermarket','Active'),(9,'Victor Ruiz',9720286903,'vicruiz0521@example.com',4,'victor21','victor521','What was the first gift I got from my first spouse?','Phone case','Active'),(10,'Daniel Briones',9914428975,'dbriones@example.com',3,'dandaniel','brionesd32','What was the color of my first motorcycle?','Dark gray','Active'),(11,'Poppy Luisito',9453203427,'elpoppy40@example.com',2,'poppy4','poppy40','What was the first flower that grew in my apartment?','Roses','Inactive'),(12,'Clement Santos',9883651438,'clementS82@example.com',5,'clem_ent2','santos82c','What is the vegetable that I will NEVER eat?','Okra','Inactive'),(13,'Eva Delos Reyes',9381839374,'evaReyes73@example.com',3,'eva_73','reyeseva777','What is my favorite sanrio character?','Kuromi','Active'),(14,'Miguel Ramos',9238847348,'ramosmigs91@example.com',2,'migs91','migsramos','When did I go to Hong Kong?','August 3, 2013','Active'),(15,'Patrick Flores',9232398283,'patFlores34@example.com',5,'patrick34','patflores34','What is my favorite color in highschool?','Blue','Active'),(16,'Hannah Macasinag',9394833027,'hannahM50@example.com',4,'hannah05','hannahbanana','What is my favorite fruit?','Banana','Active'),(17,'Emmanuel Tan',9108023934,'emman10@example.com',3,'emmanTan','emmanuel10','What is my biggest fear?','Dying','Inactive');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_position`
--

DROP TABLE IF EXISTS `employee_position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_position` (
  `job_code` int NOT NULL AUTO_INCREMENT,
  `position` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`job_code`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_position`
--

LOCK TABLES `employee_position` WRITE;
/*!40000 ALTER TABLE `employee_position` DISABLE KEYS */;
INSERT INTO `employee_position` VALUES (1,'Manager'),(2,'Store Clerk'),(3,'Sales Staff'),(4,'IT Support'),(5,'Technician');
/*!40000 ALTER TABLE `employee_position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `employee_summary`
--

DROP TABLE IF EXISTS `employee_summary`;
/*!50001 DROP VIEW IF EXISTS `employee_summary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `employee_summary` AS SELECT 
 1 AS `position`,
 1 AS `employee_count`,
 1 AS `total_salary`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `order_status_count`
--

DROP TABLE IF EXISTS `order_status_count`;
/*!50001 DROP VIEW IF EXISTS `order_status_count`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `order_status_count` AS SELECT 
 1 AS `order_status`,
 1 AS `count`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `order_date` date DEFAULT NULL,
  `product_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `price` float DEFAULT NULL,
  `order_status` varchar(255) DEFAULT NULL,
  `customer_id` int DEFAULT NULL,
  `payment_method` varchar(255) DEFAULT NULL,
  `delivery_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `product_id_idx` (`product_id`),
  KEY `delivery_id_idx` (`delivery_id`),
  KEY `customer_id_idx` (`customer_id`),
  CONSTRAINT `customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `delivery_id` FOREIGN KEY (`delivery_id`) REFERENCES `delivery` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `product_id` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2024-01-19',12,2,44990,'Delivered',7,'Bank Transfer',4),(2,'2024-01-21',1,4,54600,'Delivered',2,'Gcash',6),(3,'2024-01-21',11,1,6350,'Delivered',6,'DragonPay',1),(4,'2024-01-21',5,1,55995,'Delivered',8,'Gcash',2),(5,'2024-01-22',9,6,4170,'Delivered',10,'Gcash',10),(6,'2024-01-23',6,2,143990,'Delivered',7,'Bank Transfer',9),(7,'2024-01-25',8,2,139990,'Delivered',9,'Bank Transfer',4),(8,'2024-01-28',12,1,22495,'Delivered',2,'Gcash',3),(10,'2024-01-31',5,2,111990,'Delivered',3,'DragonPay',10),(11,'2024-02-03',11,2,12700,'Delivered',5,'Gcash',2),(12,'2024-02-03',6,1,71995,'Delivered',4,'Bank Transfer',3),(13,'2024-02-04',2,3,17400,'Delivered',1,'Bank Transfer',1),(14,'2024-02-05',11,3,19050,'Delivered',2,'Gcash',5),(15,'2024-02-07',8,1,69995,'Delivered',6,'DragonPay',8),(16,'2024-02-08',8,3,209985,'Delivered',10,'DragonPay',1),(21,'2024-02-08',5,3,167985,'Delivered',10,'DragonPay',1),(24,'2024-02-08',4,4,155980,'Delivered',3,'Bank Transfer',5),(27,'2024-02-09',1,4,54600,'Delivered',4,'GCash',1),(28,'2024-02-10',4,3,116985,'Delivered',5,'Bank Transfer',10),(29,'2024-02-10',10,5,332475,'Shipped',3,'DragonPay',4),(30,'2024-02-10',10,5,332475,'Shipped',3,'GCash',4),(31,'2024-03-25',3,5,274975,'Shipped',2,'DragonPay',3),(32,'2024-03-26',3,3,164985,'Shipped',8,'GCash',3),(33,'2024-04-02',10,2,132990,'Packed',9,'Bank Transfer',6),(34,'2024-04-05',2,2,11600,'Packed',1,'GCash',8),(35,'2024-04-07',12,3,67485,'Packed',1,'GCash',6),(36,'2024-04-09',12,5,112475,'Pending',5,'DragonPay',5),(37,'2024-04-10',14,3,24900,'Pending',7,'GCash',3),(38,'2024-04-11',10,5,332475,'Pending',5,'GCash',1),(39,'2024-04-16',6,2,143990,'Pending',11,'Bank Transfer',3),(40,'2024-04-16',10,3,199485,'Pending',11,'DragonPay',5),(41,'2024-04-16',17,2,20000,'Pending',12,'GCash',7);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_insert_compute_price` BEFORE INSERT ON `orders` FOR EACH ROW BEGIN
    set new.price = new.quantity * (select price from product where id = new.product_id);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_insert_update_product` AFTER INSERT ON `orders` FOR EACH ROW begin
	update product		
	set unit_in_stock = unit_in_stock - new.quantity 
	where id = new.product_id;	
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_update_compute_price` BEFORE UPDATE ON `orders` FOR EACH ROW begin
    set new.price = new.quantity * (select price from product where id = new.product_id);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_update_update_product` AFTER UPDATE ON `orders` FOR EACH ROW begin
	if new.order_status in ("Canceled", "Returned")  
		AND old.order_status not in ("Canceled", "Returned") then
		update product
		set unit_in_stock = unit_in_stock + old.quantity
		where id = old.product_id;						
	elseif new.order_status not in ("Canceled", "Returned") 
		AND old.order_status in ("Canceled", "Returned") then
		update product		  						
		set unit_in_stock = unit_in_stock - old.quantity
		where id = old.product_id;
	end if;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_delete_check_orders` BEFORE DELETE ON `orders` FOR EACH ROW begin
    if old.order_status in ('Delivered', 'Shipped') then
		SIGNAL SQLSTATE '45000'
		set message_text = 'Unable to delete order transaction';
    end if;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `id` int NOT NULL,
  `product_name` varchar(255) DEFAULT NULL,
  `brand` varchar(255) DEFAULT NULL,
  `product_type` int DEFAULT NULL,
  `unit_in_stock` int DEFAULT NULL,
  `color` varchar(255) DEFAULT NULL,
  `cost` float DEFAULT NULL,
  `price` float DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `product_type_idx` (`product_type`),
  CONSTRAINT `product_type` FOREIGN KEY (`product_type`) REFERENCES `product_type` (`type_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Gigabyte GS27Q-AP','Gigabyte',5,18,'Black',11000,13650),(2,'RK84 Pro 75','Royal Kludge',3,17,'White',5200,5800),(3,'ROG Phone 7','Asus',7,14,'Storm White',50000,54995),(4,'Acer Aspire A515','Acer',1,13,'Charcoal Black',36000,38995),(5,'Acer Nitro V','Acer',1,17,'Black',45000,55995),(6,'YOGA Duet 7i','Lenovo',1,12,'Gray',61000,71995),(7,'Apple MAC Mini 2 Package','Apple',2,0,'Black',48500,54995),(8,'Macbook Air','Apple',1,9,'Light Pink',62000,69995),(9,'Promate Ken ','Promate',4,13,'Pink',550,695),(10,'Asus TUF Gaming','Asus',1,30,'Black',56000,66495),(11,'AKKO MOD005','AKKO',3,0,'Black',5500,6350),(12,'Epson EcoTank L11050','Epson',6,17,'Black',20000,22495),(13,'Lenovo Ideapad Slim 3','Lenovo',1,0,'Artic Grey',38000,41995),(14,'HP Ink Tank 315','HP',6,12,'Black',7500,8300),(15,'DCP-T420W Ink Tank Printer','Brother',6,10,'Black',8250,8800),(16,'ROG Phone 8 Pro','Asus',7,20,'Obsidian',58995,60995),(17,'ROG Strix Scope II 96 Wireless','Asus',3,25,'Black',7500,10000),(18,'Logitech Signature Slim K950 Full-Size Wireless Keyboard','Logitech',3,15,'White',4500,4999),(19,'Asus VivoBook 15','Asus',1,20,'Silver',37500,38995);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_type`
--

DROP TABLE IF EXISTS `product_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_type` (
  `type_id` int NOT NULL AUTO_INCREMENT,
  `prod_type` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_type`
--

LOCK TABLES `product_type` WRITE;
/*!40000 ALTER TABLE `product_type` DISABLE KEYS */;
INSERT INTO `product_type` VALUES (1,'Laptop'),(2,'Desktop'),(3,'Mechanical Keyboard'),(4,'Wireless Mouse'),(5,'Monitor'),(6,'Printer'),(7,'Gaming Phone');
/*!40000 ALTER TABLE `product_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salary`
--

DROP TABLE IF EXISTS `salary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salary` (
  `tracking_num` int NOT NULL AUTO_INCREMENT,
  `employee_id` int DEFAULT NULL,
  `daily_rate` float DEFAULT NULL,
  `working_days` int DEFAULT NULL,
  `salary_for_the_month` varchar(255) DEFAULT NULL,
  `monthly_salary` float DEFAULT NULL,
  PRIMARY KEY (`tracking_num`),
  KEY `employee_id_idx` (`employee_id`),
  CONSTRAINT `employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salary`
--

LOCK TABLES `salary` WRITE;
/*!40000 ALTER TABLE `salary` DISABLE KEYS */;
INSERT INTO `salary` VALUES (1,1,1800,20,'JANUARY',36000),(2,2,1000,23,'JANUARY',23000),(3,3,1680,21,'JANUARY',35280),(4,4,1200,19,'JANUARY',22800),(5,5,920,24,'JANUARY',22080),(6,6,1280,22,'JANUARY',28160),(7,7,1400,20,'JANUARY',28000),(8,8,1720,25,'JANUARY',43000),(9,9,1400,19,'JANUARY',26600),(10,10,1280,23,'JANUARY',29440);
/*!40000 ALTER TABLE `salary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `unavailable_products`
--

DROP TABLE IF EXISTS `unavailable_products`;
/*!50001 DROP VIEW IF EXISTS `unavailable_products`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `unavailable_products` AS SELECT 
 1 AS `product_id`,
 1 AS `color`,
 1 AS `cost`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'compstore'
--

--
-- Dumping routines for database 'compstore'
--
/*!50003 DROP FUNCTION IF EXISTS `discount_func` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `discount_func`(price_val float, discount float) RETURNS float
    DETERMINISTIC
BEGIN
	declare output float;
    set output = price_val - (price_val * discount);
    return output;
RETURN 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `order_total` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `order_total`()
BEGIN
    declare done int default 0;
    declare current_id int;
    declare id_cur cursor for select id from orders;
    declare continue handler for not found set done = 1;
    
    open id_cur;
    repeat 
		fetch id_cur into current_id;
        update orders set price = (quantity * (select price from product where product.id = orders.product_id))
        where id = current_id;
	until done
    end repeat;
    close id_cur;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `salary_emp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `salary_emp`()
BEGIN
    declare done int default 0;
    declare current_id int;
    declare id_cur cursor for select employee_id from salary;
    declare continue handler for not found set done = 1;
    
    open id_cur;
    repeat 
		fetch id_cur into current_id;
        update salary set monthly_salary = (daily_rate * working_days)
        where employee_id = current_id;
	until done
    end repeat;
    close id_cur;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `employee_summary`
--

/*!50001 DROP VIEW IF EXISTS `employee_summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `employee_summary` AS select `p`.`position` AS `position`,count(`e`.`job_code`) AS `employee_count`,sum(`s`.`monthly_salary`) AS `total_salary` from ((`employee` `e` join `employee_position` `p` on((`e`.`job_code` = `p`.`job_code`))) join `salary` `s` on((`e`.`id` = `s`.`employee_id`))) group by `p`.`position` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `order_status_count`
--

/*!50001 DROP VIEW IF EXISTS `order_status_count`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `order_status_count` AS select `orders`.`order_status` AS `order_status`,count(0) AS `count` from `orders` group by `orders`.`order_status` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `unavailable_products`
--

/*!50001 DROP VIEW IF EXISTS `unavailable_products`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `unavailable_products` AS select `product`.`id` AS `product_id`,`product`.`color` AS `color`,`product`.`cost` AS `cost` from `product` where (`product`.`unit_in_stock` = 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-23  0:34:11
