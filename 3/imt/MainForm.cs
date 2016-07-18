using ImitationSenderAPPIG.Imitation;
using System;
using System.Windows.Forms;

namespace ImitationSenderAPPIG
{
    public partial class MainForm : Form
    {
        private Imitator _imitator;
        private FileDialog _fd;
        private bool isStop = false;        

        public MainForm()
        {
            InitializeComponent();

            _fd = new OpenFileDialog();
#if DEBUG
            _fd.InitialDirectory = @"C:\Users\user\Desktop\06 - 07 - 2016_09 - 49 - 27(1)\АП012016070601";
#else
            _fd.InitialDirectory = Application.StartupPath;
#endif
            _fd.Filter = "Файл | *.BND";

            InitImitator();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(fileGGI.Text.Length == 0 || _imitator == null)
            {
                ShowError("Укажите файл GGI для имитации");
                return;
            }

            if (isStop)
            {
                StopImitation();
                return;
            }

            try
            {
                StartImitation();
            }
            catch (Exception err)
            {
                ShowError(err.Message);
            }
        }      

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = _fd.ShowDialog();

            if (DialogResult.OK != dr)
                return;
            
            _imitator.SetDataTransmission(_fd.FileName);

            fileGGI.Text = _fd.FileName;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (isStop)
            {                
                tbLog.Text = string.Empty;
                StopImitation();
            }

            _imitator.SetTypeSender(rbUDP.Checked);

            if(fileGGI.TextLength !=0)
                _imitator.SetDataTransmission(_fd.FileName);
       
        }        
    }
}
