// See https://aka.ms/new-console-template for more information

List<int> a = new List<int> { 1, 4, 3 ,2, 5 };

for (int i = 0; i < a.Count / 2; i++)
{
    int firstIndex = i;
    int secondIndex = a.Count - 1 - i;
    swap(a, firstIndex, secondIndex);

}

Console.WriteLine(String.Join(' ', a));

void swap(List<int> arr, int j, int v)
{
    int firstNum = arr[j];
    int secondNum = arr[v];
    arr[j] = secondNum;
    arr[v] = firstNum;
}
