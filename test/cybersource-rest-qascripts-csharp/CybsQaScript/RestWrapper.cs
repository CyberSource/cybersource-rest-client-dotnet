using System;
using System.IO;
using System.Net;
using LumenWorks.Framework.IO.Csv;

namespace CybsQaScript
{
    public class RestWrapper
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("QA Scripts App - BEGIN");
            Apicollection();
            Console.WriteLine("QA Scripts App - END");
        }

        public static void Apicollection()
        {
            // Read the data from csv file for condition flag = 1
            try
            {
                CsvReader csv = null;
                using (csv = new CsvReader(new StreamReader(@"../../CSV_Files/Driver/driver.csv"), true))
                {
                    while (csv.ReadNextRecord())
                    {
                        if (csv["Flag"] == "1")
                        {
                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                            ServicePointManager.ServerCertificateValidationCallback +=
                                (sender, certificate, chain, sslPolicyErrors) => true;

                            var apiName = csv["fileName"];
                            SampleCode.RunMethod(apiName);
                        }
                    }
                }

                // Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message);
                //Console.WriteLine("Inside erro");
                //Console.ReadLine();
            }
        }
    }
}