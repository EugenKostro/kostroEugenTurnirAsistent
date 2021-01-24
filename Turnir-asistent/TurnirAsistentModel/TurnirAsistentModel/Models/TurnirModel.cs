using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel.Models
{
    public class TurnirModel
    {
        /// <summary>
        /// jedinstveni identitet za turnir
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// naziv turnira koji je kreiran
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// placanje za ulazak u turnir(npr 50kn)
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// lista timova koji su prijavljeni na turniru
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// lista nagrad za prva tri mjesta (imenuj ih)
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// U turniru ima vise rundi, treba lista rundi koje ce se nalaziti u turniru 
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; } = new List<List<UtakmicaModel>>();
    }
}
