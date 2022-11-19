using OceanLibrary;

namespace OceanGame
{
    public class WinFormInput: IInput // клас для введення даних. Реалізує інтерфейс IInput
    {
        private readonly SettingsForm settingsForm; // створюється екземпляр форми налаштувань,
                                                    // оскільки саме там користувач вказує
                                                    // свої налаштування та вводить дані

        public WinFormInput(SettingsForm settingsForm)
        {
            this.settingsForm = settingsForm;
        }

        public void EnterAll(Ocean ocean) // введення усіх даних
        {
            EnterOceanSize(ocean);
            EnterPreys(ocean);
            EnterPredators(ocean);
            EnterObstacles(ocean);
            EnterCellBorderStyle(ocean);
        }

        public void EnterObstacles(Ocean ocean) // введення кількості перешкод
        {
            int obst = int.Parse(settingsForm.txtObstacle.Text); 
                // дані беруться з відповідного textBox'у 

            if (obst < 0 || obst > Constants.maxObstaclesArr[ocean.pickedSize])
                // якщо кількість перешкод некоректна, користувачу виводиться повідомлення
            {
                throw new WrongAmountInput($"The number of obstacles must be between 0 and {Constants.maxObstaclesArr[ocean.pickedSize]}");
            }
            else
            {
                ocean.numObstacles = obst;
            }
        }

        public void EnterPreys(Ocean ocean) // введення кількості здобичи
        {
            int preys = int.Parse(settingsForm.txtPrey.Text);
                // дані беруться з відповідного textBox'у 

            if (preys < 0 || preys > Constants.maxPreysArr[ocean.pickedSize])
                // якщо кількість здобичи некоректна, користувачу виводиться повідомлення
            {
                throw new WrongAmountInput($"The number of preys must be between 0 and {Constants.maxPreysArr[ocean.pickedSize]}");
            }
            else
            {
                ocean.numPreys = preys;
            }
        }

        public void EnterPredators(Ocean ocean) // введення кількості хижаків
        {
            int predators = int.Parse(settingsForm.txtPredator.Text);
                // дані беруться з відповідного textBox'у 

            if (predators < 0 || predators > Constants.maxPredatorsArr[ocean.pickedSize])
                // якщо кількість хижаків некоректна, користувачу виводиться повідомлення
            {
                throw new WrongAmountInput($"The number of predators must be between 0 and {Constants.maxPredatorsArr[ocean.pickedSize]}");
            }
            else
            {
                ocean.numPredators = predators;
            }
        }

        public void EnterOceanSize(Ocean ocean) // введення розмірів океану
        {
            ocean.pickedSize = settingsForm.cmbboxOceanSize.SelectedIndex;
                // дані беруться з відповідного comboBox'у
        }

        public void EnterCellBorderStyle(Ocean ocean) // введення типу границь клітин
        {
            ocean.pickedCellBorderStyleIndex = settingsForm.cmbbxCellBorder.SelectedIndex;
                // дані беруться з відповідного comboBox'у
        }

    }
}
