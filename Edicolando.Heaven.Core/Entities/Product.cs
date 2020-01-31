using Edicolando.Heaven.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edicolando.Heaven.Core.Entities
{
    /// <summary>
    /// Qui genero la classe, od entità (oggetto - Entity) relativo ai prodotti
    /// Inserisco le variabili relative solo a questa classe ed alla stessa faccio 
    /// eredita le variabili (e metodi, se sussistono) dell' interfaccia IEntity
    /// </summary>
    public class Product : IEntity //Eredita da IEntity, ricordatio di implemenatrla con ctrl + .

    {/// <summary>
     /// Imposto le variabili legate alla classe Prodotto, in lettura e scrittura
     /// </summary>
        public string productid  {get; set;} // Variabile dell' Id del prodotto di tipo stringa

        public string productname { get; set; } // Variabile del nome prodotto, di tipo stringa

        public string productdescription { get; set; } // Variabile della descrizione, di tipo stringa

        public int productean { get; set; } // Variabile del barcode, di tipo integer

        public string productqrcode { get; set; } // Variabile del QRCode, di tipo stringa

        public int racommandedage { get; set; } // Variabile della età target raccomandata, di tipo integer

        public DateTime productcreationdate { get; set; } // Variabile della data di creazione prodotto, ti tipo metodo DateTime

        public DateTime productupdatedate { get; set; } // Variabile della data di modifica prodotto, ti tipo metodo DateTime





    }
}
