using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure
{
    public static class ImageConverter
    {
        public static string ImageToBase64(IFormFile file)
        {
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();
                string s = "data:image/png;base64," +" "+ Convert.ToBase64String(fileBytes);
                return s;
            } 
        }

    }
}
