create table Pokemon(
	ID		INT			NOT NULL,
	Name	varchar(15) NOT NULL,
	Type1	varchar(10) NOT NULL,
	Type2	varchar(10),
	primary key (ID)
);

create table Items(
	Item_ID				int				not null,
	Item_Name			varchar(50)		not null,
	Item_Desciption		varchar(250)	not null,
	primary key (Item_ID)
);

create table Moves(
	Move_ID		int			not null,
	Move_Name	varchar(50) not null,
	Move_Type	varchar(10) not null,
	Move_Cat	varchar(10) not null,
	Move_PP     int			not null,
	Move_Power	varchar(5)	not null,
	Move_Acc	varchar(5)	not null,
	primary key(Move_ID)
);

create table Natures(
	Nature_ID		int			not null,
	Nature_Name		varchar(20) not null,
	Nature_Inc		varchar(20) not null,
	Nautre_Dec		varchar(20) not null
	primary key(Nature_ID)
);

create table Users(
	Users_ID	int IDENTITY(1,1)	not null,
	Users_Name	varchar(25)			not null,
	Users_Pass	varchar(20)			not null,
	primary key(Users_ID)
);




insert into Users (Users_Name,Users_Pass)
values('Admin','password')

Select * from Users;

drop table Users; 

delete from Users;