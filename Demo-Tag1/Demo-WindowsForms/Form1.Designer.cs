namespace Demo_WindowsForms
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
            txtZahl1 = new TextBox();
            lblZahl1 = new Label();
            lblZahl2 = new Label();
            txtZahl2 = new TextBox();
            lblGleich = new Label();
            lblErgebnis = new Label();
            btnBerechne = new Button();
            btnLoeschen = new Button();
            cmbRechenoperation = new ComboBox();
            lstRechnungen = new ListBox();
            SuspendLayout();
            // 
            // txtZahl1
            // 
            txtZahl1.Location = new Point(12, 37);
            txtZahl1.Name = "txtZahl1";
            txtZahl1.Size = new Size(109, 31);
            txtZahl1.TabIndex = 0;
            // 
            // lblZahl1
            // 
            lblZahl1.AutoSize = true;
            lblZahl1.Location = new Point(12, 9);
            lblZahl1.Name = "lblZahl1";
            lblZahl1.Size = new Size(55, 25);
            lblZahl1.TabIndex = 1;
            lblZahl1.Text = "Zahl1";
            // 
            // lblZahl2
            // 
            lblZahl2.AutoSize = true;
            lblZahl2.Location = new Point(220, 12);
            lblZahl2.Name = "lblZahl2";
            lblZahl2.Size = new Size(55, 25);
            lblZahl2.TabIndex = 3;
            lblZahl2.Text = "Zahl2";
            // 
            // txtZahl2
            // 
            txtZahl2.Location = new Point(220, 40);
            txtZahl2.Name = "txtZahl2";
            txtZahl2.Size = new Size(109, 31);
            txtZahl2.TabIndex = 2;
            // 
            // lblGleich
            // 
            lblGleich.AutoSize = true;
            lblGleich.Location = new Point(347, 44);
            lblGleich.Name = "lblGleich";
            lblGleich.Size = new Size(24, 25);
            lblGleich.TabIndex = 5;
            lblGleich.Text = "=";
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Location = new Point(388, 46);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(80, 25);
            lblErgebnis.TabIndex = 6;
            lblErgebnis.Text = "Ergebnis";
            // 
            // btnBerechne
            // 
            btnBerechne.Location = new Point(12, 93);
            btnBerechne.Name = "btnBerechne";
            btnBerechne.Size = new Size(112, 34);
            btnBerechne.TabIndex = 7;
            btnBerechne.Text = "berechnen";
            btnBerechne.UseVisualStyleBackColor = true;
            btnBerechne.Click += btnBerechne_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(12, 142);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(112, 34);
            btnLoeschen.TabIndex = 8;
            btnLoeschen.Text = "löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // cmbRechenoperation
            // 
            cmbRechenoperation.FormattingEnabled = true;
            cmbRechenoperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbRechenoperation.Location = new Point(127, 38);
            cmbRechenoperation.Name = "cmbRechenoperation";
            cmbRechenoperation.Size = new Size(87, 33);
            cmbRechenoperation.TabIndex = 9;
            // 
            // lstRechnungen
            // 
            lstRechnungen.FormattingEnabled = true;
            lstRechnungen.ItemHeight = 25;
            lstRechnungen.Location = new Point(17, 239);
            lstRechnungen.Name = "lstRechnungen";
            lstRechnungen.Size = new Size(231, 179);
            lstRechnungen.TabIndex = 10;
            lstRechnungen.SelectedIndexChanged += lstRechnungen_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 480);
            Controls.Add(lstRechnungen);
            Controls.Add(cmbRechenoperation);
            Controls.Add(btnLoeschen);
            Controls.Add(btnBerechne);
            Controls.Add(lblErgebnis);
            Controls.Add(lblGleich);
            Controls.Add(lblZahl2);
            Controls.Add(txtZahl2);
            Controls.Add(lblZahl1);
            Controls.Add(txtZahl1);
            Name = "Form1";
            Text = "Taschenrechner";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZahl1;
        private Label lblZahl1;
        private Label lblZahl2;
        private TextBox txtZahl2;
        private Label lblGleich;
        private Label lblErgebnis;
        private Button btnBerechne;
        private Button btnLoeschen;
        private ComboBox cmbRechenoperation;
        private ListBox lstRechnungen;
    }
}
