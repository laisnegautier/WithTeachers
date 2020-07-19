using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file, string uniqueFileName);
    }

    public class FileUploadService : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;

        public FileUploadService(IWebHostEnvironment env)
        {
            _environment = env;
        }

        public async Task UploadAsync(IFileListEntry fileEntry, string uniqueFileName)
        {
            string path = Path.Combine(_environment.ContentRootPath, "wwwroot/uploads", uniqueFileName);

            MemoryStream ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }
    }
}