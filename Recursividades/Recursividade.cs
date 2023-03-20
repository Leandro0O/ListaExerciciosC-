class Recursividade{


    public static void tabuada(int n1, int n2){

        if(n2 > 10){
            return;
        }
        Console.WriteLine($"{n1} x {n2} = {(n1*n2)}");
        tabuada(n1,n2+1);
    }

    public static int soma(int n1, int n2){
        int res = 0;
        if(res < n2){
            res = n1 + soma(n1,n2-1);
        }
        return res;
    }


}