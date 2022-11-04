SELECT usuario, pass, rol, apellido, nombre, telefono
from personal
WHERE ((usuario like '%a%') OR (apellido like '%a%') OR (nombre like '%a%') )
ORDER BY usuario

#SELECT usuario, pass, rol, apellido, nombre, telefono from personal WHERE ((usuario like '%a%') OR (apellido like '%a%') OR (nombre like '%a%')) ORDER BY usuario