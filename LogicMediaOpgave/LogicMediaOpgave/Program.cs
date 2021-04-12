using System;

namespace LogicMediaOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste af 100"); // Du har en liste af tal fra 1 - 100. 
            for (int i = 1; i < 101; i++) //Jeg vil gerne du løber igennem listen. 
            {
                if (i % 3 == 0 & i % 5 == 0) // For hvert tal der kan deles ligeligt med 3 OG 5 skal du udskrive “[Fornavn][Efternavn]”. 
                {
                    Console.WriteLine("Mathias Munch" + ","); 
                }
                else if (i % 3 == 0) // For hvert tal i listen der kan deles ligeligt med 3 skal du udskrive dit [Fornavn]. 
                {
                    Console.WriteLine("Mathias" + ","); 
                }
                else if (i % 5 == 0) //For hvert tal der kan deles ligeligt med 5 skal du udskrive dit [Efternavn]. 
                {
                    Console.WriteLine("Munch" + ","); 
                }
                else
                {
                    Console.WriteLine(i + ",");
                }

            }
        }
    }
}
