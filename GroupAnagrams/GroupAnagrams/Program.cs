using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ArrayList arrayList= new ArrayList();
             ArrayList pomocnicza = new ArrayList();
            
            string[] strs = new string[]
            {
                "eat","tea","tan","ate","nat","bat"
            };

            foreach (var item in strs)
            {
               string s= string.Concat(item.OrderBy(x => x));
               arrayList.Add(s);
               
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("\t");
               for(int j =0; j<arrayList.Count; j++)
                {
                    if (arrayList[i].Equals(arrayList[j])  )
                    {
                        Console.WriteLine(arrayList[j]);
                        pomocnicza.Add(arrayList[i]);
                        
                    }
                    else
                        continue;
                        //Console.WriteLine(arrayList[j]+"to nie to ");
                }
                
                }
            Console.ReadLine();

            }

          
        
            

            
           
           

        }
    }
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            HashSet<string> list = new HashSet<string>();
            foreach (string str in strs)
            {
                list.Add(str);
                
            }
           

            return new List<IList<string>>();
        }
    }



