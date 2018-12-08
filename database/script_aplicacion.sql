create procedure INNERJOIN.sp_eliminar_rol 
@id_rol numeric(10,0)
as begin

delete from INNERJOIN.rol_funcionalidad where id_rol = @id_rol
delete from INNERJOIN.usuario_rol where id_rol = @id_rol
delete from INNERJOIN.rol where rol_id = @id_rol

end

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


create procedure [INNERJOIN].[sp_baja_cliente] @idCliente numeric(18,0)
as

	begin tran

	declare @id_usuario numeric

	select @id_usuario=usuario_id from INNERJOIN.cliente where cliente_id=@idCliente

	update INNERJOIN.usuario set usuario_baja_logica=1 where usuario_id=@id_usuario

	update INNERJOIN.cliente set cliente_baja_logica=1 where cliente_id=@idCliente

	commit 
	
	
	




create procedure [INNERJOIN].[sp_alta_cliente] @username nvarchar(16) output,@password nvarchar(16) output,@tipodni nvarchar(4),@nrodni nvarchar(255),@cuil nvarchar(255),@apellido nvarchar(255),@nombre nvarchar(255),@fechanac nvarchar(255),@email nvarchar(255),@telefono nvarchar(20),@dom_calle nvarchar(255),@dom_numero nvarchar(255),@dom_piso nvarchar(255),@dom_depto nvarchar(255),@codpost nvarchar(255),@num_tarjeta nvarchar(255),@venc_tarjeta nvarchar(255)
as

	begin tran

	declare @id_usuario numeric
	declare @id_cliente numeric

	if ((@username = '') and (@password = ''))
	begin
		exec INNERJOIN.sp_generar_random_username @username output
		exec INNERJOIN.sp_generar_random_password @password output
	end
	
	insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo,usuario_baja_logica)
		values (@username,LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256',@password), 2)),'cliente',0)
		
	select @id_usuario=usuario_id from INNERJOIN.usuario where usuario_username=@username
		
	insert into INNERJOIN.cliente (usuario_id,cliente_tipo_dni,cliente_numero_dni,cliente_cuil,cliente_apellido,cliente_nombre,cliente_fecha_nacimiento,cliente_email,cliente_telefono,cliente_domicilio_calle,cliente_domicilio_numero,cliente_domicilio_piso,cliente_domicilio_departamento,cliente_codigo_postal,cliente_baja_logica)
		values (@id_usuario,@tipodni,(CAST(@nrodni as numeric(18,0))),@cuil,@apellido,@nombre,CONVERT(date,@fechanac, 103),@email,@telefono,@dom_calle,(CAST(@dom_numero as numeric(18,0))),(CAST(@dom_piso as numeric(18,0))),@dom_depto,@codpost,0)
		
	select @id_cliente=cliente_id from INNERJOIN.cliente where usuario_id=@id_usuario

	insert into INNERJOIN.tarjeta_credito (numero,fec_vencimiento,cliente_id)
		values ((CAST(@num_tarjeta as numeric(18,0))),CONVERT(date,@venc_tarjeta, 103),@id_cliente)
	
	insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
		values (@id_usuario,3)

	commit  



procedure [INNERJOIN].[sp_generar_comision] @cantidad_compras int,@id_empresa numeric(10,0)
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

insert into INNERJOIN.factura values(@id_empresa, GETDATE())
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

fetch next from c_cursor1 into @id_compra, @porcentaje_comision
end


close c_cursor1
deallocate c_cursor1

end


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
	




create procedure [INNERJOIN].[sp_alta_empresa] @username nvarchar(16) output,@password nvarchar(16) output,@razonSocial nvarchar(255),@cuit nvarchar(255),@domCalle nvarchar(255),@domNro nvarchar(255),@domPiso nvarchar(255),@domDepto nvarchar(255),@ciudad nvarchar(255),@codpost nvarchar(255),@telefono nvarchar(255),@email nvarchar(255)
as

	begin tran

	declare @id_usuario numeric
	declare @id_empresa numeric

	if ((@username = '') and (@password = ''))
	begin
		exec INNERJOIN.sp_generar_random_username @username output
		exec INNERJOIN.sp_generar_random_password @password output
	end
	
	insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo,usuario_baja_logica)
		values (@username,LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256',@password), 2)),'empresa',0)
		
	select @id_usuario=usuario_id from INNERJOIN.usuario where usuario_username=@username
		
	insert into INNERJOIN.empresa (usuario_id,empresa_razon_social,empresa_cuit,empresa_email,empresa_telefono,empresa_domicilio_calle,empresa_domicilio_numero,empresa_domicilio_piso,empresa_domicilio_departamento,empresa_codigo_postal,empresa_ciudad,empresa_baja_logica)
		values (@id_usuario,@razonSocial,@cuit,@email,@telefono,@domCalle,(CAST(@domNro as numeric(18,0))),(CAST(@domPiso as numeric(18,0))),@domDepto,@codpost,@ciudad,0)
	
	insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
		values (@id_usuario,1)

	commit


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



create procedure [INNERJOIN].[cambiar_password] @idUsuario numeric(18,0),@password nvarchar(16)
as

	update INNERJOIN.usuario set usuario_password = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256',@password), 2)) where usuario_id = @idUsuario





create procedure INNERJOIN.sp_generar_random_username @username nvarchar(16) output
as
begin
	
	SELECT @username = replace((left(CONVERT(nvarchar(255), NEWID()),16)),'-','');

	while ((select count(*) from INNERJOIN.usuario where usuario_username = @username) <> 0)
		SELECT @username = replace((left(CONVERT(nvarchar(255), NEWID()),16)),'-','');
	
end





create procedure INNERJOIN.sp_generar_random_password @password nvarchar(16) output
as
begin
	
	SELECT @password = replace((left(CONVERT(nvarchar(255), NEWID()),16)),'-','');
	
end


