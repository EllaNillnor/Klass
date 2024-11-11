

    class program
    {
        public static void Main(){
            Fordon f = new Fordon ();
            f.Tillverkare ="Volvo";
            f.Model ="V90";
            f.Årsmodel =2021;
            f.Vikt= 2000;

        Console.WriteLine("Tillverkare: "+ f.Tillverkare);
        Console.WriteLine("Model: "+ f.Model);
        Console.WriteLine("Årsmodel: "+ f.Årsmodel);
        Console.WriteLine("Vikt: "+ f.Vikt);
        }
    }
