using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forma1;

namespace beadando_form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            futtatho.Fajlbeolvasas();
            futtatho.Fajlbeolvasas2();
            futtatho.Fajlbeolvasas3();
            futtatho.Fajlbeolvasas4();

            InitializeComponent();
            comboBox1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.Visible = false;
            dataGridView2.RowHeadersVisible = false;
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
            button2.Visible = false;  // Gomb elrejtése
            comboBox1.Visible = true;  // ComboBox megjelenítése
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valasztottErtek = comboBox1.SelectedItem.ToString();

            var szurtEredmenyek = futtatho.eredmenyek.Where(x => x.Palya == valasztottErtek).ToList();

            BindingList<Eredmenyek> bl = new BindingList<Eredmenyek>();
            foreach (Eredmenyek item in szurtEredmenyek)
            {
                bl.Add(item);
            }
            dataGridView1.DataSource = bl;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clickedColumnIndex = e.ColumnIndex;
            string valasztottErtek = comboBox1.SelectedItem.ToString();

            var szurtEredmenyek = futtatho.eredmenyek.Where(x => x.Palya == valasztottErtek).ToList();

            // Ha szükséges, az oszlop neve is elérhető a DataGridView.Columns tulajdonságából:
            string kivalasztott = dataGridView1.Columns[clickedColumnIndex].Name;
            List<Eredmenyek> rendezett =  futtatho.Rendezeses(kivalasztott, szurtEredmenyek);
            BindingList<Eredmenyek> bl = new BindingList<Eredmenyek>();
            foreach (Eredmenyek item in rendezett)
            {
                bl.Add(item);
            }
            dataGridView1.DataSource = bl;
            dataGridView1.ClearSelection();
        }
        private void Versenyzokadatai(string v) 
        {
            BindingList<Versenyzok> versenyzo = new BindingList<Versenyzok>();
            versenyzo.Add(futtatho.VersenyzoAdatok(v)[0]);
            dataGridView2.DataSource = versenyzo;

        }
        private void CsapatokAdatai(string v)
        {
            BindingList<Csapatok> csapat = new BindingList<Csapatok>();
            csapat.Add(futtatho.CsapatAdatok(v)[0]);
            dataGridView2.DataSource = csapat;

        }
        private void AutoAdatai(string v)
        {
            BindingList<Autok> autoazonosito = new BindingList<Autok>();
            autoazonosito.Add(futtatho.AutoAdatok(v)[0]);
            dataGridView2.DataSource = autoazonosito;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            string Headerszöveg = dataGridView1.SelectedCells[0].OwningColumn.HeaderText;
            if (Headerszöveg == "Nev" )
            {
                dataGridView2.Visible = true; 
                Versenyzokadatai("" + dataGridView1.SelectedCells[0].Value);
                
            }
            else if (Headerszöveg == "Csapat") 
            {
                dataGridView2.Visible = true;
                CsapatokAdatai("" + dataGridView1.SelectedCells[0].Value);

            }
            else if (Headerszöveg == "AutoAzonostio")
            {
                dataGridView2.Visible = true;
                AutoAdatai("" + dataGridView1.SelectedCells[0].Value);

            }
        }
    }
}
