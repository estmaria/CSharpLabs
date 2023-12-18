
namespace MarshallsRevenueProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.interiorWallLabel = new System.Windows.Forms.Label();
            this.exteriorWallLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.monthInputTextBox = new System.Windows.Forms.TextBox();
            this.intWallInputTextBox = new System.Windows.Forms.TextBox();
            this.extWallInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateStatementButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(40, 33);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(595, 50);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Welcom To Marshalls Paint";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interiorWallLabel
            // 
            this.interiorWallLabel.AutoSize = true;
            this.interiorWallLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.interiorWallLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interiorWallLabel.Location = new System.Drawing.Point(138, 166);
            this.interiorWallLabel.Name = "interiorWallLabel";
            this.interiorWallLabel.Size = new System.Drawing.Size(208, 21);
            this.interiorWallLabel.TabIndex = 7;
            this.interiorWallLabel.Text = "Number of interior wall : ";
            // 
            // exteriorWallLabel
            // 
            this.exteriorWallLabel.AutoSize = true;
            this.exteriorWallLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.exteriorWallLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exteriorWallLabel.Location = new System.Drawing.Point(137, 228);
            this.exteriorWallLabel.Name = "exteriorWallLabel";
            this.exteriorWallLabel.Size = new System.Drawing.Size(209, 21);
            this.exteriorWallLabel.TabIndex = 6;
            this.exteriorWallLabel.Text = "Number of exterior wall : ";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.monthLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(138, 289);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(201, 21);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Month number (1 - 12) : ";
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.BackColor = System.Drawing.Color.Transparent;
            this.statementLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statementLabel.Location = new System.Drawing.Point(43, 413);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(0, 18);
            this.statementLabel.TabIndex = 4;
            // 
            // monthInputTextBox
            // 
            this.monthInputTextBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthInputTextBox.Location = new System.Drawing.Point(352, 286);
            this.monthInputTextBox.Name = "monthInputTextBox";
            this.monthInputTextBox.Size = new System.Drawing.Size(167, 28);
            this.monthInputTextBox.TabIndex = 2;
            this.monthInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // intWallInputTextBox
            // 
            this.intWallInputTextBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intWallInputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.intWallInputTextBox.Location = new System.Drawing.Point(352, 163);
            this.intWallInputTextBox.Name = "intWallInputTextBox";
            this.intWallInputTextBox.Size = new System.Drawing.Size(167, 28);
            this.intWallInputTextBox.TabIndex = 0;
            this.intWallInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // extWallInputTextBox
            // 
            this.extWallInputTextBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extWallInputTextBox.Location = new System.Drawing.Point(352, 225);
            this.extWallInputTextBox.Name = "extWallInputTextBox";
            this.extWallInputTextBox.Size = new System.Drawing.Size(167, 28);
            this.extWallInputTextBox.TabIndex = 1;
            this.extWallInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateStatementButton
            // 
            this.calculateStatementButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateStatementButton.Location = new System.Drawing.Point(241, 353);
            this.calculateStatementButton.Name = "calculateStatementButton";
            this.calculateStatementButton.Size = new System.Drawing.Size(189, 35);
            this.calculateStatementButton.TabIndex = 3;
            this.calculateStatementButton.Text = "Calculate Statement";
            this.calculateStatementButton.UseVisualStyleBackColor = true;
            this.calculateStatementButton.Click += new System.EventHandler(this.calculateStatementButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(111, 114);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(456, 21);
            this.questionLabel.TabIndex = 10;
            this.questionLabel.Text = "Fill out the form below to calculate your statement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 484);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.calculateStatementButton);
            this.Controls.Add(this.extWallInputTextBox);
            this.Controls.Add(this.intWallInputTextBox);
            this.Controls.Add(this.monthInputTextBox);
            this.Controls.Add(this.statementLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.exteriorWallLabel);
            this.Controls.Add(this.interiorWallLabel);
            this.Controls.Add(this.welcomeLabel);
            this.MaximumSize = new System.Drawing.Size(679, 523);
            this.MinimumSize = new System.Drawing.Size(679, 523);
            this.Name = "Form1";
            this.Text = "Marshalls Statement Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label interiorWallLabel;
        private System.Windows.Forms.Label exteriorWallLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.TextBox monthInputTextBox;
        private System.Windows.Forms.TextBox intWallInputTextBox;
        private System.Windows.Forms.TextBox extWallInputTextBox;
        private System.Windows.Forms.Button calculateStatementButton;
        private System.Windows.Forms.Label questionLabel;
    }
}

