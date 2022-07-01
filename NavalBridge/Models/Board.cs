namespace NavalBridge.Models
{
    public class BoardViewModel
    {
        private readonly Logic.Logic _logic;

        public BoardViewModel(Logic.Logic logic, int boardSize)
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

            GridItems = gridItemList;
            _logic = logic;
        }

        public IEnumerable<GridItem> GridItems { get; set; }

        public ActionState SetHit(char gridRow, int gridColumn)
        {
            try
            {
                var grid = GetGridItem(gridRow, gridColumn);

                // Publish hit to backend and get whether or not hit value is true
                grid.SetHit(_logic.DetermineHit($"{gridRow}{gridColumn}"));

                return new ActionState() { Success = true };
            }
            catch (Exception ex)
            {
                var errorList = new List<string>
                {
                    $"{ex.Message}"
                };

                return new ActionState() { Success = false, Errors = errorList };
            }
        }

        public void SyncroniseHitState(GridItem gridItem)
        {
            var existingGridItem = GetGridItem(gridItem.GridRow, gridItem.GridColumn);
            if (existingGridItem.Hit != gridItem.Hit)
            {
                existingGridItem.SetHit(gridItem.Hit);
            }
        }

        public void RefreshHitStates()
        {
            // TODO: Get some hit states server side (perhaps we standardise the grid item model)
            var gridItemList = new List<GridItem>();

            foreach (var gridItem in gridItemList)
            {
                SyncroniseHitState(gridItem);
            }
        }

        private GridItem GetGridItem(char gridRow, int gridColumn)
        {
            var grid = GridItems.Where(x => (x.GridRow == gridRow) && (x.GridColumn == gridColumn)).FirstOrDefault();

            if (grid != null)
            {
                return grid;
            }

            throw new ArgumentOutOfRangeException($"Grid item '{gridRow}{gridColumn}' does not exist within the grid!");
        }
    }
}