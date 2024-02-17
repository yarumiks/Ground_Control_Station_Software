using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yer_istasyonu
{
    public class ChartDataView
    {
        public Point? prevPosition { get; set; }
        public ToolTip tooltip { get; set; }

        public ChartDataView()
        {
            prevPosition = null;
            tooltip = new ToolTip();
        }
    }
}
