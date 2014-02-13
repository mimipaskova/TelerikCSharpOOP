using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        Display display;
        Battery battery;

        public string model;
        public string manufacturer;
        public int? price;
        public string owner;
       
        public GSM()
        {
            display = new Display();
            battery = new Battery();
        }

        public GSM(string model, string manufacturer, int size, int numColours, string batteryModel, int batteryHoursIdle, 
            int batteryHoursTalk, Battery.BatteryType batteryType  )
        {

            this.model = model;
            this.manufacturer = manufacturer;
            display = new Display(size, numColours);
            battery = new Battery(batteryModel, batteryHoursIdle, batteryHoursTalk, batteryType);
        }

        public GSM(string model, string manufacturer, int price, string owner, int size, int numColours, string batteryModel, int batteryHoursIdle,
            int batteryHoursTalk, Battery.BatteryType batteryType)
            : this(model, manufacturer, size, numColours, batteryModel, batteryHoursIdle, batteryHoursTalk, batteryType)
        {   
            this.price = price;
            this.owner = owner;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("model: " + this.model + '\n' + "manifacturer: " + this.manufacturer + '\n');

            if (this.price != null)
            {
                sb.Append("price: " + this.price + "lv" + '\n');
            }
            if (this.owner != null)
            {
                sb.Append("owner: " + this.owner + '\n');
            }
            if (this.battery.batteryModel != null)
            {
                sb.Append("battery model: " + this.battery.batteryModel + '\n');
            }
            if (this.battery.batteryType != null)
            {
                sb.Append("battery type: " + this.battery.batteryType + '\n');
            }
            if (this.battery.batteryHoursIdle != null)
            {
                sb.Append("hours idle: " + this.battery.batteryHoursIdle + '\n');
            }
            if (this.battery.batteryHoursTalk != null)
            {
                sb.Append("hours talk: " + this.battery.batteryHoursTalk + '\n');
            }
            if (this.display.displaySize != null)
            {
                sb.Append("display size: " + this.display.displaySize + "cm" + '\n');
            }
           
            if (this.display.displayColors != null)
            {
                sb.Append("number of colors: " + this.display.displayColors + '\n');
            }

            return sb.ToString();
        }
    }
}
