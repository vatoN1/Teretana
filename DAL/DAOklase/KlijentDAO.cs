using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class KlijentDAO : IDaoCrud<Klijent>
        {
            protected MySqlCommand c;

            public long create(Klijent entity)
            {
                try
                {
                    var datumRodjenja = entity.DatumRodjenja.Date.ToString("yyyy-MM-dd");
                    c = new MySqlCommand(String.Format("INSERT INTO Klijenti VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                        entity.ID, entity.Ime, entity.Prezime, entity.Spol.ToString(), datumRodjenja, entity.Kontakt, entity.IDtrenera, entity.IDnutricioniste ), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public Klijent update(int id, Klijent entity) { throw new NotImplementedException(); }
            public Klijent read(Klijent entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Klijenti WHERE id = '{0}';", entity.ID), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Klijent k = new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("spol"),
                            r.GetDateTime("datumRodjenja"), r.GetString("kontakt"), r.GetInt32("id_trenera"), r.GetInt32("id_nutricioniste"));
                        r.Close();

                        return k;
                    }
                    else throw new Exception("Nema podataka za citanje");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Klijent update(Klijent entity)
            {
                try
                {
                    var datumRodjenja = entity.DatumRodjenja.Date.ToString("yyyy-MM-dd");
                    /*c = new MySqlCommand(String.Format("UPDATE Klijenti SET id='{0}', ime = '{1}', prezime = '{2}', spol = '{3}', datumRodjenja = '{4}', kontakt = '{5}', id_trenera = '{6}', id_nutricioniste = '{7}';",
                        entity.ID, entity.Ime, entity.Prezime, entity.Spol.ToString(), entity.DatumRodjenja.ToShortDateString(), entity.Kontakt, entity.IDtrenera, entity.IDnutricioniste), con);*/
                    c = new MySqlCommand("UPDATE klijenti set ime= '" + entity.Ime
                                            + "', prezime= '" + entity.Prezime
                                            + "', spol= '" + Convert.ToString(entity.Spol)
                                            + "', datumRodjenja= '" + datumRodjenja
                                            + "', kontakt= '" + entity.Kontakt
                                            + "', id_trenera= " + entity.IDtrenera
                                            + ", id_nutricioniste= " + entity.IDnutricioniste
                                            + " where id = " + entity.ID, con
                                            );
                    
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Klijent entity)
            {
                try
                {
                    c = new MySqlCommand(("DELETE FROM Klijenti WHERE id = '" + entity.ID + "';"), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Klijent> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Klijenti;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Klijent> klijenti = new List<Klijent>();
                    while (r.Read())
                        klijenti.Add(new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("spol"),
                            r.GetDateTime("datumRodjenja"), r.GetString("kontakt"), r.GetInt32("id_trenera"), r.GetInt32("id_nutricioniste")));

                    r.Close();
                    return klijenti;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Klijent getById(long id)
            {
                try
                {
                    c = new MySqlCommand(("SELECT * FROM Klijenti WHERE id='" + id + "';"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Klijent k = new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("spol"),
                            r.GetDateTime("datumRodjenja"), r.GetString("kontakt"), r.GetInt32("id_trenera"), r.GetInt32("id_nutricioniste"));
                        r.Close();
                        return k;
                    }
                    else throw
                        new Exception("Nema podataka za prikaz");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Klijent> getByExample(string name, string value)
            {
                try
                {
                    c = new MySqlCommand(("SELECT * FROM Klijenti WHERE " + name + "='" + value + "';"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Klijent> klijenti = new List<Klijent>();
                    while (r.Read())
                        klijenti.Add(new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("spol"),
                            r.GetDateTime("datumRodjenja"), r.GetString("kontakt"), r.GetInt32("id_trenera"), r.GetInt32("id_nutricioniste")));
                    r.Close();
                    return klijenti;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
