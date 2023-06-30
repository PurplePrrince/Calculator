using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator {
    public partial class Form1 : Form {

        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        Double memory = 0;
        

        public Form1() {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e) {
            Button num = (Button)sender;
            if (TxtDisplay1.Text == "0")
                TxtDisplay1.Text = "";
            {
                if (num.Text == ".") {
                    if (!TxtDisplay1.Text.Contains("."))
                        TxtDisplay1.Text = TxtDisplay1.Text + num.Text;
                } else {
                    TxtDisplay1.Text = TxtDisplay1.Text + num.Text;
                }
            }
        }

        private void BtnMathOper_Click(object sender, EventArgs e) {
            if (result != 0) {
                BtnEquals.PerformClick();
            } else {
                result = Double.Parse(TxtDisplay1.Text);
            }

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (TxtDisplay1.Text != "0") {
                TxtDisplay2.Text = fstNum = $"{result}{operation}";
                TxtDisplay1.Text = string.Empty;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e) {
            secNum = TxtDisplay1.Text;
            TxtDisplay2.Text = $"{TxtDisplay2.Text}{TxtDisplay1.Text}=";

            if (RtBoxDisplayHistory.Text == "Цифры убежали от вас") {
                RtBoxDisplayHistory.Clear();
            }

            if (TxtDisplay1.Text != string.Empty) {
                if (TxtDisplay1.Text == "0") {
                    TxtDisplay2.Text = string.Empty;
                }
                switch (operation) {
                    case "+":
                        TxtDisplay1.Text = (result + Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TxtDisplay1.Text}\n");
                        break;
                    case "-":
                        TxtDisplay1.Text = (result - Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TxtDisplay1.Text}\n");
                        break;
                    case "*":
                        TxtDisplay1.Text = (result * Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TxtDisplay1.Text}\n");
                        break;
                    case "÷":
                        TxtDisplay1.Text = (result / Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TxtDisplay1.Text}\n");
                        break;
                    default:
                        TxtDisplay2.Text = $"{TxtDisplay1.Text}= ";
                        break;
                }

                result = Double.Parse(TxtDisplay1.Text);
                operation = string.Empty;
            }
        }

        private void BtnClearHistory_Click(object sender, EventArgs e) {
            RtBoxDisplayHistory.Clear();
            RtBoxDisplayHistory.Text = "Цифры убежали от вас";
        }

        private void BtnHistory_Click(object sender, EventArgs e) {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 345 : 5;
        }

        private void BtnBackspace_Click(object sender, EventArgs e) {
            if (TxtDisplay1.Text.Length > 0) {
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1);
            }
            if (TxtDisplay1.Text == string.Empty) {
                TxtDisplay1.Text = "0";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            TxtDisplay1.Text = "0";
            TxtDisplay2.Text = string.Empty;
            result = 0;
        }

        private void BtnOperations_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation) {
                case "√":
                    TxtDisplay2.Text = $"√({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay1.Text)));
                    break;
                case "x²":
                    TxtDisplay2.Text = $"({TxtDisplay1.Text})²";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) * Convert.ToDouble(TxtDisplay1.Text));
                    break;
                case "¹/x":
                    TxtDisplay2.Text = $"¹/({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay1.Text));
                    break;
                case "%":
                    TxtDisplay2.Text = $"%({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) / Convert.ToDouble(100));
                    break;
                case "±":
                    TxtDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay1.Text));
                    break;
            }
            RtBoxDisplayHistory.AppendText($"{TxtDisplay2.Text} = {TxtDisplay1.Text}\n");
        }

        private void BtnClearEntry_Click(object sender, EventArgs e) {
            TxtDisplay1.Text = "0";
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnFold_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MemOperations_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            operation = button.Text;
            Double a = 0;
            switch (operation) {
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    TxtDisplay1.Text = Convert.ToString(memory);
                    break;
                case "M+":
                    a = Double.Parse(TxtDisplay1.Text);
                    TxtDisplay2.Text = $"{a}+{Convert.ToString(memory)}=";
                    TxtDisplay1.Text = (Double.Parse(TxtDisplay1.Text) + memory).ToString();
                    RtBoxDisplayHistory.AppendText($"{a}+{memory} = {TxtDisplay1.Text}\n");
                    break;
                case "M-":
                    a = Double.Parse(TxtDisplay1.Text);
                    TxtDisplay2.Text = $"{a}-{Convert.ToString(memory)}=";
                    TxtDisplay1.Text = (Double.Parse(TxtDisplay1.Text) - memory).ToString();
                    RtBoxDisplayHistory.AppendText($"{a}-{memory} = {TxtDisplay1.Text}\n");
                    break;
                case "MS":
                    memory = Double.Parse(TxtDisplay1.Text);
                    break;
                case "MRC":
                    TxtDisplay1.Text = Convert.ToString(memory);
                    memory = 0;
                    break;
            }

            result = Double.Parse(TxtDisplay1.Text);
            operation = string.Empty;
        }
    }
}
