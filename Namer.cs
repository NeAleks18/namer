using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

public class Namer : Plugin<Config>
{
    private EventHandlers EventHandler;

    public override string Name { get; } = "Namer";

    public override string Author { get; } = "everyofflineuser";

    public override Version Version { get; } = new Version(1, 0, 0);

    public override void OnEnabled()
    {
        EventHandler = new EventHandlers();
        base.OnEnabled();
        Player.Spawning += EventHandler.OnSpawning;
    }

    public override void OnDisabled()
    {
        base.OnDisabled();
        Player.Spawning -= EventHandler.OnSpawning;
        EventHandler = null;
    }
}
