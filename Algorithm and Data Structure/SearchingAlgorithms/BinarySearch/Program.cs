using BinarySearch;

int[] numList = new int[] { 1, 3, 5, 7 };
int keyElement = 5;
BinarySearcher searcher = new BinarySearcher();

Console.WriteLine($"Position of element {keyElement} is {searcher.GetKeyElement(numList, keyElement)}");

