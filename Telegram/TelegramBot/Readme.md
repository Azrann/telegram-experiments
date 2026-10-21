# TelegramBot

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2018.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2018-07-07**, [`Telegram/TelegramBot/TelegramBot.cs`](TelegramBot.cs); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2018-06-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [OpenTl.ClientApi 0.4.76](https://www.nuget.org/packages/OpenTl.ClientApi/0.4.76), publicada el **2018-06-08** (versión declarada), en [`Telegram/TelegramBot/packages.config`](packages.config).
- Referencia adicional: destino `v4.7.2` en [`Telegram/TelegramBot/TelegramBot.csproj`](TelegramBot.csproj); su [versión estable se publicó el 2018-04-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-framework). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

## Por qué merece la pena mirarlo

La consola y OpenTL permiten explorar autenticación de usuario, sesiones y consultas MTProto, un nivel distinto del simple envío de mensajes de un bot. El punto de interés es la separación entre la aplicación consumidora y el cliente de protocolo.

Puntos de entrada al código:

- [`ClientFactory.cs`](ClientFactory.cs)
- [`Program.cs`](Program.cs)

<!-- END project-context -->

