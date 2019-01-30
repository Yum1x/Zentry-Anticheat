using System;
using ZentryAnticheat.Client.Controller;

namespace ZentryAnticheat.Client.Scans
{
    public class ScanEntitys
    {
        private ScanEnum _scan;
        
        public ScanEntitys(ScanEnum scan)
        {
            this._scan = scan;
        }


        public void Scan()
        {
            switch (_scan)
            {
                case ScanEnum.full:
                    new PropManager().propScan();
                    new PedManager().PedScan();
                    new VehicleManager().VehicleScan();
                    break;
                case ScanEnum.pedOnly:
                    new PedManager().PedScan();
                    break;
                case ScanEnum.PropOnly:
                    new PropManager().propScan();
                    break;
                case ScanEnum.VehicleOnly:
                    new VehicleManager().VehicleScan();
                    break;
                default:
                    break;
            }
        }
    }
}