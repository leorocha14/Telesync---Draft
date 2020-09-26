CREATE TABLE `tcliente` (
  `CPF` int(11) NOT NULL,
  `nome` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nomeMae` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `sexo` varchar(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `email` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `bairro` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cep` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `logradouro` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `numero` int(11) NOT NULL,
  `uf` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cidade` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `complemento` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `codLogin` varchar(50) NOT NULL,
  PRIMARY KEY (`CPF`) USING BTREE,
  UNIQUE KEY `email_UNIQUE` (`email`) USING BTREE,
  UNIQUE KEY `codLogin_UNIQUE` (`codLogin`),
  CONSTRAINT `tcliente_ibfk_1` FOREIGN KEY (`codLogin`) REFERENCES `tlogin` (`codLogin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tlogin` (
	`login` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`senha` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`cpf_usuario` INT(11) NOT NULL DEFAULT '0',
	PRIMARY KEY (`login`) USING BTREE,
	INDEX `FK_CPF_USUARIO` (`cpf_usuario`) USING BTREE
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=InnoDB
;

CREATE TABLE `tvendaplano` (
  `codVendaPlano` int(11) NOT NULL,
  `codVenda` int(11) NOT NULL,
  `codPlano` int(11) NOT NULL,
  `ddd` varchar(45) NOT NULL,
  `numero` varchar(45) NOT NULL,
  `numChip` varchar(45) NOT NULL,
  PRIMARY KEY (`codVendaPlano`),
  KEY `codVenda_idx` (`codVenda`),
  KEY `codPlano_idx` (`codPlano`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tvenda` (
  `codVenda` int(11) NOT NULL,
  `cpfCliente` int(11) NOT NULL,
  `codFormaPag` int(11) NOT NULL,
  `qtddPlanos` varchar(45) NOT NULL,
  `dtVenda` varchar(45) NOT NULL,
  `dtVencimento` varchar(45) NOT NULL,
  `valorTotal` varchar(45) NOT NULL,
  `obs` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codVenda`),
  KEY `cpfCliente_idx` (`cpfCliente`),
  KEY `codFormaPag_idx` (`codFormaPag`),
  CONSTRAINT `cpfCliente` FOREIGN KEY (`cpfCliente`) REFERENCES `tcliente` (`CPF`),
  CONSTRAINT `tvenda_ibfk_1` FOREIGN KEY (`codFormaPag`) REFERENCES `tformapagamento` (`codFormaPag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tplano` (
  `codPlano` int(11) NOT NULL,
  `nomePlano` varchar(45) NOT NULL,
  `tipo` varchar(45) NOT NULL,
  `valor` varchar(45) NOT NULL,
  PRIMARY KEY (`codPlano`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



CREATE TABLE `tformapagamento` (
  `codFormaPag` int(11) NOT NULL,
  `formaPagamento` varchar(45) NOT NULL,
  PRIMARY KEY (`codFormaPag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
