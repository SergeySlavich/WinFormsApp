namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Car
        {
            int id;
            string Mark;
            string Model;
            string Engine;
            string Transmission;
            public Car() { }
            public Car(int id, string Mark, string Model, string Engine, string Transmission)
            {
                this.id = id;
                this.Mark = Mark;
                this.Model = Model;
                this.Engine = Engine;
                this.Transmission = Transmission;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Car> list = new List<Car>();
            list.Add(new Car(1, "Lada", "Samara", "1.5i", "MT"));
            list.Add(new Car(2, "GAZ", "Volga 21", "2.0", "AT"));
            list.Add(new Car(3, "Toyota", "Corolla", "1.5i", "AT"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}