using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace capaNegocio
{
    public class logicaNegocioEspecialidad
    {
        accesoDatosEspecialidad aesp = new accesoDatosEspecialidad();

        public int insertarEspecialidad(Especialidad esp)
        {
            return aesp.insertarEspecialidad(esp);
        }
        public List<Especialidad> listarEspecialidad()
        {
            return aesp.listarEspecialidad();
        }
        public int eliminarEspecialidad(int idEspecialidad)
        {
            return aesp.eliminarEspecialidad(idEspecialidad);
        }
        public int editarEspecialidad(Especialidad esp)
        {
            return aesp.editarEspecialidad(esp);
        }
        public List<Especialidad> buscarEspecialidad(string dato)
        {
            return aesp.buscarEspecialidad(dato);
        }
    }
}
