// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

using System.Net.Security;

Console.WriteLine("Enter your name:");
//string-sõne
string userName;
userName = Console. ReadLine();
Console.WriteLine("Hello" + userName);
//string inerpolation

Console.WriteLine($"Hello, {userName}!");
