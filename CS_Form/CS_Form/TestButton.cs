using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;
        /// <summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        /// </summary>
        
        public TestButton(Form1 form1,string str ,int x,int y,int width,int height) 
        {
            _form1 = form1;
            //ClickイベントにOnClick関数をと登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnClick;
            Text = str.ToString();

            Location = new Point(x,y);
            Size = new Size(width,height);

        }
        /// <summary>
        /// ボタンをクリックした際の処理を記入する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    public void OnClick(object sender, EventArgs e)
    {
            _form1.LabelTextUpdate(Text);
    }
       


    }

}
