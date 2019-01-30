using System.Collections.Generic;
using System.Linq;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ZentryAnticheat.Client.Controller
{
    public class PedManager : BaseScript
    {
        private int[] pedIdInterzise = new int[10]
        {
            451459928,
            882848737,
            351016938,
            307287994,
            1684083350,
            880829941,
            1096929346,
            1794449327,
            -1404353274,
            2109968527
        };


        public void PedScan()
        {
            foreach (Ped allPed in World.GetAllPeds())
            {
                int entityModel = API.GetEntityModel(allPed.Handle);
                int selectedPedWeapon = API.GetSelectedPedWeapon(allPed.Handle);
                if (API.DoesEntityExist(allPed.Handle))
                {
                    if (selectedPedWeapon == -1312131151 || selectedPedWeapon ==
                        -2084633992)
                        allPed.Delete();
                    else if (((IEnumerable<int>) this.pedIdInterzise).Contains<int>(entityModel))
                        allPed.Delete();
                }
            }

        }
    }
}