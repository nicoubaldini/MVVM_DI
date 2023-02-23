using MVVM_DI.Models;

namespace MVVM_DI.Interfaces
{
    public interface IFileService
    {
        IEnumerable<FileModel> GetFiles();
    }
}