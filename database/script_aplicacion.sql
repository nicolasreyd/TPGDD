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