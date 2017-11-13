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
    public class Carrito : List<Producto>
    {
        public float getTotal()
        {
            float total = 0f;
            foreach (Producto producto in this)
            {
                total += producto.Precio;
            }
            return total;
        }

        public void vaciarCarrito()
        {
            this.Clear();
        }
    }
}