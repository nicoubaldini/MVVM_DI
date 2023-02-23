using MVVM_DI.Interfaces;
using MVVM_DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_DI.Services
{
    public class FileService : IFileService
    {
        public IEnumerable<FileModel> GetFiles()
        {
            return null;
        }
    }
}
