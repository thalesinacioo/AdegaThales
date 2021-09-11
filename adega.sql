-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 08-Set-2021 às 00:23
-- Versão do servidor: 10.4.20-MariaDB
-- versão do PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `adega`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `vinho`
--

CREATE TABLE `vinho` (
  `idVinho` int(11) NOT NULL,
  `nomeVinho` varchar(50) CHARACTER SET utf8 NOT NULL,
  `categoriaVinho` varchar(50) NOT NULL,
  `descricaoVinho` text NOT NULL,
  `anoVinho` int(4) NOT NULL,
  `ativoVinho` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vinho`
--

INSERT INTO `vinho` (`idVinho`, `nomeVinho`, `categoriaVinho`, `descricaoVinho`, `anoVinho`, `ativoVinho`) VALUES
(1, 'Decanto ', 'Tinto ', 'Os vinhos tintos caracterizam-se pela cor avermelhada em vários tons, pois são fermentadas com a casca da uva. Os tintos que possuem tonalidade mais clara são mais leves e para consumo mais rápido. Já os mais escuros devem ser armazenados e envelhecidos. O vinho tinto pode acompanhar diversos tipos de refeições, principalmente as que possuem carne vermelhas e molhos fortes.', 1994, 1),
(2, 'JotaP', 'Branco', 'Os vinhos brancos, por serem fermentados sem a casca da uva, apresentam uma cor amarelada, com tons esverdeados e dourados. São elaborados com uvas não excessivamente maduras, visando assegurar uma boa carga de acidez, resultando em frescor gustativo. Podem acompanhar carne branca, frutos do mar, frango, presunto cozido, massa e lombinho assado.', 1999, 1),
(3, 'Veuve Clicquot', 'Tannat', 'Originária do sul da França, esse tipo de uva adaptou-se muito bem no Uruguai. O vinho Tannat apresenta boa cor e excelente estrutura. Possui sabor frutado, com leve passagem pelo carvalho, que lhe confere equilíbrio e complexidade. Por ser um vinho bastante encorpado, acompanha pratos fortes, como carnes vermelhas e queijos de sabor acentuado.', 2002, 1),
(5, 'ADW', 'Gewurztraminer', 'Vinho seco, com aromas que lembram frutas e flores do campo. De sabor intenso e agradável, o Gewurztraminer é elaborado com uvas originárias da região da Alsácia, no norte da França, e da região do Reno, na Alemanha. Acompanha presunto cru, comida chinesa, peixes e vários tipos de sobremesas.', 2012, 1),
(6, 'Red3', 'Pinot Noir', 'Esta uva, cultivada em diversos países, produz um vinho seco, encorpado, de cor violácea e sabor delicado. É originário da Borgonha francesa, onde se fabrica o Romanée-Conti, considerado um dos vinhos mais prestigiados e caros do mundo. O Pinot Noir possui corpo médio e é sensível à umidade. Acompanha frutos do mar, massas, fondues e aves.', 2005, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `vinho`
--
ALTER TABLE `vinho`
  ADD PRIMARY KEY (`idVinho`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `vinho`
--
ALTER TABLE `vinho`
  MODIFY `idVinho` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
