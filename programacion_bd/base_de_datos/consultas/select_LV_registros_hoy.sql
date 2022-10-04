SELECT residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo, registros_hoy.hora AS hora 
FROM residuo
JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo