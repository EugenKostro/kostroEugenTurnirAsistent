using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel.Models
{
    public class OsobaModel
    {
        /// <summary>
        /// unikatan id za osobu
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// ime igraca
        /// </summary>
        public string Ime { get; set; }
        /// <summary>
        /// prezime igraca
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// mail adresa igraca za primanje notifikacija o sljedecoj rundi
        /// </summary>
        public string EmailAdresa { get; set; }
        /// <summary>
        /// broj telefona igraca da dobije informaciju o sljedecoj rundi
        /// </summary>
        public string BrojMobitela { get; set; }

        public string PunoIme
        {
            get
            {
                return $"{ Ime } { Prezime }";
            }
        }
    }
}
