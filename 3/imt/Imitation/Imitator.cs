using System;
using System.Timers;

namespace ImitationSenderAPPIG.Imitation
{
    class Imitator
    {
        public event Action FinishedSendEvent;
        public event Action<string> SendByteEvent;

        private Timer _t;                
        private FileGgi _fileGgi;
        private AbstractSender _sender;
        private byte currentByte;

        public Imitator(): this(true){}

        public Imitator(bool isUdpSender)
        {
            _t = new Timer();
            _t.AutoReset = true;
            _t.Interval = 1000;
            _t.Elapsed += T_Elapsed;            

            _fileGgi = new FileGgi();

            FinishedSendEvent += () => { };
            SendByteEvent += (x) => { }; 

            SetTypeSender(isUdpSender);
        }        

        public void Start()
        {
            try
            {
                _sender.InitConnection();            
                _t.Start();
            }
            catch(Exception err)
            {
                throw err;
            }
        }    
        
        public void SetDataTransmission(string fileName)
        {
            _fileGgi.SetFileGgi(fileName);
            _sender.SetData(_fileGgi.ContentOfFile);
        }

        public void Stop()
        {
            _t.Stop();
        }    

        public void SetTypeSender(bool isUdpSender)
        {
            if (isUdpSender)
                _sender = new UdpSender();
            else
                _sender = new TcpSender();
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            _sender.SendData(ref currentByte);

            SendByteEvent(currentByte.ToString("X"));            

            if (_sender.IsLastByte)
            {
                FinishedSendEvent();
                Stop();
            }
        }
    }
}
