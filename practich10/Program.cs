const int n = 3, 
          m = 3;

int[]  mas  = new int[m];
int[,] matr = new int[n, m];

Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matr[i, j] = rnd.Next(2);
        Console.Write("{0,5}", matr[i, j]);
    }
    Console.WriteLine();
}

int max = mas[0],
    pos = 0;

for (int j = 0; j < m; j++)
{
    int Kol = 0;

    for (int i = 0; i < n; i++)
    {
        if (matr[i, j] == 0)
        {
            Kol++;
        }
    }

    mas[j] = Kol;
}

for (int j = 0; j < m; j++)
{
    if (max < mas[j])
    {
        max = mas[j];
        pos = j;
    }
}

Console.WriteLine();
Console.WriteLine("Столбец с мах значением нулей = " + (pos + 1));
