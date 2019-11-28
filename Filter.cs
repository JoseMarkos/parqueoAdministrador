using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;

namespace ParqueoAdministrator
{
    public sealed class Filter
    {
        #region Enums

        public enum licensePlatePrefix
        {
            A,
            C,
            CC,
            CD,
            DIS,
            E,
            EXT,
            M,
            MI,
            O,
            P,
            TC,
            TRC,
            U
        }

        public enum licensePlatePrefixLevel
        {
            one = 1,
            two = 2,
            tree = 3
        }

        #endregion
        public List<Vehicle> ByVehicleType(Vehicle.Vehicletype type)
        {
            List<Vehicle> list = new List<Vehicle>();

            foreach (var item in Form1.listaVehiculos)
            {
                if (item.Type == type)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public List<Vehicle> ByOwner(string name)
        {
            name = name.ToLower();

            List<Vehicle> list = new List<Vehicle>();

            foreach (var item in Form1.listaVehiculos)
            {
                string[] ownerArray = item.Owner.ToLower().Split();

                for (int i = 0; i < ownerArray.Length; i++)
                {
                    if (name == ownerArray[i])
                    {
                        list.Add(item);
                    }
                }
            }

            if (list.Count > 0)
            {
                return list;
            }

            return Form1.listaVehiculos;
        }

        public List<Vehicle> ByLisencePlate(licensePlatePrefix licensePlatePrefix)
        {
            List<Vehicle> list = new List<Vehicle>();

            foreach (var item in Form1.listaVehiculos)
            {
                licensePlatePrefixLevel prefixLevel = GetLicensePlatePrefixLevel(licensePlatePrefix);

                #region For two and three cases

                string licensePlatePrefixString = licensePlatePrefix.ToString();

                #endregion


                switch (prefixLevel)
                {
                    case licensePlatePrefixLevel.one:

                        char licensePlatePrefixChar = Convert.ToChar(licensePlatePrefix.ToString());

                        // index 1 because of white space in the file:
                        // propN, propN+1
                        if (licensePlatePrefixChar == item.LicensePlate[1])
                        {
                            list.Add(item);
                        }

                        break;
                    case licensePlatePrefixLevel.two:

                        string licenPlaceFirstTwoChars = item.LicensePlate[1].ToString() + item.LicensePlate[2].ToString();

                        if (licensePlatePrefixString == licenPlaceFirstTwoChars)
                        {
                            list.Add(item);
                        }

                        break;
                    case licensePlatePrefixLevel.tree:

                        string licenPlaceFirstThreeChars
                            = item.LicensePlate[1].ToString()
                            + item.LicensePlate[2].ToString()
                            + item.LicensePlate[3].ToString();

                        if (licensePlatePrefixString == licenPlaceFirstThreeChars)
                        {
                            list.Add(item);
                        }

                        break;
                }
            }

            if (list.Count > 0)
            {
                return list;
            }

            return Form1.listaVehiculos;
        }

        public licensePlatePrefixLevel GetLicensePlatePrefixLevel(licensePlatePrefix licensePlatePrefix)
        {
            switch (licensePlatePrefix)
            {
                case licensePlatePrefix.CC:
                    return licensePlatePrefixLevel.two;
                case licensePlatePrefix.CD:
                    return licensePlatePrefixLevel.two;
                case licensePlatePrefix.DIS:
                    return licensePlatePrefixLevel.tree;
                case licensePlatePrefix.EXT:
                    return licensePlatePrefixLevel.tree;
                case licensePlatePrefix.MI:
                    return licensePlatePrefixLevel.two;
                case licensePlatePrefix.TC:
                    return licensePlatePrefixLevel.two;
                case licensePlatePrefix.TRC:
                    return licensePlatePrefixLevel.tree;
                default:
                    return licensePlatePrefixLevel.one;
            }
        }
    }
}
