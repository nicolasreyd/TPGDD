create procedure gd_esquema.sp_eliminar_rol 
@id_rol numeric(10,0)
as begin

delete from gd_esquema.rol_funcionalidad where id_rol = @id_rol
delete from gd_esquema.usuario_rol where id_rol = @id_rol
delete from gd_esquema.rol where rol_id = @id_rol

end