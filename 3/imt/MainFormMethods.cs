using ImitationSenderAPPIG.Imitation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationSenderAPPIG
{
    public partial class MainForm : Form
    {
        private void InitImitator()
        {
            _imitator = new Imitator();
            _imitator.FinishedSendEvent += () => { UpdateLogAsync("Передача завершена"); };
            _imitator.SendByteEvent += (x) => { UpdateLogAsync(string.Format("Передан байт: {0}", x)); };
        }

        private void StartImitation()
        {
            _imitator.Start();
            UpdateLog("Начало отправки");
            isStop = true;
            btnStart.Text = "Stop";
        }

        private void StopImitation()
        {
            _imitator.Stop();
            UpdateLog("Отправка приостановлена");
            isStop = !isStop;
            btnStart.Text = "Start";
        }

        private void UpdateLogAsync(string text)
        {
            BeginInvoke(new Action(delegate () { UpdateLog(text); }));
        }

        private void UpdateLog(string text)
        {
            tbLog.Text += string.Format("{0}{1}", text, Environment.NewLine);
            tbLog.SelectionStart = tbLog.TextLength;
            tbLog.ScrollToCaret();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                   message,
                   "ОШИБКА",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
    }
}
