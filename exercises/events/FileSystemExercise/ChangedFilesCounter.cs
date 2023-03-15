using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemExercise
{
    internal class ChangedFilesCounter
    {

        public int ChangeCount => files.Count;

        private HashSet<string> files;

        public ChangedFilesCounter(IFileSystem fileSystem)
        {
            files = new HashSet<string>();

            fileSystem.FileWritten += OnFileChange;
            fileSystem.FileCreated += OnFileChange;
            fileSystem.FileDeleted += OnFileChange;
        }

        public void OnFileChange(string file)
        {
            files.Add(file);
        }
            

    }
}
