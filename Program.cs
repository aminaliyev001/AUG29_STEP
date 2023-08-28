//1
using PointerSpace;
using CounterSpace;
using Calc;
using System.Runtime.InteropServices;

Pointer point = new Pointer(2,3);
Console.WriteLine(point);

//2
Counter counter = new Counter(5,10);
Console.WriteLine(counter.Count);
counter.increament();
counter.increament();
counter.increament();
counter.increament();
counter.increament();

Console.WriteLine(counter.Count);
//3
Calculator calc = new Calculator();
Console.WriteLine(calc.multiple(12,3,true));
Console.WriteLine(calc.add(7,3,true));