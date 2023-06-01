namespace WinForms_7
{
    public partial class Form1 : Form
    {
        private Form2 childForm;
        public Form1()
        {
            InitializeComponent();
            childForm = new Form2(this);
            childForm.Owner = this;
            childForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            childForm.textBox1.Text = this.textBox1.Text;
        }

        public void ChildForm_TextChanged(string newText)
        {
            this.textBox1.Text = newText;
        }

    }
}