-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Máquina: 127.0.0.1
-- Data de Criação: 11-Out-2013 às 02:50
-- Versão do servidor: 5.5.32
-- versão do PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `ordem_de_servico`
--
CREATE DATABASE IF NOT EXISTS `ordem_de_servico` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `ordem_de_servico`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `access_level`
--

CREATE TABLE IF NOT EXISTS `access_level` (
  `access_level_id` int(11) NOT NULL AUTO_INCREMENT,
  `access_level_name` varchar(90) NOT NULL,
  `created_by` int(11) NOT NULL,
  PRIMARY KEY (`access_level_id`),
  UNIQUE KEY `access_level_name` (`access_level_name`),
  KEY `created_by` (`created_by`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `item`
--

CREATE TABLE IF NOT EXISTS `item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_description` varchar(90) DEFAULT NULL,
  `item_brand` varchar(90) DEFAULT NULL,
  `creation_date` datetime NOT NULL,
  `last_price` float NOT NULL,
  `machine_id` int(11) NOT NULL,
  `enabled_flag` varchar(1) NOT NULL,
  `created_by` int(11) NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `machine_id` (`machine_id`),
  KEY `created_by` (`created_by`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `machines`
--

CREATE TABLE IF NOT EXISTS `machines` (
  `machine_id` int(11) NOT NULL AUTO_INCREMENT,
  `creation_date` datetime NOT NULL,
  `price` float DEFAULT NULL,
  `repair_count` int(11) NOT NULL,
  `enabled_flag` varchar(1) NOT NULL,
  `created_by` int(11) NOT NULL,
  PRIMARY KEY (`machine_id`),
  KEY `created_by` (`created_by`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `so_headers`
--

CREATE TABLE IF NOT EXISTS `so_headers` (
  `so_header_id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_os` int(11) NOT NULL,
  `creation_date` datetime NOT NULL,
  `created_by` int(11) NOT NULL,
  `last_update_date` datetime NOT NULL,
  `last_update_by` varchar(60) NOT NULL,
  `status` varchar(60) NOT NULL,
  `maquina_id` int(11) NOT NULL,
  `comments` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`so_header_id`),
  UNIQUE KEY `codigo_os` (`codigo_os`),
  KEY `maquina_id` (`maquina_id`),
  KEY `created_by` (`created_by`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `so_lines`
--

CREATE TABLE IF NOT EXISTS `so_lines` (
  `so_line_id` int(11) NOT NULL AUTO_INCREMENT,
  `so_header_id` int(11) NOT NULL,
  `amount` float NOT NULL,
  `item_id` int(11) NOT NULL,
  PRIMARY KEY (`so_line_id`),
  KEY `so_header_id` (`so_header_id`),
  KEY `items_id` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` int(11) NOT NULL,
  `password` varchar(100) NOT NULL,
  `name` varchar(250) NOT NULL,
  `access_level_id` int(11) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`),
  KEY `access_level_id` (`access_level_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `so_headers`
--
ALTER TABLE `so_headers`
  ADD CONSTRAINT `so_headers_ibfk_1` FOREIGN KEY (`maquina_id`) REFERENCES `machines` (`machine_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `so_lines`
--
ALTER TABLE `so_lines`
  ADD CONSTRAINT `so_lines_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `so_lines_ibfk_1` FOREIGN KEY (`so_header_id`) REFERENCES `so_headers` (`so_header_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`access_level_id`) REFERENCES `access_level` (`access_level_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
