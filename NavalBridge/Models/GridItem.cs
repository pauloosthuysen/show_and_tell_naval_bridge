using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBridge.Models
{
    public class GridItem
    {
        public GridItem(char gridRow, int gridColumn)
        {
            GridRow = gridRow;
            GridColumn = gridColumn;
        }

        public char GridRow { get; set; }
        public int GridColumn { get; set; }
        public bool? Hit { get; set; }

        public void SetHit(bool? hitState)
        {
            Hit = hitState;
        }
    }
}
