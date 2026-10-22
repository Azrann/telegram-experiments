**Languages:** [English](README.md) · [Español](README.es.md)

# telegram-experiments

Telegram client experiments and channel listing prototype.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2018.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2018-08-18**, [`TelegramChannelListing/src/TelegramChannelListing.sln`](TelegramChannelListing/src/TelegramChannelListing.sln); preserved modification timestamp.
- Earliest record among the original Git repositories included: **2018-06-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [OpenTl.ClientApi 0.4.76](https://www.nuget.org/packages/OpenTl.ClientApi/0.4.76), published on **2018-06-08** (declared version), in [`Telegram/TelegramBot/packages.config`](Telegram/TelegramBot/packages.config).
- Additional reference: target `netcoreapp2.1` in [`TelegramChannelListing/src/TelegramChannelListing/TelegramChannelListing.csproj`](TelegramChannelListing/src/TelegramChannelListing/TelegramChannelListing.csproj); its [stable release was published on 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

Reference years by component (most recent datable file):

| Component | Year |
| --- | --- |
| [`Telegram/TelegramBot`](Telegram/TelegramBot/) | 2018 |
| [`Telegram/Telegram.sln`](Telegram/Telegram.sln) | 2018 |
| [`Telegram/FodyWeavers.xml`](Telegram/FodyWeavers.xml) | 2018 |
| [`TelegramChannelListing`](TelegramChannelListing/) | 2018 |
| [`telegramchannel.listing`](telegramchannel.listing/) | Undetermined |

## Why this is worth exploring

The console lets you follow user authentication and queries through MTProto; the MVC project preserves an initial channel directory idea. Distinguish the protocol experiment from the web scaffold that still lacks a catalogue.

Code entry points:

- [`Telegram/TelegramBot/ClientFactory.cs`](Telegram/TelegramBot/ClientFactory.cs)
- [`Telegram/TelegramBot/Program.cs`](Telegram/TelegramBot/Program.cs)
- [`TelegramChannelListing/src/TelegramChannelListing/Controllers/HomeController.cs`](TelegramChannelListing/src/TelegramChannelListing/Controllers/HomeController.cs)

<!-- END project-context -->

## Contents

| Directory | Function |
| --- | --- |
| [`Telegram/TelegramBot/`](Telegram/TelegramBot/) | Source code |
| [`TelegramChannelListing/`](TelegramChannelListing/) | ASP.NET Core MVC application scaffold named TelegramChannelListing, with home, about, contact, privacy, and error pages. |
| [`telegramchannel.listing/`](telegramchannel.listing/) | Repository folder without working files; only .git exists. |

Sessions, phone numbers, and credentials have been removed. OpenTL code is preserved in opentl-client-api-fork; adjust local references when using this solution.

## Requirements and setup

.NET Framework 4.7.2, .NET Core 2.1, and OpenTL.

This is a historical copy. Consult each component's project files and README for versions and dependencies. Restore NuGet/npm from the appropriate folder; internal libraries may need rebuilding. Prepare databases and external services using your own accounts.

Preserved solutions:

- `Telegram/Telegram.sln`
- `TelegramChannelListing/src/TelegramChannelListing.sln`

## Configuration and security

Original secrets have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Search for this marker before running and provide values through local configuration or environment variables. Sessions, private keys, signing certificates, databases, logs, deployment profiles, and binary packages are not published. The `.gitignore` protects these local files.

A fresh history is published: old commits remain only in the original local copy. Example values cannot connect to the original services.

## Validation status

A static review and secret scan were performed before publication. Applications, trading operations, deployments, and tests contacting external services were not run. Building with current tools is not guaranteed. Some projects need historical dependencies and assets that are not included.

## Licenses and provenance

Third-party licenses and attributions present in the code are retained. No blanket license is added to components that lacked one. This import preserves local sources and does not claim to be a current version of the original project.
