using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static proyectoLibrary.Modelos.Vehicle;

namespace ParqueoAdministrator
{
    public sealed class Filter
    {
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

        public void ByOwner(string name, DataGridView dgv)
        {
            DataGridViewRowCollection collection = dgv.Rows;
            dgv.CurrentCell = null;

            name = name.ToLower();

            List<int> list = new List<int>();

            for (int i = 0; i < Administrator.listaVehiculos.Count; i++)
            {
                if (name == String.Empty)
                {
                    list.Add(i);
                }

                else
                {
                    collection[i].Visible = false;

                    string[] ownerArray = Administrator.listaVehiculos[i].Owner.ToLower().Split();

                    for (int j = 0; j < ownerArray.Length; j++)
                    {
                        if (name == ownerArray[j])
                        {
                            list.Add(i);
                        }
                    }
                }
            }

            foreach (var item in list)
            {
                collection[item].Visible = true;
            }
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

                        if (licensePlatePrefixChar != Administrator.listaVehiculos[i].LicensePlate[0])
                        {
                            collection[i].Visible = false;
                            counter++;
                        }

                        break;
                    case licensePlatePrefixLevel.two:

                        string licenPlaceFirstTwoChars
                            = Administrator.listaVehiculos[i].LicensePlate[1].ToString()
                            + Administrator.listaVehiculos[i].LicensePlate[2].ToString();

                        if (licensePlatePrefixString != licenPlaceFirstTwoChars)
                        {
                            collection[i].Visible = false;
                            counter++;
                        }

                        break;
                    case licensePlatePrefixLevel.tree:

                        string licenPlaceFirstThreeChars
                            = Administrator.listaVehiculos[i].LicensePlate[1].ToString()
                            + Administrator.listaVehiculos[i].LicensePlate[2].ToString()
                            + Administrator.listaVehiculos[i].LicensePlate[3].ToString();

                        if (licensePlatePrefixString != licenPlaceFirstThreeChars)
                        {
                            collection[i].Visible = false;
                            counter++;
                        }

                        break;
                }
            }
        }

        private licensePlatePrefixLevel GetLicensePlatePrefixLevel(licensePlatePrefix licensePlatePrefix)
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
