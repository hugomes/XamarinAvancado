using PCLStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StorageDatabase.Util
{
    public class StorageManagement
    {
        public async static void SaveFile(string fileName, string content)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("StorageDatabase", CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await file.WriteAllTextAsync(content);
        }

        public async static Task<string> ReadFile(string fileName)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("StorageDatabase", CreationCollisionOption.OpenIfExists);
            IFile file = await folder.GetFileAsync(fileName);

            return await file.ReadAllTextAsync();
        }
    }
}
