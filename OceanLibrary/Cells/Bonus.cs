namespace OceanLibrary
{
    public class Bonus:Cell // клас бонусної клітини (черв'яка)
    {
        public Bonus(Ocean owner, int X, int Y) :base(owner, X, Y)
        {
            image = Constants.defaultBonusImage;
        }

    }
}
