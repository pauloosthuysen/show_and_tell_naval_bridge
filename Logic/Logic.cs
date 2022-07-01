namespace Logic
{
    public enum Desk
    {
        Desk1,
        Desk2,
        Desk3,
        Desk4,
        Desk5,
    }

    public class Logic
    {
        public const int boardRowSize = 10;
        public const int boardColSize = 10;
        public int[,] grid = new int[boardRowSize, boardColSize];

        public Dictionary<Desk, int> deskSizes = new()
        {
            { Desk.Desk1, 2 },
            { Desk.Desk2, 3 },
            { Desk.Desk3, 4 },
            { Desk.Desk4, 5 },
            { Desk.Desk5, 6 },
        };

        public bool DetermineHit(int xCoordinates, int yCoordinates)
        {


            return true;
        }

        public void PlaceDesksAI()
        {
            Random rand = new Random();
            bool verticle = rand.NextDouble() > 0.5;

            //Determines placement verticle / horizontal
        }

        public void PlaceUserDesk()
        {

        }

        public void ResetBoards()
        {
            grid = new int[boardRowSize, boardColSize];
        }

        /// <summary>
        /// Gets the coords from the tile ID e.g. A1 -> (0,0); B4 -> (1, 3)
        /// </summary>
        /// <param name="tileID"></param>
        /// <returns></returns>
        public DeskCoord MapFromTile(string tileID)
        {
            var data = "ABCDEFGHIJ";
            var xId = tileID[0].ToString().ToUpper();
            var x = data.IndexOf(xId);
            var y = Int32.Parse(tileID[1].ToString()) - 1;
            return new DeskCoord { X = x, Y = y };
        }
    }
}