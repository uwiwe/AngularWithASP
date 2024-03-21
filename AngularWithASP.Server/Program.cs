var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         bool encendido = false;
        
//         Console.WriteLine("Escriba 0 para apagar o 1 para encender la luz:");
//         string entrada = Console.ReadLine();

//         if (entrada == "0")
//         {
//             encendido = false; // Apagar la luz
//         }
//         else if (entrada == "1")
//         {
//             encendido = true; // Encender la luz
//         }
//         else
//         {
//             Console.WriteLine("Su respuesta no es válida. Por favor, escriba 0 o 1.");
//             return;
//         }

//         Console.WriteLine($"La luz está {(encendido ? "encendida" : "apagada")}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         bool continuar = true;
        
//         while (continuar)
//         {
//             Console.WriteLine("¿Desea continuar? Escriba 'no' para detener el bucle");
//             string respuesta = Console.ReadLine();

//             if (respuesta.ToLower() == "no")
//             {
//                 continuar = false;
//             }
//         }

//         Console.WriteLine("Bucle detenido por decisión del usuario");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         double numero;

//         Console.WriteLine("Ingrese un número positivo:");
//         string entrada = Console.ReadLine();

//         if (double.TryParse(entrada, out numero))
//         {
//             if (numero > 0)
//             {
//                 Console.WriteLine($"El número {numero} es válido.");
//             }
//             else
//             {
//                 Console.WriteLine("El número ingresado no es positivo.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("Seleccione una operación:");
//             Console.WriteLine("1. Suma");
//             Console.WriteLine("2. Resta");
//             Console.WriteLine("3. Multiplicación");
//             Console.WriteLine("4. División");
//             Console.WriteLine("5. Salir");

//             Console.Write("Ingrese el número de la operación deseada: ");
//             string opcion = Console.ReadLine();

//             switch (opcion)
//             {
//                 case "1":
//                     RealizarSuma();
//                     break;
//                 case "2":
//                     RealizarResta();
//                     break;
//                 case "3":
//                     RealizarMultiplicacion();
//                     break;
//                 case "4":
//                     RealizarDivision();
//                     break;
//                 case "5":
//                     Console.WriteLine("Has salido del programa.");
//                     return;
//                 default:
//                     Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
//                     break;
//             }
//         }
//     }

//     static void RealizarSuma()
//     {
//         Console.WriteLine("Ingrese el primer número:");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Ingrese el segundo número:");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         double resultado = num1 + num2;
//         Console.WriteLine($"La suma de {num1} y {num2} es: {resultado}");
//     }

//     static void RealizarResta()
//     {
//         Console.WriteLine("Ingrese el primer número:");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Ingrese el segundo número:");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         double resultado = num1 - num2;
//         Console.WriteLine($"La resta de {num1} y {num2} es: {resultado}");
//     }

//     static void RealizarMultiplicacion()
//     {
//         Console.WriteLine("Ingrese el primer número:");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Ingrese el segundo número:");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         double resultado = num1 * num2;
//         Console.WriteLine($"La multiplicación de {num1} y {num2} es: {resultado}");
//     }

//     static void RealizarDivision()
//     {
//         Console.WriteLine("Ingrese el dividendo:");
//         double dividendo = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Ingrese el divisor:");
//         double divisor = Convert.ToDouble(Console.ReadLine());

//         if (divisor != 0)
//         {
//             double resultado = dividendo / divisor;
//             Console.WriteLine($"La división de {dividendo} entre {divisor} es: {resultado}");
//         }
//         else
//         {
//             Console.WriteLine("Error, No se puede dividir por cero.");
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Ingrese el número de términos de la serie:");
//         int n;
        
//         if (int.TryParse(Console.ReadLine(), out n) && n > 0)
//         {
//             int suma = 0;
//             for (int i = 1; i <= n; i++)
//             {
//                 suma += i;
//             }
            
//             Console.WriteLine($"La suma de los primeros {n} números naturales es: {suma}");
//         }
//         else
//         {
//             Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
//         }
//     }
// }