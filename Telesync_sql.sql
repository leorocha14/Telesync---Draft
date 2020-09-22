-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Telesync
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Telesync
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Telesync` DEFAULT CHARACTER SET utf8 ;
USE `Telesync` ;

-- -----------------------------------------------------
-- Table `Telesync`.`TPermissao`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TPermissao` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TPermissao` (
  `codPermissao` INT NOT NULL,
  `tipoPermissao` VARCHAR(30) NULL,
  PRIMARY KEY (`codPermissao`),
  UNIQUE INDEX `codPermissao_UNIQUE` (`codPermissao` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TUsuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TUsuario` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TUsuario` (
  `cpf` INT(11) UNSIGNED NOT NULL,
  `nome` VARCHAR(35) NOT NULL,
  `dtNasc` DATE NOT NULL,
  `sexo` CHAR(1) NOT NULL,
  `estadoCivil` VARCHAR(45) NULL,
  `nomeMae` VARCHAR(35) NULL,
  `uf` CHAR(2) NOT NULL,
  `cidade` VARCHAR(35) NOT NULL,
  `endereco` VARCHAR(35) NOT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `numero` INT(4) UNSIGNED NOT NULL,
  `complemento` VARCHAR(50) NULL,
  `bairro` VARCHAR(35) NOT NULL,
  `profissao` VARCHAR(45) NULL,
  `TPermissao_codPermissao` INT NOT NULL,
  `limiteDisponivel` VARCHAR(45) NULL,
  `limiteCredito` VARCHAR(45) NULL,
  `dataCadastro` VARCHAR(45) NULL,
  PRIMARY KEY (`cpf`, `TPermissao_codPermissao`),
  UNIQUE INDEX `cpfCliente_UNIQUE` (`cpf` ASC),
  INDEX `fk_TClientes_TPermissao1_idx` (`TPermissao_codPermissao` ASC),
  CONSTRAINT `fk_TClientes_TPermissao1`
    FOREIGN KEY (`TPermissao_codPermissao`)
    REFERENCES `Telesync`.`TPermissao` (`codPermissao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TLogin`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TLogin` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TLogin` (
  `TUsuario_cpf` INT(11) UNSIGNED NOT NULL,
  `email` VARCHAR(20) NOT NULL,
  `senha` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`TUsuario_cpf`),
  CONSTRAINT `fk_TLogin_TClientes1`
    FOREIGN KEY (`TUsuario_cpf`)
    REFERENCES `Telesync`.`TUsuario` (`cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TPlano`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TPlano` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TPlano` (
  `codPlano` INT NOT NULL,
  `tipo` VARCHAR(45) NULL,
  `limiteMin` INT NULL,
  `limiteGiga` INT NULL,
  `velocidade` INT NULL,
  `descricao` VARCHAR(45) NULL,
  `valor` FLOAT NULL,
  `dtCadastro` VARCHAR(45) NULL,
  PRIMARY KEY (`codPlano`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TCli_Plano`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TCli_Plano` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TCli_Plano` (
  `numeroTelefone` FLOAT NOT NULL,
  `TUsuario_cpf` INT(11) UNSIGNED NOT NULL,
  `ime` INT NOT NULL,
  `TPlano_codPlano` INT NOT NULL,
  PRIMARY KEY (`numeroTelefone`, `TUsuario_cpf`, `TPlano_codPlano`),
  INDEX `fk_TPedido_TClientes1_idx` (`TUsuario_cpf` ASC),
  INDEX `fk_TCli_Plano_TPlano1_idx` (`TPlano_codPlano` ASC),
  CONSTRAINT `fk_TPedido_TClientes1`
    FOREIGN KEY (`TUsuario_cpf`)
    REFERENCES `Telesync`.`TUsuario` (`cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TCli_Plano_TPlano1`
    FOREIGN KEY (`TPlano_codPlano`)
    REFERENCES `Telesync`.`TPlano` (`codPlano`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TVenda`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TVenda` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TVenda` (
  `codVenda` INT NOT NULL,
  `TCli_Plano_TUsuario_cpf` INT(11) UNSIGNED NOT NULL,
  `TCli_Plano_numeroTelefone` FLOAT NOT NULL,
  `TCli_Plano_TPlano_codPlano` INT NOT NULL,
  `quantidadeChips` INT NULL,
  `dtVenda` DATE NULL,
  `dtVencim` DATE NULL,
  `valorTotal` FLOAT NULL,
  `obs` VARCHAR(45) NULL,
  PRIMARY KEY (`codVenda`, `TCli_Plano_TUsuario_cpf`, `TCli_Plano_numeroTelefone`, `TCli_Plano_TPlano_codPlano`),
  INDEX `fk_Venda_TCli_Plano1_idx` (`TCli_Plano_numeroTelefone` ASC, `TCli_Plano_TUsuario_cpf` ASC, `TCli_Plano_TPlano_codPlano` ASC),
  CONSTRAINT `fk_Venda_TCli_Plano1`
    FOREIGN KEY (`TCli_Plano_numeroTelefone` , `TCli_Plano_TUsuario_cpf` , `TCli_Plano_TPlano_codPlano`)
    REFERENCES `Telesync`.`TCli_Plano` (`numeroTelefone` , `TUsuario_cpf` , `TPlano_codPlano`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TLog`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TLog` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TLog` (
  `codRegistro` INT NOT NULL,
  `tipoAlteracao` VARCHAR(45) NULL,
  `tipoJustificativa` VARCHAR(45) NULL,
  `TCli_Plano_numeroTelefone` FLOAT NOT NULL,
  `TCli_Plano_TUsuario_cpf` INT(11) UNSIGNED NOT NULL,
  `TCli_Plano_TPlano_codPlano` INT NOT NULL,
  `dtAlteracao` DATE NULL,
  PRIMARY KEY (`codRegistro`, `TCli_Plano_numeroTelefone`, `TCli_Plano_TUsuario_cpf`, `TCli_Plano_TPlano_codPlano`),
  INDEX `fk_Log_TCli_Plano1_idx` (`TCli_Plano_numeroTelefone` ASC, `TCli_Plano_TUsuario_cpf` ASC, `TCli_Plano_TPlano_codPlano` ASC),
  CONSTRAINT `fk_Log_TCli_Plano1`
    FOREIGN KEY (`TCli_Plano_numeroTelefone` , `TCli_Plano_TUsuario_cpf` , `TCli_Plano_TPlano_codPlano`)
    REFERENCES `Telesync`.`TCli_Plano` (`numeroTelefone` , `TUsuario_cpf` , `TPlano_codPlano`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Telesync`.`TRelatorio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Telesync`.`TRelatorio` ;

CREATE TABLE IF NOT EXISTS `Telesync`.`TRelatorio` (
  `codRelatorio` INT NOT NULL,
  `dtInicial` VARCHAR(45) NULL,
  `dtFinal` VARCHAR(45) NULL,
  `tipoRelatorio` VARCHAR(45) NULL,
  `descricao` VARCHAR(45) NULL,
  `Log_codRegistro` INT NOT NULL,
  `Log_TCli_Plano_numeroTelefone` FLOAT NOT NULL,
  `Log_TCli_Plano_TUsuario_cpf` INT(11) UNSIGNED NOT NULL,
  `Log_TCli_Plano_TPlano_codPlano` INT NOT NULL,
  PRIMARY KEY (`codRelatorio`, `Log_codRegistro`, `Log_TCli_Plano_numeroTelefone`, `Log_TCli_Plano_TUsuario_cpf`, `Log_TCli_Plano_TPlano_codPlano`),
  INDEX `fk_Relatorio_Log1_idx` (`Log_codRegistro` ASC, `Log_TCli_Plano_numeroTelefone` ASC, `Log_TCli_Plano_TUsuario_cpf` ASC, `Log_TCli_Plano_TPlano_codPlano` ASC),
  CONSTRAINT `fk_Relatorio_Log1`
    FOREIGN KEY (`Log_codRegistro` , `Log_TCli_Plano_numeroTelefone` , `Log_TCli_Plano_TUsuario_cpf` , `Log_TCli_Plano_TPlano_codPlano`)
    REFERENCES `Telesync`.`TLog` (`codRegistro` , `TCli_Plano_numeroTelefone` , `TCli_Plano_TUsuario_cpf` , `TCli_Plano_TPlano_codPlano`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Telesync` ;

-- -----------------------------------------------------
-- Placeholder table for view `Telesync`.`view1`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Telesync`.`view1` (`id` INT);

-- -----------------------------------------------------
-- View `Telesync`.`view1`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `Telesync`.`view1` ;
DROP TABLE IF EXISTS `Telesync`.`view1`;
USE `Telesync`;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
