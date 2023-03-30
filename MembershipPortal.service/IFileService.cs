using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IFileService
    {
        public void UploadFile(List<IFormFile> files, string subDirectory);
        public (string fileType, byte[] archiveData, string archiveName) DownloadFile(string subDirectory);
        public string SizeConverter(long bytes);
    }
}
