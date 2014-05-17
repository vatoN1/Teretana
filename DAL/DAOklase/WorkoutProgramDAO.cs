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
        public class WorkoutProgramDAO : IDaoCrud<WorkoutProgram>
        {
            protected MySqlCommand c;

            public long create(WorkoutProgram entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO workoutprogrami VALUES ('{0}','{1}', '{2}');"
                        , entity.Opis, entity.TipPrograma, entity.Vjezbe), con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public WorkoutProgram read(WorkoutProgram entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM workoutprogrami WHERE id='{0}'", entity.IdWorkoutPrograma)
                        , con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        WorkoutProgram WorkoutProgram= new WorkoutProgram
                        (
                            r.GetInt32("id"), r.GetString("opis"), r.GetString("tipPrograma"), r.GetString("vjezbe")
                        );

                        r.Close();
                        return WorkoutProgram;
                    }
                    else throw
                     new Exception("Nema podataka za citanje");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public WorkoutProgram update(int id, WorkoutProgram entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE wokroutprogrami SET opis='{0}', tipPrograma='{1}', " +
                              "vjezbe='{2}, where id = '{9}'",
                        entity.IdWorkoutPrograma, entity.Opis, entity.TipPrograma, entity.Vjezbe, id), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(WorkoutProgram entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM workoutprogrami WHERE id ='{0}';",
                        entity.IdWorkoutPrograma), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public WorkoutProgram getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM workoutprogrami WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        WorkoutProgram WorkoutProgram = new WorkoutProgram
                        (
                            r.GetInt32("id"), r.GetString("opis"), r.GetString("tipPrograma"), r.GetString("vjezbe")
                        );
                        r.Close();
                        return WorkoutProgram;
                    }
                    else throw
                        new Exception("Nema podataka za prikaz");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<WorkoutProgram> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM workoutprogrami;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<WorkoutProgram> WorkoutProgrami = new List<WorkoutProgram>();
                    while (r.Read())
                        WorkoutProgrami.Add(new WorkoutProgram
                        (
                            r.GetInt32("id"), r.GetString("opis"), r.GetString("tipSuplementa"), r.GetString("vjezbe")
                        ));

                    r.Close();
                    return WorkoutProgrami;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<WorkoutProgram> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM workoutprogrami WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<WorkoutProgram> WorkoutProgrami = new List<WorkoutProgram>();
                    while (r.Read())
                        WorkoutProgrami.Add(new WorkoutProgram
                        (
                            r.GetInt32("id"), r.GetString("opis"), r.GetString("tipSuplementa"), r.GetString("vjezbe")
                        ));
                    r.Close();
                    return WorkoutProgrami;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
