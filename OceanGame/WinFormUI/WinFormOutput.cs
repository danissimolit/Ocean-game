using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using OceanLibrary;

namespace OceanGame
{
    public class WinFormOutput : IOutput // клас для виведння даних. Реалізує інтерфейс IOutput
    {
        private readonly OceanForm oceanForm; 
        // зображення усіх типів клітинок
        private readonly Bitmap preyImg = Properties.Resources.PreyImg;
        private readonly Bitmap predatorImg = Properties.Resources.PredatorImg;
        private readonly Bitmap predatorDefaultImg = Properties.Resources.PredatorDefaultImg;
        private readonly Bitmap obstacleImg = Properties.Resources.ObstacleImg;
        private readonly Bitmap bonusImg = Properties.Resources.BonusImg;
        private readonly Bitmap predatorImgWithBonus = Properties.Resources.PredatorImgWithBonus;


        public WinFormOutput(OceanForm oceanForm)
        {
            this.oceanForm = oceanForm;
        }

        public WinFormOutput()
        {

        }

        public void ShowException(string message)
            // виведення повідомлення
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Print(Ocean _owner)
            // виведення океану
        {
            int mainPredatorTimeToEat;
            if (_owner[_owner.mainPredatorCoord.X, _owner.mainPredatorCoord.Y] != null)
                // якщо головний хижак не помер з голоду, береться значення його ситості
            {
                mainPredatorTimeToEat = _owner[_owner.mainPredatorCoord.X,
                    _owner.mainPredatorCoord.Y].timeToEat;
            }
            else mainPredatorTimeToEat = 0;

            PrintStats(_owner.numPreys, _owner.numPredators, mainPredatorTimeToEat, _owner.score);
            // виведення статистики

            for(int i = 0; i < _owner.changedCellsIndex; i++)
                // виведення кожної клітини у циклі
            {
                PrintCell(_owner, _owner.changedCellsCoord[i].X, _owner.changedCellsCoord[i].Y);
            }
        }

        public void FirstPrint(Ocean _owner) 
            // метод для першого виведення океану при завантаженні гри
        {
            PrintStats(_owner.numPreys, _owner.numPredators, _owner[_owner.mainPredatorCoord.X, 
                _owner.mainPredatorCoord.Y].timeToEat, _owner.score);

            for (int i = 0; i < _owner.rows; i++)
            {
                for (int j = 0; j < _owner.cols; j++)
                {
                    PrintCell(_owner, i, j);
                }
            }
        }

        public void PrintCell(Ocean _owner, int i, int j)
            // метод виведення клітини за вказаними координатами
        {
            if (_owner[i, j] == null)
                // якщо клітина пуста, її фон пустий
            {
                oceanForm.buttons[i, j].BackgroundImage = null;
            }
            else if (_owner[i, j].GetType() == typeof(Prey))
                // якщо клітина це здобич, виведення картинки здобичи
            {
                oceanForm.buttons[i, j].BackgroundImage = preyImg;
            }
            else if (_owner[i, j].GetType() == typeof(MainPredator))
                // якщо клітина це головний хижак, виведення картинки головнго хижака
            {
                if (_owner[i, j].isBonusOn())
                    // якщо головний хижак має бонус, виведення його бонусної картинки
                {
                    oceanForm.buttons[i, j].BackgroundImage = predatorImgWithBonus;
                }
                else oceanForm.buttons[i, j].BackgroundImage = predatorImg;
            }
            else if (_owner[i, j].GetType() == typeof(Predator))
                // якщо клітина це хижак, виведення картинки хижака
            {
                oceanForm.buttons[i, j].BackgroundImage = predatorDefaultImg;
            }
            else if (_owner[i, j].GetType() == typeof(Obstacle))
                // якщо клітина це перешкода, виведення картинки перешкоди
            {
                oceanForm.buttons[i, j].BackgroundImage = obstacleImg;
            }
            else if (_owner[i, j].GetType() == typeof(Bonus))
                // якщо клітина це бонус, виведення картинки бонусу
            {
                oceanForm.buttons[i, j].BackgroundImage = bonusImg;
            }
        }

        public void PrintStats(int numPreys, int numPredators, int satiety, int score)
            // метод для виведення статистики
        {
            oceanForm.lblStatsScore.Text = $"SCORE: {score}";
            oceanForm.lblStatsPrey.Text = $"PREYS: {numPreys}";              
            oceanForm.lblStatsPredator.Text = $"PREDATORS: {numPredators}";

            if (satiety <= 3)
                // якщо ситість головного хижака менше або дорівнює 3,
                // текст з його ситістю буде червоного кольору
            {
                oceanForm.lblStatsSatiety.ForeColor = Color.Red;
            }
            else if (satiety > Constants.timeToFeedMainPredator)
                // якщо ситість головного хижака більше
                // ніж стандартна максимальна ситість
                // (тобто головний хижак має бонус),
                // текст з його ситістю буде золотого кольору
            {
                oceanForm.lblStatsSatiety.ForeColor = Color.FromArgb(255, 215, 0);
            }
            else
            {
                oceanForm.lblStatsSatiety.ForeColor = Color.FromArgb(103, 203, 254);
                    // текст стандартного кольору якщо усі умови вище не виконалися
            }
            oceanForm.lblStatsSatiety.Text = $"SATIETY: {satiety}";

        }

        public void GameOver(int numPreys, int numMainPredators, int score)
            // метод для закінчення гри та виведення відповідного повідомлення
        {
            oceanForm.KeyPreview = false; // вимкнення зчитування клавіш клавіатури
            if (numMainPredators == 0 && numPreys == 0)
            {
                Draw(score); // нічия якщо хижаки та здобичи вмерли
            }
            else if (numMainPredators == 0)
            {
                PreysWin(score); // перемога здобичи, якщо головний хижак помер
            }
            else if (numPreys == 0)
            {
                PredatorsWin(score); // перемога хижаків, якщо уся здобич померла
            }
        }

        public void Draw(int score)
        {
            MessageBox.Show("Your shark and all fishes are dead" +
                $"\nYour score: {score}", "Draw!",
                MessageBoxButtons.OK);
        }

        public void PredatorsWin(int score)
        {
            MessageBox.Show("All preys are dead" +
                $"\nYour score {score}", "You won!",
                MessageBoxButtons.OK);
        }

        public void PreysWin(int score)
        {
            MessageBox.Show("Your shark starved to death" +
                $"\nYour score {score}", "Game over!",
                MessageBoxButtons.OK);
        }
    }
}
