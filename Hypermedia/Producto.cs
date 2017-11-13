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
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Imagen { get; set; }
        public int Existencia { get; set; }
        public int Id { get; set; }

        public Producto(string nombre, string descripcion, float precio, int existencia, string imagen, int id)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencia = existencia;
            this.Imagen = imagen;
            this.Id = id;
        }
    }
}