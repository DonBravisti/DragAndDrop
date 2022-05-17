namespace DragAndDropAuto
{
    partial class FormMain
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
            this.buttonSourceDrag = new System.Windows.Forms.Button();
            this.textBoxTargetDrop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSourceDrag
            // 
            this.buttonSourceDrag.Location = new System.Drawing.Point(153, 278);
            this.buttonSourceDrag.Name = "buttonSourceDrag";
            this.buttonSourceDrag.Size = new System.Drawing.Size(268, 58);
            this.buttonSourceDrag.TabIndex = 0;
            this.buttonSourceDrag.Text = "Иииуу";
            this.buttonSourceDrag.UseVisualStyleBackColor = true;
            this.buttonSourceDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourceDrag_MouseDown);
            // 
            // textBoxTargetDrop
            // 
            this.textBoxTargetDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTargetDrop.Location = new System.Drawing.Point(427, 278);
            this.textBoxTargetDrop.Name = "textBoxTargetDrop";
            this.textBoxTargetDrop.Size = new System.Drawing.Size(268, 29);
            this.textBoxTargetDrop.TabIndex = 1;
            this.textBoxTargetDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragDrop);
            this.textBoxTargetDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTargetDrop);
            this.Controls.Add(this.buttonSourceDrag);
            this.Name = "FormMain";
            this.Text = "Встроеный инструмент для перетаскивания объектов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSourceDrag;
        private System.Windows.Forms.TextBox textBoxTargetDrop;
    }
}

