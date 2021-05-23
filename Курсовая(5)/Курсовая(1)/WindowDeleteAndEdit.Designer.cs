
namespace Курсовая_1_
{
    partial class WindowDeleteAndEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowDeleteAndEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.showDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoBackToMenu = new System.Windows.Forms.Button();
            this.textBoxDelet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1004, 98);
            this.label1.TabIndex = 5;
            this.label1.Text = "База Данных";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuDelete.BackColor = System.Drawing.Color.Silver;
            this.btnMenuDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDelete.FlatAppearance.BorderSize = 5;
            this.btnMenuDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnMenuDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDelete.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenuDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenuDelete.Location = new System.Drawing.Point(610, 250);
            this.btnMenuDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(375, 58);
            this.btnMenuDelete.TabIndex = 8;
            this.btnMenuDelete.Text = "Удалить запись о писателе";
            this.btnMenuDelete.UseVisualStyleBackColor = false;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnMenuDelete_Click);
            // 
            // showDB
            // 
            this.showDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showDB.BackColor = System.Drawing.Color.Silver;
            this.showDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDB.FlatAppearance.BorderSize = 5;
            this.showDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.showDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDB.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.showDB.Location = new System.Drawing.Point(610, 409);
            this.showDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showDB.Name = "showDB";
            this.showDB.Size = new System.Drawing.Size(375, 58);
            this.showDB.TabIndex = 14;
            this.showDB.Text = "Обновить базу данных";
            this.showDB.UseVisualStyleBackColor = false;
            this.showDB.Click += new System.EventHandler(this.showDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 173);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 374);
            this.dataGridView1.TabIndex = 15;
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
            this.btnGoBackToMenu.Location = new System.Drawing.Point(8, 111);
            this.btnGoBackToMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoBackToMenu.Name = "btnGoBackToMenu";
            this.btnGoBackToMenu.Size = new System.Drawing.Size(151, 44);
            this.btnGoBackToMenu.TabIndex = 16;
            this.btnGoBackToMenu.Text = "Вернуться в меню";
            this.btnGoBackToMenu.UseVisualStyleBackColor = false;
            this.btnGoBackToMenu.Click += new System.EventHandler(this.btnGoBackToMenu_Click);
            // 
            // textBoxDelet
            // 
            this.textBoxDelet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDelet.BackColor = System.Drawing.Color.Silver;
            this.textBoxDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDelet.Location = new System.Drawing.Point(39, 561);
            this.textBoxDelet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDelet.Name = "textBoxDelet";
            this.textBoxDelet.Size = new System.Drawing.Size(432, 26);
            this.textBoxDelet.TabIndex = 12;
            this.textBoxDelet.Enter += new System.EventHandler(this.textBoxDelet_Enter);
            this.textBoxDelet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDelet_KeyPress);
            this.textBoxDelet.Leave += new System.EventHandler(this.textBoxDelet_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(610, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Редоктировать ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowDeleteAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoBackToMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showDB);
            this.Controls.Add(this.textBoxDelet);
            this.Controls.Add(this.btnMenuDelete);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WindowDeleteAndEdit";
            this.Text = "Справочник";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuDelete;
        private System.Windows.Forms.Button showDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoBackToMenu;
        private System.Windows.Forms.TextBox textBoxDelet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}