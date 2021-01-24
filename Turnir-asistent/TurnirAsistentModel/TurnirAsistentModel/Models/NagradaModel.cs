using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel.Models
{
    public class NagradaModel
    {
        /// <summary>
        /// jedinstveni identitet za nagradu
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// pozicija mjesta koju je ekipa osvojila
        /// </summary>
        public int Mjesto { get; set; }
        /// <summary>
        /// naziv mjesta koju je ekipa osvojila
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Kolicina nagrade koju ce ekipa dobiti
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// postotak nagrade koju ce ekipa dobiti(npr 50%)
        /// </summary>
        public double PostotakNagrade { get; set; }

        public NagradaModel()
        {

        }
        public NagradaModel(string mjesto, string nazivMjesta, string iznosNagrade, string postotakNagrade)
        {
            NazivMjesta = nazivMjesta;

            int mjestoValue = 0;
            int.TryParse(mjesto, out mjestoValue);
            Mjesto = mjestoValue;

            decimal iznosNagradeValue = 0;
            decimal.TryParse(iznosNagrade, out iznosNagradeValue);
            IznosNagrade = iznosNagradeValue;

            double postotakNagradeValue = 0;
            double.TryParse(postotakNagrade, out postotakNagradeValue);
            PostotakNagrade = postotakNagradeValue;
        }

    }
}
