#CREATE SCHEMA `products_db` ;

CREATE TABLE `products_db`.`products_tb` (
  `idproducts_tb` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(45) NULL,
  `category` VARCHAR(45) NULL,
  `qty` INT NULL,
  `price` DECIMAL NULL,
  `timeofentry` DATETIME NULL,
  PRIMARY KEY (`idproducts_tb`));

CREATE TABLE `products_db`.`book` (
  `idbook` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NULL,
  `description` VARCHAR(45) NULL,
  `datecreated` VARCHAR(45) NULL,
  PRIMARY KEY (`idbook`));


CREATE TABLE `products_db`.`users_tb` (
  `idusers_tb` INT NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  PRIMARY KEY (`idusers_tb`));