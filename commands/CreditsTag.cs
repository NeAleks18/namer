using System;
using CommandSystem;

[CommandHandler(typeof(ClientCommandHandler))]
public class NamerCMD : ICommand
{
    public string Command { get; } = "namer";

    public string[] Aliases { get; } = new string[] { "ctnamer" };

    public string Description { get; } = "Команда пишет о том кто модифицировал плагин или кто создал.";

    private string ModifyAuthor = "NONE";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        response = $"Created by everyofflineuser\nCreated to use in Extenvil Games Server\nModified by {ModifyAuthor}";
        return true;
    }
}
