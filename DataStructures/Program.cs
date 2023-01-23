using DataStructures;

BubbleSort.Sort();

Console.WriteLine("-----------------------------");

var myStack = new Stack();

myStack.Push(10);
myStack.Push(20);
myStack.Push(30);
myStack.Push(40);
myStack.PrintStack();
myStack.Peek();
Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
myStack.PrintStack();