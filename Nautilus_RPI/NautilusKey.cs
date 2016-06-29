using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nautilus_RPI
{
    public partial class NautilusKey : Form
    {
        private static bool capslock = false;
        public NautilusKey()
        {
            InitializeComponent();
        }

       


        private void constructor(string texto)
        {
            string t = txtContent.Text;
            txtContent.Text = t + texto;
        }

       
        private void btnCaps_Click(object sender, EventArgs e)
        {
            if (capslock==false)
            {
                allCaps();
            }
            else
            {
                allSmallCaps();
            }
        }
        private void btn_q_Click(object sender, EventArgs e)
        {
            string s = btn_q.Text;
            constructor(s);
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            string s = btn_w.Text;
            constructor(s);
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            string s = btn_e.Text;
            constructor(s);
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            string s = btn_r.Text;
            constructor(s);
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            string s = btn_t.Text;
            constructor(s);
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            string s = btn_y.Text;
            constructor(s);
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            string s = btn_u.Text;
            constructor(s);
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            string s = btn_i.Text;
            constructor(s);
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            string s = btn_o.Text;
            constructor(s);
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            string s = btn_p.Text;
            constructor(s);
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            string s = btn_a.Text;
            constructor(s);
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            string s = btn_s.Text;
            constructor(s);
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            string s = btn_d.Text;
            constructor(s);
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            string s = btn_f.Text;
            constructor(s);
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            string s = btn_g.Text;
            constructor(s);
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            string s = btn_h.Text;
            constructor(s);
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            string s = btn_j.Text;
            constructor(s);
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            string s = btn_k.Text;
            constructor(s);
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            string s = btn_l.Text;
            constructor(s);
        }

        private void btn_nn_Click(object sender, EventArgs e)
        {
            string s = btn_nn.Text;
            constructor(s);
        }

        private void btn_z_Click(object sender, EventArgs e)
        {
            string s = btn_z.Text;
            constructor(s);
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            string s = btn_x.Text;
            constructor(s);
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            string s = btn_c.Text;
            constructor(s);
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            string s = btn_v.Text;
            constructor(s);
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            string s = btn_b.Text;
            constructor(s);
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            string s = btn_n.Text;
            constructor(s);
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            string s = btn_m.Text;
            constructor(s);
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            string s = btn_dot.Text;
            constructor(s);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            string s = btn_0.Text;
            constructor(s);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            string s = btn_1.Text;
            constructor(s);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string s = btn_2.Text;
            constructor(s);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            string s = btn_3.Text;
            constructor(s);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string s = btn_4.Text;
            constructor(s);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            string s = btn_5.Text;
            constructor(s);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            string s = btn_6.Text;
            constructor(s);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            string s = btn_7.Text;
            constructor(s);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            string s = btn_8.Text;
            constructor(s);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            string s = btn_9.Text;
            constructor(s);
        }

        private void btn_http_Click(object sender, EventArgs e)
        {
            string s = btn_http.Text;
            constructor(s);
        }

        private void btn_www_Click(object sender, EventArgs e)
        {
            string s = btn_www.Text;
            constructor(s);
        }

        private void btn_slash_Click(object sender, EventArgs e)
        {
            string s = btn_slash.Text;
            constructor(s);
        }

        private void btn_space_Click(object sender, EventArgs e)
        {
            
            constructor(" ");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            string s = txtContent.Text;
            s = s.Remove(s.Length - 1);
            txtContent.Text = s;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            KeyboardManager.textString = null;
            KeyboardManager.textString = txtContent.Text.Trim();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            KeyboardManager.textString = null;
            this.Close();
        }
        private void allCaps()
        {
            foreach (Control objCtrl in this.Controls)
            {
                if (objCtrl is Button)
                {
                    capslock = true;
                    objCtrl.Text = objCtrl.Text.ToUpper();
                }
            }
        }

        private void allSmallCaps()
        {
            foreach (Control objCtrl in this.Controls)
            {
                if (objCtrl is Button)
                {
                    capslock = false;
                    objCtrl.Text = objCtrl.Text.ToLower();
                }
            }
        }
    }
}
