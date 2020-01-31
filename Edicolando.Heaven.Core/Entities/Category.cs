using Edicolando.Heaven.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edicolando.Heaven.Core.Entities

{

    /// <summary>
    /// Qui genero la classe, od entità (oggetto - Entity) relativo alle categorie
    /// Inserisco le variabili relative solo a questa classe ed alla stessa faccio 
    /// eredita le variabili (e metodi, se sussistono) dell' interfaccia IEntity
    /// </summary>
    class Category : IEntity //Eredita da IEntity, ricordatio di implemenatrla con ctrl + .
    {
        /// <summary>
        /// Imposto le variabili legate alla classe Categoria, in lettura e scrittura
        /// </summary>
        public string idcategory { get; set; } // Variabile dell' Id della categoria di tipo stringa

        public string categoryname { get; set; } //Variabile del nome categoria, di tipo stringa

        public string categorydescription { get; set; } // Variabile della descrizione della categoria, di tipo string

        public DateTime categorycreationdate { get; set; } // Variabile della data di creazione categoria, ti tipo metodo DateTime

        public DateTime categoryupdatedate { get; set; }  // Variabile della data di modifica categoria, ti tipo metodo DateTime




    }
}
