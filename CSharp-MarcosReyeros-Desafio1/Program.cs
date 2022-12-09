// See https://aka.ms/new-console-template for more information


//ACTIVIDAD 1
//Crear un proyecto de consola y nombrarlo como [Desafio1NombreApellido] (nombre y apellido del alumno)
//Luego, guardar los siguientes datos en variables y mostrarlos por consola:
//Nombre:
//Apellido:
//DNI:
//Edad:
//Altura:

string nombre = "Marcos";
String apellido = "Reyeros";
int dni = 41041822;
int edad = 24;
double altura = 1.84;

Console.WriteLine("ACTIVIDAD-1");
Console.WriteLine("\nNombre : " + nombre + "\nApellido : " + apellido + "\nDNI : " + dni
    + "\nEdad : " + edad + "\nAltura : " + altura);

//Actividad 2

//Siguiendo en el mismo proyecto… 
//Ingresar dos números por teclado y luego mostrar el resultado de la suma por consola.

Console.WriteLine("\nACTIVIDAD-2" + "\nSuma de dos Números");

Console.WriteLine("\nIngrese el Primer Número: ");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("\nIngrese el Segundo Número: ");

int num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;

Console.WriteLine("\nLa suma de ambos numeros es = " + suma);

//Actividad 3

//Utilizando las variables nombre y apellido de la actividad 1 . 
//Muestre las dos variables en un solo console.readline , poniendo en el medio su alias.

Console.WriteLine("ACTIVIDAD-3");
Console.WriteLine("\nINGRESE SU ALIAS");


Console.WriteLine("\nMi nombre es : " + nombre + " \"" + Console.ReadLine() + "\" " + apellido);