﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class ProstorijaDAO : IDaoCrud<Prostorija>
        {
            protected MySqlCommand c;

            public long create(Prostorija entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("INSERT INTO Prostorije VALUES ('{0}','{1}','{2}','{3}');",
                        entity.Id, entity.Dostupnost, entity.TipProstorije, entity.Inventar1), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public Prostorija update(int id, Prostorija entity) { throw new NotImplementedException(); }
            public Prostorija read(Prostorija entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Prostorije WHERE id='{0}';", entity.Id), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Prostorija prostorija = new Prostorija(
                            r.GetInt32("id"), r.GetString("nazivProstorije"), r.GetString("dostupnost"), r.GetString("inventar"));
                        r.Close();
                        return prostorija;
                    }
                    else throw
                     new Exception("Nema podataka za citanje");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Prostorija update(Prostorija entity)
            {
                try
                {
                    /*c = new MySqlCommand(String.Format("UPDATE Prostorije SET id='{0}', nazivProstorije='{1}', dostupnost='{2}', inventar = '{3}' where id = '{8}';",
                        entity.Id, entity.NazivProstorije, entity.Dostupnost, entity.Inventar, entity.Id), con);*/
                    c = new MySqlCommand("UPDATE prostorije set dostupnost= '" + entity.Dostupnost
                                            + "', nazivProstorije= '" + entity.TipProstorije
                                            + "', inventar= '" + entity.Inventar1
                                            + "' where id = " + entity.Id, con
                                            );
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Prostorija entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM Prostorije WHERE id ='{0}';", entity.Id), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Prostorija getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Prostorije WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Prostorija a = new Prostorija(r.GetInt32("id"), r.GetString("Dostupnost"), r.GetString("NazivProstorije"), 
                            r.GetString("Inventar"));
                        r.Close();
                        return a;
                    }
                    else throw
                        new Exception("Nema podataka za prikaz");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Prostorija> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Prostorije;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Prostorija> prostorija = new List<Prostorija>();
                    while (r.Read())
                        prostorija.Add(new Prostorija(r.GetInt32("id"), r.GetString("Dostupnost"), r.GetString("NazivProstorije"),
                            r.GetString("Inventar")));

                    r.Close();
                    return prostorija;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Prostorija> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Prostorije WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Prostorija> prostorija = new List<Prostorija>();
                    while (r.Read())
                        prostorija.Add(new Prostorija(r.GetInt32("id"), r.GetString("Dostupnost"), r.GetString("NazivProstorije"),
                            r.GetString("Inventar")));
                    r.Close();
                    return prostorija;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
