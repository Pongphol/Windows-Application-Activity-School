-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: db_activity
-- ------------------------------------------------------
-- Server version	5.7.13-log

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
-- Table structure for table `tbl_activity`
--

DROP TABLE IF EXISTS `tbl_activity`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_activity` (
  `act_id` int(11) NOT NULL AUTO_INCREMENT,
  `n_act` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `date_act` date DEFAULT NULL,
  `act_img` longblob,
  PRIMARY KEY (`act_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1005 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_activity`
--

LOCK TABLES `tbl_activity` WRITE;
/*!40000 ALTER TABLE `tbl_activity` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_activity` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_check_std_act`
--

DROP TABLE IF EXISTS `tbl_check_std_act`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_check_std_act` (
  `id_chek_ai` bigint(11) NOT NULL AUTO_INCREMENT,
  `std_id` bigint(11) DEFAULT NULL,
  `act_id` int(11) DEFAULT NULL,
  `class_id` int(11) DEFAULT NULL,
  `dep_id` int(11) DEFAULT NULL,
  `status_std_act` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `log_msg` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_chek_ai`),
  KEY `fore_check_std_idx` (`std_id`),
  KEY `fore_check_act_idx` (`act_id`),
  KEY `fore_check_class_idx` (`class_id`),
  KEY `fore_check_dep_idx` (`dep_id`),
  CONSTRAINT `fore_check_act` FOREIGN KEY (`act_id`) REFERENCES `tbl_activity` (`act_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fore_check_class` FOREIGN KEY (`class_id`) REFERENCES `tbl_class` (`class_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fore_check_dep` FOREIGN KEY (`dep_id`) REFERENCES `tbl_department` (`dep_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fore_check_std` FOREIGN KEY (`std_id`) REFERENCES `tbl_student` (`std_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_check_std_act`
--

LOCK TABLES `tbl_check_std_act` WRITE;
/*!40000 ALTER TABLE `tbl_check_std_act` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_check_std_act` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_class`
--

DROP TABLE IF EXISTS `tbl_class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_class` (
  `class_id` int(11) NOT NULL AUTO_INCREMENT,
  `class_name` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `dep_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`class_id`),
  KEY `fore_class_dep_idx` (`dep_id`),
  CONSTRAINT `fore_class_dep` FOREIGN KEY (`dep_id`) REFERENCES `tbl_department` (`dep_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=526 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_class`
--

LOCK TABLES `tbl_class` WRITE;
/*!40000 ALTER TABLE `tbl_class` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_department`
--

DROP TABLE IF EXISTS `tbl_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_department` (
  `dep_id` int(11) NOT NULL AUTO_INCREMENT,
  `dep_n` varchar(45) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`dep_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1024 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_department`
--

LOCK TABLES `tbl_department` WRITE;
/*!40000 ALTER TABLE `tbl_department` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_log`
--

DROP TABLE IF EXISTS `tbl_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_log` (
  `log_id` bigint(11) NOT NULL AUTO_INCREMENT,
  `log_user` varchar(50) DEFAULT NULL,
  `log_date` datetime DEFAULT NULL,
  `log_operation` longtext,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_log`
--

LOCK TABLES `tbl_log` WRITE;
/*!40000 ALTER TABLE `tbl_log` DISABLE KEYS */;
INSERT INTO `tbl_log` VALUES (1,'fluk','2016-07-13 17:24:40','ลบอาจารย์ที่ปรึกษาสาขา : เทคโนโลยีสารสนเทศ | ระดับชั้น : ปวส.1'),(2,'fluk','2016-07-13 17:24:42','ลบอาจารย์ที่ปรึกษาสาขา : การตลาด | ระดับชั้น : ปวช.3'),(3,'fluk','2016-07-13 17:24:44','ลบอาจารย์ที่ปรึกษาสาขา : เทคโนโลยีสารสนเทศ | ระดับชั้น : ปวส.2'),(4,'fluk','2016-07-13 17:24:49','ลบระดับชั้น : ปวช.3 | ของสาขา : การตลาด'),(5,'fluk','2016-07-13 17:24:50','ลบระดับชั้น : ปวส.1 | ของสาขา : เทคโนโลยีสารสนเทศ'),(6,'fluk','2016-07-13 17:24:52','ลบระดับชั้น : ปวส.2 | ของสาขา : เทคโนโลยีสารสนเทศ'),(7,'fluk','2016-07-13 17:24:55','ลบสาขา : เทคโนโลยีสารสนเทศ'),(8,'fluk','2016-07-13 17:24:56','ลบสาขา : การตลาด'),(9,'fluk','2016-07-13 17:25:02','ลบกิจกรรม : วันวิชาการ'),(10,'fluk','2016-07-13 17:25:03','ลบกิจกรรม : แจีะ'),(11,'fluk','2016-07-13 17:25:05','ออกจากระบบ'),(12,'fluk','2016-07-13 17:25:09','เข้าสู่ระบบ'),(13,'fluk','2016-07-13 17:25:09','ออกจากระบบ');
/*!40000 ALTER TABLE `tbl_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_student`
--

DROP TABLE IF EXISTS `tbl_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_student` (
  `std_id` bigint(11) NOT NULL AUTO_INCREMENT,
  `std_title` varchar(10) CHARACTER SET utf8 NOT NULL,
  `std_fname` varchar(50) CHARACTER SET utf8 NOT NULL,
  `std_lname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `class_id` int(11) DEFAULT NULL,
  `dep_id` int(11) DEFAULT NULL,
  `teacher_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`std_id`),
  KEY `fore_std_dep_idx` (`dep_id`),
  KEY `fore_std_class_idx` (`class_id`),
  KEY `fore_std_teacher_idx` (`teacher_id`),
  CONSTRAINT `fore_std_class` FOREIGN KEY (`class_id`) REFERENCES `tbl_class` (`class_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fore_std_dep` FOREIGN KEY (`dep_id`) REFERENCES `tbl_department` (`dep_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fore_std_teacher` FOREIGN KEY (`teacher_id`) REFERENCES `tbl_teacher` (`teacher_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5939010027 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_student`
--

LOCK TABLES `tbl_student` WRITE;
/*!40000 ALTER TABLE `tbl_student` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_teacher`
--

DROP TABLE IF EXISTS `tbl_teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_teacher` (
  `teacher_id` int(11) NOT NULL AUTO_INCREMENT,
  `teacher_fname` varchar(50) CHARACTER SET utf8 NOT NULL,
  `teacher_lname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `class_id` int(11) DEFAULT NULL,
  `dep_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`teacher_id`),
  KEY `fore_teacher_dep_idx` (`dep_id`),
  KEY `fore_teacher_class_idx` (`class_id`),
  CONSTRAINT `fore_teacher_class` FOREIGN KEY (`class_id`) REFERENCES `tbl_class` (`class_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fore_teacher_dep` FOREIGN KEY (`dep_id`) REFERENCES `tbl_department` (`dep_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1023 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_teacher`
--

LOCK TABLES `tbl_teacher` WRITE;
/*!40000 ALTER TABLE `tbl_teacher` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_teacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `status` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES (1,'fluk','1234','admin'),(2,'user1','dddd','user'),(3,'userasda','1121d','user'),(4,'asda','asdad','user'),(6,'asdas','asdad','user'),(7,'yukiart','lnwza','user'),(8,'asdad','asdsa','user');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-13 17:25:53
