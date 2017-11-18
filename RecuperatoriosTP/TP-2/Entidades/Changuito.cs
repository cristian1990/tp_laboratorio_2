using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        #region Atributos
        private int _espacioDisponible;

        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        private List<Producto> _productos;
        #endregion

        #region Constructores
        private Changuito()
        {
            _productos = new List<Producto>();
        }

        public Changuito(int espacioDisponible) : this()
        {
            _espacioDisponible = espacioDisponible;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestro la concecionaria y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Mostrar(Changuito changuito, ETipo tipoDeProducto) //quitar static
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", changuito._productos.Count, changuito._espacioDisponible);
            sb.AppendLine("");
            sb.AppendLine("");

            foreach (Producto prod in changuito._productos)
            {
                switch (tipoDeProducto)
                {
                    case ETipo.Snacks:
                        if (prod is Snacks)
                            sb.AppendLine(((Snacks)prod).Mostrar());
                        break;
                    case ETipo.Dulce:
                        if (prod is Dulce)
                            sb.AppendLine(((Dulce)prod).Mostrar());
                        break;
                    case ETipo.Leche:
                        if (prod is Leche)
                            sb.AppendLine(((Leche)prod).Mostrar());
                        break;
                    default:
                        sb.AppendLine(prod.Mostrar());
                        break;
                }
            }

                return sb.ToString();
        }

        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se agregará el elemento</param>
        /// <param name="producto">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito changuito, Producto producto)
        {
            foreach (Producto prod in changuito._productos)
            {
                if (prod == producto)
                    return changuito;
            }

            if (changuito._espacioDisponible > changuito._productos.Count)
            {
                changuito._productos.Add(producto);
            }

            return changuito;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se quitará el elemento</param>
        /// <param name="pproducto">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito changuito, Producto producto)
        {
            foreach (Producto prod in changuito._productos)
            {
                if (prod == producto)
                {
                    changuito._productos.Remove(prod);
                    break;
                }
            }

            return changuito;
        }
        #endregion
    }
}

