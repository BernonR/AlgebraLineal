using System;
					
public class Program
{
    
    
	public static void Main()
	{
        int opc=0;
        int i=0;
        int k=0;
        int j=0;
        double pivote=0;
        double d=0;

                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine("|     Proyecto Final Algebra Lineal      |");
                Console.WriteLine("|         BERNON ROMERO LEONARDO         |");
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine(" ");
                Console.ReadKey (); 
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine("|                                        |"); 
				Console.WriteLine("|   Definir el tamano de la Matriz M*N   |");
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine(" "); 
                Console.WriteLine("Introduce la cantidad  de filas de la Matriz N*M");
        int filas = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Introduce la cantidad  de columas de la Matriz N*M");
         int columnas = Convert.ToInt32(Console.ReadLine());
                    
                    double[,] MatrizA = new double [filas,columnas];
 


     
        //Menu por medio de una estructura repetitiva do while
        
		do {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine("|     Proyecto Final Algebra Lineal      |");
                Console.WriteLine("|         BERNON ROMERO LEONARDO         |");
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine(" ");
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine("|                                        |"); 
                Console.WriteLine("| 1. Ingresar valores de de la Matriz    |"); 
                Console.WriteLine("| 2. Ver la matriz aumentada             |");
                Console.WriteLine("| 3. Resolver por Gauss Jordan           |");         
				Console.WriteLine("| 4. Mostrar resultados                  |"); 
				Console.WriteLine("| 5. Salir                               |");
                Console.WriteLine("|                                        |"); 
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine(" ");
				Console.WriteLine("Ingresar Opción que desea realizar");
				opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc) 
				{
                    

                    case 1:
                    Console.Clear();
                     FillMatrix(MatrizA); 
                     
                   
                        break; 
                    case 2:
                    Console.Clear();
                        PrintMatrix(MatrizA); 
                       
                   
                   
                        break;   
                    case 3:
                        Console.Clear();
                        GaussSolver(MatrizA,filas,k,j, i,pivote,d);
                        
                        
                   
                        break;  

                    case 4:
                        Console.Clear();
                        Console.WriteLine("|-------------------------------------------|"); 
                        Console.WriteLine("| LA MATRIZ HA SIDO RESUELTA POR EL METODO  |");
                        Console.WriteLine("|              DE GAUSS JORDAN              |");
                        Console.WriteLine("|          BERNON ROMERO LEONARDO           |");
                        Console.WriteLine("|-------------------------------------------|"); 
                        for (i=0; i<filas; i++)
                        Console.WriteLine("Resultados de x[{0}]={1}", i, MatrizA[i,filas]);
                        break;

                    case 5:
                    Console.Clear();
                        Console.WriteLine("|-------------------------------------------|"); 
                        Console.WriteLine("|        ESTE HA SIDO EL PROYECTO           |");
                        Console.WriteLine("|                   DE                      |");
                        Console.WriteLine("|          BERNON ROMERO LEONARDO           |");
                        Console.WriteLine("|                                           |");
                        Console.WriteLine("|     *****GRACIAS POR SU ATENCION*****     |");
                        Console.WriteLine("|-------------------------------------------|");
                       
                        break;
                    default:
                    
                        Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                        break;
			    }
				Console.ReadKey();	
		} while (opc !=5);
    }

       public static void FillMatrix(double[,] MatrizA)
    {

       
        // forma # 1 , tengo variables donde almacené cuantas filas y cuantas columnas quiero
        for (int i = 0; i < MatrizA.GetLength(0); i++) //filas
        {
            for (int j = 0; j < MatrizA.GetLength(1); j++) // columnas
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine("Introduce un numero para la FILA "+i+" COLUMNA " +j);
                MatrizA[i,j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        Console.Clear(); 
        Console.WriteLine("|-------------------------------------------|"); 
        Console.WriteLine("| La Matriz ha sido rellenada correctamente |");
        Console.WriteLine("|-------------------------------------------|"); 
        
    }

        public static void GaussSolver(double [,] MatrizA, int filas, int k, int j, int i, double pivote, double d )
        {
              for ( k=0; k < filas; k++)
              {
                pivote = MatrizA[k,k];
                
                for (j=k; j< filas+1; j++)
                MatrizA[k,j] = MatrizA[k, j] / pivote;

                for(i=0; i<filas; i++){
                    if(i!=k){
                        d=MatrizA[i,k];

                        for (j=k; j<filas+1; j++)
                        MatrizA[i,j] = MatrizA[i, j] - d * MatrizA[k,j];

                    }
                    
                    ShowSteps(MatrizA,filas);


                }
                for (i=0; i<filas; i++)
                Console.WriteLine("Resultados de x[{0}]={1}", i, MatrizA[i,filas]);


              }



        }

     public static void PrintMatrix(double[,] MatrizA)
    {
        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("|-------------------------------------------|"); 
        Console.WriteLine("|             MATRIX AUMENTADA              |");
        Console.WriteLine("|-------------------------------------------|"); 
        Console.WriteLine("");
        for (int i = 0; i < MatrizA.GetLength(0); i++) // filas 
        {
            for (int j = 0; j < MatrizA.GetLength(1); j++) // columnas
            {
                Console.Write(MatrizA[i,j] + "\t");
            }
            Console.WriteLine("");
        }
       
    }

    public static void ShowSteps(double [,] MatrizA, int filas)
    {

        int i=0;
        int j=0;

       


        for (i=0; i<filas; i++)
        {

            for (j=0; j<filas; j++)
            {
                Console.Write("{0}\t", MatrizA[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("|-------------------------------------------|"); 

    }

}


    
