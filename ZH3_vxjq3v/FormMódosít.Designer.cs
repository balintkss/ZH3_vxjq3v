namespace ZH3_vxjq3v
{
    partial class FormMódosít
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.engineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberSeaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelerationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTípus = new System.Windows.Forms.TextBox();
            this.textBoxÉv = new System.Windows.Forms.TextBox();
            this.textBoxVégsebesség = new System.Windows.Forms.TextBox();
            this.textBox0100 = new System.Windows.Forms.TextBox();
            this.radioButton5ülés = new System.Windows.Forms.RadioButton();
            this.radioButton4ülés = new System.Windows.Forms.RadioButton();
            this.buttonTípus = new System.Windows.Forms.Button();
            this.buttonTöröl = new System.Windows.Forms.Button();
            this.buttonHozzáad = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.bodyTypeIdDataGridViewTextBoxColumn,
            this.engineIdDataGridViewTextBoxColumn,
            this.numberSeaterDataGridViewTextBoxColumn,
            this.accelerationDataGridViewTextBoxColumn,
            this.maxSpeedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // bodyTypeIdDataGridViewTextBoxColumn
            // 
            this.bodyTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BodyTypeId";
            this.bodyTypeIdDataGridViewTextBoxColumn.DataSource = this.bodyBindingSource;
            this.bodyTypeIdDataGridViewTextBoxColumn.DisplayMember = "BodyType";
            this.bodyTypeIdDataGridViewTextBoxColumn.HeaderText = "BodyTypeId";
            this.bodyTypeIdDataGridViewTextBoxColumn.Name = "bodyTypeIdDataGridViewTextBoxColumn";
            this.bodyTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bodyTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bodyTypeIdDataGridViewTextBoxColumn.ValueMember = "BodyTypeId";
            // 
            // bodyBindingSource
            // 
            this.bodyBindingSource.DataSource = typeof(ZH3_vxjq3v.Models.Body);
            // 
            // engineIdDataGridViewTextBoxColumn
            // 
            this.engineIdDataGridViewTextBoxColumn.DataPropertyName = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.DataSource = this.engineBindingSource;
            this.engineIdDataGridViewTextBoxColumn.DisplayMember = "EngineType";
            this.engineIdDataGridViewTextBoxColumn.HeaderText = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.Name = "engineIdDataGridViewTextBoxColumn";
            this.engineIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.engineIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.engineIdDataGridViewTextBoxColumn.ValueMember = "EngineId";
            // 
            // engineBindingSource
            // 
            this.engineBindingSource.DataSource = typeof(ZH3_vxjq3v.Models.Engine);
            // 
            // numberSeaterDataGridViewTextBoxColumn
            // 
            this.numberSeaterDataGridViewTextBoxColumn.DataPropertyName = "NumberSeater";
            this.numberSeaterDataGridViewTextBoxColumn.HeaderText = "NumberSeater";
            this.numberSeaterDataGridViewTextBoxColumn.Name = "numberSeaterDataGridViewTextBoxColumn";
            // 
            // accelerationDataGridViewTextBoxColumn
            // 
            this.accelerationDataGridViewTextBoxColumn.DataPropertyName = "Acceleration";
            this.accelerationDataGridViewTextBoxColumn.HeaderText = "Acceleration";
            this.accelerationDataGridViewTextBoxColumn.Name = "accelerationDataGridViewTextBoxColumn";
            // 
            // maxSpeedDataGridViewTextBoxColumn
            // 
            this.maxSpeedDataGridViewTextBoxColumn.DataPropertyName = "MaxSpeed";
            this.maxSpeedDataGridViewTextBoxColumn.HeaderText = "MaxSpeed";
            this.maxSpeedDataGridViewTextBoxColumn.Name = "maxSpeedDataGridViewTextBoxColumn";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataSource = typeof(ZH3_vxjq3v.Models.Cars);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTípus);
            this.groupBox1.Controls.Add(this.textBoxÉv);
            this.groupBox1.Controls.Add(this.textBoxVégsebesség);
            this.groupBox1.Controls.Add(this.textBox0100);
            this.groupBox1.Controls.Add(this.radioButton5ülés);
            this.groupBox1.Controls.Add(this.radioButton4ülés);
            this.groupBox1.Controls.Add(this.buttonTípus);
            this.groupBox1.Controls.Add(this.buttonTöröl);
            this.groupBox1.Controls.Add(this.buttonHozzáad);
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Végsebesség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "0-100 gyorsulás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Évjárat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Típus";
            // 
            // textBoxTípus
            // 
            this.textBoxTípus.Location = new System.Drawing.Point(105, 35);
            this.textBoxTípus.Name = "textBoxTípus";
            this.textBoxTípus.Size = new System.Drawing.Size(100, 23);
            this.textBoxTípus.TabIndex = 7;
            this.textBoxTípus.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTípus_Validating);
            this.textBoxTípus.Validated += new System.EventHandler(this.textBoxTípus_Validated);
            // 
            // textBoxÉv
            // 
            this.textBoxÉv.Location = new System.Drawing.Point(105, 70);
            this.textBoxÉv.Name = "textBoxÉv";
            this.textBoxÉv.Size = new System.Drawing.Size(100, 23);
            this.textBoxÉv.TabIndex = 6;
            this.textBoxÉv.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxÉv_Validating_1);
            this.textBoxÉv.Validated += new System.EventHandler(this.textBoxÉv_Validated_1);
            // 
            // textBoxVégsebesség
            // 
            this.textBoxVégsebesség.Location = new System.Drawing.Point(392, 73);
            this.textBoxVégsebesség.Name = "textBoxVégsebesség";
            this.textBoxVégsebesség.Size = new System.Drawing.Size(100, 23);
            this.textBoxVégsebesség.TabIndex = 5;
            // 
            // textBox0100
            // 
            this.textBox0100.Location = new System.Drawing.Point(392, 32);
            this.textBox0100.Name = "textBox0100";
            this.textBox0100.Size = new System.Drawing.Size(100, 23);
            this.textBox0100.TabIndex = 2;
            // 
            // radioButton5ülés
            // 
            this.radioButton5ülés.AutoSize = true;
            this.radioButton5ülés.Location = new System.Drawing.Point(226, 74);
            this.radioButton5ülés.Name = "radioButton5ülés";
            this.radioButton5ülés.Size = new System.Drawing.Size(66, 19);
            this.radioButton5ülés.TabIndex = 4;
            this.radioButton5ülés.TabStop = true;
            this.radioButton5ülés.Text = "5 üléses";
            this.radioButton5ülés.UseVisualStyleBackColor = true;
            // 
            // radioButton4ülés
            // 
            this.radioButton4ülés.AutoSize = true;
            this.radioButton4ülés.Location = new System.Drawing.Point(226, 36);
            this.radioButton4ülés.Name = "radioButton4ülés";
            this.radioButton4ülés.Size = new System.Drawing.Size(66, 19);
            this.radioButton4ülés.TabIndex = 3;
            this.radioButton4ülés.TabStop = true;
            this.radioButton4ülés.Text = "4 üléses";
            this.radioButton4ülés.UseVisualStyleBackColor = true;
            // 
            // buttonTípus
            // 
            this.buttonTípus.Location = new System.Drawing.Point(684, 27);
            this.buttonTípus.Name = "buttonTípus";
            this.buttonTípus.Size = new System.Drawing.Size(86, 66);
            this.buttonTípus.TabIndex = 2;
            this.buttonTípus.Text = "Új fajta típus hozzáadása";
            this.buttonTípus.UseVisualStyleBackColor = true;
            this.buttonTípus.Click += new System.EventHandler(this.buttonTípus_Click);
            // 
            // buttonTöröl
            // 
            this.buttonTöröl.Location = new System.Drawing.Point(603, 27);
            this.buttonTöröl.Name = "buttonTöröl";
            this.buttonTöröl.Size = new System.Drawing.Size(75, 66);
            this.buttonTöröl.TabIndex = 1;
            this.buttonTöröl.Text = "-";
            this.buttonTöröl.UseVisualStyleBackColor = true;
            this.buttonTöröl.Click += new System.EventHandler(this.buttonTöröl_Click_1);
            // 
            // buttonHozzáad
            // 
            this.buttonHozzáad.Location = new System.Drawing.Point(522, 27);
            this.buttonHozzáad.Name = "buttonHozzáad";
            this.buttonHozzáad.Size = new System.Drawing.Size(75, 66);
            this.buttonHozzáad.TabIndex = 0;
            this.buttonHozzáad.Text = "+";
            this.buttonHozzáad.UseVisualStyleBackColor = true;
            this.buttonHozzáad.Click += new System.EventHandler(this.buttonHozzáad_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMódosít
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMódosít";
            this.Text = "FormMódosít";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxTípus;
        private TextBox textBoxÉv;
        private TextBox textBoxVégsebesség;
        private TextBox textBox0100;
        private RadioButton radioButton5ülés;
        private RadioButton radioButton4ülés;
        private Button buttonTípus;
        private Button buttonTöröl;
        private Button buttonHozzáad;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn bodyTypeIdDataGridViewTextBoxColumn;
        private BindingSource bodyBindingSource;
        private DataGridViewComboBoxColumn engineIdDataGridViewTextBoxColumn;
        private BindingSource engineBindingSource;
        private DataGridViewTextBoxColumn numberSeaterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accelerationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxSpeedDataGridViewTextBoxColumn;
        private BindingSource carsBindingSource;
        private ErrorProvider errorProvider1;
    }
}