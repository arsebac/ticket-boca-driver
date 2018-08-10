using BocaTicket.Serial_Port;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BocaTicket
{
    public partial class Form1 : Form
    {
        public int LastIdBon { get; set; }
        public Model model;
        public Form1()
        {
            model = new Model();
            LastIdBon = Int32.Parse(System.Configuration.ConfigurationManager.AppSettings["ID"]);
            InitializeComponent();
            updateSerialState();
        }
        private bool Verify(bool multiple)
        {
            /*if (!PortAccess.Boca_Serial.IsOpen)
            {
                MessageBox.Show("Impossible de communiquer avec l'imprimante");
            }
            else*/ if (this.companyName.Text.Length < 1)
            {
                MessageBox.Show("Entrez un nom d'entreprise");
            }
            else if (multiple && bonNumber.Value <= 0)
            {
                MessageBox.Show("Entrez le nombre de bon à imprimer");
            }
            else
            {
                return true;
            }

            return false;
        }
        private void updateSerialState()
        {
            string win = PortAccess.Open_Serial("COM1");
            if (win == PortAccess.OPENED)
            {
                this.state.Text = "Connecté";
            }
            else
            {
                this.state.Text = win;
            }
        }
        private void Relancer(object sender, EventArgs e)
        {
            updateSerialState();
        }


        private void bonNumber_ValueChanged(object sender, EventArgs e)
        {
            this.bonId.Text = (model.Id + 1) + " - " + (model.Id + this.bonNumber.Value);
            this.launch.Text = "Lancer " + this.bonNumber.Value + " impressions";
        }
        private void Apply()
        {
            model.Id++;
            PortAccess.write_serial(model.GenerateFGLModel(companyName.Text, model.Id));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Verify(false)) Apply();
        }

        private void state_Click(object sender, EventArgs e)
        {

        }

        private void changeBonNumber(object sender, EventArgs e)
        {

            int res = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Le premier numéro à utiliser :", "Title", "" + (model.Id + 1)));
            model.Id = res - 1;
            bonNumber_ValueChanged(null, null);
        }

        private void lauchPrints(object sender, EventArgs e)
        {
            if (Verify(true))
            {
                for (int i = 0; i < bonNumber.Value; i++)
                {
                    button4_Click(sender, e);
                }

                bonNumber_ValueChanged(null, null);
            }
        }

        private void bonId_Click(object sender, EventArgs e)
        {

        }
    }
}
