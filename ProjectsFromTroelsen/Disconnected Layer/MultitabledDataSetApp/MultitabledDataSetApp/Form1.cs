using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace MultitabledDataSetApp
{
    public partial class MainForm : Form
    {
        private DataSet _autoLotDS = new DataSet("AutoLot");

        private SqlCommandBuilder _sqlCbInventory;
        private SqlCommandBuilder _sqlCbCustumer;
        private SqlCommandBuilder _sqlCbOrder;

        private SqlDataAdapter _invTableAdapter;
        private SqlDataAdapter _custTableAdapter;
        private SqlDataAdapter _ordersTableAdapter;

        private string _connectionString;
        public MainForm()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

            _invTableAdapter = new SqlDataAdapter("Select * From Inventory", _connectionString);
            _custTableAdapter = new SqlDataAdapter("Select * From Custumers", _connectionString);
            _ordersTableAdapter = new SqlDataAdapter("Select * From [Order]", _connectionString);

            _sqlCbInventory = new SqlCommandBuilder(_invTableAdapter);
            _sqlCbCustumer = new SqlCommandBuilder(_custTableAdapter);
            _sqlCbOrder = new SqlCommandBuilder(_ordersTableAdapter);

            _invTableAdapter.Fill(_autoLotDS, "Inventory");
            _custTableAdapter.Fill(_autoLotDS, "Custumers");
            _ordersTableAdapter.Fill(_autoLotDS, "Order");

            BuildTableRelationship();

            inventoryGrid.DataSource = _autoLotDS.Tables["Inventory"];
            custumerGrid.DataSource = _autoLotDS.Tables["Custumers"];
            orderGrid.DataSource = _autoLotDS.Tables["Order"];

        }

        private void BuildTableRelationship()
        {
            DataRelation dr = new DataRelation("CustumerOrder",
                _autoLotDS.Tables["Custumers"].Columns["CustId"],
                _autoLotDS.Tables["Order"].Columns["CustId"]);
            _autoLotDS.Relations.Add(dr);

            dr = new DataRelation("InventoryOrder",
                _autoLotDS.Tables["Inventory"].Columns["CarId"],
                _autoLotDS.Tables["Order"].Columns["CarID"]);
            _autoLotDS.Relations.Add(dr);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                _invTableAdapter.Update(_autoLotDS, "Inventory");
                _custTableAdapter.Update(_autoLotDS, "Custumers");
                _ordersTableAdapter.Update(_autoLotDS, "Order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            string strOrderInfo = string.Empty;
            int custId = int.Parse(txtCusIdOrderDetails.Text);

            var drsCust = _autoLotDS.Tables["Custumers"].Select($"CustId = {custId}");
            strOrderInfo += $"Custumer {drsCust[0]["CustId"]}:" +
                $" {drsCust[0]["FirstName"].ToString().Trim()}" +
                $" {drsCust[0]["LastName"].ToString().Trim()}\n";
            var drsOrder = drsCust[0].GetChildRows(_autoLotDS.Relations["CustumerOrder"]);

            foreach (DataRow order in drsOrder)
            {
                strOrderInfo += $"---\nOrder Number: {order["OrderId"]}\n";
                DataRow[] drsInv = order.GetParentRows(_autoLotDS.Relations["InventoryOrder"]);
                DataRow car = drsInv[0];

                strOrderInfo += $"Make: {car["Make"]}\n";
                strOrderInfo += $"Color: {car["Color"]}\n";
                strOrderInfo += $"PetName: {car["PetName"]}\n";
            }
            MessageBox.Show(strOrderInfo, "Order Details");
        }
    }
}
