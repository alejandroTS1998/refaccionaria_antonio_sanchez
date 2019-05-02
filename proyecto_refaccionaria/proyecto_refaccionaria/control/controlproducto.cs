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
    class controlproducto
    {
        public void agregarproducto(producto mproducto)
        {
            String SQL = "insert into producto values " +
                "(null,'?1','?2','?3','?4','?5','?6')";
            SQL = SQL.Replace("?1", mproducto.Nombre);
            SQL = SQL.Replace("?2", mproducto.descripcion);
            SQL = SQL.Replace("?3", mproducto.tipo);
            SQL = SQL.Replace("?4", mproducto.precio.ToString());
            SQL = SQL.Replace("?5", mproducto.marca);
            SQL = SQL.Replace("?6", mproducto.ruta);


            basedatos mConeccion = new basedatos();
            mConeccion.Conectar();
            mConeccion.ejecutarActualizacion(SQL);
            mConeccion.Desconectar();
        }
        public void Eliminarproducto(producto mproducto)
        {
            String SQL = "delete  from producto where id_producto='?1'";
            SQL = SQL.Replace("?1", mproducto.id_producto.ToString());
            basedatos mConeccion = new basedatos();
            mConeccion.Conectar();
            mConeccion.ejecutarActualizacion(SQL);
            mConeccion.Desconectar();
        }
        public void modificarproducto(producto mproducto)
        {
            String SQL = "update producto set " + "nombre='?1'," + "descripcion='?2',"
                + "tipo='?3'," + "precio='?4'," + "marca='?5'," + "rutai='?7'"
                + " where id_producto=?6";
            SQL = SQL.Replace("?1", mproducto.Nombre);
            SQL = SQL.Replace("?2", mproducto.descripcion);
            SQL = SQL.Replace("?3", mproducto.tipo);
            SQL = SQL.Replace("?4", mproducto.precio.ToString());
            SQL = SQL.Replace("?5", mproducto.marca);
            SQL = SQL.Replace("?6", mproducto.id_producto.ToString());
            SQL = SQL.Replace("?7", mproducto.ruta);
            basedatos mConeccion = new basedatos();
            mConeccion.Conectar();
            mConeccion.ejecutarActualizacion(SQL);
            mConeccion.Desconectar();
        }
        public DataSet consultartodosproductos()
        {
            String SQL = "select * from producto";
            DataSet listaproductos;
            basedatos mconexion = new basedatos();
            mconexion.Conectar();
            listaproductos = mconexion.ejecutarConsulta(SQL);
            mconexion.Desconectar();
            return listaproductos;
        }
        public DataSet consultarproductos(producto mproducto)
        {
            DataSet listaproductos2;
            listaproductos2 = null;
            basedatos mconexion = new basedatos();
            if (mproducto.marca == null)
            {
                String SQL = "select * from producto where nombre like '%?1%'";
                SQL = SQL.Replace("?1", mproducto.Nombre);              
                mconexion.Conectar();
                listaproductos2 = mconexion.ejecutarConsulta(SQL);
            }
            else
            {
                String SQL = "select * from producto where nombre like '%?1%' or marca like '%?2%'";
                SQL = SQL.Replace("?1", mproducto.Nombre);
                SQL = SQL.Replace("?2", mproducto.marca);

                mconexion.Conectar();
                listaproductos2 = mconexion.ejecutarConsulta(SQL);
            }
                mconexion.Desconectar();
            
            return listaproductos2;
            
        }
    }
}
