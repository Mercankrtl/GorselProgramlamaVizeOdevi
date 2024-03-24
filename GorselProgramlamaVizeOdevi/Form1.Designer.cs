namespace GorselProgramlamaVizeOdevi
{
    partial class AnaSayfa
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
            groupBox1 = new GroupBox();
            btmUyeListele = new Button();
            groupBox2 = new GroupBox();
            btnKitapListele = new Button();
            groupBox3 = new GroupBox();
            btnEmanetVer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btmUyeListele);
            groupBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(58, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye slemlerı";
            // 
            // btmUyeListele
            // 
            btmUyeListele.Location = new Point(15, 43);
            btmUyeListele.Name = "btmUyeListele";
            btmUyeListele.Size = new Size(281, 29);
            btmUyeListele.TabIndex = 1;
            btmUyeListele.Text = "Uye Listeleme Islemleri";
            btmUyeListele.UseVisualStyleBackColor = true;
            btmUyeListele.Click += btmUyeListele_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKitapListele);
            groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(58, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Islemleri";
            // 
            // btnKitapListele
            // 
            btnKitapListele.Location = new Point(15, 43);
            btnKitapListele.Name = "btnKitapListele";
            btnKitapListele.Size = new Size(281, 29);
            btnKitapListele.TabIndex = 1;
            btnKitapListele.Text = "Kitap Listeleme Islemleri";
            btnKitapListele.UseVisualStyleBackColor = true;
            btnKitapListele.Click += btnKitapListele_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEmanetVer);
            groupBox3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(58, 352);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(330, 102);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Emanet Kitap  Islemelri";
            // 
            // btnEmanetVer
            // 
            btnEmanetVer.Location = new Point(27, 44);
            btnEmanetVer.Name = "btnEmanetVer";
            btnEmanetVer.Size = new Size(269, 29);
            btnEmanetVer.TabIndex = 0;
            btnEmanetVer.Text = "Emanet Kitap Islemleri";
            btnEmanetVer.UseVisualStyleBackColor = true;
            btnEmanetVer.Click += btnEmanetVer_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(446, 528);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btmUyeListele;
        private Button btnKitapListele;
        private Button btnEmanetVer;
    }
}
