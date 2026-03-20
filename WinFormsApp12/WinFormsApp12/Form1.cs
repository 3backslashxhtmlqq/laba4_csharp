namespace WinFormsApp12;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string title = textBox1.Text;
        string author = textBox2.Text;
        int year = Convert.ToInt32(textBox3.Text);
        
        Book yourBook =  new Book(title, author, year);
        listBox1.Items.Add(yourBook.GetInfo());

    }

    private void button2_Click(object sender, EventArgs e)
    {
        Book myBook = new Book("Война и мир", "Лев Толстой", 1869);
        listBox1.Items.Add(myBook.GetInfo());
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Book unknownBook = new Book();
        listBox1.Items.Add(unknownBook.GetInfo());
    }
}