using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzzCalc
    {
        public FizzBuzzCalc() { }

        public enum specialNums { FIZZ = 3, BUZZ = 5, WOLF = 7 }

         
        private int _numToCalc;
        /// <summary>
        /// Number currently set for performing FIZZBUZZ calculation.
        /// </summary>
        public int numToCalc
        {
            get { return _numToCalc; }
            set { _numToCalc = value; }
        }

        private string[] _lastCalculated;
        /// <summary>
        /// Stores the last generated FIZZBUZZ result string.
        /// </summary>
        public string[] lastCalculated
        {
            get { return _lastCalculated; }
        }


        private int _numOfFIZZ = 0;
        public int numOfFIZZ
        {
            get { return _numOfFIZZ;  }
        }

        private int _numOfBUZZ = 0;
        public int numOfBUZZ
        {
            get { return _numOfBUZZ; }
        }

        private int _combinedNumOfSpecial = 0;
        public int combinedNumOfSpecial
        {
            get { return _combinedNumOfSpecial;  }
        }


        /// <summary>
        /// Initializes string array which stores calculated FIZZBUZZ.
        /// </summary>
        private void InitializeLastCalculated()
        {
            // Allocate array to store FIZZBUZZ output
            try
            {
                _lastCalculated = new string[_numToCalc + 1];
            }
            catch(OutOfMemoryException e)
            {
                // Display helpful message on failure and pass exception up
                System.Windows.Forms.MessageBox.Show("Stop it, you memory hog!");

                throw new Exception("FIZZBUZZ Calculation failed!", e);
            }

            // re-initialize counters
            _numOfBUZZ = 0;
            _numOfFIZZ = 0;

            // initialize elements of array
            for( int i = 0; i < _lastCalculated.Length; i ++)
            {
                _lastCalculated[i] = "";
            }
        }

        /// <summary>
        /// Performs FIZZBUZZ calculation.
        /// </summary>
        public void PerformFIZZBUZZCalculation( int num )
        {
            _numToCalc = num;

            PerformFIZZBUZZCalculation();
        }

        /// <summary>
        /// Performs FIZZBUZZ calculation.
        /// </summary>
        public void PerformFIZZBUZZCalculation()
        {
            InitializeLastCalculated();

            // loops each number to assign either normal or special value 
            for (int i = 0; i <= _numToCalc; i++)
            {
                // Checks current number against all special values. If value does not meet special criteria, the number is added to results array.
                if (!CheckSpecial(i, specialNums.FIZZ, ref _numOfFIZZ) & !CheckSpecial(i, specialNums.BUZZ, ref _numOfBUZZ))
                {
                    _lastCalculated[i] = i.ToString();
                }
            }
        }

        /// <summary>
        /// Performs check of int for specified value. If the special value found, the result array is updated accordingly.
        /// </summary>
        /// <param name="num">Current value of FIZZBUZZ being calculated</param>
        /// <param name="FizzBuzz">Special value to check for</param>
        /// <returns>True if the special value is hit, false otherwise.</returns>
        private bool CheckSpecial( int num, specialNums FizzBuzz, ref int counter)
        {
            // Determines if num is divisible by special number
            if( num % (int)FizzBuzz == 0 )
            {
                // Update coresponding cell in result array with the name of the special char used by enum
                _lastCalculated[num] = _lastCalculated[num] + Enum.GetName(typeof(specialNums), FizzBuzz);
                counter++;
                return true;
            }

            return false;
        }

    }
}
