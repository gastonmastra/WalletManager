create table users
(
id_user		decimal(2),
username	varchar(20),
passwd		varchar(20),
constraint pk_users PRIMARY KEY (id_user)
)

create table wallets
(
id_wallet	decimal(3),
walletName	varchar(20),
constraint pk_wallets PRIMARY KEY(id_wallet)
)

create table wallets_x_users
(
id_user		decimal(2),
id_wallet	decimal(3),
constraint pk_wallets_x_users PRIMARY KEY (id_user,id_wallet),
constraint fk_wallet_x_user_user FOREIGN KEY (id_user) REFERENCES users(id_user),
constraint fk_wallet_x_user_wallet FOREIGN KEY (id_wallet) REFERENCES wallets(id_wallet),
)

create table fixedExpense
(
id_fixedExpense	decimal(2),
name			varchar(15),
description		varchar(100),
mount			decimal(2),
constraint pk_fixedExpense PRIMARY KEY(id_fixedExpense)
)

create table fixedExpense_x_wallets
(
id_fixedExpense		decimal(2),
id_wallet			decimal(3),
constraint pk_fixedExpense_x_wallets PRIMARY KEY(id_fixedExpense, id_wallet),
constraint fk_fixedExpense_x_wallets_fixedExpense FOREIGN KEY (id_fixedExpense) REFERENCES FixedExpense (id_fixedExpense),
constraint fk_fixedExpense_x_wallets_wallet FOREIGN KEY (id_wallet) REFERENCES wallets (id_wallet),
)

create table typeOfMovements
(
id_typeMovement		int,
name				varchar(20),
constraint pk_typeOfMovements PRIMARY KEY(id_typeMovement)
)

create table clasifications
(
id_clasification	int,
description			varchar(100),
constraint pk_clasification	PRIMARY KEY (id_clasification)
)

create table persons
(
name		varchar(20),
surname		varchar(20),
debt		decimal(2),
constraint pk_person PRIMARY KEY(name, surname)
)

create table movements
(
id_movement			int,
descrip				varchar(100),
isDebt				varchar(1) default 'N',
mount				decimal(2) not null,
id_typeMovement		int not null,
id_clasification	int not null,
deudorName			varchar(20),
deudorSurname		varchar(20),
constraint pk_movement PRIMARY KEY (id_movement),
constraint fk_movement_typeOfMovement FOREIGN KEY (id_typeMovement) REFERENCES typeOfMovements(id_typeMovement),
constraint fk_movement_clasification FOREIGN KEY (id_clasification) REFERENCES clasifications (id_clasification),
constraint fk_movement_person FOREIGN KEY (deudorName, deudorSurname) REFERENCES persons (name, surname)
)
