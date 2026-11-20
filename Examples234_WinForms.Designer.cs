using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox7 = new TextBox();
            this.button1 = new Button();
            this.labelResult = new Label();

            string[] names = {
                "Название товара", "Цена", "Количество",
                "Номер заказа", "Имя покупателя", "Сумма заказа",
                "Температура (°C)"
            };
            TextBox[] fields = {
                textBox1, textBox2, textBox3, textBox4,
                textBox5, textBox6, textBox7
            };

            this.SuspendLayout();

            for (int i = 0; i < fields.Length; i++)
            {
                Label label = new Label();
                label.Text = names[i];
                label.Location = new Point(15, 20 + i * 35);
                label.Size = new Size(145, 25);
                this.Controls.Add(label);

                fields[i].Name = "textBox" + (i + 1);
                fields[i].Location = new Point(165, 17 + i * 35);
                fields[i].Size = new Size(200, 25);
                this.Controls.Add(fields[i]);
            }

            this.button1.Name = "button1";
            this.button1.Text = "Подтвердить";
            this.button1.Location = new Point(165, 265);
            this.button1.Size = new Size(200, 30);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.labelResult.Name = "labelResult";
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new Point(15, 315);
            this.labelResult.Text = "";

            this.ClientSize = new Size(410, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Примеры 2, 3, 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
