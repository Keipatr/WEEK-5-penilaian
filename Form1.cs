namespace WEEK_5
{
    public partial class formMateri : Form
    {
        public formMateri()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.BeginUpdate();
            if (listBoxKoleksi.Items.Count > 0)
            {
                
                
                    if (listBoxKoleksi.Items.Contains(textBoxData.Text))
                    {
                        MessageBox.Show("ISI ADA KEMBAR");
                    }
                    else
                    {
                        listBoxKoleksi.Items.Add(textBoxData.Text);
                    }
                    textBoxData.Text = "";
                
            }
            else
            {
                listBoxKoleksi.Items.Add(textBoxData.Text);
                textBoxData.Text = "";
            }
            listBoxKoleksi.EndUpdate();
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelOutput.ForeColor = Color.Blue;
                }
                if (radioButtonMerah.Checked == true)
                {
                    labelOutput.ForeColor = Color.Red;
                }
            }
            else
            {
                labelOutput.ForeColor = Color.Black;
            }
        }

        private void formMateri_Load(object sender, EventArgs e)
        {
            radioButtonMerah.Checked = true;
            labelOutput.Text = "";
        }

        private void buttonCLear_Click(object sender, EventArgs e)
        {
            labelOutput.Text="";
            listBoxKoleksi.Items.Clear();
            radioButtonMerah.Checked = true;
            checkBoxAktif.Checked = false;
        }

        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutput.Text = listBoxKoleksi.Text;
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelOutput.ForeColor = Color.Blue;
                }
                if (radioButtonMerah.Checked == true)
                {
                    labelOutput.ForeColor = Color.Red;
                }
            }
            else
            {
                labelOutput.ForeColor = Color.Black;
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelOutput.ForeColor = Color.Blue;
                }
                if (radioButtonMerah.Checked == true)
                {
                    labelOutput.ForeColor = Color.Red;
                }
            }
            else
            {
                labelOutput.ForeColor = Color.Black;
            }
        }
    }
}