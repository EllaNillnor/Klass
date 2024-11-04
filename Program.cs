
class Fordon
    {
        private string Tillverkare;
        private string Model; 
        private int Årsmodel;
        private int Vikt;
        
        public void setTillverkare(string T) { Tillverkare = T;}
        public string getTillverkare() {return Tillverkare;}
        public void setModel(string M) {Model = M;}
        public string getModel() {return Model;}
        public void setÅrsmodel(int Å) {Årsmodel = Å;}
        public int getÅrsmodel() {return Årsmodel;}
        public void setVikt(int V) {Vikt = V;}
        public int getVikt() {return Vikt;}
    }
    class Program
    {
        public static void Main(){
        Fordon f = new();

        f.setTillverkare("Volvo");
        f.setModel("V90");
        f.setÅrsmodel(2021);
        f.setVikt(2000);

        Console.WriteLine("Tillverkare: "+ f.getTillverkare());
        Console.WriteLine("Model: "+ f.getModel());
        Console.WriteLine("Årsmodel: "+ f.getÅrsmodel());
        Console.WriteLine("Vikt: "+ f.getVikt());
        }
    }
