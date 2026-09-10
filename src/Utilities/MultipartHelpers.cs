using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CyberSource.Utilities
{
    /// <summary>
    /// Lightweight replacement for RestSharp's FileParameter, used by MultipartHelpers
    /// and the generated Api classes to describe a file to be sent in a multipart body.
    /// </summary>
    public class FileParameter
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }

        private readonly Func<Stream> _getFile;

        public FileParameter(string name, string fileName, Stream stream, string contentType = null)
        {
            Name = name;
            FileName = fileName;
            ContentType = contentType;
            _getFile = () => stream;
        }

        public FileParameter(string name, string fileName, Func<Stream> getFile, string contentType = null)
        {
            Name = name;
            FileName = fileName;
            ContentType = contentType;
            _getFile = getFile;
        }

        public Stream GetFile()
        {
            return _getFile?.Invoke();
        }
    }

    public static class MultipartHelpers
    {
        public static string[] BuildPostBodyForFiles(Dictionary<string, FileParameter> localVarFileParams)
        {
            if (localVarFileParams == null || localVarFileParams.Count == 0)
            {
                return null;
            }

            Dictionary<string, string> localVarForFileNameAndContent = new Dictionary<string, string>();
            foreach(var fileParam in localVarFileParams)
            {
                string fileName = fileParam.Value.FileName;
                string fileContent = null;
                using (var reader = new StreamReader(fileParam.Value.GetFile()))
                {
                    try
                    {
                        fileContent = reader.ReadToEnd();
                        // fileContent now contains the content of the file as a string
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                localVarForFileNameAndContent.Add(fileName, fileContent);
            }

            string boundary = Guid.NewGuid().ToString("N");
            string delimiter = "-------------" + boundary;
            string eol = "\r\n";
            StringBuilder data = new StringBuilder();

            foreach (var param in localVarForFileNameAndContent)
                {
                string name = param.Key;
                string content = param.Value;

                data.Append("--").Append(delimiter).Append(eol);
                data.Append("Content-Disposition: form-data; name=\"").Append(name).Append("\"; filename=\"").Append(name).Append("\"").Append(eol);
                data.Append("Content-Transfer-Encoding: binary").Append(eol);
                data.Append(eol);
                data.Append(content).Append(eol);
            }

            data.Append("--").Append(delimiter).Append("--").Append(eol);

            return new string[] { data.ToString(), delimiter };
        }
        
        
    }
}
