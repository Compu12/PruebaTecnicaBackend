# Prueba Técnica Desarrollador Fullstack

 Desarrollar un CRUD .Net (API, Backend) para la creación de Clientes y Servicios

## Requisitos Previos

Asegúrate de tener instalado lo siguiente:

- [**.NET SDK 6.0**](https://dotnet.microsoft.com/download/dotnet/6.0)
- [**Visual Studio Code**](https://code.visualstudio.com/) o [**Visual Studio 2022**](https://visualstudio.microsoft.com/)

## Configuración del Proyecto

1. **Clonar el Repositorio:**

   ```bash
   git clone [https://github.com/tuusuario/tuproyecto.git](https://github.com/Compu12/PruebaTecnicaBackend.git)https://github.com/Compu12/PruebaTecnicaBackend.git
   cd PruebaTecnicaBackend

2. **Abrir el Proyecto:**

Abre el proyecto en tu editor preferido.

3. **Configurar la Cadena de Conexión de la Base de Datos:**

Abre el archivo appsettings.json.

Busca la sección "ConnectionStrings" y actualiza la cadena de conexión según tus necesidades.

~~~
"ConnectionStrings": {
  "Connection": "Server=(localdb)\\mssqllocaldb;Database=NombreDeTuBaseDeDatos;Trusted_Connection=True;"
}
~~~

Guardar los Cambios.

4. **Ejecución del Proyecto**

Abre una terminal en el directorio del proyecto y ejecuta el siguiente comando:

~~~
dotnet run
~~~

Abre tu navegador y navega a https://localhost:7028/swagger/index.html 

Donde se encontrara las Apis Documentas

## Uso de las APIs

**Endpoints**

1. ***Obtener Todos los Clientes***
   
Endpoint
~~~
GET /Clientes
~~~

Descripción

Recupera una lista de todos los clientes.

Respuesta
- 200 OK: Devuelve una lista de clientes.
- 500 Internal Server Error: Si hay un error interno en el servidor.

2. ***Obtener Cliente por ID***
   
Endpoint
~~~
GET /Clientes/{idCliente}
~~~
Descripción

Recupera un cliente específico por su ID.

Parámetros
- idCliente (int): El ID del cliente que se desea recuperar.

Respuesta
- 200 OK: Devuelve los detalles del cliente especificado.
- 404 Not Found: Si no se encuentra el cliente con el ID especificado.
- 500 Internal Server Error: Si hay un error interno en el servidor.

3. ***Crear Cliente***
   
Endpoint
~~~
POST /Clientes
~~~

Descripción

Crea un nuevo cliente.

Cuerpo de la Solicitud
- NombreCliente (string): El nombre del cliente.
- CorreoCliente (string): La dirección de correo electrónico del cliente.

Respuesta
- 200 OK: Devuelve los detalles del cliente recién creado.
- 400 Bad Request: Si el cuerpo de la solicitud no es válido.
- 500 Internal Server Error: Si hay un error interno en el servidor.

4. ***Actualizar Cliente***
   
Endpoint
~~~
PUT /Cliente
~~~
Descripción

Actualiza un cliente existente.

Cuerpo de la Solicitud
- IdCliente (int): El ID del cliente que se desea actualizar.
- NombreCliente (string): El nombre actualizado del cliente.
- CorreoCliente (string): La dirección de correo electrónico actualizada del cliente.

Respuesta
- 200 OK: Devuelve un mensaje de éxito y los detalles actualizados del cliente.
- 404 Not Found: Si no se encuentra el cliente con el ID especificado.
- 400 Bad Request: Si el cuerpo de la solicitud no es válido.
- 500 Internal Server Error: Si hay un error interno en el servidor.

5. ***Eliminar Cliente***
   
Endpoint
~~~
DELETE /Cliente/{idCliente}
~~~
Descripción

Elimina un cliente por su ID.


Parámetros
- idCliente (int): El ID del cliente que se desea eliminar.

Respuesta
- 200 OK: Devuelve un mensaje de éxito y el ID del cliente eliminado.
- 404 Not Found: Si no se encuentra el cliente con el ID especificado.
- 500 Internal Server Error: Si hay un error interno en el servidor.

1. ***Obtener Todos los Servicios***
   
Endpoint
~~~
GET /Servicios
~~~
Descripción

Recupera una lista de todos los servicios.

Respuesta
- 200 OK: Devuelve una lista de servicios.
- 500 Internal Server Error: Si hay un error interno en el servidor.
2. ***Obtener Servicio por ID***
  
Endpoint
~~~
GET /Servicios/{idServicio}
~~~
Descripción

Recupera un servicio específico por su ID.

Parámetros
- idServicio (entero): El ID del servicio que se desea recuperar.
  
Respuesta
- 200 OK: Devuelve los detalles del servicio especificado.
- 404 Not Found: Si no se encuentra el servicio con el ID especificado.
- 500 Internal Server Error: Si hay un error interno en el servidor.
3. ***Crear Servicio***
  
Endpoint
~~~
POST /Servicios
~~~
Descripción

Crea un nuevo servicio.

Cuerpo de la Solicitud
- NombreServicio (string): El nombre del servicio.
- DescripcionServicio (string): La descripción del servicio.
  
Respuesta
- 200 OK: Devuelve los detalles del servicio recién creado.
- 400 Bad Request: Si el cuerpo de la solicitud no es válido.
- 500 Internal Server Error: Si hay un error interno en el servidor.
4. ***Actualizar Servicio***
  
Endpoint
~~~
PUT /Servicio
~~~
Descripción

Actualiza un servicio existente.

Cuerpo de la Solicitud
- IdServicio (int): El ID del servicio que se desea actualizar.
- NombreServicio (string): El nombre actualizado del servicio.
- DescripcionServicio (string): La descripción actualizada del servicio.
  
Respuesta
- 200 OK: Devuelve un mensaje de éxito y los detalles actualizados del servicio.
- 404 Not Found: Si no se encuentra el servicio con el ID especificado.
- 400 Bad Request: Si el cuerpo de la solicitud no es válido.
- 500 Internal Server Error: Si hay un error interno en el servidor.
5. ***Eliminar Servicio***
  
Endpoint
~~~
DELETE /Servicio/{idServicio}
~~~
Descripción

Elimina un servicio por su ID.

Parámetros
- idServicio (int): El ID del servicio que se desea eliminar.
  
Respuesta
- 200 OK: Devuelve un mensaje de éxito y el ID del servicio eliminado.
- 404 Not Found: Si no se encuentra el servicio con el ID especificado.
- 500 Internal Server Error: Si hay un error interno en el servidor.


