-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 07, 2021 at 05:56 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uitleen_systeem`
--

-- --------------------------------------------------------

--
-- Table structure for table `inlog_gegv`
--

CREATE TABLE `inlog_gegv` (
  `user_id` int(2) NOT NULL,
  `name` varchar(30) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `age` int(11) NOT NULL,
  `gender` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inlog_gegv`
--

INSERT INTO `inlog_gegv` (`user_id`, `name`, `username`, `password`, `age`, `gender`) VALUES
(1, 'Frans de Boer', 'user1', 'pass1', 18, 'Man'),
(3, 'Yusuf Kemal Ozturk', 'yusufkemal1001', 'Mavi8829', 18, 'Man'),
(5, 'obejah', 'obejah', 'alexander', 17, 'man');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `inlog_gegv`
--
ALTER TABLE `inlog_gegv`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `inlog_gegv`
--
ALTER TABLE `inlog_gegv`
  MODIFY `user_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
