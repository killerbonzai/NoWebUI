namespace NoWebUI
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
            this.lstThingsToAdd = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThingToAdd = new System.Windows.Forms.Label();
            this.btnThingToAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblThingToRemove = new System.Windows.Forms.Label();
            this.btnThingToRemove = new System.Windows.Forms.Button();
            this.lstThingsToRemove = new System.Windows.Forms.ListBox();
            this.flpThingsAdded = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFlowTest = new System.Windows.Forms.Panel();
            this.pnlThingsAdded = new System.Windows.Forms.Panel();
            this.pnlPanelTest = new System.Windows.Forms.Panel();
            this.pnlTestUserControl = new System.Windows.Forms.Panel();
            this.lblCapture = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flpThingsAdded.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstThingsToAdd
            // 
            this.lstThingsToAdd.FormattingEnabled = true;
            this.lstThingsToAdd.Location = new System.Drawing.Point(12, 12);
            this.lstThingsToAdd.Name = "lstThingsToAdd";
            this.lstThingsToAdd.Size = new System.Drawing.Size(120, 121);
            this.lstThingsToAdd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThingToAdd);
            this.groupBox1.Controls.Add(this.btnThingToAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thing to add";
            // 
            // lblThingToAdd
            // 
            this.lblThingToAdd.AutoSize = true;
            this.lblThingToAdd.Location = new System.Drawing.Point(6, 16);
            this.lblThingToAdd.Name = "lblThingToAdd";
            this.lblThingToAdd.Size = new System.Drawing.Size(35, 13);
            this.lblThingToAdd.TabIndex = 1;
            this.lblThingToAdd.Text = "label1";
            // 
            // btnThingToAdd
            // 
            this.btnThingToAdd.Location = new System.Drawing.Point(39, 70);
            this.btnThingToAdd.Name = "btnThingToAdd";
            this.btnThingToAdd.Size = new System.Drawing.Size(75, 23);
            this.btnThingToAdd.TabIndex = 0;
            this.btnThingToAdd.Text = "Add";
            this.btnThingToAdd.UseVisualStyleBackColor = true;
            this.btnThingToAdd.Click += new System.EventHandler(this.btnThingToAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblThingToRemove);
            this.groupBox2.Controls.Add(this.btnThingToRemove);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 99);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thing to remove";
            // 
            // lblThingToRemove
            // 
            this.lblThingToRemove.AutoSize = true;
            this.lblThingToRemove.Location = new System.Drawing.Point(6, 16);
            this.lblThingToRemove.Name = "lblThingToRemove";
            this.lblThingToRemove.Size = new System.Drawing.Size(35, 13);
            this.lblThingToRemove.TabIndex = 1;
            this.lblThingToRemove.Text = "label2";
            // 
            // btnThingToRemove
            // 
            this.btnThingToRemove.Location = new System.Drawing.Point(39, 70);
            this.btnThingToRemove.Name = "btnThingToRemove";
            this.btnThingToRemove.Size = new System.Drawing.Size(75, 23);
            this.btnThingToRemove.TabIndex = 0;
            this.btnThingToRemove.Text = "Remove";
            this.btnThingToRemove.UseVisualStyleBackColor = true;
            this.btnThingToRemove.Click += new System.EventHandler(this.btnThingToRemove_Click);
            // 
            // lstThingsToRemove
            // 
            this.lstThingsToRemove.FormattingEnabled = true;
            this.lstThingsToRemove.Location = new System.Drawing.Point(12, 244);
            this.lstThingsToRemove.Name = "lstThingsToRemove";
            this.lstThingsToRemove.Size = new System.Drawing.Size(120, 121);
            this.lstThingsToRemove.TabIndex = 2;
            // 
            // flpThingsAdded
            // 
            this.flpThingsAdded.Controls.Add(this.pnlFlowTest);
            this.flpThingsAdded.Location = new System.Drawing.Point(138, 244);
            this.flpThingsAdded.Name = "flpThingsAdded";
            this.flpThingsAdded.Size = new System.Drawing.Size(497, 226);
            this.flpThingsAdded.TabIndex = 5;
            // 
            // pnlFlowTest
            // 
            this.pnlFlowTest.BackColor = System.Drawing.Color.Maroon;
            this.pnlFlowTest.Location = new System.Drawing.Point(3, 3);
            this.pnlFlowTest.Name = "pnlFlowTest";
            this.pnlFlowTest.Size = new System.Drawing.Size(153, 118);
            this.pnlFlowTest.TabIndex = 0;
            // 
            // pnlThingsAdded
            // 
            this.pnlThingsAdded.Location = new System.Drawing.Point(141, 15);
            this.pnlThingsAdded.Name = "pnlThingsAdded";
            this.pnlThingsAdded.Size = new System.Drawing.Size(278, 226);
            this.pnlThingsAdded.TabIndex = 1;
            // 
            // pnlPanelTest
            // 
            this.pnlPanelTest.BackColor = System.Drawing.Color.Maroon;
            this.pnlPanelTest.Location = new System.Drawing.Point(482, 50);
            this.pnlPanelTest.Name = "pnlPanelTest";
            this.pnlPanelTest.Size = new System.Drawing.Size(153, 118);
            this.pnlPanelTest.TabIndex = 1;
            // 
            // pnlTestUserControl
            // 
            this.pnlTestUserControl.Location = new System.Drawing.Point(670, 50);
            this.pnlTestUserControl.Name = "pnlTestUserControl";
            this.pnlTestUserControl.Size = new System.Drawing.Size(395, 339);
            this.pnlTestUserControl.TabIndex = 2;
            // 
            // lblCapture
            // 
            this.lblCapture.AutoSize = true;
            this.lblCapture.Location = new System.Drawing.Point(426, 15);
            this.lblCapture.Name = "lblCapture";
            this.lblCapture.Size = new System.Drawing.Size(35, 13);
            this.lblCapture.TabIndex = 6;
            this.lblCapture.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 480);
            this.Controls.Add(this.lblCapture);
            this.Controls.Add(this.pnlTestUserControl);
            this.Controls.Add(this.pnlPanelTest);
            this.Controls.Add(this.pnlThingsAdded);
            this.Controls.Add(this.flpThingsAdded);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstThingsToRemove);
            this.Controls.Add(this.lstThingsToAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flpThingsAdded.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstThingsToAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThingToAdd;
        private System.Windows.Forms.Button btnThingToAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblThingToRemove;
        private System.Windows.Forms.Button btnThingToRemove;
        private System.Windows.Forms.ListBox lstThingsToRemove;
        private System.Windows.Forms.FlowLayoutPanel flpThingsAdded;
        private System.Windows.Forms.Panel pnlFlowTest;
        private System.Windows.Forms.Panel pnlThingsAdded;
        private System.Windows.Forms.Panel pnlPanelTest;
        private System.Windows.Forms.Panel pnlTestUserControl;
        private System.Windows.Forms.Label lblCapture;
    }
}

