// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Start Program");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("Using Old class ");
Console.WriteLine("--------------------------------------");
var oldClass =new oldClassToCalculation(-50, 10);
oldClass.Mul();
oldClass.Div();
oldClass.Add();
oldClass.Sub();
Console.WriteLine("Using New class And Adapter ");
Console.WriteLine("--------------------------------------");
var newclass = new newClassThatTakeSign(50, 10, true, false);
var adapter = new AdapterClass(newclass);
adapter.Mul();
adapter.Div();
adapter.Add();
adapter.Sub();
