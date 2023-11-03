﻿using CommandLine;
using Matterhook.NET.MatterhookClient;
using Mattermost_Cli;


partial class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
                           .WithParsed<Options>(o =>
                           {
                               if(!o.Quiet) { Header(); }

                               MatterhookClient client = new MatterhookClient(o.Webhook);
                               MattermostMessage message = new MattermostMessage
                               {
                                   Text = o.Message,
                                   Channel = o.Channel,
                                   Username = o.User,
                                   IconUrl = o.Iconurl
                               };
                               if (o.Verbose & !o.Quiet)
                               {
                                   Console.WriteLine($"Message: '{o.Message}'\nUser: {o.User}\nChannel: {o.Channel}\nWebhook: {o.Webhook}\nIcon url (optional): {o.Iconurl}");
                               }
                               try
                               {
                                   client.PostAsync(message).Wait();
                                   if (o.Verbose & !o.Quiet)
                                   {
                                       Console.WriteLine("Message successfully delivered.");
                                   }
                               }
                               catch (Exception ex)
                               {
                                   Console.WriteLine(ex.ToString());
                               }
                           });

    }

    private static void Header()
    {
        Console.WriteLine("Mattermost Webhook Command Line Interface");
        Console.WriteLine("Sends message to a Mattermost channel using a webhook");
        Console.WriteLine("© 2023 medisoftware\n");
        Console.WriteLine("Markus from medisoftware says: Curl on Windows sucks!\n\n");
    }
}

