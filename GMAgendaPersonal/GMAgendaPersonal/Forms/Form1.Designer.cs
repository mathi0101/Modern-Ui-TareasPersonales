namespace GMAgendaPersonal.Forms {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
			this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage3 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetTabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroSetTabControl1
			// 
			this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
			this.metroSetTabControl1.AnimateTime = 200;
			this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
			this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage1);
			this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage2);
			this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage3);
			this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.metroSetTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroSetTabControl1.IsDerivedStyle = true;
			this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
			this.metroSetTabControl1.Location = new System.Drawing.Point(12, 70);
			this.metroSetTabControl1.Name = "metroSetTabControl1";
			this.metroSetTabControl1.SelectedIndex = 0;
			this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
			this.metroSetTabControl1.Size = new System.Drawing.Size(776, 368);
			this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.metroSetTabControl1.Speed = 100;
			this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetTabControl1.StyleManager = null;
			this.metroSetTabControl1.TabIndex = 0;
			this.metroSetTabControl1.ThemeAuthor = "Narwin";
			this.metroSetTabControl1.ThemeName = "MetroLite";
			this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
			this.metroSetTabControl1.UseAnimation = false;
			// 
			// metroSetSetTabPage1
			// 
			this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.White;
			this.metroSetSetTabPage1.Font = null;
			this.metroSetSetTabPage1.ImageIndex = 0;
			this.metroSetSetTabPage1.ImageKey = null;
			this.metroSetSetTabPage1.IsDerivedStyle = true;
			this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
			this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
			this.metroSetSetTabPage1.Size = new System.Drawing.Size(768, 322);
			this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage1.StyleManager = null;
			this.metroSetSetTabPage1.TabIndex = 0;
			this.metroSetSetTabPage1.Text = "metroSetSetTabPage1";
			this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage1.ThemeName = "MetroLite";
			this.metroSetSetTabPage1.ToolTipText = null;
			// 
			// metroSetSetTabPage2
			// 
			this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.White;
			this.metroSetSetTabPage2.Font = null;
			this.metroSetSetTabPage2.ImageIndex = 0;
			this.metroSetSetTabPage2.ImageKey = null;
			this.metroSetSetTabPage2.IsDerivedStyle = true;
			this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
			this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
			this.metroSetSetTabPage2.Size = new System.Drawing.Size(768, 322);
			this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage2.StyleManager = null;
			this.metroSetSetTabPage2.TabIndex = 1;
			this.metroSetSetTabPage2.Text = "metroSetSetTabPage2";
			this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage2.ThemeName = "MetroLite";
			this.metroSetSetTabPage2.ToolTipText = null;
			// 
			// metroSetSetTabPage3
			// 
			this.metroSetSetTabPage3.BaseColor = System.Drawing.Color.White;
			this.metroSetSetTabPage3.Font = null;
			this.metroSetSetTabPage3.ImageIndex = 0;
			this.metroSetSetTabPage3.ImageKey = null;
			this.metroSetSetTabPage3.IsDerivedStyle = true;
			this.metroSetSetTabPage3.Location = new System.Drawing.Point(4, 42);
			this.metroSetSetTabPage3.Name = "metroSetSetTabPage3";
			this.metroSetSetTabPage3.Size = new System.Drawing.Size(768, 322);
			this.metroSetSetTabPage3.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage3.StyleManager = null;
			this.metroSetSetTabPage3.TabIndex = 2;
			this.metroSetSetTabPage3.Text = "metroSetSetTabPage3";
			this.metroSetSetTabPage3.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage3.ThemeName = "MetroLite";
			this.metroSetSetTabPage3.ToolTipText = null;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroSetTabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.metroSetTabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage3;
	}
}