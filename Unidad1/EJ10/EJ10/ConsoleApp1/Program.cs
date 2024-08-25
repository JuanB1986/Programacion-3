
int [] array1 = new int [50];
int [] array2 = new int [50];


int p1 = 0;
int p2 = 0;

for (int i=1; i<101; ++i)
{
    
    if ((i % 2) == 0)
    {
        array1[p1++] = i;
    }

    if ((i % 3) == 0)
    {
        array2[p2++]=i;
    } 
}


for (int i=0; i < array1.Length; ++i)
{
    Console.WriteLine(array1[i]);
}
for (int i = 0; i < array2.Length; ++i)
{
    Console.WriteLine(array2[i]);
}