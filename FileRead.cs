using proyectoLibrary.Modelos;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ParqueoAdministrator
{
    public sealed class FileRead
    {
        public string PathVehicle { get; set; }
        public string PathParking { get; set; }
        private List<Vehicle> listVehicles = new List<Vehicle>();
        private List<Parking> listParkings = new List<Parking>();
       
        public List<Vehicle> ReadVehicleFile()
        {
            string line;
            StreamReader streamReader = new StreamReader(PathVehicle);

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
                listVehicles.Add(vehicle);
            }

            streamReader.Close();

            return listVehicles;
        }

        public List<Parking> ReadParkingFile()
        {
            string line;
            StreamReader streamReader = new StreamReader(PathParking);

            string _name;
            Parking.ParkingQuadrant _parkingQuadrant;
            List<string> _services = new List<string>();
            byte _normal = 0;
            byte _big = 0;
            int Normal = -10;
            int Big = -10;

            while ((line = streamReader.ReadLine()) != null)
            {
                string[] lineArray = line.ToString().Split(',');

                _name = lineArray[0] is null ? "" : lineArray[0];
                _parkingQuadrant = (Parking.ParkingQuadrant)int.Parse(lineArray[1]);

                string[] servicesArray = lineArray[2].Split('|');
                servicesArray = servicesArray[1].Split();

                for (int i = 0; i < servicesArray.Length; i++)
                {
                    _services.Add(servicesArray[i]);
                }
                
                byte.TryParse(lineArray[3], out _normal);
                byte.TryParse(lineArray[4], out _big);

                //if (Normal * _normal == 0)
                //{
                //    _normal = 0;
                //}

                //if (Big * _big == 0)
                //{
                //    _big = 0;
                //}

                Parking parking = new Parking(_name, _parkingQuadrant, _services, _normal, _big);

                if (lineArray.Length == 6)
                {
                    byte _freeSpace = byte.Parse(lineArray[5]);

                    for (int i = 0; i < parking.Capacity - (int)_freeSpace; i++)
                    {
                        parking.DiscountFreeSpaces();
                    }
                }
                
                listParkings.Add(parking);
            }

            streamReader.Close();

            return listParkings;
        }
    }
}
