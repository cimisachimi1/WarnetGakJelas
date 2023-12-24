-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Des 2023 pada 14.39
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bilingwarnet`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akunpelanggan`
--

CREATE TABLE `akunpelanggan` (
  `Username` varchar(50) NOT NULL,
  `ID_Pelanggan` int(20) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `akunpelanggan`
--

INSERT INTO `akunpelanggan` (`Username`, `ID_Pelanggan`, `Password`) VALUES
('fatur11', 1, 'fatur11');

-- --------------------------------------------------------

--
-- Struktur dari tabel `komputerwarnet`
--

CREATE TABLE `komputerwarnet` (
  `ID_Komputer` int(20) NOT NULL,
  `Ketersediaan` tinyint(1) NOT NULL,
  `Jenis_Komputer` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `layanantambahan`
--

CREATE TABLE `layanantambahan` (
  `ID_Layanan_Tambahan` int(20) NOT NULL,
  `ID_Pelanggan` int(20) NOT NULL,
  `Makanan` varchar(50) NOT NULL,
  `Minuman` varchar(50) NOT NULL,
  `Print` varchar(50) NOT NULL,
  `Total_Layanan` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `operator`
--

CREATE TABLE `operator` (
  `ID_Operator` int(20) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Umur` int(3) NOT NULL,
  `Mulai_Shift` time DEFAULT NULL,
  `Akhir_Shift` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID_Pelanggan` int(20) NOT NULL,
  `Nama_Pelanggan` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `NomerHP` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`ID_Pelanggan`, `Nama_Pelanggan`, `Alamat`, `Email`, `NomerHP`) VALUES
(1, 'Muh. Faturahman', 'Bantul, Yogyakarta', 'mfaturrahmann@gmail.com', '08216458454');

-- --------------------------------------------------------

--
-- Struktur dari tabel `sesirental`
--

CREATE TABLE `sesirental` (
  `ID_SesiRental` int(20) NOT NULL,
  `WaktuMulai` datetime DEFAULT NULL,
  `WaktuSelesai` datetime DEFAULT NULL,
  `Durasi` datetime DEFAULT NULL,
  `Username` varchar(50) NOT NULL,
  `ID_Komputer` int(20) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Total_Rental` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `ID_Transaksi` int(20) NOT NULL,
  `Tanggal_Transaksi` datetime DEFAULT NULL,
  `ID_SesiRental` int(20) NOT NULL,
  `ID_Layanan_Tambahan` int(20) NOT NULL,
  `ID_Operator` int(20) NOT NULL,
  `Total_Biaya` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akunpelanggan`
--
ALTER TABLE `akunpelanggan`
  ADD PRIMARY KEY (`Username`),
  ADD KEY `ID_Pelanggan` (`ID_Pelanggan`);

--
-- Indeks untuk tabel `komputerwarnet`
--
ALTER TABLE `komputerwarnet`
  ADD PRIMARY KEY (`ID_Komputer`);

--
-- Indeks untuk tabel `layanantambahan`
--
ALTER TABLE `layanantambahan`
  ADD PRIMARY KEY (`ID_Layanan_Tambahan`),
  ADD KEY `ID_Pelanggan` (`ID_Pelanggan`);

--
-- Indeks untuk tabel `operator`
--
ALTER TABLE `operator`
  ADD PRIMARY KEY (`ID_Operator`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID_Pelanggan`);

--
-- Indeks untuk tabel `sesirental`
--
ALTER TABLE `sesirental`
  ADD PRIMARY KEY (`ID_SesiRental`),
  ADD KEY `Username` (`Username`),
  ADD KEY `ID_Komputer` (`ID_Komputer`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID_Transaksi`),
  ADD KEY `ID_SesiRental` (`ID_SesiRental`),
  ADD KEY `ID_Operator` (`ID_Operator`),
  ADD KEY `transaksi_ibfk_2` (`ID_Layanan_Tambahan`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `akunpelanggan`
--
ALTER TABLE `akunpelanggan`
  ADD CONSTRAINT `akunpelanggan_ibfk_1` FOREIGN KEY (`ID_Pelanggan`) REFERENCES `pelanggan` (`ID_Pelanggan`);

--
-- Ketidakleluasaan untuk tabel `layanantambahan`
--
ALTER TABLE `layanantambahan`
  ADD CONSTRAINT `layanantambahan_ibfk_1` FOREIGN KEY (`ID_Pelanggan`) REFERENCES `pelanggan` (`ID_Pelanggan`);

--
-- Ketidakleluasaan untuk tabel `sesirental`
--
ALTER TABLE `sesirental`
  ADD CONSTRAINT `sesirental_ibfk_1` FOREIGN KEY (`Username`) REFERENCES `akunpelanggan` (`Username`),
  ADD CONSTRAINT `sesirental_ibfk_2` FOREIGN KEY (`ID_Komputer`) REFERENCES `komputerwarnet` (`ID_Komputer`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`ID_SesiRental`) REFERENCES `sesirental` (`ID_SesiRental`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`ID_Layanan_Tambahan`) REFERENCES `layanantambahan` (`ID_Layanan_Tambahan`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`ID_Operator`) REFERENCES `operator` (`ID_Operator`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
