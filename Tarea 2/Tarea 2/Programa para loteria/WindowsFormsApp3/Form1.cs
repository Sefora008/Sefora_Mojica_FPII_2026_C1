using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // File-based simple database
        private readonly string dbFile = Path.Combine(Application.StartupPath, "numeros.xml");
        private List<Numero> db = new List<Numero>();
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDatabase();
            RefreshHistory();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            // Generate three random numbers 1-100
            int primera = rng.Next(1, 101);
            int segunda = rng.Next(1, 101);
            int tercera = rng.Next(1, 101);

            int nextId = db.Any() ? db.Max(x => x.Id) + 1 : 1;

            var numero = new Numero
            {
                Id = nextId,
                Primera = primera,
                Segunda = segunda,
                Tercera = tercera,
                FechaHora = DateTime.Now
            };

            // Save to file-based "database"
            db.Add(numero);
            SaveDatabase();

            // Display current result
            lblResult.Text = $"ID {numero.Id} - {numero.FechaHora:G} - {numero.Primera}, {numero.Segunda}, {numero.Tercera}";

            // Update history list
            RefreshHistory();
        }

        private void RefreshHistory()
        {
            lstHistory.Items.Clear();
            foreach (var n in db.OrderByDescending(x => x.FechaHora))
            {
                lstHistory.Items.Add($"ID {n.Id} - {n.FechaHora:G} - {n.Primera}, {n.Segunda}, {n.Tercera}");
            }
        }

        private void LoadDatabase()
        {
            try
            {
                if (File.Exists(dbFile))
                {
                    var ser = new XmlSerializer(typeof(List<Numero>));
                    using (var fs = File.OpenRead(dbFile))
                    {
                        var obj = ser.Deserialize(fs) as List<Numero>;
                        if (obj != null)
                            db = obj;
                    }
                }
                else
                {
                    db = new List<Numero>();
                }
            }
            catch
            {
                // If load fails, start with empty DB
                db = new List<Numero>();
            }
        }

        private void SaveDatabase()
        {
            try
            {
                var ser = new XmlSerializer(typeof(List<Numero>));
                using (var fs = File.Create(dbFile))
                {
                    ser.Serialize(fs, db);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Numero
    {
        public int Id { get; set; }
        public int Primera { get; set; }
        public int Segunda { get; set; }
        public int Tercera { get; set; }
        public DateTime FechaHora { get; set; }

        // Parameterless constructor required for XML serialization
        public Numero() { }
    }
}
