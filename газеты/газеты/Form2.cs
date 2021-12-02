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
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }
        public Form2 sp { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // agentBindingSource.DataSource = db.Agent.ToList();
            if (sp == null)
            {
                agentBindingSource.AddNew();
                this.Text = "Добавление нового агента";
            }
            else
            {
                agentBindingSource.Add(sp);
                this.Text = "Корректировка";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                db.SaveChanges();
                DialogResult = DialogResult.OK;
           
        }
    }
}
