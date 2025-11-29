// See https://aka.ms/new-console-template for more information
int[] numList = new int[] {5,9,4,7,8,2,1 };
int keyElement = 2;

for(int i = 0; i < numList.Length; i++)
{
    if (numList[i] == keyElement)
    {
        Console.WriteLine($"Key element {keyElement} was found on the list in position: {i}");
    }
}

