namespace MultitabledDataSetApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.custumerGrid = new System.Windows.Forms.DataGridView();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.labelInventoryGrid = new System.Windows.Forms.Label();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.labelOrderGrid = new System.Windows.Forms.Label();
            this.labelCastumerGrid = new System.Windows.Forms.Label();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusIdOrderDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Location = new System.Drawing.Point(12, 46);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.RowHeadersWidth = 51;
            this.inventoryGrid.RowTemplate.Height = 24;
            this.inventoryGrid.Size = new System.Drawing.Size(594, 150);
            this.inventoryGrid.TabIndex = 0;
            // 
            // custumerGrid
            // 
            this.custumerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custumerGrid.Location = new System.Drawing.Point(12, 234);
            this.custumerGrid.Name = "custumerGrid";
            this.custumerGrid.RowHeadersWidth = 51;
            this.custumerGrid.RowTemplate.Height = 24;
            this.custumerGrid.Size = new System.Drawing.Size(594, 150);
            this.custumerGrid.TabIndex = 1;
            // 
            // orderGrid
            // 
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Location = new System.Drawing.Point(12, 428);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowHeadersWidth = 51;
            this.orderGrid.RowTemplate.Height = 24;
            this.orderGrid.Size = new System.Drawing.Size(594, 150);
            this.orderGrid.TabIndex = 2;
            // 
            // labelInventoryGrid
            // 
            this.labelInventoryGrid.AutoSize = true;
            this.labelInventoryGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInventoryGrid.Location = new System.Drawing.Point(78, 18);
            this.labelInventoryGrid.Name = "labelInventoryGrid";
            this.labelInventoryGrid.Size = new System.Drawing.Size(162, 25);
            this.labelInventoryGrid.TabIndex = 3;
            this.labelInventoryGrid.Text = "Current Inventory";
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(471, 584);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(134, 44);
            this.btnUpdateDB.TabIndex = 6;
            this.btnUpdateDB.Text = "Update";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // labelOrderGrid
            // 
            this.labelOrderGrid.AutoSize = true;
            this.labelOrderGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderGrid.Location = new System.Drawing.Point(78, 400);
            this.labelOrderGrid.Name = "labelOrderGrid";
            this.labelOrderGrid.Size = new System.Drawing.Size(132, 25);
            this.labelOrderGrid.TabIndex = 7;
            this.labelOrderGrid.Text = "Current Order";
            // 
            // labelCastumerGrid
            // 
            this.labelCastumerGrid.AutoSize = true;
            this.labelCastumerGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCastumerGrid.Location = new System.Drawing.Point(78, 206);
            this.labelCastumerGrid.Name = "labelCastumerGrid";
            this.labelCastumerGrid.Size = new System.Drawing.Size(167, 25);
            this.labelCastumerGrid.TabIndex = 8;
            this.labelCastumerGrid.Text = "Current Custumer";
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(220, 584);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(134, 44);
            this.btnOrderDetails.TabIndex = 10;
            this.btnOrderDetails.Text = "Get Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Custumer ID";
            // 
            // txtCusIdOrderDetails
            // 
            this.txtCusIdOrderDetails.Location = new System.Drawing.Point(103, 595);
            this.txtCusIdOrderDetails.Name = "txtCusIdOrderDetails";
            this.txtCusIdOrderDetails.Size = new System.Drawing.Size(100, 22);
            this.txtCusIdOrderDetails.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 640);
            this.Controls.Add(this.txtCusIdOrderDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.labelCastumerGrid);
            this.Controls.Add(this.labelOrderGrid);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.labelInventoryGrid);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.custumerGrid);
            this.Controls.Add(this.inventoryGrid);
            this.Name = "MainForm";
            this.Text = "AutoLot Databaase Manipulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridView custumerGrid;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Label labelInventoryGrid;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Label labelOrderGrid;
        private System.Windows.Forms.Label labelCastumerGrid;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusIdOrderDetails;
    }
}

