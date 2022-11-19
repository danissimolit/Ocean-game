namespace OceanLibrary
{
    public interface IInput // інтерфейс введення даних
    {
        void EnterAll(Ocean ocean);

        void EnterObstacles(Ocean ocean);

        void EnterPreys(Ocean ocean);

        void EnterPredators(Ocean ocean);
        

        
    }
}
