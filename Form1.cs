using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ComboEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemoverAdd_Click(object sender, EventArgs e)
        {
            if (cboEstados.SelectedIndex != -1)
            {
                string estado = cboEstados.SelectedItem.ToString();
                //norte
                if (estado == "Acre" || estado == "Amazonas" || estado == "Pará" ||
                    estado == "Roraima" || estado == "Rondônia" || estado == "Tocantins" ||
                    estado == "Amapá")
                {

                    cboNorte.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countNorte.Text = cboNorte.Items.Count.ToString();
                }
                //nordeste
                if (estado == "Alagoas" || estado == "Bahia" || estado == "Ceará" ||
                     estado == "Maranhão" || estado == "Paraíba" || estado == "Pernambuco" ||
                     estado == "Piauí" || estado == "Rio Grande do Norte")
                {
                    cboNordeste.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countNordeste.Text = cboNordeste.Items.Count.ToString();
                }
                // CEntro Oeste 
                if (estado == "Distrito Federal" || estado == "Goiás" ||
         estado == "Mato Grosso" || estado == "Mato Grosso do Sul")
                {
                    cboCentro.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    CountCentro.Text = cboCentro.Items.Count.ToString();
                }

                //sudeste
                if (estado == "Espírito Santo" || estado == "Minas Gerais" ||
         estado == "Rio de Janeiro" || estado == "São Paulo")
                {
                    cboSudeste.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countSudeste.Text = cboSudeste.Items.Count.ToString();
                }
                //Sul
                if (estado == "Paraná" || estado == "Santa Catarina" ||
         estado == "Rio Grande do Sul")
                {
                    cboSul.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countSul.Text = cboSul.Items.Count.ToString();
                }
            }

        }

        private void btnRemoverNorte_Click(object sender, EventArgs e)
        {
            if (cboNorte.SelectedIndex != -1)
            {
                cboEstados.Items.Add(cboNorte.SelectedItem);
                cboNorte.Items.Remove(cboNorte.SelectedItem);
                countEstados.Text = cboEstados.Items.Count.ToString();
                countNorte.Text = cboNorte.Items.Count.ToString();
                cboNorte.ResetText();
            }
        }

        private void btnRemoverNordeste_Click(object sender, EventArgs e)
        {
            if (cboNordeste.SelectedIndex != -1)
            {
                cboEstados.Items.Add(cboNordeste.SelectedItem);
                cboNordeste.Items.Remove(cboNordeste.SelectedItem);
                countEstados.Text = cboEstados.Items.Count.ToString();
                countNordeste.Text = cboNordeste.Items.Count.ToString();
                cboNordeste.ResetText();
            }
        }

        private void btnRemoverCentro_Click(object sender, EventArgs e)
        {
            if (cboCentro.SelectedIndex != -1)
            {
                cboEstados.Items.Add(cboCentro.SelectedItem);
                cboCentro.Items.Remove(cboCentro.SelectedItem);
                countEstados.Text = cboEstados.Items.Count.ToString();
                CountCentro.Text = cboCentro.Items.Count.ToString();
                cboCentro.ResetText();
            }
        }

        private void btnRemoverSudeste_Click(object sender, EventArgs e)
        {
            if (cboSudeste.SelectedIndex != -1)
            {
                cboEstados.Items.Add(cboSudeste.SelectedItem);
                cboSudeste.Items.Remove(cboSudeste.SelectedItem);
                countEstados.Text = cboEstados.Items.Count.ToString();
                countSudeste.Text = cboSudeste.Items.Count.ToString();
                cboSudeste.ResetText();
            }
        }

        private void btnRemoverSul_Click(object sender, EventArgs e)
        {
            if (cboSul.SelectedIndex != -1)
            {
                cboEstados.Items.Add(cboSul.SelectedItem);
                cboSul.Items.Remove(cboSul.SelectedItem);
                countEstados.Text = cboEstados.Items.Count.ToString();
                countSul.Text = cboSul.Items.Count.ToString();
                cboSul.ResetText();

            }
        }

        
    }
}
