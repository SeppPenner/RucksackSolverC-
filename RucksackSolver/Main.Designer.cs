namespace RucksackSolver
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelB = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.comboBoxChooseType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelK = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.labelK = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.tableLayoutPanelK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadConfig.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(299, 24);
            this.buttonLoadConfig.TabIndex = 0;
            this.buttonLoadConfig.Text = "Load config file";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculate.Location = new System.Drawing.Point(3, 123);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(299, 27);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonLoadConfig, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelB, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxChooseType, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonCalculate, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelK, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(305, 153);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // tableLayoutPanelB
            // 
            this.tableLayoutPanelB.ColumnCount = 2;
            this.tableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelB.Controls.Add(this.numericUpDownB, 1, 0);
            this.tableLayoutPanelB.Controls.Add(this.labelB, 0, 0);
            this.tableLayoutPanelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelB.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanelB.Name = "tableLayoutPanelB";
            this.tableLayoutPanelB.RowCount = 1;
            this.tableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelB.Size = new System.Drawing.Size(299, 24);
            this.tableLayoutPanelB.TabIndex = 3;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownB.Location = new System.Drawing.Point(152, 3);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(144, 20);
            this.numericUpDownB.TabIndex = 2;
            this.numericUpDownB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Location = new System.Drawing.Point(3, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(143, 24);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Select B:";
            // 
            // comboBoxChooseType
            // 
            this.comboBoxChooseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseType.FormattingEnabled = true;
            this.comboBoxChooseType.Items.AddRange(new object[] {
            "Dynamic programming",
            "Dynamic programming - FPTAS"});
            this.comboBoxChooseType.Location = new System.Drawing.Point(3, 63);
            this.comboBoxChooseType.Name = "comboBoxChooseType";
            this.comboBoxChooseType.Size = new System.Drawing.Size(299, 21);
            this.comboBoxChooseType.TabIndex = 4;
            this.comboBoxChooseType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseType_SelectedIndexChanged);
            // 
            // tableLayoutPanelK
            // 
            this.tableLayoutPanelK.ColumnCount = 2;
            this.tableLayoutPanelK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelK.Controls.Add(this.numericUpDownK, 0, 0);
            this.tableLayoutPanelK.Controls.Add(this.labelK, 0, 0);
            this.tableLayoutPanelK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelK.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanelK.Name = "tableLayoutPanelK";
            this.tableLayoutPanelK.RowCount = 1;
            this.tableLayoutPanelK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelK.Size = new System.Drawing.Size(299, 24);
            this.tableLayoutPanelK.TabIndex = 5;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownK.Location = new System.Drawing.Point(152, 3);
            this.numericUpDownK.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(144, 20);
            this.numericUpDownK.TabIndex = 5;
            this.numericUpDownK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelK.Location = new System.Drawing.Point(3, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(143, 24);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "Select K:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 153);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelB.ResumeLayout(false);
            this.tableLayoutPanelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.tableLayoutPanelK.ResumeLayout(false);
            this.tableLayoutPanelK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.ComboBox comboBoxChooseType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelK;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.Label labelK;
    }
}

