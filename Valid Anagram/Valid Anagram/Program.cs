using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
            //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
        }
    }
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {

            ArrayList sList = new ArrayList();
            ArrayList tList = new ArrayList();
            for (int i = 0; i < s.Length; i++)
            {
                sList.Add(s[i]);
            }
            for (int i = 0; i < t.Length; i++)
            {
                tList.Add(t[i]);
            }
            sList.Sort();
            tList.Sort();

            for (int i = 0; i < sList.Count; i++)
            {
                if (sList[i].Equals(tList[i]) && sList.Count == tList.Count)
                {
                    Console.WriteLine(sList[i] + "/" + tList[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;


        }

    }
}
