﻿namespace BesseresSBB
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
            this.tabctrlMenu = new System.Windows.Forms.TabControl();
            this.tabVerbindungSuchen = new System.Windows.Forms.TabPage();
            this.livVerbindungen = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.switchStations = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabFahrplan = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.btnFahrplanSuchen = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.livStationBoard = new System.Windows.Forms.ListView();
            this.tabctrlMenu.SuspendLayout();
            this.tabVerbindungSuchen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabFahrplan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlMenu
            // 
            this.tabctrlMenu.Controls.Add(this.tabVerbindungSuchen);
            this.tabctrlMenu.Controls.Add(this.tabFahrplan);
            this.tabctrlMenu.Controls.Add(this.tabPage1);
            this.tabctrlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlMenu.Location = new System.Drawing.Point(12, 12);
            this.tabctrlMenu.Name = "tabctrlMenu";
            this.tabctrlMenu.SelectedIndex = 0;
            this.tabctrlMenu.Size = new System.Drawing.Size(608, 541);
            this.tabctrlMenu.TabIndex = 1;
            // 
            // tabVerbindungSuchen
            // 
            this.tabVerbindungSuchen.BackColor = System.Drawing.Color.Gainsboro;
            this.tabVerbindungSuchen.Controls.Add(this.livVerbindungen);
            this.tabVerbindungSuchen.Controls.Add(this.panel1);
            this.tabVerbindungSuchen.Location = new System.Drawing.Point(4, 33);
            this.tabVerbindungSuchen.Name = "tabVerbindungSuchen";
            this.tabVerbindungSuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerbindungSuchen.Size = new System.Drawing.Size(600, 504);
            this.tabVerbindungSuchen.TabIndex = 0;
            this.tabVerbindungSuchen.Text = "Verbindung suchen";
            // 
            // livVerbindungen
            // 
            this.livVerbindungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livVerbindungen.Location = new System.Drawing.Point(8, 175);
            this.livVerbindungen.Name = "livVerbindungen";
            this.livVerbindungen.Size = new System.Drawing.Size(582, 204);
            this.livVerbindungen.TabIndex = 12;
            this.livVerbindungen.TileSize = new System.Drawing.Size(50, 50);
            this.livVerbindungen.UseCompatibleStateImageBehavior = false;
            this.livVerbindungen.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNach);
            this.panel1.Controls.Add(this.lblVon);
            this.panel1.Controls.Add(this.txtVon);
            this.panel1.Controls.Add(this.txtNach);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.switchStations);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(8, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 146);
            this.panel1.TabIndex = 11;
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNach.Location = new System.Drawing.Point(346, 13);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(55, 24);
            this.lblNach.TabIndex = 1;
            this.lblNach.Text = "Nach";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.Location = new System.Drawing.Point(19, 13);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(45, 24);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von";
            // 
            // txtVon
            // 
            this.txtVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVon.Location = new System.Drawing.Point(19, 40);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(220, 29);
            this.txtVon.TabIndex = 2;
            // 
            // txtNach
            // 
            this.txtNach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNach.Location = new System.Drawing.Point(350, 40);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(220, 29);
            this.txtNach.TabIndex = 3;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(350, 95);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(220, 31);
            this.search.TabIndex = 6;
            this.search.Text = "Suchen";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // switchStations
            // 
            this.switchStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchStations.Location = new System.Drawing.Point(267, 40);
            this.switchStations.Name = "switchStations";
            this.switchStations.Size = new System.Drawing.Size(59, 29);
            this.switchStations.TabIndex = 4;
            this.switchStations.Text = "<--->";
            this.switchStations.UseVisualStyleBackColor = true;
            this.switchStations.Click += new System.EventHandler(this.switchStations_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(19, 95);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(307, 29);
            this.dateTimePicker.TabIndex = 5;
            // 
            // tabFahrplan
            // 
            this.tabFahrplan.BackColor = System.Drawing.Color.LightGray;
            this.tabFahrplan.Controls.Add(this.livStationBoard);
            this.tabFahrplan.Controls.Add(this.panel2);
            this.tabFahrplan.Location = new System.Drawing.Point(4, 33);
            this.tabFahrplan.Name = "tabFahrplan";
            this.tabFahrplan.Padding = new System.Windows.Forms.Padding(3);
            this.tabFahrplan.Size = new System.Drawing.Size(600, 504);
            this.tabFahrplan.TabIndex = 1;
            this.tabFahrplan.Text = "Fahrplan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStation);
            this.panel2.Controls.Add(this.txtStation);
            this.panel2.Controls.Add(this.btnFahrplanSuchen);
            this.panel2.Location = new System.Drawing.Point(8, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 134);
            this.panel2.TabIndex = 12;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(259, 13);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(66, 24);
            this.lblStation.TabIndex = 2;
            this.lblStation.Text = "Station";
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStation.Location = new System.Drawing.Point(168, 40);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(233, 29);
            this.txtStation.TabIndex = 1;
            // 
            // btnFahrplanSuchen
            // 
            this.btnFahrplanSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrplanSuchen.Location = new System.Drawing.Point(221, 79);
            this.btnFahrplanSuchen.Name = "btnFahrplanSuchen";
            this.btnFahrplanSuchen.Size = new System.Drawing.Size(130, 37);
            this.btnFahrplanSuchen.TabIndex = 0;
            this.btnFahrplanSuchen.Text = "Suche";
            this.btnFahrplanSuchen.UseVisualStyleBackColor = true;
            this.btnFahrplanSuchen.Click += new System.EventHandler(this.btnFahrplanSuchen_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 504);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // livStationBoard
            // 
            this.livStationBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livStationBoard.Location = new System.Drawing.Point(8, 160);
            this.livStationBoard.Name = "livStationBoard";
            this.livStationBoard.Size = new System.Drawing.Size(586, 299);
            this.livStationBoard.TabIndex = 13;
            this.livStationBoard.UseCompatibleStateImageBehavior = false;
            this.livStationBoard.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 560);
            this.Controls.Add(this.tabctrlMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabctrlMenu.ResumeLayout(false);
            this.tabVerbindungSuchen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFahrplan.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlMenu;
        private System.Windows.Forms.TabPage tabVerbindungSuchen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button switchStations;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TabPage tabFahrplan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Button btnFahrplanSuchen;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView livVerbindungen;
        private System.Windows.Forms.ListView livStationBoard;
    }
}

