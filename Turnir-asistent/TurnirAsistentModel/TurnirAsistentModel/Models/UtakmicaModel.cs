using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel.Models
{
    public class UtakmicaModel
    {
        /// <summary>
        /// ekipa koja sudjeluje u utakmici
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// rezultat ove ekipe u utakmici
        /// </summary>
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// prethodna utakmica u kojoj je ova ekipa bila pobjednik
        /// </summary>
        public int BrojRunde { get; set; }
        
    }
}
