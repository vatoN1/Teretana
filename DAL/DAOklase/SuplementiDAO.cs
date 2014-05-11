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
        public class SuplementDAO : IDaoCrud<Suplement>
        {
            protected MySqlCommand c;

            public long create(Suplement entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO suplementi VALUES ('{0}','{1}');"
                        , entity.TipSuplementa, entity.Cijena), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Suplement read(Suplement entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM suplementi WHERE id='{0}'", entity.IdSuplementa)
                        , con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Suplement Suplement = new Suplement
                        (
                            r.GetInt32("id"), r.GetString("tipSuplementa"), r.GetDecimal("cijena")
                        );

                        r.Close();
                        return Suplement;
                    }
                    else throw
                     new Exception("Nema podataka za citanje");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Suplement update(int id, Suplement entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE suplementi SET, tipSuplementa='{0}', " +
                              "cijena='{1}, where id = '{2}'",
                        entity.IdSuplementa, entity.TipSuplementa, entity.Cijena, id), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Suplement entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM suplementi WHERE id ='{0}';", 
                        entity.IdSuplementa), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Suplement getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM suplementi WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Suplement Suplement = new Suplement
                        (
                            r.GetInt32("id"), r.GetString("tipSuplementa"), r.GetDecimal("cijena")
                        );
                        r.Close();
                        return Suplement;
                    }
                    else throw
                        new Exception("Nema podataka za prikaz");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Suplement> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM workoutprogram;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Suplement> Suplementi = new List<Suplement>();
                    while (r.Read())
                        Suplementi.Add(new Suplement
                        (
                            r.GetInt32("id"), r.GetString("tipSuplementa"), r.GetDecimal("cijena")
                        ));

                    r.Close();
                    return Suplementi;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Suplement> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM suplementi WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Suplement> Suplementi = new List<Suplement>();
                    while (r.Read())
                        Suplementi.Add(new Suplement
                        (
                            r.GetInt32("id"), r.GetString("tipSuplementa"), r.GetDecimal("cijena")
                        ));
                    r.Close();
                    return Suplementi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
