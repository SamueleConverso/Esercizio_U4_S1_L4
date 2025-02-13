using Esercizio_U4_S1_L4.Interface;

namespace Esercizio_U4_S1_L4.Models {
    public abstract partial class Veicolo : IVeicolo {
        protected string Targa {
            get; set;
        }

        protected string Marca {
            get; set;
        }

        protected string Modello {
            get; set;
        }

        public Veicolo(string targa, string marca, string modello) {
            Targa = targa;
            Marca = marca;
            Modello = modello;
        }

        public virtual void ShowProps() {
            Console.WriteLine($"Targa: {Targa}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modello: {Modello}");
        }
    }
}
