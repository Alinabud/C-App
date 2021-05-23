
namespace Курсовая_1_
{
    partial class WindowFirst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowFirst));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnterToSystem = new System.Windows.Forms.Button();
            this.infoProgram = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BlueViolet;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать\r\nв справочник о писателях!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnterToSystem
            // 
            this.btnEnterToSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnterToSystem.BackColor = System.Drawing.Color.Silver;
            this.btnEnterToSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterToSystem.FlatAppearance.BorderSize = 5;
            this.btnEnterToSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnterToSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnEnterToSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterToSystem.Font = new System.Drawing.Font("Monotype Corsiva", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterToSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEnterToSystem.Location = new System.Drawing.Point(129, 510);
            this.btnEnterToSystem.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterToSystem.Name = "btnEnterToSystem";
            this.btnEnterToSystem.Size = new System.Drawing.Size(772, 81);
            this.btnEnterToSystem.TabIndex = 2;
            this.btnEnterToSystem.Text = "Войти в систему";
            this.btnEnterToSystem.UseVisualStyleBackColor = false;
            this.btnEnterToSystem.Click += new System.EventHandler(this.btnEnterToSystem_Click);
            // 
            // infoProgram
            // 
            this.infoProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoProgram.BackColor = System.Drawing.Color.Silver;
            this.infoProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoProgram.FlatAppearance.BorderSize = 5;
            this.infoProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.infoProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.infoProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoProgram.Font = new System.Drawing.Font("Monotype Corsiva", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.infoProgram.Location = new System.Drawing.Point(376, 595);
            this.infoProgram.Margin = new System.Windows.Forms.Padding(2);
            this.infoProgram.Name = "infoProgram";
            this.infoProgram.Size = new System.Drawing.Size(289, 35);
            this.infoProgram.TabIndex = 3;
            this.infoProgram.Text = "Информация о программе";
            this.infoProgram.UseVisualStyleBackColor = false;
            this.infoProgram.Click += new System.EventHandler(this.infoProgram_Click);
            // 
            // WindowFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 641);
            this.Controls.Add(this.infoProgram);
            this.Controls.Add(this.btnEnterToSystem);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WindowFirst";
            this.Text = "Справочник";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterToSystem;
        private System.Windows.Forms.Button infoProgram;
    }
}