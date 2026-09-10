using Newtonsoft.Json;
using Services;

namespace IHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TitleTb.Text))
            {
                dataGridView1.DataSource = Factory.Instance?.GetAll();
            }
            else
            {
                dataGridView1.DataSource = Factory.Instance?.GetByTitle(TitleTb.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var recipes = Factory.Instance?.GetAll();

            // 2. Configuration pour préserver la structure du graphe
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };

            // 3. Sérialisation
            var json = JsonConvert.SerializeObject(recipes, settings);

            File.WriteAllText("recipes.json", json);
        }
    }
}
