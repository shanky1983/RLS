using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Attune.KernelV2
{
    public class CustomMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
    {

        public override Stream GetStream(HttpContent parent, HttpContentHeaders headers)
        {
            if (String.IsNullOrEmpty(headers.ContentDisposition.FileName)) return base.GetStream(parent, headers);

            List<string> extensions = new List<string> { "png", "gif", 
                "jpg", "jpeg", "tiff", "pdf", "tif", "bmp","doc","docx","ods","xls","xlsx","odt","csv","txt","rtf" };
            var filename = headers.ContentDisposition.FileName.Replace("\"", string.Empty); // correct for chrome.

            if (filename.IndexOf('.') < 0)
            {
                return Stream.Null;
            }

            var extension = filename.Split('.').Last();

            return extensions.Contains(extension) ? base.GetStream(parent, headers) : Stream.Null;

        }

        public override string GetLocalFileName(HttpContentHeaders headers)
        {
            //var fileName = (headers.ContentDisposition.FileName ?? string.Empty).Replace("\"", string.Empty);
            var fileName = Guid.NewGuid().ToString().Replace("\"", string.Empty);
            var illegalChars = Path.GetInvalidFileNameChars();
            fileName = illegalChars.Aggregate(fileName, (current, ch) => current.Replace(ch, '_'));
            fileName = fileName.Replace('+', ' ') + Path.GetExtension((headers.ContentDisposition.FileName ?? string.Empty).Replace("\"", string.Empty));
            return fileName;

            //var sb = new StringBuilder((headers.ContentDisposition.FileName ?? DateTime.Now.Ticks.ToString()).Replace("\"", "").Trim().Replace(" ", "_"));
            //Array.ForEach(Path.GetInvalidFileNameChars(), invalidChar => sb.Replace(invalidChar, '-'));
            //return sb.ToString();
        }



        public CustomMultipartFormDataStreamProvider(string path) : base(path)
        {
        }

    }
}