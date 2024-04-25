// Implicit Casting

int firstInt = 9;
double firstDouble = firstInt;       // Automatic casting: int to double

Console.WriteLine(firstInt);
Console.WriteLine(firstDouble);
Console.WriteLine("/////////////////////////////////////////");
// Explicit Casting

double secondDouble = 9.78;
int secondInt = (int)secondDouble;    // Manual casting: double to int

Console.WriteLine(secondDouble);
Console.WriteLine(secondInt);
Console.WriteLine("/////////////////////////////////////////");

// Type Conversion Methods

int thirdInt = 10;
double thirdDouble = 5.25;
bool thirdBool = true;

Console.WriteLine(Convert.ToString(thirdInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(thirdInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(thirdDouble));  // convert double to int
Console.WriteLine(Convert.ToString(thirdBool));   // convert bool to string