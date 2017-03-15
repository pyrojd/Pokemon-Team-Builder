CREATE TABLE SavedPokemon
(
	PDB_ID int not null,
	ID int not null, 
	NickName Varchar(15),
	Gender int,
	HP_EV int not null,
	ATK_EV int not null,
	DEF_EV int not null,
	SP_ATK_EV int not null,
	SP_DEF_EV int not null,
	SPD_EV int not null,
	HP_IV int not null,
	ATK_IV int not null,
	DEF_IV int not null,
	SP_ATK_IV int not null,
	SP_DEF_IV int not null,
	SPD_IV int not null,
	Nature_ID int not null,
	Ability_ID int not null,
	Item_ID int,
	Move_1 int,
	Move_2 int,
	Move_3 int,
	Move_4 int,
	In_Party bit not null,
	Team_Num int,
	Users_ID int not null,
	Primary Key(PDB_ID),
	Foreign Key (ID) References Pokemon(ID),
	Foreign Key (Nature_ID) References Natures(Nature_ID),
	Foreign Key (Ability_ID) References Ability(Ability_ID),
	Foreign Key (Item_ID) References Items(Item_ID),
	Foreign Key (Move_1) References Moves(Move_ID),
	Foreign Key (Move_2) References Moves(Move_ID),
	Foreign Key (Move_3) References Moves(Move_ID),
	Foreign Key (Move_4) References Moves(Move_ID),
	Foreign Key (Users_ID) References Users(Users_ID)
);

Create table Ability(
Ability_ID int not null,
Ability_Name varchar(25) not null,
Ability_Desc varchar(250) not null,
Primary Key(Ability_ID)
);

