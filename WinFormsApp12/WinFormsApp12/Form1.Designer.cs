namespace WinFormsApp12;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(24, 22);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(133, 31);
        label1.TabIndex = 0;
        label1.Text = "Название книги:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(24, 65);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(133, 31);
        label2.TabIndex = 1;
        label2.Text = "Автор книги:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(24, 108);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(133, 31);
        label3.TabIndex = 2;
        label3.Text = "Год издания:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(150, 22);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(232, 27);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(127, 62);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(232, 27);
        textBox2.TabIndex = 4;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(127, 105);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(232, 27);
        textBox3.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(114, 158);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(158, 45);
        button1.TabIndex = 6;
        button1.Text = "Вывод";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(30, 233);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(444, 184);
        listBox1.TabIndex = 7;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(548, 73);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(178, 45);
        button2.TabIndex = 8;
        button2.Text = "Объект myBook";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(548, 172);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(178, 45);
        button3.TabIndex = 9;
        button3.Text = "Объект unknownBook";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(listBox1);
        Controls.Add(button1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}