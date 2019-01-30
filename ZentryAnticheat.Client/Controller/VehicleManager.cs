using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ZentryAnticheat.Client.Controller
{
    public class VehicleManager
    {
            
        private int[] vehicleIdInterzise = new int[95]
        {
-2137348917, //Phantom
1653666139, //Pounder2
-1988428699, //Terbyte
628003514, //Issi4
1537277726, //Issi5
1239571361, //Issi6
-1600252419, //Valkyrie
1543134283, //Valkyrie2
-82626025, //Savage
-42959138, //Hunter
788747387, //Buzzard
837858166, //Annihilator
1181327175, //Akula
456714581, //PoliceT
-1779120616, //PoliceOld2
-1973172295, //Police4
-1693015116, //Riot2
741586030, //Pranger
1938952078, //FireTruk
-2007026063, //PBus
1945374990, //Mule4
569305213, //Packer
-2137348917, //Phantom
387748548, //Hauler2
1518533038, //Hauler
1909700336, //Cerberus3
679453769, //Cerberus2
//3493417227, //Cerberus
562680400, // APC
-692292317, // Chernobog
-32236122, // Halftrack
-1435527158, // Khanjali
782665360, // Rhino
//3147997943, // Scarab
1542143200, // Scarab2
//3715219435, // Scarab3
1489874736, // Thruster
-1881846085, // Trailersmall2
//4267640610, //Deathbike
//2482017624, //Deathbike2
//2920466844, //Deathbike3
//2728360112, //Clique
1279262537, //Deviant
//3606777648, //Dominator4
//2919906639, //Dominator5
//3001042683, //Dominator6
-326143852, //Dukes2
//2198276962, //Impaler
1009171724, //Impaler2
//2370166601, //Impaler3
//2550461639, //Impaler4
444994115, //Imperator
1637620610, //Imperator2
//3539435063, //Imperator3
//2233918197, //SlamVan4
373261600, //SlamVan5
1742022738, //SlamVan6
1456744817, //Tulip
-1210451983, //Tampa3
-1661854193, //Dune
534258863, //Dune2
1897744184, //Dune3
-827162039, //Dune4
-312295511, //Dune5
-1860900134, //Insurgent
2071877360, //Insurgent2
-1924433270, //Insurgent3
1233534620, //Marshall
-845961253, //Monster
1721676810, //Monster3
840387324, //Monster4
1561036517, //Monster5
433954513, //Nightshark
2044532910, //Menacer
-2096818938, //Technical
1356124575, //Technical3
-1523619738, //AlphaZ1
-2118308144, //Avenger
408970549, //Avenger2
-150975354, //Blimp1
-613725916, //Blimp2
-307958377, //Blimp3
-32878452, //Bombushka
368211810, //CargoPlane
-644710429, //Cuban800
970385471, //Hydra
-1281684762, //Lazer
-749299473, //Mogul
1565978651, //Molotok
1036591958, //Nokota
-1386191424, //Pyro
-975345305, //Rogue
-392675425, //Seabreeze
-1700874274, //Starling
-2122757008, //Stunt
198168853, //Titan
447548909, //Velatol
1692272545, //StrikeForce
-713569950, //Bus
-1912017790, //Wastlndr
-674927303, //Raptor
//3787471536, //Schlagen
540101442, //Zr380
//3188846534, //Zr3802
//2816263004, //Zr3803
159274291, // Ardent
1483171323, //Deluxo
886810209, //Stromberg
-391595372, //Viseris
-1207431159, //ArmyTanker
682434785, //BoxVille5
903794909, //Savestra
1561920505 //Comet4
            
        };
        
        public void VehicleScan()
        {
            foreach (Vehicle allVehicle in World.GetAllVehicles())
            {
                int entityModel = API.GetEntityModel(allVehicle.Handle);
                if (API.DoesEntityExist(allVehicle.Handle))
                {
                    if (((IEnumerable<int>) this.vehicleIdInterzise).Contains<int>(entityModel))
                    {
                        allVehicle.Delete();
                    }
                }
            }
            
        }
    }
}