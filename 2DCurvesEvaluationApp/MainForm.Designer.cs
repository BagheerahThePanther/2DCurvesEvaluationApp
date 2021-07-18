
namespace _2DCurvesEvaluationApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfElems = new System.Windows.Forms.NumericUpDown();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfElems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество элементов коллекции и нажмите кнопку \"Отобразить\"";
            // 
            // numericUpDownNumberOfElems
            // 
            this.numericUpDownNumberOfElems.Location = new System.Drawing.Point(295, 28);
            this.numericUpDownNumberOfElems.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownNumberOfElems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfElems.Name = "numericUpDownNumberOfElems";
            this.numericUpDownNumberOfElems.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownNumberOfElems.TabIndex = 1;
            this.numericUpDownNumberOfElems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(366, 25);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(85, 23);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Отобразить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 54);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(735, 384);
            this.textBoxResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кривые генерируются со случайными параметрами";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.numericUpDownNumberOfElems);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "2DCurvesEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfElems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfElems;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
    }
}

