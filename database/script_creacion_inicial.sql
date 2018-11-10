/* Script de creación inicial - TP 2C 2018 */


create schema tpgdd -- Hay que cambiarlo por el verdadero nombre del esquema
go

create table tpgdd.usuario (
usuario_id int identity(1,1),
usuario_username varchar(16) not null,
usuario_password varchar(64) not null,
usuario_tipo varchar(7) not null,
usuario_logins_fallidos numeric(1) not null default 0,
usuario_baja_logica bit not null default 1
)

alter table tpgdd.usuario add constraint pk_usuario primary key (usuario_id)
alter table tpgdd.usuario add constraint unq_username unique (usuario_username)




create table tpgdd.empresa (
empresa_id numeric(10) identity(1,1),
usuario_id numeric(10),
empresa_razon_social nvarchar(255) not null,
empresa_cuit nvarchar(255) not null,
empresa_fecha_creacion date,
empresa_email nvarchar(50),
empresa_telefono varchar(20),
empresa_domicilio_calle nvarchar(50),
empresa_domicilio_numero numeric(18,0),
empresa_domicilio_piso numeric(18,0),
empresa_domicilio_departamento nvarchar(50),
empresa_codigo_postal varchar(8),
empresa_ciudad nvarchar(50),
empresa_baja_logica bit not null default 1
)

alter table tpgdd.empresa add constraint pk_empresa primary key (empresa_id)
alter table tpgdd.empresa add constraint fk_empresa_usuario foreign key (usuario_id) references tpgdd.usuario
alter table tpgdd.empresa add constraint unq_razonsocial unique (empresa_razon_social)
alter table tpgdd.empresa add constraint unq_cuit unique (empresa_cuit)



create table tpgdd.cliente (
cliente_id numeric(10) identity(1,1),
usuario_id numeric(10),
cliente_tipo_dni nvarchar(4), --No hay tipos de doc en la tabla maestra
cliente_numero_dni numeric(18,0) not null,
cliente_cuil nvarchar(255),
cliente_apellido nvarchar(255),
cliente_nombre nvarchar(255),
cliente_fecha_nacimiento date,
cliente_email nvarchar(255),
cliente_telefono nvarchar(20),
cliente_domicilio_calle nvarchar(255),
cliente_domicilio_numero numeric(18,0),
cliente_domicilio_piso numeric(18,0),
cliente_domicilio_departamento nvarchar(255),
cliente_codigo_postal nvarchar(255),
cliente_fecha_creacion date not null default getdate(),
cliente_baja_logica bit not null default 1
)

alter table tpgdd.cliente add constraint pk_cliente primary key (cliente_id)
alter table tpgdd.cliente add constraint fk_cliente_usuario foreign key (usuario_id) references tpgdd.usuario
alter table tpgdd.cliente add constraint unq_dni unique (cliente_tipo_dni,cliente_numero_dni)
--alter table tpgdd.cliente add constraint unq_cuil unique (cuil)



create table tpgdd.cliente_puntos (
id numeric(10) identity(1,1), -- Es necesario?
cliente_id numeric(10) not null,
puntos numeric(10) not null default 0,
fecha_vencimiento date -- Por poner algo, resta definir la logica de negocio detras de esto
)

alter table tpgdd.cliente_puntos add constraint pk_cliente_puntos primary key (id)
alter table tpgdd.cliente_puntos add constraint fk_cliente_puntos foreign key (cliente_id) references tpgdd.cliente



create table tpgdd.rol (
rol_id numeric(10) identity(1,1),
rol_nombre nvarchar(30) not null,
rol_baja_logica bit not null default 1
)

alter table tpgdd.rol add constraint pk_rol primary key (rol_id)
alter table tpgdd.rol add constraint unq_rolnombre unique (rol_nombre)



create table tpgdd.funcionalidad (
func_id numeric(10) identity(1,1),
func_nombre nvarchar(100) not null
)

alter table tpgdd.funcionalidad add constraint pk_funcionalidad primary key (func_id)
alter table tpgdd.funcionalidad add constraint unq_funcionalidadnombre unique (func_nombre)



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
rubro_id numeric(10) identity(1,1),
rubro_descripcion nvarchar(255)
)

alter table tpgdd.rubro add constraint pk_rubro primary key (rubro_id)


create table tpgdd.grado (
grado_id numeric(1) identity(1,1),
grado_nombre nvarchar (20),
grado_comision numeric(10)
)

alter table tpgdd.grado add constraint pk_grado primary key (grado_id)


create table tpgdd.publicacion (
publicacion_id numeric(10) identity(1,1),
id_espectaculo numeric(10),
id_rubro numeric(10),
id_grado numeric(1),
id_responsable numeric(10),
publicacion_estado nvarchar(15),
publicacion_fecha_publicacion date, -- Entiendo que es lo mismo que la fecha de inicio
publicacion_fecha_evento smalldatetime,
publicacion_descripcion nvarchar(255),
publicacion_direccion nvarchar(255)
)

alter table tpgdd.publicacion add constraint pk_publicacion primary key (publicacion_id)
alter table tpgdd.publicacion add constraint fk_publicacion_rubro foreign key (id_rubro) references tpgdd.rubro
alter table tpgdd.publicacion add constraint fk_publicacion_grado foreign key (id_grado) references tpgdd.grado
alter table tpgdd.publicacion add constraint fk_publicacion_responsable foreign key (id_responsable) references tpgdd.usuario


create table tpgdd.ubicacion_tipo (
id numeric(10) not null,-- identity(1,1), --> La tabla maestra ya trae las claves
descripcion nvarchar(30),
)

alter table tpgdd.ubicacion_tipo add constraint pk_ubicaciontipo primary key (id)


create table tpgdd.ubicacion (
ubicacion_id numeric(10) identity(1,1),
id_publicacion numeric(10),
ubicacion_fila nvarchar(2),
ubicacion_asiento numeric(3),
ubicacion_precio numeric(10,2),
id_tipo numeric(10), -- Lo normalicé, mandando los datos del tipo de ubicación a otra tabla, pero podría ir mejor sin normalizar
ubicacion_sin_numerar bit --Lo movimos, estaba en ubicaicon_tipo
)

alter table tpgdd.ubicacion add constraint pk_ubicacion primary key (ubicacion_id)
alter table tpgdd.ubicacion add constraint fk_ubicacion_publicacion foreign key (id_publicacion) references tpgdd.publicacion
alter table tpgdd.ubicacion add constraint fk_ubicacion_tipo foreign key (id_tipo) references tpgdd.ubicacion_tipo


create table tpgdd.compra (
compra_id numeric(10) identity(1,1),
id_publicacion numeric(10),
id_usuario numeric(10), -- El DER dice cliente, pero entiendo que el que compra en definitiva es el usuario
compra_medio_pago nvarchar(255),
compra_mail nvarchar(255),
compra_importe_total numeric(10,2)
)

alter table tpgdd.compra add constraint pk_compra primary key (compra_id)
alter table tpgdd.compra add constraint fk_compra_publicacion foreign key (id_publicacion) references tpgdd.compra
alter table tpgdd.compra add constraint fk_compra_usuario foreign key (id_usuario) references tpgdd.usuario


create table tpgdd.compra_ubicacion (
id_compra numeric(10),
id_ubicacion numeric(10)
)

alter table tpgdd.compra_ubicacion add constraint fk_compraubicacion_compra foreign key (id_compra) references tpgdd.compra
alter table tpgdd.compra_ubicacion add constraint fk_compraubicacion_ubicacion foreign key (id_ubicacion) references tpgdd.ubicacion


create table tpgdd.factura (
factura_id numeric(10) identity(1,1),
id_empresa numeric(10),
factura_fecha smalldatetime
)

alter table tpgdd.factura add constraint pk_factura primary key (factura_id)
alter table tpgdd.factura add constraint fk_factura_empresa foreign key (id_empresa) references tpgdd.empresa


create table tpgdd.factura_item (
id numeric(10),
id_compra numeric(10),
id_factura numeric(10),
comision numeric(10,2)
)

alter table tpgdd.factura_item add constraint fk_facturaitem_compra foreign key (id_compra) references tpgdd.compra
alter table tpgdd.factura_item add constraint fk_facturaitem_factura foreign key (id_factura) references tpgdd.factura







-- Migracion clientes a usuarios

insert into tpgdd.usuario (usuario_username,usuario_password,usuario_tipo)
select DISTINCT concat('',cli_dni), 
HASHBYTES('SHA2_256','123'),'cliente'
from gd_esquema.Maestra 
where Cli_Dni is not null;

--Probado OK

-- Migracion empresas a usuarios

insert into tpgdd.usuario (usuario_username,usuario_password,usuario_tipo)
select DISTINCT concat('',REPLACE(espec_empresa_cuit,'-','')), 
LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','123'))),'empresa'
from gd_esquema.Maestra 
where espec_empresa_cuit is not null;

--Probado OK

-- Migracion empresas

insert into tpgdd.empresa (usuario_id,empresa_razon_social,empresa_cuit,empresa_fecha_creacion,
empresa_email,empresa_domicilio_calle,empresa_domicilio_numero,
empresa_domicilio_piso,empresa_domicilio_departamento,empresa_codigo_postal)
select (select usuario_id from tpgdd.usuario where usuario_username LIKE concat('',REPLACE(espec_empresa_cuit,'-',''))),
espec_empresa_razon_social,
espec_empresa_cuit,espec_empresa_fecha_Creacion,
espec_empresa_mail,espec_empresa_dom_calle,espec_empresa_nro_calle,
espec_empresa_piso,espec_empresa_depto,espec_empresa_cod_postal
from gd_esquema.Maestra
group by espec_empresa_razon_social,espec_empresa_cuit,espec_empresa_fecha_Creacion,
espec_empresa_mail,espec_empresa_dom_calle,espec_empresa_nro_calle,
espec_empresa_piso,espec_empresa_depto,espec_empresa_cod_postal
order by 3

--Probado OK

-- Migracion clientes

insert into tpgdd.cliente (usuario_id,cliente_numero_dni,cliente_apellido,cliente_nombre,cliente_fecha_nacimiento,cliente_email,cliente_domicilio_calle,cliente_domicilio_numero,cliente_domicilio_piso,cliente_domicilio_departamento,cliente_codigo_postal)
select concat('',cli_dni)
cli_dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac,Cli_Mail,Cli_Dom_Calle,Cli_Nro_Calle,cli_piso,cli_depto,Cli_Cod_Postal
from gd_esquema.Maestra
where cli_dni is not null
group by cli_dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac,Cli_Mail,Cli_Dom_Calle,Cli_Nro_Calle,cli_piso,cli_depto,Cli_Cod_Postal
order by 1 asc

--Probado OK

-- Migracion Rubro

INSERT INTO tpgdd.rubro (rubro_descripcion)
SELECT case Espectaculo_Rubro_Descripcion 
       when '' THEN 'Sin definir' end
FROM tpgdd.Maestra
WHERE Espectaculo_Rubro_Descripcion IS NOT NULL
group by Espectaculo_Rubro_Descripcion 

--Probado OK


-- Migracion Roles

insert into tpgdd.rol (rol_nombre, rol_baja_logica)
values ('Empresa', 1), 
	   ('Administrativo', 1), 
	   ('Cliente', 1)

--Probado OK

-- Migracion Funcionaliades

insert into tpgdd.funcionalidad (func_nombre)
VALUES ('Login y seguridad'),
       ('Registro de Usuario'), 
	   ('ABM de Cliente'), 
	   ('ABM de Empresa de espectaculos'), 
	   ('ABM de Categoria'), 
	   ('ABM grado de publicacion'), 
	   ('Generar Publicacion'), 
	   ('Editar Publicación'), 
	   ('Comprar'), 
	   ('Historial del cliente'),
	   ('Canje y administración de puntos'),
	   ('Generar Pago de comisiones'),
	   ('Listado Estadístico')

--Probado OK

-- Migracion tipos de ubicacion


insert into tpgdd.ubicacion_tipo (id,descripcion)
select Ubicacion_Tipo_Codigo,Ubicacion_Tipo_Descripcion from gd_esquema.Maestra
group by Ubicacion_Tipo_Codigo,Ubicacion_Tipo_Descripcion
order by 1 asc

--Probado OK


-- Migracion espectaculos/publicaciones
/*El grado no esta en la tabla maestra por lo tanto se deja en null*/

insert into gd_esquema.publicacion (id_responsable,id_espectaculo,publicacion_descripcion,publicacion_fecha_publicacion,publicacion_fecha_evento,id_rubro,publicacion_estado)
select (select usuario_id from gd_esquema.usuario
         where usuario_username LIKE concat('',REPLACE(espec_empresa_cuit,'-','')))
,espectaculo_cod,espectaculo_descripcion,
Espectaculo_Fecha,Espectaculo_Fecha_Venc,rubro_id,Espectaculo_Estado
from gd_esquema.Maestra join gd_esquema.rubro on Espectaculo_Rubro_Descripcion=rubro_descripcion
group by espec_empresa_cuit,espectaculo_cod,espectaculo_descripcion,Espectaculo_Fecha,
         Espectaculo_Fecha_Venc,rubro_id,Espectaculo_Estado
order by 1 asc

--Probado OK

--Migracion compra (desuso, no borrar hasta ver como meter el compra_importe_total en el procedure)

insert into tpgdd.compra (id_publicacion, id_usuario, compra_medio_pago, compra_mail, compra_importe_total)
select id_publicacion, usuario_id, forma_pago_desc, cli_mail, 
(select SUM(ubicacion_precio) from tpgdd.Maestra as m2 where concat('',m2.cli_dni) = usuario_username and m2.espectaculo_cod = id_espectaculo)

from gd_esquema.Maestra
join tpgdd.publicacion on espectaculo_cod = id_espectaculo
join tpgdd.usuario on CONCAT('',cli_dni) = usuario_username
where compra_cantidad is not null


 --Migracion Compra, Ubicacion y compra_ubicacion (para probar se seleccionan las primeras 1000 filas. Falta el campo compra_importe_total en Comrpa)

insert into gd_esquema.compra_temp (Forma_Pago_Desc, Cli_Mail,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,
Ubicacion_Sin_numerar,Ubicacion_Tipo_Codigo, Espectaculo_Cod,Cli_Dni) 
select Forma_Pago_Desc, Cli_Mail,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,
Ubicacion_Sin_numerar,Ubicacion_Tipo_Codigo, Espectaculo_Cod,Cli_Dni 
from gd_esquema.Maestra
where Cli_Dni is not null

--create procedure [dbo].[pr_compra_ubicacion]
--as begin

WHILE EXISTS (SELECT * FROM gd_esquema.compra_temp where flag_migrado=0)
  BEGIN

  SET IDENTITY_INSERT gd_esquema.compra ON
  insert into gd_esquema.compra (compra_id, id_publicacion, id_usuario, compra_medio_pago, compra_mail, compra_importe_total)
  SELECT top 10000
  id,Espectaculo_Cod,1,Forma_Pago_Desc,Cli_Mail,100
  FROM gd_esquema.compra_temp WHERE flag_migrado = 0 order by id asc;
  SET IDENTITY_INSERT gd_esquema.compra OFF

  SET IDENTITY_INSERT gd_esquema.ubicacion ON
  insert into gd_esquema.ubicacion (ubicacion_id, id_publicacion,ubicacion_fila,ubicacion_asiento,ubicacion_precio,id_tipo,ubicacion_sin_numerar)
  SELECT top 10000 
  id,Espectaculo_Cod,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,Ubicacion_Tipo_Codigo,Ubicacion_Sin_numerar 
  FROM gd_esquema.compra_temp WHERE flag_migrado = 0 order by id asc;
  SET IDENTITY_INSERT gd_esquema.ubicacion OFF

  ;WITH CTE AS 
  ( 
  SELECT top 10000 * FROM gd_esquema.compra_temp WHERE flag_migrado = 0 order by id asc
  ) 
  UPDATE CTE SET flag_migrado=1 

  END


  insert into gd_esquema.compra_ubicacion(id_compra,id_ubicacion)
  select compra_id as id_compra,compra_id as id_ubicacion from gd_esquema.compra

-- Probado OK