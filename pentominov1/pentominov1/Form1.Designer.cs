namespace pentominov1
{
    partial class Form1
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
            this.bOkreni = new System.Windows.Forms.Button();
            this.timerPomeranje = new System.Windows.Forms.Timer(this.components);
            this.bOdoznaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bOkreni
            // 
            this.bOkreni.Location = new System.Drawing.Point(220, 471);
            this.bOkreni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bOkreni.Name = "bOkreni";
            this.bOkreni.Size = new System.Drawing.Size(116, 34);
            this.bOkreni.TabIndex = 0;
            this.bOkreni.Text = "OBRNIOKRENI";
            this.bOkreni.UseVisualStyleBackColor = true;
            this.bOkreni.Click += new System.EventHandler(this.bOkreni_Click);
            // 
            // timerPomeranje
            // 
            this.timerPomeranje.Tick += new System.EventHandler(this.timerPomeranje_Tick);
            // 
            // bOdoznaci
            // 
            this.bOdoznaci.Location = new System.Drawing.Point(66, 471);
            this.bOdoznaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bOdoznaci.Name = "bOdoznaci";
            this.bOdoznaci.Size = new System.Drawing.Size(119, 34);
            this.bOdoznaci.TabIndex = 1;
            this.bOdoznaci.Text = "ODOZNAČI";
            this.bOdoznaci.UseVisualStyleBackColor = true;
            this.bOdoznaci.Click += new System.EventHandler(this.bOdoznaci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.bOdoznaci);
            this.Controls.Add(this.bOkreni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOkreni;
        private System.Windows.Forms.Timer timerPomeranje;
        private System.Windows.Forms.Button bOdoznaci;
    }
}

