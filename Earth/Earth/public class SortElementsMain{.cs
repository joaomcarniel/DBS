using System;

public class SortElementsMain
{
    static void Main()
    {
        Service MyService = new Service();
        int[] numList = { 5, 6, 5, 4, 9, 8, 4 };
        numList = MyService.SortElements(numList);

        foreach (var num in numList)
        {
            Console.WriteLine(num);
        }
    }
}

public class Service
{
    public int[] SortElements(int[] numList)
    {
        int aux;

        for (int j = 0; j < numList.Length; j++)
        {
            for (int i = 0; i < numList.Length - 1; i++) 
            {
                if (numList[i] > numList[i + 1])
                {
                    aux = numList[i];
                    numList[i] = numList[i + 1];
                    numList[i + 1] = aux;
                }
            }
        }

        return numList;
    }
}
