namespace R6RS
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtADS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtMultiplier = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtVertical = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtHorizontal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LblUpdate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.bunifuDropdown1.Items = new string[] {
        "Ping Based",
        "US East",
        "US Central",
        "US South Central",
        "US West",
        "Brazil South",
        "Europe North",
        "Europe West",
        "Asia East",
        "Asia South East",
        "Australia East",
        "Japan West"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(16, 43);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(182, 39);
            this.bunifuDropdown1.TabIndex = 0;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 51);
            this.panel3.TabIndex = 11;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 21);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "R6 Tools";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.TxtADS);
            this.panel1.Controls.Add(this.TxtMultiplier);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.TxtVertical);
            this.panel1.Controls.Add(this.TxtHorizontal);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 198);
            this.panel1.TabIndex = 3;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(10, 9);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel7.TabIndex = 9;
            this.bunifuCustomLabel7.Text = "Sensitivity";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(102, 117);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "Vertical";
            // 
            // TxtADS
            // 
            this.TxtADS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtADS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtADS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtADS.HintForeColor = System.Drawing.Color.Empty;
            this.TxtADS.HintText = "";
            this.TxtADS.isPassword = false;
            this.TxtADS.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtADS.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TxtADS.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtADS.LineThickness = 3;
            this.TxtADS.Location = new System.Drawing.Point(105, 138);
            this.TxtADS.Margin = new System.Windows.Forms.Padding(4);
            this.TxtADS.Name = "TxtADS";
            this.TxtADS.Size = new System.Drawing.Size(61, 33);
            this.TxtADS.TabIndex = 7;
            this.TxtADS.Text = "bunifuMaterialTextbox1";
            this.TxtADS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtMultiplier
            // 
            this.TxtMultiplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMultiplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMultiplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtMultiplier.HintForeColor = System.Drawing.Color.Empty;
            this.TxtMultiplier.HintText = "";
            this.TxtMultiplier.isPassword = false;
            this.TxtMultiplier.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtMultiplier.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TxtMultiplier.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtMultiplier.LineThickness = 3;
            this.TxtMultiplier.Location = new System.Drawing.Point(105, 71);
            this.TxtMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMultiplier.Name = "TxtMultiplier";
            this.TxtMultiplier.Size = new System.Drawing.Size(74, 33);
            this.TxtMultiplier.TabIndex = 6;
            this.TxtMultiplier.Text = "bunifuMaterialTextbox1";
            this.TxtMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(102, 50);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Multiplier";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(10, 117);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Vertical";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(10, 50);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(68, 17);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Horizontal";
            // 
            // TxtVertical
            // 
            this.TxtVertical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtVertical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVertical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtVertical.HintForeColor = System.Drawing.Color.Empty;
            this.TxtVertical.HintText = "";
            this.TxtVertical.isPassword = false;
            this.TxtVertical.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtVertical.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TxtVertical.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtVertical.LineThickness = 3;
            this.TxtVertical.Location = new System.Drawing.Point(13, 138);
            this.TxtVertical.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVertical.Name = "TxtVertical";
            this.TxtVertical.Size = new System.Drawing.Size(61, 33);
            this.TxtVertical.TabIndex = 2;
            this.TxtVertical.Text = "bunifuMaterialTextbox1";
            this.TxtVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtHorizontal
            // 
            this.TxtHorizontal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHorizontal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHorizontal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtHorizontal.HintForeColor = System.Drawing.Color.Empty;
            this.TxtHorizontal.HintText = "";
            this.TxtHorizontal.isPassword = false;
            this.TxtHorizontal.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtHorizontal.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TxtHorizontal.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.TxtHorizontal.LineThickness = 3;
            this.TxtHorizontal.Location = new System.Drawing.Point(13, 71);
            this.TxtHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHorizontal.Name = "TxtHorizontal";
            this.TxtHorizontal.Size = new System.Drawing.Size(61, 33);
            this.TxtHorizontal.TabIndex = 1;
            this.TxtHorizontal.Text = "bunifuMaterialTextbox1";
            this.TxtHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuDropdown1);
            this.panel2.Location = new System.Drawing.Point(214, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 198);
            this.panel2.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 21);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Region";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(194, 55);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(18, 195);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // LblUpdate
            // 
            this.LblUpdate.AutoSize = true;
            this.LblUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(222)))));
            this.LblUpdate.Location = new System.Drawing.Point(4, 236);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(0, 17);
            this.LblUpdate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.LblUpdate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtHorizontal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtVertical;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtMultiplier;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtADS;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomLabel LblUpdate;
    }
}

