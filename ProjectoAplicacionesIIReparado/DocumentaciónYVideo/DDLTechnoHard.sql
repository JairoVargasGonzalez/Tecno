create database TecnoHardw1;
use TecnoHardw1;

 create table Proveedor
( 
id_proveedor  int identity  not null,
nombre varchar (100) not null,
direccion varchar (100) not null,
correo varchar (150) not null,
telefono bigint  not null,
primary key (id_proveedor)
);

create table categoria (
 id_categoria INT  identity not null,
  nom_categoria VARCHAR(70) NOT NULL,
  PRIMARY KEY (id_categoria)
 );
 

create table Producto( 
id_producto int identity not null ,
fk_id_categoria INT not null,
nombre_producto varchar (150) not null,
costo float not null,
descripcion_producto varchar (150) not null,
primary key (id_producto)
);


 create table Proveedor_has_Producto
(
id_proveedor_producto int identity  not null, 
fkpkid_proveedor int not null,
fkpkid_producto int not null,
primary key (id_proveedor_producto, fkpkid_proveedor,fkpkid_producto)
);


alter table Producto
add constraint producto_categoria
foreign key (fk_id_categoria)
references categoria (id_categoria);


alter table Proveedor_has_Producto
add constraint producto_proveedor_producto
foreign key (fkpkid_producto)
references Producto (id_producto);

alter table Proveedor_has_Producto
add constraint proveedor_proveedor_producto
foreign key (fkpkid_proveedor)
references Proveedor (id_proveedor);




