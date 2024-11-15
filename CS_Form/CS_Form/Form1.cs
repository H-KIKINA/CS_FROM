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

        public Form1()
        {
            InitializeComponent();

            string [] strs = 
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
                
                TestButton testButton = new TestButton(this, strs[i], (i % 5) * 100, (i / 5) * 100, 100, 100);
                
                Controls.Add(testButton);
            }

             _testLabel =
                new Test_Label("ラベルです", 10, 300, 100, 500);
            Controls.Add(_testLabel);
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
    }
}
