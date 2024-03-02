using System.Data;
using System.Data.SQLite;

namespace Informe
{
    public partial class Form1 : Form
    {
       public Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conect_Click(object sender, EventArgs e)

        //Para poder conectatse y hacer consultas 
        {
            //Objeto de conexiónn
            SQLiteConnection conn = new SQLiteConnection("Data source = C:\\DAM\\DAM 2 DUAL\\Interfaces\\2aEv\\Informe\\provider_sqlite.db ");

            //Consulta
            string query = "SELECT * from Cliente";


            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //Objeto dataTabl
            DataTable dt = new DataTable();

            //Adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);

            //Enlaece deatabase con datagridView
            data_grid.DataSource = dt;

        }

        private void btn_inform_Click(object sender, EventArgs e)
        {
          
            frm.Show();
            
        }
    }
}
