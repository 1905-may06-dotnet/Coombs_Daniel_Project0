using System;
using System.Collections.Generic;
using System.Text;

namespace App.Logic
{
    interface ILogic<T> //can make generic
    {
        //methods
        void Swap<T>(T a, T b); //cannot make methods public, abstract, etc. b/c it's by default public and abstract

        //properties
        int value { get; set; }
        //events
        //indesxers
    }
}
