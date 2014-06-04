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
        public class OpremaDAO : IDaoCrud<Oprema>
        {
            protected MySqlCommand c;

            public long create(Oprema entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("INSERT INTO Oprema VALUES ('{0}', '{1}', '{2}', '{3}');",
                        entity.ID, entity.Kolicina, entity.CijenaNajama, entity.TipOpremeS), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Oprema read(Oprema entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Oprema WHERE id = '{0}';", entity.ID), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Oprema o = new Oprema(r.GetInt32("id"), r.GetInt32("kolicina"), r.GetDouble("cijenaNajama"), r.GetString("tipOpreme"));
                        r.Close();

                        return o;
                    }
                    else throw new Exception("Nema podataka za citanje");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Oprema update(int id, Oprema entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE Oprema SET id='{0}', kolicina = '{1}', tipOpreme = '{2}', cijenaNajama = '{3}';",
                        entity.ID, entity.Kolicina, entity.TipOpreme.ToString(), entity.CijenaNajama), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Oprema entity)
            {
                try
                {
                    c = new MySqlCommand(("DELETE FROM Oprema WHERE id = '" + entity.ID + "';"), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Oprema> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Oprema;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Oprema> oprema = new List<Oprema>();
                    while (r.Read())
                        oprema.Add(new Oprema(r.GetInt32("id"), r.GetInt32("kolicina"), r.GetDouble("cijenaNajama"), r.GetString("tipOpreme")));

                    r.Close();
                    return oprema;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Oprema getById(long id)
            {
                try
                {
                    c = new MySqlCommand(("SELECT * FROM Oprema WHERE id='" + id + "';"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Oprema o = new Oprema(r.GetInt32("id"), r.GetInt32("kolicina"), r.GetDouble("cijenaNajama"), r.GetString("tipOpreme"));
                        r.Close();
                        return o;
                    }
                    else throw
                        new Exception("Nema podataka za prikaz");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Oprema> getByExample(string name, string value)
            {
                try
                {
                    c = new MySqlCommand(("SELECT * FROM Oprema WHERE " + name + "='" + value + "';"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Oprema> oprema = new List<Oprema>();
                    while (r.Read())
                        oprema.Add(new Oprema(r.GetInt32("id"), r.GetInt32("kolicina"), r.GetDouble("cijenaNajama"), r.GetString("tipOpreme")));
                    r.Close();
                    return oprema;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
