//using Magnum.FileSystem;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Extensions
{
    public static class Extension
    {
        public static bool IsImage(this IFormFile photo)
        {
            return photo.ContentType.Contains("image/");
        }

        public static bool MaxSize(this IFormFile photo, int kb)
        {
            return photo.Length / 1024 <= kb;
        }

        public async static Task<string> SaveImageAsync(this IFormFile photo, string root, string folder)
        {
            string fileName = Guid.NewGuid().ToString() + photo.FileName;
            string path = Path.Combine(root, folder, fileName);

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }

    public enum Roles
    {
        Admin,
        Member
    }
}
