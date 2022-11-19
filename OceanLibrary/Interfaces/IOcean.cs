namespace OceanLibrary
{
    interface IOcean // інтерфейс океану
    {
        public Cell[,] _cells { get; set; }
        public int numObstacles { get; set; }
        public int numPreys { get; set; }
        public int numPredators { get; set; }
        public int numMainPredator { get; set; }
        public Coordinate mainPredatorCoord { get; set; }
        public int rows { get; set; }
        public int cols { get; set; }
        public int pickedSize { get; set; }
        public int score { get; set; }

        public void InitCells();

        public void AddEmptyCells(int rows, int cols);

        public void AddPreys();

        public void AddPredators();

        public void AddMainPredator();

        public void AddObstacles();

        public void Iteration();

    }
}
