int i = 10;
int g = 10;
int max = 0;
int min = 1;

if (i > g)
{
max = i;
min = g;
} else
{
max = g;
min = i;
}
Console.WriteLine("min: " + min + "max: " + max);
