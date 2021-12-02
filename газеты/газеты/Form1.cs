using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace газеты
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = db.Agent.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = db.Agent.ToList<Agent>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                agentBindingSource.DataSource = db.Agent.OrderByDescending(help => help.Title).ToList();

            }
            else
            {
                agentBindingSource.DataSource = db.Agent.OrderBy(help => help.Title).ToList();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.db = db;
            frm.sp = null;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                agentBindingSource.DataSource = null;
                agentBindingSource.DataSource = db.Agent.ToList();
            }
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agent sp = (Agent)agentBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить ?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Agent.Remove(sp);
                try
                {
                    db.SaveChanges();
                    agentBindingSource.DataSource = db.Agent.ToList();
                }


                catch (Exception ex)
                {
                }
                
                }
            }
        }

    }


