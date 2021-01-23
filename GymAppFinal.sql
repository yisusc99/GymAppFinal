create database gymapp;
use gymapp;

create table users(
	id_user int primary key auto_increment,
    name text,
    lastname text,
    user varchar(25),
    passw varchar(255),
    rol varchar(30),
    img varchar(255),
    admission_date date
);

create table product(
	id_product int primary key auto_increment,
    name varchar(30),
    price double,
    description varchar(100),
    amount int,
    category varchar(30),
    img varchar(255)
);

create table sales(
	id_venta int primary key auto_increment,
	id_product int,
    amount int,
    price double,
    s_date date
); 
create table tmp(
	id int,
    nombre varchar(30),
    precio double,
    cantidad int,
    subtotal varchar(255)
);