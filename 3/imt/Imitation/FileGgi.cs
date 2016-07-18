using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImitationSenderAPPIG.Imitation
{
    class FileGgi
    {        
        private FileInfo _fi;        
        private string _fileName;

        public byte[] ContentOfFile { get; private set;}

        public FileGgi(): this(string.Empty){}
        public FileGgi(string fileName)
        {
            if (fileName != string.Empty)
            {
                SetFileGgi(fileName);
            }
        }

        public void SetFileGgi(string fileName)
        {
            _fileName = fileName;
            _fi = new FileInfo(_fileName);

            ContentOfFile = (new BinaryReader(_fi.OpenRead())).ReadBytes(Convert.ToInt32(_fi.Length));
        }        
    }
}
