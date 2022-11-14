SELECT registros_hoy.id_eco_resid AS id_registro,
ecopunto.id_ecopunto AS id_ecopunto,
ecopunto.nombre AS ecopunto,
residuo.id_residuo AS id_residuo,personalpersonalpersonal
residuo.nombre_residuo AS residuo,
SUM(registros_hoy.cantidad_residuo) as total
FROM registros_hoy
JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo
JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto
WHERE ecopunto.nombre = 'Cruz Roja'
GROUP BY registros_hoy.id_residuo
ORDER BY registros_hoy.id_eco_resid
-- SELECT residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo