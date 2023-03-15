using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    internal class FileLogger : StreamLogger
    {

        private readonly FileStream fileStream;

        private FileLogger(FileStream fileStream) : base(new StreamWriter(fileStream))
        {
            this.fileStream = fileStream;
        }


        public static Logger Create(string path)
        {
            var fileStream = File.OpenWrite(path);
            return new FileLogger(fileStream);
        }

        public override void Close() 
        {
            this.fileStream.Close();
        }
    }
}
