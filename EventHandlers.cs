using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

public class EventHandlers
{
    private Random rnd = new Random();
    private readonly Plugin _plugin;
    internal EventHandlers(Plugin plugin) => _plugin = plugin;

    internal void OnSpawning(SpawningEventArgs ev)
    {
        if (!ev.Player.IsConnected) return;
        Config cfg = _plugin.Config;

        if (ev.Player.Role == RoleTypeId.None ||
            ev.Player.Role == RoleTypeId.Spectator ||
            ev.Player.Role == RoleTypeId.Filmmaker ||
            ev.Player.Role == RoleTypeId.CustomRole ||
            ev.Player.Role == RoleTypeId.Overwatch)
                ev.Player.DisplayNickname = null;

        if (ev.Player.IsCHI)
            ev.Player.DisplayNickname = $"{cfg.PrefixHAOS} {cfg.Names[rnd.Next(0, cfg.Names.Count)]}";

        if (ev.Player.IsNTF)
            ev.Player.DisplayNickname = $"{cfg.PrefixMOG} {cfg.Names[rnd.Next(0, cfg.Names.Count)]}";

        if (ev.Player.Role == RoleTypeId.FacilityGuard)
            ev.Player.DisplayNickname = $"{cfg.PrefixSecurity} {cfg.Names[rnd.Next(0, cfg.Names.Count)]}";

        if (ev.Player.IsScp)
            ev.Player.DisplayNickname = cfg.PrefixSCP;

        if (ev.Player.Role == RoleTypeId.ClassD)
            ev.Player.DisplayNickname = $"{cfg.PrefixDClass}-{rnd.Next(1000, 9999)}";

        if (ev.Player.Role == RoleTypeId.Scientist)
            ev.Player.DisplayNickname = $"{cfg.PrefixScientist} {cfg.Names[rnd.Next(0, cfg.Names.Count)]}";
      for (int i = 0; i < cfg.Names.Count; i++)
        {
            Log.Debug(cfg.Names[i]);
        }
    }
}
