using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forth_Webinar_Tasks
{
    namespace Task_3
    {
            public static class ListOfStrings
            {
               public static void MakeExample()
               {
                   List<string> lst = GetStrings(150);
                   Console.WriteLine("Before sort : " + lst.Count);
                   SortElements(ref lst);
                   Console.WriteLine("After sort : " + lst.Count);
               }
               public static void DisplayPage(int page)
               {
                   List<string> lst = GetStrings(150);
                   SortElements(ref lst);
                   if (page * 5 > lst.Count)
                   {
                       Console.WriteLine("InvalidPage");
                       return;
                   }
                   int startIndex = page * 5 - 1;
                   int elements = startIndex + 5 > lst.Count ? lst.Count - startIndex : 5;
                   for (int i = startIndex; i < startIndex + elements; ++i)
                       Console.WriteLine(lst[i]);
               }
               static void SortElements(ref List<string> arr)
               {
                   arr.Sort();
                   arr.Reverse();
                   int length = arr.Count;
                   for (int i = length - 1; i > 0; --i)
                   {
                       if (arr[i].StartsWith("Z"))
                       {
                           arr.RemoveAt(i);
                           continue;
                       }
                       if (arr[i].CompareTo(arr[i - 1]) == 0)
                       {
                           arr.RemoveAt(i);
                           continue;
                       }
                   }
                   if (arr[0][0] == 'Z')
                       arr.RemoveAt(0);
               }
               static List<string> GetStrings(int length)
               {
                   List<string> arr = new List<string>(length);
                    Random random = new Random();
                    for (int i = 0; i < length; ++i)
                       arr.Add(GetRndString(random));
                   return arr;
               }
               static string GetRndString(Random random)
               {            
                   string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                   StringBuilder result = new StringBuilder();
                   for (int i = 0; i < 4; i++)
                   {
                       result.Append(characters[random.Next(characters.Length)]);
                   }
                   return result.ToString();
               }
            }
        }
    }
