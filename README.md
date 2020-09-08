# BeersApi para la materia de Desarrollo de aplicaciones hibridas.
# Impartida por el Ing. Saul Salcido.

# Integrantes del Equipo: 

Amed Daniel Limas Palma
Sergio Andres Muños Castillo
Jose Daniel Renteria Silva
David Servando Torres Ortega 
Sergio Alberto Varela Bencomo

# Tecnologías utilizadas

* -C#
* -ASP.NET
* -MongoDB

Para probar la aplicacion: 
1. Clonar o descargar el repositorio
1. Es necesario tener instalado .NET Core 3.1 para que se pueda ejecutar el programa
1. Ir a la carpeta bin/debug/netcoreapp3.1/ y ejecutar BeersApi.exe
1. Ir a la siguiente direccion: https://localhost:5001/api/beers
1. Utilizar ARC o Postman para probar put, get, post, delete

<pre>
/getall           [get]                     Return all the beers  
/create           [post]                    Create a beer 
/getbeer{id}      [get]                     Return a beer 
/update{id}       [put]                     Update a beer 
/delete{id}       [delete]                  Delete a beer 
</pre>

Para editar la aplicación
* -Es ampliamente recomendable abrir la solución como un proyecto de Visual Studio 2019. 
* -Ir a la carpeta raíz del repo y abrir BeersApi.sln

