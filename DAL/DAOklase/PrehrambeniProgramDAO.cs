 	using System.Collections.Generic;
 	using System.Linq;
 	using System.Text;
	using MySql.Data.MySqlClient;
	using System.Threading.Tasks;
using System;
 	
	namespace DAL
 	{
	    partial class DAL
 	    {
	        public class PrehrambeniProgramDAO : IDaoCrud<PrehrambeniProgram>
	        {
	            protected MySqlCommand c;
	 
	            public long create(PrehrambeniProgram entity)
	            {
	                try
	                {
	                    
	                    c = new MySqlCommand(String.Format("INSERT INTO prehrambeniprogrami VALUES ('{0}','{1}','{2}','{3}');",
	                        entity.IdPrehrambeniProgram, entity.Opis, entity.TipProgramaS, entity.Obroci), con);
	                    c.ExecuteNonQuery();
	                    return c.LastInsertedId;
	                }
	                catch (Exception e)
	                {
	                    throw e;
	                }
	            }
                public PrehrambeniProgram update(int id, PrehrambeniProgram entity) { throw new NotImplementedException(); }
	            public PrehrambeniProgram read(PrehrambeniProgram entity)
	            {
	                try
	                {
	                    c = new MySqlCommand(String.Format("SELECT * FROM prehrambeniprogrami WHERE id='{0}'", entity.ID1), con);
	
	                    MySqlDataReader r = c.ExecuteReader();
	
	                    if (r.Read())
	                    {
	                        PrehrambeniProgram pprogram = new PrehrambeniProgram(r.GetInt32("id"), r.GetString("opis"), r.GetString("tipPrograma"), r.GetString("obroci"));
	                        r.Close();
	                        return pprogram;
	                    }
	                    else throw
	                     new Exception("Nema podataka za citanje");
	
	                }
	                catch (Exception e)
	                {
	                    throw e;
	                }
	            }
	
	            public PrehrambeniProgram update(PrehrambeniProgram entity)
	            {
	                try
	                {
	                    /*c = new MySqlCommand(String.Format("UPDATE prehrambeniprogrami SET id='{0}', opis='{1}', tipPrograma='{2}', obroci = '{3}' where id = '{8}';",
	                        entity.ID1, entity.Opis, entity.TipPrograma, entity.Obroci, id), con);*/
                        c = new MySqlCommand("UPDATE prehrambeniprogrami set opis= '" + entity.Opis
                                            + "', tipPrograma= '" + entity.TipProgramaS
                                            + "', obroci= '" + entity.Obroci
                                            + "' where id = " + entity.IdPrehrambeniProgram, con
                                            );
	                    c.ExecuteNonQuery();
	                    return entity;
	                }
	                catch (Exception e)
	                {
	                    throw e;
	                }
	            }
	
	            public void delete(PrehrambeniProgram entity)
	            {
	                try
	                {
	                    c = new MySqlCommand(String.Format("DELETE FROM prehrambeniprogrami WHERE id ='{0}';", entity.IdPrehrambeniProgram), con);
	                    c.ExecuteNonQuery();
	                }
	                catch (Exception e)
	                {
	                    throw e;
	                }
	            }
	
	            public PrehrambeniProgram getById(long id)
	            {
	                try
	                {
	                    c = new MySqlCommand(String.Format("SELECT * FROM prehrambeniprogrami WHERE id='{0}';", id), con);
	                    MySqlDataReader r = c.ExecuteReader();
	                    if (r.Read())
	                    {
	                        PrehrambeniProgram a = new PrehrambeniProgram(r.GetInt32("id"), r.GetString("opis"), r.GetString("tipPrograma"),
	                            r.GetString("obroci"));
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
	
	            public List<PrehrambeniProgram> GetAll()
	            {
	                try
	                {
	                    c = new MySqlCommand(String.Format("SELECT * FROM prehrambeniprogrami;"), con);
	                    MySqlDataReader r = c.ExecuteReader();
	                    List<PrehrambeniProgram> pprogram = new List<PrehrambeniProgram>();
	                    while (r.Read())
	                        pprogram.Add(new PrehrambeniProgram(r.GetInt32("id"), r.GetString("opis"), r.GetString("tipPrograma"),
	                            r.GetString("obroci")));
	
	                    r.Close();
	                    return pprogram;
	
	                }
	                catch (Exception e)
	                {
	                    throw e;
	                }
	            }
	
	            public List<PrehrambeniProgram> getByExample(string name, string values)
	            {
	                try
	                {
	                    c = new MySqlCommand(String.Format("SELECT * FROM prehrambeniprogrami WHERE {0}='{1}';", name, values), con);
	                    MySqlDataReader r = c.ExecuteReader();
	                    List<PrehrambeniProgram> pprogram = new List<PrehrambeniProgram>();
	                    while (r.Read())
	                        pprogram.Add(new PrehrambeniProgram(r.GetInt32("id"), r.GetString("opis"), r.GetString("tipPrograma"),
	                            r.GetString("obroci")));
	                    r.Close();
	                    return pprogram;
	                }
	                catch (Exception e)
	                {
	                    throw e;
	                }
	            }
	        }
 	    }
 	}
