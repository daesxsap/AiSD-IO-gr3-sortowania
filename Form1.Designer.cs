namespace AiSD_IO_gr3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonss = new Button();
            buttonsi = new Button();
            buttonsm = new Button();
            buttonsq = new Button();
            textBoxwpisz = new TextBox();
            checkbox = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            buttongeneruj = new Button();
            textBoxpokaz = new TextBox();
            buttonsb = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonss
            // 
            buttonss.Location = new Point(179, 209);
            buttonss.Name = "buttonss";
            buttonss.Size = new Size(75, 23);
            buttonss.TabIndex = 2;
            buttonss.Text = "SS";
            buttonss.UseVisualStyleBackColor = true;
            buttonss.Click += buttonss_Click;
            // 
            // buttonsi
            // 
            buttonsi.Location = new Point(260, 209);
            buttonsi.Name = "buttonsi";
            buttonsi.Size = new Size(75, 23);
            buttonsi.TabIndex = 3;
            buttonsi.Text = "SI";
            buttonsi.UseVisualStyleBackColor = true;
            buttonsi.Click += buttonsi_Click;
            // 
            // buttonsm
            // 
            buttonsm.Location = new Point(341, 209);
            buttonsm.Name = "buttonsm";
            buttonsm.Size = new Size(75, 23);
            buttonsm.TabIndex = 4;
            buttonsm.Text = "SM";
            buttonsm.UseVisualStyleBackColor = true;
            buttonsm.Click += buttonsm_Click;
            // 
            // buttonsq
            // 
            buttonsq.Location = new Point(422, 209);
            buttonsq.Name = "buttonsq";
            buttonsq.Size = new Size(75, 23);
            buttonsq.TabIndex = 5;
            buttonsq.Text = "SQ";
            buttonsq.UseVisualStyleBackColor = true;
            buttonsq.Click += buttonsq_Click;
            // 
            // textBoxwpisz
            // 
            textBoxwpisz.Location = new Point(73, 32);
            textBoxwpisz.Name = "textBoxwpisz";
            textBoxwpisz.Size = new Size(100, 23);
            textBoxwpisz.TabIndex = 6;
            textBoxwpisz.TextChanged += textBoxwpisz_TextChanged;
            // 
            // checkbox
            // 
            checkbox.AutoSize = true;
            checkbox.Location = new Point(252, 37);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(15, 14);
            checkbox.TabIndex = 7;
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(377, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 120);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 10;
            label2.Text = "Czas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 120);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // buttongeneruj
            // 
            buttongeneruj.Location = new Point(400, 76);
            buttongeneruj.Name = "buttongeneruj";
            buttongeneruj.Size = new Size(75, 23);
            buttongeneruj.TabIndex = 12;
            buttongeneruj.Text = "Generuj";
            buttongeneruj.UseVisualStyleBackColor = true;
            buttongeneruj.Click += buttongeneruj_Click;
            // 
            // textBoxpokaz
            // 
            textBoxpokaz.Location = new Point(73, 112);
            textBoxpokaz.Name = "textBoxpokaz";
            textBoxpokaz.Size = new Size(100, 23);
            textBoxpokaz.TabIndex = 13;
            textBoxpokaz.TextChanged += textBoxpokaz_TextChanged;
            // 
            // buttonsb
            // 
            buttonsb.Location = new Point(98, 209);
            buttonsb.Name = "buttonsb";
            buttonsb.Size = new Size(75, 23);
            buttonsb.TabIndex = 14;
            buttonsb.Text = "SB";
            buttonsb.UseVisualStyleBackColor = true;
            buttonsb.Click += buttonsb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 299);
            Controls.Add(buttonsb);
            Controls.Add(textBoxpokaz);
            Controls.Add(buttongeneruj);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(checkbox);
            Controls.Add(textBoxwpisz);
            Controls.Add(buttonsq);
            Controls.Add(buttonsm);
            Controls.Add(buttonsi);
            Controls.Add(buttonss);
            MinimumSize = new Size(556, 324);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button buttonss;
        private Button buttonsi;
        private Button buttonsm;
        private Button buttonsq;
        private TextBox textBoxwpisz;
        private CheckBox checkbox;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private Button buttongeneruj;
        private TextBox textBoxpokaz;
        private Button buttonsb;
    }
}