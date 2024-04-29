using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTCC_Prévia
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Estoque Estoque = new Estoque();
            Estoque.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            String Produto = guna2TextBox1.Text;

            if (Produto == "123")
            {
                guna2GradientButton6.Visible = true;
                guna2NumericUpDown1.Visible = true;

            }
            else {

                
                guna2GradientButton6.Visible = false;
                guna2NumericUpDown1.Visible = false;
            }

                            if (Produto == "111")
                            {
                                Point Carne = new Point(50, 97);
                                Point BoxC = new Point(196, 99);

                                guna2GradientButton7.Location = Carne;
                                guna2NumericUpDown2.Location = BoxC;
                                guna2GradientButton7.Visible = true;
                                guna2NumericUpDown2.Visible = true;

                            }
                            else
                            {


                                guna2GradientButton7.Visible = false;
                                guna2NumericUpDown2.Visible = false;
                            }

                                                if(Produto == "222")
                                    {
                                                    Point Leite = new Point(50, 97);
                                                    Point BoxL = new Point(196, 99);

                                                    guna2GradientButton8.Location = Leite;
                                                    guna2NumericUpDown3.Location = BoxL;
                                                    guna2GradientButton8.Visible = true;
                                                    guna2NumericUpDown3.Visible = true;
                                                }
                                                else
                                                {
                                                    guna2GradientButton8.Visible = false;
                                                    guna2NumericUpDown3.Visible = false;
                                                }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
        }
    }
}
