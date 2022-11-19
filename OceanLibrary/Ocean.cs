using System;
using System.Threading;

namespace OceanLibrary
{
    public class Ocean : IOcean // головний клас океан
    {
        public Cell[,] _cells { get; set; } // масив ясіх клітин
        public int numObstacles { get; set; }
        public int numPreys { get; set; }
        public int numPredators { get; set; }
        public int numMainPredator { get; set; }
        public Coordinate mainPredatorCoord { get; set; } // координати головного хижака
        public int score { get; set; }
        public int rows { get; set; } 
        public int cols { get; set; }
        public int pickedSize { get; set; } // обраний користувачем розмір океану
        public int pickedCellBorderStyleIndex { get; set; } // обраний тип границь клітин

        public bool successfulInitialization { get; set; } = false; 
        // індикатор, вказує на успішність ініціалізації
        public bool successfulMainPredatorMove { get; set; } = false;
        // індикатор, вказує на успішність пересування головного хижака

        public Coordinate[] changedCellsCoord { get; set; }
        // масив з координатами змінених клітин. В подальшому, саме клітини
        // з координатами з цього масиву будуть промальовуватись. Це оптимізує
        // роботу програми, оскільки не треба промальовувати весь океан заново

        public int changedCellsIndex { get; set; } = 0; // кількість змінених клітин
        public bool isUniqueCell { get; set; } = true; // індикатор унікальності клітини
        public int timeToSpawnBonus { get; set; } 

        public IOutput output { get; set; } 
        // створення екземпляру інтерфейсу, через який буде вивід на екран
        public IInput input { get; set; }
        // створення екземпляру інтерфейсу, через який буде введення даних

        public enum Directions // enum з усіма напрямками пересування
        {
            Up,
            Down,
            Left,
            Right
        }


        public Ocean(IOutput output)
        {
            this.output = output;
        }

        public Ocean()
        {

        }

        public void SetOutput(IOutput output)
        {
            this.output = output;
        }

        public void SetInput(IInput input)
        {
            this.input = input;
        }

        public Cell this[int x, int y] // індексатор
        {
            get
            {
                return _cells[x, y];
            }
            set
            {
                _cells[x, y] = value;
            }
        }

        public void InitCells() // ініціалізація клітин в океані
        {
            EnterCells();
            AddCells();
        }

        public void SetDefaultOcean() // присвоєння стандартних значень океану
        {
            pickedSize = Constants.defaultPickedIndex;
            pickedCellBorderStyleIndex = Constants.defaultPickedCellBorderStyle;
            rows = Constants.defaultRows;
            cols = Constants.defaultCols;
            numPreys = Constants.defaultNumPreys;
            numPredators = Constants.defaultNumPredators;
            numMainPredator = Constants.defaultNumMainPredators;
            numObstacles = Constants.defaultNumObstacles;
            timeToSpawnBonus = Constants.timeToSpawnBonus;
        }

        public void CopyOceanDataFrom(Ocean oceanData) // копіювання основних даних океану 
        {
            pickedSize = oceanData.pickedSize;
            pickedCellBorderStyleIndex = oceanData.pickedCellBorderStyleIndex;
            rows = oceanData.rows;
            cols = oceanData.cols;
            numPreys = oceanData.numPreys;
            numPredators = oceanData.numPredators;
            numObstacles = oceanData.numObstacles;
            numMainPredator = oceanData.numMainPredator;
        }

        public void SetRows(int rows)
        {
            this.rows = rows;
        }

        public void SetCols(int cols)
        {
            this.cols = cols;
        }

        public void EnterCells() // введення клітин
        {
            try
            {
                input.EnterAll(this);
                
                timeToSpawnBonus = Constants.timeToSpawnBonus;
                successfulInitialization = true;
            }
            catch (WrongAmountInput e) // у разі некоретного вводу виведення повідомлення
            {
                output.ShowException(e.Message); 
                successfulInitialization = false;
                return;
            }
            catch (Exception ex)
            {
                output.ShowException(ex.Message);
                successfulInitialization = false;
                return;
            }
        }

        public void AddCells() // додавання клітин у пустий масив клітин
        {
            _cells = new Cell[rows, cols];
            changedCellsCoord = new Coordinate[rows * cols];
            timeToSpawnBonus = Constants.timeToSpawnBonus;
            AddEmptyCells(rows, cols);
            AddMainPredator();
            AddObstacles();
            AddPreys();
            AddPredators();
        }

        public void AddEmptyCells(int rows, int cols) // присвоєння всім клітинам значення null
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    _cells[i, j] = null;
                }
            }
        }

        public void AddMainPredator() // додавання головного хижака у масив
        {

            for (int i = 0; i < numMainPredator; i++)
            {
                Coordinate coord = new Coordinate();
                coord = Rand.GetRandomCoordinate(rows, cols); // отримання випадкових координат

                if (_cells[coord.X, coord.Y] == null) // перевірка на те, що клітина порожня
                {
                    _cells[coord.X, coord.Y] = new MainPredator(this, coord.X, coord.Y);
                }
                else i--; // якщо клітина не була порожнюю, то цикл буде проходити ітерації
                          // поки не знайде пусту клітину
                mainPredatorCoord = coord; 
            }
            
        }

        public void AddPreys() // створення здобичей у масиві
        {
            for (int i = 0; i < numPreys; i++)
            {
                Coordinate coord = new Coordinate();
                coord = Rand.GetRandomCoordinate(rows, cols); // отримання випадкових координат

                if (_cells[coord.X, coord.Y] == null) // перевірка на те, що клітина порожня
                {
                    _cells[coord.X, coord.Y] = new Prey(this, coord.X, coord.Y);
                }
                else i--;// якщо клітина не була порожнюю, то цикл буде проходити ітерації
                         // поки не знайде пусту клітину
            }
        }

        public void AddPredators()
        {

            for (int i = 0; i < numPredators; i++)
            {
                Coordinate coord = new Coordinate();
                coord = Rand.GetRandomCoordinate(rows, cols);  // отримання випадкових координат

                if (_cells[coord.X, coord.Y] == null) // перевірка на те, що клітина порожня
                {
                    _cells[coord.X, coord.Y] = new Predator(this, coord.X, coord.Y);

                }
                else i--; // якщо клітина не була порожнюю, то цикл буде проходити ітерації
                          // поки не знайде пусту клітину
            }
        }

        public void AddObstacles()
        {
            for (int i = 0; i < numObstacles; i++)
            {
                Coordinate coord = new Coordinate();
                coord = Rand.GetRandomCoordinate(rows, cols); // отримання випадкових координат

                if (_cells[coord.X, coord.Y] == null) // перевірка на те, що клітина порожня
                {
                    _cells[coord.X, coord.Y] = new Obstacle(this, coord.X, coord.Y);
                }
                else i--; // якщо клітина не була порожнюю, то цикл буде проходити ітерації
                          // поки не знайде пусту клітину
            }
        }

        public void AddChangedCellsCoord(Coordinate coord) // додавання зміненої клітинки у масив
        {
            for (int i = 0; i < changedCellsIndex; i++)
            {
                if (changedCellsCoord[i].X == coord.X && changedCellsCoord[i].Y == coord.Y)
                    // якщо у масиві вже є клітина з такими координатами, то вона не унікальна,
                    // тому і не буде додаватись у масив
                {
                    isUniqueCell = false;
                    break;
                }
            }

            if (isUniqueCell) // якщо клітина унікальна, вона додається до масиву
            {
                changedCellsCoord[changedCellsIndex] = coord;
                changedCellsIndex++; // збільшення кількості змінених клітин 
            }

            isUniqueCell = true;
        }

        public void ClearChangedCellsArr() // очищення масиву зі зміненими клітинами
        {
            for (int i = 0; i < changedCellsCoord.Length; i++)
            {
                changedCellsCoord[i] = null;
            }
            changedCellsIndex = 0;
        }

        public void Iteration() // ітерація, тобто дія, під час якої кожна клітина виконує
                                // свою унікальну поведінку
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (_cells[i, j] == null || _cells[i, j].GetType() == typeof(Bonus)
                        || _cells[i, j].GetType() == typeof(Obstacle))
                        // цикл переходе до наступної ітерації, оскільки пуста клітина,
                        // бонус або перешкода не мають якоїсь поведінки
                    {
                        continue;
                    }

                    switch (_cells[i, j].GetImage())
                    {
                        case Constants.defaultPredatorImage:
                            if (_cells[i, j].isMoved == false)
                                // якщо клітина є хижак та він ще не пересувався,
                                // виконується процес для хижака
                            {
                                _cells[i, j].ProcessForPredator();
                            }

                            break;
                        case Constants.defaultPreyImage:
                            if (_cells[i, j].isMoved == false)
                                // якщо клітина є здобич та вона ще не пересувалася,
                                // виконується процес для здобичи
                            {
                                _cells[i, j].ProcessForPrey();
                            }

                            break;
                        default:
                            break;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (_cells[i, j] != null)
                        // присвоєння всім клітинам масиву значення,
                        // що вони не пересувались
                    {
                        _cells[i, j].isMoved = false;
                    }
                }
            }

            timeToSpawnBonus--;

            if (timeToSpawnBonus <= 0 && !isFull())
            // якщо повинен з'явитись бонус та океан не заповнений 
            // повністью, бонус з'являється
            {
                SpawnBonus();
                timeToSpawnBonus = Constants.timeToSpawnBonus;
            }

            output.Print(this); // виведення океану на екран
            ClearChangedCellsArr(); // очищення масиву зі зміненими клітинами
        }

        public void MoveMainPredator(Directions direction) // пересування головного хижака
        {
            _cells[mainPredatorCoord.X, mainPredatorCoord.Y].ProcessForMainPredator(direction);
        }

        public bool isFull() // метод, який перевіряє чи є океан повністю заповненим
                             // та повертає відповідне значення
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (_cells[i, j] == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void SpawnBonus() // створення бонусу
        {
            Coordinate coord = new Coordinate();
            for (int i = 0; i < 1; i++)
            {
                coord = Rand.GetRandomCoordinate(rows, cols); // отримання випадкових координат

                if (_cells[coord.X, coord.Y] == null) // перевірка на те, що клітина порожня
                {
                    _cells[coord.X, coord.Y] = new Bonus(this, coord.X, coord.Y);
                }
                else i--; // якщо клітина не була порожнюю, то цикл буде проходити ітерації
                          // поки не знайде пусту клітину
            }
            AddChangedCellsCoord(new Coordinate(coord)); // додавання координат до масиву змінених клітин
        }
    }

}
