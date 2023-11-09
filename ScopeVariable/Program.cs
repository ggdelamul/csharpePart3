bool flag = true;
if(flag) Console.WriteLine(flag);

//Console.WriteLine($"Outside of code block: {value}");

int value1=5;
if(value1>0)
{
    
    int value2=6;
    value1 += value2;
}
Console.WriteLine(value1);