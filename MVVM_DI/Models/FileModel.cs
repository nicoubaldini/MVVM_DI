using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_DI.Models
{
    public class FileModel
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Extention { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreationDate { get; set; }

        public FileModel(string fileName, string path, string extention, DateTime lastModifiedDate, DateTime creationDate)
        {
            FileName = fileName;
            Path = path;
            Extention = extention;
            LastModifiedDate = lastModifiedDate;
            CreationDate = creationDate;
        }

    }
}
