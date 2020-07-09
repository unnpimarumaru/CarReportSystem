namespace CarReportSystem
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.dgvArticle = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 0;
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
            // dgvArticle
            // 
            this.dgvArticle.AllowUserToAddRows = false;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(108, 267);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.ReadOnly = true;
            this.dgvArticle.RowTemplate.Height = 21;
            this.dgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticle.Size = new System.Drawing.Size(904, 150);
            this.dgvArticle.TabIndex = 5;
            this.dgvArticle.Click += new System.EventHandler(this.dgvArticle_Click);
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
            this.btOpen.Text = "開く";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
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
            this.Controls.Add(this.dgvArticle);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.DataGridView dgvArticle;
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
    }
}

