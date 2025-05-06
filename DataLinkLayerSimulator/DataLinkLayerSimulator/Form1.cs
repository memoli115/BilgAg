using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using System.Xml;
using System.Text.Json.Serialization;

namespace DataLinkLayerSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProcessStartInfo psi;

        private void Form1_Load(object sender, EventArgs e)
        {
            psi = new ProcessStartInfo();
            psi.FileName = "python";
            psi.Arguments = "DataLinkLayerSiulator.py";  

            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            

            
        }

        private void btnSimulasyon_Click(object sender, EventArgs e)
        {
            if (cbxHataTespitAlg.SelectedIndex == -1 || cbxCerceveBoyutu.SelectedIndex == -1 
                || cbxSimulasyonTuru.SelectedIndex == -1 || numHataOrani.Value == -1)
            {
                MessageBox.Show("Lütfen bütün gerekli bilgileri giriniz!");
                return;
            }
            MessageBox.Show(cbxSimulasyonTuru.SelectedIndex.ToString());
            var process = Process.Start(psi);
            var simulation = new Simulation
            {
                HataTespitAlg = cbxHataTespitAlg.SelectedItem.ToString(),
                CerceveBoyutu = Convert.ToInt32(cbxCerceveBoyutu.SelectedItem),
                SimulasyonTuru = cbxSimulasyonTuru.SelectedItem.ToString(),
                HataOrani = Convert.ToDecimal(numHataOrani.Value),
                Metin = string.IsNullOrEmpty(txbMetin.Text) ? "" : txbMetin.Text
            };

            var jsonData = JsonSerializer.Serialize(simulation, new JsonSerializerOptions { WriteIndented = true });


            using (StreamWriter sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(jsonData);
                }
            }
        }

       
    }

    public class Simulation
    {
        public string HataTespitAlg { get; set; }
        public int CerceveBoyutu { get; set; }
        public string SimulasyonTuru { get; set; }
        public decimal HataOrani { get; set; }
        public string Metin { get; set; }
    }
}
