using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ItemLockers
{
    public class Plugin : Qurre.Plugin
    {
        public EventHandlers EventHandlers;
        public override int Priority { get; } = -9999999;
        public override string Developer { get; } = "G-Man";
        public override string Name { get; } = "ItemLockers";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version NeededQurreVersion { get; } = new Version(1, 11, 1);
        public Config config;

        public override void Enable()
        {
            config = new Config();
            CustomConfigs.Add(config);
            EventHandlers = new EventHandlers(this);
            Qurre.Events.Round.Start += EventHandlers.OnStartRound;
            Qurre.Log.Custom("\n██╗████████╗███████╗███╗░░░███╗██╗░░░░░░█████╗░░█████╗░██╗░░██╗███████╗██████╗░░██████╗\n██║╚══██╔══╝██╔════╝████╗░████║██║░░░░░██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗██╔════╝\n██║░░░██║░░░█████╗░░██╔████╔██║██║░░░░░██║░░██║██║░░╚═╝█████═╝░█████╗░░██████╔╝╚█████╗░\n██║░░░██║░░░██╔══╝░░██║╚██╔╝██║██║░░░░░██║░░██║██║░░██╗██╔═██╗░██╔══╝░░██╔══██╗░╚═══██\n██║░░░██║░░░███████╗██║░╚═╝░██║███████╗╚█████╔╝╚█████╔╝██║░╚██╗███████╗██║░░██║██████╔╝\n╚═╝░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░", "", ConsoleColor.Red);
            Qurre.Log.Custom("♥ Thanks for using ItemLockers ♥", "", ConsoleColor.Red);
        }
        public override void Disable()
        {
            Qurre.Events.Round.Start -= EventHandlers.OnStartRound;
        }
    }
}
