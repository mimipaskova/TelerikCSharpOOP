using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery
    {
        public enum BatteryType
        {
            LiIon, NiMH, NiCd,
        }

        public string batteryModel;
        public int? batteryHoursIdle;
        public int? batteryHoursTalk;
        public BatteryType batteryType;

        public Battery()
        {

        }

        public Battery(string batteryModel, int batteryHoursIdle, int batteryHoursTalk, BatteryType batteryType)
        {
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
            this.batteryType = batteryType;
        }

        
        
    }
}
