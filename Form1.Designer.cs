namespace Timer_WF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lb_seconds = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.NumericUpDown();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.counter)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_seconds
            // 
            this.lb_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_seconds.Location = new System.Drawing.Point(32, 31);
            this.lb_seconds.Name = "lb_seconds";
            this.lb_seconds.Size = new System.Drawing.Size(229, 53);
            this.lb_seconds.TabIndex = 1;
            this.lb_seconds.Text = "ТАЙМЕР";
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(40, 115);
            this.counter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(233, 53);
            this.counter.TabIndex = 2;
            this.counter.ValueChanged += new System.EventHandler(this.counter_ValueChanged);
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_start.Location = new System.Drawing.Point(40, 197);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(158, 85);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_stop.Location = new System.Drawing.Point(40, 323);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(158, 85);
            this.bt_stop.TabIndex = 4;
            this.bt_stop.Text = "STOP";
            this.bt_stop.UseVisualStyleBackColor = false;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.lb_seconds);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.counter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_seconds;
        private System.Windows.Forms.NumericUpDown counter;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Timer timer;
    }
}

