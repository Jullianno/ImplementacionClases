using ImplementacionClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionClases.DAL
{

    
    public class DatoDAL
    {

        private List<DatoDTO> ListaDatos;


        public DatoDAL()
        {
            this.ListaDatos = new List<DatoDTO>();
        }

        public bool Insertar(DatoDTO datos)
        {

            try
            {
                this.ListaDatos.Add(datos);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            

            return false;
        } 


        public bool Actualizar (DatoDTO datos)
        {
            
            return false;
        }


        public bool Eliminar(DatoDTO datos)
        {

            try
            {
                this.ListaDatos.Remove(datos);
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        public List<DatoDTO> Listar()
        {
            return this.ListaDatos;
        }


    }
}
