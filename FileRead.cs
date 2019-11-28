using proyectoLibrary.Modelos;
using System.Collections.Generic;
using System.IO;

namespace ParqueoAdministrator
{
    public sealed class FileRead
    {
        public string Path { get; set; }
        private List<Vehicle> list = new List<Vehicle>();

        public List<Vehicle> ReadFile()
        {
            string line;
            StreamReader streamReader = new StreamReader(Path);

            string _owner;
            int OwnderIDInt = -10;
            byte _ownerID = 0;
            Vehicle.Vehicletype _type;
            string _licensePlate, _parking;

            while ((line = streamReader.ReadLine()) != null)
            {

                string[] lineArray = line.ToString().Split(',');

                _owner = lineArray[0] is null ? "" : lineArray[0];

                byte.TryParse(lineArray[1], out _ownerID);

                if (OwnderIDInt * _ownerID == 0)
                {
                    _ownerID = 0;
                }

                _type = (Vehicle.Vehicletype)int.Parse(lineArray[2]);
                _licensePlate = lineArray[0] is null ? "" : lineArray[3];
                _parking = lineArray[0] is null ? "" : lineArray[4];

                Vehicle vehicle = new Vehicle(_owner, _ownerID, _type, _licensePlate, _parking);
                list.Add(vehicle);
            }

            streamReader.Close();

            return list;
        }

    }
}
