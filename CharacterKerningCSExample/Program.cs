using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CharacterKerningCSExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please enter the letters you want to Display");
                var inputString = Console.ReadLine();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var displayPalette = new List<string>
                {
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                };

                if (inputString.Length > 3)
                {
                    Console.WriteLine("Enter a only a 3 letters between 0-9 and A-Z");
                }

                else
                {
                    bool Is5Character = false;
                    foreach (var letter in inputString)
                    {
                        if (CharacterMap.PaletteList4Column[letter - 48] == null)
                        {
                            Is5Character = true;
                        }

                        List<string> currentPalette;

                        if (inputString.Length <= 2)
                        {
                            currentPalette = CharacterMap.PaletteList5Column[letter - 48];
                            Is5Character = true;
                        }

                        else
                        {
                            currentPalette = CharacterMap.PaletteList4Column[letter - 48] ??
                                                        CharacterMap.PaletteList5Column[letter - 48];
                        }

                        var index = 0;
                        foreach (var line in currentPalette)
                        {
                            var truncatedString = line.Remove(0, Is5Character ? 3 : 4);

                            displayPalette[index] = $"{displayPalette[index]}1{truncatedString}";

                            index++;
                        }
                    }

                    foreach (var line in displayPalette)
                    {
                        var tempOutput = line;

                        while (tempOutput.Length < 16)
                        {
                            tempOutput = tempOutput + "1";
                            if (tempOutput.Length < 16)
                            {
                                tempOutput = tempOutput.Insert(0, "1");
                            }
                        }

                        if (tempOutput.Length > 16)
                        {
                            tempOutput = tempOutput.Remove(16);
                        }

                        foreach (var character in tempOutput)
                        {
                            if (character == '1')
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write('0');
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write('X');
                            }
                        }
                        Console.ResetColor();
                        int cursorTop = Console.CursorTop;
                        Console.SetCursorPosition(0, cursorTop + 1);
                    }
                }
                stopwatch.Stop();
                var executionTime = stopwatch.Elapsed;
                Console.WriteLine
                    ($"Seconds: {executionTime.Seconds} MilliSeconds: {executionTime.Milliseconds}");
            }
        }
    }
}
