

Console.WriteLine("Hello, and welcome to the Pig Latin Translator.");

bool run = true;
do
{
    Console.WriteLine();
    Console.WriteLine("Please enter a word to be translated");

    string theWord = Console.ReadLine().ToLower();



    int findVowel = -1;
    foreach (char vowel in theWord)
    {
        findVowel = findVowel + 1;

        if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
        { break; }
    }


    string consonant = "";
    string translation = "";
    string remainingWord = "";

    if (findVowel == 0)
    {
        Console.WriteLine(theWord + "way");


    }

    else if (findVowel >= 1)
    {
        consonant = theWord.Substring(0, findVowel);
        remainingWord = theWord.Substring(findVowel);
        translation = remainingWord + consonant + "ay";
        Console.WriteLine(translation);
    }
    else
    {
        Console.WriteLine("Please enter a valid word");
    }

    Console.WriteLine("Translate another line? (y/n):");
    string response = Console.ReadLine().ToLower();

    if (response == "y")
    {
        run = true;
    }
    else if (response == "n")
    {
        run = false;
        Console.WriteLine("Thank you, Goodbye");
    }
    else
    {
        Console.WriteLine("Please respond with 'y' or 'n'");
    }

} while (run == true);
