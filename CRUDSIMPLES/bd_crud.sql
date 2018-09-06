create database bd_crud;
use bd_crud;

create table tbl_usuario(

	cod_usuario int not null primary key auto_increment,
    nomeUsuario varchar(100) not null,
    email varchar(100) not null,
    celular int(12) not null,
    senha varchar(16) not null
);
