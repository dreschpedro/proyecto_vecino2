SELECT personal.id_personal AS id_personal,
personal.usuario AS usuario,
personal.pass AS pass,
personal.rol AS rol,
personal.apellido AS apellido,
personal.nombre AS nombre,
personal.telefono AS telefono,
imagenes.id_img AS id_img
FROM imagenes
JOIN personal ON personal.id_personal = imagenes.id_personal
WHERE personal.id_personal= '53'


-- SELECT registros_hoy.id_eco_resid AS id_registro,
-- ecopunto.nombre AS ecopunto,
-- residuo.nombre_residuo AS residuo,
-- registros_hoy.cantidad_residuo AS cantidad
-- FROM registros_hoy
-- JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo
-- JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto
-- WHERE (residuo.nombre_residuo like '%a%')
-- ORDER BY registros_hoy.id_eco_resid