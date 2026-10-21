# telegram-experiments

Experimentos de cliente Telegram y prototipo de listado de canales.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2018.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2018-08-18**, [`TelegramChannelListing/src/TelegramChannelListing.sln`](TelegramChannelListing/src/TelegramChannelListing.sln); fecha de modificación conservada.
- Primer registro entre los repositorios Git originales incluidos: **2018-06-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [OpenTl.ClientApi 0.4.76](https://www.nuget.org/packages/OpenTl.ClientApi/0.4.76), publicada el **2018-06-08** (versión declarada), en [`Telegram/TelegramBot/packages.config`](Telegram/TelegramBot/packages.config).
- Referencia adicional: destino `netcoreapp2.1` en [`TelegramChannelListing/src/TelegramChannelListing/TelegramChannelListing.csproj`](TelegramChannelListing/src/TelegramChannelListing/TelegramChannelListing.csproj); su [versión estable se publicó el 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Años de referencia por componente (archivo más reciente datable):

| Componente | Año |
| --- | --- |
| [`Telegram/TelegramBot`](Telegram/TelegramBot/) | 2018 |
| [`Telegram/Telegram.sln`](Telegram/Telegram.sln) | 2018 |
| [`Telegram/FodyWeavers.xml`](Telegram/FodyWeavers.xml) | 2018 |
| [`TelegramChannelListing`](TelegramChannelListing/) | 2018 |
| [`telegramchannel.listing`](telegramchannel.listing/) | Sin determinar |

## Por qué merece la pena mirarlo

La consola permite seguir autenticación y consultas de usuario mediante MTProto; el proyecto MVC conserva una idea inicial de directorio de canales. Es importante distinguir el experimento de protocolo del esqueleto web todavía sin catálogo.

Puntos de entrada al código:

- [`Telegram/TelegramBot/ClientFactory.cs`](Telegram/TelegramBot/ClientFactory.cs)
- [`Telegram/TelegramBot/Program.cs`](Telegram/TelegramBot/Program.cs)
- [`TelegramChannelListing/src/TelegramChannelListing/Controllers/HomeController.cs`](TelegramChannelListing/src/TelegramChannelListing/Controllers/HomeController.cs)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`Telegram/TelegramBot/`](Telegram/TelegramBot/) | Código fuente |
| [`TelegramChannelListing/`](TelegramChannelListing/) | Esqueleto de aplicación ASP.NET Core MVC llamado TelegramChannelListing, con páginas de inicio, información, contacto, privacidad y errores. |
| [`telegramchannel.listing/`](telegramchannel.listing/) | Carpeta de repositorio sin archivos de trabajo; únicamente existe .git. |

Las sesiones, números de teléfono y credenciales se han retirado. El código OpenTL se conserva en opentl-client-api-fork; ajustar las referencias locales si se usa esta solución.

## Requisitos y preparación

.NET Framework 4.7.2, .NET Core 2.1 y OpenTL.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

Soluciones conservadas:

- `Telegram/Telegram.sln`
- `TelegramChannelListing/src/TelegramChannelListing.sln`

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.
