
namespace Lab4AverageCase
{
    partial class formAverageCases
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCasePrompt = new System.Windows.Forms.Label();
            this.textBoxCaseEntry = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.textBoxRegion1List = new System.Windows.Forms.TextBox();
            this.labelAverage1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.textBoxRegion2List = new System.Windows.Forms.TextBox();
            this.labelAverage2 = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.textBoxRegion3List = new System.Windows.Forms.TextBox();
            this.labelAverage3 = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCasePrompt
            // 
            this.labelCasePrompt.AutoSize = true;
            this.labelCasePrompt.Location = new System.Drawing.Point(29, 25);
            this.labelCasePrompt.Name = "labelCasePrompt";
            this.labelCasePrompt.Size = new System.Drawing.Size(87, 20);
            this.labelCasePrompt.TabIndex = 0;
            this.labelCasePrompt.Text = "Daily &Cases:";
            // 
            // textBoxCaseEntry
            // 
            this.textBoxCaseEntry.Location = new System.Drawing.Point(130, 22);
            this.textBoxCaseEntry.Name = "textBoxCaseEntry";
            this.textBoxCaseEntry.Size = new System.Drawing.Size(125, 27);
            this.textBoxCaseEntry.TabIndex = 1;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(423, 25);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(47, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Location = new System.Drawing.Point(48, 97);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(68, 20);
            this.labelRegion1.TabIndex = 3;
            this.labelRegion1.Text = "Region &1";
            this.labelRegion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegion1List
            // 
            this.textBoxRegion1List.Location = new System.Drawing.Point(29, 137);
            this.textBoxRegion1List.Multiline = true;
            this.textBoxRegion1List.Name = "textBoxRegion1List";
            this.textBoxRegion1List.ReadOnly = true;
            this.textBoxRegion1List.Size = new System.Drawing.Size(125, 163);
            this.textBoxRegion1List.TabIndex = 4;
            // 
            // labelAverage1
            // 
            this.labelAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverage1.Location = new System.Drawing.Point(29, 326);
            this.labelAverage1.Name = "labelAverage1";
            this.labelAverage1.Size = new System.Drawing.Size(125, 25);
            this.labelAverage1.TabIndex = 5;
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(231, 97);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(68, 20);
            this.labelRegion2.TabIndex = 6;
            this.labelRegion2.Text = "Region &2";
            this.labelRegion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegion2List
            // 
            this.textBoxRegion2List.Location = new System.Drawing.Point(205, 137);
            this.textBoxRegion2List.Multiline = true;
            this.textBoxRegion2List.Name = "textBoxRegion2List";
            this.textBoxRegion2List.ReadOnly = true;
            this.textBoxRegion2List.Size = new System.Drawing.Size(125, 163);
            this.textBoxRegion2List.TabIndex = 7;
            // 
            // labelAverage2
            // 
            this.labelAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverage2.Location = new System.Drawing.Point(205, 326);
            this.labelAverage2.Name = "labelAverage2";
            this.labelAverage2.Size = new System.Drawing.Size(125, 25);
            this.labelAverage2.TabIndex = 8;
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(402, 97);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(68, 20);
            this.labelRegion3.TabIndex = 9;
            this.labelRegion3.Text = "Region &3";
            this.labelRegion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegion3List
            // 
            this.textBoxRegion3List.Location = new System.Drawing.Point(369, 137);
            this.textBoxRegion3List.Multiline = true;
            this.textBoxRegion3List.Name = "textBoxRegion3List";
            this.textBoxRegion3List.ReadOnly = true;
            this.textBoxRegion3List.Size = new System.Drawing.Size(125, 163);
            this.textBoxRegion3List.TabIndex = 10;
            // 
            // labelAverage3
            // 
            this.labelAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverage3.Location = new System.Drawing.Point(369, 326);
            this.labelAverage3.Name = "labelAverage3";
            this.labelAverage3.Size = new System.Drawing.Size(125, 25);
            this.labelAverage3.TabIndex = 11;
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(29, 376);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(465, 33);
            this.labelAverageOutput.TabIndex = 12;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(29, 436);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(205, 436);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(400, 436);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // formAverageCases
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(540, 502);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelAverage3);
            this.Controls.Add(this.textBoxRegion3List);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.labelAverage2);
            this.Controls.Add(this.textBoxRegion2List);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.labelAverage1);
            this.Controls.Add(this.textBoxRegion1List);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxCaseEntry);
            this.Controls.Add(this.labelCasePrompt);
            this.Name = "formAverageCases";
            this.Text = "Average Weekly Units By Regions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCasePrompt;
        private System.Windows.Forms.TextBox textBoxCaseEntry;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.TextBox textBoxRegion1List;
        private System.Windows.Forms.Label labelAverage1;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.TextBox textBoxRegion2List;
        private System.Windows.Forms.Label labelAverage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelAverage3;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.TextBox textBoxRegion3List;
    }
}

