using Edicolando.Heaven.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edicolando.Heaven.Core.Entities
{
    /// <summary>
    /// Qui genero la classe, od entità (oggetto - Entity) relativo alle promozioni, legate ai prodotti, 
    /// non alle categorie, non è ereditabile dala categoria. Questo perchè a livello di implemenentazione del codice
    /// sarebbe un po' complesso e non elegante. Sarà invece comodo generare un METODO che aggiungerà ai prodotti 
    /// il flag di promoione
    /// Inserisco QUINDI le variabili relative solo a questa classe ed alla stessa faccio 
    /// ereditare le variabili (e metodi, se sussistono) dell' interfaccia IEntity
    /// </summary>
    public class Promotion : IEntity //Eredita da IEntity, ricordatio di implemenatrla con ctrl + .
    {
        public int promotionid { get; set; }

        public float promotionprice { get; set; }

        public DateTime creationdate { get; set; }

        public DateTime updatedate { get; set; }

    }
}
