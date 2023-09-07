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
             ArrayList indexofArray = new ArrayList();
             ArrayList valueArray = new ArrayList();
             ArrayList lastArray= new ArrayList();  
            int counter = 0;
             
            IList<IList<string>> lista = new List<IList<string>>();


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
                if(valueArray.Count!= 0)
                {
                    for (int k = 0; k < valueArray.Count; k++)
                    {
                        int value = (int)valueArray[k];
                        lastArray.Add(strs[value]);
                    }
                    for(int m=0; m< lastArray.Count; m++)
                    {
                        Console.WriteLine(lastArray[m]+"   LastArray");
                    }
                   // lista[counter].Add(lastArray);
                }
                Console.WriteLine("\t");
               for(int j =0; j<arrayList.Count; j++)
                {

                    if (arrayList[i].Equals(arrayList[j]) && !indexofArray.Contains(j) )
                    {
                        indexofArray.Add(j);
                        valueArray.Add(j);

                    }
                    else
                        continue;
                        
                }

                
                }
            for (int i = 0; i < indexofArray.Count; i++)
            {
                Console.WriteLine(indexofArray[i]);
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
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



