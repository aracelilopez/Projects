-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-12-2018 a las 02:32:57
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `biblioteca`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `Codigo` int(11) NOT NULL,
  `Dni` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Apellido` varchar(30) NOT NULL,
  `Localidad` varchar(30) NOT NULL,
  `Tipo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`Codigo`, `Dni`, `Nombre`, `Apellido`, `Localidad`, `Tipo`) VALUES
(1, 33141516, 'Clara', 'Paz', 'F. Varela', 0),
(2, 32124565, 'Gonzalo', 'Ruiz', 'Quilmes', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libro`
--

CREATE TABLE `libro` (
  `Isbn` int(11) NOT NULL,
  `Ejemplar` int(11) NOT NULL,
  `Titulo` varchar(30) NOT NULL,
  `Autor` varchar(30) NOT NULL,
  `Editorial` varchar(30) NOT NULL,
  `Genero` varchar(30) NOT NULL,
  `Estado` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`Isbn`, `Ejemplar`, `Titulo`, `Autor`, `Editorial`, `Genero`, `Estado`) VALUES
(1, 1, 'Harry Potter', 'J.K. Rowling', 'S.A', 'Fantasia', 'Disponible'),
(2, 1, 'El Señor de los Anillos', 'J.R.R. Tolkien', 'S.A', 'Fantasia', 'Disponible'),
(2, 4, 'El Código da Vinci', 'Dan Brown', 'S.A', 'Suspenso', 'Disponible');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamo`
--

CREATE TABLE `prestamo` (
  `codigo` int(11) NOT NULL,
  `codigoCliente` int(11) NOT NULL,
  `isbn` int(11) NOT NULL,
  `ejemplar` int(11) NOT NULL,
  `fechaPrestamo` datetime NOT NULL,
  `fechaDevolucion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `prestamo`
--

INSERT INTO `prestamo` (`codigo`, `codigoCliente`, `isbn`, `ejemplar`, `fechaPrestamo`, `fechaDevolucion`) VALUES
(1, 2, 2, 4, '2018-12-26 00:00:00', '2019-09-20 00:00:00'),
(45, 2, 2, 4, '2018-12-12 00:00:00', '2019-03-03 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reserva`
--

CREATE TABLE `reserva` (
  `Codigo` int(11) NOT NULL,
  `CodigoCliente` int(11) NOT NULL,
  `CodigoIsbn` int(11) NOT NULL,
  `Ejemplar` int(11) NOT NULL,
  `fechaDisponibilidad` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reserva`
--

INSERT INTO `reserva` (`Codigo`, `CodigoCliente`, `CodigoIsbn`, `Ejemplar`, `fechaDisponibilidad`) VALUES
(3, 1, 1, 1, '2018-12-26 00:00:00'),
(4, 2, 2, 1, '2018-12-26 00:00:00'),
(5, 2, 2, 4, '2018-12-26 00:00:00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Codigo`);

--
-- Indices de la tabla `libro`
--
ALTER TABLE `libro`
  ADD PRIMARY KEY (`Isbn`,`Ejemplar`);

--
-- Indices de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`Codigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
