using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        /// <summary>
        /// Atributo de la clase
        /// </summary>
        private string html;
        private Uri direccion;

        /// <summary>
        /// Declaracion de delegado DescargaCompleta
        /// </summary>
        /// <param name="resultado">Resultado de la descarga</param>
        public delegate void DescargaCompleta(string resultado);

        /// <summary>
        /// Declaracion de delegado Progreso
        /// </summary>
        /// <param name="progreso">Resultado del Progreso</param>
        public delegate void Progreso(int progreso);

        /// <summary>
        /// Declaracion de los eventos
        /// </summary>
        public event DescargaCompleta descargaCompleta;
        public event Progreso progreso;

        /// <summary>
        /// Constructor de la clase Descargador que me permite definirle la direccion url
        /// </summary>
        /// <param name="direccion">Direccion Url</param>
        public Descargador(Uri direccion)
        {
            this.html = "";
            this.direccion = direccion;
        }

        /// <summary>
        /// Metodo IniciarDescarga
        /// </summary>
        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClientDownloadProgressChanged);
                cliente.DownloadStringCompleted += new DownloadStringCompletedEventHandler(WebClientDownloadCompleted);

                cliente.DownloadStringAsync(direccion, html);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// WebClientDownloadProgressChanged
        /// </summary>
        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progreso(e.ProgressPercentage);
        }

        /// <summary>
        /// WebClientDownloadCompleted
        /// </summary>
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                this.html = e.Result;
                this.descargaCompleta(this.html);
            }
            catch (Exception error)
            {
                this.descargaCompleta("Error de acceso, " + error.InnerException.Message);
            }
        }
    }
}
