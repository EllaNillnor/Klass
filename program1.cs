
using System.Runtime.CompilerServices;

class Fordon
    {
        private string tillverkare;
        private string model; 
        private int årsmodel;
        private int vikt;
        
        public string Tillverkare{
            get {return tillverkare;}
            set {tillverkare = value; }
        }
        public string Model{
            get {return model;}
            set {model = value;}
        }
        public int Årsmodel{
            get {return årsmodel;}
            set {årsmodel = value;}
        }
        public int Vikt{
            get {return vikt;}
            set {vikt = value;}
        }
        
    }