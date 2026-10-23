# Sistema de Gestión Escolar

Proyecto práctico para la aplicación de un patrón Modelo-Vista-Controller (MVC) utilizando .NET 10 y SQL Server.

## Integrantes del Grupo
* **Alexander Rafael Infante Salas** - Entidad: `Estudiante`
* **Eliecer Mateo Mogollón Ortiz** - Entidad: `Maestro`
* **Carmen Violeta Tapia Sotamba ** - Entidad: `Aula`
* **Jannina Viviana Puga Monserrate** - Entidad: `Libro`

## Pasos para Ejecutar el Proyecto Localmente
Para levantar la aplicación en su ordenador local siga los siguientes pasos:

### 1. Configurar la Cadena de Conexión
Abra el archivo `appsettings.json` en la raíz del proyecto y asegúrese de que la propiedad `DefaultConnection` apunte a su instancia local de SQL Server Express:
```json
"Server=localhost\\SQLEXPRESS;Database=SistemaGestionEscolar;Trusted_Connection=True;MultipleActiveResultSets=true"
```
### 2. Aplicar las Migraciones a la Base de Datos
Abra la **Consola del Administrador de paquetes NuGet** en Visual Studio (Herramientas > Administrador de paquetes NuGet > Consola del Administrador de paquetes) y ejecute el siguiente comando para mapear todas las tablas físicas en su servidor de SQL Server:
```text
Update-Database
```
### 3. Ejecutar la Aplicación
Presione el botón **Iniciar / Play (https)** en Visual Studio para compilar y abrir el sistema escolar en su navegador web.
