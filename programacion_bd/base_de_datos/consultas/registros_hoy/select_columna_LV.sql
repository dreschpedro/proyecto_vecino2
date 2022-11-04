-- COLUMNA 0

-- SELECT residuo.nombre_residuo AS residuo, 
-- registros_hoy.cantidad_residuo AS cantidad 
-- FROM residuo 
-- JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo
-- ORDER BY registros_hoy.id_residuo

-- SELECT residuo.nombre_residuo AS residuo,  registros_hoy.cantidad_residuo AS cantidad FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo ORDER BY registros_hoy.id_residuo


-- COLUMNA 1

SELECT residuo.nombre_residuo AS residuo, 
registros_hoy.cantidad_residuo AS cantidad 
FROM residuo 
JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo
ORDER BY registros_hoy.cantidad_residuo

-- SELECT residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo ORDER BY registros_hoy.cantidad_residuo