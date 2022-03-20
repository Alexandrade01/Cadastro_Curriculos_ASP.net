create database auladb
use auladb

drop table Cadastros
--Criação de tabela
CREATE TABLE Cadastros(
	ID int NOT NULL Primary Key,
	CPF varchar(14) NOT NULL,
	Nome varchar(100) NOT NULL,
	endereco varchar(50) NULL,
	numero int NULL,
	DDD int NULL,
	telefone int NULL,
	email varchar(100)NULL,
	salario decimal(10,2)  NULL,
	cargo varchar(50) NULL,
	instituicao1 varchar(50) NOT NULL,
	formacao1 varchar(50) NOT NULL,
	conclusao1 datetime NOT NULL,
	instituicao2 varchar(50) NULL,
	formacao2 varchar(50) NULL,
	conclusao2 datetime NULL,
	instituicao3 varchar(50) NULL,
	formacao3 varchar(50) NULL,
	conclusao3 datetime NULL,
	instituicao4 varchar(50) NULL,
	formacao4 varchar(50) NULL,
	conclusao4 datetime NULL,
	instituicao5 varchar(50) NULL,
	formacao5 varchar(50) NULL,
	conclusao5 datetime NULL,
	empresa1 varchar(50) NULL,
	funcao1 varchar(50) NULL,
	empresa2 varchar(50) NULL,
	funcao2 varchar(50) NULL,
	empresa3 varchar(50) NULL,
	funcao3 varchar(50) NULL,
	idioma varchar(50) NULL,
	nivel varchar(50) NULL,

)

  set dateformat dmy
  insert into Cadastros(Id,CPF, nome, endereco, numero, DDD,telefone,email,salario,cargo,
						instituicao1,formacao1,conclusao1,instituicao2,formacao2,conclusao2,instituicao3,formacao3,conclusao3,instituicao4,formacao4,conclusao4,instituicao5,formacao5,conclusao5,
						empresa1,funcao1,empresa2,funcao2,empresa3,funcao3,
						idioma,nivel)

           values (2,'447.150.718-45','ratinho','rua java',12,11,43356413,'ratinho@bol.com',1750.00,'Gerente',
					'Mackenzie','Marketing',GETDATE(),null,null,null,null,null,null,null,null,null,null,null,null,
					'sbt','apresentador',null,null,null,null,
					'Ingles','Avancado')

