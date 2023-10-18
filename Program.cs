// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите количество элементов исходного массива- ");
int n=Convert.ToInt32(Console.ReadLine());
string[]array=new string[n];
int j=0;

for (int i=0; i<n;i++)
{
	Console.Write($"Введите {i} элемент массива- ");
	array[i]=Console.ReadLine();
	if (array[i].Length<4) j=j+1;
}
Console.WriteLine($"Количество элементов с 3 и менее символами в исходном массиве= {j}");
string[]array1=new string[j];
j=0;
// Формирование нового массива из элементов исходного с 3 и менее символами 
for (int i=0; i<n;i++)
{
	if (array[i].Length<4) 
	{
		array1[j]=array[i];
		j=j+1;
	}
}
// вывод на экран элементов нового массива
Console.WriteLine("новый массив из строк, длина которых меньше, либо равна 3 символам");
for(j=0; j<array1.Length;j++)
{
	Console.WriteLine(array1[j]);
}
