using System;
public class Program
{
    static void Main(string[] args)
    {
        bool again = true;
        while (again)
        {
            string DNAsequence = Console.ReadLine();
            if (IsValidSequence(DNAsequence))
            {
                Console.WriteLine("Current half DNA sequence : {0}", DNAsequence);
                Console.WriteLine("Do you want to replicate it ? (Y/N) :");
                bool loop = true;
                while (loop)
                {
                    string ans = Console.ReadLine();
                    if (ans == "Y")
                    {
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(DNAsequence));
                        loop = false;
                    }
                    else if (ans == "N")
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid");      
            }
            Console.WriteLine("Do you want to process another sequence ? (Y/N) :");
                bool question = true;
                while (question)
                {
                    string ans = Console.ReadLine();
                    if (ans == "Y")
                    {
                        question = false;
                    }
                    else if (ans == "N")
                    {
                        question = false;
                        again = false;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }

                }
        }
    }
    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }
}