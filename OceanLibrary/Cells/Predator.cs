namespace OceanLibrary
{
    public class Predator : Prey // клас сірої акули хижака, наслідується від класу здобичи
    {
        public Predator(Ocean owner, int X, int Y) : base(owner, X, Y)
        {
            image = Constants.defaultPredatorImage;
            timeToEat = Constants.timeToFeed; // зміна ситості хижака
        }

        public override void ProcessForPredator()
        {
            if (timeToEat <= 0) // якщо ситість хижака менше 0, він помирає
            {
                Die();
                return;
            }
            else
            {
                timeToEat--;


                Coordinate neighborPrey = GetNeighborWithImageCoord(Constants.defaultPreyImage); 
                // пошук здобичи поблизу

                if (timeToReproduce <= 0)
                {
                    if (neighborPrey != coord)
                    {
                        Reproduce(neighborPrey); // розмножування хижака та поїдання здобичи поблизу,
                                                 // якщо така є
                        _owner.numPreys--;
                        ChangeTimeToEat();
                    }
                    else
                    {
                        Coordinate newCell = GetEmptyNeighborCoord();
                        if (newCell != coord)
                        {
                            Reproduce(newCell); // лише розмножування хижака та переход на вільну клітину,
                                                // якщо така є
                        }
                    }
                }

                if (neighborPrey.X != coord.X || neighborPrey.Y != coord.Y)
                {
                    Eat(neighborPrey); // поїдання здобичи поблизу
                    timeToReproduce--;
                }
                else
                {
                    Coordinate newCell = GetEmptyNeighborCoord();
                    if (newCell != coord)
                    {
                        Move(newCell); // переход на вільну клітину
                    }
                    timeToReproduce--;
                }
            }
        }

        protected virtual void ChangeTimeToEat()
        {
            timeToEat = Constants.timeToFeed;
        }

        protected virtual void Die() // метод для смерті хижака
        {
            _owner[coord.X, coord.Y] = null; // очищення клітини
            _owner.AddChangedCellsCoord(new Coordinate(coord));
            _owner.numPredators--;
        }

        protected virtual void Eat(Coordinate preyCoord) // метод поїдання здобичи
        {
            Move(preyCoord); // переход на клітину де знаходиться здобич
            _owner.numPreys--; 
            ChangeTimeToEat(); // ситість знов достигає максимуму
        }

        protected override void Move(Coordinate newCoord) // метод переходу на вказану клітину
        {
            _owner.AddChangedCellsCoord(new Coordinate(coord));     // додавання обох клітин у масив зі зміненими
            _owner.AddChangedCellsCoord(new Coordinate(newCoord));  // клітинами, який оптимізує роботу програми 
            _owner[newCoord.X, newCoord.Y] = _owner[coord.X, coord.Y]; // новій клітини привласнюють стару клітину
            _owner[coord.X, coord.Y] = null; // очищення старої клітини
            _owner[newCoord.X, newCoord.Y].coord.X = newCoord.X; // нові дані координат для клітини
            _owner[newCoord.X, newCoord.Y].coord.Y = newCoord.Y;
            _owner[newCoord.X, newCoord.Y].isMoved = true; // зміна індикатору для уникнення подвійного пересування
        }

        protected override void Reproduce(Coordinate newCoord) // метод розмноження
        {
            _owner.AddChangedCellsCoord(new Coordinate(coord));
            _owner.AddChangedCellsCoord(new Coordinate(newCoord));
            _owner[newCoord.X, newCoord.Y] = _owner[coord.X, coord.Y];
            _owner[coord.X, coord.Y] = new Predator(_owner, coord.X, coord.Y);
            // замість очищення старої клітини, як це було в методі Move, створюємо нову рибу-здобич
            _owner[newCoord.X, newCoord.Y].coord.X = newCoord.X;
            _owner[newCoord.X, newCoord.Y].coord.Y = newCoord.Y;
            _owner[newCoord.X, newCoord.Y].isMoved = true;
            _owner.numPredators++;
            timeToReproduce = Constants.timeToReproduce;
        }

    }

}
