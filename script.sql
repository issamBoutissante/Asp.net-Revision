--Client(Compte ,Nom ,Prenom ,Adresse,Email,Mdp)
--Operation(#Compte, Date , Type  , Montant)
create database ExercicedeRevisionWCS1
go 
use ExercicedeRevisionWCS1
go
create table Client(
Compte int primary key,
Nom varchar(20),
Prenom varchar(20),
Adresse varchar(50),
Email varchar(50),
Mdp varchar(20)
)
insert into Client values(1,'Boutissante','Issam','Tidili Mesefioua','Boutissante@gmail.com','boutissante')
create table Operation(
Compte int,
[Date] date,
[Type] varchar(10) check([Type]='Versement' or [Type]='Retrait'),
Montant money,
constraint pk_Operation primary key(Compte,[Date]),
constraint fk_Compte_Operation_Client foreign key(Compte) references Client(Compte)
)
insert into Operation values(1,GETDATE(),'Versement',90000)
