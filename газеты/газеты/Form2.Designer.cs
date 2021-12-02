
namespace газеты
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(226, 120);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(122, 31);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            agentTypeIDLabel.Location = new System.Drawing.Point(152, 169);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(196, 31);
            agentTypeIDLabel.TabIndex = 4;
            agentTypeIDLabel.Text = "Agent Type ID:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(278, 222);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(70, 31);
            iNNLabel.TabIndex = 12;
            iNNLabel.Text = "INN:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(272, 276);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(76, 31);
            kPPLabel.TabIndex = 14;
            kPPLabel.Text = "KPP:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priorityLabel.Location = new System.Drawing.Point(241, 334);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(107, 31);
            priorityLabel.TabIndex = 20;
            priorityLabel.Text = "Priority:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(303, 586);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(30, 13);
            titleLabel1.TabIndex = 27;
            titleLabel1.Text = "Title:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ГАЗЕТЫ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(titleLabel1);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(agentTypeIDLabel);
            this.panel1.Controls.Add(this.agentTypeIDTextBox);
            this.panel1.Controls.Add(iNNLabel);
            this.panel1.Controls.Add(this.iNNTextBox);
            this.panel1.Controls.Add(kPPLabel);
            this.panel1.Controls.Add(this.kPPTextBox);
            this.panel1.Controls.Add(priorityLabel);
            this.panel1.Controls.Add(this.priorityTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 623);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(643, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(726, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(367, 117);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(206, 31);
            this.addressTextBox.TabIndex = 3;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(газеты.Agent);
            // 
            // agentTypeIDTextBox
            // 
            this.agentTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentTypeID", true));
            this.agentTypeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeIDTextBox.Location = new System.Drawing.Point(367, 169);
            this.agentTypeIDTextBox.Name = "agentTypeIDTextBox";
            this.agentTypeIDTextBox.Size = new System.Drawing.Size(206, 31);
            this.agentTypeIDTextBox.TabIndex = 5;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iNNTextBox.Location = new System.Drawing.Point(367, 222);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(206, 31);
            this.iNNTextBox.TabIndex = 13;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kPPTextBox.Location = new System.Drawing.Point(367, 276);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(206, 31);
            this.kPPTextBox.TabIndex = 15;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityTextBox.Location = new System.Drawing.Point(367, 331);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(206, 31);
            this.priorityTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 622);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox agentTypeIDTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.Button button1;
    }
}