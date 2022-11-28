class Decisao{

public void ex1(){
    int num;
    Console.WriteLine("Informe um número:");
    num = Convert.ToInt32(Console.ReadLine());

    if(num < 0){
        Console.WriteLine($"O número {num} é negativo");
    }else{
        Console.WriteLine($"O número {num} é positivo");
    }
}

public void ex2(){
    double l,r;
    Console.WriteLine("Informe o lado do quadrado:");
    l = Math.Pow(Convert.ToDouble(Console.ReadLine()),2);
    Console.WriteLine("Informe o raio do circulo:");
    r = Math.PI * Math.Pow(Convert.ToDouble(Console.ReadLine()),2);
    if(l > r){
        Console.WriteLine("O quadrado tem a maior área:");
    }else{
        Console.WriteLine("O circulo tem a maior área");
    }

}

public void ex3(){
    int num1,num2,num3;
    Console.WriteLine("Informe o primeiro numero:");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o segundo numero:");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o terceiro numero:");
    num3 = Convert.ToInt32(Console.ReadLine());

    if(num1 > num2 && num1 > num3){
        Console.WriteLine($"O numero {num1} é o maior dos tres números");
    }else if(num2 > num3){
        Console.WriteLine($"O numero {num2} é o maior dos tres números");
    }else{
        Console.WriteLine($"O numero {num3} é o maior dos tres números");
    }
}

public void ex4(){
    
}

}