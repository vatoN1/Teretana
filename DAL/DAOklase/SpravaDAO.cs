﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class SpravaDAO : IDaoCrud<Sprava>
        {
            protected MySqlCommand c;

            public long create(Sprava entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO Sprave VALUES ('{0}','{1}','{2}','{3}');",
                        entity.Id, entity.Starost, entity.TipSpraveS, entity.Kolicina), con); // ****
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public Sprava update(int id, Sprava entity) { throw new NotImplementedException(); }
            public Sprava read(Sprava entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Sprave WHERE id='{0}'", entity.Id), con); //**

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    { //******
                        Sprava sprava = new Sprava(r.GetInt32("Id"), r.GetString("TipSprave"), r.GetInt32("Kolicina"), r.GetInt32("Starost")); 
                        r.Close();
                        return sprava;
                    }
                    else throw
                     new Exception("Nema podataka za citanje");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Sprava update(Sprava entity)
            {
                try
                { //****************
                    /*c = new MySqlCommand(String.Format("UPDATE Sprave SET Id='{0}', TipSprave='{1}', Kolicina='{2}', Starost = '{3}' where id = '{8}';",
                        entity.Id, entity.TipSprave, entity.Kolicina, entity.Starost, id), con);*/
                    c = new MySqlCommand("UPDATE sprave set starost= " + entity.Starost
                                            + ", tipSprave= '" + entity.TipSpraveS
                                            + "', kolicina= " + entity.Kolicina
                                            + " where id = " + entity.Id, con
                                            );
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Sprava entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM Sprave WHERE id ='{0}';", entity.Id), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Sprava getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Sprave WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Sprava a = new Sprava(r.GetInt32("id"), r.GetString("TipSprave"), r.GetInt32("Kolicina"),
                            r.GetInt32("Starost"));
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

            public List<Sprava> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Sprave;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Sprava> Sprava = new List<Sprava>();
                    while (r.Read())
                        Sprava.Add(new Sprava(r.GetInt32("Id"), r.GetString("TipSprave"), r.GetInt32("Kolicina"),
                            r.GetInt32("Starost")));

                    r.Close();
                    return Sprava;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Sprava> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Sprave WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Sprava> Sprava = new List<Sprava>();
                    while (r.Read())
                        Sprava.Add(new Sprava(r.GetInt32("Id"), r.GetString("TipSprave"), r.GetInt32("Kolicina"),
                            r.GetInt32("Starost")));
                    r.Close();
                    return Sprava;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
