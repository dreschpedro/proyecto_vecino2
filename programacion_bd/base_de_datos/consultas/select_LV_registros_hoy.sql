SELECT registros_hoy.id_eco_resid AS id, residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo
FROM residuo
JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo

#SELECT residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo, registros_hoy.hora AS hora FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo