SELECT registros_hoy.id_eco_resid AS id_registro,
ecopunto.nombre AS ecopunto,
residuo.nombre_residuo AS residuo,
registros_hoy.cantidad_residuo AS cantidad
FROM registros_hoy
JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo
JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto
WHERE (residuo.nombre_residuo like '%a%')
ORDER BY registros_hoy.id_eco_resid

-- SELECT registros_hoy.id_eco_resid AS id_registro, ecopunto.nombre AS ecopunto, residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto WHERE (residuo.nombre_residuo like '%a%') ORDER BY registros_hoy.id_eco_resid