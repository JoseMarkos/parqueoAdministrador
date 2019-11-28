using System.IO;

namespace ParqueoAdministrator
{
    public sealed class FileManager
    {
        public static int counter = 0;
        private static readonly string currentDirectory = Directory.GetCurrentDirectory();
        private readonly string ParkingPath = currentDirectory + "//parkings";

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

        public void DeleteParkingFile(string name)
        {
            // create just once
            if (_ = File.Exists(ParkingPath + "//" + name))
            {
                File.Delete(ParkingPath + "//" + name);
            }

        }
    }
}
