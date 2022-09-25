CREATE TABLE Pessoa(
	CPF int identity,
    Nome varchar(50), NOT NULL
    Sexo char(1), NOT NULL
    DataNascimento datetime, NOT NULL
    Telefone varchar(11), NOT NULL
    Cidade varchar(30), NOT NULL
    SiglaEstado char(2), NOT NULL
    Rua varchar(30), NOT NULL
    Bairro varchar(30), NOT NULL
    Numero char(5), NOT NULL

	constraint CPF_PESSOA primary key (CPF)
);

CREATE TABLE Animal(
	Chip int identity,
    Nome varchar(10),
    Raca varchar(20), NOT NULL
    Sexo char(1), NOT NULL
    Familia varchar(20), NOT NULL
    Adotante varchar(20),

	foreign key(Adotante) references Pessoa(CPF),
	constraint CHIP_ANIMAL primary key (Chip)

);