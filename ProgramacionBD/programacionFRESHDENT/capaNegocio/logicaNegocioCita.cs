using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace capaNegocio
{
    public class logicaNegocioCita
    {
        accesoDatosCita act = new accesoDatosCita();

        public int insertarCita(Cita ct)
        {
            return act.insertarCita(ct);
        }
        public List<Consulta> listarCita()
        {
            return act.listarCita();
        }
        public int eliminarCita(int idcit)
        {
            return act.eliminarCita(idcit);
        }
        public int editarConsulta(Cita ct)
        {
            return act.editarCita(ct);
        }
        public List<Cita> buscarCita(string dato)
        {
            return act.buscarCita(dato);
        }
    }
}
