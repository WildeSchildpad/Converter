using System;
using System.IO;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        bool messageShown = false;
        public Double input;
        public String ans;
        public Converter()
        {
            InitializeComponent();
        }

        private void BtnMToF_Click(object sender, EventArgs e)
        {

            ConvertLabel.Text = "Meter To Foot.";
        }

        private void BtnFTM_Click(object sender, EventArgs e)
        {

            ConvertLabel.Text = "Foot to Meter.";
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            decimal round;
            switch (ConvertType.Text)
            {
                case "Meter To Foot":
                    input = Double.Parse(MTFTextbox.Text);
                    MTFTextbox.Text = (input * 3.2808399).ToString();
                    ans = MTFTextbox.Text;
                    MessageShown();
                    break;
                case "Foot To Meter":
                    input = Double.Parse(MTFTextbox.Text);
                    MTFTextbox.Text = (input / 3.2808399).ToString();
                    ans = MTFTextbox.Text;
                    MessageShown();
                    break;
                case "Euro To Dollar":
                    input = Double.Parse(MTFTextbox.Text);
                    round = Decimal.Round(Decimal.Parse((input * 1.18).ToString()), 2);
                    MTFTextbox.Text = "€" + (round).ToString();
                    ans = MTFTextbox.Text;
                    MessageShown();
                    break;
                case "Dollar To Euro":
                    input = Double.Parse(MTFTextbox.Text);
                    round = Decimal.Round(Decimal.Parse((input / 1.18).ToString()), 2);
                    MTFTextbox.Text = "$" + (round).ToString();
                    ans = MTFTextbox.Text;
                    MessageShown();
                    break;
            }
        }

        private void MTFTextbox_Enter(object sender, EventArgs e)
        {
            MTFTextbox.Text = "";
        }

        private void MTFTextbox_Leave(object sender, EventArgs e)
        {
            if (MTFTextbox.Text == "")
            {
                MTFTextbox.Text = "Enter number to convert...";
            }
        }


        private void BtnAns_Click(object sender, EventArgs e)
        {
            MTFTextbox.Text = ans.ToString();
        }

        private void MTFTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnConvert_Click(sender, e);
            }
            else if (e.KeyCode == Keys.C)
            {
                BtnClr_Click(sender, e);
            }

            else if (e.KeyCode == Keys.M)
            {
                ConvertType.SelectedItem = 0;
            }
            else if (e.KeyCode == Keys.F)
            {
                ConvertType.SelectedItem = 1;
            }
            else if (e.KeyCode == Keys.H)
            {
                if (HistoryBox.Items.Count != 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete your history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        HistoryBox.Items.Clear();

                    }
                }
            }
        }

        private void BtnClrHistory_Click(object sender, EventArgs e)
        {
            if (HistoryBox.Items.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete your history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save();
                    HistoryBox.Items.Clear();
                }
            }
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            MTFTextbox.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnConvert_Click(sender, e);
            }
            else if (e.KeyCode == Keys.C)
            {
                BtnClr_Click(sender, e);
            }
            else if (e.KeyCode == Keys.M)
            {
                ConvertType.SelectedItem = 0;
            }
            else if (e.KeyCode == Keys.F)
            {
                ConvertType.SelectedItem = 1;
            }
            else if (e.KeyCode == Keys.H)
            {
                BtnClrHistory_Click(sender, e);
            }
        }

        private void MTFTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsPunctuation(e.KeyChar);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save()
        {
            const string sPath = "lasthistory.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in HistoryBox.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"lasthistory.txt");
            HistoryBox.Items.AddRange(lines);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConvertType.SelectedIndex == 0)
            {
                ConvertLabel.Text = "Meter To Foot";
            }
            else if (ConvertType.SelectedIndex == 1)
            {
                ConvertLabel.Text = "Foot To Meter";
            }
            if (ConvertType.SelectedIndex == 2)
            {
                ConvertLabel.Text = "Euro To Dollar";
                EuroDollarLabel.Text = "€";
            }
            else if (ConvertType.SelectedIndex == 3)
            {
                ConvertLabel.Text = "Dollar To Euro";
                EuroDollarLabel.Text = "$";
            }
        }

        private void MessageShown()
        {
            if (HistoryBox.Items.Count <= 20)
            {
                switch (ConvertType.SelectedItem)
                {
                    case "Meter To Foot":
                        HistoryBox.Items.Add(input.ToString() + "ft = " + ans.ToString() + "m");
                        HistoryBox.Items.Add("");
                        break;
                    case "Foot To Meter":
                        HistoryBox.Items.Add(input.ToString() + "ft = " + ans.ToString() + "m");
                        HistoryBox.Items.Add("");
                        break;
                    case "Dollar To Euro":
                        HistoryBox.Items.Add("$" + input.ToString() + " = " + ans.ToString());
                        HistoryBox.Items.Add("");
                        break;
                    case "Euro To Dollar":
                        HistoryBox.Items.Add("€" + input.ToString() + " = " + ans.ToString());
                        HistoryBox.Items.Add("");
                        break;

                }
            }
            else if (messageShown == false)
            {
                if (MessageBox.Show("Your history is full. Do you want to delete the history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && messageShown == false)
                {
                    HistoryBox.Items.Clear();
                    messageShown = false;
                }
                else
                {
                    messageShown = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MTFTextbox.Text = "Enter number to convert...";
            ConvertLabel.Text = "Meter To Foot.";
            MTFTextbox.HideSelection = true;
            HistoryBox.SelectedIndex = -1;
            ConvertType.SelectedIndex = 0; 
        }
    }
}

