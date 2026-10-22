**Languages:** [English](Readme.md) · [Español](README.es.md)

# TelegramBot

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2018.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2018-07-07**, [`Telegram/TelegramBot/TelegramBot.cs`](TelegramBot.cs); preserved modification timestamp.
- First record in the original Git repository containing this code: **2018-06-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [OpenTl.ClientApi 0.4.76](https://www.nuget.org/packages/OpenTl.ClientApi/0.4.76), published on **2018-06-08** (declared version), in [`Telegram/TelegramBot/packages.config`](packages.config).
- Additional reference: target `v4.7.2` in [`Telegram/TelegramBot/TelegramBot.csproj`](TelegramBot.csproj); its [stable release was published on 2018-04-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-framework). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

## Why this is worth exploring

The console and OpenTL let you explore user authentication, sessions, and MTProto queries, at a different level from simply sending bot messages. The interesting part is the separation between the consuming application and the protocol client.

Code entry points:

- [`ClientFactory.cs`](ClientFactory.cs)
- [`Program.cs`](Program.cs)

<!-- END project-context -->

