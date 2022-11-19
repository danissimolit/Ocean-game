using OceanLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OceanGame
{
    public partial class OceanForm : Form
    {
        #region Fields

        private readonly WinFormOutput output;
        private readonly Ocean _owner;
        private readonly LoadForm mainForm;
        public Button[,] buttons { get; set; } 
            // масив кнопок, які являють собою клітини океану

        #endregion

        #region Constructor

        public OceanForm(LoadForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            output = new WinFormOutput(this);
            _owner = new Ocean(output);

            _owner.CopyOceanDataFrom(mainForm.mainOcean);
                // копіювання даних з головного океану

            InitOceanTabel();

            Width = oceanTable.Width + Constants.oceanFormWidthAddition;
            Height = oceanTable.Height + Constants.oceanFormHeightAddition;

            _owner.AddCells();
            output.FirstPrint(_owner);
        }

        #endregion

        #region Control Events

        private void btnReset_Click(object sender, EventArgs e)
            // при натискані на кнопку Reset, скидання всіх даних до початкових
        {
            _owner.score = 0;
            KeyPreview = true; 
            ResetOcean();
        }

        private void OceanForm_KeyDown(object sender, KeyEventArgs e)
            // обробка натиснутих клавіш для керування головним хижаком
        {
            if (e.KeyValue == (char)Keys.W)
            {
                _owner.MoveMainPredator(Ocean.Directions.Up);
            }
            else if (e.KeyValue == (char)Keys.S)
            {
                _owner.MoveMainPredator(Ocean.Directions.Down);
            }
            else if (e.KeyValue == (char)Keys.A)
            {
                _owner.MoveMainPredator(Ocean.Directions.Left);
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                _owner.MoveMainPredator(Ocean.Directions.Right);
            }
            else
            {
                return;
            }

            if (_owner.successfulMainPredatorMove == false)
                // якщо за вказаним напрямком була перешкода або інший хижак,
                // пересування головного хижака неможливо
            {
                return;
            }

            _owner.Iteration(); // виконування поведінки для кожної іншої клітини

            if (_owner.numMainPredator <= 0 || _owner.numPreys <= 0)
                // якщо головний хижак або вся здобич померли, гра закінчується
            {
                output.GameOver(_owner.numPreys, _owner.numMainPredator, _owner.score);
            }
        }

        private void chkbxOptimizer_CheckedChanged(object sender, EventArgs e)
            // оптімайзер, який задає статичний фон для океану для покращення 
            // плавності та швидкості роботи програми
        {
            if (oceanTable.BackColor == Color.Transparent)
            {
                oceanTable.BackColor = Color.FromArgb(1, 18, 40);
            }
            else oceanTable.BackColor = Color.Transparent;
        }

        private void picboxClose_Click(object sender, EventArgs e)
            // закриття вікна з океаном
        {
            Close();
        }

        private void OceanForm_Load(object sender, EventArgs e)
        {

        }

        private void OceanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void OceanForm_MouseDown(object sender, MouseEventArgs e)
            // метод для пересування форми
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

        #region Extra Methods

        private void InitOceanTabel()
            // ініціалізація таблиці з океаном
        {
            oceanTable.RowCount = _owner.rows;
            oceanTable.ColumnCount = _owner.cols;
            buttons = new Button[_owner.rows, _owner.cols]; 
                // створення масиву кнопок відповідного розміру

            for (int i = 0; i < _owner.rows; i++)
            {
                for (int j = 0; j < _owner.cols; j++)
                {
                    buttons[i, j] = CreateNewButton(); 
                        // створення кнопки відповідних параметрів
                    oceanTable.Controls.Add(buttons[i, j], j, i);
                        // додавання кнопки до таблиці
                }
            }

            oceanTable.CellBorderStyle = (TableLayoutPanelCellBorderStyle)_owner.pickedCellBorderStyleIndex;
        }

        private Button CreateNewButton()
            // метод для створення кнопки з відповідними параметрами
        {
            Button button = new Button();

            button.Width = Constants.cellSize[_owner.pickedSize];
            button.Height = Constants.cellSize[_owner.pickedSize];

            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.ForeColor = Color.White;

            return button;
        }

        public void ResetOcean()
            // скидування океану до початкових даних
        {
            _owner.CopyOceanDataFrom(mainForm.mainOcean);
            _owner.AddCells();
            output.FirstPrint(_owner);
        }

        #endregion

        #region Control Visual Events

        private void picboxClose_MouseEnter(object sender, EventArgs e)
            // зміна картинки на більш яксраву при наведенні
        {
            picboxClose.BackgroundImage = Properties.Resources.CloseImgMouseOn;
        }

        private void picboxClose_MouseLeave(object sender, EventArgs e)
        {
            picboxClose.BackgroundImage = Properties.Resources.CloseImg4;
        }

        #endregion

        
    }
}
