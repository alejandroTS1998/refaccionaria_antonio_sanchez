using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_refaccionaria.BD;
using proyecto_refaccionaria.clases;

namespace proyecto_refaccionaria.control
{
    class control_Ventas
    {
        public void agregarventa(ventas mventas)
        {
            String SQL = "insert into venta values " +
                "(null,'?1','?2')";
            SQL = SQL.Replace("?1", mventas.fecha.ToString());
            SQL = SQL.Replace("?2", mventas.total.ToString());
            


            basedatos mConeccion = new basedatos();
            mConeccion.Conectar();
            mConeccion.ejecutarActualizacion(SQL);
            mConeccion.Desconectar();
        }


        public DataSet consultartodasventas()
        {
            String SQL = "select * from ventas";
            DataSet listaventas;
            basedatos mconexion = new basedatos();
            mconexion.Conectar();
            listaventas = mconexion.ejecutarConsulta(SQL);
            mconexion.Desconectar();
            return listaventas;
        }
        public DataSet consultarventa(ventas mventa)
        {
            String SQL = "select * from venta where id_venta ='?1' ";
            SQL = SQL.Replace("?1", mventa.id_venta.ToString());
            DataSet listaventas2;
            basedatos mconexion = new basedatos();
            mconexion.Conectar();
            listaventas2 = mconexion.ejecutarConsulta(SQL);
            mconexion.Desconectar();
            return listaventas2;
        }
        public DataSet consultarprecio(producto mproducto)
        {
            String SQL = "select precio from producto where nombre = '?1' ";
            SQL = SQL.Replace("?1", mproducto.Nombre);
            DataSet listaproductos;
            basedatos mconexion = new basedatos();
            mconexion.Conectar();
            listaproductos = mconexion.ejecutarConsulta(SQL);
            mconexion.Desconectar();
            return listaproductos;
        }
    }
}
