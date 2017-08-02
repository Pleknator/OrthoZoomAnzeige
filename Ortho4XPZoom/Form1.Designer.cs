namespace Ortho4XP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listViewKacheln = new System.Windows.Forms.ListView();
            this.columnHeaderKachel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZommlevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPfad = new System.Windows.Forms.TextBox();
            this.columnHeaderGröße = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(537, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lese Datei";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewKacheln
            // 
            this.listViewKacheln.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKachel,
            this.columnHeaderMap,
            this.columnHeaderZommlevel,
            this.columnHeaderGröße});
            this.listViewKacheln.FullRowSelect = true;
            this.listViewKacheln.GridLines = true;
            this.listViewKacheln.Location = new System.Drawing.Point(12, 12);
            this.listViewKacheln.Name = "listViewKacheln";
            this.listViewKacheln.Size = new System.Drawing.Size(537, 401);
            this.listViewKacheln.TabIndex = 1;
            this.listViewKacheln.UseCompatibleStateImageBehavior = false;
            this.listViewKacheln.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderKachel
            // 
            this.columnHeaderKachel.Text = "Kachel";
            this.columnHeaderKachel.Width = 180;
            // 
            // columnHeaderMap
            // 
            this.columnHeaderMap.Text = "Kartendienst";
            this.columnHeaderMap.Width = 120;
            // 
            // columnHeaderZommlevel
            // 
            this.columnHeaderZommlevel.Text = "Zoomlevel";
            this.columnHeaderZommlevel.Width = 70;
            // 
            // textBoxPfad
            // 
            this.textBoxPfad.Location = new System.Drawing.Point(12, 455);
            this.textBoxPfad.Name = "textBoxPfad";
            this.textBoxPfad.Size = new System.Drawing.Size(537, 20);
            this.textBoxPfad.TabIndex = 2;
            // 
            // columnHeaderGröße
            // 
            this.columnHeaderGröße.Text = "Verzeichnisgröße in MB";
            this.columnHeaderGröße.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 487);
            this.Controls.Add(this.textBoxPfad);
            this.Controls.Add(this.listViewKacheln);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ortho4XP Zoomlevelanzeige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewKacheln;
        private System.Windows.Forms.ColumnHeader columnHeaderKachel;
        private System.Windows.Forms.ColumnHeader columnHeaderMap;
        private System.Windows.Forms.ColumnHeader columnHeaderZommlevel;
        private System.Windows.Forms.TextBox textBoxPfad;
        private System.Windows.Forms.ColumnHeader columnHeaderGröße;
    }
}

