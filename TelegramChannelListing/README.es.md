**Languages:** [English](Readme.md) · [Español](README.es.md)

# TelegramChannelListing

Esqueleto de aplicación ASP.NET Core MVC llamado TelegramChannelListing, con páginas de inicio, información, contacto, privacidad y errores.

Documentación basada en los archivos locales revisados el 21 de octubre de 2026.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2018.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2018-08-18**, [`TelegramChannelListing/src/TelegramChannelListing.sln`](src/TelegramChannelListing.sln); fecha de modificación conservada.
- Referencia adicional: destino `netcoreapp2.1` en [`TelegramChannelListing/src/TelegramChannelListing/TelegramChannelListing.csproj`](src/TelegramChannelListing/TelegramChannelListing.csproj); su [versión estable se publicó el 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

## Por qué merece la pena mirarlo

Conserva el esqueleto MVC de una aplicación que pretendía listar canales. Puede servir para estudiar el arranque y las vistas de ASP.NET Core 2.1; el listado y la conexión con Telegram no aparecen implementados.

Puntos de entrada al código:

- [`src/TelegramChannelListing/Startup.cs`](src/TelegramChannelListing/Startup.cs)
- [`src/TelegramChannelListing/Controllers/HomeController.cs`](src/TelegramChannelListing/Controllers/HomeController.cs)

<!-- END project-context -->

## Estructura y responsabilidades

| Ruta | Responsabilidad |
| --- | --- |
| `src/TelegramChannelListing/` | Aplicación web, Program y Startup. |
| `src/TelegramChannelListing/Controllers/HomeController.cs` | Acciones de las páginas de la plantilla. |
| `src/TelegramChannelListing/Views/` | Vistas Razor y layout. |
| `src/TelegramChannelListing.sln` | Solución de Visual Studio. |

## Tecnologías y requisitos

.NET Core 2.1 y herramientas compatibles con ASP.NET Core MVC de esta versión.

Destinos leídos de los proyectos: `netcoreapp2.1`.

## Preparación y arranque

Revisar Startup y launchSettings.json antes de iniciar el proyecto web. No se ejecutó el servidor.

Comandos de preparación, desde esta carpeta, después de revisar la configuración privada:

```text
dotnet restore src/TelegramChannelListing.sln
dotnet build src/TelegramChannelListing/TelegramChannelListing.csproj
```

Soluciones presentes: `src/TelegramChannelListing.sln`.

## Configuración e integraciones

appsettings.json contiene registro y AllowedHosts. No se identificó un token Telegram o conexión de catálogo en la configuración visible.

## Estado de esta copia

El nombre sugiere un directorio de canales, pero no se encontró una implementación de listado o integración Telegram. La carpeta telegramchannel.listing también existe y no contiene código de aplicación visible; no se fusionaron ambas.

La revisión fue estática: no se restauraron dependencias, no se compiló ni se ejecutaron aplicaciones o pruebas. Los comandos anteriores son instrucciones de preparación, no resultados de validación. Las versiones indicadas son las del código conservado.


## Copia pública

Las credenciales originales se han retirado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Los datos locales, sesiones, certificados privados y perfiles de despliegue se omiten. Configurar servicios y credenciales propios antes de ejecutar. La compilación y el funcionamiento con servicios externos no se han validado.
