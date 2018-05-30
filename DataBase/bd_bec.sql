-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 13-12-2017 a las 19:21:41
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bd_bec`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estante`
--

CREATE TABLE IF NOT EXISTS `estante` (
  `idEstante` int(11) NOT NULL AUTO_INCREMENT,
  `piso` varchar(20) NOT NULL,
  `seccion` varchar(25) NOT NULL,
  PRIMARY KEY (`idEstante`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=62 ;

--
-- Volcado de datos para la tabla `estante`
--

INSERT INTO `estante` (`idEstante`, `piso`, `seccion`) VALUES
(18, '1', 'F1'),
(19, '1', 'F2'),
(20, '1', 'N1'),
(21, '1', 'N2'),
(22, '1', 'N3'),
(23, '1', 'N3'),
(24, '1', 'F2'),
(25, '2', 'S1'),
(26, '2', 'P1'),
(27, '1', 'N3'),
(28, '2', 'I3'),
(29, '1', 'N3'),
(30, '1', 'N2'),
(31, '1', 'N4'),
(32, '2', 'P3'),
(33, '2', 'H2'),
(34, '2', 'T2'),
(35, '1', 'F2'),
(36, '2', 'R1'),
(37, '2', 'N1'),
(38, '1', 'N4'),
(39, '2', 'T1'),
(40, '1', 'N1'),
(41, '2', 'S5'),
(42, '2', 'M1'),
(43, '2', 'I3'),
(44, '2', 'M7'),
(45, '1', 'MU1'),
(46, '1', 'MU1'),
(47, '1', 'MU1'),
(48, '1', 'MU2'),
(49, '1', 'MU2'),
(50, '1', 'MU2'),
(51, '1', 'MU3'),
(52, '1', 'MU2'),
(53, '1', 'MU2'),
(54, '1', 'MU2'),
(55, '1', 'MU2'),
(56, '1', 'MU2'),
(57, '1', 'MU2'),
(58, '1', 'MU2'),
(59, '1', 'MU2'),
(60, '1', 'MU2'),
(61, '1', 'MU2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ficha`
--

CREATE TABLE IF NOT EXISTS `ficha` (
  `idFicha` int(11) NOT NULL AUTO_INCREMENT,
  `rut` varchar(50) NOT NULL,
  `nombres` varchar(200) NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `correo` varchar(200) NOT NULL,
  `telefono` varchar(200) NOT NULL,
  `huella` int(11) NOT NULL,
  PRIMARY KEY (`idFicha`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Volcado de datos para la tabla `ficha`
--

INSERT INTO `ficha` (`idFicha`, `rut`, `nombres`, `direccion`, `correo`, `telefono`, `huella`) VALUES
(1, '17342316-0', 'mlagos@gmail.com', 'Santa Marta 6950', 'fabian.millahual.m@gmail.com', '64177802', 555),
(5, '1231', 'pepito', 'mordor', 'pepo@mordor.cl', '123', 12312),
(6, '17148775-7', 'valeska urrutia', 'santa marta', 'vale@gmail.com', '8888', 5555),
(7, '7079967-7', 'jorge', 'recoleta', 'jlcisternas@yahoo.es', '8888', 4444),
(8, '17342315-2', 'Alejandro Lagos', 'Santa Marta ', 'alagos@gmail.com', '5987456', 22);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libro`
--

CREATE TABLE IF NOT EXISTS `libro` (
  `idLibro` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` varchar(50) NOT NULL,
  `codigo` varchar(50) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `autor` varchar(200) NOT NULL,
  `genero` varchar(50) NOT NULL,
  `fecha` varchar(200) NOT NULL,
  `popularidad` int(11) NOT NULL,
  `idstock` int(11) NOT NULL,
  PRIMARY KEY (`idLibro`),
  KEY `idStock` (`idstock`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=36 ;

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`idLibro`, `isbn`, `codigo`, `nombre`, `autor`, `genero`, `fecha`, `popularidad`, `idstock`) VALUES
(9, '9786073135603', '324853721', 'MOMO', 'MICHAEL ENDE', 'Fantasía', '2016', 1, 18),
(10, '7502268181154', '324853722', 'AL SUR DE LA FRONTERA, AL OESTE DEL SOL', 'HARUKI MURAKAMI', 'Ficción', '2008', 1, 19),
(11, '9786073110952', '324853723', 'POR FAVOR CUIDA DE MAMA', 'KYUNG SOOK SHIM', 'Novela', '2012', 1, 20),
(12, '9706991310213', '324853724', 'CRONICA DEL PAJARO QUE DA CUERDA AL MUNDO', 'HARUKI MURAKAMI', 'Novela', '2001', 1, 21),
(13, '9786070729560', '324853725', 'CRONICA DE UNA MUERTE ANUNCIADA', 'GABRIEL GARCIA MARQUEZ', 'Novela', '2015', 1, 22),
(14, '9786070728389', '324853726', 'LA CHICA DEL TREN', 'PAULA HAWKINS', 'Novela', '2015', 1, 23),
(15, '9788437624747', '324853727', 'RAYUELA', 'JULIO CORTAZAR', 'Ficción', '2009', 1, 24),
(16, '8466610685', '324853728', 'EL PSICOANALISTA', 'JOHN KATZENBACH', 'Suspenso', '2003', 1, 25),
(17, '9786073135436', '324853729', 'CRIMEN Y CASTIGO', 'FIODOR DOSTOIEVSKI', 'Policíaco', '2015', 1, 26),
(18, '9786073156165', '324853730', 'MAS ALLA DEL INVIERNO', 'ISABEL ALLENDE', 'Novela', '2017', 1, 27),
(19, '9786070721632', '324853731', 'LA SOMBRA DEL VIENTO', 'CARLOS RUIZ ZAFON', 'Intriga', '2014', 1, 28),
(20, '9786073130288', '324853732', 'COMO AGUA PARA CHOCOLATE', 'LAURA ESQUIVEL', 'Novela', '2015', 1, 29),
(21, '9786074450552', '324853733', 'LAS BATALLAS EN EL DESIERTO', 'JOSE EMILIO PACHECO', 'Novela', '2011', 1, 30),
(22, '9786074809794', '324853734', 'LA METAMORFOSIS', 'FRANZ KAFKA', 'Novela', '2016', 1, 31),
(23, '9786073151528', '324853735', 'LA VIDA SECRETA DE LA MENTE: NUESTRO CEREBRO CUANDO DECIDIMOS', 'MARIANO SIGMAN', 'Psicologico', '2017', 1, 32),
(24, '9786073110037', '324853736', 'MISERY', 'STEPHEN KING', 'Horror', '2012', 1, 33),
(25, '9786073118392', '324853737', 'EL RESPLANDOR', 'STEPHEN KING', 'Terror', '2013', 1, 34),
(26, '9788466649179', '324853738', 'READY PLAYER ONE', 'ERNEST CLINE', 'Ficción', '2011', 1, 35),
(27, '9786074451849', '324853739', 'AURA', 'CARLOS FUENTES', 'Realismo', '2012', 1, 36),
(28, '9788498382549', '324853740', 'EL NIÑO CON EL PIJAMA DE RAYAS', 'JOHN BOYNE', 'Novela', '2011', 1, 37),
(29, '9786070740497', '324853741', 'ESCRITO EN EL AGUA: NO CONFIES EN NADIE NI SIQUIERA EN TI', 'PAULA HAWKINS', 'Novela', '2017', 1, 38),
(30, '9786073158848', '324853742', 'FAUSTO', 'JOHANN WOLFGANG VON GOETHE', 'Tragedia', '2015', 1, 39),
(31, '849777230213', '324853743', 'EL CABALLERO DE LA ARMADURA OXIDADA', 'ROBERT FISHER', 'Novela', '2010', 1, 40),
(32, '9786070721632', '324853744', 'LA SOMBRA DEL VIENTO', 'CARLOS RUIZ ZAFON', 'Sobrenatural', '2014', 1, 41),
(33, '9786070721632', '324853745', 'EL JUEGO DEL ANGEL', 'CARLOS RUIZ ZAFON', 'Misterio', '2016', 1, 42),
(34, '9788408112303', '324853746', 'EL PRISIONERO DEL CIELO', 'CARLOS RUIZ ZAFON', 'Intriga', '2014', 1, 43),
(35, '9786070737336', '324853747', 'EL LABERINTO DE LOS ESPIRITUS', 'CARLOS RUIZ ZAFON', 'Misterio', '2016', 1, 44);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `multa`
--

CREATE TABLE IF NOT EXISTS `multa` (
  `idMulta` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(50) NOT NULL,
  `tiempo` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`idMulta`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `multa`
--

INSERT INTO `multa` (`idMulta`, `estado`, `tiempo`, `total`) VALUES
(1, 'Moroso', 3, 3),
(2, 'Moroso', 3, 3),
(3, 'Moroso', 3, 3),
(4, 'Moroso', 3, 3),
(5, 'Moroso', 3, 3),
(6, 'Moroso', 3, 3),
(7, 'Moroso', 3, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `multimedia`
--

CREATE TABLE IF NOT EXISTS `multimedia` (
  `idMultimedia` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(50) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `autor` varchar(200) NOT NULL,
  `fecha` varchar(4) NOT NULL,
  `idStock` int(11) NOT NULL,
  PRIMARY KEY (`idMultimedia`),
  KEY `idStock` (`idStock`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Volcado de datos para la tabla `multimedia`
--

INSERT INTO `multimedia` (`idMultimedia`, `codigo`, `tipo`, `nombre`, `autor`, `fecha`, `idStock`) VALUES
(4, '324153001', 'DVD', 'Aprendamos Ciencia Y Matemáticas', 'Nickelodeon Studios', '2015', 45),
(5, '324153002', 'DVD', 'MATEMATICAS BASICAS', 'VICTOR ET AL. HERNANDEZ MORALES', '2006', 46),
(6, '324153003', 'DVD', 'Anatomía & Fisiología', 'Kevin T. Patton PhD', '2017', 47),
(7, '324153004', 'DVD', 'Curso De Ciencias básicas y clinicial', 'BCSC', '2017', 48),
(8, '324153005', 'DVD', 'Aprender idiomas 24.de japonés', 'Udo Verlag Gollub', '2010', 49),
(9, '324153006', 'DVD', 'capacitación de administración de bases de datos Oracle 12', 'Infinite Skills - ORACLE', '2016', 50),
(10, '324153007', 'Pelicula', 'MICROCOSMOS', ' Claude Nuridsany', '1996', 51),
(11, '324153008', 'Pelicula', 'El Teatro del más allá, Chavín de Huántar', 'José Manuel Novoa', '2015', 52),
(12, '324153009', 'Pelicula', 'El último de los injustos', 'Claude Lanzmann', '2014', 53),
(13, '324153010', 'Pelicula', 'La Cueva de los Sueños Olvidados', 'Werner Herzog', '2012', 54),
(14, '324153011', 'Pelicula', 'Una esvástica sobre el Bidasoa', 'Alfonso Andrés', '2014', 55),
(15, '324153012', 'Pelicula', 'Llega de noche', 'Trey Edward Shults', '2017', 56),
(16, '324153013', 'Pelicula', 'La revolución altruista', 'Sylvie Gilman y Thierry de Lestrade', '2017', 57),
(17, '324153014', 'Pelicula', 'Speed, en busca del tiempo perdido', 'Florian Opitz', '2017', 58),
(18, '324153015', 'DVD', 'Barcelona Antes que el tiempo lo borre', 'Mireia Ros', '2011', 59),
(19, '324153016', 'DVD', 'Page One: un año en The New York Times', 'Andrew Rossi', '2012', 60),
(20, '324153017', 'CD', 'The Black Power Mixtape', 'Göran Hugo Olsson', '2013', 61);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamo`
--

CREATE TABLE IF NOT EXISTS `prestamo` (
  `idPrestamo` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) NOT NULL,
  `estado` varchar(50) NOT NULL,
  `fechaPrestamo` varchar(50) NOT NULL,
  `fechaDevolucion` varchar(50) NOT NULL,
  `idUsuario` int(11) DEFAULT NULL,
  `idMulta` int(11) DEFAULT NULL,
  `idLibro` int(11) DEFAULT NULL,
  `idMultimedia` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPrestamo`),
  KEY `idUsuario` (`idUsuario`),
  KEY `idMulta` (`idMulta`),
  KEY `idLibro` (`idLibro`),
  KEY `idMultimedia` (`idMultimedia`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Volcado de datos para la tabla `prestamo`
--

INSERT INTO `prestamo` (`idPrestamo`, `tipo`, `estado`, `fechaPrestamo`, `fechaDevolucion`, `idUsuario`, `idMulta`, `idLibro`, `idMultimedia`) VALUES
(5, 'Libro', 'Meson', '12-11-2017 12:22', '11-12-2017 17: 22', 3, NULL, 9, NULL),
(6, 'Libro', 'Reserva', '2017-12-13', '2017-12-13', 5, 6, 20, NULL),
(7, 'Multimedia', 'Reservado', '2017-12-19', '2017-12-19', 3, 7, NULL, 12),
(8, 'Libro', 'Meson', '13-12-2017 14:07:30', '13-12-2017 19:07:30', 3, NULL, 9, NULL),
(9, 'Libro', 'Meson', '13-12-2017 15:22:54', '13-12-2017 20:22:54', 3, NULL, 17, NULL),
(10, 'Libro', 'Meson', '13-12-2017 15:35:53', '13-12-2017 20:35:53', 3, NULL, 9, NULL),
(11, 'Libro', 'Meson', '13-12-2017 15:46:51', '13-12-2017 20:46:51', 3, NULL, 22, NULL),
(12, 'Multimedia', 'Meson', '13-12-2017 15:53:44', '13-12-2017 20:53:44', 3, NULL, NULL, 16),
(13, 'Multimedia', 'Meson', '13-12-2017 15:56:29', '13-12-2017 20:56:29', 3, NULL, NULL, 16);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

CREATE TABLE IF NOT EXISTS `rol` (
  `idRol` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `rol`
--

INSERT INTO `rol` (`idRol`, `descripcion`) VALUES
(1, 'Usuario'),
(2, 'Bibliotecario'),
(3, 'Administrativo de Biblioteca');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stock`
--

CREATE TABLE IF NOT EXISTS `stock` (
  `idStock` int(11) NOT NULL AUTO_INCREMENT,
  `activo` int(11) NOT NULL,
  `prestado` int(11) DEFAULT NULL,
  `total` int(11) NOT NULL,
  `idEstante` int(11) NOT NULL,
  PRIMARY KEY (`idStock`),
  KEY `idEstante` (`idEstante`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=62 ;

--
-- Volcado de datos para la tabla `stock`
--

INSERT INTO `stock` (`idStock`, `activo`, `prestado`, `total`, `idEstante`) VALUES
(18, 9, 1, 10, 18),
(19, 15, 0, 15, 19),
(20, 7, 0, 7, 20),
(21, 4, 0, 4, 21),
(22, 6, 0, 6, 22),
(23, 12, 0, 12, 23),
(24, 9, 0, 9, 24),
(25, 5, 0, 5, 25),
(26, 13, 0, 13, 26),
(27, 22, 0, 22, 27),
(28, 4, 0, 4, 28),
(29, 5, 1, 6, 29),
(30, 7, 0, 7, 30),
(31, 3, 1, 4, 31),
(32, 7, 0, 7, 32),
(33, 23, 0, 23, 33),
(34, 25, 0, 25, 34),
(35, 5, 0, 5, 35),
(36, 3, 0, 3, 36),
(37, 15, 0, 15, 37),
(38, 5, 0, 5, 38),
(39, 6, 0, 6, 39),
(40, 4, 0, 4, 40),
(41, 7, 0, 7, 41),
(42, 3, 0, 3, 42),
(43, 5, 0, 5, 43),
(44, 5, 0, 5, 44),
(45, 3, 1, 4, 45),
(46, 6, 0, 6, 46),
(47, 3, 0, 3, 47),
(48, 2, 0, 2, 48),
(49, 3, 0, 3, 49),
(50, 2, 0, 2, 50),
(51, 2, 1, 3, 51),
(52, 3, 0, 3, 52),
(53, 1, 1, 2, 53),
(54, 4, 0, 4, 54),
(55, 2, 0, 2, 55),
(56, 5, 0, 5, 56),
(57, 4, 1, 5, 57),
(58, 3, 0, 3, 58),
(59, 2, 0, 2, 59),
(60, 0, 2, 2, 60),
(61, 2, 0, 2, 61);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(100) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `Activo` int(11) DEFAULT NULL,
  `idRol` int(11) DEFAULT NULL,
  `idFicha` int(11) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`),
  KEY `idRol` (`idRol`),
  KEY `idFicha` (`idFicha`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `nombreUsuario`, `clave`, `Activo`, `idRol`, `idFicha`) VALUES
(3, 'mlagosu', '1234', 1234, 1, 1),
(4, 'vale', '111', 1234, 1, 6),
(5, 'jlagos', '123', 1234, 2, 7),
(6, 'alagos', '1234', 1234, 3, 8);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `libro`
--
ALTER TABLE `libro`
  ADD CONSTRAINT `libro_ibfk_1` FOREIGN KEY (`idstock`) REFERENCES `stock` (`idStock`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `multimedia`
--
ALTER TABLE `multimedia`
  ADD CONSTRAINT `multimedia_ibfk_1` FOREIGN KEY (`idStock`) REFERENCES `stock` (`idStock`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD CONSTRAINT `prestamo_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prestamo_ibfk_2` FOREIGN KEY (`idMulta`) REFERENCES `multa` (`idMulta`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prestamo_ibfk_3` FOREIGN KEY (`idMultimedia`) REFERENCES `multimedia` (`idMultimedia`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prestamo_ibfk_4` FOREIGN KEY (`idLibro`) REFERENCES `libro` (`idLibro`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`idEstante`) REFERENCES `estante` (`idEstante`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`idRol`) REFERENCES `rol` (`idRol`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`idFicha`) REFERENCES `ficha` (`idFicha`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
