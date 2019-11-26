using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueoAdministrator
{
    public sealed class FileManager
    {
        public static int counter = 0;
        private static readonly string currentDirectory = Directory.GetCurrentDirectory();
        private readonly string ParkingPath = currentDirectory + "//parkings" ;

        public FileManager()
        {
            counter++;
        }

        public void CreateParkingFile(string name)
        {
            // create just once
            if (counter < 2)
            {
                _ = Directory.CreateDirectory(ParkingPath);
            }

            _ = File.Create(ParkingPath + "//" + name);
        }
    }
}
