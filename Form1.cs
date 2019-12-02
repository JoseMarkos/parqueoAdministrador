using proyectoLibrary;
using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static proyectoLibrary.Modelos.Vehicle;

namespace ParqueoAdministrator
{
    public partial class Administrator : Form
    {
        public static List<Parking> ListaParqueos = new List<Parking>();
        public static List<Vehicle> listaVehiculos = new List<Vehicle>();
        private Filter filter = new Filter();
        private FileRead fileRead = new FileRead();
        private int rowId;
        private OpenFileDialog openFileDialog;

        private static string Year = DateTime.Now.Year.ToString();
        private static string Month = DateTime.Now.Month.ToString();
        private static string Day = DateTime.Now.Day.ToString();
        private static string CurrentVehiclesDirectory = Directory.GetCurrentDirectory() + "\\vehicles\\" + Year + "\\" + Month;
        private static string CurrentParkingsDirectory = Directory.GetCurrentDirectory() + "\\parkings\\" + Year + "\\" + Month;
        private static string CurrentVehiclesFile = CurrentVehiclesDirectory + "\\" + Day + ".txt";
        private static string CurrentParkingFile = CurrentParkingsDirectory + "\\" + Day + ".txt";

        public Administrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // open current day Vehicle file
          
            if (File.Exists(CurrentVehiclesFile))
            {
                fileRead.PathVehicle = CurrentVehiclesFile;

                listaVehiculos = fileRead.ReadVehicleFile();

                initDataGridViewSource();
            }

            else
            {
                labelNotification.Text = "Oh, there is not a vehicles file today. Try import instead.";
            }

            // Adding options to comboVehicleType filter

            comboVehicleType.Items.Add(Vehicle.Vehicletype.Sedan);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.Coupe);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.HatchBack);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.SUV);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.PickUp);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.Camioneta);

            // Adding options to comboTypeLicensePlate filter

            comboTypeLicensePlate.Items.Add(licensePlatePrefix.A);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.C);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.CC);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.CD);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.DIS);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.E);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.EXT);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.M);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.MI);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.O);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.P);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.TC);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.TRC);
            comboTypeLicensePlate.Items.Add(licensePlatePrefix.U);
        }

        private void initDataGridViewSource()
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = listaVehiculos
            };

            dgvVehiculos.DataSource = bindingSource;
            dgvVehiculos.Refresh();
            dgvVehiculos.CurrentCell = null;
        }

        private void initDataGridViewSource(List<Parking> list)
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = list
            };

            dgvParqueos.DataSource = bindingSource;
            dgvParqueos.Refresh();
            dgvParqueos.CurrentCell = null;
        }

        private void SelectVehiclePanel()
        {
            splitParking.Hide();
            splitMain.Show();
        }

        private void SelectParkingPanel()
        {
            if (File.Exists(CurrentParkingFile))
            {
                fileRead.PathParking = CurrentParkingFile;

                try
                {
                    ListaParqueos = fileRead.ReadParkingFile();
                }
                catch (Exception ex)
                {
                    labelNotification2.Text = ex.Message;
                }

                initDataGridViewSource(ListaParqueos);
            }
            else
            {
                if (ListaParqueos.Count < 1)
                {
                    labelNotification2.Text = "Oh, there is not a parking file today. Try import instead.";
                }
            }

            splitMain.Hide();
            splitParking.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectParkingPanel();
        }

        private void btnParqueos2_Click(object sender, EventArgs e)
        {
            SelectParkingPanel();
        }

        private void btnVehiculos2_Click(object sender, EventArgs e)
        {
            SelectVehiclePanel();
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            SelectVehiclePanel();
        }

        private void btnGetOut_Click(object sender, EventArgs e)
        {
            dgvVehiculos.Rows.RemoveAt(rowId);

            FileManager fileMaganer = new FileManager();

            fileMaganer.DeleteParkingFile(fileRead.PathVehicle);
            fileMaganer.WriteVehicleFile(listaVehiculos);

            if (comboVehicleType.SelectedItem != null)
            {
                filter.ByVehicleType((Vehicle.Vehicletype)comboVehicleType.SelectedItem, dgvVehiculos);
            }

            if (comboTypeLicensePlate.SelectedItem != null)
            {
                filter.ByLisencePlate((licensePlatePrefix)comboTypeLicensePlate.SelectedItem, dgvVehiculos);
            }

            if (txtFilterOwner.Text != "")
            {
                filter.ByOwner(txtFilterOwner.Text, dgvVehiculos);
            }
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowId = e.RowIndex;
        }

        #region Filter
        private void txtFilterOwner_TextChanged(object sender, EventArgs e)
        {
            filter.ByOwner(txtFilterOwner.Text, dgvVehiculos);
        }

        private void comboVehicleType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboVehicleType.SelectedItem != null)
            {
                filter.ByVehicleType((Vehicle.Vehicletype)comboVehicleType.SelectedItem, dgvVehiculos);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterOwner.Text = "";

            comboVehicleType.SelectedItem = null;
            comboVehicleType.Text = "Type";

            comboTypeLicensePlate.SelectedItem = null;
            comboTypeLicensePlate.Text = "License Plate Type";

            initDataGridViewSource();
        }

        private void comboTypeLicensePlate_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboTypeLicensePlate.SelectedItem != null)
            {
                filter.ByLisencePlate((licensePlatePrefix)comboTypeLicensePlate.SelectedItem, dgvVehiculos);
            }
        }

        #endregion

        private void btnOpenVehiclesFile_Click(object sender, EventArgs e)
        {
            labelNotification.Text = "";

            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    fileRead.PathVehicle = filePath;

                    listaVehiculos.Clear();

                    try {
                        listaVehiculos = fileRead.ReadVehicleFile();
                    }
                    catch (Exception ex)
                    {
                        labelNotification.Text = ex.Message;
                    }

                    initDataGridViewSource();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            labelNotification2.Text = "";
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    fileRead.PathParking = filePath;

                    ListaParqueos.Clear();

                    try
                    {
                        ListaParqueos = fileRead.ReadParkingFile();
                    }
                    catch (Exception ex)
                    {
                        labelNotification2.Text = ex.Message;
                    }

                    initDataGridViewSource(ListaParqueos);
                }
            }
        }
    }
}
