-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: student_db
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `user_Id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=99838749 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (1,'joyce','12345'),(2,'mik','12345'),(3,'per','12345'),(4,'bem','12345'),(1334,'ebian','2345'),(999398,'Cris','123456'),(99838748,'Loterte','1234');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campus`
--

DROP TABLE IF EXISTS `campus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campus` (
  `campus_code` int NOT NULL,
  `campus_address` varchar(100) DEFAULT NULL,
  `campus_dean` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`campus_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campus`
--

LOCK TABLES `campus` WRITE;
/*!40000 ALTER TABLE `campus` DISABLE KEYS */;
INSERT INTO `campus` VALUES (1,'Manila','Mr. Clint Vergarra'),(2,'Pampanga','Ms. Santos'),(3,'Manila','Mr. Clint Vergarra'),(665,'Pilar','Dr.Santos'),(888,'Sorsogon','Mr. Cambri'),(901,'Albay','Dr. Milan'),(902,'Legazpi City ','Dr. Tanyag'),(903,'Sorsogon City','Dr. Almero'),(905,'Albay','Dr. Gomez'),(906,'Sorsogon City','Mr. Calzado'),(907,'Tabaco Albay','Dr. Silvestre'),(908,'Sorsogon','Dr. Cameron'),(909,'Sorsogon','Dr. Lee'),(9876,'Manila','Mr. Gonzalgo');
/*!40000 ALTER TABLE `campus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `course_department`
--

DROP TABLE IF EXISTS `course_department`;
/*!50001 DROP VIEW IF EXISTS `course_department`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `course_department` AS SELECT 
 1 AS `course_code`,
 1 AS `course_name`,
 1 AS `course_major`,
 1 AS `department_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `course_details`
--

DROP TABLE IF EXISTS `course_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `course_details` (
  `course_code` int NOT NULL,
  `course_name` varchar(100) DEFAULT NULL,
  `course_major` varchar(100) DEFAULT NULL,
  `tuition_fee_perSem` int DEFAULT NULL,
  `school_deptUnicode` int DEFAULT NULL,
  `cNo` int NOT NULL,
  PRIMARY KEY (`course_code`,`cNo`),
  KEY `course_details_ibfk_2` (`school_deptUnicode`),
  CONSTRAINT `course_details_ibfk_2` FOREIGN KEY (`school_deptUnicode`) REFERENCES `school_department` (`school_deptUnicode`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course_details`
--

LOCK TABLES `course_details` WRITE;
/*!40000 ALTER TABLE `course_details` DISABLE KEYS */;
INSERT INTO `course_details` VALUES (704,'BS Philosophy','',14999,804,4),(705,'BS Entrep','',1000,805,5),(706,'Nursing','',20999,806,6),(707,'Medicine','',30999,808,7),(711,'BSCS',NULL,5000,801,8),(712,'BSed','MATH',5000,802,2),(1616,'BS Architecture','None',22000,801,2),(6332,'BSED I','English',62225,801,12),(70986,'Food Tech','Food',90000,802,2),(90889,'BSED','Arts and Craft',12000,802,1),(202212,'ICT','Drafting',6999,804,16),(900564,'Bachelor of Science in Chemistry','Chemistry',18000,808,13),(20206731,'BSED','VALUES ED',12999,804,10),(20206732,'BSED','PE',10999,804,14),(20206734,'BSED','English',12999,804,10),(20206735,'BSED','Filipino',10999,804,14),(20206736,'BSED','Math',12999,804,10),(20206737,'BSED','Science',10999,804,14),(20222021,'BSIS','Acad',8999,804,14),(20222022,'BSIT','Animation',6999,804,10),(20222023,'HE','Baking',6999,804,10),(20232024,'','Acad',8999,804,14);
/*!40000 ALTER TABLE `course_details` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_tuition_after_insert` AFTER INSERT ON `course_details` FOR EACH ROW begin
if new.cno is not null then
update tuitionfeeupdate
set totaltuition = totaltuition + new.tuition_fee_perSem
where cNO= new.cNo;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tuition_after_update` AFTER UPDATE ON `course_details` FOR EACH ROW begin
if old.cNo is not null then 
update tuitionfeeupdate
set totaltuition = totaltuition - old.tuition_fee_perSem
where cNo = old.cNo; 
end if;
if new.cNo is not null then 
update tuitionfeeupdate
set totaltuition = totaltuition + new.tuition_fee_perSem
where cNo = new.cNo; 
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
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tuition_before_delete` BEFORE DELETE ON `course_details` FOR EACH ROW begin
if (old.cNo is not null) then
update tuitionfeeupdate
set totaltuition = totaltuition - old.tuition_fee_perSem 
where cNo = old.cNo; 
end if;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `individual_record`
--

DROP TABLE IF EXISTS `individual_record`;
/*!50001 DROP VIEW IF EXISTS `individual_record`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `individual_record` AS SELECT 
 1 AS `student_id`,
 1 AS `student_fullname`,
 1 AS `age`,
 1 AS `course_name`,
 1 AS `tuition_fee_perSem`,
 1 AS `course_major`,
 1 AS `campus_address`,
 1 AS `mother_fullname`,
 1 AS `mother_cNum`,
 1 AS `father_fullname`,
 1 AS `father_cNum`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `school_department`
--

DROP TABLE IF EXISTS `school_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `school_department` (
  `school_deptUnicode` int NOT NULL,
  `department_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`school_deptUnicode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `school_department`
--

LOCK TABLES `school_department` WRITE;
/*!40000 ALTER TABLE `school_department` DISABLE KEYS */;
INSERT INTO `school_department` VALUES (801,'College of Science'),(802,'College of Education'),(803,'College of Engineering'),(804,'College of Social Science'),(805,'College of Business'),(806,'College of Nursing'),(807,'College of Arts'),(808,'College of Medicine'),(809,'College of Industrial '),(899,'College of Forestry Guinobatan'),(9990,'College of Arts'),(11122,'IDEA'),(202023,'College of ICT');
/*!40000 ALTER TABLE `school_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `student_details`
--

DROP TABLE IF EXISTS `student_details`;
/*!50001 DROP VIEW IF EXISTS `student_details`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `student_details` AS SELECT 
 1 AS `student_id`,
 1 AS `student_fullname`,
 1 AS `age`,
 1 AS `course_name`,
 1 AS `tuition_fee_perSem`,
 1 AS `course_major`,
 1 AS `campus_address`,
 1 AS `mother_fullname`,
 1 AS `mother_cNum`,
 1 AS `father_fullname`,
 1 AS `father_cNum`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `student_guardian`
--

DROP TABLE IF EXISTS `student_guardian`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student_guardian` (
  `parents_code` int NOT NULL,
  `mother_fullname` varchar(100) DEFAULT NULL,
  `father_fullname` varchar(100) DEFAULT NULL,
  `mother_cNum` varchar(20) DEFAULT NULL,
  `father_cNum` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`parents_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_guardian`
--

LOCK TABLES `student_guardian` WRITE;
/*!40000 ALTER TABLE `student_guardian` DISABLE KEYS */;
INSERT INTO `student_guardian` VALUES (7869,'Annalyn Chu','Joseph Chu','09578954634','09087654345'),(32221,'Nelly Loterte','Alexander Loterte','09555666454','09555666454'),(32222,'Gina Asia ','Carlo Asia','09876548976','09867543897'),(32223,'Maria Santos','Gino Santos','09897879949','09876856678'),(32224,'Milda Pinto','Kam Pinto','09878966567','09890767545'),(32225,'Josana Cruz','Joey Cruz','09899999999','09088966645'),(32227,'Bridge Sy','Jose Sy','09834334567','09456389799'),(32228,'Angelina Claig','Saimon Claig','09123456789','09676897765'),(32229,'Mia Kang','Miu Kang','09765342445','09765342445'),(90011,'Reina Kuls','Rey Kuls','09768543290','09678546677'),(2022129,'Janna Kim','Lou Kim','9878768556','9756743212');
/*!40000 ALTER TABLE `student_guardian` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student_info`
--

DROP TABLE IF EXISTS `student_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student_info` (
  `student_id` int NOT NULL,
  `student_fullname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `address` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `course_code` int DEFAULT NULL,
  `campus_code` int DEFAULT NULL,
  `parents_code` int DEFAULT NULL,
  `age` int DEFAULT NULL,
  PRIMARY KEY (`student_id`),
  KEY `course_code` (`course_code`),
  KEY `campus_code` (`campus_code`),
  KEY `parents_code` (`parents_code`),
  CONSTRAINT `student_info_ibfk_1` FOREIGN KEY (`course_code`) REFERENCES `course_details` (`course_code`) ON DELETE SET NULL,
  CONSTRAINT `student_info_ibfk_2` FOREIGN KEY (`campus_code`) REFERENCES `campus` (`campus_code`) ON DELETE SET NULL,
  CONSTRAINT `student_info_ibfk_4` FOREIGN KEY (`parents_code`) REFERENCES `student_guardian` (`parents_code`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_info`
--

LOCK TABLES `student_info` WRITE;
/*!40000 ALTER TABLE `student_info` DISABLE KEYS */;
INSERT INTO `student_info` VALUES (20,'Joanna Tablate','Naga City',706,NULL,32221,19),(665,'Angelina Jolie','Italy',NULL,902,32227,31),(1156,'Mikaella Rue','',706,905,32228,15),(5664,'Konah Aiko','Baguio',705,905,32221,19),(53381,'Ann Joyce Loterte','Pilar',NULL,901,32221,20),(53383,'Ana Santos','Daraga',NULL,907,32223,22),(53384,'Sammy Pinto','Legazpi',704,906,32224,23),(53385,'Kirk Silva','Pilar',705,905,NULL,20),(53386,'Nathan Sy','Draga',706,NULL,32227,19),(53387,'Sabrina Claig','Legazpi',NULL,903,32228,25),(53388,'Jain Ang','Albay',NULL,902,32229,22),(129900,'Karl Andres','Caloocan ',705,905,32221,20),(20222333,'Lea Kim','China',706,905,32221,18);
/*!40000 ALTER TABLE `student_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tuitionfeeupdate`
--

DROP TABLE IF EXISTS `tuitionfeeupdate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tuitionfeeupdate` (
  `cNo` int NOT NULL,
  `totaltuition` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tuitionfeeupdate`
--

LOCK TABLES `tuitionfeeupdate` WRITE;
/*!40000 ALTER TABLE `tuitionfeeupdate` DISABLE KEYS */;
INSERT INTO `tuitionfeeupdate` VALUES (1,12000),(2,117000),(3,0),(4,14999),(5,1000),(6,20999),(1,12000),(7,30999),(9,0),(8,7000);
/*!40000 ALTER TABLE `tuitionfeeupdate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `course_department`
--

/*!50001 DROP VIEW IF EXISTS `course_department`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `course_department` AS select `cd`.`course_code` AS `course_code`,`cd`.`course_name` AS `course_name`,`cd`.`course_major` AS `course_major`,`sd`.`department_name` AS `department_name` from (`course_details` `cd` join `school_department` `sd` on((`cd`.`school_deptUnicode` = `sd`.`school_deptUnicode`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `individual_record`
--

/*!50001 DROP VIEW IF EXISTS `individual_record`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `individual_record` AS select `s`.`student_id` AS `student_id`,`s`.`student_fullname` AS `student_fullname`,`s`.`age` AS `age`,`cd`.`course_name` AS `course_name`,`cd`.`tuition_fee_perSem` AS `tuition_fee_perSem`,`cd`.`course_major` AS `course_major`,`cp`.`campus_address` AS `campus_address`,`sg`.`mother_fullname` AS `mother_fullname`,`sg`.`mother_cNum` AS `mother_cNum`,`sg`.`father_fullname` AS `father_fullname`,`sg`.`father_cNum` AS `father_cNum` from (((`student_info` `s` join `course_details` `cd` on((`s`.`course_code` = `cd`.`course_code`))) join `campus` `cp` on((`s`.`campus_code` = `cp`.`campus_code`))) join `student_guardian` `sg` on((`s`.`parents_code` = `sg`.`parents_code`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `student_details`
--

/*!50001 DROP VIEW IF EXISTS `student_details`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `student_details` AS select `s`.`student_id` AS `student_id`,`s`.`student_fullname` AS `student_fullname`,`s`.`age` AS `age`,`cd`.`course_name` AS `course_name`,`cd`.`tuition_fee_perSem` AS `tuition_fee_perSem`,`cd`.`course_major` AS `course_major`,`cp`.`campus_address` AS `campus_address`,`sg`.`mother_fullname` AS `mother_fullname`,`sg`.`mother_cNum` AS `mother_cNum`,`sg`.`father_fullname` AS `father_fullname`,`sg`.`father_cNum` AS `father_cNum` from (((`student_info` `s` join `course_details` `cd` on((`s`.`course_code` = `cd`.`course_code`))) join `campus` `cp` on((`s`.`campus_code` = `cp`.`campus_code`))) join `student_guardian` `sg` on((`s`.`parents_code` = `sg`.`parents_code`))) */;
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

-- Dump completed on 2023-04-16  9:38:38
