-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Jun 10, 2023 at 07:24 PM
-- Server version: 5.7.24
-- PHP Version: 8.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db`
--

-- --------------------------------------------------------

--
-- Table structure for table `chat`
--

CREATE TABLE `chat` (
  `chat_id` int(11) UNSIGNED NOT NULL,
  `user_1` int(11) UNSIGNED NOT NULL,
  `user_2` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chat`
--

INSERT INTO `chat` (`chat_id`, `user_1`, `user_2`) VALUES
(3, 95, 111),
(4, 95, 113),
(7, 115, 115),
(12, 95, 115);

-- --------------------------------------------------------

--
-- Table structure for table `contacts`
--

CREATE TABLE `contacts` (
  `id` int(11) UNSIGNED NOT NULL,
  `1` longtext CHARACTER SET ucs2,
  `91` longtext,
  `92` longtext,
  `93` longtext,
  `94` longtext,
  `95` longtext,
  `96` longtext,
  `97` longtext,
  `98` longtext,
  `99` longtext,
  `100` longtext,
  `101` longtext,
  `102` longtext,
  `103` longtext,
  `106` longtext,
  `107` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `contacts`
--

INSERT INTO `contacts` (`id`, `1`, `91`, `92`, `93`, `94`, `95`, `96`, `97`, `98`, `99`, `100`, `101`, `102`, `103`, `106`, `107`) VALUES
(1, '0', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(95, NULL, NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `content`
--

CREATE TABLE `content` (
  `content_id` int(11) UNSIGNED NOT NULL,
  `content` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `content`
--

INSERT INTO `content` (`content_id`, `content`) VALUES
(92, 'приветик'),
(93, 'даров'),
(94, 'как делишки?'),
(95, 'нормасик, у тебя'),
(96, 'тож'),
(102, 'привет'),
(103, 'здорово!'),
(104, 'как жизнь?'),
(105, 'путём, у тебя?'),
(106, 'у меня тоже неплохо'),
(113, 'проверка связи!'),
(114, 'проверка связи!'),
(115, 'всё работает отлично'),
(116, 'так точно!'),
(117, 'очередная проверка'),
(118, 'проверяем'),
(119, 'пока работает'),
(120, 'действительно...'),
(121, 'надеюсь, так и продолжит');

-- --------------------------------------------------------

--
-- Table structure for table `message`
--

CREATE TABLE `message` (
  `message_id` int(11) UNSIGNED NOT NULL,
  `chat_id` int(11) UNSIGNED NOT NULL,
  `sender_id` int(11) UNSIGNED NOT NULL,
  `content_id` int(11) UNSIGNED NOT NULL,
  `send_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `message`
--

INSERT INTO `message` (`message_id`, `chat_id`, `sender_id`, `content_id`, `send_date`) VALUES
(27, 3, 111, 92, '2023-05-03 10:50:16'),
(28, 3, 95, 93, '2023-05-03 10:50:20'),
(29, 3, 111, 94, '2023-05-03 10:50:31'),
(30, 3, 95, 95, '2023-05-03 10:50:40'),
(31, 3, 111, 96, '2023-05-03 10:50:46'),
(37, 3, 95, 102, '2023-05-04 22:54:13'),
(38, 3, 111, 103, '2023-05-04 22:55:28'),
(39, 3, 95, 104, '2023-05-04 22:55:40'),
(40, 3, 111, 105, '2023-05-04 22:55:50'),
(41, 3, 95, 106, '2023-05-04 22:56:10'),
(48, 3, 111, 113, '2023-05-04 23:20:58'),
(49, 3, 95, 114, '2023-05-04 23:21:07'),
(50, 3, 111, 115, '2023-05-04 23:21:18'),
(51, 3, 95, 116, '2023-05-04 23:21:29'),
(52, 3, 95, 117, '2023-05-04 23:29:25'),
(53, 3, 111, 118, '2023-05-04 23:29:47'),
(54, 3, 95, 119, '2023-05-04 23:30:09'),
(55, 3, 111, 120, '2023-05-04 23:30:22'),
(56, 3, 95, 121, '2023-05-04 23:30:52');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) UNSIGNED NOT NULL,
  `login` mediumtext NOT NULL,
  `password` mediumtext NOT NULL,
  `first_name` mediumtext NOT NULL,
  `second_name` mediumtext NOT NULL,
  `job_name` mediumtext NOT NULL,
  `phone` text NOT NULL,
  `mail` text NOT NULL,
  `key_e` int(11) UNSIGNED DEFAULT NULL,
  `key_n` int(11) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `login`, `password`, `first_name`, `second_name`, `job_name`, `phone`, `mail`, `key_e`, `key_n`) VALUES
(1, 'root', 'root', 'admin', 'admin', '', '0', '', 0, 0),
(95, '1234', '0 1 9436', 'Олег', 'Тестов', 'Тестировщик', '89455432', 'some@mail.com', 37183, 18871),
(111, 'test3', '956 3750 3953 956 1990 956 3750 3953 956 1990', 'Тестировщик', 'Тестович', 'Программист', '8 (945) 672-33-44', 'test@test.com', 7567, 3979),
(112, '1', '0 1 9924 6616 4962 7939 3308 8506', 'Артём', 'Добров', 'Тестировщик', '8 (999) 999-99-99', 'test@mail.ru', 39071, 19847),
(113, '2', '0 1 4066 5421 2033 6505 6776 5808', 'Сергей', 'Проверкин', 'Тестировщик', '8 (999) 999-99-99', 'test@mail.ru', 15823, 8131),
(114, '3', '0 1 603 402 904 675 201 1033', 'Константин', 'Злобин', 'Тестировщик', '8 (999) 999-99-99', 'test@mail.ru', 1919, 1205),
(115, '123', '0 1 4002 2668 2001 4802 1334 3430', 'Никита', 'Обрящиков', 'Программист', '8 (495) 516-38-47', 'mail@mail.ru', 15599, 8003);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chat`
--
ALTER TABLE `chat`
  ADD PRIMARY KEY (`chat_id`),
  ADD KEY `user_1` (`user_1`) USING BTREE,
  ADD KEY `user_2` (`user_2`) USING BTREE;

--
-- Indexes for table `contacts`
--
ALTER TABLE `contacts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `content`
--
ALTER TABLE `content`
  ADD PRIMARY KEY (`content_id`);

--
-- Indexes for table `message`
--
ALTER TABLE `message`
  ADD PRIMARY KEY (`message_id`),
  ADD KEY `chat_id` (`chat_id`) USING BTREE,
  ADD KEY `sender_id` (`sender_id`) USING BTREE,
  ADD KEY `content_id` (`content_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`user_id`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chat`
--
ALTER TABLE `chat`
  MODIFY `chat_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `contacts`
--
ALTER TABLE `contacts`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=96;

--
-- AUTO_INCREMENT for table `content`
--
ALTER TABLE `content`
  MODIFY `content_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=122;

--
-- AUTO_INCREMENT for table `message`
--
ALTER TABLE `message`
  MODIFY `message_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=116;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chat`
--
ALTER TABLE `chat`
  ADD CONSTRAINT `chat_ibfk_1` FOREIGN KEY (`user_1`) REFERENCES `users` (`user_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `chat_ibfk_2` FOREIGN KEY (`user_2`) REFERENCES `users` (`user_id`) ON DELETE CASCADE;

--
-- Constraints for table `contacts`
--
ALTER TABLE `contacts`
  ADD CONSTRAINT `contacts_ibfk_1` FOREIGN KEY (`id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `message`
--
ALTER TABLE `message`
  ADD CONSTRAINT `message_ibfk_2` FOREIGN KEY (`sender_id`) REFERENCES `users` (`user_id`),
  ADD CONSTRAINT `message_ibfk_4` FOREIGN KEY (`chat_id`) REFERENCES `chat` (`chat_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `message_ibfk_5` FOREIGN KEY (`content_id`) REFERENCES `content` (`content_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
