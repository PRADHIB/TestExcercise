using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Configuration;

namespace FileData
{
    public static class Program
    {

        private static string ReadConfigKeys(string Key)
        {
            return ConfigurationSettings.AppSettings.Get(Key).ToString();
        }

        public static string ReturnFileInformation(string fileOption, string filePath)
        {
            string fileInformation = "";
            FileDetails fileDetails = new FileDetails();
            var fileSize = Program.ReadConfigKeys("size");

            if (fileSize.Split(',').Contains(fileOption))
            {
                fileInformation = fileDetails.Size(filePath).ToString();

            }
            else
            {
                var fileVersion = Program.ReadConfigKeys("version");
                if (fileVersion.Split(',').Contains(fileOption))
                {
                    fileInformation = fileDetails.Version(filePath).ToString();
                }
            }

            return fileInformation;

        }


        public static void Main(string[] args)
        {
            try
            {
                string fileInfo = Program.ReturnFileInformation(args[0], args[1]);
                Console.WriteLine(fileInfo);
                Console.Read();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }



    }
}
