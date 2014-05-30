using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();

    
    static Singleton()
    {
    }

    private Singleton()
    {
    }
  
        
       public List<string> data = new List<string>(){
            "Howdy",
            "Hello",
            "Hola"
        };


    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }
} 
}