using System;
using System.Collections.Generic;
using Exiled.API.Interfaces;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;

    public bool Debug { get; set; } = true;

    public List<string> Names { get; set; } = new List<string>
    {
        "Робби",
        "Автор"
    };

    public string PrefixSecurity { get; set; } = "СБ";

    public string PrefixMOG { get; set; } = "МОГ";

    public string PrefixHAOS { get; set; } = "ПХ";

    public string PrefixDClass { get; set; } = "Д";

    public string PrefixScientist { get; set; } = "Ученный";

    public string PrefixSCP { get; set; } = "Объект";
}