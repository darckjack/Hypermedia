using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Hypermedia
{
    public class ProductosRepo
    {
        public List<Producto> Inventario { get; set; }

        public ProductosRepo()
        {
            Inventario = new List<Producto>();
        }

        public void agregarProducto(string nombre, string descripcion, float precio, int existencia, string imagen, int id)
        {
            Producto aux = new Producto(nombre, descripcion, precio, existencia, imagen, id);
            this.Inventario.Add(aux);
        }

        public void actualizarInventario(Producto producto, int existencia)
        {
            this.Inventario[producto.Id].Existencia = existencia;
        }

        public List<Producto> buscarProductos(string consulta)
        {
            List<Producto> aux = new List<Producto>();

            for (int i = 0; i < this.Inventario.Count; i++)
            {
                int j;
                for (j = 0; j < consulta.Length; j++)
                {
                    if (j < this.Inventario[i].Nombre.Length)
                    {
                        if (this.Inventario[i].Nombre[j] != consulta[j])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                if (j == consulta.Length)
                    aux.Add(this.Inventario[i]);
            }

            return aux;

        }
    }
}