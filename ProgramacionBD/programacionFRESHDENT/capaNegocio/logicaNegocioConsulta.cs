using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace capaNegocio
{
    public class logicaNegocioConsulta
    {
        accesoDatosConsulta ac = new accesoDatosConsulta();

        public int insertarConsulta(Consulta c)
        {
            return ac.insertarConsulta(c);
        }
        public List<Consulta> listarConsulta()
        {
            return ac.listarConsulta();
        }
        public int eliminarConsulta(int idcons)
        {
            return ac.eliminarConsulta(idcons);
        }
        public int editarConsulta(Consulta c)
        {
            return ac.editarConsulta(c);
        }
        public List<Consulta> buscarConsulta(string dato)
        {
            return ac.buscarConsulta(dato);
        }
    }
}
