using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

public class EventHandlers : Plugin<Config>
{
    private Random rnd = new Random();

    public void OnSpawning(SpawningEventArgs ev)
    {
        if (!ev.Player.IsConnected) return;
        if (ev.Player.Role == RoleTypeId.None ||
            ev.Player.Role == RoleTypeId.Spectator ||
            ev.Player.Role == RoleTypeId.Filmmaker ||
            ev.Player.Role == RoleTypeId.CustomRole ||
            ev.Player.Role == RoleTypeId.Overwatch)
                ev.Player.DisplayNickname = null;

        if (ev.Player.IsCHI)
            ev.Player.DisplayNickname = $"{Config.PrefixHAOS} {Config.Names[rnd.Next(0, Config.Names.Count)]}";

        if (ev.Player.IsNTF)
            ev.Player.DisplayNickname = $"{Config.PrefixMOG} {Config.Names[rnd.Next(0, Config.Names.Count)]}";

        if (ev.Player.Role == RoleTypeId.FacilityGuard)
            ev.Player.DisplayNickname = $"{Config.PrefixSecurity} {Config.Names[rnd.Next(0, Config.Names.Count)]}";

        if (ev.Player.IsScp)
            ev.Player.DisplayNickname = Config.PrefixSCP;

        if (ev.Player.Role == RoleTypeId.ClassD)
            ev.Player.DisplayNickname = $"{Config.PrefixDClass}-{rnd.Next(1000, 9999)}";

        if (ev.Player.Role == RoleTypeId.Scientist)
            ev.Player.DisplayNickname = $"{Config.PrefixScientist} {Config.Names[rnd.Next(0, Config.Names.Count)]}";
    }
}
