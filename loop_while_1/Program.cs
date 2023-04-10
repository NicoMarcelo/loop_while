class Bucle{
    static void Main(string[] args){

        double promedio = 0.0;
        double nota = 0.0;
        double total = 0.0;
        int cantidad = 0;
        string nombre;

        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        while(true){
            Console.WriteLine("(escriba '-1' para salirse)\n Ingrese una nota: ");
            nota = double.Parse(Console.ReadLine());

            if(nota == -1){
                break;
            }

            else if(nota <= 7.0 && nota >= 1.0){
                total += nota;
                cantidad++;
                Console.WriteLine("Anotado");
            }
            else{
                Console.WriteLine("El valor ingresado no es correcto");
            }
        }

        promedio = total/cantidad;

        if(cantidad == 0){
            Console.WriteLine("No has ingresado ninguna nota");
        }
        else if(promedio < 4.0){
            Console.WriteLine("Lo siento, "+nombre+", repobraste...\nTu promedio es: "+promedio.ToString("0.0"));
        }
        else{
            Console.WriteLine("Felicidades, "+nombre+" aprobaste!\nTu promedio es: "+promedio.ToString("0.0"));
        }
    
    }
}