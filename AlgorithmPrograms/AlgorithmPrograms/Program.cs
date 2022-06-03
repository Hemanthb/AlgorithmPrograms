AlgorithmPrograms.StringPermutation permutation = new AlgorithmPrograms.StringPermutation();
String word = "ABC";
int len = word.Length;
Console.WriteLine("Permutation of given string {0} are -\n",word);
AlgorithmPrograms.StringPermutation.Permute(word, 0, len - 1);
Console.WriteLine();