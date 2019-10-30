using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotDAL.DisconnectLayer;



namespace InventoryDALDC_GUI
{
    public partial class MainForm : Form
    {
        InventoryDALDC _dal = null;
        public MainForm()
        {
            
            InitializeComponent();
            string cnStr = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = AutoLot;" +
                "Integrated Security = True; Pooling = False";
            _dal = new InventoryDALDC(cnStr);
            inventoryGrid.DataSource = _dal.GetAllInventory();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            DataTable cangedDT = (DataTable)inventoryGrid.DataSource;
            try
            {
                _dal.UpdateInventory(cangedDT);
                inventoryGrid.DataSource = _dal.GetAllInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
