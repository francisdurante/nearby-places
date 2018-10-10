-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 10, 2018 at 04:54 PM
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
(36, 'review000', '$2y$10$8oFySyV0BjnG2wlpwM031.mrJKIHByDRrMdE1zuobepu1U4ECLM4e', 1, '2018-10-09');

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
  `date_created` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_establishment`
--

INSERT INTO `tbl_establishment` (`id`, `establishment_user_id`, `establishment_name`, `location_latitude`, `location_longitude`, `good_for_emotion_of`, `good_at_of`, `status`, `date_created`) VALUES
(1, 30, 'francisres', '.12457851000', '.45412265874', 'all', 'all', 1, NULL),
(2, 34, 'francisres', '.12457851000', '.45412265874', 'all', 'all', 1, NULL),
(3, 35, 'francisres', '.45412265874', NULL, 'all', 'all', 1, '2018-10-09'),
(4, 36, 'Francis kaininan', '1.25555555555', '1.02154876', 'HAPPY', 'CHILDREN', 1, '2018-10-09');

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
(1, 'Drinks', 36, 1, '2018-10-10 00:16:10'),
(2, 'Dessert', 36, 1, '2018-10-10 00:16:10'),
(3, 'Others', 36, 1, '2018-10-10 00:30:47'),
(4, 'Appetizers', 36, 1, '2018-10-10 00:32:54'),
(5, 'Pasta', 36, 1, '2018-10-10 00:36:48');

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
(1, 36, 1, 'Test', '/storage/ssd5/923/6605923/public/images/productone-1539186904.jpg', '150', '1', '2018-10-10 15:55:04'),
(2, 36, 1, 'Test', '/storage/ssd5/923/6605923/public/images/productone-1539187236.jpg', '150', '1', '2018-10-10 16:00:36'),
(3, 36, 1, 'Test', '/storage/ssd5/923/6605923/public/images/productone-1539187329.jpg', '150', '1', '2018-10-10 16:02:09'),
(4, 36, 1, 'Test', '/storage/ssd5/923/6605923/public/images/productone-1539187500.jpg', '150', '1', '2018-10-10 16:05:00'),
(5, 36, 1, 'Test', '/storage/ssd5/923/6605923/public/../public_html/imagesproductone-1539187774.jpg', '150', '1', '2018-10-10 16:09:34'),
(6, 36, 1, 'Test', '/storage/ssd5/923/6605923/public/images/productone-1539188240.jpg', '150', '1', '2018-10-10 16:17:20'),
(7, 36, 1, 'Test', '/storage/ssd5/923/6605923/public_html/images/productone-1539188363.jpg', '150', '1', '2018-10-10 16:19:23'),
(8, 36, 1, 'Test', '/storage/ssd5/923/6605923/public_html/images/productone-1539189252.jpg', '150', '1', '2018-10-10 16:34:12'),
(9, 36, 1, 'Coke', '/storage/ssd5/923/6605923/public_html/images/productone-1539190285.jpg', '50', '1', '2018-10-10 16:51:25');

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
  `date_created` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`id`, `first_name`, `last_name`, `username`, `password`, `status`, `date_created`) VALUES
(1, 'francis', 'durante', 'francisdurante', '$2y$10$uSRb83rQO..VlCzYuAMfFeEgfOzh6hJYI6xGknYuHn4.DRVPsgPRe', 1, '2018-10-09'),
(2, 'francis', 'durante', 'francisdurante1', '$2y$10$OrUAgVQoWvNX0qbEgodq8e4aZJn8o5NGvbNv6kXKKhBDRnHWadOq.', 1, '2018-10-09');

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
  ADD KEY `establishment_user_id` (`establishment_user_id`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tbl_establishment`
--
ALTER TABLE `tbl_establishment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_menu_category`
--
ALTER TABLE `tbl_menu_category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_menu_item`
--
ALTER TABLE `tbl_menu_item`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_establishment`
--
ALTER TABLE `tbl_establishment`
  ADD CONSTRAINT `tbl_establishment_ibfk_1` FOREIGN KEY (`establishment_user_id`) REFERENCES `tbl_estabalishment_user` (`id`);

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
