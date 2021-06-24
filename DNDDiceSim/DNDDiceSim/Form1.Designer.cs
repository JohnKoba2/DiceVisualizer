
namespace DNDDiceSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNumDice = new System.Windows.Forms.Label();
            this.numDice = new System.Windows.Forms.NumericUpDown();
            this.rbD2 = new System.Windows.Forms.RadioButton();
            this.rbD4 = new System.Windows.Forms.RadioButton();
            this.rbD6 = new System.Windows.Forms.RadioButton();
            this.rbD8 = new System.Windows.Forms.RadioButton();
            this.rbD10 = new System.Windows.Forms.RadioButton();
            this.rbD12 = new System.Windows.Forms.RadioButton();
            this.rbD20 = new System.Windows.Forms.RadioButton();
            this.rbD100 = new System.Windows.Forms.RadioButton();
            this.lbType = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.btRoll = new System.Windows.Forms.Button();
            this.txResults = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumDice
            // 
            this.lbNumDice.AutoSize = true;
            this.lbNumDice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumDice.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumDice.Location = new System.Drawing.Point(59, 23);
            this.lbNumDice.Name = "lbNumDice";
            this.lbNumDice.Size = new System.Drawing.Size(114, 22);
            this.lbNumDice.TabIndex = 0;
            this.lbNumDice.Text = "How Many Dice?";
            // 
            // numDice
            // 
            this.numDice.Location = new System.Drawing.Point(175, 23);
            this.numDice.Name = "numDice";
            this.numDice.Size = new System.Drawing.Size(38, 20);
            this.numDice.TabIndex = 1;
            this.numDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbD2
            // 
            this.rbD2.AutoSize = true;
            this.rbD2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD2.Location = new System.Drawing.Point(29, 170);
            this.rbD2.Name = "rbD2";
            this.rbD2.Size = new System.Drawing.Size(39, 17);
            this.rbD2.TabIndex = 2;
            this.rbD2.TabStop = true;
            this.rbD2.Tag = "2";
            this.rbD2.Text = "D2";
            this.rbD2.UseVisualStyleBackColor = false;
            // 
            // rbD4
            // 
            this.rbD4.AutoSize = true;
            this.rbD4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD4.Location = new System.Drawing.Point(117, 173);
            this.rbD4.Name = "rbD4";
            this.rbD4.Size = new System.Drawing.Size(39, 17);
            this.rbD4.TabIndex = 3;
            this.rbD4.TabStop = true;
            this.rbD4.Tag = "4";
            this.rbD4.Text = "D4";
            this.rbD4.UseVisualStyleBackColor = false;
            // 
            // rbD6
            // 
            this.rbD6.AutoSize = true;
            this.rbD6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD6.Location = new System.Drawing.Point(205, 172);
            this.rbD6.Name = "rbD6";
            this.rbD6.Size = new System.Drawing.Size(39, 17);
            this.rbD6.TabIndex = 4;
            this.rbD6.TabStop = true;
            this.rbD6.Tag = "6";
            this.rbD6.Text = "D6";
            this.rbD6.UseVisualStyleBackColor = false;
            // 
            // rbD8
            // 
            this.rbD8.AutoSize = true;
            this.rbD8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD8.Location = new System.Drawing.Point(301, 172);
            this.rbD8.Name = "rbD8";
            this.rbD8.Size = new System.Drawing.Size(39, 17);
            this.rbD8.TabIndex = 5;
            this.rbD8.TabStop = true;
            this.rbD8.Tag = "8";
            this.rbD8.Text = "D8";
            this.rbD8.UseVisualStyleBackColor = false;
            // 
            // rbD10
            // 
            this.rbD10.AutoSize = true;
            this.rbD10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD10.Location = new System.Drawing.Point(389, 172);
            this.rbD10.Name = "rbD10";
            this.rbD10.Size = new System.Drawing.Size(45, 17);
            this.rbD10.TabIndex = 6;
            this.rbD10.TabStop = true;
            this.rbD10.Tag = "10";
            this.rbD10.Text = "D10";
            this.rbD10.UseVisualStyleBackColor = false;
            // 
            // rbD12
            // 
            this.rbD12.AutoSize = true;
            this.rbD12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD12.Location = new System.Drawing.Point(494, 173);
            this.rbD12.Name = "rbD12";
            this.rbD12.Size = new System.Drawing.Size(45, 17);
            this.rbD12.TabIndex = 7;
            this.rbD12.TabStop = true;
            this.rbD12.Tag = "12";
            this.rbD12.Text = "D12";
            this.rbD12.UseVisualStyleBackColor = false;
            // 
            // rbD20
            // 
            this.rbD20.AutoSize = true;
            this.rbD20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD20.Location = new System.Drawing.Point(589, 173);
            this.rbD20.Name = "rbD20";
            this.rbD20.Size = new System.Drawing.Size(45, 17);
            this.rbD20.TabIndex = 8;
            this.rbD20.TabStop = true;
            this.rbD20.Tag = "20";
            this.rbD20.Text = "D20";
            this.rbD20.UseVisualStyleBackColor = false;
            // 
            // rbD100
            // 
            this.rbD100.AutoSize = true;
            this.rbD100.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbD100.Location = new System.Drawing.Point(685, 173);
            this.rbD100.Name = "rbD100";
            this.rbD100.Size = new System.Drawing.Size(51, 17);
            this.rbD100.TabIndex = 9;
            this.rbD100.TabStop = true;
            this.rbD100.Tag = "100";
            this.rbD100.Text = "D100";
            this.rbD100.UseVisualStyleBackColor = false;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbType.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(68, 64);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(123, 22);
            this.lbType.TabIndex = 10;
            this.lbType.Text = "What type of Dice?";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DNDDiceSim.Properties.Resources.d100_dice_1x1;
            this.pictureBox7.Location = new System.Drawing.Point(675, 80);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(87, 90);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DNDDiceSim.Properties.Resources.D20;
            this.pictureBox6.Location = new System.Drawing.Point(572, 86);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 81);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DNDDiceSim.Properties.Resources.D12;
            this.pictureBox5.Location = new System.Drawing.Point(475, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 85);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DNDDiceSim.Properties.Resources.D10;
            this.pictureBox4.Location = new System.Drawing.Point(381, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 85);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DNDDiceSim.Properties.Resources.D8;
            this.pictureBox3.Location = new System.Drawing.Point(282, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 74);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DNDDiceSim.Properties.Resources.D6;
            this.pictureBox2.Location = new System.Drawing.Point(189, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 63);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DNDDiceSim.Properties.Resources.D4;
            this.pictureBox1.Location = new System.Drawing.Point(98, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 64);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pbCoin
            // 
            this.pbCoin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCoin.Image = ((System.Drawing.Image)(resources.GetObject("pbCoin.Image")));
            this.pbCoin.Location = new System.Drawing.Point(17, 96);
            this.pbCoin.Name = "pbCoin";
            this.pbCoin.Size = new System.Drawing.Size(68, 66);
            this.pbCoin.TabIndex = 11;
            this.pbCoin.TabStop = false;
            // 
            // btRoll
            // 
            this.btRoll.Location = new System.Drawing.Point(33, 237);
            this.btRoll.Name = "btRoll";
            this.btRoll.Size = new System.Drawing.Size(75, 23);
            this.btRoll.TabIndex = 26;
            this.btRoll.Text = "Roll";
            this.btRoll.UseVisualStyleBackColor = true;
            this.btRoll.Click += new System.EventHandler(this.btRoll_Click);
            // 
            // txResults
            // 
            this.txResults.Location = new System.Drawing.Point(138, 237);
            this.txResults.Multiline = true;
            this.txResults.Name = "txResults";
            this.txResults.Size = new System.Drawing.Size(269, 138);
            this.txResults.TabIndex = 27;
            this.txResults.TextChanged += new System.EventHandler(this.txResults_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DNDDiceSim.Properties.Resources.Dnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 389);
            this.Controls.Add(this.txResults);
            this.Controls.Add(this.btRoll);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCoin);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.rbD100);
            this.Controls.Add(this.rbD20);
            this.Controls.Add(this.rbD12);
            this.Controls.Add(this.rbD10);
            this.Controls.Add(this.rbD8);
            this.Controls.Add(this.rbD6);
            this.Controls.Add(this.rbD4);
            this.Controls.Add(this.rbD2);
            this.Controls.Add(this.numDice);
            this.Controls.Add(this.lbNumDice);
            this.Name = "Form1";
            this.Text = "Dungeons & Dragons Dice";
            ((System.ComponentModel.ISupportInitialize)(this.numDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumDice;
        private System.Windows.Forms.NumericUpDown numDice;
        private System.Windows.Forms.RadioButton rbD2;
        private System.Windows.Forms.RadioButton rbD4;
        private System.Windows.Forms.RadioButton rbD6;
        private System.Windows.Forms.RadioButton rbD8;
        private System.Windows.Forms.RadioButton rbD10;
        private System.Windows.Forms.RadioButton rbD12;
        private System.Windows.Forms.RadioButton rbD20;
        private System.Windows.Forms.RadioButton rbD100;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btRoll;
        private System.Windows.Forms.TextBox txResults;
    }
}

