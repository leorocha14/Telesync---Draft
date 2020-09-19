CREATE TABLE `tcliente` (
	`cpf` INT(11) NOT NULL,
	`nome` VARCHAR(45) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`nome_mae` VARCHAR(45) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`sexo` VARCHAR(1) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`email` VARCHAR(45) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`dt_nasc` DATE NOT NULL,
	`bairro` VARCHAR(30) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`cep` VARCHAR(8) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`logradouro` VARCHAR(45) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`numero` INT(11) NOT NULL,
	`uf` VARCHAR(2) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`cidade` VARCHAR(15) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`complemento` VARCHAR(80) NULL DEFAULT NULL COLLATE 'utf8mb4_0900_ai_ci',
	PRIMARY KEY (`cpf`) USING BTREE,
	UNIQUE INDEX `email_UNIQUE` (`email`) USING BTREE
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=MyISAM
;

CREATE TABLE `tlogin` (
	`login` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`senha` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`cpf_usuario` INT(11) NOT NULL DEFAULT '0',
	PRIMARY KEY (`login`) USING BTREE,
	INDEX `FK_CPF_USUARIO` (`cpf_usuario`) USING BTREE
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=MyISAM
;
