using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_CONVERSOR
{
    public partial class FORM_CONVERSOR : Form
    {
        public FORM_CONVERSOR()
        {
            InitializeComponent();
        }

        private void BTNConverter_Click(object sender, EventArgs e)
        {
            double t;
            if (!double.TryParse(TxtTemperatura.Text, out t))
            {
                MessageBox.Show("Informe uma temperatura válida.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTemperatura.Focus();
                return;
            }

            if ((RbC.Checked && RbToC.Checked) || (RbF.Checked && RbToF.Checked) || (RbK.Checked && RbToK.Checked))
            {
                string u = RbC.Checked ? "ºC" : RbF.Checked ? "ºF" : "K";
                LbResposta.Text = $"{t:N2}{u} = {t:N2}{u}";
                return;
            }

            if ((RbC.Checked && RbToK.Checked) || (RbK.Checked && RbToC.Checked))
            {
                ConverterCK(t);
                return;
            }

            if ((RbC.Checked && RbToF.Checked) || (RbF.Checked && RbToC.Checked))
            {
                ConverterCF(t);
                return;
            }

            if ((RbF.Checked && RbToK.Checked) || (RbK.Checked && RbToF.Checked))
            {
                ConverterKF(t);
                return;
            }

            MessageBox.Show("Selecione a unidade de origem e a de destino.", "Conversão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConverterCK(double t) {

            if (RbC.Checked && RbToK.Checked) {
                double k = t + 273.15;
                LbResposta.Text = $"{t:N2}ºC = {k:N2}K";
            }
            if (RbK.Checked && RbToC.Checked)
            {
                double k = t - 273.15;
                LbResposta.Text = $"{t:N2}K = {k:N2}ºC";
            }
        }

        private void ConverterCF(double t)
        {

            if (RbC.Checked && RbToF.Checked)
            {
                double k = (t * 9.0 / 5.0) + 32.0;
                LbResposta.Text = $"{t:N2}ºC =  {k:N2}ºF";
            }
            if (RbF.Checked && RbToC.Checked)
            {
                double k = (t - 32.0) * 5.0 / 9.0;
                LbResposta.Text = $"{t:N2}ºF =  {k:N2}ºC";
            }
        }

        private void ConverterKF(double t)
        {

            if (RbF.Checked && RbToK.Checked)
            {
                double k = (t - 32.0) * 5.0 / 9.0 + 273.15;
                LbResposta.Text = $"{t:N2}ºF =  {k:N2}K";
            }
            if (RbK.Checked && RbToF.Checked)
            {
                double k = (t - 273.15) * 9.0 / 5.0 + 32.0;
                LbResposta.Text = $"{t:N2}K =  {k:N2}ºF";
            }
        }
    }
}
