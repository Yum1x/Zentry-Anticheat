using System;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace ZentryAnticheat.Server
{
    public class Main : BaseScript
    {
        private DateTime _lastAdvTime;
        
        private string adv =
            "================================================================\n \n \n \n \n \n \n \n \n \n \n THIS RESOURCE WAS CREATED BY ZENTRY ACADEMY\n ESSE RECURSO FOI CRIADO PELA ZENTRY ACADEMY\n \n DONT BUY THIS FROM ANYONE, IF YOU BUYED ASK FOR REFUND RIGHT NOW\n \n NAO COMPRE ESTE RECURSO DE NINGUEM, CASO TENHA COMPRADO, PECA O REEMBOLSO\n JOIN US DISCORD:https://discord.gg/MZkcKAU\n ENTRE EM NOSSO DISCORD: https://discord.gg/MZkcKAU \n \n \n \n \n \n \n \n \n \n Version: 0.9.4 Pre-Release | Beta Acess\n================================================================";
        public Main()
        {
            Debug.WriteLine(adv);
            _lastAdvTime = DateTime.UtcNow;
            this.Tick += new Func<Task>(this.OnTick);
        }

        private async Task OnTick()
        {
            BaseScript.TriggerClientEvent("scanEntitys");
            await BaseScript.Delay(500);
            if (_lastAdvTime.Ticks + 1200000000 <= DateTime.UtcNow.Ticks)
            {
                Debug.WriteLine(adv);
                _lastAdvTime = DateTime.UtcNow;
            }
        }
    }
}