
namespace _7_House
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.goHereButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.exitsComboBox = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goHereButton
            // 
            this.goHereButton.Location = new System.Drawing.Point(12, 194);
            this.goHereButton.Name = "goHereButton";
            this.goHereButton.Size = new System.Drawing.Size(75, 23);
            this.goHereButton.TabIndex = 0;
            this.goHereButton.Text = "Go here";
            this.goHereButton.UseVisualStyleBackColor = true;
            this.goHereButton.Click += new System.EventHandler(this.goHereButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(302, 167);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // exitsComboBox
            // 
            this.exitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitsComboBox.FormattingEnabled = true;
            this.exitsComboBox.Location = new System.Drawing.Point(101, 195);
            this.exitsComboBox.Name = "exitsComboBox";
            this.exitsComboBox.Size = new System.Drawing.Size(212, 21);
            this.exitsComboBox.TabIndex = 2;
            // 
            // goThroughTheDoorButton
            // 
            this.goThroughTheDoorButton.Location = new System.Drawing.Point(24, 234);
            this.goThroughTheDoorButton.Name = "goThroughTheDoorButton";
            this.goThroughTheDoorButton.Size = new System.Drawing.Size(275, 25);
            this.goThroughTheDoorButton.TabIndex = 3;
            this.goThroughTheDoorButton.Text = "Go Through the door";
            this.goThroughTheDoorButton.UseVisualStyleBackColor = true;
            this.goThroughTheDoorButton.Click += new System.EventHandler(this.goThroughTheDoorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 265);
            this.Controls.Add(this.goThroughTheDoorButton);
            this.Controls.Add(this.exitsComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.goHereButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goHereButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox exitsComboBox;
        private System.Windows.Forms.Button goThroughTheDoorButton;
    }
}

