using System;
class programe
{
    
    static void Main(string[] args)
    {
        
        char flower = ']';
        int Gcounter = 0;
        int Rcheck = 0;
        Console.WriteLine("Input some flowers");
        Console.WriteLine("J ,G,O,R other for stop progress:");
       CircularLinkedList<char> flowerBS = new CircularLinkedList<char>();
       while(flower == 'J'||flower == 'G'||flower == 'O'||flower =='R'|| flower == ']')
       {
    flower = char.Parse(Console.ReadLine());
    
    if(flower == 'G'){
        if(Gcounter <3 ){
        Gcounter++;
        flowerBS.Push(flower);
        Rcheck++;
        }
        else{
            Gcounter = 0;
            ErorrP();
        }
    }
    if(flower == 'J'){
        flowerBS.Push(flower);
        Rcheck++;
    }
    if(flower == 'O'){
        flowerBS.Push(flower);
        Rcheck++;
    }
    if(flower == 'R'){
        if(Rcheck >= 1 ){
            flowerBS.Push(flower);
            Rcheck = 0;
        }
        else{
            ErorrP();
            
        }
    }

       }
       Console.Write("Flower bond is : ");
      
      
      for(int x = 0;x < flowerBS.GetLength();x++)
       {
        Console.Write("{0}",flowerBS.Get(x),flowerBS);
       } 
    }
    static void ErorrP(){
      Console.WriteLine("invalid pattern");

    }
    }
    
   

