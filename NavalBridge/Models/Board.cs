namespace NavalBridge.Models
{
    public class BoardViewModel
    {
        public BoardViewModel(int boardSize)
        {
            var gridItemList = new List<GridItem>();

            char startChar = 'A';
            for (int i = 1; i <= boardSize; i++)
            {
                for (int j = 1; j <= boardSize; j++)
                {
                    gridItemList.Add(new GridItem(startChar, j));
                }
                startChar++;

            }
        }

        public IEnumerable<GridItem> GridItems { get; set; }

        protected void SetHit(char gridRow, int gridColumn)
        {
            var grid = GridItems.Where(x => (x.GridRow == gridRow) && (x.GridColumn == gridColumn)).FirstOrDefault();

            if (grid != null)
            {
                // Publish hit to backend and get whether or not hit value is true
            }

            // Maybe error if grid is out of range?
        }
    }

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
    }
}
