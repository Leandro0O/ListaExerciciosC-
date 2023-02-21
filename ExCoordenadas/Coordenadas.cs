class Coordenadas{  
    public void Coord(Double x, Double y){
        if(x != 0 && y != 0){
            
            if(x > 0 && y > 0 ){
                Console.WriteLine($"Valor de x:{x}\nValor de Y {y}\nQ1");
            } else if( x < 0 && y > 0){
             Console.WriteLine($"Valor de x:{x}\nValor de Y {y}\nQ2");
            } else if(x< 0 && y< 0){
               Console.WriteLine($"Valor de x:{x}\nValor de Y {y}\nQ3");
            }else{
                Console.WriteLine($"Valor de x:{x}\nValor de Y {y}\nQ4");
            }   
        }
     
        
    }


    // public static void Main(string[] args)
    // {   Console.Clear();
    //     Coordenadas cord = new Coordenadas();
    //     Console.WriteLine("Informe o valor de x:");
    //     Double x  = Convert.ToDouble(Console.ReadLine());
    //     Console.WriteLine("Informe o valor de y:");
    //     Double y = Convert.ToDouble(Console.ReadLine());
    //     cord.Coord(x,y);
    // }
}

