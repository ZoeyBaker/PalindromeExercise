﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsaPalindrome(string word)
        {

            var reversed = "";

          for (int i = word.Length - 1;  i >= 0; i--) 
            {
                reversed += word.ToLower()[i];
            }

          if(reversed.ToLower() == word.ToLower())

            {
                return true;
            }
          else
            {
                return false;
            }
        }
    }
}
