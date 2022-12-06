using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nyilvantarto
{
    public partial class Form1 : Form
    {
        int osszeg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            if (ofdMegynyitas.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdMegynyitas.FileName))
                {
                    tbNev.Enabled = true;
                    tbOsszeg.Enabled = true;
                    gbTipus.Enabled = true;
                    btnTranzakcio.Enabled = true;
                    btnMentes.Enabled = true;
                    osszeg = Convert.ToInt32(sr.ReadLine());

                    Befizet(osszeg);

                    lbAdatok.Items.Clear();

                    while (!sr.EndOfStream)
                    {
                        lbAdatok.Items.Add(sr.ReadLine());
                    }
                }
            }
        }

        private void btnTranzakcio_Click(object sender, EventArgs e)
        {
            if (tbNev.TextLength > 0 && tbOsszeg.TextLength > 0)
            {
                int addOsszeg;
                if (int.TryParse(tbOsszeg.Text, out addOsszeg))
                {
                    if (addOsszeg > 0)
                    {
                        if (rbBe.Checked)
                        {
                            osszeg += addOsszeg;
                            Befizet(osszeg);

                            lbAdatok.Items.Add((lbAdatok.Items.Count + 1) + ". tranzakció: " + tbNev.Text + " befizetett " + addOsszeg + " Ft-ot.");
                        } 
                        else
                        {
                            osszeg -= addOsszeg;
                            Befizet(osszeg);

                            lbAdatok.Items.Add((lbAdatok.Items.Count + 1) + ". tranzakció: " + addOsszeg + " Ft-ot kifizettünk " + tbNev.Text + " részére.");
                        }
                    }
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(ofdMegynyitas.FileName))
            {
                sw.WriteLine(osszeg);
                foreach (var item in lbAdatok.Items)
                {
                    sw.WriteLine(item);
                }

                MessageBox.Show("Az osztálypénz nyilvántartását az " + ofdMegynyitas.FileName + " fájlba kiírtam.", "Mentés");
            }
        }

        private void Befizet(int osszeg)
        {
            lbEgyenleg.Text = osszeg + " Ft";
        }
    }
}
