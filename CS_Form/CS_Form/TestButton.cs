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
        /// <summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        /// </summary>
        
        public TestButton(int id ,int x,int y,int width,int height) 
        {
            //ClickイベントにOnClick関数をと登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnClick;

            Text = id .ToString();

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
            MessageBox.Show(Text);
    }
}

}
