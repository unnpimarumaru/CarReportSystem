using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> cars = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvArticle.DataSource = cars;
        }





















        private void initButton()
        {
            if (cars.Count <= 0)
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
        private void nullCurrent()
        {
            dgvArticle.CurrentCell = null;
            btDelete.Enabled = false;
            btCorrected.Enabled = false;

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

                    Author = cbRecorder.Text,

                    Name = cbCarName.Text,

                    Report = tbRepo.Text,


                    Picture = pbPicture.Image,
                };
                //メーカーをコンボボックスの入力候補に登録

                cars.Insert(0, car);

                AllClearMethod();

                initButton();

                nullCurrent();

            }
 
        }
        private void AllClearMethod()
        {

            cbRecorder.Text=("");
            tbRepo.Clear();
            pbPicture.Image = null;
        }





    }




}
