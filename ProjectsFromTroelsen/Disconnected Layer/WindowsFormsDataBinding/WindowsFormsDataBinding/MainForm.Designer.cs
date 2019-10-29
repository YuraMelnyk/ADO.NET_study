namespace WindowsFormsDataBinding
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
            this.label1 = new System.Windows.Forms.Label();
            this.carInventoryGridView = new System.Windows.Forms.DataGridView();
            this.deleteBox = new System.Windows.Forms.GroupBox();
            this.txtRowToRemove = new System.Windows.Forms.TextBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplayMakes = new System.Windows.Forms.Button();
            this.txtMakeToView = new System.Windows.Forms.TextBox();
            this.changeGroupBox = new System.Windows.Forms.GroupBox();
            this.btnChangePetName = new System.Windows.Forms.Button();
            this.txtChangePetName = new System.Windows.Forms.TextBox();
            this.filterGridView = new System.Windows.Forms.DataGridView();
            this.labelForFind = new System.Windows.Forms.Label();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFindBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
            this.deleteBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.changeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGridView)).BeginInit();
            this.findGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here is what we have in stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // carInventoryGridView
            // 
            this.carInventoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carInventoryGridView.Location = new System.Drawing.Point(25, 87);
            this.carInventoryGridView.Name = "carInventoryGridView";
            this.carInventoryGridView.RowHeadersWidth = 51;
            this.carInventoryGridView.RowTemplate.Height = 24;
            this.carInventoryGridView.Size = new System.Drawing.Size(711, 250);
            this.carInventoryGridView.TabIndex = 1;
            // 
            // deleteBox
            // 
            this.deleteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBox.Controls.Add(this.btnRemoveRow);
            this.deleteBox.Controls.Add(this.txtRowToRemove);
            this.deleteBox.Location = new System.Drawing.Point(25, 343);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(333, 93);
            this.deleteBox.TabIndex = 2;
            this.deleteBox.TabStop = false;
            this.deleteBox.Text = "Enter ID of Car to Delete";
            // 
            // txtRowToRemove
            // 
            this.txtRowToRemove.Location = new System.Drawing.Point(17, 42);
            this.txtRowToRemove.Name = "txtRowToRemove";
            this.txtRowToRemove.Size = new System.Drawing.Size(186, 22);
            this.txtRowToRemove.TabIndex = 0;
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(210, 40);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(106, 23);
            this.btnRemoveRow.TabIndex = 1;
            this.btnRemoveRow.Text = "Delete";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDisplayMakes);
            this.groupBox1.Controls.Add(this.txtMakeToView);
            this.groupBox1.Location = new System.Drawing.Point(395, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Make of Car to View";
            // 
            // btnDisplayMakes
            // 
            this.btnDisplayMakes.Location = new System.Drawing.Point(210, 40);
            this.btnDisplayMakes.Name = "btnDisplayMakes";
            this.btnDisplayMakes.Size = new System.Drawing.Size(106, 23);
            this.btnDisplayMakes.TabIndex = 1;
            this.btnDisplayMakes.Text = "View!";
            this.btnDisplayMakes.UseVisualStyleBackColor = true;
            this.btnDisplayMakes.Click += new System.EventHandler(this.btnDisplayMakes_Click);
            // 
            // txtMakeToView
            // 
            this.txtMakeToView.Location = new System.Drawing.Point(17, 42);
            this.txtMakeToView.Name = "txtMakeToView";
            this.txtMakeToView.Size = new System.Drawing.Size(186, 22);
            this.txtMakeToView.TabIndex = 0;
            // 
            // changeGroupBox
            // 
            this.changeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeGroupBox.Controls.Add(this.btnChangePetName);
            this.changeGroupBox.Controls.Add(this.txtChangePetName);
            this.changeGroupBox.Location = new System.Drawing.Point(25, 456);
            this.changeGroupBox.Name = "changeGroupBox";
            this.changeGroupBox.Size = new System.Drawing.Size(333, 93);
            this.changeGroupBox.TabIndex = 4;
            this.changeGroupBox.TabStop = false;
            this.changeGroupBox.Text = "Enter ID of Car to Change PetName to NoName";
            // 
            // btnChangePetName
            // 
            this.btnChangePetName.Location = new System.Drawing.Point(210, 40);
            this.btnChangePetName.Name = "btnChangePetName";
            this.btnChangePetName.Size = new System.Drawing.Size(106, 23);
            this.btnChangePetName.TabIndex = 1;
            this.btnChangePetName.Text = "Change";
            this.btnChangePetName.UseVisualStyleBackColor = true;
            this.btnChangePetName.Click += new System.EventHandler(this.btnChangePetName_Click);
            // 
            // txtChangePetName
            // 
            this.txtChangePetName.Location = new System.Drawing.Point(17, 42);
            this.txtChangePetName.Name = "txtChangePetName";
            this.txtChangePetName.Size = new System.Drawing.Size(186, 22);
            this.txtChangePetName.TabIndex = 0;
            // 
            // filterGridView
            // 
            this.filterGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterGridView.Location = new System.Drawing.Point(25, 619);
            this.filterGridView.Name = "filterGridView";
            this.filterGridView.RowHeadersWidth = 51;
            this.filterGridView.RowTemplate.Height = 24;
            this.filterGridView.Size = new System.Drawing.Size(711, 158);
            this.filterGridView.TabIndex = 5;
            this.filterGridView.Visible = false;
            // 
            // labelForFind
            // 
            this.labelForFind.AutoSize = true;
            this.labelForFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelForFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForFind.Location = new System.Drawing.Point(33, 567);
            this.labelForFind.Name = "labelForFind";
            this.labelForFind.Size = new System.Drawing.Size(227, 29);
            this.labelForFind.TabIndex = 6;
            this.labelForFind.Text = "Here all cars from ";
            this.labelForFind.Visible = false;
            // 
            // findGroupBox
            // 
            this.findGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findGroupBox.Controls.Add(this.btnFind);
            this.findGroupBox.Controls.Add(this.txtFindBox);
            this.findGroupBox.Location = new System.Drawing.Point(396, 456);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(340, 93);
            this.findGroupBox.TabIndex = 7;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Enter Make of Car to Find all cars";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(210, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(106, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFindBox
            // 
            this.txtFindBox.Location = new System.Drawing.Point(17, 42);
            this.txtFindBox.Name = "txtFindBox";
            this.txtFindBox.Size = new System.Drawing.Size(186, 22);
            this.txtFindBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 783);
            this.Controls.Add(this.findGroupBox);
            this.Controls.Add(this.labelForFind);
            this.Controls.Add(this.filterGridView);
            this.Controls.Add(this.changeGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.carInventoryGridView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "Windows Forms Data Binding";
            ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
            this.deleteBox.ResumeLayout(false);
            this.deleteBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.changeGroupBox.ResumeLayout(false);
            this.changeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGridView)).EndInit();
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView carInventoryGridView;
        private System.Windows.Forms.GroupBox deleteBox;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.TextBox txtRowToRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplayMakes;
        private System.Windows.Forms.TextBox txtMakeToView;
        private System.Windows.Forms.GroupBox changeGroupBox;
        private System.Windows.Forms.Button btnChangePetName;
        private System.Windows.Forms.TextBox txtChangePetName;
        private System.Windows.Forms.DataGridView filterGridView;
        private System.Windows.Forms.Label labelForFind;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFindBox;
    }
}

