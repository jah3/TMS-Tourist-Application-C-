
USE MASTER
GO
IF EXISTS(SELECT'True'FROM SYS.DATABASES WHERE NAME='Turism')
BEGIN
DROP DATABASE Turism
END
GO
CREATE DATABASE Turism
GO
USE Turism
GO

CREATE TABLE destination
	(d_id int  PRIMARY KEY,
	where_ varchar(255),
	to_ varchar(255),
	tour varchar(255),
	retour varchar(255), 
	seats int);




	
CREATE TABLE customer
	(c_id int  PRIMARY KEY, 
	fname varchar(255),
	lname varchar(255),
	address_ varchar(255),
	email varchar(255),
	d_id int FOREIGN KEY REFERENCES destination(d_id));


CREATE TABLE housing
	(h_id int PRIMARY KEY,
	country varchar(255),
	hlocation varchar(255),
	hname varchar(255),
	hrating int,
	price int);

CREATE TABLE transport
	(t_id int primary key,
	t_Company varchar(255),
	t_cost int);

CREATE TABLE package
	(p_id int  PRIMARY KEY,
	cost int, 
	noofdays int, 
	packagetype varchar(255), 
	contact varchar(255), 
	discount float,
	d_id int FOREIGN KEY REFERENCES destination(d_id),
	h_id int FOREIGN KEY REFERENCES housing(h_id),
	t_id int FOREIGN KEY REFERENCES transport(t_id));



CREATE TABLE tours
	(to_id int  PRIMARY KEY, 
	seats int, 
	types_ varchar(255), 
	p_id int FOREIGN KEY REFERENCES package(p_id));



CREATE TABLE Bill
	 (b_id int PRIMARY KEY,
	 c_id int FOREIGN KEY REFERENCES customer(c_id),
	 p_id int FOREIGN KEY REFERENCES package(p_id),
	 d_id int FOREIGN KEY REFERENCES destination(d_id),
	 h_id int FOREIGN KEY REFERENCES housing(h_id),
	 t_id int FOREIGN KEY REFERENCES transport(t_id),
	 to_id int FOREIGN KEY REFERENCES tours(to_id));




-------------------------------------------------------------------------------------------------------------------------------------
--|																																	|
--|														INSERT													    				|
--|																										 							|
-------------------------------------------------------------------------------------------------------------------------------------
insert into destination values
			 (1, 'Chisinau', 'Denmark','5/4/2022', '5/20/2022', 2),
			 (2, 'Chisinau', 'Denmark','5/4/2022', '5/20/2022', 2),
			 (3, 'Chisinau', 'Denmark','5/4/2022', '5/20/2022', 2),
			 (4, 'Moldova',  'Cyprus', '5/4/2022', '5/19/2022', 2),
			 (5, 'Moldova',  'Cyprus', '5/4/2022', '5/19/2022', 2),
			 (6, 'Moldova',  'Cyprus', '5/4/2022', '5/19/2022', 2),
			 (7, 'Chisinau', 'Japan',  '5/30/2022','6/4/2022', 3),
			 (8, 'Chisinau', 'Japan',  '5/30/2022','6/4/2022', 3),
			 (9, 'Chisinau', 'Japan',  '5/30/2022','6/4/2022', 3),
			 (10,'Chisinau', 'Orhei',  '5/4/2022', '5/25/2022', 4),
			 (11,'Chisinau', 'Orhei',  '5/4/2022', '5/25/2022', 4),
			 (12,'Chisinau', 'Orhei',  '5/4/2022', '5/25/2022', 4),
			 (13,'Chisinau', 'Turkey', '5/4/2022', '5/18/2022', 3),
			 (14,'Chisinau', 'Turkey', '5/4/2022', '5/18/2022', 3),
			 (15,'Chisinau', 'Turkey', '5/4/2022', '5/18/2022', 3),
			 (16,'Moldova',  'Greece', '5/4/2022', '5/26/2022', 2),
			 (17,'Moldova',  'Greece', '5/4/2022', '5/26/2022', 2),
			 (18,'Moldova',  'Greece', '5/4/2022', '5/26/2022', 2);

iNSERT into customer VALUES
			(1,'Ion','Gutu','Lomonosov 2/5','gutuionica@gamail.com',1),
			(2, 'Chirila ', 'Sasaran ','Str. Pacurari 4A', 'cornea.teea@hotmail.com', 2),
			(3, 'Paul ', 'Dabija ','P-ta Mircea cel Batrân 5/4', 'ispas.savina@gmail.com', 3),
			(4, 'Pasca ', 'Eremia ','Str. Cire?ilor 7/8, Soroca','gabriela.sima@nistor.org', 4),
			(5, 'Florin ', 'Coman ','Str-la Croitorilor 350', 'janina.costache@iorga.com', 5),
			(6, 'Bucur ', 'Barbulescu','Str. Alexandru cel Bun nr. 8A','beatrice10@yahoo.com', 6),
			(7, 'Agata ', 'Iliescu ','P-ta Zidarilor nr. 04', 'adam07@hotmail.com', 7),
			(8, 'Rodica ', 'Maftei ', 'Str-la 31 August 1989 nr. 007', 'iosif.olteanu@gmail.com', 8),
			(9, 'Gherman ', 'Adonis ', 'B-dul. Pacurari 890', 'tamara.voinea@yahoo.com', 9),
			(10,'Ardelean ', 'Georgiana ', 'Aleea Veronica Micle 6', 'ursu.iustinian@gmail.com', 10),
			(11,'Ilie ', 'Moga ', 'Aleea Independen?ei 3B', 'lorin49@stanescu.com', 11),
			(12,'Alistar ', 'Nita ', 'Aleea Lenin 512', 'livia.macovei@miron.com', 12),
			(13,'Nadia ', 'Lupu ', 'P-ta Decebal 7A', 'axinte80@yahoo.com', 13),
			(14,'Timea ', 'Mazilu ', 'P-ta Veronica Micle nr. 7A', 'cantemir63@yahoo.com', 14),
			(15,'Silvana ', 'Ardeleanu ', N'Str-la Padurii 003', 'vlad.macovei@oancea.biz', 15),
			(16,'Carmen', 'Trif ', 'Str-la Cire?ilor 0', 'iancu80@tudose.com', 16),
			(17,'Corvin ', 'Alexa ', 'P-ta Padurii nr. 3A', 'tgrosu@hotmail.com', 17),
			(18,'Gica ', 'Georgescu ', 'B-dul. Chisinau 021', 'flaviu07@gmail.com', 18);


insert into housing values
			(1,  'Denmark', 'Odense', 'Cabinn Copenhagen', 3, 80),
			(2,  'Denmark', 'Arhus', 'Borgergade', 2, 70),
			(3,  'Denmark', 'Odense', 'Cabinn Copenhagen', 3, 80),
			(4,  'Cyprus', 'Nicosia', 'Mikes Kanarium City Hotel', 3, 73),
			(5,  'Cyprus', 'Paphos', 'Art & Wine Studios and Apts', 3, 93),
			(6,  'Cyprus', 'Paphos', 'Mikes Kanarium City Hotel', 3, 73),
			(7,  'Japan',  'Okinawa', 'Sunrise Kanko Hotel', 5, 80),
			(8,  'Japan',  'Kyoto', 'Sunrise Kanko Hotel', 5, 80),
			(9,  'Japan',  'Okinawa', 'Okinawa Grand Mer Resort', 4, 70),
			(10, 'Orhei',  'Old Orhei', 'STARK HOTEL', 3,40 ),
			(11, 'Orhei',  'Orhei Land', 'Book Vila Elat ', 5, 20),
			(12, 'Orhei',  'Old Orhei', 'Book Vila Elat ', 5, 20),
			(13, 'Turkey', 'Antalya', 'Crowne Plaza Antalya, an IHG Hotel', 5, 80),
			(14, 'Turkey', 'Hagia Sophia', 'Akra Hotel', 5, 100),
			(15, 'Turkey', 'Antalya', 'Crowne Plaza Antalya, an IHG Hotel', 5, 80),
			(16, 'Greece', 'Crete', 'Mrs Chryssana Beach Hotel', 4, 75),
			(17, 'Greece', 'Santorini', 'Santo Miramare Resort', 5, 80),
			(18, 'Greece', 'Crete', 'Mrs Chryssana Beach Hotel', 4, 75);



insert into transport values
			(1, 'Danish Air Flybilletter', 470),
			(2, 'Denmark Bus: Havnbus', 300),
			(3, 'Cyprus Airways', 330),
			(4, 'Love Buses Cyprus', 370),
			(5, 'Japan Airline', 1800),
			(6, 'ANA, Turkish Airlines', 1200),
			(7, 'MoldovaBus', 15),
			(8, 'Rutiera', 5),
			(9, 'Turkish Airlines', 450),
			(10,'Multiple Airlines', 350),
			(11,'Airline:Ryanair', 500),
			(12,'Airline:easyJet', 555);

insert into package values
			(1, 10, 16, 'Silver', '+454227442', 5, 1, 1, 1),
			(2, 20, 16, 'Gold',   '+424254442', 10, 2, 2, 2),
			(3, 35, 16, 'Diamond','+357422744', 15, 3, 3, 1),
			(4, 10, 15, 'Silver', '+454227442', 5, 4, 4, 3),
			(5, 20, 15, 'Gold',   '+424254442', 10, 5, 5, 4),
			(6, 35, 15, 'Diamond','+357422744', 15, 6, 6, 4),
			(7, 10, 5, 'Silver',  '+454227442', 5, 7, 7, 5),
			(8, 20, 5, 'Gold',    '+424254442', 10, 8, 8, 6),
			(9, 35, 5, 'Diamond', '+357422744', 15, 9, 9, 6),
			(10, 10, 21,'Silver', '+454227442', 5, 10, 10, 7),
			(11, 20, 21,'Gold',   '+424254442', 10, 11, 11, 8),
			(12, 35, 21,'Diamond','+357422744', 15, 12, 12, 7),
			(13, 10, 14,'Silver', '+454227442', 5, 13, 13, 9),
			(14, 20, 14,'Gold',   '+424254442', 10, 14, 14, 10),
			(15, 35, 14,'Diamond','+357422744', 15, 15, 15, 9),
			(16, 10, 22,'Silver', '+454227442', 5, 16, 16, 11),
			(17, 20, 22,'Gold',   '+424254442', 10, 17, 17, 12),
			(18, 35, 22,'Diamond','+357422744', 15, 18, 18, 11);

insert into tours values 
			 (1, 2, 'Shopping Tour', 1),
			 (2, 2, 'Mountain Skiing Tour', 2),
			 (3, 2, 'Traditional Excursion Tour', 3),
			 (4, 2, 'Sport and Extreme Tour', 4),
			 (5, 2, 'Pilgrimage', 5),
			 (6, 2, 'Wedding Tour', 6),
			 (7, 3, 'Wedding Tour', 7),
			 (8, 3, 'Sport', 8),
			 (9, 3, 'Shopping Tour', 9),
			 (10, 4,'Traditional Excursion Tour', 10),
			 (11, 4,'Sport and Extreme Tour', 11),
			 (12, 4,'Mountain Skiing Tour', 12),
			 (13, 3,'Traditional Excursion Tour', 13),
			 (14, 3,'Sport and Extreme Tour', 14),
			 (15, 3,'Mountain Skiing Tour', 15),
			 (16, 2,'Shopping Tour', 16),
			 (17, 2,'Traditional Excursion Tour', 17),
			 (18, 2,'Wedding Tour', 18);

insert into Bill values
			(1, 1, 1, 1, 1, 1, 1),
			(2, 2, 2, 2, 2, 2, 2),
			(3, 3, 3, 3, 3, 1, 3),
			(4, 4, 4, 4, 4, 3, 4),
			(5, 5, 5, 5, 5, 4, 5),
			(6, 6, 6, 6, 6, 4, 6),
			(7, 7, 7, 7, 7, 5, 7),
			(8, 8, 8, 8, 8, 6, 8),
			(9, 9, 9, 9, 9, 6, 9),
			(10, 10, 10, 10, 10, 7, 10),
			(11, 11, 11, 11, 11, 8, 11),
			(12, 12, 12, 12, 12, 7, 12),
			(13, 13, 13, 13, 13, 9, 13),
			(14, 14, 14, 14, 14, 10, 14),
			(15, 15, 15, 15, 15, 9, 15),
			(16, 16, 16, 16, 16, 11, 16),
			(17, 17, 17, 17, 17, 12, 17),
			(18, 18, 18, 18, 18, 11, 18);







	IF OBJECT_ID('SelectAllCustomers', 'P') IS NOT NULL
	DROP PROC SelectAllCustomers
	GO
	CREATE PROCEDURE SelectAllCustomers
	AS
	SELECT customer.c_id, customer.fname, customer.lname,  package.packagetype, destination.to_, housing.hlocation, housing.hname  , tours.types_ ,(housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere
	FROM customer, package, destination, housing, transport, Bill,tours
	WHERE customer.c_id = Bill.c_id 
	AND package.p_id = Bill.p_id 
	AND destination.d_id = Bill.d_id 
	AND housing. h_id = Bill.h_id 
	AND transport.t_id = Bill.t_id
	AND tours.to_id = Bill.to_id
	AND housing.h_id = Bill.h_id
	GO
	EXEC SelectAllCustomers;




	
	IF OBJECT_ID('Report_', 'P') IS NOT NULL
	DROP PROC Report_
	GO
	CREATE PROCEDURE Report_
	AS
	SELECT customer.c_id, customer.fname, customer.lname,  package.packagetype, destination.where_,destination.to_,destination.tour, destination.retour, housing.hlocation, housing.hname  , tours.types_ ,transport.t_Company,  (housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere
	FROM customer, package, destination, housing, transport, Bill,tours
	WHERE customer.c_id = Bill.c_id 
	AND package.p_id = Bill.p_id 
	AND destination.d_id = Bill.d_id 
	AND housing. h_id = Bill.h_id 
	AND transport.t_id = Bill.t_id
	AND tours.to_id = Bill.to_id
	AND housing.h_id = Bill.h_id
	GO
	EXEC Report_ 

--Sarcina 2


select customer.c_id, customer.fname, customer.lname,  package.packagetype, destination.to_, housing.hlocation, housing.hname
	FROM customer, package, destination, housing,  Bill
	where customer.c_id = Bill.c_id
	AND package.p_id = Bill.p_id
	AND destination.d_id = Bill.d_id
	AND housing.h_id = Bill.h_id


select * from Bill





SELECT customer.fname, package.packagetype, destination.to_ , destination.tour, destination.retour, tours.types_ ,  (housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere
FROM customer, package, destination, housing, transport, Bill,tours
WHERE customer.c_id = Bill.c_id 
AND package.p_id = Bill.p_id 
AND  destination.d_id = Bill.d_id 
AND housing. h_id = Bill.h_id 
AND transport.t_id = Bill.t_id   
AND tours.to_id = Bill.to_id 
--1
SELECT customer.fname, package.packagetype, destination.to_ , destination.tour, destination.retour, tours.types_ ,  (housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere
FROM customer, package, destination, housing, transport, Bill,tours
WHERE customer.c_id = Bill.c_id 
AND package.p_id = Bill.p_id 
AND  destination.d_id = Bill.d_id 
AND housing. h_id = Bill.h_id 
AND transport.t_id = Bill.t_id   
AND tours.to_id = Bill.to_id 
AND tours.types_ like '%Wedding Tour'
--2
SELECT customer.fname,housing.hname
FROM customer, housing ,Bill
WHERE customer.c_id = Bill.c_id 
AND housing. h_id = Bill.h_id
AND customer.fname like 'Ion'
--4
SELECT customer.fname,housing.hname, destination.to_,destination.tour, destination.retour
FROM customer, destination, housing, Bill
WHERE customer.c_id = Bill.c_id 
AND  destination.d_id = Bill.d_id 
AND housing. h_id = Bill.h_id 
AND housing.hname like 'Borgergade'
and destination.tour like'2/09/2022'
and destination.retour like'2/15/2022'
--6
SELECT housing.hname, tours.types_
FROM  tours, housing, Bill
WHERE  tours.to_id = Bill.to_id 
AND housing. h_id = Bill.h_id 
AND housing.hlocation like 'Odense'
--7
SELECT customer.fname,package.packagetype
FROM customer, package,Bill
WHERE customer.c_id = Bill.c_id 
AND package.p_id = Bill.p_id 
and package.packagetype like 'Diamond'


SELECT  housing.hname, transport.t_Company
	FROM customer, package, destination, housing, transport, Bill,tours
	WHERE customer.c_id = Bill.c_id 
	AND package.p_id = Bill.p_id 
	AND destination.d_id = Bill.d_id 
	AND housing. h_id = Bill.h_id 
	AND transport.t_id = Bill.t_id
	AND tours.to_id = Bill.to_id
	AND housing.h_id = Bill.h_id AND housing.hname like 'Okinawa Grand Mer Resort'

	select * from customer
	select * from transport
	select * from Bill
	select * from housing
	select * from destination
	select * from package
	select * from tours