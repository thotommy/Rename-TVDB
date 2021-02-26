using System;
using System.IO.Abstractions;

namespace FileManipulator
{
    class FileManipulator
    {
        private IFileSystem _fileSystem;

        public FileManipulator()
        {
            _fileSystem = new FileSystem();
        }

        public void Method()
        {
            if(_fileSystem.Directory.Exists("FolderTest"))
            {
                string[] arr = new string[] { };

                arr = _fileSystem.Directory.GetFiles("FolderTest");

                int i = 0;
                while(i < arr.Length) {
                    Console.WriteLine(arr[i]);
                    
                    _fileSystem.File.GetAttributes(arr[i]);
                    i++;
                }
            }
        }
    }
}
