
namespace Курсовая_1_
{
    partial class WindowAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowAdd));
            this.btnGoBackToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddWriter = new System.Windows.Forms.TextBox();
            this.txtAddBook = new System.Windows.Forms.TextBox();
            this.txtAddLanguage = new System.Windows.Forms.TextBox();
            this.txtAddGanre = new System.Windows.Forms.TextBox();
            this.txtAddCountry = new System.Windows.Forms.TextBox();
            this.txtAddEdition = new System.Windows.Forms.TextBox();
            this.txtAddPublishing = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.editing = new System.Windows.Forms.Button();
            this.textBoxEditing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoBackToMenu
            // 
            this.btnGoBackToMenu.AutoSize = true;
            this.btnGoBackToMenu.BackColor = System.Drawing.Color.Silver;
            this.btnGoBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBackToMenu.FlatAppearance.BorderSize = 3;
            this.btnGoBackToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoBackToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnGoBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToMenu.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBackToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGoBackToMenu.Location = new System.Drawing.Point(8, 116);
            this.btnGoBackToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBackToMenu.Name = "btnGoBackToMenu";
            this.btnGoBackToMenu.Size = new System.Drawing.Size(151, 44);
            this.btnGoBackToMenu.TabIndex = 11;
            this.btnGoBackToMenu.Text = "Вернуться в меню";
            this.btnGoBackToMenu.UseVisualStyleBackColor = false;
            this.btnGoBackToMenu.Click += new System.EventHandler(this.btnGoBackToMenu_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 98);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавление новой записи и изменения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая_1_.Properties.Resources.Безымянный;
            this.pictureBox1.Location = new System.Drawing.Point(881, 509);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtAddWriter
            // 
            this.txtAddWriter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddWriter.BackColor = System.Drawing.Color.Silver;
            this.txtAddWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddWriter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddWriter.Location = new System.Drawing.Point(55, 236);
            this.txtAddWriter.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddWriter.Name = "txtAddWriter";
            this.txtAddWriter.Size = new System.Drawing.Size(406, 26);
            this.txtAddWriter.TabIndex = 14;
            this.txtAddWriter.Enter += new System.EventHandler(this.txtAddWriter_Enter);
            this.txtAddWriter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddWriter_KeyPress);
            this.txtAddWriter.Leave += new System.EventHandler(this.txtAddWriter_Leave);
            // 
            // txtAddBook
            // 
            this.txtAddBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddBook.BackColor = System.Drawing.Color.Silver;
            this.txtAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddBook.Location = new System.Drawing.Point(55, 277);
            this.txtAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddBook.Name = "txtAddBook";
            this.txtAddBook.Size = new System.Drawing.Size(406, 26);
            this.txtAddBook.TabIndex = 15;
            this.txtAddBook.Enter += new System.EventHandler(this.txtAddBook_Enter);
            this.txtAddBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddBook_KeyPress);
            this.txtAddBook.Leave += new System.EventHandler(this.txtAddBook_Leave);
            // 
            // txtAddLanguage
            // 
            this.txtAddLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddLanguage.BackColor = System.Drawing.Color.Silver;
            this.txtAddLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddLanguage.Location = new System.Drawing.Point(55, 400);
            this.txtAddLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLanguage.Name = "txtAddLanguage";
            this.txtAddLanguage.Size = new System.Drawing.Size(406, 26);
            this.txtAddLanguage.TabIndex = 16;
            this.txtAddLanguage.Enter += new System.EventHandler(this.txtAddLanguage_Enter);
            this.txtAddLanguage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddLanguage_KeyPress);
            this.txtAddLanguage.Leave += new System.EventHandler(this.txtAddLanguage_Leave);
            // 
            // txtAddGanre
            // 
            this.txtAddGanre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddGanre.BackColor = System.Drawing.Color.Silver;
            this.txtAddGanre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddGanre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddGanre.Location = new System.Drawing.Point(55, 320);
            this.txtAddGanre.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddGanre.Name = "txtAddGanre";
            this.txtAddGanre.Size = new System.Drawing.Size(406, 26);
            this.txtAddGanre.TabIndex = 16;
            this.txtAddGanre.Enter += new System.EventHandler(this.txtAddGanre_Enter);
            this.txtAddGanre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddGanre_KeyPress);
            this.txtAddGanre.Leave += new System.EventHandler(this.txtAddGanre_Leave);
            // 
            // txtAddCountry
            // 
            this.txtAddCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddCountry.BackColor = System.Drawing.Color.Silver;
            this.txtAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddCountry.Location = new System.Drawing.Point(55, 359);
            this.txtAddCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddCountry.Name = "txtAddCountry";
            this.txtAddCountry.Size = new System.Drawing.Size(406, 26);
            this.txtAddCountry.TabIndex = 17;
            this.txtAddCountry.Enter += new System.EventHandler(this.txtAddCountry_Enter);
            this.txtAddCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddCountry_KeyPress);
            this.txtAddCountry.Leave += new System.EventHandler(this.txtAddCountry_Leave);
            // 
            // txtAddEdition
            // 
            this.txtAddEdition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddEdition.BackColor = System.Drawing.Color.Silver;
            this.txtAddEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddEdition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddEdition.Location = new System.Drawing.Point(55, 440);
            this.txtAddEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddEdition.Name = "txtAddEdition";
            this.txtAddEdition.Size = new System.Drawing.Size(406, 26);
            this.txtAddEdition.TabIndex = 18;
            this.txtAddEdition.Enter += new System.EventHandler(this.txtAddEdition_Enter);
            this.txtAddEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddEdition_KeyPress);
            this.txtAddEdition.Leave += new System.EventHandler(this.txtAddEdition_Leave);
            // 
            // txtAddPublishing
            // 
            this.txtAddPublishing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddPublishing.BackColor = System.Drawing.Color.Silver;
            this.txtAddPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddPublishing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddPublishing.Location = new System.Drawing.Point(55, 482);
            this.txtAddPublishing.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddPublishing.Name = "txtAddPublishing";
            this.txtAddPublishing.Size = new System.Drawing.Size(406, 26);
            this.txtAddPublishing.TabIndex = 19;
            this.txtAddPublishing.Enter += new System.EventHandler(this.txtAddPublishing_Enter);
            this.txtAddPublishing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPublishing_KeyPress);
            this.txtAddPublishing.Leave += new System.EventHandler(this.txtAddPublishing_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(560, 236);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(362, 44);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Введите необходимые данные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 164);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(496, 428);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // editing
            // 
            this.editing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editing.AutoSize = true;
            this.editing.BackColor = System.Drawing.Color.Silver;
            this.editing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editing.FlatAppearance.BorderSize = 3;
            this.editing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.editing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editing.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editing.Location = new System.Drawing.Point(560, 461);
            this.editing.Margin = new System.Windows.Forms.Padding(2);
            this.editing.Name = "editing";
            this.editing.Size = new System.Drawing.Size(362, 44);
            this.editing.TabIndex = 23;
            this.editing.Text = "Изменить";
            this.editing.UseVisualStyleBackColor = false;
            this.editing.Click += new System.EventHandler(this.editing_Click);
            // 
            // textBoxEditing
            // 
            this.textBoxEditing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEditing.BackColor = System.Drawing.Color.Silver;
            this.textBoxEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxEditing.Location = new System.Drawing.Point(560, 431);
            this.textBoxEditing.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditing.Name = "textBoxEditing";
            this.textBoxEditing.Size = new System.Drawing.Size(362, 26);
            this.textBoxEditing.TabIndex = 24;
            this.textBoxEditing.Enter += new System.EventHandler(this.textBoxEditing_Enter);
            this.textBoxEditing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditing_KeyPress);
            this.textBoxEditing.Leave += new System.EventHandler(this.textBoxEditing_Leave);
            // 
            // WindowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.Controls.Add(this.textBoxEditing);
            this.Controls.Add(this.editing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddPublishing);
            this.Controls.Add(this.txtAddEdition);
            this.Controls.Add(this.txtAddCountry);
            this.Controls.Add(this.txtAddGanre);
            this.Controls.Add(this.txtAddLanguage);
            this.Controls.Add(this.txtAddBook);
            this.Controls.Add(this.txtAddWriter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBackToMenu);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WindowAdd";
            this.Text = "Справочник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGoBackToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAddWriter;
        private System.Windows.Forms.TextBox txtAddBook;
        private System.Windows.Forms.TextBox txtAddLanguage;
        private System.Windows.Forms.TextBox txtAddGanre;
        private System.Windows.Forms.TextBox txtAddCountry;
        private System.Windows.Forms.TextBox txtAddEdition;
        private System.Windows.Forms.TextBox txtAddPublishing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button editing;
        private System.Windows.Forms.TextBox textBoxEditing;
    }
}