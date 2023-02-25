// See https://aka.ms/new-console-template for more information
string t = Console.ReadLine();
int n = Convert.ToInt32(t);
t = Console.ReadLine();
int m = Convert.ToInt32(t);
for (int i = n; i <= m; i++)
{
    Console.Write(i);
    Console.Write(' ');
}
