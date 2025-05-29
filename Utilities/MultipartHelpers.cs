using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CyberSource.Utilities
{
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
                    fileContent = reader.ReadToEnd();
                    // fileContent now contains the content of the file as a string  
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
