AlgorithmPrograms.StringPermutation permutation = new AlgorithmPrograms.StringPermutation();
AlgorithmPrograms.Sorting sorts = new AlgorithmPrograms.Sorting();
AlgorithmPrograms.UnorderedWordsList wordsList = new AlgorithmPrograms.UnorderedWordsList();
Console.WriteLine("Enter\n1 - Permutation\n2 - Binary Search\n3 - For Sort\n4 - Anagram\n" +
    "5 - UnorderedWordsSearchList\n6 - Ordered List\n7 - Balanced Parenthesis stack\nAnd your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
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
    case 3:
        Console.WriteLine("Enter the num of words you want to add:");
        int number = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[number];
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter a word:");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter\n 1 - Insertion Sort\n 2 - Bubble Sort");
        int sortChoice = Convert.ToInt32(Console.ReadLine());
        if(sortChoice== 1)
            sorts.InsertionSort(array);
        if (sortChoice == 2)
            sorts.BubbleSort(array);
        break;
    case 4:
        Console.WriteLine("Enter the first word:");
        string word1 = Console.ReadLine();
        Console.WriteLine("Enter the second word:");
        string word2 = Console.ReadLine();
        permutation.Anagram(word1,word2);
        break;
    case 5:
        string file = @"D:\blabz_fellowship\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\wordlist.txt";
        string fileContent = "";
        if (File.Exists(file))
        {
            fileContent = File.ReadAllText(file);
        }
        string[] wordsArray = fileContent.ToLower().Split(' ');
        foreach(string wrd in wordsArray)
        {
            wordsList.addNode(wrd);
        }
        wordsList.Displaylist();
        Console.WriteLine("ENter a word to check whther it exists in the file");
        string find = Console.ReadLine();
        if(wordsList.Search(find) < 0)
            wordsList.addNode(find);
        else
            wordsList.Remove(find);
        wordsList.Displaylist();
        break;
    case 6:
        AlgorithmPrograms.OrderedLinkedList ordered = new AlgorithmPrograms.OrderedLinkedList();
        string file1 = @"D:\blabz_fellowship\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\NumberList.txt";
        string fileContent1 = "";
        if (File.Exists(file1))
        {
            fileContent1 = File.ReadAllText(file1);
        }
        string[] numArray = fileContent1.Split(' ');
        foreach (string wrd in numArray)
        {
            int pos = ordered.InsertNewNode(Convert.ToInt32(wrd));
            Console.WriteLine("Data entered at position - " + pos);
        }
        ordered.Displaylist();
        ordered.sortElement();
        Console.WriteLine("*********After Sorting********");
        ordered.Displaylist();
        break;
    case 7:
        AlgorithmPrograms.StackBalancedParenthesis stack = new AlgorithmPrograms.StackBalancedParenthesis();
        Console.WriteLine("Enter Arithmetic Expression:");
        string exp = Console.ReadLine();
        stack.BalancedParanthesis(exp);
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;

}