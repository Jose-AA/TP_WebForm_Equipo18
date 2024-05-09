﻿using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWinForm_Equipo18
{
    public partial class Contact : Page
    {
        List<Articulo> listaCarrito = new List<Articulo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Articulo ar1 = new Articulo();
            Articulo ar2 = new Articulo();
            Articulo ar3 = new Articulo();

            Marca mar1 = new Marca();
            Marca mar2 = new Marca();
            Marca mar3 = new Marca();

            Categoria cat1 = new Categoria();
            Categoria cat2 = new Categoria();
            Categoria cat3 = new Categoria();

            Imagen ima1 = new Imagen();
            Imagen ima2 = new Imagen();

            ima1.IDImagen = 1;
            ima2.IDImagen = 2;

            ima1.IDArticulo = 1;
            ima2.IDArticulo = 1;

            ima1.Url = "";
            ima2.Url = "";

            cat1.ID = 1;
            cat2.ID = 2;
            cat3.ID = 3;

            cat1.Descripcion = "Computadoras";
            cat2.Descripcion = "Celulares";
            cat3.Descripcion = "Televisores";

            mar1.id = 1;
            mar2.id = 2;
            mar3.id = 3;

            mar1.descripcion = "HP";
            mar2.descripcion = "Aplle";
            mar3.descripcion = "Sony";

            ar1.id = 1;
            ar2.id = 2;
            ar3.id = 3;

            ar1.codigo = "ao01";
            ar2.codigo = "ao02";
            ar3.codigo = "ao03";

            ar1.nombre = "Compu";
            ar2.nombre = "celu";
            ar3.nombre = "tele";

            ar1.descripcion = "14'' con touch screen";
            ar2.descripcion = "El de la manzanita";
            ar3.descripcion = "Con control inteligente";

            ar1.precio = 100000;
            ar2.precio = 5000000;
            ar3.precio = 2000000;

            ar1.categoriaArticulo = cat1;
            ar2.categoriaArticulo = cat2;
            ar3.categoriaArticulo = cat3;

            ar1.marcaArticulo = mar1;
            ar2.marcaArticulo = mar2;
            ar3.marcaArticulo = mar3;

            ar1.imagenes = new List<Imagen>();
            ar1.imagenes.Add(ima1);
            ar1.imagenes.Add(ima2);

            listaCarrito.Add(ar1);
            listaCarrito.Add(ar2);
            listaCarrito.Add(ar3);
            Title = "Aqui podremos ver todo lo contenido dentro del carrito ";  

        }
    }
}