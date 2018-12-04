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
	
	
	




create procedure [INNERJOIN].[sp_alta_cliente] @tipodni nvarchar(4),@nrodni nvarchar(255),@cuil nvarchar(255),@apellido nvarchar(255),@nombre nvarchar(255),@fechanac nvarchar(255),@email nvarchar(255),@telefono nvarchar(20),@dom_calle nvarchar(255),@dom_numero nvarchar(255),@dom_piso nvarchar(255),@dom_depto nvarchar(255),@codpost nvarchar(255),@num_tarjeta nvarchar(255),@venc_tarjeta nvarchar(255)
as

	begin tran

	declare @id_usuario numeric
	declare @id_cliente numeric
	declare @username nvarchar(255)

	select @username=MAX(CAST(usuario_username as bigint))+1 from innerjoin.usuario
	
	insert into INNERJOIN.usuario (usuario_username,usuario_password,usuario_tipo,usuario_baja_logica)
		values (@username,getdate(),'CLIENTE',0)
		
	select @id_usuario=usuario_id from INNERJOIN.usuario where usuario_username=@username
		
	insert into INNERJOIN.cliente (usuario_id,cliente_tipo_dni,cliente_numero_dni,cliente_cuil,cliente_apellido,cliente_nombre,cliente_fecha_nacimiento,cliente_email,cliente_telefono,cliente_domicilio_calle,cliente_domicilio_numero,cliente_domicilio_piso,cliente_domicilio_departamento,cliente_codigo_postal,cliente_baja_logica)
		values (@id_usuario,@tipodni,(CAST(@nrodni as numeric(18,0))),@cuil,@apellido,@nombre,CONVERT(date,@fechanac, 103),@email,@telefono,@dom_calle,(CAST(@dom_numero as numeric(18,0))),(CAST(@dom_piso as numeric(18,0))),@dom_depto,@codpost,0)
		
	select @id_cliente=cliente_id from INNERJOIN.cliente where usuario_id=@id_usuario

	insert into INNERJOIN.tarjeta_credito (numero,fec_vencimiento,cliente_id)
		values ((CAST(@num_tarjeta as numeric(18,0))),CONVERT(date,@venc_tarjeta, 103),@id_cliente)
	
	insert into INNERJOIN.usuario_rol (id_usuario,id_rol)
		values (@id_usuario,3)

	commit 