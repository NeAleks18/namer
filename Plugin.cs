using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

public class Plugin : Plugin<Config>
{
    public static Plugin Instance;

    public override string Name { get; } = "Namer";

    public override string Author { get; } = "everyofflineuser";

    public override Version Version { get; } = new Version(1, 0, 0);

    public EventHandlers EventHandlers { get; private set; }

    public override void OnEnabled()
    {
        Instance = this;
        EventHandlers = new EventHandlers(this);
        Player.Spawning += EventHandlers.OnSpawning;

        base.OnEnabled();
    }

    public override void OnDisabled()
    {
        Player.Spawning -= EventHandlers.OnSpawning;
        EventHandlers = null;

        base.OnDisabled();
    }
}
