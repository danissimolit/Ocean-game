namespace OceanLibrary
{
    public class MainPredator : Predator // клас головного хижака синьої акули, якою керує користувач
    {
        public bool isBonusMealOn = false; // зміна-індикатор бонусу від поїдання черв'яка

        public MainPredator(Ocean owner, int X, int Y) : base(owner, X, Y)
        {
            image = Constants.defaultMainPredatorImage;
            timeToEat = Constants.timeToFeedMainPredator;
        }

        public override void ProcessForMainPredator(Ocean.Directions direction)
        {
            Cell newCell = null;
            Coordinate newCoord = null;
             
            switch ((int)direction)
                // в залежності від обраного користувачем напрямку, обирається клітина
            {
                case 0:
                    newCell = _owner._cells[coord.X, coord.Y].NorthCell();
                    newCoord = _owner._cells[coord.X, coord.Y].NorthCellCoord();
                    break;
                case 1:
                    newCell = _owner._cells[coord.X, coord.Y].SouthCell();
                    newCoord = _owner._cells[coord.X, coord.Y].SouthCellCoord();
                    break;
                case 2:
                    newCell = _owner._cells[coord.X, coord.Y].WestCell();
                    newCoord = _owner._cells[coord.X, coord.Y].WestCellCoord();
                    break;
                case 3:
                    newCell = _owner._cells[coord.X, coord.Y].EastCell();
                    newCoord = _owner._cells[coord.X, coord.Y].EastCellCoord();
                    break;
                default:
                    break;
            }

            if (newCell == null 
                || newCell.GetType() == typeof(Prey)
                || newCell.GetType() == typeof(Bonus))
                // якщо обрана клітина це путса клітина, здобич або бонус
                // пересування головного хижака успішне
            {
                _owner.successfulMainPredatorMove = true;
            }
            else
            // якщо обраною клітиною виявився інший хижак або перешкода,
            // пересування неуспішне
            {
                _owner.successfulMainPredatorMove = false;
                return;
            }

            timeToEat--;

            if (timeToEat <= Constants.timeToFeedMainPredator)
            // перевірка на кінець дії бонуса від черв'яка, який дає ситість 20
            {
                isBonusMealOn = false;
                _owner.AddChangedCellsCoord(new Coordinate(coord));
            }

            if (timeToReproduce <= 0)
            {
                if (newCell == null)
                {
                    Reproduce(newCoord); // розмноження у пусту клітину
                }
                else if (newCell.GetType() == typeof(Bonus))
                {
                    Reproduce(newCoord); // розмноження з поїданням бонусу
                    BonusEffect(); // активація бонусного ефекту
                }
                else if (newCell.GetType() == typeof(Prey))
                {
                    Reproduce(newCoord); // розмноження з поїданням здобичи
                    ChangeTimeToEat(); // оновлення ситості
                }
            }
            else if (newCell == null)
            {
                Move(newCoord); // пересування на вільну клітину
                _owner.score += Constants.scoreMove; // додавання очок за пересування
                timeToReproduce--;
            }
            else if (newCell.GetType() == typeof(Bonus))
            {
                EatBonus(newCoord);// пересування з поїданням бонусу
                timeToReproduce--;
            }
            else if (newCell.GetType() == typeof(Prey))
            {
                Eat(newCoord);// пересування з поїданням здобичи
                timeToReproduce--;
            }


            if (timeToEat <= 0) // якщо ситість нижче або дорівнює 0,
                                // головний хижак помирає
            {
                Die();
                return;
            }


        }

        protected override void ChangeTimeToEat() // зміна ситості
        {
            if (isBonusMealOn)
            {
                return;
            }
            else timeToEat = Constants.timeToFeedMainPredator;
        }

        protected override void Die() // метод смерті головного хижака
        {
            _owner[coord.X, coord.Y] = null;
            _owner.AddChangedCellsCoord(new Coordinate(coord));
            _owner.numMainPredator--;

        }

        protected void EatBonus(Coordinate bonusCoord) // поїдання бонусу за вказаними координатами
        {
            Move(bonusCoord);
            BonusEffect();
        }

        protected void BonusEffect() // бонусний ефект від черв'яка
        {
            _owner.score += Constants.scoreEatBonus; // додавання очок за поїдання бонусу
            isBonusMealOn = true;
            timeToEat = Constants.BonusTimeToEatForPredator;
        }

        protected override void Eat(Coordinate preyCoord) // поїдання здобичи за вказаними координатами
        {
            Move(preyCoord);
            _owner.score += Constants.scoreEatPrey; // додавання очок за поїдання здобичи
            _owner.numPreys--; 
            ChangeTimeToEat();
        }

        protected override void Move(Coordinate newCoord) // пересування за вказаними координатами
        {
            _owner.AddChangedCellsCoord(new Coordinate(coord));
            _owner.AddChangedCellsCoord(new Coordinate(newCoord));
            _owner[newCoord.X, newCoord.Y] = _owner[coord.X, coord.Y];
            _owner[coord.X, coord.Y] = null;
            _owner[newCoord.X, newCoord.Y].coord.X = newCoord.X;
            _owner[newCoord.X, newCoord.Y].coord.Y = newCoord.Y;
            _owner[newCoord.X, newCoord.Y].isMoved = true;
            _owner.mainPredatorCoord = newCoord;
        }

        protected override void Reproduce(Coordinate newCoord) // розмноження за вказаними координатами
        {
            if (_owner[newCoord.X, newCoord.Y] != null
                && _owner[newCoord.X, newCoord.Y].GetImage() == Constants.defaultPreyImage)
            // якщо вказана клітина містить здобич, хижак їсть та розмножується одночасно
            {
                _owner.score += Constants.scoreEatPrey; // додавання очок за поїдання здобичи
                _owner.numPreys--;
            }

            _owner.AddChangedCellsCoord(new Coordinate(coord));
            _owner.AddChangedCellsCoord(new Coordinate(newCoord));
            _owner[newCoord.X, newCoord.Y] = _owner[coord.X, coord.Y];
            _owner[coord.X, coord.Y] = new Predator(_owner, coord.X, coord.Y);
            _owner[newCoord.X, newCoord.Y].coord.X = newCoord.X;
            _owner[newCoord.X, newCoord.Y].coord.Y = newCoord.Y;
            _owner[newCoord.X, newCoord.Y].isMoved = true;
            _owner.mainPredatorCoord = newCoord;
            _owner.numPredators++;
            _owner.score += Constants.scoreReproduce; // додавання очок за розмноження
            timeToReproduce = Constants.timeToReproduce;
        }

        public override bool isBonusOn() 
        {
            return isBonusMealOn;
        }
    }

}
