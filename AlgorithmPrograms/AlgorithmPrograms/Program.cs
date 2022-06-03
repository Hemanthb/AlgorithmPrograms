AlgorithmPrograms.StringPermutation permutation = new AlgorithmPrograms.StringPermutation();
int choice = 2;
switch (choice) 
{
    case 1:
        String word = "ABC";
        int len = word.Length;
        Console.WriteLine("Permutation of given string {0} are -\n",word);
        AlgorithmPrograms.StringPermutation.Permute(word, 0, len - 1);
        Console.WriteLine();
        break;
    case 2:
        string fileName = @"D:\blabz_fellowship\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\wordlist.txt";
        string fileContents = "";
        if (File.Exists(fileName))
        {
            fileContents = File.ReadAllText(fileName);
        }
        Console.WriteLine("ENter a word to check whther it exists in the file");
        string search = Console.ReadLine();
        AlgorithmPrograms.BinarySearch binarySearch = new AlgorithmPrograms.BinarySearch();
        string[] wordArray = fileContents.ToLower().Split(' ');
        Array.Sort(wordArray);
        binarySearch.SearchWord(wordArray, 0, (wordArray.Length-1), search);
        break;   
}