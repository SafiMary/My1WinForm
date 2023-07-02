namespace My1WinForm
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
            this.textBoxOne = new System.Windows.Forms.TextBox();
            this.textBoxTwo = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonOne = new System.Windows.Forms.Button();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxThree = new System.Windows.Forms.TextBox();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOne
            // 
            this.textBoxOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOne.Location = new System.Drawing.Point(94, 85);
            this.textBoxOne.Name = "textBoxOne";
            this.textBoxOne.Size = new System.Drawing.Size(116, 30);
            this.textBoxOne.TabIndex = 0;
            
            // 
            // textBoxTwo
            // 
            this.textBoxTwo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTwo.Location = new System.Drawing.Point(555, 85);
            this.textBoxTwo.Name = "textBoxTwo";
            this.textBoxTwo.Size = new System.Drawing.Size(118, 30);
            this.textBoxTwo.TabIndex = 0;
         
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(276, 353);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 0;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox.Location = new System.Drawing.Point(300, 83);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 33);
            this.comboBox.TabIndex = 1;
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.Location = new System.Drawing.Point(289, 133);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(158, 49);
            this.buttonOne.TabIndex = 2;
            this.buttonOne.Text = "Посчитать";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOne.Location = new System.Drawing.Point(43, 36);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(221, 25);
            this.labelOne.TabIndex = 3;
            this.labelOne.Text = "Введите первое число";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTwo.Location = new System.Drawing.Point(508, 36);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(222, 25);
            this.labelTwo.TabIndex = 4;
            this.labelTwo.Text = "Введите второе число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите операцию";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(310, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат";
            // 
            // textBoxThree
            // 
            this.textBoxThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxThree.Location = new System.Drawing.Point(300, 271);
            this.textBoxThree.Name = "textBoxThree";
            this.textBoxThree.Size = new System.Drawing.Size(121, 30);
            this.textBoxThree.TabIndex = 0;

            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.Location = new System.Drawing.Point(498, 292);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(135, 49);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.Text = "Очистить";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(635, 292);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 49);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxThree);
            this.Controls.Add(this.textBoxTwo);
            this.Controls.Add(this.textBoxOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOne;
        private System.Windows.Forms.TextBox textBoxTwo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonSave;
    }
}

