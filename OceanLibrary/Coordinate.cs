namespace OceanLibrary
{
    public class Coordinate // клас координат
    {
        public int X;
        public int Y;

        public Coordinate()
        {
            X = 0;
            Y = 0;
        }

        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Coordinate(Coordinate coord)
        {
            X = coord.X;
            Y = coord.Y;
        }


    }
}
