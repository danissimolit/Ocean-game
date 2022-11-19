namespace OceanLibrary
{
    abstract public class Cell // головний абстрактний клас. Є предком для всіх класів клітин
    {
        protected Ocean _owner;
        public Coordinate coord { get; set; }
        protected char image { get; set; }
        public int timeToEat { get; set; }
        public bool isMoved { get; set; } = false; // зміна-індикатор для уникання подвійного пересування


        public Cell(Ocean owner, int X, int Y)
        {
            image = Constants.defaultImage;
            coord = new Coordinate(X, Y);
            _owner = owner;
        }

        public Cell(Coordinate coord)
        {
            this.coord = coord;
        }

        public Coordinate GetEmptyNeighborCoord() // метод для пошуку вільної клітки поблизу
        {
            Coordinate[] desiredCells = new Coordinate[4];
            int counter = 0;
            if (NorthCell() == null)
            {
                desiredCells[counter] = NorthCellCoord();
                counter++;
            }

            if (EastCell() == null)
            {
                desiredCells[counter] = EastCellCoord();
                counter++;
            }

            if (SouthCell() == null)
            {
                desiredCells[counter] = SouthCellCoord();
                counter++;
            }

            if (WestCell() == null)
            {
                desiredCells[counter] = WestCellCoord();
                counter++;
            }

            if (counter == 0) 
            {
                return coord; // якщо вільної клітини немає, повератються координати клітини
                              // для якої і робився пошук
            }
            else if (counter == 1)
            {
                return desiredCells[0]; // повертаються координати клітини,
                                        // якщо вільна клітина лише одна
            }
            else return desiredCells[Rand.GetRandomIndex(counter)]; 
            // повераються координати випадкової клітини серед всіх вільних клітин поблизу
        }

        public Coordinate GetNeighborWithImageCoord(char image) // метод для пошуку певної клітини поблизу
                                                                // за допомогою символа класу клітини
        {
            Cell[] desiredCells = new Cell[4];
            int counter = 0;
            if (NorthCell() != null && NorthCell().GetImage() == image)
            {
                desiredCells[counter] = NorthCell();
                counter++;
            }

            if (EastCell() != null && EastCell().image == image)
            {
                desiredCells[counter] = EastCell();
                counter++;
            }

            if (SouthCell() != null && SouthCell().image == image)
            {
                desiredCells[counter] = SouthCell();
                counter++;
            }

            if (WestCell() != null && WestCell().image == image)
            {
                desiredCells[counter] = WestCell();
                counter++;
            }

            if (counter == 0) 
            {
                return coord; // якщо клітини з таким символом поблизу немає,
                              // повератються координати клітини
                              // для якої і робився пошук
            }
            else if (counter == 1)
            {
                return desiredCells[0].coord;// повертаються координати клітини,
                                             // якщо клітина з цим символом лише одна
            }
            else return desiredCells[Rand.GetRandomIndex(counter)].coord;
            // повераються координати випадкової клітини серед всіх клітин з цим символом поблизу
        }

        // чотири методи які повертають клітину в залежності від напрямку відносно самої клітини
        // для якої був викликан цей метод
        public Cell NorthCell()
        {
            return _owner[NorthCellCoord().X, NorthCellCoord().Y];
        }

        public Cell WestCell()
        {
            return _owner[WestCellCoord().X, WestCellCoord().Y];
        }

        public Cell SouthCell()
        {
            return _owner[SouthCellCoord().X, SouthCellCoord().Y];
        }

        public Cell EastCell()
        {
            return _owner[EastCellCoord().X, EastCellCoord().Y];
        }

        // аналогічні чотири методи, проте повертають саме координати цієї клітини
        public Coordinate NorthCellCoord()
        {
            if (coord.X != 0)
            {
                return new Coordinate(coord.X - 1, coord.Y);
            }
            else return new Coordinate(_owner.rows - 1, coord.Y);
        }

        public Coordinate WestCellCoord()
        {
            if (coord.Y != 0)
            {
                return new Coordinate(coord.X, coord.Y - 1);
            }
            else return new Coordinate(coord.X, _owner.cols - 1);
        }

        public Coordinate SouthCellCoord()
        {
            if (coord.X != _owner.rows - 1)
            {
                return new Coordinate(coord.X + 1, coord.Y);
            }
            else return new Coordinate(0, coord.Y);
        }

        public Coordinate EastCellCoord()
        {
            if (this.coord.Y != _owner.cols - 1)
            {
                return new Coordinate(coord.X, coord.Y + 1);
            }
            else return new Coordinate(coord.X, 0);
        }



        public void SetOcean(Ocean ocean)
        {
            _owner = ocean;
        }

        public char GetImage()
        {
            return image;
        }

        public virtual void ProcessForMainPredator(Ocean.Directions direction)
        {

        }

        public virtual void ProcessForPredator()
        {

        }

        public virtual void ProcessForPrey()
        {

        }

        public virtual bool isBonusOn()
        {
            return false;
        }

        public virtual void SetBonus(bool bonus)
        {

        }
    }
}
