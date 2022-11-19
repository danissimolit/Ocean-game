namespace OceanLibrary
{
    public struct Constants // структура з константами
    {
        public const int numOceanSizes = 3; // кількість розмірів океану
        public const int defaultPickedIndex = 1; // стандартно обраний розмір океану

        // усі масиви мають по трі змінні- кожна змінна для певного розміру океану
        public static readonly int[] defaultRowsArr = new int[numOceanSizes] { 7, 10, 15 };  // масив з рядками океану
        public static readonly int[] defaultColsArr = new int[numOceanSizes] { 12, 15, 20 }; // масив з колонками океану
                                                               
        // масиви зі стандартними значеннями параметрів
        public static readonly int[] defaultPreysArr = new int[numOceanSizes] { 10, 30, 70 }; // масив з кількостью здобичи
        public static readonly int[] defaultPredatorsArr = new int[numOceanSizes] { 1, 2, 5 }; // масив з кількостью хижаків
        public static readonly int[] defaultObstaclesArr = new int[numOceanSizes] { 7, 15, 30 }; // масив з кількостью перешкод

        // масиви з максимальними кількостями кожного параметру
        public static readonly int[] maxPreysArr = new int[numOceanSizes] { 25, 50, 170 }; 
        public static readonly int[] maxPredatorsArr = new int[numOceanSizes] { 15, 30, 60 };
        public static readonly int[] maxObstaclesArr = new int[numOceanSizes] { 25, 50, 170 };

        public static readonly string[] cellBorderStylesText = new string[] { "None", "Slim", "Wide" }; // типи границь клітин
        public static readonly int[] cellBorderStylesIndex = new int[] { 0, 1, 3 }; // типи границь клітин за індексами
        public const int defaultPickedCellBorderStyle = 0; // стандартно обраний тип границі 

        // додавання до розміру окна з океаном
        public const int oceanFormWidthAddition = 90; 
        public const int oceanFormHeightAddition = 200;

        public static readonly int[] cellSize = new int[numOceanSizes] { 60, 50, 40}; // розміри клітин

        // стандартні значення параметрів
        public static readonly int defaultRows = defaultRowsArr[defaultPickedIndex];
        public static readonly int defaultCols = defaultColsArr[defaultPickedIndex];
        public static readonly int defaultNumMainPredators = 1;
        public static readonly int defaultNumPreys = defaultPreysArr[defaultPickedIndex];
        public static readonly int defaultNumPredators = defaultPredatorsArr[defaultPickedIndex];
        public static readonly int defaultNumObstacles = defaultObstaclesArr[defaultPickedIndex];

        // відповідні символи для кожного класу
        public const char defaultImage = '-';
        public const char defaultMainPredatorImage = 'S';
        public const char defaultPredatorImage = 'P';
        public const char defaultPreyImage = 'f';
        public const char defaultObstacleImage = '#';
        public const char defaultBonusImage = '@';

        // параметри ситості, розмноження та появи бонусу
        public const int timeToFeed = 4;
        public const int timeToFeedMainPredator = 10;
        public const int timeToReproduce = 6;
        public const int timeToSpawnBonus = 16;
        public const int BonusTimeToEatForPredator = 20;

        // кількість очок за відповідну дію
        public const int scoreMove = 5;
        public const int scoreReproduce = 10;
        public const int scoreEatPrey = 20;
        public const int scoreEatBonus = 40;

        // відступ вікна налаштувань
        public static readonly Coordinate settingsWindowOffset = new Coordinate(50, 35);
    }
}
