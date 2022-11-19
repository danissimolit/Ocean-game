namespace OceanLibrary
{
    public class Prey : Cell // клас здобичи (звичайної риби)
    {
        public int timeToReproduce;

        public Prey(Ocean owner, int X, int Y) : base(owner, X, Y)
        {
            image = Constants.defaultPreyImage;
            timeToReproduce = Constants.timeToReproduce;
        }

        public override void ProcessForPrey()
        {
            Coordinate emptyNeighbor = GetEmptyNeighborCoord(); // пошук вільної клітини поблизу
            if (timeToReproduce <= 0 && emptyNeighbor != coord) // якщо вже час розмножуватися для риби
                                                                // та поблизу є вільна клітина, 
                                                                // риба розмножується
            {
                Reproduce(emptyNeighbor); // розмножування з переходом на вільну клітину поблизу
                return;
                
            }
            else if (emptyNeighbor != coord) // якщо ще не час розмножуватись, проте поблизу є вільна клітина
                                             // риба переходить до неї з шаносм 50%
            {
                if (Rand.GetRandomIndex(2) == 1) // метод повертає випадкове число від 0 до 1, 
                                                 // якщо випадає 1, то риба робить переход (50% шанс)
                {
                    Move(emptyNeighbor); //переход на вільну клітину
                    timeToReproduce--; // віднімання часу для розмножування
                }
            }
            else timeToReproduce--; // якщо поблизу немає вільних клітин, то риба стоїть на місці,
                                    // віднімаючи час для розмножування
        }

        

        protected virtual void Move(Coordinate newCoord) // метод переходу на вказану клітину
        {
            _owner.AddChangedCellsCoord(new Coordinate(coord));     // додавання обох клітин у масив зі зміненими 
            _owner.AddChangedCellsCoord(new Coordinate(newCoord));  // клітинами, який оптимізує роботу програми 
            _owner[newCoord.X, newCoord.Y] = _owner[coord.X, coord.Y]; // новій клітини привласнюють стару клітину
            _owner[coord.X, coord.Y] = null; // очищення старої клітини
            _owner[newCoord.X, newCoord.Y].coord.X = newCoord.X; // нові дані координат для клітини
            _owner[newCoord.X, newCoord.Y].coord.Y = newCoord.Y;
            _owner[newCoord.X, newCoord.Y].isMoved = true; // зміна індикатору для уникнення подвійного пересування
        }

        protected virtual void Reproduce(Coordinate newCoord) // метод для розмножування риби
        {
            _owner.AddChangedCellsCoord(new Coordinate(coord)); 
            _owner.AddChangedCellsCoord(new Coordinate(newCoord));
            _owner[newCoord.X, newCoord.Y] = _owner[coord.X, coord.Y];
            _owner[coord.X, coord.Y] = new Prey(_owner, coord.X, coord.Y); 
            // замість очищення старої клітини, як це було в методі Move, створюємо нову рибу-здобич

            _owner[newCoord.X, newCoord.Y].coord.X = newCoord.X;
            _owner[newCoord.X, newCoord.Y].coord.Y = newCoord.Y;
            _owner[newCoord.X, newCoord.Y].isMoved = true;

            _owner.numPreys++;
            timeToReproduce = Constants.timeToReproduce;
        }
    }

}
