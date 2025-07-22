using System;
using System.Collections.Generic;
using System.Text;
// User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

// Implement the class TextInput that contains:

// Public method void Add(char c) - adds the given character to the current value
// Public method string GetValue() - returns the current value
// Implement the class NumericInput that:

// Inherits TextInput
// Overrides the Add method so that each non-numeric character is ignored
// For example, the following code should output "10":

// TextInput input = new NumericInput();
// input.Add('1');
// input.Add('a');
// input.Add('0');
// Console.WriteLine(input.GetValue());
public class UserInput
{
    public abstract class TextInput
    {
        //public List<int> list = new List<int>();
        public StringBuilder sb = new StringBuilder();

        public virtual void Add(char c)
        {
            //list.Add(c);
            sb.Append(c);
        }

        public string GetValue()
        {
            // string items = string.Join("", list);
            // return items;
            return sb.ToString();
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char a)
        {
            if (Char.IsDigit(a))
            {
                //list.Add(a);
                sb.Append(a);
            }
        }
    }
}

// public class UserInput 
// {
//     public static void Main(string[] args)
//     {
//         TextInput input = new NumericInput();
//         input.Add('1');
//         input.Add('a');
//         input.Add('0');
//         Console.WriteLine(input.GetValue());
//     }
// }