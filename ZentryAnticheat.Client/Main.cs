using System;
using System.Diagnostics;
using System.Threading.Tasks;
using CitizenFX.Core;
using ZentryAnticheat.Client.Controller;
using ZentryAnticheat.Client.Scans;

namespace ZentryAnticheat.Client
{
    class Main : BaseScript
    {
        public Main()
        {
            this.EventHandlers.Add("scanEntitys", (Delegate) new Action(new ScanEntitys(ScanEnum.full).Scan));
            
        }

    }
}