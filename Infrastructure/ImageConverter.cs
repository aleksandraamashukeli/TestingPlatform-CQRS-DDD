using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure
{
    public static class ImageConverter
    {
        public static string ImageToBase64(this IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                var fileBytes = memoryStream.ToArray();
                var base64String = "data:image/png;base64," + " " + Convert.ToBase64String(fileBytes);
                return base64String;
            } 
        }

    }
}
