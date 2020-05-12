using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace capaNegocio
{
    public class logicaNegocioConsultaReceta
    {
        accesoDatosConsultaReceta acr = new accesoDatosConsultaReceta();

        public int insertarConsultaReceta(Consulta_Receta cr)
        {
            return acr.insertarConsultaReceta(cr);
        }
        public List<Consulta_Receta> listarConsultaReceta()
        {
            return acr.listarConsultaReceta();
        }
        public int eliminarConsultaReceta(int idConsulta)
        {
            return acr.eliminarConsultaReceta(idConsulta);
        }
        public int editarConsultaReceta(Consulta_Receta cr)
        {
            return acr.editarConsultaReceta(cr);
        }
        public List<Consulta_Receta> buscarConsultaReceta(string dato)
        {
            return acr.buscarConsultaReceta(dato);
        }
    }
}
