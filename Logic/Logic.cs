﻿namespace Logic
{
    public enum Desk {
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

        public bool DetermineHit(string tileID)
        {


            return true;
        }

        public void PlaceDesksAI()
        {

        }

        public void PlaceUserDesk()
        {

        }

        public void ResetBoards()
        {
            grid = new int[boardRowSize, boardColSize];
        }
    }
}