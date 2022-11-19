namespace OceanLibrary
{
    public interface IOutput // інтерфейс виводу
    {
        void ShowException(string message);

        void Print(Ocean _owner);

        void Draw(int score);

        void PredatorsWin(int score);

        void PreysWin(int score);

        void GameOver(int numPreys, int numMainPredators, int score);

    }
}
