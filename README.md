# Mattermost-Webhook-Cli

Send text messages from the command line to a [Mattermost](https://mattermost.com/) channel 
using incoming webhooks.

## Introducion

I struggled using *Curl* on Windows to send messages to Mattermost incoming webhook, altough, it´s
[possible](https://mattermost.com/blog/mattermost-integrations-incoming-webhooks/). 

*Mattermost-Webhook-Cli* takes usage of the Nuget packages 
*[Matterhook.NET.MatterhookClient](https://github.com/PromoFaux/Matterhook.NET.MatterhookClient)* and 
[*commandline*](https://github.com/commandlineparser/commandline) so ease this task.

*This project is rarely tested and contains just a few lines of own code.*

## Setup

- [Create a incoming webhook](https://developers.mattermost.com/integrate/webhooks/incoming/) or copy the URL of an existing one.
- If not yet installed: Install .NET 6.0 Desktop Runtime (download and install from [Microsoft](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or install using [Chocolatey](https://chocolatey.org/): `choco install dotnet-6.0-desktopruntime`)

## Usage

```
.\Mattermost-Webhook-Cli.exe
Mattermost-Webhook-Cli 1.0.0
Copyright (C) 2023 elpatron@mailbox.org

-c, --channel    Required. Set Mattermost channel.
-w, --webhook    Required. Set Mattermost webhook url.
-u, --user       Required. Set user name.
-m, --message    Required. Set message text.
-i, --iconurl    Set message icon url.
-v, --verbose    (Default: false) Set output to verbose messages.
-q, --quiet      (Default: false) Supress any output. May not be used in combination with -v.
--help           Display this help screen.
--version        Display version information.
```

## Example

Replace `<your-mattermost-incoming-webhook>` with your webhook url.

`.\Mattermost-Webhook-Cli.exe -c "town-square" 
-w "https://<your-mattermost-incoming-webhook>" -u mm-cli 
-m "Hello World!\n:wave_light_skin_tone:" -v` 