using System;
using System.Windows.Forms;

namespace Gato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDat1_TextChanged(object sender, EventArgs e)
        {

            if (txtDat1.Text == "0" || txtDat1.Text == "X" || txtDat1.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat1.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat1.Text = "";

            }

        }

        private void txtDat2_TextChanged(object sender, EventArgs e)
        {

            if (txtDat2.Text == "0" || txtDat2.Text == "X" || txtDat2.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat2.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat2.Text = "";

            }
        }

        private void txtDat3_TextChanged(object sender, EventArgs e)
        {

            if (txtDat3.Text == "0" || txtDat3.Text == "X" || txtDat3.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat3.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat3.Text = "";

            }
        }

        private void txtDat4_TextChanged(object sender, EventArgs e)
        {

            if (txtDat4.Text == "0" || txtDat4.Text == "X" || txtDat4.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat4.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat4.Text = "";

            }
        }

        private void txtDat5_TextChanged(object sender, EventArgs e)
        {

            if (txtDat5.Text == "0" || txtDat5.Text == "X" || txtDat5.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat5.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat5.Text = "";

            }
        }

        private void txtDat6_TextChanged(object sender, EventArgs e)
        {

            if (txtDat6.Text == "0" || txtDat6.Text == "X" || txtDat6.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat6.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat6.Text = "";

            }
        }

        private void txtDat7_TextChanged(object sender, EventArgs e)
        {

            if (txtDat7.Text == "0" || txtDat7.Text == "X" || txtDat7.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat7.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat7.Text = "";

            }
        }

        private void txtDat8_TextChanged(object sender, EventArgs e)
        {

            if (txtDat8.Text == "0" || txtDat8.Text == "X" || txtDat8.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat8.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat8.Text = "";

            }
        }

        private void txtDat9_TextChanged(object sender, EventArgs e)
        {

            if (txtDat9.Text == "0" || txtDat9.Text == "X" || txtDat9.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat9.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat9.Text = "";

            }
        }

        //checar gato..
        private void checarGato()
        {
            //optimizacion de  codigo...
            String c1, c2, c3, c4, c5, c6, c7, c8, c9;
            string j1, j2,res;
            j1 = txtname1.Text.ToUpper();
            j2 = txtnam2.Text.ToUpper();
            res = cboSelect.Text.ToUpper();

            c1 = txtDat1.Text.ToUpper();
            c2 = txtDat2.Text.ToUpper();
            c3 = txtDat3.Text.ToUpper();
            c4 = txtDat4.Text.ToUpper();
            c5 = txtDat5.Text.ToUpper();
            c6 = txtDat6.Text.ToUpper();
            c7 = txtDat7.Text.ToUpper();
            c8 = txtDat8.Text.ToUpper();
            c9 = txtDat9.Text.ToUpper();


            if (c1 == "0" && c2 == "0" && c3 == "0" ||
                c1 == "X" && c2 == "X" && c3 == "X")
            {
                if (c1 == "0" && res == "0"  ) lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c1 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c1 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c1 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }
            if (c4 == "0" && c5 == "0" && c6 == "0" ||
                c4 == "X" && c5 == "X" && c6 == "X")
            {
                if (c4 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c4 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c4 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c4 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }

            if (c7 == "0" && c8 == "0" && c9 == "0" ||
                c7 == "X" && c8 == "X" && c9 == "X")
            {
                if (c7 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c7 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c7 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c7 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }

            if (c1 == "0" && c4 == "0" && c7 == "0" ||
                  c1 == "X" && c4 == "X" && c7 == "X")
            {
                if (c4 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c4 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c4 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c4 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }
            if (c2 == "0" && c5 == "0" && c8 == "0" ||
                 c2 == "X" && c5 == "X" && c8 == "X")
            {
                if (c2 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c2 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c2 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c2 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }
            if (c3 == "0" && c6 == "0" && c9 == "0" ||
                 c3 == "X" && c6 == "X" && c9 == "X")
            {
                if (c3 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c3 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c3 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c3 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }
            if (c3 == "0" && c5 == "0" && c7 == "0" ||
                 c3 == "X" && c5 == "X" && c7 == "X")
            {
                if (c3 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c3 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c3 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c3 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }
            if (c1 == "0" && c5 == "0" && c9 == "0" ||
                 c1 == "X" && c5 == "X" && c9 == "X")
            {
                if (c1 == "0" && res == "0") lblFinal.Text = ("El ganador es (0) " + j1 + "");
                if (c1 == "X" && lblSelect2.Text == "X") lblFinal.Text = ("El ganador es (X) " + j2 + "");

                if (c1 == "0" && lblSelect2.Text == "0") lblFinal.Text = ("El ganador es (0) " + j2 + "");
                if (c1 == "X" && res == "X") lblFinal.Text = ("El ganador es (X) " + j1 + "");
            }

            ////empate
            //if (c4 == "0" && c5 == "X" && c6 == "0" ||
            //   c4 == "X" && c5 == "0" && c6 == "X")
            //{
            //    if (c4 == "0") MessageBox.Show("Es un empate");
            //}
            //if (c7 == "0" && c8 == "X" && c9 == "0" ||
            //  c7 == "X" && c8 == "0" && c9 == "X")
            //{
            //    if (c7 == "0") MessageBox.Show("Es un empate");
            //}
            //if (c1 == "0" && c4 == "X" && c7 == "0" ||
            //     c1 == "X" && c4 == "0" && c7 == "X")
            //{
            //    if (c1 == "0") MessageBox.Show("Es un empate");
            //}
            //if (c2 == "0" && c5 == "X" && c8 == "0" ||
            //    c2 == "X" && c5 == "0" && c8 == "X")
            //{
            //    if (c2 == "0") MessageBox.Show("Es un empate");
            //}

            //if (c3 == "0" && c6 == "X" && c9 == "0" ||
            //    c3 == "X" && c6 == "0" && c9 == "X")
            //{
            //    if (c3 == "0") MessageBox.Show("Es un empate");
            //}
            //if (c3 == "0" && c5 == "X" && c7 == "0" ||
            //    c3 == "X" && c5 == "0" && c7 == "X")
            //{
            //    if (c3 == "0") MessageBox.Show("Es un empate");
            //}

        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            //se limpian los texbox para generar nueva partida..
            txtDat1.Text = "";
            txtDat2.Text = "";
            txtDat3.Text = "";
            txtDat4.Text = "";
            txtDat5.Text = "";
            txtDat6.Text = "";
            txtDat7.Text = "";
            txtDat8.Text = "";
            txtDat9.Text = "";
            lblFinal.Text = "";
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cboSelect.Text == "0")
            {

                lblSelect2.Text = "X";
            }
            else
            {
                lblSelect2.Text = "0";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido enter para continuar");


        }
    }
}
