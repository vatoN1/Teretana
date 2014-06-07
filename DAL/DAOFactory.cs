using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class DAL
    {
        public class DAOFactory
        {
            private static DAOFactory instanca = null;

            public static DAOFactory Instanca
            {
                get { return (instanca == null) ? instanca = new DAOFactory() : instanca; }
            }
       
            private DAOFactory() { }

            public IzvjestajDAO getIzvjestajDAO()
            {
                return new IzvjestajDAO();
            }

            public KlijentDAO getKlijentDAO()
            {
                return new KlijentDAO();
            }

            public OpremaDAO getOpremaDAO()
            {
                return new OpremaDAO();
            }

            public PrehrambeniProgramDAO getPrehrambeniProgramDAO()
            {
                return new PrehrambeniProgramDAO();
            }
            public ProstorijaDAO getProstorijaDAO()
            {
                return new ProstorijaDAO();
            }

            public SpravaDAO getSpravaDAO()
            {
                return new SpravaDAO();
            }

            public SuplementDAO getSuplementDAO()
            {
                return new SuplementDAO();
            }

            public UposlenikDAO getUposlenikDAO()
            {
                return new UposlenikDAO();
            }

            public WorkoutProgramDAO getWorkoutProgramDAO()
            {
                return new WorkoutProgramDAO();
            }
        }
    }
}
