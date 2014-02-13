using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        public int? displaySize;
        public int? displayColors;

        public Display()
        {

        }

        public Display(int displaySize, int displayColors)
        {
            this.displaySize = displaySize;
            this.displayColors = displayColors;
        }

    }
}
