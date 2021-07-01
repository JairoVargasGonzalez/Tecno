use TecnoHardw1;

insert into Proveedor(nombre,direccion,correo,telefono) values('Dell Colombia','Carrera 43 A #19-87','dellcolombia@gmail.com',3118565721),
('Hp Colombia','Carrera 43 A #19-87','dellcolombia@gmail.com',3153241585),
 ('Ibm Bogota','Calle 10 #41-25 ','ibmbogota@gmail.com',3203212233),
('Technology Medellin','Calle 44 #50-62','Technologymedellin@gmail.com',3012254488),
('Apple Colombia','Carrera 15 #28-90','Applecolombia@gmail.com',3133212356),
('Unilago Colombia','Calle 38 #35-70','unilagocolombia@gmail.com',3203215214);


insert into categoria(nom_categoria) values('Impresoras'),
('Monitores'),
('Servidores');

select * from categoria; 

insert into Producto(fk_id_categoria,nombre_producto,costo,descripcion_producto) values(1,'IMPRESORA MULTIFUNCIONAL HP INK TANK 315 AIO',831.731,'Inyección térmica de tinta.'),
 (2,'Monitor para PC HP 23.8',751.731,'monitor led.'),
 (2,'Monitor para PC dell 32.8',953.731,'monitor lcd.'),
 (2,'Monitor para PC Nexus 34.0',970.000,'monitor gamer.');


 insert into Proveedor_has_Producto(fkpkid_proveedor,fkpkid_producto) values (1,1);

 select * from Producto;


select nombre,direccion,correo,telefono,nombre_producto as producto,costo,descripcion_producto as descripcion
from Proveedor pr inner join Producto p on (pr.id_proveedor = p.id_producto)



select * from Proveedor;