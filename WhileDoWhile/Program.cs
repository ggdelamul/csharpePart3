Random random = new Random();
int current =0;
int current2 =random.Next(1,11);
do {
    current = random.Next(1,11);
    if(current>=8) continue;
    Console.WriteLine(current);

}while (current !=7);

while (current2 >=3)
{
    Console.WriteLine(current2);
    current2 = random.Next(1,11);
}
Console.WriteLine($"Last numbers {current2}");