using OceanLibrary;
using System;
using System.Windows.Forms;

namespace OceanGame
{
    public partial class LoadForm : Form // форма при запуску гри
    {
        #region Fields

        public Ocean mainOcean { get; set; }
        Coordinate formPosition { get; set; }

        #endregion

        #region Constructor

        public LoadForm()
        {
            InitializeComponent();
            mainOcean = new Ocean();
            mainOcean.SetDefaultOcean();
        }

        #endregion

        #region Control Events

        private void picboxStart_Click(object sender, EventArgs e)
            // створення вікна з океаном
        {
            OceanForm oceanForm = new OceanForm(this);
            oceanForm.Show();
        }

        private void picboxSettings_Click(object sender, EventArgs e)
            // створення діалогового вікна з налаштуваннями
        {
            formPosition = new Coordinate(Left, Top);
            SettingsForm settingsForm = new SettingsForm(formPosition, mainOcean);

            settingsForm.ShowDialog();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadForm_MouseDown(object sender, MouseEventArgs e)
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

        #region Control Visual Events

        private void picboxSettings_MouseEnter(object sender, EventArgs e)
            // зміна картинки на більш яксраву при наведенні
        {
            picboxSettings.BackgroundImage = Properties.Resources.SettingsImgMouseOn;
        }

        private void picboxSettings_MouseLeave(object sender, EventArgs e)
        {
            picboxSettings.BackgroundImage = Properties.Resources.SettingsImg2;
        }

        private void picboxStart_MouseEnter(object sender, EventArgs e)
            // зміна картинки на більш яксраву при наведенні
        {
            picboxStart.BackgroundImage = Properties.Resources.StartImgButtonMouseOn;
        }

        private void picboxStart_MouseLeave(object sender, EventArgs e)
        {
            picboxStart.BackgroundImage = Properties.Resources.StartImgButton4;
        }

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
