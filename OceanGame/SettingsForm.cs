using OceanLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OceanGame
{
    public partial class SettingsForm : Form
    {
        #region Fields

        private readonly Ocean ocean;
        private readonly Ocean mainOcean;
        private readonly Coordinate mainFormPosition;
        private readonly WinFormOutput output;
        private readonly WinFormInput input;
        private bool wasSaved { get; set; } = false; 
            // змінна індикатор яка вказує на збереження введених даних

        #endregion

        #region Constructor

        public SettingsForm(Coordinate mainFormPosition, Ocean mainOcean)
        {
            InitializeComponent();
            this.mainFormPosition = mainFormPosition;
            this.mainOcean = mainOcean;

            ocean = new Ocean();
            output = new WinFormOutput();
            input = new WinFormInput(this);

            ocean.CopyOceanDataFrom(mainOcean); // копіювання даних з головного екрану
            ocean.SetOutput(output);
            ocean.SetInput(input);

            InitSizeComboBox(); // ініціалізація comboBox'у з розмірами океану
            InitCellBorderComboBox(); // ініціалізація comboBox'у з типами границь клітин
            InitTextBoxes(); // ініціалізація textBox'ів
        }

        #endregion

        #region Control Events

        private void SettingsForm_Load(object sender, EventArgs e) 
            // зміщення вікна з налаштуваннями 
        {
            Left = mainFormPosition.X + Constants.settingsWindowOffset.X;
            Top = mainFormPosition.Y + Constants.settingsWindowOffset.Y;
        }

        private void cmbboxOceanSize_SelectedIndexChanged(object sender, EventArgs e)
            // зміна даних у textBox'ах на стандартні для цього розміру океану,
            // при зміні розміру океану
        {
            txtPrey.Text = Constants.defaultPreysArr[cmbboxOceanSize.SelectedIndex].ToString();
            txtPredator.Text = Constants.defaultPredatorsArr[cmbboxOceanSize.SelectedIndex].ToString();
            txtObstacle.Text = Constants.defaultObstaclesArr[cmbboxOceanSize.SelectedIndex].ToString();
        }

        private void lblSave_Click(object sender, EventArgs e)
            // збереження данних при натисканні на кнопку зберегти
        {
            Save();
        }

        private void picboxClose_Click(object sender, EventArgs e)
            // закриття вікна налаштувань
        {
            if (wasSaved || (cmbboxOceanSize.SelectedIndex == ocean.pickedSize
                && txtPrey.Text == ocean.numPreys.ToString()
                && txtPredator.Text == ocean.numPredators.ToString()
                && txtObstacle.Text == ocean.numObstacles.ToString()
                && cmbboxOceanSize.SelectedIndex == ocean.pickedSize
                && cmbbxCellBorder.SelectedIndex == ocean.pickedCellBorderStyleIndex))
                // якщо дані були збережені, або дані у comboBox'ах та textBox'ах
                // не відрізняються від даних які вже були в океані, вікно закривається
            {
                Close();
            }
            else
                // в іншому разі, виведення повідомлення користувачу
                // з запропонуванням зберегти дані зараз
            {
                if (MessageBox.Show("You have not saved your new settings! Do you want to save it now?", 
                    "Be careful!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    // якщо користувач погодився зберегти дані, виконується збереження
                {
                    Save();
                }
                else Close(); // якщо користувач відмовився, виконується закриття вікна
            }
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        // метод для пересування форми
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void lblCaption_MouseDown(object sender, MouseEventArgs e)
        // метод для пересування форми
        {
            lblCaption.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

        #region Extra Methods

        private void InitSizeComboBox()
        {
            for (int i = 0; i < Constants.numOceanSizes; i++)
            {
                cmbboxOceanSize.Items.Add($"{Constants.defaultRowsArr[i]} x {Constants.defaultColsArr[i]}");
            }

            cmbboxOceanSize.SelectedIndex = ocean.pickedSize;
            cmbboxOceanSize.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitCellBorderComboBox()
        {
            for (int i = 0; i < Constants.cellBorderStylesText.Length; i++)
            {
                cmbbxCellBorder.Items.Add(Constants.cellBorderStylesText[i]);
            }

            cmbbxCellBorder.SelectedIndex = ocean.pickedCellBorderStyleIndex;
            cmbbxCellBorder.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitTextBoxes()
        {
            txtPrey.Text = ocean.numPreys.ToString();
            txtPredator.Text = ocean.numPredators.ToString();
            txtObstacle.Text = ocean.numObstacles.ToString();
        }

        private void Save()
            // збереження даних 
        {
            ocean.SetRows(Constants.defaultRowsArr[cmbboxOceanSize.SelectedIndex]);
            ocean.SetCols(Constants.defaultColsArr[cmbboxOceanSize.SelectedIndex]);

            ocean.EnterCells();
            mainOcean.CopyOceanDataFrom(ocean);

            if (ocean.successfulInitialization)
            {
                wasSaved = true;
                Close();
            }
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

        private void lblSave_MouseEnter(object sender, EventArgs e)
        // зміна кольору тексту на більш яксравий при наведенні
        {
            lblSave.ForeColor = Color.FromArgb(205, 231, 243);
        }

        private void lblSave_MouseLeave(object sender, EventArgs e)
        {
            lblSave.ForeColor = Color.FromArgb(129, 192, 224);
        }

        #endregion


    }
}
