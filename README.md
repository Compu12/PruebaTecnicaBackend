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

json
"ConnectionStrings": {
  "Connection": "Server=(localdb)\\mssqllocaldb;Database=NombreDeTuBaseDeDatos;Trusted_Connection=True;"
}
Guardar los Cambios.

Ejecución del Proyecto
Abre una terminal en el directorio del proyecto y ejecuta el siguiente comando:

bash
Copy code
dotnet run
Abre tu navegador y navega a https://localhost:7028/swagger/index.html 
Donde se encontrara las Apis Documentas
**Uso de las APIs**
Endpoints
1. Obtener Todos los Clientes
Endpoint
sql
Copy code
GET /Clientes
Descripción
Recupera una lista de todos los clientes.

Respuesta
200 OK: Devuelve una lista de clientes.
500 Internal Server Error: Si hay un error interno en el servidor.
2. Obtener Cliente por ID
Endpoint

GET /Clientes/{idCliente}
Descripción
Recupera un cliente específico por su ID.

Parámetros
idCliente (entero): El ID del cliente que se desea recuperar.
Respuesta
200 OK: Devuelve los detalles del cliente especificado.
404 Not Found: Si no se encuentra el cliente con el ID especificado.
500 Internal Server Error: Si hay un error interno en el servidor.
3. Crear Cliente
Endpoint
POST /Clientes
Descripción
Crea un nuevo cliente.

Cuerpo de la Solicitud
NombreCliente (cadena): El nombre del cliente.
CorreoCliente (cadena): La dirección de correo electrónico del cliente.
Respuesta
200 OK: Devuelve los detalles del cliente recién creado.
400 Bad Request: Si el cuerpo de la solicitud no es válido.
500 Internal Server Error: Si hay un error interno en el servidor.

4. Actualizar Cliente
Endpoint

PUT /ActualizarCliente
Descripción
Actualiza un cliente existente.

Cuerpo de la Solicitud
IdCliente (entero): El ID del cliente que se desea actualizar.
NombreCliente (cadena): El nombre actualizado del cliente.
CorreoCliente (cadena): La dirección de correo electrónico actualizada del cliente.
Respuesta
200 OK: Devuelve un mensaje de éxito y los detalles actualizados del cliente.
404 Not Found: Si no se encuentra el cliente con el ID especificado.
400 Bad Request: Si el cuerpo de la solicitud no es válido.
500 Internal Server Error: Si hay un error interno en el servidor.
5. Eliminar Cliente
Endpoint
DELETE /EliminarCliente/{idCliente}
Descripción
Elimina un cliente por su ID.

Parámetros
idCliente (int): El ID del cliente que se desea eliminar.
Respuesta
200 OK: Devuelve un mensaje de éxito y el ID del cliente eliminado.
404 Not Found: Si no se encuentra el cliente con el ID especificado.
500 Internal Server Error: Si hay un error interno en el servidor.

