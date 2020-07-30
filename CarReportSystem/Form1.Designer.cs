namespace CarReportSystem
{
    partial class dgvArticle
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerSerch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toyotaButton = new System.Windows.Forms.RadioButton();
            this.nissanButton = new System.Windows.Forms.RadioButton();
            this.othersButton = new System.Windows.Forms.RadioButton();
            this.subaruButton = new System.Windows.Forms.RadioButton();
            this.gaisyaButton = new System.Windows.Forms.RadioButton();
            this.hondaButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRepo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btCorrected = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.savSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.carReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202021DataSet = new CarReportSystem.infosys202021DataSet();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.tbmakerSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.carReportTableAdapter = new CarReportSystem.infosys202021DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202021DataSetTableAdapters.TableAdapterManager();
            this.btOR = new System.Windows.Forms.RadioButton();
            this.btAND = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202021DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerSerch
            // 
            this.dateTimePickerSerch.Location = new System.Drawing.Point(46, 93);
            this.dateTimePickerSerch.Name = "dateTimePickerSerch";
            this.dateTimePickerSerch.Size = new System.Drawing.Size(188, 19);
            this.dateTimePickerSerch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付：";
            // 
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(108, 64);
            this.cbRecorder.Name = "cbRecorder";
            this.cbRecorder.Size = new System.Drawing.Size(224, 20);
            this.cbRecorder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "メーカー：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "記録者：";
            // 
            // toyotaButton
            // 
            this.toyotaButton.AutoSize = true;
            this.toyotaButton.Location = new System.Drawing.Point(6, 18);
            this.toyotaButton.Name = "toyotaButton";
            this.toyotaButton.Size = new System.Drawing.Size(47, 16);
            this.toyotaButton.TabIndex = 3;
            this.toyotaButton.TabStop = true;
            this.toyotaButton.Text = "トヨタ";
            this.toyotaButton.UseVisualStyleBackColor = true;
            // 
            // nissanButton
            // 
            this.nissanButton.AutoSize = true;
            this.nissanButton.Location = new System.Drawing.Point(59, 18);
            this.nissanButton.Name = "nissanButton";
            this.nissanButton.Size = new System.Drawing.Size(47, 16);
            this.nissanButton.TabIndex = 3;
            this.nissanButton.TabStop = true;
            this.nissanButton.Text = "日産";
            this.nissanButton.UseVisualStyleBackColor = true;
            // 
            // othersButton
            // 
            this.othersButton.AutoSize = true;
            this.othersButton.Location = new System.Drawing.Point(280, 18);
            this.othersButton.Name = "othersButton";
            this.othersButton.Size = new System.Drawing.Size(54, 16);
            this.othersButton.TabIndex = 3;
            this.othersButton.TabStop = true;
            this.othersButton.Text = "その他";
            this.othersButton.UseVisualStyleBackColor = true;
            // 
            // subaruButton
            // 
            this.subaruButton.AutoSize = true;
            this.subaruButton.Location = new System.Drawing.Point(169, 18);
            this.subaruButton.Name = "subaruButton";
            this.subaruButton.Size = new System.Drawing.Size(52, 16);
            this.subaruButton.TabIndex = 3;
            this.subaruButton.TabStop = true;
            this.subaruButton.Text = "スバル";
            this.subaruButton.UseVisualStyleBackColor = true;
            // 
            // gaisyaButton
            // 
            this.gaisyaButton.AutoSize = true;
            this.gaisyaButton.Location = new System.Drawing.Point(227, 18);
            this.gaisyaButton.Name = "gaisyaButton";
            this.gaisyaButton.Size = new System.Drawing.Size(47, 16);
            this.gaisyaButton.TabIndex = 3;
            this.gaisyaButton.TabStop = true;
            this.gaisyaButton.Text = "外車";
            this.gaisyaButton.UseVisualStyleBackColor = true;
            // 
            // hondaButton
            // 
            this.hondaButton.AutoSize = true;
            this.hondaButton.Location = new System.Drawing.Point(112, 18);
            this.hondaButton.Name = "hondaButton";
            this.hondaButton.Size = new System.Drawing.Size(51, 16);
            this.hondaButton.TabIndex = 3;
            this.hondaButton.TabStop = true;
            this.hondaButton.Text = "ホンダ";
            this.hondaButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(27, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "記事一覧：";
            // 
            // tbRepo
            // 
            this.tbRepo.Location = new System.Drawing.Point(108, 180);
            this.tbRepo.Multiline = true;
            this.tbRepo.Name = "tbRepo";
            this.tbRepo.Size = new System.Drawing.Size(405, 81);
            this.tbRepo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(29, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "レポート：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.othersButton);
            this.groupBox1.Controls.Add(this.gaisyaButton);
            this.groupBox1.Controls.Add(this.subaruButton);
            this.groupBox1.Controls.Add(this.toyotaButton);
            this.groupBox1.Controls.Add(this.nissanButton);
            this.groupBox1.Controls.Add(this.hondaButton);
            this.groupBox1.Location = new System.Drawing.Point(108, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpen.Location = new System.Drawing.Point(25, 308);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(64, 34);
            this.btOpen.TabIndex = 7;
            this.btOpen.Text = "接続";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(25, 358);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(64, 37);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(693, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "画像：";
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btPictureOpen.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPictureOpen.Location = new System.Drawing.Point(744, 21);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(122, 22);
            this.btPictureOpen.TabIndex = 7;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdd.Location = new System.Drawing.Point(731, 239);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(71, 22);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(731, 64);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(281, 155);
            this.pbPicture.TabIndex = 9;
            this.pbPicture.TabStop = false;
            // 
            // btCorrected
            // 
            this.btCorrected.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btCorrected.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCorrected.Location = new System.Drawing.Point(842, 239);
            this.btCorrected.Name = "btCorrected";
            this.btCorrected.Size = new System.Drawing.Size(62, 22);
            this.btCorrected.TabIndex = 7;
            this.btCorrected.Text = "修正";
            this.btCorrected.UseVisualStyleBackColor = true;
            this.btCorrected.Click += new System.EventHandler(this.btCorrected_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(944, 239);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(68, 22);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPictureDelete.Location = new System.Drawing.Point(884, 23);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(128, 22);
            this.btPictureDelete.TabIndex = 8;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEnd.Location = new System.Drawing.Point(884, 423);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(128, 22);
            this.btEnd.TabIndex = 8;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(44, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "車名：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(108, 152);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(224, 20);
            this.cbCarName.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog2";
            // 
            // carReportDataGridView
            // 
            this.carReportDataGridView.AllowUserToAddRows = false;
            this.carReportDataGridView.AutoGenerateColumns = false;
            this.carReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDataGridView.DataSource = this.carReportBindingSource;
            this.carReportDataGridView.Location = new System.Drawing.Point(114, 267);
            this.carReportDataGridView.MultiSelect = false;
            this.carReportDataGridView.Name = "carReportDataGridView";
            this.carReportDataGridView.ReadOnly = true;
            this.carReportDataGridView.RowTemplate.Height = 21;
            this.carReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDataGridView.Size = new System.Drawing.Size(962, 151);
            this.carReportDataGridView.TabIndex = 22;
            this.carReportDataGridView.Click += new System.EventHandler(this.carReportDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202021DataSet;
            // 
            // infosys202021DataSet
            // 
            this.infosys202021DataSet.DataSetName = "infosys202021DataSet";
            this.infosys202021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(46, 45);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(188, 19);
            this.tbSearchCarName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "車名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAND);
            this.groupBox2.Controls.Add(this.btOR);
            this.groupBox2.Controls.Add(this.btSearchExe);
            this.groupBox2.Controls.Add(this.tbmakerSearch);
            this.groupBox2.Controls.Add(this.tbSearchCarName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePickerSerch);
            this.groupBox2.Location = new System.Drawing.Point(1018, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 242);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(159, 203);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 25;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // tbmakerSearch
            // 
            this.tbmakerSearch.Location = new System.Drawing.Point(46, 134);
            this.tbmakerSearch.Name = "tbmakerSearch";
            this.tbmakerSearch.Size = new System.Drawing.Size(188, 19);
            this.tbmakerSearch.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "メーカー";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "日付";
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btOR
            // 
            this.btOR.AutoSize = true;
            this.btOR.Checked = true;
            this.btOR.Location = new System.Drawing.Point(37, 173);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(39, 16);
            this.btOR.TabIndex = 26;
            this.btOR.TabStop = true;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = true;
            // 
            // btAND
            // 
            this.btAND.AutoEllipsis = true;
            this.btAND.AutoSize = true;
            this.btAND.Location = new System.Drawing.Point(146, 173);
            this.btAND.Name = "btAND";
            this.btAND.Size = new System.Drawing.Size(47, 16);
            this.btAND.TabIndex = 27;
            this.btAND.Text = "AND";
            this.btAND.UseVisualStyleBackColor = true;
            // 
            // dgvArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.carReportDataGridView);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCorrected);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbRepo);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "dgvArticle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202021DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerSerch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRecorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton toyotaButton;
        private System.Windows.Forms.RadioButton nissanButton;
        private System.Windows.Forms.RadioButton othersButton;
        private System.Windows.Forms.RadioButton subaruButton;
        private System.Windows.Forms.RadioButton gaisyaButton;
        private System.Windows.Forms.RadioButton hondaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btCorrected;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog savSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private infosys202021DataSet infosys202021DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202021DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbmakerSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton btOR;
        private System.Windows.Forms.RadioButton btAND;
    }
}

