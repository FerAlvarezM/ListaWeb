
using System;
using System.ComponentModel.DataAnnotations;

namespace ListaWeb.Models
{


    public class PendienteItem
    {
        /// Guid genera un secuencia aletoria 
        /// Investigar Guid
        public Guid Id { get; set; }

        public bool EstaHecha { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Pendiente { get; set; }

        public DateTimeOffset? ParaCuando { get; set; }

        /// Aquí deben hacer todo lo necesario para la creación de un Pendiente
        public PendienteItem()
        {
           /// El Id debe generarse a la creación de Guid
        
            DateTime PorHacer= DateTime.Today;
 
            /// Las tareas son para dentro de dos días 

            ParaCuando = PorHacer.AddDays(3);

            
            /// Siempre las tareas deben estas no EstaHecha = false

           
           //identificador global 
           Guid guid = Guid.NewGuid();
           string id = guid.ToString();
           EstaHecha = false ;
        }
    }
}
