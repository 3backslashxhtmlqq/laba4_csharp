namespace WinFormsApp13;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;
        Visitor visitor = new Visitor(name);
        listBox1.Items.Add(visitor.PrintInfo());
        
        listBox1.Items.Add(Visitor.ShowTotalVisitors());
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Visitor visitor = new Visitor("Анна");
        Visitor visitor1 = new Visitor("Борис");
        Visitor visitor2 = new Visitor("Виктор");

        listBox1.Items.Add(visitor.PrintInfo());
        listBox1.Items.Add(visitor1.PrintInfo());
        listBox1.Items.Add(visitor2.PrintInfo());

        listBox1.Items.Add(Visitor.ShowTotalVisitors());

    }
}