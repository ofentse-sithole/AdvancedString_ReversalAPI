using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedString_ReversalAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dateTimePicker();

            clear();
        }

        //DateTimePicker
        private void dateTimePicker()
        {
            DateTime today = DateTime.Now;
            label2.Text = today.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //Exit Button
        private void api_exit_button(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //submit button
        private void api_submit_btn_Click(object sender, EventArgs e)
        {
            int clickCount = 0;

            txt_enter_word.Text.Trim();
            reverse();
            palindrome();

        }

        //clear button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //clear method
        private void clear()
        {
            txt_enter_word.Text = "";
            label_reversed_answer.Text = "";
            label_palindrome.Text = "";
        }

        //reverse method
        private void reverse()
        {
            
            string input;

            input = txt_enter_word.Text.Trim();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                label_reversed_answer.Text += input[i];
            }

           
        }


        //palindrome method
        private void palindrome() 
        {
            int valuelength ;
            string reversed = string.Empty;
            string inputTxtWord;

            inputTxtWord = txt_enter_word.Text.Trim();

            valuelength = inputTxtWord.Length - 1;



            while(valuelength >= 0)
            {
                reversed += inputTxtWord[valuelength];
                valuelength--;
            }

            if(inputTxtWord == reversed)
            {
                label_palindrome.Text = "True";
            }
            else
            {
                label_palindrome.Text = "False";
            }

        }

    }
}
