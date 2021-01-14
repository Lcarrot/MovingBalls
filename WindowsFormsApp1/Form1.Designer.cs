
namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.n_speed = new System.Windows.Forms.TextBox();
            this.t_speed = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 631);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1221, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание шарика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1181, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "масса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1154, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "n_скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1154, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "t_скорость";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(1224, 83);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 5;
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyNumbers);
            // 
            // n_speed
            // 
            this.n_speed.Location = new System.Drawing.Point(1224, 138);
            this.n_speed.Name = "n_speed";
            this.n_speed.Size = new System.Drawing.Size(100, 20);
            this.n_speed.TabIndex = 6;
            this.n_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyNumbers);
            // 
            // t_speed
            // 
            this.t_speed.Location = new System.Drawing.Point(1224, 164);
            this.t_speed.Name = "t_speed";
            this.t_speed.Size = new System.Drawing.Size(100, 20);
            this.t_speed.TabIndex = 7;
            this.t_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyNumbers);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(1238, 190);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 8;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.CreateBallClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1181, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "радиус";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(1224, 109);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 20);
            this.radius.TabIndex = 10;
            this.radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyNumbers);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 685);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.create);
            this.Controls.Add(this.t_speed);
            this.Controls.Add(this.n_speed);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox n_speed;
        private System.Windows.Forms.TextBox t_speed;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Timer timer1;
    }
}

