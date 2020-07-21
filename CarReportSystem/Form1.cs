using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class dgvArticle : Form
    {
        BindingList<CarReport> cars = new BindingList<CarReport>();
        public dgvArticle()
        {
            InitializeComponent();
            //dgvArticle.DataSource = cars;
        }
        private void nullCurrent()
        {
            carReportDataGridView.CurrentCell = null;
            btDelete.Enabled = false;
            btCorrected.Enabled = false;

        }


        private void initButton()
        {
            if (infosys202021DataSet.CarReport.Count <= 0 )
            {
                btCorrected.Enabled = false;
                btDelete.Enabled = false;
            }
            else
            {
                btCorrected.Enabled = true;
                btDelete.Enabled = true;
            }
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbRecorder.Text == "")
            {
                MessageBox.Show("記録者を入力してください");
            }
            else
            {
                CarReport car = new CarReport()

                {
                    CreatedDate = dateTimePicker1.Value,

                    Author = cbRecorder.Text,

                    Name = cbCarName.Text,

                    Report = tbRepo.Text,

                    Maker = RadioBottonCheck(),

                    Picture = pbPicture.Image,
                };

                cars.Insert(0, car);

                setcomboboxRecorder(cbRecorder.Text);

                setcomboboxCarName(cbCarName.Text);

                AllClearMethod();

                initButton();

                nullCurrent();
            }

        }
        //メーカーをコンボボックスの入力候補に登録
        private void setcomboboxRecorder(string Recorder)
        {//!で条件反転
            if (!cbRecorder.Items.Contains(Recorder))
            {
                //コンボボックスの追加
                cbRecorder.Items.Add(Recorder);
            }
        }


        //メーカーをコンボボックスの入力候補に登録
        private void setcomboboxCarName(string CarName)
        {//!で条件反転
            if (!cbCarName.Items.Contains(CarName))
            {
                //コンボボックスの追加
                cbCarName.Items.Add(CarName);
            }
        }



        //クリアメソッド
        private void AllClearMethod()
        {
            cbRecorder.Text = ("");
            tbRepo.Clear();
            pbPicture.Image = null;
            cbCarName.Text = ("");
        }
        //ラジオボタンチェック
        private CarMaker RadioBottonCheck()
        {
            if (toyotaButton.Checked == true)
            {
                return CarMaker.トヨタ;
            }

            if (nissanButton.Checked == true)
            {
                return CarMaker.日産;
            }
            if (hondaButton.Checked == true)
            {
                return CarMaker.ホンダ;
            }

            if (subaruButton.Checked == true)
            {
                return CarMaker.スバル;
            }

            if (gaisyaButton.Checked == true)
            {
                return CarMaker.外車;
            }
            else
            {
                return CarMaker.その他;

            }

        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbPicture.Image = Image.FromFile(openFileDialog1.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
                
        }


        private void carReportDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;

                cbRecorder.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();

                RadioBotton(carReportDataGridView.CurrentRow.Cells[3].Value.ToString());

                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();

                tbRepo.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();

                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
            }
            catch(InvalidCastException)//画像が登録されていないとき
            {
                pbPicture.Image = null;
            }
            catch(Exception ex)//上記以外のデータをすべて拾う
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btCorrected_Click(object sender, EventArgs e)
        {
            //変更対象のレコード
            //CarReport ChengeCar = cars[carReportDataGridView.CurrentRow.Index];
            
            carReportDataGridView.CurrentRow.Cells[1].Value = dateTimePicker1.Value;
            
            carReportDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;

            carReportDataGridView.CurrentRow.Cells[3].Value = RadioBottonCheck();

            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;

            carReportDataGridView.CurrentRow.Cells[5].Value = tbRepo.Text;

            if(pbPicture.Image != null)
            {
                carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);
            }
            else
            {
                carReportDataGridView.CurrentRow.Cells[6].Value = null;
            }

            carReportDataGridView.Refresh(); //データグリッドビューの再読み込み

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202021DataSet);

        }

        private void RadioBotton(string carMaker)
        {
            switch (carMaker)
            {
                case "トヨタ":
                    toyotaButton.Checked = true;
                    break;

                case "日産":
                    nissanButton.Checked = true;
                    break;

                case "ホンダ":
                    hondaButton.Checked = true;
                    break;

                case"スバル":
                    subaruButton.Checked = true;
                    break;

                case "外車":
                    gaisyaButton.Checked = true;
                    break;

                case "その他":
                    othersButton.Checked = true;
                    break;

            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202021DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            carReportDataGridView.Columns[0].Visible = false; //id非表示
            initButton();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
            nullCurrent();
            initButton();
            AllClearMethod();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログ
            if (savSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                //ファイルストリームを生成
                using (FileStream fs = new FileStream(savSaveData.FileName, FileMode.Create))

                    try
                    {     //シリアル化して保存
                        formatter.Serialize(fs, cars);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }

            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202021DataSet.CarReport);
            
            initButton();
            carReportDataGridView_Click(sender, e);
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202021DataSet);

        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }
    }
}
