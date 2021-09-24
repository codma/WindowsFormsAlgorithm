using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btInput.Click += btInput_Click;
        }
        //숫자 입력 후 버튼 클릭 시 입력한 텍스트를 가지고 Total 함수를 실행한다.
        private void btInput_Click(object sender, EventArgs e)
        {
            string result = tbInputNum.Text;

            //입력한 텍스트(number)를 배열로 변환
            char[] arr;
            arr = result.ToCharArray();
            
            Total(arr);
        }
       
        
        private void Total(char[] numbers)
        {
            //변환한 배열을 숫자형식의 리스트로 변경 
            int Sum = new int();
            Sum = 0;

            //인덱스 카운트만큼 포문을 돌려 합한다
            for (int i = 0; i < numbers.Length; i++)
            {
                //char형식으로 했더니 아스키코드로 나옴.
                // 문자열로 변환한 다음 다시 숫자로 변환해서 합해준다.
                Sum = Sum + int.Parse(numbers[i].ToString());
            }
            tbResult.Text = Sum.ToString();
        }
        
        
    }
}
