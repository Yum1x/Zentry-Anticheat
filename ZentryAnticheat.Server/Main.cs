using System;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace ZentryAnticheat.Server
{
    public class Main : BaseScript
    {
        private DateTime _lastAdvTime;
        
        private string adv =
            "================================================================\n \n \n THIS RESOURCE WAS CREATED BY ZENTRY ACADEMY\n ESSE RECURSO FOI CRIADO PELA ZENTRY ACADEMY\n \n DONT BUY THIS FROM ANYONE, IF YOU BUYED ASK FOR REFUND RIGHT NOW\n \n NAO COMPRE ESTE RECURSO DE NINGUEM, CASO TENHA COMPRADO, PECA O REEMBOLSO\n \n Version: 0.9.5 Pre-Release | Beta\n================================================================";
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
            if (_lastAdvTime.Ticks + 6000000000 <= DateTime.UtcNow.Ticks)
            {
                Debug.WriteLine(adv);
                _lastAdvTime = DateTime.UtcNow;
            }
        }
    }
}