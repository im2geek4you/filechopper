using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    class SplitSettings
    {
        private byte[] startPatern;

        public byte[] StartPatern
        {
            get { return startPatern; }
            set { startPatern = value; }
        }

        private byte[] endPatern;

        public byte[] EndPatern
        {
            get { return endPatern; }
            set { endPatern = value; }
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private bool includeHeaderPatern;

        public bool IncludeHeaderPatern
        {
            get { return includeHeaderPatern; }
            set { includeHeaderPatern = value; }
        }

        private bool includeTailPatern;

        public bool IncludeTailPatern
        {
            get { return includeTailPatern; }
            set { includeTailPatern = value; }
        }

        private string fileExtension;

        public string FileExtension
        {
            get { return fileExtension; }
            set { fileExtension = value; }
        }

        private string outputFileNamePatern;

        public string OutputFileNamePatern
        {
            get { return outputFileNamePatern; }
            set { outputFileNamePatern = value; }
        }

        private string outputFolder;

        public string OutputFolder
        {
            get { return outputFolder; }
            set { outputFolder = value; }
        }

        private bool scan;

        public bool Scan
        {
            get { return scan; }
            set { scan = value; }
        }


    }
}
