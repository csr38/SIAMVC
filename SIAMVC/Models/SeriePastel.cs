
using MySqlConnector;
using System.Collections.Generic;

namespace SIAMVC.Models
{
    public class SeriePastel
    {
        public string name { get; set; }
        public double y { get; set; }
        public bool sliced { get; set; }
        public bool selected { get; set; }

        public SeriePastel() { 
        
        }

        public SeriePastel(string name, double y, bool sliced=false, bool selected = false)
        {
            this.name = name;
            this.y = y;
            this.sliced = sliced;
            this.selected = selected;
        }

        public string ConnectionString { get; set; }

        public SeriePastel(string connectionString)
        {
            this.ConnectionString= connectionString;

        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<ReporteFauna> allFauna()
        {
            List<ReporteFauna> list = new List<ReporteFauna>();
           

            using (MySqlConnection conn = GetConnection()) {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM bd_fauna", conn);
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ReporteFauna()
                        {
                            Id = reader.GetInt32("idFauna"),
                            Especie = reader.GetString("Especie"),
                            NombreCom = reader.GetString("NombreCom"),
                            Nativa = reader.GetInt32("Nativa"),
                            
                        });

                       
                    }
                }
            }
            return list;
        }
        List<SeriePastel> lista = new List<SeriePastel>();

        
        public List<SeriePastel> GetDataDummy()
        {


            lista.Add(new SeriePastel("angula", 45));
            lista.Add(new SeriePastel("VueJS", 45));
            lista.Add(new SeriePastel("ReactJS", 45));
            lista.Add(new SeriePastel("html", 45));
            lista.Add(new SeriePastel("css", 20));






            return lista;
        }
    }
}
