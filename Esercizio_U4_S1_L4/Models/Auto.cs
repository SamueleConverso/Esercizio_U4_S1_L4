using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_U4_S1_L4.Models {
    public class Auto : Veicolo {

        public int AssicurazioneAuto {
            get; set;
        }

        public Auto(string targa, string marca, string modello, int assicurazioneAuto) : base(targa, marca, modello) {
            AssicurazioneAuto = assicurazioneAuto;
        }

        public override void ShowProps() {
            base.ShowProps();
            Console.WriteLine($"Assicurazione Auto: {AssicurazioneAuto}");
        }
    }
}
