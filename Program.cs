/*  PUNTO 1

        double numerador1, denominador1, numerador2, denominador2;
        string operador;

        Console.WriteLine("Ingrese el primer numerador:");
        if (!double.TryParse(Console.ReadLine(), out numerador1)){
            Console.WriteLine("Numerador 1 no válido.");
            return;
        }

        Console.WriteLine("Ingrese el primer denominador:");
        if (!double.TryParse(Console.ReadLine(), out denominador1) || denominador1 == 0){
            Console.WriteLine("Denominador 1 no válido.");
            return;
        }

        Console.WriteLine("Ingrese el operador (+, -, *, /):");
        operador = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo numerador:");
        if (!double.TryParse(Console.ReadLine(), out numerador2)) {
            Console.WriteLine("Numerador 2 no válido.");
            return;
        }

        Console.WriteLine("Ingrese el segundo denominador:");
        if (!double.TryParse(Console.ReadLine(), out denominador2) || denominador2 == 0) {
            Console.WriteLine("Denominador 2 no válido.");
            return;
        }

        double resultadoNum = 0;

      
        switch (operador)
        {
            case "+":
                resultadoNum = (numerador1 / denominador1) + (numerador2 / denominador2);
                break;
            case "-":
                resultadoNum = (numerador1 / denominador1) - (numerador2 / denominador2);
                break;
            case "*":
                resultadoNum = (numerador1 / denominador1) * (numerador2 / denominador2);
                break;
            case "/":
                if (numerador2 != 0) {
                    resultadoNum = (numerador1 / denominador1) / (numerador2 / denominador2);
                }
                else
                {
                    Console.WriteLine("No puedes dividir por cero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operador no válido.");
                return;
        }

        Console.WriteLine($"Resultado: {resultadoNum}");
    


      */

/*PUNTO 2

        int num1, num2, J;
        Console.WriteLine("Ingrese primer número del rango:");
        num1 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segundo número del rango:");
        num2 = Int16.Parse(Console.ReadLine());

        Random random = new Random();

        for (int i = num1; i <= num2; i++){
            int resultadoOculto = random.Next(1, 11); 
            for (J = 1; J <= 10; J++){
                if (J == resultadoOculto)
                {
                    Console.WriteLine($"{i} x ? = {i * J}");
                }
                else
                {
                    Console.WriteLine($"{i} x {J} = {i * J}");
                }
            }

            Console.WriteLine("Adivina el numero faltante:");
            int respuestaUsuario;
            if (int.TryParse(Console.ReadLine(), out respuestaUsuario) && respuestaUsuario == resultadoOculto){
                Console.WriteLine("Adivinaste mi perro!!");
            }
            else
            {
                Console.WriteLine($"No parce, ese no era. El número que faltaba era: {resultadoOculto}.");
            }
        }
    

*/
/*
int num1;

Console.WriteLine("Ingrese un número:");
num1 = Int32.Parse(Console.ReadLine());

if ((num1 % 5 == 0 || num1 % 5 == 5) && (num1 % 2 != 0 && num1 % 3 != 0))
{
    int sumaDigitos = 0;
    int numero = num1;

    while (numero != 0) {
        sumaDigitos += numero % 10;
        numero /= 10;
    }

    if (sumaDigitos > 10){
        Console.WriteLine($"El número {num1} es especial.");
    }
    else
    {
        Console.WriteLine($"El número {num1} no es especial.");
    }
}
else
{
    Console.WriteLine($"El número {num1} no es especial.");
}
*/

/*PUNTO4*/

Console.WriteLine("Completa la siguiente frase en menos de 10 intentos: ");
Console.WriteLine("El ______ juega _____ el _______");

int numIntentos = 0;
bool p1 = false;
bool p2 = false;
bool p3 = false;

while (numIntentos < 10 && !(p1 && p2 && p3)) {

    Console.WriteLine($"Intento {numIntentos + 1}");
    Console.WriteLine("Ingresa una palabra: ");
    string palabra = Console.ReadLine().ToLower();

    if (palabra == "gato" && !p1) { 
        Console.WriteLine("¡Adivinaste una palabra!");
        Console.WriteLine("El gato juega _____ el _______");
        p1 = true;
    } 
    else if (palabra == "en" && !p2)  { 
        Console.WriteLine("¡Adivinaste una palabra!");
        Console.WriteLine("El gato juega en el _______");
        p2 = true;
    }
    else if (palabra == "jardin" && !p3)  { 
        Console.WriteLine("¡Adivinaste una palabra!");
        Console.WriteLine("El gato juega en el jardin");
        p3 = true;
    }
    else
    {
        Console.WriteLine("Incorrecto");
    }

    numIntentos++;
}

if (p1 && p2 && p3){
    Console.WriteLine("my bro, ganaste!!!");
}
else
{
    Console.WriteLine("Papi llorela, perdiste hasta la conciencia");
}
