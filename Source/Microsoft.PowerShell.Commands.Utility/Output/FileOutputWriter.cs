using System;
using System.IO;

namespace Microsoft.PowerShell.Commands.Utility
{
    internal class FileOutputWriter : OutputWriter
    {
        private StreamWriter _streamWriter;

        public FileOutputWriter(string filename)
        {
            _streamWriter = new StreamWriter(File.Open(filename, FileMode.OpenOrCreate));
        }

        public override void Close()
        {
            _streamWriter.Close();
        }

        public override void WriteLine(string output)
        {
            _streamWriter.Write(output);
        }
    }
}

