class Ordencao{

        public void ordem(){
            int[] v = {99, 82, 50 , 67, 90, 20 , 71, 8 , 31, 18};
            int m, t;

            for(int i = 0; i < v.Length - 1; i++){
                m = i;
                for( int p = i + 1 ; p < v.Length; p++){
                    if( v[p] < v[m]){
                        m = p;
                    }
                    if(v[i] != v[m]){
                        t = v[i];
                        v[i] = v[m];
                        v[m] = t;
                }
                }
            }
            foreach(int num in v){
                Console.WriteLine(num);
            }
        }

}