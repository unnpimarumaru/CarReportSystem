using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CarReportSystem
{
    //メーカー（列挙型）
    public enum CarMaker
    {
        DEFAULT,
        トヨタ,
        日産,
        ホンダ,
        スバル,
        外車,
        その他
    }
    [Serializable]
    class CarReport
    {
        //作成日
        public DateTime CreatedDate { get; set; }
        //記録者
        public string Author { get; set; }
        //車名
        public string Name { get; set; }
        //レポート
        public string Report { get; set; }
        //画像
        public Image Picture { get; set; }


        public CarMaker Maker {get; set; }


    }



}
