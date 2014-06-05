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

        public class IzvjestajDAO : IDaoCrud<Izvjestaj>
        {
            protected MySqlCommand c;
            public long create(Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("INSERT INTO Izvjestaji VALUES ('{0}', '{1}', '{2}', '{3}');",
                        entity.ID, entity.IDuposlenik, entity.DatumIzvjestaja.ToShortDateString(), entity.SadrzajIzvjestaja), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Izvjestaj read(Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand (String.Format("SELECT * FROM Izvjestaji WHERE id = '{0}';", entity.ID ), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Izvjestaj izv = new Izvjestaj(r.GetInt32("id"), r.GetInt32("Uposlenici_ID"), r.GetDateTime("datumIzvjestaja"), r.GetString("sadrzaj"));
                        r.Close();

                        return izv;
                    }
                    else throw new Exception("Nema podataka za citanje");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Izvjestaj update(int id, Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE Izvjestaji SET id='{0}', Uposlenici_ID = '{1}', datumIzvjestaja = '{2}', sadrzaj = '{3}';",
                        entity.ID, entity.IDuposlenik, entity.DatumIzvjestaja, entity.SadrzajIzvjestaja), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public Izvjestaj update(Izvjestaj entity) { throw new NotImplementedException(); }
            public void delete(Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand(("DELETE FROM Izvjestaji WHERE id = '" + entity.ID + "';"), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Izvjestaj> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Izvjestaji;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Izvjestaj> izvjestaji = new List<Izvjestaj>();
                    while (r.Read())
                        izvjestaji.Add(new Izvjestaj(r.GetInt32("id"), r.GetInt32("Uposlenici_ID"), r.GetDateTime("datumIzvjestaja"), r.GetString("sadrzaj")));

                    r.Close();
                    return izvjestaji;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Izvjestaj getById(long id)
            {
                try
                {
                    c = new MySqlCommand(("SELECT * FROM Izvjestaji WHERE id ='" + id + "';"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Izvjestaj a = new Izvjestaj(r.GetInt32("id"), r.GetInt32("Uposlenici_ID"), r.GetDateTime("datumIzvjestaja"), r.GetString("sadrzaj"));
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

            public List<Izvjestaj> getByExample(string name, string value)
            {
                try
                {
                    c = new MySqlCommand(("SELECT * FROM Izvjestaji WHERE " + name + "='" + value + "';"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Izvjestaj> izvjestaji = new List<Izvjestaj>();
                    while (r.Read())
                        izvjestaji.Add(new Izvjestaj(r.GetInt32("id"), r.GetInt32("Uposlenici_ID"), r.GetDateTime("datumIzvjestaja"), r.GetString("sadrzaj")));
                    r.Close();
                    return izvjestaji;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
