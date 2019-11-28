using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public void ByVehicleType(Vehicle.Vehicletype type, DataGridView dgv)
        {
            DataGridViewRowCollection collection = dgv.Rows;
            dgv.CurrentCell = null;

            for (int i = 0; i < Administrator.listaVehiculos.Count; i++)
            {
                collection[i].Visible = true;

                if (Administrator.listaVehiculos[i].Type != type)
                {
                    collection[i].Visible = false;
                }
            }
        }

        public List<Vehicle> ByOwner(string name)
        {
            name = name.ToLower();

            List<Vehicle> list = new List<Vehicle>();

            foreach (var item in Administrator.listaVehiculos)
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

            return Administrator.listaVehiculos;
        }

        public void ByLisencePlate(licensePlatePrefix licensePlatePrefix, DataGridView dgv)
        {
            DataGridViewRowCollection collection = dgv.Rows;
            dgv.CurrentCell = null;

            int counter = 0;

            for (int i = 0; i < Administrator.listaVehiculos.Count; i++)
            {
                collection[i].Visible = true;

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
                        if (licensePlatePrefixChar != Administrator.listaVehiculos[i].LicensePlate[1])
                        {
                            collection[i].Visible = false;
                            counter++;
                        }

                        break;
                    case licensePlatePrefixLevel.two:

                        string licenPlaceFirstTwoChars 
                            =  Administrator.listaVehiculos[i].LicensePlate[1].ToString() 
                            +  Administrator.listaVehiculos[i].LicensePlate[2].ToString();

                        if (licensePlatePrefixString != licenPlaceFirstTwoChars)
                        {
                            collection[i].Visible = false;
                            counter++;
                        }

                        break;
                    case licensePlatePrefixLevel.tree:

                        string licenPlaceFirstThreeChars
                            =  Administrator.listaVehiculos[i].LicensePlate[1].ToString()
                            +  Administrator.listaVehiculos[i].LicensePlate[2].ToString()
                            +  Administrator.listaVehiculos[i].LicensePlate[3].ToString();

                        if (licensePlatePrefixString != licenPlaceFirstThreeChars)
                        {
                            collection[i].Visible = false;
                            counter++;
                        }

                        break;
                }
            }
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
