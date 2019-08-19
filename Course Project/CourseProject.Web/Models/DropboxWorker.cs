using Dropbox.Api;
using Dropbox.Api.Files;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Web.Models
{
    public class DropboxWorker
    {
        private readonly string token = "";

        public void Add(IFormFile formFile)
        {
            string filename = formFile.FileName;
            if (ItHas(filename))
            {
                using (var dbx = new DropboxClient(token))
                {
                    using (var mem1 = new MemoryStream())
                    {
                        formFile.CopyTo(mem1);
                        var fileByte = mem1.ToArray();
                        using (var mem = new MemoryStream(fileByte))
                        {
                            var update = dbx.Files.UploadAsync("/" + filename, WriteMode.Overwrite.Instance, body: mem);
                            update.Wait();
                        }
                    }
                }
            }
        }

        public string GetPath(string fileName)
        {
            string url = "";
            using (var dbx = new DropboxClient(token))
            {
                var sharedLink = dbx.Sharing.CreateSharedLinkAsync("/" + fileName);
                sharedLink.Wait();
                url = sharedLink.Result.Url;
            }
            url = url.Remove(url.Length - 4) + "raw=1";
            return url;
        }

        private bool ItHas(string filename)
        {
            using (var dbx = new DropboxClient(token))
            {
                var list = dbx.Files.ListFolderAsync(string.Empty);
                list.Wait();
                if (list.Result.Entries.Where(i => i.IsFile).ToList().Find(x => x.Name.Contains(filename)) == null)
                    return true;
                return false;
            }
        }

        public void Add(List<IFormFile> formFiles)
        {
            foreach (var formFile in formFiles)
            {
                string filename = formFile.FileName;
                if (ItHas(filename))
                {
                    using (var dbx = new DropboxClient(token))
                    {
                        using (var mem1 = new MemoryStream())
                        {
                            formFile.CopyTo(mem1);
                            var fileByte = mem1.ToArray();
                            using (var mem = new MemoryStream(fileByte))
                            {
                                var update = dbx.Files.UploadAsync("/" + filename, WriteMode.Overwrite.Instance, body: mem);
                                update.Wait();
                            }
                        }
                    }
                }
            }
        }

        public List<string> GetPath(List<IFormFile> formFiles)
        {
            List<string> urls = new List<string>();
            foreach (var formFile in formFiles)
            {
                string url = "";
                using (var dbx = new DropboxClient(token))
                {
                    var sharedLink = dbx.Sharing.CreateSharedLinkAsync("/" + formFile.FileName);
                    sharedLink.Wait();
                    url = sharedLink.Result.Url;
                }
                url = url.Remove(url.Length - 4) + "raw=1";
                urls.Add(url);
            }
            return urls;
        }
    }
}
