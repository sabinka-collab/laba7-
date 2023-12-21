string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
char r1 = 'c';
int i = 0;
foreach (char s in s1)
{
    i++;
    if (s == r1)
    {
        s1 = s1.Insert(i, s2);
    }
}
Console.WriteLine(s1);
