using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class Greeting
    {       
        public string Greet(string name)
        {            
            if (name == null || name == "")
            {
                throw new NullReferenceException("The input for name was either null or empty.");
            }

            return "Hello, " + name + " how are you doing today?";
        }

        // or you can use 
        // public string Greet(string name)
        // {
        //     return !String.IsNullOrEmpty(name) ? $"Hello, {name} how are you doing today?" : "Name is empty.";

        // }


        // Write a method that takes in a name as a string
        // and returns the greeting using that name

    }
}
