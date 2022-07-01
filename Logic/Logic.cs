using System;

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
        public const int boardRowSize = 5;
        public const int boardColSize = 5;
        public int[,] grid = new int[boardRowSize, boardColSize];
        public Dictionary<Desk, int> deskSizes = new()
        {
            { Desk.Desk1, 1 },
            { Desk.Desk2, 1 },
            { Desk.Desk3, 1 },
            { Desk.Desk4, 1 },
            { Desk.Desk5, 1 },
        };

        public void Setup()
        {
            // blank grid

            // place AI chairs (obfuscated on the FE)


        }

        public int tries = 0;

        public static string RandomCoordinate(int? length)
        {
            if (length == null)
            {
                length = 5;
            }

            Random random = new Random();
            const string chars = "ABCDE"; //FGHIJKLMNOPQRSTUVWXYZ
            const string numbers = "01234"; //56789
            var output1 = new string(Enumerable.Repeat(chars, length.Value).Select(s => s[random.Next(s.Length)]).ToArray());
            var output2 = new string(Enumerable.Repeat(numbers, length.Value).Select(s => s[random.Next(s.Length)]).ToArray());

            return String.Empty;//output1 + output2;
        }

        public bool DetermineHit(string tileID)
        {
            var coord = MapFromTile(tileID);
            return DetermineHit(coord.X, coord.Y);
        }

        public bool DetermineHit(int xCoordinates, int yCoordinates)
        {


            return true;
        }

        public bool PlaceUserDesk(char row, int column)
        {
            var coord = MapFromTile($"{row}{column}");
            if (grid[coord.X, coord.Y] == 0)
            {
                grid[coord.X, coord.Y] = 1;
                return true;
            }
            tries++;
            return false;
        }


        public void PlaceDesksAI()
        {

            var i = 0;
            while (true)
            {
                var rand = new Random();
                var letter = GetLetter();
                var number = rand.NextInt64(0, 4);
                if (grid[letter, number] == 0)
                {
                    i++;
                    grid[letter, number] = 1;
                }
                if (i == 5) break;
            }
        }

        public static char GetLetter()
        {
            Random rand = new Random();
            int num = rand.Next(0, 5);
            char let = (char)('a' + num);
            return let;
        }

        public void ResetBoards()
        {
            tries = 0;
            grid = new int[boardRowSize, boardColSize];
        }

        /// <summary>
        /// Gets the coords from the tile ID e.g. A1 -> (0,0); B4 -> (1, 3)
        /// </summary>
        /// <param name="tileID"></param>
        /// <returns></returns>
        public Coordinate MapFromTile(string tileID)
        {
            if (tileID == null 
                    || tileID.Length != 2 
                    || !Char.IsLetter(tileID[0]) 
                    || !char.IsNumber(tileID[1]))
            {
                throw new Exception($"Invalid tileID {tileID}. Expected e.g. 'A3'");
            }
            var data = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var xId = tileID[0].ToString().ToUpper();
            var x = data.IndexOf(xId);
            var y = Int32.Parse(tileID[1].ToString()) - 1;
            return new Coordinate(x, y);
        }
    }
}