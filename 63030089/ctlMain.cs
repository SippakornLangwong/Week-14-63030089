using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SippakornLangwong
{
	/// <summary>
	/// Summary description for ctlMain.
	/// </summary>
	public class ctlMain : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlMain()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Teacher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Name is Sippakorn Langwong";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher, are you okay?";
            // 
            // ctlMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(567, 512);
            this.Resize += new System.EventHandler(this.ctlMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		int newH = 0;
		int newV = 0;
			
		Random rndH = new Random(20);
        private Label label1;
        private Label label2;
        private Label label3;
        Random rndV = new Random(20);
		
		private void MoveButton()
		{
			newH = rndH.Next(this.Width - 40);
			
			
			newV = rndV.Next(this.Height - 40);
			
			//this.butMain.Top = newV;
			//this.butMain.Left = newH;
		}
		
		private void butMain_Click(object sender, System.EventArgs e)
		{
			this.MoveButton();			
		}

		private void ctlMain_Resize(object sender, System.EventArgs e)
		{
			this.MoveButton();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
