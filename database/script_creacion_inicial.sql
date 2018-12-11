/* Script de creación inicial - TP 2C 2018 */
create schema INNERJOIN
go

create table INNERJOIN.usuario (
usuario_id numeric(10) identity(1,1),
usuario_username varchar(16) not null,
usuario_password varchar(64) not null,
usuario_tipo varchar(7) not null,
usuario_logins_fallidos numeric(1) not null default 0,
usuario_baja_logica bit not null default 0,
usuario_debe_cambiar_clave bit not null default 1,
usuario_clave_expirada bit not null default 0
)

alter table INNERJOIN.usuario add constraint pk_usuario primary key (usuario_id)
alter table INNERJOIN.usuario add constraint unq_username unique (usuario_username)




create table INNERJOIN.empresa (
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

alter table INNERJOIN.empresa add constraint pk_empresa primary key (empresa_id)
--alter table INNERJOIN.empresa add constraint fk_empresa_usuario foreign key (usuario_id) references INNERJOIN.usuario
alter table INNERJOIN.empresa add constraint unq_razonsocial unique (empresa_razon_social)
alter table INNERJOIN.empresa add constraint unq_cuit unique (empresa_cuit)



create table INNERJOIN.cliente (
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

alter table INNERJOIN.cliente add constraint pk_cliente primary key (cliente_id)
alter table INNERJOIN.cliente add constraint unq_dni unique (cliente_tipo_dni,cliente_numero_dni)

create table INNERJOIN.tarjeta_credito (
tarjeta_credito_id numeric(10) identity(1,1),
numero numeric(18,0) not null,
fec_vencimiento date not null,
cliente_id numeric(10)
)

alter table INNERJOIN.tarjeta_credito add constraint pk_tarjeta_credito primary key (tarjeta_credito_id)

create table INNERJOIN.producto (
producto_id numeric(10) identity(1,1),
descripcion nvarchar(255)
)

alter table INNERJOIN.producto add constraint pk_producto primary key (producto_id)

create table INNERJOIN.premio (
premio_id numeric(10) identity(1,1),
puntos numeric(18,0) not null,
id_producto numeric(10)
)

alter table INNERJOIN.premio add constraint pk_premio primary key (premio_id)

create table INNERJOIN.cliente_premio (
id_premio numeric(10),
id_cliente numeric(10)
)


create table INNERJOIN.cliente_puntos (
id numeric(10) identity(1,1), -- Es necesario?
cliente_id numeric(10) not null,
puntos numeric(10) not null default 0,
fecha_vencimiento date -- Por poner algo, resta definir la logica de negocio detras de esto
)

alter table INNERJOIN.cliente_puntos add constraint pk_cliente_puntos primary key (id)



create table INNERJOIN.rol (
rol_id numeric(10) identity(1,1),
rol_nombre nvarchar(30) not null,
rol_baja_logica bit not null default 1
)

alter table INNERJOIN.rol add constraint pk_rol primary key (rol_id)
alter table INNERJOIN.rol add constraint unq_rolnombre unique (rol_nombre)



create table INNERJOIN.funcionalidad (
func_id numeric(10) identity(1,1),
func_nombre nvarchar(100) not null
)

alter table INNERJOIN.funcionalidad add constraint pk_funcionalidad primary key (func_id)
alter table INNERJOIN.funcionalidad add constraint unq_funcionalidadnombre unique (func_nombre)



create table INNERJOIN.rol_funcionalidad (
id_rol numeric(10) not null,
id_funcionalidad numeric(10) not null
)




create table INNERJOIN.usuario_rol (
id_usuario numeric(10) not null,
id_rol numeric(10) not null
)



create table INNERJOIN.rubro (
rubro_id numeric(10) identity(1,1),
rubro_descripcion nvarchar(255)
)

alter table INNERJOIN.rubro add constraint pk_rubro primary key (rubro_id)


create table INNERJOIN.grado (
grado_id numeric(1) identity(1,1),
grado_nombre nvarchar (20),
grado_prioridad numeric(10) not null default 1,
grado_comision numeric(10)
)

alter table INNERJOIN.grado add constraint pk_grado primary key (grado_id)


create table INNERJOIN.publicacion (
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

alter table INNERJOIN.publicacion add constraint pk_publicacion primary key (publicacion_id)

set identity_insert INNERJOIN.publicacion ON


create table INNERJOIN.ubicacion_tipo (
id numeric(10) not null,-- identity(1,1), --> La tabla maestra ya trae las claves
descripcion nvarchar(30),
)

alter table INNERJOIN.ubicacion_tipo add constraint pk_ubicaciontipo primary key (id)


create table INNERJOIN.ubicacion (
ubicacion_id numeric(10) identity(1,1),
id_publicacion numeric(10),
ubicacion_fila nvarchar(2),
ubicacion_asiento numeric(3),
ubicacion_precio numeric(10,2),
id_tipo numeric(10), -- Lo normalicé, mandando los datos del tipo de ubicación a otra tabla, pero podría ir mejor sin normalizar
numerada bit --Lo movimos, estaba en ubicaicon_tipo
)

alter table INNERJOIN.ubicacion add constraint pk_ubicacion primary key (ubicacion_id)


create table INNERJOIN.compra (
compra_id numeric(10) identity(1,1),
id_publicacion numeric(10),
id_usuario numeric(10), -- El DER dice cliente, pero entiendo que el que compra en definitiva es el usuario
compra_medio_pago nvarchar(255),
compra_mail nvarchar(255),
compra_importe_total numeric(10,2),
compra_fecha date
)

alter table INNERJOIN.compra add constraint pk_compra primary key (compra_id)


create table INNERJOIN.compra_ubicacion (
id_compra numeric(10),
id_ubicacion numeric(10)
)



create table INNERJOIN.factura (
factura_id numeric(10) identity(1,1),
id_empresa numeric(10),
factura_fecha smalldatetime,
factura_total numeric(10,2),
)

alter table INNERJOIN.factura add constraint pk_factura primary key (factura_id)


create table INNERJOIN.factura_item (
id numeric(10) identity(1,1),
id_compra numeric(10),
id_factura numeric(10),
comision numeric(10,2),
importe_total numeric(10,2),
descripcion varchar(255) default 'Comision por compra'
)








-- Migracion clientes a usuarios

insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo)
select DISTINCT concat('',cli_dni),
LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','123'), 2)),'cliente'
from gd_esquema.Maestra  
where Cli_Dni is not null;

--Probado OK

insert into INNERJOIN.grado values ('Alto',1,50),('Medio',2,30),('Bajo',3,10)

-- Migracion empresas a usuarios

insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo)
select DISTINCT concat('',REPLACE(espec_empresa_cuit,'-','')), 
LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','123'), 2)),'empresa'
from gd_esquema.Maestra  
where espec_empresa_cuit is not null;

--Creacion de usuario admin
insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo)
select DISTINCT 'admin', 
LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','w23e'), 2)),'admin'
from gd_esquema.Maestra  
where espec_empresa_cuit is not null;

insert into INNERJOIN.usuario_rol values ((select usuario_id from innerjoin.usuario where usuario_username='admin'),2)

insert into INNERJOIN.rol_funcionalidad values (2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(2,9),(2,10),(2,11),(2,12),(2,13)

update INNERJOIN.usuario set usuario_debe_cambiar_clave = 0 where usuario_username LIKE 'admin'


--Probado OK

-- Migracion empresas

insert into INNERJOIN.empresa (usuario_id,empresa_razon_social,empresa_cuit,empresa_fecha_creacion,
empresa_email,empresa_domicilio_calle,empresa_domicilio_numero,
empresa_domicilio_piso,empresa_domicilio_departamento,empresa_codigo_postal)
select (select usuario_id from INNERJOIN.usuario where usuario_username LIKE concat('',REPLACE(espec_empresa_cuit,'-',''))),
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

insert into INNERJOIN.cliente (usuario_id,cliente_numero_dni,cliente_apellido,cliente_nombre,cliente_fecha_nacimiento,cliente_email,cliente_domicilio_calle,cliente_domicilio_numero,cliente_domicilio_piso,cliente_domicilio_departamento,cliente_codigo_postal)
select ((select usuario_id from INNERJOIN.usuario where usuario_username LIKE concat('',cli_dni))),
cli_dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac,Cli_Mail,Cli_Dom_Calle,Cli_Nro_Calle,cli_piso,cli_depto,Cli_Cod_Postal
from gd_esquema.Maestra 
where cli_dni is not null
group by cli_dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac,Cli_Mail,Cli_Dom_Calle,Cli_Nro_Calle,cli_piso,cli_depto,Cli_Cod_Postal
order by 1 asc


--Probado OK

-- Migracion Rubro

INSERT INTO INNERJOIN.rubro (rubro_descripcion)
SELECT case Espectaculo_Rubro_Descripcion 
       when '' THEN 'Sin definir' end
FROM gd_esquema.Maestra 
WHERE Espectaculo_Rubro_Descripcion IS NOT NULL
group by Espectaculo_Rubro_Descripcion 

	
--Probado OK

-- Migracion Roles

insert into INNERJOIN.rol (rol_nombre, rol_baja_logica)
values ('Empresa', 1), 
	     ('Administrativo', 1), 
	     ('Cliente', 1),
       ('Administrador General', 1)

--Probado OK

-- Migracion Funcionaliades

insert into INNERJOIN.funcionalidad (func_nombre)
VALUES ('Registro de Usuario'), 
	   ('ABM de Cliente'), 
	   ('ABM de Empresa de espectaculos'), 
	   ('ABM de Categoria'), 
	   ('ABM grado de publicacion'), 
	   ('Generar Publicacion'), 
	   ('Editar Publicacion'), 
	   ('Comprar'), 
	   ('Historial del cliente'),
	   ('Canje y administración de puntos'),
	   ('Generar Pago de comisiones'),
	   ('Listado Estadistico'),
	   ('ABM de Rol')

--Probado OK

-- Migracion tipos de ubicacion


insert into INNERJOIN.ubicacion_tipo (id,descripcion)
select Ubicacion_Tipo_Codigo,Ubicacion_Tipo_Descripcion from gd_esquema.Maestra 
group by Ubicacion_Tipo_Codigo,Ubicacion_Tipo_Descripcion
order by 1 asc

--Probado OK


-- Migracion espectaculos/publicaciones
/*El grado no esta en la tabla maestra por lo tanto se deja en null*/
insert into INNERJOIN.publicacion (publicacion_id,id_responsable,id_grado,id_espectaculo,publicacion_descripcion,publicacion_fecha_publicacion,publicacion_fecha_evento,id_rubro,publicacion_estado)
select espectaculo_cod,(select usuario_id from INNERJOIN.usuario
         where usuario_username LIKE concat('',REPLACE(espec_empresa_cuit,'-',''))),2
,espectaculo_cod,espectaculo_descripcion,
Espectaculo_Fecha,Espectaculo_Fecha_Venc,isnull(rubro_id,1),Espectaculo_Estado
from gd_esquema.Maestra  left join INNERJOIN.rubro on Espectaculo_Rubro_Descripcion=rubro_descripcion
group by espec_empresa_cuit,espectaculo_cod,espectaculo_descripcion,Espectaculo_Fecha,
         Espectaculo_Fecha_Venc,rubro_id,Espectaculo_Estado
order by 1 asc
set identity_insert INNERJOIN.publicacion OFF

--Probado OK

create table INNERJOIN.compra_temp (
id numeric(10) identity(1,1),
Forma_Pago_Desc nvarchar(255),
Cli_Mail nvarchar(255),
Espec_Empresa_Razon_Social nvarchar(255),
Ubicacion_Fila varchar(2),
Ubicacion_Asiento varchar(3),
Ubicacion_Precio numeric(10,2),
Ubicacion_Sin_numerar bit not null default 1,
Ubicacion_Tipo_Codigo numeric(10),
Espectaculo_Cod numeric(18,0),
Cli_Dni numeric(18,0),
compra_fecha date,
flag_migrado bit not null default 0,
Item_Factura_Monto numeric(18,0),
Item_Factura_Descripcion varchar(255),
Factura_Nro numeric(10)
)

 --Migracion Compra, Ubicacion y compra_ubicacion (para probar se seleccionan las primeras 1000 filas. Falta el campo compra_importe_total en Comrpa)

insert into INNERJOIN.compra_temp (Forma_Pago_Desc, Cli_Mail, Espec_Empresa_Razon_Social, Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,
Ubicacion_Sin_numerar,Ubicacion_Tipo_Codigo, Espectaculo_Cod,Cli_Dni,compra_fecha,Item_Factura_Monto,Item_Factura_Descripcion,Factura_Nro) 
select Forma_Pago_Desc, Cli_Mail,Espec_Empresa_Razon_Social,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,
Ubicacion_Sin_numerar,Ubicacion_Tipo_Codigo, Espectaculo_Cod,Cli_Dni,Compra_fecha,Item_Factura_Monto,Item_Factura_Descripcion,Factura_Nro
from gd_esquema.Maestra 
where Cli_Dni is not null

WHILE EXISTS (SELECT * FROM INNERJOIN.compra_temp where flag_migrado=0)
  BEGIN

  SET IDENTITY_INSERT INNERJOIN.compra ON
  insert into INNERJOIN.compra (compra_id, id_publicacion, id_usuario, compra_medio_pago, compra_mail, compra_importe_total,compra_fecha)
  SELECT top 10000
  id,Espectaculo_Cod,(select empresa_id from INNERJOIN.empresa where empresa_razon_social = Espec_Empresa_Razon_Social),
  Forma_Pago_Desc,Cli_Mail,Ubicacion_Precio,compra_fecha
  FROM INNERJOIN.compra_temp c
   WHERE flag_migrado = 0 order by id asc;
  SET IDENTITY_INSERT INNERJOIN.compra OFF

  SET IDENTITY_INSERT INNERJOIN.ubicacion ON
  insert into INNERJOIN.ubicacion (ubicacion_id, id_publicacion,ubicacion_fila,ubicacion_asiento,ubicacion_precio,id_tipo,numerada)
  SELECT top 10000 
  id,Espectaculo_Cod,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,Ubicacion_Tipo_Codigo,Ubicacion_Sin_numerar 
  FROM INNERJOIN.compra_temp WHERE flag_migrado = 0 order by id asc;
  SET IDENTITY_INSERT INNERJOIN.ubicacion OFF

  ;WITH CTE AS 
  ( 
  SELECT top 10000 * FROM INNERJOIN.compra_temp WHERE flag_migrado = 0 order by id asc
  ) 
  UPDATE CTE SET flag_migrado=1 

  END

  insert into INNERJOIN.ubicacion (id_publicacion,ubicacion_fila,ubicacion_asiento,ubicacion_precio,id_tipo,numerada)
  SELECT Espectaculo_Cod,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Precio,Ubicacion_Tipo_Codigo,Ubicacion_Sin_numerar 
  FROM gd_esquema.Maestra WHERE Cli_Dni is null;


  insert into INNERJOIN.compra_ubicacion(id_compra,id_ubicacion)
  select compra_id as id_compra,compra_id as id_ubicacion from INNERJOIN.compra

-- Probado OK
SET IDENTITY_INSERT INNERJOIN.factura on
insert into INNERJOIN.factura (factura_id,id_empresa,factura_fecha,factura_total)
SELECT Factura_Nro,
(select empresa_id from INNERJOIN.empresa where empresa_razon_social = Espec_Empresa_Razon_Social),
Factura_Fecha,
Factura_Total 
FROM gd_esquema.Maestra
WHERE Factura_Nro is not null
group by Factura_Nro,Factura_Fecha,Factura_Total,Espec_Empresa_Razon_Social
SET IDENTITY_INSERT INNERJOIN.factura OFF


insert into INNERJOIN.factura_item (id_compra,id_factura,comision,importe_total,descripcion)
select id,Factura_Nro,Item_Factura_Monto,(select compra_importe_total from INNERJOIN.compra where compra_id=id),Item_Factura_Descripcion
FROM INNERJOIN.compra_temp
where Factura_Nro is not null

insert into INNERJOIN.rol_funcionalidad values
(1, 1),
(1, 6),
(1, 7),
(1, 2),
(3, 1),
(3, 10),
(3, 8),
(3, 9),
(2, 1),
(2, 2),
(2, 3),
(2, 4),
(2, 5),
(2, 7),
(2, 9),
(2, 11),
(2, 12),
(4, 1),
(4, 2),
(4, 3),
(4, 4),
(4, 5),
(4, 6),
(4, 7),
(4, 8),
(4, 9),
(4, 10),
(4, 11),
(4, 12),
(4, 13)

insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
select usuario_id,(select rol_id from INNERJOIN.rol where rol_nombre='Cliente') from INNERJOIN.cliente

insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
select usuario_id,(select rol_id from INNERJOIN.rol where rol_nombre='Empresa') from INNERJOIN.empresa

insert into INNERJOIN.producto (descripcion) values
('Aire Acondicionado'),('TV'),('Licuadora'),('Cafetera'),('Heladera'),('Bicicleta')

insert into INNERJOIN.premio (puntos,id_producto) values
(5000,1),(11000,2),(2000,3),(50000,4),(20000,5),(10000,6)

alter table INNERJOIN.factura_item add constraint fk_facturaitem_compra foreign key (id_compra) references INNERJOIN.compra
alter table INNERJOIN.factura_item add constraint fk_facturaitem_factura foreign key (id_factura) references INNERJOIN.factura
alter table INNERJOIN.factura add constraint fk_factura_empresa foreign key (id_empresa) references INNERJOIN.empresa
alter table INNERJOIN.compra_ubicacion add constraint fk_compraubicacion_compra foreign key (id_compra) references INNERJOIN.compra
alter table INNERJOIN.compra_ubicacion add constraint fk_compraubicacion_ubicacion foreign key (id_ubicacion) references INNERJOIN.ubicacion
alter table INNERJOIN.compra add constraint fk_compra_publicacion foreign key (id_publicacion) references INNERJOIN.compra
alter table INNERJOIN.compra add constraint fk_compra_usuario foreign key (id_usuario) references INNERJOIN.usuario
alter table INNERJOIN.ubicacion add constraint fk_ubicacion_publicacion foreign key (id_publicacion) references INNERJOIN.publicacion
alter table INNERJOIN.ubicacion add constraint fk_ubicacion_tipo foreign key (id_tipo) references INNERJOIN.ubicacion_tipo
alter table INNERJOIN.publicacion add constraint fk_publicacion_rubro foreign key (id_rubro) references INNERJOIN.rubro
alter table INNERJOIN.publicacion add constraint fk_publicacion_grado foreign key (id_grado) references INNERJOIN.grado
alter table INNERJOIN.publicacion add constraint fk_publicacion_responsable foreign key (id_responsable) references INNERJOIN.usuario
alter table INNERJOIN.usuario_rol add constraint fk_usuario_usuario foreign key (id_usuario) references INNERJOIN.usuario
alter table INNERJOIN.usuario_rol add constraint fk_usuario_rol foreign key (id_rol) references INNERJOIN.rol
alter table INNERJOIN.rol_funcionalidad add constraint fk_rol_rol foreign key (id_rol) references INNERJOIN.rol
alter table INNERJOIN.rol_funcionalidad add constraint fk_rol_funcionalidad foreign key (id_funcionalidad) references INNERJOIN.funcionalidad
alter table INNERJOIN.cliente_puntos add constraint fk_cliente_puntos foreign key (cliente_id) references INNERJOIN.cliente
alter table INNERJOIN.cliente_premio add constraint fk_clientecliente_premio foreign key (id_cliente) references INNERJOIN.cliente
alter table INNERJOIN.cliente_premio add constraint fk_premiocliente_premio foreign key (id_premio) references INNERJOIN.premio
alter table INNERJOIN.premio add constraint fk_productopremio foreign key (id_producto) references INNERJOIN.producto
alter table INNERJOIN.tarjeta_credito add constraint fk_cliente foreign key (cliente_id) references INNERJOIN.cliente
alter table INNERJOIN.empresa add constraint fk_empresa_usuario foreign key (usuario_id) references INNERJOIN.usuario
alter table INNERJOIN.cliente add constraint fk_cliente_usuario foreign key (usuario_id) references INNERJOIN.usuario
CREATE UNIQUE NONCLUSTERED INDEX unq_cuil
ON INNERJOIN.cliente(cliente_cuil)
WHERE cliente_cuil IS NOT NULL;

GO

create procedure INNERJOIN.sp_eliminar_rol 
@id_rol numeric(10,0)
as begin

delete from INNERJOIN.rol_funcionalidad where id_rol = @id_rol
delete from INNERJOIN.usuario_rol where id_rol = @id_rol
delete from INNERJOIN.rol where rol_id = @id_rol

end
go

create procedure INNERJOIN.sp_generar_random_username @username nvarchar(16) output
as
begin
	
	SELECT @username = replace((left(CONVERT(nvarchar(255), NEWID()),16)),'-','');

	while ((select count(*) from INNERJOIN.usuario where usuario_username = @username) <> 0)
		SELECT @username = replace((left(CONVERT(nvarchar(255), NEWID()),16)),'-','');
	
end
go




create procedure INNERJOIN.sp_generar_random_password @password nvarchar(16) output
as
begin
	
	SELECT @password = replace((left(CONVERT(nvarchar(255), NEWID()),16)),'-','');
	
end
go


CREATE procedure [INNERJOIN].[sp_generar_publicacion] 
@descripcion nvarchar(255), @rubro_text nvarchar(50), @grado_text nvarchar(20), @grado_comision numeric(10,0),
@id_usuario numeric(10,0), @estado nvarchar(15), @fecha_public date, @fecha_evento date, @direccion nvarchar(255),
@identity numeric(10,0)
as begin

declare @id_grado numeric(10,0)
declare @id_rubro numeric(10,0)

select @id_grado = grado_id from GD2C2018.INNERJOIN.grado where grado_nombre LIKE @grado_text and grado_comision = @grado_comision
select @id_rubro = rubro_id from GD2C2018.INNERJOIN.rubro where rubro_descripcion LIKE @rubro_text

insert into GD2C2018.INNERJOIN.publicacion values (null, @id_rubro, @id_grado, @id_usuario, @estado, @fecha_public,
                                                    @fecha_evento, @descripcion, @direccion)
update GD2C2018.INNERJOIN.publicacion set id_espectaculo = SCOPE_IDENTITY() where publicacion_id = SCOPE_IDENTITY()

select @@IDENTITY

return

end
go


create procedure [INNERJOIN].[sp_baja_cliente] @idCliente numeric(18,0)
as

	begin tran

	declare @id_usuario numeric

	select @id_usuario=usuario_id from INNERJOIN.cliente where cliente_id=@idCliente

	update INNERJOIN.usuario set usuario_baja_logica=1 where usuario_id=@id_usuario

	update INNERJOIN.cliente set cliente_baja_logica=1 where cliente_id=@idCliente

	commit 
go
	
	




create procedure [INNERJOIN].[sp_alta_cliente] @username nvarchar(16),@password varchar(64),@tipodni nvarchar(4),@nrodni nvarchar(255),@cuil nvarchar(255),@apellido nvarchar(255),@nombre nvarchar(255),@fechanac nvarchar(255),@email nvarchar(255),@telefono nvarchar(20),@dom_calle nvarchar(255),@dom_numero nvarchar(255),@dom_piso nvarchar(255),@dom_depto nvarchar(255),@codpost nvarchar(255),@num_tarjeta nvarchar(255),@venc_tarjeta nvarchar(255),@credenciales nvarchar(255) output
as

	begin tran

	declare @id_usuario numeric
	declare @id_cliente numeric
	declare @debe_cambiar_password bit = 0;

	if ((@username = '') and (@password = ''))
	begin
		exec INNERJOIN.sp_generar_random_username @username output
		exec INNERJOIN.sp_generar_random_password @password output
		set @debe_cambiar_password = 1
	end
	
	insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo,usuario_baja_logica,usuario_debe_cambiar_clave)
		values (@username,LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256',@password), 2)),'cliente',0,@debe_cambiar_password)
		
	select @id_usuario=usuario_id from INNERJOIN.usuario where usuario_username=@username
		
	insert into INNERJOIN.cliente (usuario_id,cliente_tipo_dni,cliente_numero_dni,cliente_cuil,cliente_apellido,cliente_nombre,cliente_fecha_nacimiento,cliente_email,cliente_telefono,cliente_domicilio_calle,cliente_domicilio_numero,cliente_domicilio_piso,cliente_domicilio_departamento,cliente_codigo_postal,cliente_baja_logica)
		values (@id_usuario,@tipodni,(CAST(@nrodni as numeric(18,0))),@cuil,@apellido,@nombre,CONVERT(date,@fechanac, 103),@email,@telefono,@dom_calle,(CAST(@dom_numero as numeric(18,0))),(CAST(@dom_piso as numeric(18,0))),@dom_depto,@codpost,0)
		
	select @id_cliente=cliente_id from INNERJOIN.cliente where usuario_id=@id_usuario

	insert into INNERJOIN.tarjeta_credito (numero,fec_vencimiento,cliente_id)
		values ((CAST(@num_tarjeta as numeric(18,0))),CONVERT(date,@venc_tarjeta, 103),@id_cliente)
	
	insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
		values (@id_usuario,3)

	set @credenciales = 'Nombre de usuario: '+@username + CHAR(13) +  CHAR(13) +  'Contraseña: '+@password

	commit 
go


create procedure [INNERJOIN].[sp_generar_comision] @cantidad_compras int,@id_empresa numeric(10,0), @fecha datetime
as begin

declare @id_compra numeric(10,0)
declare @importe_total numeric(10,2)
declare @importe_comision numeric(10,2)
declare @ubicacion_id numeric(10,0)
declare @porcentaje_comision numeric(10,0)
declare @id_factura numeric(10,0)
declare @count int

declare c_cursor1 cursor for
select top (@cantidad_compras) compra_id,
(select grado_comision from INNERJOIN.grado inner join INNERJOIN.publicacion p on p.id_grado = grado_id
where c.id_publicacion = p.publicacion_id) as Comision
from INNERJOIN.compra c
where id_usuario = @id_empresa and c.compra_id not in (select id_compra from INNERJOIN.factura_item)
order by compra_fecha asc

open c_cursor1 fetch next from c_cursor1 into @id_compra, @porcentaje_comision
while(@@FETCH_STATUS = 0)
begin

insert into INNERJOIN.factura values(@id_empresa, @fecha, 0)
set @id_factura = SCOPE_IDENTITY()


declare c_cursor2 cursor for 
select id_ubicacion, ubicacion_precio from INNERJOIN.compra_ubicacion inner join INNERJOIN.ubicacion on ubicacion_id = id_ubicacion where id_compra = @id_compra

open c_cursor2 fetch next from c_cursor2 into @ubicacion_id,@importe_total
while(@@FETCH_STATUS = 0)
begin

set @importe_comision = @importe_total * @porcentaje_comision / 100
insert into INNERJOIN.factura_item values(@ubicacion_id, @id_compra,  @id_factura, @importe_comision, @importe_total)
fetch next from c_cursor2 into @ubicacion_id,@importe_total

end

close c_cursor2
deallocate c_cursor2

update INNERJOIN.factura set factura_total = (select SUM(comision) from INNERJOIN.factura_item where id_factura = @id_factura) where factura_id = @id_factura

fetch next from c_cursor1 into @id_compra, @porcentaje_comision
end


close c_cursor1
deallocate c_cursor1

end
go


create procedure [INNERJOIN].[sp_rehabilitar_usuario] @tipoUsuario nvarchar(20),@idUsuario numeric(18,0)
as

	begin tran

	declare @id_usuario numeric

	if @tipoUsuario = 'cliente'
	begin
		select @id_usuario=usuario_id from INNERJOIN.cliente where cliente_id=@idUsuario
		update INNERJOIN.cliente set cliente_baja_logica = 0 where cliente_id = @idUsuario
	end
		
		
	if @tipoUsuario = 'empresa'
	begin
		select @id_usuario=empresa_id from INNERJOIN.empresa where empresa_id=@idUsuario
		update INNERJOIN.empresa set empresa_baja_logica = 0 where empresa_id = @idUsuario
	end			

	if (@tipoUsuario <> 'cliente') and (@tipoUsuario <> 'empresa') RAISERROR('Tipo incorrecto de usuario (debe ser "cliente" o "empresa")',16,1)

	update INNERJOIN.usuario set usuario_baja_logica=0 where usuario_id=@id_usuario

	commit
go	




create procedure [INNERJOIN].[sp_alta_empresa] @username nvarchar(16) output,@password varchar(64) output,@razonSocial nvarchar(255),@cuit nvarchar(255),@domCalle nvarchar(255),@domNro nvarchar(255),@domPiso nvarchar(255),@domDepto nvarchar(255),@ciudad nvarchar(255),@codpost nvarchar(255),@telefono nvarchar(255),@email nvarchar(255),@credenciales nvarchar(255) output
as

	begin tran

	declare @id_usuario numeric
	declare @id_empresa numeric
	declare @debe_cambiar_password bit = 0;

	if ((@username = '') and (@password = ''))
	begin
		exec INNERJOIN.sp_generar_random_username @username output
		exec INNERJOIN.sp_generar_random_password @password output
		set @debe_cambiar_password = 1
	end
	
	insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo,usuario_baja_logica,usuario_debe_cambiar_clave)
		values (@username,LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256',@password), 2)),'empresa',0,@debe_cambiar_password)
		
	select @id_usuario=usuario_id from INNERJOIN.usuario where usuario_username=@username
		
	insert into INNERJOIN.empresa (usuario_id,empresa_razon_social,empresa_cuit,empresa_email,empresa_telefono,empresa_domicilio_calle,empresa_domicilio_numero,empresa_domicilio_piso,empresa_domicilio_departamento,empresa_codigo_postal,empresa_ciudad,empresa_baja_logica)
		values (@id_usuario,@razonSocial,@cuit,@email,@telefono,@domCalle,(CAST(@domNro as numeric(18,0))),(CAST(@domPiso as numeric(18,0))),@domDepto,@codpost,@ciudad,0)
	
	insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
		values (@id_usuario,1)

	set @credenciales = 'Nombre de usuario: '+@username + CHAR(13) +  'Contraseña: '+@password

	commit
go

create procedure [INNERJOIN].[sp_baja_empresa] @idEmpresa numeric(18,0)
as

	begin tran

	declare @id_usuario numeric	
	declare @cantidad_compras numeric
	

	select @cantidad_compras = count(*) from INNERJOIN.compra where id_usuario = @idEmpresa and compra_id not in (select id_compra from INNERJOIN.factura_item)

	exec INNERJOIN.sp_generar_comision @cantidad_compras, @idEmpresa

	select @id_usuario=usuario_id from INNERJOIN.empresa where empresa_id=@idEmpresa

	update INNERJOIN.usuario set usuario_baja_logica=1 where usuario_id=@id_usuario

	update INNERJOIN.empresa set empresa_baja_logica=1 where empresa_id=@idEmpresa



	commit
go

CREATE procedure [INNERJOIN].[sp_generar_compra] 
@id_compra numeric(10,0), @id_ubicacion numeric(10,0)
as begin

insert into GD2C2018.INNERJOIN.compra_ubicacion values (@id_compra,@id_ubicacion)

select @@IDENTITY

return

end
go


create procedure [INNERJOIN].[cambiar_password] @idUsuario numeric(18,0),@password varchar(64)
as

	update INNERJOIN.usuario set usuario_password = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256',@password), 2)) where usuario_id = @idUsuario
go




create procedure [INNERJOIN].[sp_sumar_login_fallido] @idUsuario numeric(18,0)
as
begin
	
	declare @intentos_fallidos numeric;

	SELECT @intentos_fallidos = usuario_logins_fallidos from INNERJOIN.usuario where usuario_id = @idUsuario

	set @intentos_fallidos = @intentos_fallidos + 1;

	update INNERJOIN.usuario set usuario_logins_fallidos = @intentos_fallidos where usuario_id = @idUsuario;
	
end

go
