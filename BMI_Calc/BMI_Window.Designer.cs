namespace BMI_Calc
{
    partial class BMI_Window
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.feetTxtBox = new System.Windows.Forms.TextBox();
            this.inchesTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.viewList = new System.Windows.Forms.Button();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate you BMI Below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height (ft, in): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight (lb): ";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(193, 82);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(218, 22);
            this.nameTxtBox.TabIndex = 4;
            // 
            // feetTxtBox
            // 
            this.feetTxtBox.Location = new System.Drawing.Point(193, 129);
            this.feetTxtBox.Name = "feetTxtBox";
            this.feetTxtBox.Size = new System.Drawing.Size(100, 22);
            this.feetTxtBox.TabIndex = 5;
            // 
            // inchesTxtBox
            // 
            this.inchesTxtBox.Location = new System.Drawing.Point(299, 129);
            this.inchesTxtBox.Name = "inchesTxtBox";
            this.inchesTxtBox.Size = new System.Drawing.Size(112, 22);
            this.inchesTxtBox.TabIndex = 6;
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(193, 173);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(218, 22);
            this.weightTxtBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(193, 214);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(218, 35);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // viewList
            // 
            this.viewList.Location = new System.Drawing.Point(70, 273);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(153, 53);
            this.viewList.TabIndex = 10;
            this.viewList.Text = "View BMI List";
            this.viewList.UseVisualStyleBackColor = true;
            this.viewList.Click += new System.EventHandler(this.viewList_Click);
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(244, 273);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(145, 53);
            this.addToListBtn.TabIndex = 11;
            this.addToListBtn.Text = "Add To List";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // BMI_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 461);
            this.Controls.Add(this.addToListBtn);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.inchesTxtBox);
            this.Controls.Add(this.feetTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BMI_Window";
            this.Text = "BMI_Window";
            this.Load += new System.EventHandler(this.BMI_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox feetTxtBox;
        private System.Windows.Forms.TextBox inchesTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button viewList;
        private System.Windows.Forms.Button addToListBtn;
    }
}