SELECT * #residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo
FROM registros_hoy
#JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo