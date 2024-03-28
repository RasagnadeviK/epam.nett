
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private ComboBox comboBox1;
    private ListBox listBox1;
    private Label label1;

    public Form1()
    {
        comboBox1 = new ComboBox();
        comboBox1.Items.Add("Circle");
        comboBox1.Items.Add("Ellipse");
        comboBox1.Items.Add("Triangle");
        comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

        listBox1 = new ListBox();
        listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);

        label1 = new Label();

        this.Controls.Add(comboBox1);
        this.Controls.Add(listBox1);
        this.Controls.Add(label1);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBox1.SelectedItem.ToString())
        {
            case "Circle":
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Size = new Size(200, 200);
                break;
            case "Ellipse":
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Size = new Size(300, 200);
                break;
            case "Triangle":
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.Size = new Size(200, 300);
                break;
        }
    }

    private void InitializeComponent()
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        label1.Font = new Font(listBox1.SelectedItem.ToString(), 12);
    }
}