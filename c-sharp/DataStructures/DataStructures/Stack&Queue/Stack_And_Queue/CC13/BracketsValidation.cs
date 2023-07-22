using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stack_And_Queue.CC13
{

  
  public class BracketsValidation
  {
    private readonly Stack_And_Queue.Stack<char> stack = new Stack_And_Queue.Stack<char>();

    public BracketsValidation()
    {
      stack = new Stack_And_Queue.Stack<char>();
    }


    //    Write a function called validate brackets
    //Arguments: string
    //Return: boolean
    //representing whether or not the brackets in the string are balanced
   

   

    public bool ValidateBrackets(string str)
    {
      foreach(char ch in str)
      {
        if (ch == '(' || ch == '{' || ch == '[')
          stack.Push(ch);
        else if(ch == ')' || ch == '}' || ch == ']')
        {

          if (stack.IsEmpty())
            return false;


          else if (!CheckIfMatching(stack.Pop(), ch))
            return false;



        }


      }
      if (stack.IsEmpty())
        return true;

      else
        return false;
    }


  


    public bool CheckIfMatching(char ch1, char ch2)
    {
      if (ch1 == '(' && ch2 == ')')
        return true;
      else if (ch1 == '[' && ch2 == ']')
        return true;
      else if (ch1 == '{' && ch2 == '}')
        return true;
      else
      return false;
    }





}
}

