# BeersApi para la materia de Desarrollo de aplicaciones hibridas
# Impartida por el Ing. Saul Salcido...

TODO: 

* -Probar Update con verbo PUT o crear funcion de Update que utilice PATCH
* -Probar verbo DELETE
* -Construir aplicacion HTML sencilla de lado del cliente para acceder al API
* -Crear interfaz que permita al usuario subir y consultar imagenes
* -Eventual deploy de la aplicacion en AWS, Azure o Heroku

Para probar la aplicacion: 
1. Clonar o descargar el repositorio
1. Ir a la carpeta bin/debug/netcoreapp3.1/ y ejecutar BeersApi.exe
1. Ir a la siguiente direccion: https://localhost:5001/api/beers
1. Utilizar ARC o Postman para probar put, get, post, delete

El get puede traer todas las cervezas o solo una. Para traer una cerveza: https://localhost:5001/api/beers/{id}
Las funciones Update y Delete funcionan de la misma manera.
