using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace capaNegocio
{
    public class logicaNegocioExpediente
    {
        accesoDatosExpediente ae = new accesoDatosExpediente();

        public int insertarExpediente(Expediente ex)
        {
            return ae.insertarExpediente(ex);
        }
        public List<Expediente> listarExpediente()
        {
            return ae.listarExpediente();
        }
        public int eliminarExpediente(int idExpediente)
        {
            return ae.eliminarExpediente(idExpediente);
        }
        public int editarExpediente(Expediente ex)
        {
            return ae.editarExpediente(ex);
        }
        public List<Expediente> buscarExpediente(string dato)
        {
            return ae.buscarExpediente(dato);
        }
    }
}
