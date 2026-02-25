CREATE DATABASE  IF NOT EXISTS `up_02_2_2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `up_02_2_2`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: up_02_2_2
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `единицы_изм`
--

DROP TABLE IF EXISTS `единицы_изм`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `единицы_изм` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `единицы_изм`
--

LOCK TABLES `единицы_изм` WRITE;
/*!40000 ALTER TABLE `единицы_изм` DISABLE KEYS */;
INSERT INTO `единицы_изм` VALUES (1,'шт');
/*!40000 ALTER TABLE `единицы_изм` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `заказ`
--

DROP TABLE IF EXISTS `заказ`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `заказ` (
  `id_order` int NOT NULL AUTO_INCREMENT,
  `OrderDate` date NOT NULL,
  `DeliveryDate` date DEFAULT NULL,
  `id_pick_up_point` int NOT NULL,
  `id_client` int NOT NULL,
  `PickupCode` varchar(10) NOT NULL,
  `id_status` int NOT NULL,
  PRIMARY KEY (`id_order`),
  KEY `fk_pickup_idx` (`id_pick_up_point`),
  KEY `fk_client_idx` (`id_client`),
  KEY `fk_Status_idx` (`id_status`),
  CONSTRAINT `fk_client` FOREIGN KEY (`id_client`) REFERENCES `пользователь` (`id_client`),
  CONSTRAINT `fk_pickup` FOREIGN KEY (`id_pick_up_point`) REFERENCES `пункт_выдачи` (`id_pick_up_point`),
  CONSTRAINT `fk_Status` FOREIGN KEY (`id_status`) REFERENCES `статус_зак` (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `заказ`
--

LOCK TABLES `заказ` WRITE;
/*!40000 ALTER TABLE `заказ` DISABLE KEYS */;
INSERT INTO `заказ` VALUES (1,'2025-02-27','2025-04-20',1,4,'901',1),(2,'2022-09-28','2025-04-21',11,1,'902',1),(3,'2025-03-21','2025-04-22',2,2,'903',1),(4,'2025-02-20','2025-04-23',11,3,'904',1),(5,'2025-03-17','2025-04-24',2,4,'905',1),(6,'2025-03-01','2025-04-25',15,1,'906',1),(7,'2025-02-20','2025-04-26',3,2,'907',1),(8,'2025-03-31','2025-04-27',19,3,'908',2),(9,'2025-04-02','2025-04-28',5,4,'909',2),(10,'2025-04-03','2025-04-29',19,4,'910',2);
/*!40000 ALTER TABLE `заказ` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `категориятовара`
--

DROP TABLE IF EXISTS `категориятовара`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `категориятовара` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `категориятовара`
--

LOCK TABLES `категориятовара` WRITE;
/*!40000 ALTER TABLE `категориятовара` DISABLE KEYS */;
INSERT INTO `категориятовара` VALUES (1,'жеская обувь'),(2,'мужская обувь');
/*!40000 ALTER TABLE `категориятовара` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `пользователь`
--

DROP TABLE IF EXISTS `пользователь`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `пользователь` (
  `id_client` int NOT NULL AUTO_INCREMENT,
  `roll_id` int NOT NULL,
  `FIO` varchar(145) NOT NULL,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`id_client`),
  KEY `fk_roll_idx` (`roll_id`),
  CONSTRAINT `fk_roll` FOREIGN KEY (`roll_id`) REFERENCES `роль сотрудника` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `пользователь`
--

LOCK TABLES `пользователь` WRITE;
/*!40000 ALTER TABLE `пользователь` DISABLE KEYS */;
INSERT INTO `пользователь` VALUES (1,1,'Никифорова Весения Николаевна','94d5ous@gmail.com','uzWC67'),(2,1,'Сазонов Руслан Германович','uth4iz@mail.com','2L6KZG'),(3,1,'Одинцов Серафим Артёмович','yzls62@outlook.com','JlFRCZ'),(4,2,'Степанов Михаил Артёмович','1diph5e@tutanota.com','8ntwUp'),(5,2,'Ворсин Петр Евгеньевич','tjde7c@yahoo.com','YOyhfR'),(6,2,'Старикова Елена Павловна','wpmrc3do@tutanota.com','RSbvHv'),(7,3,'Михайлюк Анна Вячеславовна','5d4zbu@tutanota.com','rwVDh9'),(8,3,'Ситдикова Елена Анатольевна','ptec8ym@yahoo.com','LdNyos'),(9,3,'Ворсин Петр Евгеньевич','1qz4kw@mail.com','gynQMT'),(10,3,'Старикова Елена Павловна','4np6se@mail.com','AtnDjr');
/*!40000 ALTER TABLE `пользователь` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `поставщики`
--

DROP TABLE IF EXISTS `поставщики`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `поставщики` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `поставщики`
--

LOCK TABLES `поставщики` WRITE;
/*!40000 ALTER TABLE `поставщики` DISABLE KEYS */;
INSERT INTO `поставщики` VALUES (1,'Kari'),(2,'Обувь для вас');
/*!40000 ALTER TABLE `поставщики` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `производитель`
--

DROP TABLE IF EXISTS `производитель`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `производитель` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `производитель`
--

LOCK TABLES `производитель` WRITE;
/*!40000 ALTER TABLE `производитель` DISABLE KEYS */;
INSERT INTO `производитель` VALUES (5,'Alessio Nesca'),(6,'CROSBY'),(1,'Kari'),(2,'Marco Tozzi'),(4,'Rieker'),(3,'Рос');
/*!40000 ALTER TABLE `производитель` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `пункт_выдачи`
--

DROP TABLE IF EXISTS `пункт_выдачи`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `пункт_выдачи` (
  `id_pick_up_point` int NOT NULL AUTO_INCREMENT,
  `adress` varchar(245) NOT NULL,
  PRIMARY KEY (`id_pick_up_point`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `пункт_выдачи`
--

LOCK TABLES `пункт_выдачи` WRITE;
/*!40000 ALTER TABLE `пункт_выдачи` DISABLE KEYS */;
INSERT INTO `пункт_выдачи` VALUES (1,'420151, г. Лесной, ул. Вишневая, 32'),(2,'125061, г. Лесной, ул. Подгорная, 8'),(3,'630370, г. Лесной, ул. Шоссейная, 24'),(4,'400562, г. Лесной, ул. Зеленая, 32'),(5,'614510, г. Лесной, ул. Маяковского, 47'),(6,'410542, г. Лесной, ул. Светлая, 46'),(7,'620839, г. Лесной, ул. Цветочная, 8'),(8,'443890, г. Лесной, ул. Коммунистическая, 1'),(9,'603379, г. Лесной, ул. Спортивная, 46'),(10,'603721, г. Лесной, ул. Гоголя, 41'),(11,'410172, г. Лесной, ул. Северная, 13'),(12,'614611, г. Лесной, ул. Молодежная, 50'),(13,'454311, г.Лесной, ул. Новая, 19'),(14,'660007, г.Лесной, ул. Октябрьская, 19'),(15,'603036, г. Лесной, ул. Садовая, 4'),(16,'394060, г.Лесной, ул. Фрунзе, 43'),(17,'410661, г. Лесной, ул. Школьная, 50'),(18,'625590, г. Лесной, ул. Коммунистическая, 20'),(19,'625683, г. Лесной, ул. 8 Марта'),(20,'450983, г.Лесной, ул. Комсомольская, 26'),(21,'394782, г. Лесной, ул. Чехова, 3'),(22,'603002, г. Лесной, ул. Дзержинского, 28'),(23,'450558, г. Лесной, ул. Набережная, 30'),(24,'344288, г. Лесной, ул. Чехова, 1'),(25,'614164, г.Лесной,  ул. Степная, 30'),(26,'394242, г. Лесной, ул. Коммунистическая, 43'),(27,'660540, г. Лесной, ул. Солнечная, 25'),(28,'125837, г. Лесной, ул. Шоссейная, 40'),(29,'125703, г. Лесной, ул. Партизанская, 49'),(30,'625283, г. Лесной, ул. Победы, 46'),(31,'614753, г. Лесной, ул. Полевая, 35'),(32,'426030, г. Лесной, ул. Маяковского, 44'),(33,'450375, г. Лесной ул. Клубная, 44'),(34,'625560, г. Лесной, ул. Некрасова, 12'),(35,'630201, г. Лесной, ул. Комсомольская, 17'),(36,'190949, г. Лесной, ул. Мичурина, 26');
/*!40000 ALTER TABLE `пункт_выдачи` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `роль сотрудника`
--

DROP TABLE IF EXISTS `роль сотрудника`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `роль сотрудника` (
  `id` int NOT NULL AUTO_INCREMENT,
  `роль` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `роль сотрудника`
--

LOCK TABLES `роль сотрудника` WRITE;
/*!40000 ALTER TABLE `роль сотрудника` DISABLE KEYS */;
INSERT INTO `роль сотрудника` VALUES (1,'Администратор'),(2,'Менеджер'),(3,'Авторизированный клиент');
/*!40000 ALTER TABLE `роль сотрудника` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `состав_заказа`
--

DROP TABLE IF EXISTS `состав_заказа`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `состав_заказа` (
  `id_order_structure` int NOT NULL,
  `id_order` int NOT NULL,
  `article` varchar(10) NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`id_order_structure`),
  KEY `fk_order_idx` (`article`),
  KEY `fk_order_idx1` (`id_order`),
  CONSTRAINT `fk_article` FOREIGN KEY (`article`) REFERENCES `товар` (`article`),
  CONSTRAINT `fk_order` FOREIGN KEY (`id_order`) REFERENCES `заказ` (`id_order`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `состав_заказа`
--

LOCK TABLES `состав_заказа` WRITE;
/*!40000 ALTER TABLE `состав_заказа` DISABLE KEYS */;
INSERT INTO `состав_заказа` VALUES (1,1,'А112Т4',2),(2,1,'F635R4',2),(3,2,'H782T5',1),(4,2,'G783F5',1),(5,3,'J384T6',10),(6,3,'D572U8',10),(7,4,'F572H7',5),(8,4,'D329H3',4),(9,5,'А112Т4',2),(10,5,'F635R4',4),(11,6,'H782T5',1),(12,6,'G783F5',1),(13,7,'J384T6',10),(14,7,'D572U8',10),(15,8,'F572H7',5),(16,8,'D329H3',4),(17,9,'B320R5',5),(18,9,'G432E4',1),(19,10,'S213E3',5),(20,10,'E482R4',5);
/*!40000 ALTER TABLE `состав_заказа` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `статус_зак`
--

DROP TABLE IF EXISTS `статус_зак`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `статус_зак` (
  `id_status` int NOT NULL AUTO_INCREMENT,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `статус_зак`
--

LOCK TABLES `статус_зак` WRITE;
/*!40000 ALTER TABLE `статус_зак` DISABLE KEYS */;
INSERT INTO `статус_зак` VALUES (1,'Завершен'),(2,'Новый');
/*!40000 ALTER TABLE `статус_зак` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `товар`
--

DROP TABLE IF EXISTS `товар`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `товар` (
  `article` varchar(10) NOT NULL,
  `name` varchar(150) NOT NULL,
  `unit_id` int NOT NULL,
  `supplier_id` int NOT NULL,
  `manufacturer_id` int NOT NULL,
  `category_id` int NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `discount_percent` int DEFAULT '0',
  `stock_quantity` int DEFAULT '0',
  `description` text,
  `photo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`article`),
  UNIQUE KEY `article` (`article`),
  KEY `unit_id` (`unit_id`),
  KEY `supplier_id` (`supplier_id`),
  KEY `manufacturer_id` (`manufacturer_id`),
  KEY `category_id` (`category_id`),
  CONSTRAINT `товар_ibfk_1` FOREIGN KEY (`unit_id`) REFERENCES `единицы_изм` (`id`),
  CONSTRAINT `товар_ibfk_2` FOREIGN KEY (`supplier_id`) REFERENCES `поставщики` (`id`),
  CONSTRAINT `товар_ibfk_3` FOREIGN KEY (`manufacturer_id`) REFERENCES `производитель` (`id`),
  CONSTRAINT `товар_ibfk_4` FOREIGN KEY (`category_id`) REFERENCES `категориятовара` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `товар`
--

LOCK TABLES `товар` WRITE;
/*!40000 ALTER TABLE `товар` DISABLE KEYS */;
INSERT INTO `товар` VALUES ('B320R5','Туфли',1,1,4,1,4300.00,2,6,'Туфли Rieker женские демисезонные, размер 41, цвет коричневый','9.jpg'),('B431R5','Ботинки',1,2,4,2,2700.00,2,5,'Мужские кожаные ботинки/мужские ботинки',''),('C436G5','Ботинки',1,1,5,1,10200.00,15,9,'Ботинки женские, ARGO, размер 40',''),('D268G5','Туфли',1,2,4,1,4399.00,3,12,'Туфли Rieker женские демисезонные, размер 36, цвет коричневый',''),('D329H3','Полуботинки',1,2,5,1,1890.00,4,4,'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый','8.jpg'),('D364R4','Туфли',1,1,1,1,12400.00,16,5,'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши',''),('D572U8','Кроссовки',1,2,3,2,4100.00,3,6,'129615-4 Кроссовки мужские','6.jpg'),('E482R4','Полуботинки',1,1,1,1,1800.00,2,14,'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный',''),('F427R5','Ботинки',1,2,4,1,11800.00,15,11,'Ботинки на молнии с декоративной пряжкой FRAU',''),('F572H7','Туфли',1,1,2,1,2700.00,2,14,'Туфли Marco Tozzi женские летние, размер 39, цвет черный','7.jpg'),('F635R4','Ботинки',1,2,2,1,3244.00,2,13,'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый','2.jpg'),('G432E4','Туфли',1,1,1,1,2800.00,3,15,'Туфли kari женские TR-YR-413017, размер 37, цвет: черный','10.jpg'),('G531F4','Ботинки',1,1,1,1,6600.00,12,9,'Ботинки женские зимние ROMER арт. 893167-01 Черный',''),('G783F5','Ботинки',1,1,3,2,5900.00,2,8,'Мужские ботинки Рос-Обувь кожаные с натуральным мехом','4.jpg'),('H535R5','Ботинки',1,2,4,1,2300.00,2,7,'Женские Ботинки демисезонные',''),('H782T5','Туфли',1,1,1,2,4499.00,4,5,'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный','3.jpg'),('J384T6','Ботинки',1,2,4,2,3800.00,2,16,'B3430/14 Полуботинки мужские Rieker','5.jpg'),('J542F5','Тапочки',1,1,1,2,500.00,13,0,'Тапочки мужские Арт.70701-55-67син р.41',''),('K345R4','Полуботинки',1,2,6,2,2100.00,2,3,'407700/01-02 Полуботинки мужские CROSBY',''),('K358H6','Тапочки',1,1,4,2,599.00,20,2,'Тапочки мужские син р.41',''),('L754R4','Полуботинки',1,1,1,1,1700.00,2,7,'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный',''),('M542T5','Кроссовки',1,2,4,2,2800.00,18,3,'Кроссовки мужские TOFA',''),('N457T5','Полуботинки',1,1,6,1,4600.00,3,13,'Полуботинки Ботинки черные зимние, мех',''),('O754F4','Туфли',1,2,4,1,5400.00,4,18,'Туфли женские демисезонные Rieker артикул 55073-68/37',''),('P764G4','Туфли',1,1,6,1,6800.00,15,15,'Туфли женские, ARGO, размер 38',''),('S213E3','Полуботинки',1,2,6,2,2156.00,3,6,'407700/01-01 Полуботинки мужские CROSBY',''),('S326R5','Тапочки',1,2,6,2,9900.00,17,15,'Мужские кожаные тапочки \"Профиль С.Дали\" ',''),('S634B5','Кеды',1,2,6,2,5500.00,3,0,'Кеды Caprice мужские демисезонные, размер 42, цвет черный',''),('T324F5','Сапоги',1,1,6,1,4699.00,2,5,'Сапоги замша Цвет: синий',''),('А112Т4','Ботинки',1,1,1,1,4990.00,3,6,'Женские Ботинки демисезонные kari','1.jpg');
/*!40000 ALTER TABLE `товар` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-02-25 21:52:02
