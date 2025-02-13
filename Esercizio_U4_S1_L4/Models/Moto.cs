using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_U4_S1_L4.Models {
    public class Moto : Veicolo {

        public string CatenaMoto {
            get; set;
        }

        public Moto(string targa, string marca, string modello, string catenamoto) : base(targa, marca, modello) {
            CatenaMoto = catenamoto;
        }

        public override void ShowProps() {
            base.ShowProps();
            Console.WriteLine($"Catena Moto: {CatenaMoto}");
        }
    }
}
