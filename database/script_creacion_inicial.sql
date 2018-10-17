/* Script de creación inicial - TP 2C 2018 */


create schema tpgdd -- Hay que cambiarlo por el verdadero nombre del esquema
go

create table tpgdd.usuario (
id numeric(10) identity(1,1),
username varchar(16) not null,
password varchar(32) not null,
tipo varchar(7) not null,
logins_fallidos numeric(1) not null default 0,
baja_logica bit not null default 1
)

alter table tpgdd.usuario add constraint pk_usuario primary key (id)
alter table tpgdd.usuario add constraint unq_username unique (username)




create table tpgdd.empresa (
id numeric(10) identity(1,1),
id_usuario numeric(10),
razon_social nvarchar(255) not null,
email nvarchar(50),
telefono varchar(20),
direccion_calle nvarchar(50),
direccion_numero numeric(18,0),
direccion_piso numeric(18,0),
direccion_departamento nvarchar(50),
codigo_postal varchar(8),
ciudad nvarchar(50),
cuit nvarchar(255) not null,
baja_logica bit not null default 1
)

alter table tpgdd.empresa add constraint pk_empresa primary key (id)
alter table tpgdd.empresa add constraint fk_empresa_usuario foreign key (id_usuario) references tpgdd.usuario
alter table tpgdd.empresa add constraint unq_razonsocial unique (razon_social)
alter table tpgdd.empresa add constraint unq_cuit unique (cuit)



create table tpgdd.cliente (
id numeric(10) identity(1,1),
id_usuario numeric(10),
tipo_dni nvarchar(4) not null, --No hay tipos de doc en la tabla maestra
numero_dni numeric(18,0) not null,
cuil nvarchar(255),
apellido nvarchar(255),
nombre nvarchar(255),
fecha_nacimiento date,
email nvarchar(255),
telefono nvarchar(20),
domicilio_calle nvarchar(255),
domicilio_numero numeric(18,0),
domicilio_piso numeric(18,0),
domicilio_departamento nvarchar(255),
codigo_postal nvarchar(255),
fecha_creacion date not null default getdate(),
baja_logica bit not null default 1
)

alter table tpgdd.cliente add constraint pk_cliente primary key (id)
alter table tpgdd.cliente add constraint fk_cliente_usuario foreign key (id_usuario) references tpgdd.usuario
alter table tpgdd.cliente add constraint unq_dni unique (tipo_dni,numero_dni)
alter table tpgdd.cliente add constraint unq_cuil unique (cuil)



create table tpgdd.cliente_puntos (
id numeric(10) identity(1,1), -- Es necesario?
id_cliente numeric(10) not null,
puntos numeric(10) not null default 0,
fecha_vencimiento date -- Por poner algo, resta definir la logica de negocio detras de esto
)

alter table tpgdd.cliente_puntos add constraint pk_cliente_puntos primary key (id)
alter table tpgdd.cliente_puntos add constraint fk_cliente_puntos foreign key (id_cliente) references tpgdd.cliente



create table tpgdd.rol (
id numeric(10) identity(1,1),
nombre nvarchar(30) not null,
baja_logica bit not null default 1
)

alter table tpgdd.rol add constraint pk_rol primary key (id)
alter table tpgdd.rol add constraint unq_rolnombre unique (nombre)



create table tpgdd.funcionalidad (
id numeric(10) identity(1,1),
nombre nvarchar(30) not null
)

alter table tpgdd.funcionalidad add constraint pk_funcionalidad primary key (id)
alter table tpgdd.funcionalidad add constraint unq_funcionalidadnombre unique (nombre)



create table tpgdd.rol_funcionalidad (
id_rol numeric(10) not null,
id_funcionalidad numeric(10) not null
)

alter table tpgdd.rol_funcionalidad add constraint fk_rol_rol foreign key (id_rol) references tpgdd.rol
alter table tpgdd.rol_funcionalidad add constraint fk_rol_funcionalidad foreign key (id_funcionalidad) references tpgdd.funcionalidad



create table tpgdd.usuario_rol (
id_usuario numeric(10) not null,
id_rol numeric(10) not null
)

alter table tpgdd.usuario_rol add constraint fk_usuario_usuario foreign key (id_usuario) references tpgdd.usuario
alter table tpgdd.usuario_rol add constraint fk_usuario_rol foreign key (id_rol) references tpgdd.rol


create table tpgdd.rubro (
id numeric(10) identity(1,1),
descripcion nvarchar(255)
)

alter table tpgdd.rubro add constraint pk_rubro primary key (id)


create table tpgdd.grado (
id numeric(1) identity(1,1),
nombre nvarchar (20),
comision numeric(10)
)

alter table tpgdd.grado add constraint pk_grado primary key (id)


create table tpgdd.publicacion (
id numeric(10) identity(1,1),
id_rubro numeric(10),
id_grado numeric(1),
id_responsable numeric(10),
estado nvarchar(15),
fecha_publicacion date, -- Entiendo que es lo mismo que la fecha de inicio
fecha_evento smalldatetime,
descripcion nvarchar(255),
direccion nvarchar(255)
)

alter table tpgdd.publicacion add constraint pk_publicacion primary key (id)
alter table tpgdd.publicacion add constraint fk_publicacion_rubro foreign key (id_rubro) references tpgdd.rubro
alter table tpgdd.publicacion add constraint fk_publicacion_grado foreign key (id_grado) references tpgdd.grado
alter table tpgdd.publicacion add constraint fk_publicacion_responsable foreign key (id_responsable) references tpgdd.usuario


create table tpgdd.ubicacion_tipo (
id numeric(10) identity(1,1),
descripcion nvarchar(30)
)

alter table tpgdd.ubicacion_tipo add constraint pk_ubicaciontipo primary key (id)


create table tpgdd.ubicacion (
id numeric(10) identity(1,1),
id_publicacion numeric(10),
fila nvarchar(2),
asiento numeric(3),
precio numeric(10,2),
id_tipo numeric(10), -- Lo normalicé, mandando los datos del tipo de ubicación a otra tabla, pero podría ir mejor sin normalizar
)

alter table tpgdd.ubicacion add constraint pk_ubicacion primary key (id)
alter table tpgdd.ubicacion add constraint fk_ubicacion_publicacion foreign key (id_publicacion) references tpgdd.publicacion
alter table tpgdd.ubicacion add constraint fk_ubicacion_tipo foreign key (id_tipo) references tpgdd.ubicacion_tipo


create table tpgdd.compra (
id numeric(10) identity(1,1),
id_publicacion numeric(10),
id_usuario numeric(10), -- El DER dice cliente, pero entiendo que el que compra en definitiva es el usuario
medio_pago nvarchar(255),
mail nvarchar(255),
importe_total numeric(10,2)
)

alter table tpgdd.compra add constraint pk_compra primary key (id)
alter table tpgdd.compra add constraint fk_compra_publicacion foreign key (id_publicacion) references tpgdd.compra
alter table tpgdd.compra add constraint fk_compra_usuario foreign key (id_usuario) references tpgdd.usuario


create table tpgdd.compra_ubicacion (
id_compra numeric(10),
id_ubicacion numeric(10)
)

alter table tpgdd.compra_ubicacion add constraint fk_compraubicacion_compra foreign key (id_compra) references tpgdd.compra
alter table tpgdd.compra_ubicacion add constraint fk_compraubicacion_ubicacion foreign key (id_ubicacion) references tpgdd.ubicacion


create table tpgdd.rendicion (
id numeric(10) identity(1,1),
id_empresa numeric(10),
fecha smalldatetime
)

alter table tpgdd.rendicion add constraint pk_rendicion primary key (id)
alter table tpgdd.rendicion add constraint fk_rendicion_empresa foreign key (id_empresa) references tpgdd.empresa


create table tpgdd.rendicion_item (
id numeric(10),
id_compra numeric(10),
id_rendicion numeric(10),
comision numeric(10,2)
)

alter table tpgdd.rendicion_item add constraint fk_rendicionitem_compra foreign key (id_compra) references tpgdd.compra
alter table tpgdd.rendicion_item add constraint fk_rendicionitem_rendicion foreign key (id_rendicion) references tpgdd.rendicion