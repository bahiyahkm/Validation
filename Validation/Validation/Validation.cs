using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Validation
{
   public class Validation
    {
        
        public  bool required(string text1)
        {
            if ( text1==null||text1=="")
            {
                return false;
                
            }
            
            else
            { 
            
                return true;
            };
        }
        public bool PhoneValidation(string text2 )
        {

            if (text2.Length == 10)
            {
                return true;
            }
            else if(text2.Length>10)
            {
                return false;
            }
            else if(text2.Length<10)
            {
                return false;
            }
            else
            {
                return false;
            }
                
        }
    }
}
