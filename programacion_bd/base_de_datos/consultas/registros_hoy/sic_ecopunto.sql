SELECT registros_hoy.id_eco_resid AS id_registro,
residuo.nombre_residuo AS residuo,
ecopunto.nombre AS ecopunto,
registros_hoy.cantidad_residuo AS cantidad
FROM registros_hoy
JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo
JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto
ORDER BY ecopunto.nombre

-- SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY ecopunto.nombre