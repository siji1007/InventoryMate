-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 28, 2024 at 07:45 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorymate`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Cust_ID` int(11) NOT NULL,
  `Cust_name` varchar(50) NOT NULL,
  `Cust_address` varchar(50) NOT NULL,
  `Cust_email` varchar(30) NOT NULL,
  `Cust_cnumber` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Cust_ID`, `Cust_name`, `Cust_address`, `Cust_email`, `Cust_cnumber`) VALUES
(2, 'CHRISTIAN JOHN IBANEZ', 'TALISAY, CAMARINES NORTE', 'CJ@GMAIL.COM', '9079519214'),
(3, 'KIAN ARVEN BADING', 'PARACALE, CAMARINES NORTE', 'KIAN@GMAIL.COM', '9896473829'),
(4, 'PAUL ANDREI CAFE', 'LABO, CAMARINES NORTE', 'CAFE@GMAIL.COM', '9878998711'),
(5, 'CHARLES PINO', 'GABON', 'CHARLES@GMAIL.COM', '9086567654'),
(6, 'CJAY', 'GABON', 'HAHA@GMAIL.COM', '9079519214'),
(7, 'CJ', 'GABON', 'CJ@GMAIL.COM', '9079519214'),
(8, 'CJ POGI', 'GABON', 'CJ@GMAIL.COM', '9079519214'),
(9, 'EDIWOW', 'GABON', 'JAN@GMAIL.COM', '9079519214'),
(10, 'iSAAC', 'asd', 'asd', '9079519214'),
(11, '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Emp_ID` int(11) NOT NULL,
  `Emp_name` varchar(50) NOT NULL,
  `Emp_address` varchar(50) NOT NULL,
  `Emp_cnumber` bigint(30) NOT NULL,
  `Emp_bdate` date NOT NULL,
  `Emp_status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`Emp_ID`, `Emp_name`, `Emp_address`, `Emp_cnumber`, `Emp_bdate`, `Emp_status`) VALUES
(1, 'CHRISTIAN JOHN IBANEZ', 'ASDASD', 9079519214, '2024-04-17', ''),
(2, 'CJ', 'TALISAY', 9079519214, '2024-04-19', 'ACTIVE'),
(4, 'Christian John Ibanez', 'Talisay, Camarines Norte', 9079519214, '2024-04-25', 'ACTIVE'),
(5, 'Christian John D. Ibanez', 'Talisay, Camarines Norte', 9079519215, '2003-10-07', 'ACTIVE'),
(6, 'SIJI', 'Talisay', 9079519214, '2024-04-09', 'ACTIVE'),
(7, 'CJ', 'talisay', 98098, '2024-04-25', 'ACTIVE'),
(8, 'Clarence Portugal', 'Talisay', 9079519214, '2004-12-15', 'ACTIVE'),
(9, 'Paul Andrei Cafe', 'Labo', 9394878347, '2003-07-11', 'ACTIVE'),
(10, 'Cherry Joy Bas', 'Pamorangon', 90901921, '2024-04-25', 'ACTIVE'),
(11, 'Christian John Ibanez', 'Talisay', 9079519214, '2003-10-07', 'ACTIVE'),
(12, 'SiJi POGI', 'Talisay, Camarines Norte', 9079519214, '2003-10-07', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `prod_id` int(11) NOT NULL,
  `Warranty_ID` int(11) NOT NULL,
  `prod_name` varchar(120) NOT NULL,
  `prod_model` varchar(50) NOT NULL,
  `prod_color` varchar(10) DEFAULT NULL,
  `prod_stocks` int(15) NOT NULL,
  `prod_price` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`prod_id`, `Warranty_ID`, `prod_name`, `prod_model`, `prod_color`, `prod_stocks`, `prod_price`) VALUES
(1, 2, 'LAKSJDJ', 'ALSKDJSALKJD', 'ALSKJDLAKS', 0, 2),
(4, 2, 'SAMSUNG', 'S9', 'BLACK', 1, 8900),
(7, 3, 'REALME', 'C11', 'BLACK', 0, 2400),
(8, 2, 'NOKIA', 'C20', 'BLACK', 7, 3000);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `Supp_ID` int(11) NOT NULL,
  `Supp_name` varchar(50) NOT NULL,
  `Supp_store` varchar(50) NOT NULL,
  `Supp_address` varchar(50) NOT NULL,
  `Supp_email` varchar(20) NOT NULL,
  `Supp_cnumber` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Supp_ID`, `Supp_name`, `Supp_store`, `Supp_address`, `Supp_email`, `Supp_cnumber`) VALUES
(1, 'ASDAS', 'ASDASD', 'ASDASD', 'ASDASD', '9070519214'),
(2, 'CHRISTIAN JOHN IBANEZ', 'COFE', 'TALISAY', 'CJ@GMAIL.COM', '9079519214');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `Transac_ID` int(11) NOT NULL,
  `Prod_ID` int(11) NOT NULL,
  `Customer_ID` int(11) NOT NULL,
  `Emp_ID` int(11) NOT NULL,
  `Warr_ID` int(11) NOT NULL,
  `Quantity` int(2) NOT NULL,
  `S_fee` int(6) NOT NULL,
  `Total_cost` int(6) NOT NULL,
  `Transact_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`Transac_ID`, `Prod_ID`, `Customer_ID`, `Emp_ID`, `Warr_ID`, `Quantity`, `S_fee`, `Total_cost`, `Transact_date`) VALUES
(1, 7, 3, 9, 3, 1, 2, 2402, '2024-04-27 00:00:00'),
(2, 7, 3, 9, 3, 2, 100, 4900, '2024-04-27 10:59:35'),
(3, 7, 3, 8, 3, 2, 1, 4801, '2024-04-27 11:23:59'),
(4, 4, 5, 2, 2, 1, 9, 8909, '2024-04-27 11:43:06'),
(5, 4, 5, 2, 2, 1, 9, 13709, '2024-04-27 11:43:46'),
(6, 7, 5, 2, 3, 2, 9, 13709, '2024-04-27 11:43:46'),
(7, 8, 4, 10, 2, 1, 1, 3001, '2024-04-28 02:40:14'),
(9, 7, 3, 9, 3, 1, 1, 2401, '2024-04-28 02:44:01'),
(10, 4, 6, 8, 2, 2, 10, 17810, '2024-04-28 06:39:03'),
(11, 4, 6, 8, 2, 2, 10, 17810, '2024-04-28 06:39:24'),
(12, 4, 6, 8, 2, 2, 10, 22610, '2024-04-28 06:39:50'),
(13, 7, 6, 8, 3, 2, 10, 22610, '2024-04-28 06:39:50'),
(14, 4, 5, 8, 2, 1, 10, 8910, '2024-04-28 06:55:16'),
(15, 7, 3, 1, 3, 2, 10, 4810, '2024-04-28 07:00:19'),
(16, 7, 4, 10, 3, 1, 1, 2401, '2024-04-28 07:05:20'),
(17, 4, 3, 2, 2, 1, 1, 8901, '2024-04-28 07:06:55'),
(18, 4, 2, 10, 2, 1, 1, 8901, '2024-04-28 07:09:02'),
(19, 4, 4, 10, 2, 1, 1, 8901, '2024-04-28 07:11:20'),
(20, 7, 3, 8, 3, 1, 1, 2401, '2024-04-28 07:14:03'),
(21, 8, 5, 2, 2, 1, 2, 3002, '2024-04-28 07:15:27'),
(22, 8, 2, 9, 2, 2, 100, 15000, '2024-04-28 07:18:48'),
(23, 4, 2, 9, 2, 1, 100, 15000, '2024-04-28 07:18:48'),
(24, 8, 5, 10, 2, 2, 100, 10900, '2024-04-28 07:20:45'),
(25, 7, 5, 10, 3, 2, 100, 10900, '2024-04-28 07:20:45'),
(26, 7, 5, 1, 3, 2, 100, 4900, '2024-04-28 07:25:39'),
(27, 7, 2, 8, 3, 1, 100, 2500, '2024-04-28 07:27:44'),
(28, 7, 6, 8, 3, 4, 100, 9700, '2024-04-28 07:36:57'),
(29, 7, 5, 5, 3, 1, 100, 2500, '2024-04-28 07:38:51'),
(30, 4, 5, 8, 2, 2, 100, 17900, '2024-04-28 07:41:13'),
(31, 8, 5, 2, 2, 1, 1, 3001, '2024-04-28 07:44:42'),
(32, 8, 5, 9, 2, 2, 10, 6010, '2024-04-28 07:47:09'),
(33, 7, 5, 8, 3, 2, 1, 4801, '2024-04-28 07:51:47'),
(34, 8, 2, 9, 2, 1, 1, 3001, '2024-04-28 07:57:26'),
(35, 8, 3, 10, 2, 1, 10, 3010, '2024-04-28 08:06:29'),
(36, 8, 4, 9, 2, 1, 1, 3001, '2024-04-28 08:08:08'),
(37, 7, 2, 10, 3, 2, 8, 4808, '2024-04-28 08:09:47'),
(38, 7, 3, 2, 3, 2, 1, 4801, '2024-04-28 08:15:12'),
(39, 7, 5, 8, 3, 1, 1, 2401, '2024-04-28 08:19:03'),
(40, 7, 4, 2, 3, 1, 1, 2401, '2024-04-28 08:20:55'),
(41, 7, 6, 2, 3, 1, 10, 2410, '2024-04-28 08:24:31'),
(42, 7, 4, 9, 3, 1, 2, 2402, '2024-04-28 08:27:10'),
(44, 4, 10, 8, 2, 2, 1, 17801, '2024-04-28 08:46:58'),
(46, 4, 2, 8, 2, 1, 200, 15100, '2024-04-28 13:38:12'),
(47, 8, 2, 8, 2, 2, 200, 15100, '2024-04-28 13:38:12'),
(48, 4, 2, 8, 2, 1, 200, 15100, '2024-04-28 13:38:51'),
(49, 8, 2, 8, 2, 2, 200, 15100, '2024-04-28 13:38:51');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Employee_ID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `PasswordHash` varchar(65) DEFAULT NULL,
  `Privilege` enum('ADMIN','OWNER','EMPLOYEE') DEFAULT NULL,
  `Status` enum('ACTIVE','OFFLINE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Employee_ID`, `UserID`, `Username`, `PasswordHash`, `Privilege`, `Status`) VALUES
(11, 10, 'ADMIN', '835d6dc88b708bc646d6db82c853ef4182fabbd4a8de59c213f2b5ab3ae7d9be', 'ADMIN', 'ACTIVE'),
(12, 11, 'siji', '9b58bcc9dd9e3a5b32bfe0e309237042ab205b5a6e1538caebf5fd4c21517b91', 'EMPLOYEE', 'OFFLINE');

-- --------------------------------------------------------

--
-- Table structure for table `warranty`
--

CREATE TABLE `warranty` (
  `War_ID` int(11) NOT NULL,
  `War_Duration` int(11) DEFAULT NULL,
  `War_DurationUnit` enum('Days','Months','Years') DEFAULT NULL,
  `War_Type` enum('Limited Warranty','Service Warranty','Extended Warranty','Parts Warranty') DEFAULT NULL,
  `War_Status` enum('Active','Expired') DEFAULT NULL,
  `War_Coverage` enum('Parts','Labor') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `warranty`
--

INSERT INTO `warranty` (`War_ID`, `War_Duration`, `War_DurationUnit`, `War_Type`, `War_Status`, `War_Coverage`) VALUES
(1, 1, 'Months', 'Limited Warranty', 'Active', 'Parts'),
(2, 30, 'Days', 'Service Warranty', 'Active', 'Labor'),
(3, 50, 'Years', 'Extended Warranty', 'Expired', 'Parts');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Cust_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Emp_ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`prod_id`),
  ADD KEY `fk_warranty_id` (`Warranty_ID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Supp_ID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`Transac_ID`),
  ADD KEY `Prod_connection` (`Prod_ID`),
  ADD KEY `Emp_connection` (`Emp_ID`),
  ADD KEY `Customer_Connection` (`Customer_ID`),
  ADD KEY `Warranty_connection` (`Warr_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD KEY `Employee_ID` (`Employee_ID`);

--
-- Indexes for table `warranty`
--
ALTER TABLE `warranty`
  ADD PRIMARY KEY (`War_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `Cust_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `Emp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `prod_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `Supp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `Transac_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `fk_warranty_id` FOREIGN KEY (`Warranty_ID`) REFERENCES `warranty` (`War_ID`),
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`Warranty_ID`) REFERENCES `warranty` (`War_ID`);

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `Customer_Connection` FOREIGN KEY (`Customer_ID`) REFERENCES `customer` (`Cust_ID`),
  ADD CONSTRAINT `Emp_connection` FOREIGN KEY (`Emp_ID`) REFERENCES `employee` (`Emp_ID`),
  ADD CONSTRAINT `Prod_connection` FOREIGN KEY (`Prod_ID`) REFERENCES `products` (`prod_id`),
  ADD CONSTRAINT `Warranty_connection` FOREIGN KEY (`Warr_ID`) REFERENCES `warranty` (`War_ID`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`Employee_ID`) REFERENCES `employee` (`Emp_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
