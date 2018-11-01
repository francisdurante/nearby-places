-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 17, 2018 at 01:31 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `id6605923_nearbyplaces`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_estabalishment_user`
--

CREATE TABLE `tbl_estabalishment_user` (
  `id` int(11) NOT NULL,
  `username` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `status` int(6) NOT NULL,
  `date_created` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_estabalishment_user`
--

INSERT INTO `tbl_estabalishment_user` (`id`, `username`, `password`, `status`, `date_created`) VALUES
(2, 'francis', '$2y$10$yJQrwa2PYX64tV1p5Fjf4eygizDm3fhal/8h4.sqyp5LjrIR0EkSS', 1, '2018-10-08'),
(30, 'qwteriu', '$2y$10$.orowxwRJT0157ZDSTTTcemj9D0dO8RehMVRTcnkxJ.bW27fvG4um', 1, '2018-10-09'),
(31, 'qwrteriu', '$2y$10$/yV6UBVlnqomehIMLQOL2e3AaB/ruMjBP8fIZmrMKT7FqdzBGq4CO', 1, '2018-10-09'),
(32, 'qwreteriu', '$2y$10$Njbjag0OQH.Wn2P7VDD3/ebXR4eDIG1fxA5aaPu8q1JXzh7BJX5zy', 1, '2018-10-09'),
(33, 'qwredteriu', '$2y$10$astvvrwvzrT.CQK5Kwnaa./rjOWne/Zn9wN7DiHObQvO2flc6ip7K', 1, '2018-10-09'),
(34, 'faaaaaaaa', '$2y$10$OcqfIkTyQqUqwIi3hJ.q6e0yv8Si6K0SmbXBmCU0zQZUhKU4hOqve', 1, '2018-10-09'),
(35, 'review1', '$2y$10$vKFypro18quWiFm6EIadWeNkwQflzKkNYoFrmNzBvM8p97zANl/He', 1, '2018-10-09'),
(36, 'review000', '$2y$10$8oFySyV0BjnG2wlpwM031.mrJKIHByDRrMdE1zuobepu1U4ECLM4e', 1, '2018-10-09'),
(37, 'review0001', '$2y$10$vZhrb7.weYqy9xnxBIZFv.aqOOhiebuoxXXr9J3cNoxaxfWoAwOra', 1, '2018-10-16'),
(38, 'review00001', '$2y$10$REXq.yjl7.QzBVEZJYm/Uus/oJm155iTGJMEeq.qgWmOXMQOq9tE6', 1, '2018-10-16'),
(39, 'chaba@gmail.com', '$2y$10$e0Tdm3DVQDB8bsWmONE32.bt2XtpVazAqqGa94cZip2fWv1PHingK', 1, '2018-10-17'),
(40, 'review123', '$2y$10$w7fQjdl70BcRx2oFa5tuX..t6a5KyVU3dC4GntIvt6pNUAYCCAcqa', 1, '2018-10-17'),
(41, 'Test123', '$2y$10$xO3fCjrEAKSmocB.wNSR3.LpWmrOMRRPqcbwisgSA67dRchpqz6ga', 1, '2018-10-17');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_establishment`
--

CREATE TABLE `tbl_establishment` (
  `id` int(11) NOT NULL,
  `establishment_user_id` int(11) NOT NULL,
  `establishment_name` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `location_latitude` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `location_longitude` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `good_for_emotion_of` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `good_at_of` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `date_created` date DEFAULT NULL,
  `est_type_id` int(11) DEFAULT NULL,
  `est_front_store` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_establishment`
--

INSERT INTO `tbl_establishment` (`id`, `establishment_user_id`, `establishment_name`, `location_latitude`, `location_longitude`, `good_for_emotion_of`, `good_at_of`, `status`, `date_created`, `est_type_id`, `est_front_store`) VALUES
(1, 30, 'francisres', '.12457851000', '.45412265874', 'all', 'all', 1, NULL, NULL, NULL),
(2, 34, 'francisres', '.12457851000', '.45412265874', 'all', 'all', 1, NULL, NULL, NULL),
(3, 35, 'francisres', '.45412265874', NULL, 'all', 'all', 1, '2018-10-09', NULL, NULL),
(4, 36, 'Francis kaininan', '1.25555555555', '1.02154876', 'HAPPY', 'CHILDREN', 1, '2018-10-09', NULL, NULL),
(5, 38, 'Test', '21321321', '2313213', 'ALL', 'ALL', 1, '2018-10-16', 1, NULL),
(6, 39, 'Jollibee', NULL, NULL, 'HAPPY', 'YOUTH (15 - 24 years old)', 1, '2018-10-17', 2, NULL),
(7, 40, 'Test123', '12321', '12312', 'ALL', 'ALL', 1, '2018-10-17', 1, '/storage/ssd5/923/6605923/public_html/images/Test123-1539781976.jpg'),
(8, 41, 'Test123', '1122', '123145', 'ALL', 'ALL', 1, '2018-10-17', 2, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_est_type`
--

CREATE TABLE `tbl_est_type` (
  `id` int(11) NOT NULL,
  `est_type_name` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` int(11) DEFAULT '1',
  `date_created` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_est_type`
--

INSERT INTO `tbl_est_type` (`id`, `est_type_name`, `status`, `date_created`) VALUES
(1, 'Coffe Shop', 1, '2018-10-16 19:36:36'),
(2, 'Restaurant', 1, '2018-10-16 20:28:09'),
(3, 'COFFEE SHOP', 1, '2018-10-17 12:12:06');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_menu_category`
--

CREATE TABLE `tbl_menu_category` (
  `id` int(11) NOT NULL,
  `category_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `added_by` int(11) DEFAULT NULL,
  `status` int(11) DEFAULT '1',
  `date_created` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_menu_category`
--

INSERT INTO `tbl_menu_category` (`id`, `category_name`, `added_by`, `status`, `date_created`) VALUES
(1, 'Dessert', 36, 1, '2018-10-10 00:16:10'),
(2, 'Drinks', 36, 1, '2018-10-10 00:16:10'),
(3, 'Pasta', 36, 1, '2018-10-10 00:30:47'),
(4, 'Appetizers', 36, 1, '2018-10-10 00:32:54'),
(5, 'Shakes', 36, 1, '2018-10-10 00:36:48'),
(6, 'Salad', 36, 1, '2018-10-12 03:17:03');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_menu_item`
--

CREATE TABLE `tbl_menu_item` (
  `id` int(10) UNSIGNED NOT NULL,
  `establishment_id` int(11) NOT NULL,
  `category_id` int(11) NOT NULL,
  `item_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `path` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `price` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `date_created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_menu_item`
--

INSERT INTO `tbl_menu_item` (`id`, `establishment_id`, `category_id`, `item_name`, `path`, `price`, `status`, `date_created`) VALUES
(8, 36, 1, 'Test123', '/storage/ssd5/923/6605923/public_html/images/productone-1539285149.jpg', '150', '1', '2018-10-11 19:12:29'),
(9, 36, 1, 'Coke', '/storage/ssd5/923/6605923/public_html/images/productone-1539190285.jpg', '50', '1', '2018-10-10 16:51:25'),
(10, 36, 2, 'Royal', '/storage/ssd5/923/6605923/public_html/images/productone-1539285333.jpg', '25', '1', '2018-10-14 04:15:23'),
(11, 36, 3, 'adobo', '/storage/ssd5/923/6605923/public_html/images/productone-1539488590.jpg', '35', '1', '2018-10-14 03:43:10');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id` int(11) NOT NULL,
  `first_name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `last_name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `username` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `status` int(6) NOT NULL,
  `date_created` date NOT NULL,
  `email_address` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`id`, `first_name`, `last_name`, `username`, `password`, `status`, `date_created`, `email_address`) VALUES
(1, 'francis', 'durante', 'francisdurante', '$2y$10$uSRb83rQO..VlCzYuAMfFeEgfOzh6hJYI6xGknYuHn4.DRVPsgPRe', 1, '2018-10-09', NULL),
(2, 'francis', 'durante', 'francisdurante1', '$2y$10$OrUAgVQoWvNX0qbEgodq8e4aZJn8o5NGvbNv6kXKKhBDRnHWadOq.', 1, '2018-10-09', NULL),
(3, 'Francis', 'Durante', 'review', '$2y$10$vWIKCAqzxHlegDkkci.vMuh21dLPruMJ/lnCPLoZCEIItU938dJrG', 1, '2018-10-13', 'gggaagaagg'),
(4, 'Francis', 'Durante', 'review00', '$2y$10$45h9bCmQsiT1CbUUkcZuN.OeLWyDsjQEpse1jB08ob3nYvObnDX56', 1, '2018-10-13', 'gggaagaagg'),
(5, 'Francis', 'Durante', 'review000', '$2y$10$rATq/GGgXd/ZEq4d9wYodOLr.nEVJATjLPpPKRd8JAoSTEdDaXUY.', 1, '2018-10-13', 'faffaffa'),
(6, 'Francis', 'Durante', 'review001', '$2y$10$PY87tTQBXEmIF5DtlVw64uwHije4tfF.WBKXleTri1hK/U/goTM36', 1, '2018-10-13', 'francisdurante11@gmail.com'),
(7, 'francis', 'durante', 'ffffffff', '$2y$10$2hCVghMI7I/jw.tSmD7nvOuT9qx4vKg4VKpJVq8Ps0/.lnM6jU2IG', 1, '2018-10-13', 'dfdfdddff'),
(8, 'aaaa', 'aaaaaa', 'aaaaaaa', '$2y$10$KS6Loav.WrHmcJsrBBK3U.8hb43NaqCHjkyvkz2C4ufq9Eli.VzXi', 1, '2018-10-13', 'aaaaaa'),
(9, 'cccccc', 'cccccc', 'cccccc', '$2y$10$TsiemOICS9OF5nxxhbq25eBrRZ2sL49z2Dllh2pcH61z6.nNHJWw2', 1, '2018-10-13', 'cccccc'),
(10, 'dddddd', 'dddddd', 'ddddddd', '$2y$10$YB8hHkW9yh2apFjRkLZJDeBYDLK000SxEK6P1DNtbPNoSW/uVhfqW', 1, '2018-10-13', 'dddddd'),
(11, 'Francis', 'Durante', 'review0001', '$2y$10$UNjxBtwp..fLVjQH5U0JVu//aLRBt8oODH8l4ME9g0y7msE.zNFaC', 1, '2018-10-13', 'francisdurante11@gmail.com'),
(12, 'Charlotte', 'Jastillana', 'chaba', '$2y$10$U.HkhxipPrg6d9rlJx45uOsXOnUcJ/XozWr1PkMgw3gc6/dwFj3AS', 1, '2018-10-14', 'chachaba@yahoo.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_estabalishment_user`
--
ALTER TABLE `tbl_estabalishment_user`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_establishment`
--
ALTER TABLE `tbl_establishment`
  ADD PRIMARY KEY (`id`),
  ADD KEY `establishment_user_id` (`establishment_user_id`),
  ADD KEY `est_type_id` (`est_type_id`);

--
-- Indexes for table `tbl_est_type`
--
ALTER TABLE `tbl_est_type`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_menu_category`
--
ALTER TABLE `tbl_menu_category`
  ADD PRIMARY KEY (`id`),
  ADD KEY `added_by` (`added_by`);

--
-- Indexes for table `tbl_menu_item`
--
ALTER TABLE `tbl_menu_item`
  ADD PRIMARY KEY (`id`),
  ADD KEY `establishment_id` (`establishment_id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_estabalishment_user`
--
ALTER TABLE `tbl_estabalishment_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `tbl_establishment`
--
ALTER TABLE `tbl_establishment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_est_type`
--
ALTER TABLE `tbl_est_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_menu_category`
--
ALTER TABLE `tbl_menu_category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_menu_item`
--
ALTER TABLE `tbl_menu_item`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_establishment`
--
ALTER TABLE `tbl_establishment`
  ADD CONSTRAINT `tbl_establishment_ibfk_1` FOREIGN KEY (`establishment_user_id`) REFERENCES `tbl_estabalishment_user` (`id`),
  ADD CONSTRAINT `tbl_establishment_ibfk_2` FOREIGN KEY (`est_type_id`) REFERENCES `tbl_est_type` (`id`);

--
-- Constraints for table `tbl_menu_category`
--
ALTER TABLE `tbl_menu_category`
  ADD CONSTRAINT `tbl_menu_category_ibfk_1` FOREIGN KEY (`added_by`) REFERENCES `tbl_estabalishment_user` (`id`);

--
-- Constraints for table `tbl_menu_item`
--
ALTER TABLE `tbl_menu_item`
  ADD CONSTRAINT `tbl_menu_item_ibfk_1` FOREIGN KEY (`establishment_id`) REFERENCES `tbl_estabalishment_user` (`id`),
  ADD CONSTRAINT `tbl_menu_item_ibfk_2` FOREIGN KEY (`category_id`) REFERENCES `tbl_menu_category` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
