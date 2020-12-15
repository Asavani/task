using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "";
            Console.WriteLine("Enter Text:");
            msg = Console.ReadLine();
            cal_char(msg);
        }
        static void  cal_char(string msg)
        {
            if(msg.Length>0)
            {
                
                
                int k = 0;
                for (int i = 0; i < msg.Length; i++)
                {
                    k = 0;
                    for(int j=0;j<msg.Length;j++)
                    {
                        if(Char.ToLower(msg[i]).Equals(Char.ToLower(msg[j])))
                        {
                            k++;
                        }
                
                    }
                    if(Char.ToLower(msg[i]).Equals(' '))
                    {
                        Console.WriteLine("White Space Repeated:"+k);
                    }
                    else
                    {
                        Console.WriteLine(msg[i] + " Repeated=>" + k);
                    }
                    
                    

                }
            }
            
        }
    }
}
