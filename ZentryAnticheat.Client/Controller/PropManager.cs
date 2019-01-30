using System.Collections.Generic;
using System.Linq;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ZentryAnticheat.Client.Controller
{
    public class PropManager
    {
        
        private int[] objIdInterzise = new int[54]
        {
            -1298203218,
            970385471,
            -553616286,
            243282660,
            -1968824367,
            1109266474,
            779917859,
            -1147467348,
            2108146567,
            2064886860,
            -1354005816,
            -1268267712,
            -234152995,
            -234152995,
            568309711,
            1888301071,
            323971301,
            2124719729,
            -1003748966,
            -1639085878,
            289396019,
            -131025346,
            148511758,
            -1065766299,
            14103519,
            -1295299286,
            1208606316,
            -468144679,
            -1645730886,
            -1236638811,
            1372198431,
            -717890986,
            1714199852,
            1737474779,
            -1027860019,
            -1507470892,
            -1775547488,
            932490441,
            1088428993,
            -543669801,
            1803116220,
            -1240857364,
            -1011638209,
            118627012,
            1952396163,
            267881419,
            -1288515433,
            1623304263,
            1426534598,
            -1991361770,
            322248450,
            1338692320,
            2012223962,
            1945457558
        };

        public void propScan()
        {
            
            foreach (Entity allProp in World.GetAllProps())
                
            {
                int entityModel = API.GetEntityModel(allProp.Handle);
                if (API.DoesEntityExist(allProp.Handle) &&
                    ((IEnumerable<int>) this.objIdInterzise).Contains<int>(entityModel))
                    allProp.Delete();
            }
        }
    }
}