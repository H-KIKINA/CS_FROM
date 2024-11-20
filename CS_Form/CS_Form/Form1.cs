using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        Test_Label _testLabel;

        TestTextBox _textBox;
        TestButton _testButton;



        public Form1()
        {
            InitializeComponent();

            string[] strs =
            {  "あ",
               "か" ,
               "さ",
               "た" ,
               "な" ,
               "は" ,
               "ま" ,
               "や" ,
               "ら" ,
               "わ",
            };


            for (int i = 0; i <= 9; i++)
            {
                //ボタンの表示処理
                TestButton testButton = new TestButton(this, strs[i], (i % 5) * 100, (i / 5) * 100, 100, 100);

                //ボタンの追加
                Controls.Add(testButton);
            }
           
            
            //ラベルの作成
            _testLabel =
               new Test_Label("ラベルです", 10, 300, 100, 500);
            Controls.Add(_testLabel);

            //テキストボックスの作成
            _textBox = new TestTextBox("テキストボックスです", 150, 400, 500, 200);
            Controls.Add(_textBox);
            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "ラベルです";

            //Controls.Add(label);


            //TestButton testButton2 = new TestButton(100,100,100,100);

            //Controls.Add(testButton2);
        }

        /// <summary>
        /// ラベルの文字を更新
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        public string ButtonLabelReplacement(string str) 
        {
            string s = _textBox.TextReplacement(str);
            return s;
        }
       // public void TestTextBoxUpdate(string str)
        //{
       //   _textBox.TextUpdate(str);
       // }
       // public void TestButtonUpdate(string A)
        //{
        //    
           // _testButton.TextUpdate(A);
        //}

    }
}
