using System;
using System.Net;
using System.Net.Sockets;

namespace ImitationSenderAPPIG.Imitation
{
    abstract class AbstractSender
    {
        protected byte[] data;
        protected int currentByte = 0;

        public AbstractSender() : this(null) { }

        public AbstractSender(byte[] data)
        {
            SetData(data);
        }

        public void SetData(byte[] data)
        {
            this.data = data;
        }

        public void SetNumberCurrentByre(int index)
        {
            currentByte = index;
        }

        public void ResetNumberCurrentByte()
        {
            currentByte = 0;
        }

        public void SendData(ref byte currByte)
        {
            if (currentByte < data.Length)
            {
                SendByte(ref currByte);
                currentByte++;
            }
        }

        public bool IsLastByte
        {
            get
            {
                return data.Length == currentByte;
            }
        }

        public virtual void InitConnection()
        {
            if (data == null)
                throw new ArgumentException("Данные не заданы");
        }

        public abstract void SendByte(ref byte currByte);
        
    }

    class UdpSender : AbstractSender
    {
        private IPEndPoint _remoteIP;
        private UdpClient _server;

        public UdpSender() : this(null) { }

        public UdpSender(byte[] data): base(data)
        {
            _remoteIP = new IPEndPoint(IPAddress.Loopback, 5050);
            _server = new UdpClient();            
        }

        public override void SendByte(ref byte currByte)
        {
            currByte = data[currentByte];
            _server.Send(new byte[] { data[currentByte] }, 1,_remoteIP);
        }
    }

    class TcpSender: AbstractSender
    {        
        private TcpListener _server;        
        private IPEndPoint _ipEndPoint = new IPEndPoint(IPAddress.Loopback,5050);
        private NetworkStream _ns;

        public TcpSender():this(null){ }

        public TcpSender(byte[] data): base(data)
        {            
            _server = new TcpListener(_ipEndPoint);            
        }                

        public override void InitConnection()
        {
            base.InitConnection();
             
            _server.Start();
            TcpClient client = _server.AcceptTcpClient();

            _ns = client.GetStream();
        }

        public override void SendByte(ref byte currByte)
        {
            currByte = data[currentByte];
           _ns.WriteByte(data[currentByte]);            
        }        
    }
}

//interface ISender
//{     
//void SendData();
//void InitConnection();
//void SetData(byte[] data);
//void ResetNumberCurrentByte();
//}