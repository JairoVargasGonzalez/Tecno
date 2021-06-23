create database TecnoHardw1;
use TecnoHardw1;

 create table Proveedor
( 
id_proveedor varchar(5) not null,
nombre varchar (100) not null,
direccion varchar (100) not null,
correo varchar (150) not null,
telefono bigint  not null,
primary key (id_proveedor)
);

create table categoria (
 id_categoria INT not null,
  nom_categoria VARCHAR(70) NOT NULL,
  PRIMARY KEY (id_categoria)
 );
 

create table Producto( 
id_producto varchar(5) not null ,
pk_id_categoria INT not null,
nombre_producto varchar (150) not null,
costo double not null,
descripcion_producto varchar (150) not null,
primary key (id_producto,id_categoria)
);


 create table Proveedor_has_Producto
(
fkpkid_proveedor varchar(5) not null,
fkpkid_producto varchar(5) not null,
primary key (fkpkid_proveedor,fkpkid_producto)
);


alter table Producto
add constraint producto_categoria
foreign key (pk_id_categoria)
references categoria (id_categoria);


alter table Proveedor_has_Producto
add constraint producto_proveedor_producto
foreign key (fkpkid_producto)
references Producto (id_producto);

alter table Proveedor_has_Producto
add constraint proveedor_proveedor_producto
foreign key (fkpkid_proveedor)
references Proveedor (id_proveedor);




