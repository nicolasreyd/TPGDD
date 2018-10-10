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



