/*************************************************************************************************************
Nombre Script            : dbTotalGym
Description              : Script para crear estructura de la base de datos
Version	                 : 1.0
Historia de Modificacion : IS	-	Fecha		-	Descripcion Cambio
                           ----		----------		----------------------------------------------------------
                           HECP		20/06/2016		Se creo el script inicial para crear la base de datos
**************************************************************************************************************/

USE TOTALGYM
CREATE TABLE PRODUCTOS
(
COD_PRO INT NOT NULL,
NOMBRE_PRO VARCHAR (30) NOT NULL,
DESCRIPCION VARCHAR (25) NOT NULL,
PRECIO INT NOT NULL,
CANTIDAD INT NOT NULL,
EXISTENCIA VARCHAR (10)NOT NULL,
PRIMARY KEY (COD_PRO)
)
INSERT INTO PRODUCTOS
VALUES(10774,'PROTEINA','GANA MASA MUSCULAR',$800,30,'SI')
INSERT INTO PRODUCTOS
VALUES(11774,'SUPLEMENTOS','SUPLEMENTA LA COMIDA',$850,20,'SI')
INSERT INTO PRODUCTOS
VALUES(12774,'TOALLAS','LIMPIAR EL SUDOR',$25,30,'SI')
INSERT INTO PRODUCTOS
VALUES(13774,'ROPA DEPORTIVA','PRACTICA DE DEPORTES',$250,10,'SI')
INSERT INTO PRODUCTOS
VALUES(14774,'AGUA','HIDRATACION DEL CUERPO',$15,40,'SI')
INSERT INTO PRODUCTOS
VALUES(15774,'BEBIDAS DEPORTIVAS','HIDRATA EL CUERPO',$18,20,'SI')
INSERT INTO PRODUCTOS
VALUES(16774,'CANTINFLORAS','PARA TOMAR AGUA',$20,5,'SI')
INSERT INTO PRODUCTOS
VALUES(17774,'GUANTES','PARA ENTRENAR',$300,12,'SI')
INSERT INTO PRODUCTOS
VALUES(18774,'BARRITAS ENERGETICAS','SUPLEMENTOS ALIMIENTICIOS',$15,19,'SI')
INSERT INTO PRODUCTOS
VALUES(19774,'FAJAS DEPORTIVAS','AMPLIFICA LOS BENEFICIOS',$200,5,'SI')
INSERT INTO PRODUCTOS
VALUES(20774,'PROTEINA PRO-NOS','PARA LA MASA MUSCULAR',$850,4,'SI')
INSERT INTO PRODUCTOS
VALUES(21774,'GAINER','SUPLEMENTO PARA LA COMIDA',$900,10,'SI')
INSERT INTO PRODUCTOS
VALUES(22774,'SERIUS MAS','PARA MASA MUSCULAR',$800,20,'SI')
INSERT INTO PRODUCTOS
VALUES(23774,'LIGAS DEPORTIVAS','HACER EJERCICIO',$99,10,'SI')
INSERT INTO PRODUCTOS
VALUES(24774,'MOCHILAS','CARGA EL EQUIPO DEPORTIVO',$300,3,'SI')
INSERT INTO PRODUCTOS
VALUES(25774,'AMINOACIDO EN POLVO','AUMENTA LA ENERGIA',$870,5,'SI')

create database TotalGym


create table Clientes
(
ID_Cliente int not null,
Nombre varchar (30) not null,
Apellido varchar (30)not null,
Edad int not null,
Telefono numeric (20)  not null,
Domicilio varchar (30) not null,
fecha_activo datetime not null,
fecha_cad datetime not null,
)
insert into Clientes 
Values (9878,'Carlos David','Fiscal Gonzalez',19,8114741541,'San Nicolas de los Garza','2016/01/10','2016/03/11')
insert into Clientes
 Values (9890,'Deysi Maria','Rebolorio Mendez',20,8187498738,'Escobedo','2016/01/20','2016/02/5')
insert into Clientes
 Values (9046,'Carlos Alberto','Galvez Chavez',18,8198798778,'Apodaca','2016/01/15','2016/05/15' )
insert into Clientes
 Values (9098,'Sergio David','Sanchez Garcia',18,8176536554,'San Nicolas de los Garza','2016/01/10','2017/01/25')
insert into Clientes 
Values (9121,'Carolina Alejandra','Gonzalez Garcia',22,819387623,'Escobedo','2016/01/18','2016/12/30')
insert into Clientes
 Values (9231,'Francisco Antonio','Mendez Villarreal',21,8177757111,'Apodaca','2016/01/04','2017/11/27')
insert into Clientes
 Values (9111,'Juan Antonio','Rodriguez Perez',23,8176327672,'Escobedo','2016/01/08','2016/10/19')
insert into Clientes 
Values (9910,'Eduardo Misael','Mendoza Oviedo',22,8187632876,'Apodaca','2016/01/29','2017/05/21')
insert into Clientes 
Values (9921,'Jose Ricardo','Mendoza Palomo',20,8109320931,'San Nicolas de los Garza','2016/01/12','2016/09/13')
insert into Clientes
 Values (9467,'Brandon Elian','Avila Hernandez',24,8179891892,'Escobedo','2016/01/15','2016/06/30')
insert into Clientes 
Values (9902,'Dora Maria','Mendez Sanchez',23,8112334412,'San Nicolas de los Garza','2016/01/11','2016/12/31')
insert into Clientes
 Values (9822,'Cesar Adrian','Montemayor Villarreal',25,8143258775,'Escobedo','2016/01/18','2017/02/01')
insert into Clientes 
Values (9982,'Juan Pablo','velazquez Escobar',20,8183360594,'San Nicolas de los Garza','2016/01/23','2016/11/27')
insert into Clientes 
Values (9863,'Pedro Alejandro','Hernandez Martinez',22,8187872872,'Escobedo','2016/01/19','2016/09/12')

SELECT*FROM Clientes
drop table Clientes 

CREATE TABLE PERSONAL 

(
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
AREA VARCHAR (25) NOT NULL,
CODIGO INT NOT NULL, 
)
INSERT INTO PERSONAL
VALUES('Pablo Jose','Mendez Echeverria','Entrenador',3015)
INSERT INTO PERSONAL
VALUES('Miguel','Sanchez Sanchez','Intendente',30151)
INSERT INTO PERSONAL
VALUES('Eduardo','Mendez Leal','Entrenador Personal',30152)
INSERT INTO PERSONAL
VALUES('Zaira Yazmin','Sanchez Lopez','Ventas',30153)
INSERT INTO PERSONAL
VALUES('Graciela','Echeverria Caballero','Intendente',30154) 

CREATE TABLE EQUIPO
(
COD_EQUIPO INT NOT NULL,
CANTIDAD INT NOT NULL,
NOM_EQUIPO VARCHAR (30)NOT NULL,
)
INSERT INTO EQUIPO 
VALUES(2010,20,'Pesas')
INSERT INTO EQUIPO
VALUES(2011,8,'Caminadoras')
INSERT INTO EQUIPO
VALUES(2012,5,'Escaladoras')
INSERT INTO EQUIPO
VALUES(2013,5,'Maquina eleptica')
INSERT INTO EQUIPO
VALUES(2014,4,'Banco de pecho plano')
INSERT INTO EQUIPO
VALUES(2015,3,'Maquina extenciones')
INSERT INTO EQUIPO
VALUES(2016,4,'Banco para hombro')
INSERT INTO EQUIPO
VALUES(2017,2,'Giro de cintura')
INSERT INTO EQUIPO
VALUES(2018,8,'Porta discos')
INSERT INTO EQUIPO
VALUES(2019,6,'Prensa atletica')
INSERT INTO EQUIPO
VALUES(2020,10,'Mancuernas')
INSERT INTO EQUIPO
VALUES(2021,3,'Predicador')
INSERT INTO EQUIPO
VALUES(2022,8,'Barra')
INSERT INTO EQUIPO
VALUES(2023,8,'Barra plana')
INSERT INTO EQUIPO
VALUES(2024,8,'Bicicletas')
INSERT INTO EQUIPO
VALUES(2025,20,'Discos')
INSERT INTO EQUIPO
VALUES(2026,5,'Barra z')
INSERT INTO EQUIPO
VALUES(2027,4,'Maquina para gluteos')
INSERT INTO EQUIPO
VALUES(2028,6,'Prensa')



Create table TIPO
 (
 ID_Cliente int not null,
 Contraseña varchar(20) not null,
 Tipo varchar (30) not null,
 )

insert into TIPO 
values (9046,'usuario','administrador')
insert into TIPO
values (9098,'cliente','Usuario')
insert into TIPO 
Values (9878,'cliente','Usuario')
insert into TIPO 
Values(9890,'cliente','Usuario')
insert into TIPO 
Values (9121,'cliente','Usuario')
insert into TIPO
Values (9231,'cliente','Usuario')
insert into TIPO
Values (9111,'cliente','usuario')
insert into TIPO 
Values (9910,'cliente','cliente')
insert into TIPO
Values (9921,'cliente','cliente')
insert into TIPO
Values (9467,'cliente','cliente')
insert into TIPO 
Values (9902,'cliente','cliente')
insert into TIPO
Values (9822,'cliente','cliente')
insert into TIPO 
Values (9982,'cliente','cliente')
insert into TIPO 
Values (9863,'cliente','cliente')



