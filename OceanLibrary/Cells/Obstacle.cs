namespace OceanLibrary
{
    public class Obstacle : Cell // клас перешкоди. Не може пересуватись, розмножуватись або вмирати,
                                 // лише стоїть на місці
    {
        public Obstacle(Ocean owner, int X, int Y) : base(owner, X, Y)
        {
            image = Constants.defaultObstacleImage;
        }
    }
}
