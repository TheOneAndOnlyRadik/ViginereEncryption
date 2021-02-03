
namespace ViginereEncryption
{
    partial class MainForm
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.cipherRadioButton = new System.Windows.Forms.RadioButton();
            this.decipherRadioButton = new System.Windows.Forms.RadioButton();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.processButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(354, 121);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(3, 19);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(348, 99);
            this.inputTextBox.TabIndex = 1;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.Controls.Add(this.outputTextBox);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 238);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(354, 121);
            this.outputGroupBox.TabIndex = 2;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(3, 19);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(348, 99);
            this.outputTextBox.TabIndex = 3;
            // 
            // cipherRadioButton
            // 
            this.cipherRadioButton.AutoSize = true;
            this.cipherRadioButton.Location = new System.Drawing.Point(6, 59);
            this.cipherRadioButton.Name = "cipherRadioButton";
            this.cipherRadioButton.Size = new System.Drawing.Size(60, 19);
            this.cipherRadioButton.TabIndex = 2;
            this.cipherRadioButton.TabStop = true;
            this.cipherRadioButton.Text = "Cipher";
            this.cipherRadioButton.UseVisualStyleBackColor = true;
            this.cipherRadioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // decipherRadioButton
            // 
            this.decipherRadioButton.AutoSize = true;
            this.decipherRadioButton.Location = new System.Drawing.Point(72, 59);
            this.decipherRadioButton.Name = "decipherRadioButton";
            this.decipherRadioButton.Size = new System.Drawing.Size(72, 19);
            this.decipherRadioButton.TabIndex = 2;
            this.decipherRadioButton.TabStop = true;
            this.decipherRadioButton.Text = "Decipher";
            this.decipherRadioButton.UseVisualStyleBackColor = true;
            this.decipherRadioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordTextBox.Location = new System.Drawing.Point(66, 21);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(280, 23);
            this.keywordTextBox.TabIndex = 2;
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsGroupBox.Controls.Add(this.processButton);
            this.actionsGroupBox.Controls.Add(this.clearButton);
            this.actionsGroupBox.Controls.Add(this.keywordLabel);
            this.actionsGroupBox.Controls.Add(this.keywordTextBox);
            this.actionsGroupBox.Controls.Add(this.decipherRadioButton);
            this.actionsGroupBox.Controls.Add(this.cipherRadioButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(12, 139);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(354, 93);
            this.actionsGroupBox.TabIndex = 1;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // processButton
            // 
            this.processButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.processButton.Location = new System.Drawing.Point(271, 59);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(190, 59);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(6, 24);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(56, 15);
            this.keywordLabel.TabIndex = 3;
            this.keywordLabel.Text = "Keyword:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 369);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.actionsGroupBox);
            this.MinimumSize = new System.Drawing.Size(384, 408);
            this.Name = "MainForm";
            this.Text = "Chiffre de Viginère";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.actionsGroupBox.ResumeLayout(false);
            this.actionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.RadioButton cipherRadioButton;
        private System.Windows.Forms.RadioButton decipherRadioButton;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label keywordLabel;
    }
}

