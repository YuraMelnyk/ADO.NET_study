using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding
{
    public partial class MainForm : Form
    {
        List<Car> listCars = null;
        DataTable inventoryTable = new DataTable();
        DataView allMakeCars;

        public MainForm()
        {
            InitializeComponent();

            this.Size = new Size(600, 605);

            listCars = new List<Car>
            {
                new Car{Id = 1, PetName ="Chacky", Make = "BMW", Color = "Blue" },
                new Car{Id = 2, PetName ="Tiny", Make = "Yogo", Color = "White" },
                new Car{Id = 3, PetName ="Lola", Make = "Jeep", Color = "Black" },
                new Car{Id = 4, PetName ="Fred", Make = "BMW", Color = "Yelow" },
                new Car{Id = 5, PetName ="Baby", Make = "VW", Color = "Pink" },
                new Car{Id = 6, PetName ="Andriano", Make = "Fiat", Color = "Grey" },
                new Car{Id = 7, PetName ="Leny", Make = "Nissan", Color = "Black" },
                new Car{Id = 8, PetName ="Aid", Make = "Toyota", Color = "White" },
            };

            CreateDataTable();
        }

        void CreateDataTable()
        {
            var carIdColumn = new DataColumn("Id", typeof(int));
            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption = "Pet Name" };

            inventoryTable.Columns.AddRange(new[] { carIdColumn, carMakeColumn, carColorColumn, carPetNameColumn });

            foreach (var c in listCars)
            {
                var newRow = inventoryTable.NewRow();
                newRow["Id"] = c.Id;
                newRow["Make"] = c.Make;
                newRow["Color"] = c.Color;
                newRow["PetName"] = c.PetName;
                inventoryTable.Rows.Add(newRow);
            }

            carInventoryGridView.DataSource = inventoryTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowToDelete = inventoryTable.Select($"Id = {int.Parse(txtRowToRemove.Text)}");
                rowToDelete[0].Delete();
                inventoryTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayMakes_Click(object sender, EventArgs e)
        {
            string filterStr = $"Make = '{txtMakeToView.Text}'";
            DataRow[] makes = inventoryTable.Select(filterStr, "PetName DESC");
            if (makes.Length == 0)
            {
                MessageBox.Show("Sorry, no cars...", "Sellection error!");
            }
            else
            {
                string strMake = null;
                for (int i = 0; i < makes.Length; i++)
                {
                    strMake += makes[i]["PetName"] + "\n";
                }
                MessageBox.Show(strMake, $"We have {txtMakeToView.Text}s named: ");
            }
        }

        private void btnChangePetName_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Are You Sure??? Change this PetName???","Please Confirm!",MessageBoxButtons.YesNo))
            {
                return;
            }

            try
            {
                DataRow[] rowToChange = inventoryTable.Select($"Id = {int.Parse(txtChangePetName.Text)}");
                rowToChange[0]["PetName"] = "NoName";
                inventoryTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            allMakeCars = new DataView(inventoryTable);
            try
            {
                string strFilter = txtFindBox.Text;
                allMakeCars.RowFilter = $"Make = '{strFilter}'";

                this.Size = new Size(600, 830);

                labelForFind.Visible = true;
                labelForFind.Text += strFilter;

                filterGridView.Visible = true;
                filterGridView.DataSource = allMakeCars;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
