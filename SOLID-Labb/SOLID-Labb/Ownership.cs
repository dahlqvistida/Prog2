using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Ownership
    {
        string _owner;
        public void TransferOwnership(string owner)
        {

            Animal[] animals = [Dog, Hedgehog, Bird]; 
            _owner = owner;
            
            foreach (var animal in animals){

            if (animal is Dog dog){
                
                dog.TransferOwnership("Niklas");
            
            }
        }


       
      

}
        

}

