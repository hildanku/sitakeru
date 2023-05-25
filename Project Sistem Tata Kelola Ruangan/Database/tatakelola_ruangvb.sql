-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 25, 2022 at 05:54 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tatakelola_ruangvb`
--

-- --------------------------------------------------------

--
-- Table structure for table `inventaris_ruang`
--

CREATE TABLE `inventaris_ruang` (
  `id` int(11) NOT NULL,
  `kode_ruang` varchar(6) NOT NULL,
  `jumlah_kursi` int(100) NOT NULL,
  `ac` varchar(255) NOT NULL,
  `internet_lan` varchar(255) NOT NULL,
  `kelengkapan_lain` text NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inventaris_ruang`
--

INSERT INTO `inventaris_ruang` (`id`, `kode_ruang`, `jumlah_kursi`, `ac`, `internet_lan`, `kelengkapan_lain`, `keterangan`) VALUES
(5, 'G1A', 30, 'TERSEDIA', 'TERSEDIA', 'WhiteBoard,Spidol Ready', 'Kelas Bagus');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE `kelas` (
  `kelas_id` int(11) NOT NULL,
  `kode_kelas` varchar(6) NOT NULL,
  `nama_kelas` varchar(255) NOT NULL,
  `status` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`kelas_id`, `kode_kelas`, `nama_kelas`, `status`) VALUES
(14, '1IKRA', '1IKRA', 1),
(15, '1IKRB', '1IKRB', 1),
(16, '1IKRC', '1IKRC', 0),
(17, '1IKRAK', '1IKRAK2', 0),
(18, '1IKKA', '1IKKA', 0);

-- --------------------------------------------------------

--
-- Table structure for table `ketersediaan_ruang`
--

CREATE TABLE `ketersediaan_ruang` (
  `ket_id` int(11) NOT NULL,
  `kode_ruang` varchar(5) NOT NULL,
  `dipakai_oleh` varchar(6) NOT NULL,
  `keterangan` varchar(255) NOT NULL,
  `status` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ketersediaan_ruang`
--

INSERT INTO `ketersediaan_ruang` (`ket_id`, `kode_ruang`, `dipakai_oleh`, `keterangan`, `status`) VALUES
(37, 'G1A', '1IKRA', '12.00-SELESAI', 1),
(38, 'G1C', '1IKRB', '12.00.14.00', 1);

-- --------------------------------------------------------

--
-- Table structure for table `ruang`
--

CREATE TABLE `ruang` (
  `ruang_id` int(11) NOT NULL,
  `kode_ruang` varchar(6) NOT NULL,
  `nama_ruang` varchar(255) NOT NULL,
  `status` int(2) NOT NULL,
  `table_used` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ruang`
--

INSERT INTO `ruang` (`ruang_id`, `kode_ruang`, `nama_ruang`, `status`, `table_used`) VALUES
(21, 'G1A', 'GEDUNG 1 A', 1, 1),
(22, 'G1B', 'GEDUNG 1 B', 1, 0),
(23, 'G1C', 'GEDUNG 1 C', 0, 0),
(24, 'G1D', 'GEDUNG 1 D', 0, 0),
(26, 'G1E', 'GEDUNG 1 E', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(15) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `nama`, `username`, `password`, `role`) VALUES
(1, 'Hildan K', 'hildan', 'hildan', 'operator'),
(61, 'Rendy Raihan', 'Rendy', 'Rendy', 'operator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `inventaris_ruang`
--
ALTER TABLE `inventaris_ruang`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kode_ruang` (`kode_ruang`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`kelas_id`),
  ADD KEY `kode_kelas` (`kode_kelas`,`status`);

--
-- Indexes for table `ketersediaan_ruang`
--
ALTER TABLE `ketersediaan_ruang`
  ADD PRIMARY KEY (`ket_id`),
  ADD KEY `kode_ruang` (`kode_ruang`),
  ADD KEY `dipakai_oleh` (`dipakai_oleh`),
  ADD KEY `status` (`status`),
  ADD KEY `kode_ruang_2` (`kode_ruang`,`dipakai_oleh`,`status`);

--
-- Indexes for table `ruang`
--
ALTER TABLE `ruang`
  ADD PRIMARY KEY (`ruang_id`),
  ADD KEY `kode_ruang` (`kode_ruang`),
  ADD KEY `status` (`status`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `inventaris_ruang`
--
ALTER TABLE `inventaris_ruang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
  MODIFY `kelas_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `ketersediaan_ruang`
--
ALTER TABLE `ketersediaan_ruang`
  MODIFY `ket_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `ruang`
--
ALTER TABLE `ruang`
  MODIFY `ruang_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ketersediaan_ruang`
--
ALTER TABLE `ketersediaan_ruang`
  ADD CONSTRAINT `ketersediaan_ruang_ibfk_1` FOREIGN KEY (`dipakai_oleh`) REFERENCES `kelas` (`kode_kelas`),
  ADD CONSTRAINT `testrelasi` FOREIGN KEY (`kode_ruang`) REFERENCES `ruang` (`kode_ruang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
