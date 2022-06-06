using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class PositionGuesser
    {
        private int Row_lower_bound = 0;
        private int Row_upper_bound = 1025;
        private int Col_lower_bound = 0;
        private int Col_upper_bound = 1025;

        private int x_Guess = 512;
        private int y_Guess = 512;


        public void North()
        {
            Col_lower_bound = y_Guess;
            y_Guess = (Col_upper_bound + Col_lower_bound) / 2;
        }
        public void South()
        {
            Col_upper_bound = y_Guess;
            y_Guess = (Col_lower_bound + Col_upper_bound) / 2;
        }
        public void East()
        {
            Row_lower_bound = x_Guess;
            x_Guess = (Row_lower_bound + Row_upper_bound) / 2;
        }
        public void West()
        {
            Row_upper_bound = x_Guess;
            x_Guess = (Row_lower_bound + Row_upper_bound) / 2;
        }

        public override string ToString()
        {
            return x_Guess + "," + y_Guess;
        }

        public void ResetGuess()
        {
            Row_lower_bound = 0;
            Row_upper_bound = 1025;
            Col_lower_bound = 0;
            Col_upper_bound = 1025;
            x_Guess = 512;
            y_Guess = 512;
        }
    }

}
