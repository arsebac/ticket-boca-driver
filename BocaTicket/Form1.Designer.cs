namespace BocaTicket
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bonNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bonId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.launch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bonNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etat de l\'imprimante :";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(138, 23);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(302, 13);
            this.state.TabIndex = 1;
            this.state.Text = "En cours de connection                                        ";
            this.state.Click += new System.EventHandler(this.state_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Relancer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Relancer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom de la société :";
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(141, 67);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(139, 20);
            this.companyName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre à imprimer :";
            // 
            // bonNumber
            // 
            this.bonNumber.Location = new System.Drawing.Point(141, 114);
            this.bonNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bonNumber.Name = "bonNumber";
            this.bonNumber.Size = new System.Drawing.Size(139, 20);
            this.bonNumber.TabIndex = 6;
            this.bonNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bonNumber.ValueChanged += new System.EventHandler(this.bonNumber_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numéro de bon :";
            // 
            // bonId
            // 
            this.bonId.AutoSize = true;
            this.bonId.Location = new System.Drawing.Point(141, 162);
            this.bonId.Name = "bonId";
            this.bonId.Size = new System.Drawing.Size(34, 13);
            this.bonId.TabIndex = 8;
            this.bonId.Text = "1 - 10";
            this.bonId.Click += new System.EventHandler(this.bonId_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.changeBonNumber);
            // 
            // launch
            // 
            this.launch.Location = new System.Drawing.Point(323, 202);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(139, 23);
            this.launch.TabIndex = 10;
            this.launch.Text = "Lancer 10 impressions";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.lauchPrints);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Tenter 1 impression";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 237);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bonId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bonNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Imprimer des bons";
            ((System.ComponentModel.ISupportInitialize)(this.bonNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bonNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bonId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.Button button4;
    }
}

