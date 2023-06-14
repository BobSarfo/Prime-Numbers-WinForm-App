namespace PrimeNumbersApp
{
    partial class MainForm
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
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.leftListView = new System.Windows.Forms.ListView();
            this.rightListView = new System.Windows.Forms.ListView();
            this.leftBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.lNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBgWorker = new System.ComponentModel.BackgroundWorker();
            this.rBgWorker = new System.ComponentModel.BackgroundWorker();
            this.addInput1 = new System.Windows.Forms.TextBox();
            this.addInput2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCalculateLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(75, 58);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(261, 22);
            this.lTextBox.TabIndex = 0;
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(460, 58);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(260, 22);
            this.rTextBox.TabIndex = 1;
            // 
            // leftListView
            // 
            this.leftListView.GridLines = true;
            this.leftListView.HideSelection = false;
            this.leftListView.Location = new System.Drawing.Point(75, 108);
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(260, 260);
            this.leftListView.TabIndex = 2;
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.View = System.Windows.Forms.View.Details;
            // 
            // rightListView
            // 
            this.rightListView.GridLines = true;
            this.rightListView.HideSelection = false;
            this.rightListView.Location = new System.Drawing.Point(460, 108);
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(260, 260);
            this.rightListView.TabIndex = 3;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.View = System.Windows.Forms.View.Details;
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(75, 404);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(261, 39);
            this.leftBtn.TabIndex = 4;
            this.leftBtn.Text = "Start";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(460, 404);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(260, 39);
            this.rightBtn.TabIndex = 5;
            this.rightBtn.Text = "Start";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // lNumber
            // 
            this.lNumber.Location = new System.Drawing.Point(73, 32);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(215, 23);
            this.lNumber.TabIndex = 0;
            this.lNumber.Text = "Enter a positive integer";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(457, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a positive integer";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generate Prime Numbers";
            // 
            // lBgWorker
            // 
            this.lBgWorker.WorkerReportsProgress = true;
            this.lBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.lBgWorker_DoWork);
            // 
            // rBgWorker
            // 
            this.rBgWorker.WorkerReportsProgress = true;
            this.rBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.rBgWorker_DoWork);
            // 
            // addInput1
            // 
            this.addInput1.Location = new System.Drawing.Point(75, 493);
            this.addInput1.Name = "addInput1";
            this.addInput1.Size = new System.Drawing.Size(100, 22);
            this.addInput1.TabIndex = 6;
            // 
            // addInput2
            // 
            this.addInput2.AcceptsReturn = true;
            this.addInput2.Location = new System.Drawing.Point(235, 493);
            this.addInput2.Name = "addInput2";
            this.addInput2.Size = new System.Drawing.Size(100, 22);
            this.addInput2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // addCalculateLbl
            // 
            this.addCalculateLbl.AutoSize = true;
            this.addCalculateLbl.Location = new System.Drawing.Point(392, 496);
            this.addCalculateLbl.Name = "addCalculateLbl";
            this.addCalculateLbl.Size = new System.Drawing.Size(0, 16);
            this.addCalculateLbl.TabIndex = 10;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(138, 531);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(121, 36);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 619);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addCalculateLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addInput2);
            this.Controls.Add(this.addInput1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.rightListView);
            this.Controls.Add(this.leftListView);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.lTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker lBgWorker;
        private System.ComponentModel.BackgroundWorker rBgWorker;
        private System.Windows.Forms.TextBox addInput1;
        private System.Windows.Forms.TextBox addInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addCalculateLbl;
        private System.Windows.Forms.Button calculateBtn;
    }
}