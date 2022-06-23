-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 27, 2019 at 12:08 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `final pms`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Mobile` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `Name`, `Address`, `Mobile`, `Email`) VALUES
('1', 'hero alom', 'mirpur 1, Dhaka', '01611111111', 'heroalom@gmail.com'),
('2', 'Dolal trump', 'Commerce College Road, Dhaka', '0173333333', 'dolaltrump@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Mobile` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `password` varchar(33) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `Name`, `Address`, `Mobile`, `Email`, `password`) VALUES
('1', 'shahrukh khan', 'East Shewrapara, Mirpur, Dhaka.', '01622222222', 'shahrukhkhan@gmail.com', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `email`) VALUES
('admin1', '1234', 'moinul180180@gmail.com');


INSERT INTO `login` (`username`, `password`, `email`) VALUES
('admin2', '1122', 'emon154@gmail.com');



INSERT INTO `login` (`username`, `password`, `email`) VALUES
('admin3', '2233', 'mosrafulhabib172@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Batch No` varchar(50) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `Quantity` varchar(50) NOT NULL,
  `Price` varchar(50) NOT NULL,
  `Manufactured Date` varchar(50) NOT NULL,
  `Expired Date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`ID`, `Name`, `Batch No`, `Category`, `Quantity`, `Price`, `Manufactured Date`, `Expired Date`) VALUES
('1', 'Napa', '124', 'paracetamol', '100', '6', '24-02-2021', '01-09-2023'),
('2', 'Ace', '366', 'paracetamol', '100', '5', '24-02-2021', '01-08-2023');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `Bill No` varchar(50) NOT NULL,
  `Bill Date` varchar(50) NOT NULL,
  `Customer Name` varchar(50) NOT NULL,
  `Medicine Name` varchar(50) NOT NULL,
  `ID` varchar(50) NOT NULL,
  `Batch No` varchar(50) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `Quantity` varchar(50) NOT NULL,
  `Price` varchar(50) NOT NULL,
  `Total Price` varchar(50) NOT NULL,
  `Issued By` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`Bill No`, `Bill Date`, `Customer Name`, `Medicine Name`, `ID`, `Batch No`, `Category`, `Quantity`, `Price`, `Total Price`, `Issued By`) VALUES
('1', '25-02-2021', 'Sujon', 'Napa', '1', '124', 'paracetamol', '10', '6', '60', 'abid'),
('2', '25-02-2021', 'arat', 'ace', '2', '366', 'paracetamol', '10', '5', '50', 'abid');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
