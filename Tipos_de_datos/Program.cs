// 1.	Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor. 
// Algunos enteros 
using System.Reflection.PortableExecutable;

byte numByte = 25;
short numShort = -19;
int numInt = 378999999;
long numLong = 90382475982348;

// Algunos decimales
float numFloat = 0.4379879f;
double numDouble = 0.4359089328933245;
decimal numDecimal = 432.32195328383282319324193421m;

// Lógicos
bool boolTrue = true;
bool boolFalse = false;

// Caracteres
char character = 'a';

// Cadenas
string message = "Hello, mi nombre es Iván";

// Imprimir los valores: enteros
Console.WriteLine("Imprimir los valores: enteros");
Console.WriteLine($"Tipo byte: {numByte}");
Console.WriteLine($"Tipo short: {numShort}");
Console.WriteLine($"Tipo int: {numInt}");
Console.WriteLine($"Tipo long: {numLong}");

// Imprimir los valores: decimales
Console.WriteLine("\nImprimir los valores: decimales");
Console.WriteLine($"Tipo float: {numFloat}");
Console.WriteLine($"Tipo double: {numDouble}");
Console.WriteLine($"Tipo decimal: {numDecimal}");

// Imprimir los valores: lógicos
Console.WriteLine("\nImprimir los valores: lógicos");
Console.WriteLine($"Tipo bool: {boolTrue}");
Console.WriteLine($"Tipo bool: {boolFalse}");

// Imprimir los valores: caracteres
Console.WriteLine("\nImprimir los valores: caracteres");
Console.WriteLine($"Tipo char: {character}");

// Imprimir los valores: cadenas
Console.WriteLine("\nImprimir los valores: cadenas");
Console.WriteLine($"Tipo string: {message}");


// Declrando una constante
const int LIGHT_SPEED = 300000; // Velocidad de la luz en km/s
Console.WriteLine($"La velocidad de la luz es: {LIGHT_SPEED} Km/s"); // Imprimir el valor de la constante

// Intentar cambiar el valor de la constante (esto causará un error de compilación)
//LIGHT_SPEED = 299792; // Error: no se puede asignar un valor a una constante


// Operaciones, incremento y decremento

int number = 10; // Declarando un entero
number++; // Incrementa el valor
number--; // Decrementa el valor

int sum = number + 5; // Operación de suma
int subtraction = number - 3; // Operación de resta
int multiplication = number * 2; // Operación de multiplicación
int division = number / 2; // Operación de división


// Ooperaciones con float
float floatValue = 10152466.25f;
byte byteValue = (byte)(5 + floatValue);


// Esto es una línea comentada

/*
 Estas son varias líneas comentadas 
 Debajo de estas líneas, voy a imprimir la fecha y hora del sistema
 Y esta es mi última línea comentada
 */

Console.WriteLine($"\nFecha y hora del sistema: {DateTime.Now}");