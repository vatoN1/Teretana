using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class UposlenikDAO : IDaoCrud<Uposlenik>
        {
            protected MySqlCommand c;

            public long create(Uposlenik entity)
            {
                try
                {
                    var datumRodjenja = entity.DatumRodjenja.Date.ToString("yyyy-MM-dd");
                    var datumZaposlenja = entity.DatumRodjenja.Date.ToString("yyyy-MM-dd");
                    c = new MySqlCommand(String.Format("INSERT INTO uposlenici VALUES ('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}');",
                        entity.ID , entity.Ime, entity.Prezime, entity.Spol, datumRodjenja, datumZaposlenja
                        , Convert.ToDouble(entity.Plata), entity.Kontakt, entity.ZaposlenjeS, entity.Sifra), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
            public Uposlenik read(Uposlenik entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM uposlenici WHERE id='{0}';", entity.IdUposlenika)
                        , con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Uposlenik Uposlenik = new Uposlenik
                        (
                            r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"),
                            r.GetString("spol"), r.GetDateTime("datumRodjenja"),
                            r.GetDateTime("datumZaposlenja"), r.GetDecimal("plata"),
                            r.GetString("kontakt"), r.GetString("zaposlenje"), r.GetString("sifra")
                        );

                        r.Close();
                        return Uposlenik;
                    }
                    else throw
                     new Exception("Nema podataka za citanje");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Uposlenik update(int id, Uposlenik entity)
            {
                try
                {
                    var datumRodjenja = entity.DatumRodjenja.Date.ToString("yyyy-MM-dd");
                    var datumZaposlenja = entity.DatumRodjenja.Date.ToString("yyyy-MM-dd");
                    c = new MySqlCommand(String.Format("UPDATE uposlenici SET id={0}, ime='{1}', prezime='{2}', spol='{3}', "+
                    "datumRodjenja = '{4}', datumZaposlenja = '{5}', plata = {6}, kontakt = '{7}', zaposlenje='{8}', " +
                    "sifra = '{9}' where id = {10};",
                        entity.IdUposlenika, entity.Ime, entity.Prezime, entity.Spol, datumRodjenja, 
                        datumZaposlenja, entity.Plata, entity.Kontakt, 
                        entity.Zaposlenje, entity.Sifra, id), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    MessageBox.Show(Convert.ToString(e));
                    throw e;
                }
            }

            public void delete(Uposlenik entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM uposlenici WHERE id ='{0}';", entity.IdUposlenika), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Uposlenik getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM uposlenici WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Uposlenik Uposlenik = new Uposlenik
                        (
                            r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"),
                            r.GetString("spol"), r.GetDateTime("datumRodjenja"),
                            r.GetDateTime("datumZaposlenja"), r.GetDecimal("plata"),
                            r.GetString("kontakt"), r.GetString("zaposlenje"), r.GetString("sifra")
                        );
                        r.Close();
                        return Uposlenik;
                    }
                    else throw
                        new Exception("Nema podataka za prikaz");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Uposlenik> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM uposlenici;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Uposlenik> Uposlenici = new List<Uposlenik>();
                    while (r.Read())
                        Uposlenici.Add(new Uposlenik
                        (
                            r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), 
                            r.GetString("spol"), r.GetDateTime("datumRodjenja"), 
                            r.GetDateTime("datumZaposlenja"), r.GetDecimal("plata"),
                            r.GetString("kontakt"), r.GetString("zaposlenje"), r.GetString("sifra")
                        ));

                    r.Close();
                    return Uposlenici;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Uposlenik> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM uposlenici WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Uposlenik> Uposlenici = new List<Uposlenik>();
                    while (r.Read())
                        Uposlenici.Add(new Uposlenik
                        (
                            r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), 
                            r.GetString("spol"), r.GetDateTime("datumRodjenja"), 
                            r.GetDateTime("datumZaposlenja"), r.GetDecimal("plata"), 
                            r.GetString("kontakt"), r.GetString("zaposlenje"), r.GetString("sifra")
                        ));
                    r.Close();
                    return Uposlenici;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
