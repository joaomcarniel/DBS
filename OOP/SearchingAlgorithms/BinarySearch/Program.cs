using BinarySearch;

int[] numList = new int[] {2,4,5,6,7,8,10,16,18,20,26,30,34,38,41,42,43,44,49,50,51,54,59,60,64,67,68};
int keyElement = 49;
BinarySearcher searcher = new BinarySearcher();

Console.WriteLine($"Position of element {keyElement} is {searcher.GetKeyElement(numList, keyElement)}");

