# Vecino Sustentable

En este proyecto se trabajan las siguientes materias:

- **[Análisis y Diseño de Sistemas](./analisis_y_Dis/)**
    >Se analiza el sistema de trabajo de la ONG, con dicha información se crea el diseño del sistema  (software)

- **[Metodología de desarrollo de Software](./metodologias_dev_software/)**
    >Desarrollamos un proyecto mediante la aplicación Azure DevOps con las metodologías Scrum

- **[Programación con Bases de datos](./programacion_bd/)**
    >Se crea un sistema interno, donde agregar y modificar informacion sobre ecopuntos, voluntarios y residuos trabajados

- **[Programación Web 1](./prog_web/)**
    >Se crea el Front-End de la página con todos los views correspondientes.
    >
    >Se evalua la posibiidad de implementar un framework como Tailwind para la parte visual

## **Instalación / Uso**

- ### **[Metodología de desarrollo de Software](./metodologias_dev_software/)**

>Se debe ingresar a este link de [Azure DevOps](https://dev.azure.com/PedroDresch/Vecino%20Sustentable) con el correo

- ### **[Programación con Bases de datos](./programacion_bd/)**

>Se debe descargar el instalador de Visual Basic Express 2010 de [Mega](https://mega.nz/file/6o0mzIYR#yAIbfgbZwjAfdXiDUUNrTC-Ql6C4tdI-8Wmso0_Mol4), debe ejecutar el archivo ***setup.exe***
>
>Luego de instalar el IDE, se debe iniciar la [Aplicacion](./programacion_bd/aplicacion_visual_basic/vecino_sustentable/vecino_sustentable.sln) y elegir el programa recién sintalado para abrirla.
>
>Posteriormente se debe instalar el [Conector de MySQL](./programacion_bd/aplicacion_visual_basic/mysql-connector-net-6.9.7.msi), para luego referenciarlo dentro del proyecto en **Referencias del Proyecto**

>Por último se debe importar el [Archivo .SQL](./programacion_bd/base_de_datos/tablas/EXPORTADO.sql) dentro del programa **Heidi SQL** (previamente instalado con el setup de Visual Basic) y ejecutar el archivo, creando así la base de datos necesaria para que la aplicación funcione en su totalidad

