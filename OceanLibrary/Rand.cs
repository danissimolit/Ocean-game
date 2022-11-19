using System;

namespace OceanLibrary
{
    public class Rand // клас рандому, призначений для генерації випадкових чисел
    {
        public static Random random = new Random();
        public static Coordinate GetRandomCoordinate(int maxX, int maxY)
            // метод, який повертає випадкові координати 
        {
            Coordinate coord = new Coordinate();
            coord.X = random.Next(0, maxX);
            coord.Y = random.Next(0, maxY);
            return coord;
        }

        public static int GetRandomIndex(int maxIndex)
            // метод, який повертає випадковий індекс
        {
            return random.Next(0, maxIndex);
        }
    }
}
