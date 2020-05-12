using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace capaNegocio
{
    public class logicaNegocioRecetaMedica
    {
        accesoDatosRecetaMedica arm = new accesoDatosRecetaMedica();

        public int insertarRecetaMedica(RecetaMedica rm)
        {
            return arm.insertarRecetaMedica(rm);

        }
        public List<RecetaMedica> listarRecetaMedica()
        {
            return arm.listarRecetaMedica();
        }
        public int eliminarRecetaMedica(int idReceta)
        {
            return arm.eliminarRecetaMedica(idReceta);
        }
        public int editarRecetaMedica (RecetaMedica rm)
        {
            return arm.editarRecetaMedica(rm);
        }
        public List<RecetaMedica> buscarRecetaMedica(string dato)
        {
            return arm.buscarRecetaMedica(dato);
        }
    }
}
