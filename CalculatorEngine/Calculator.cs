using System.Reflection;

namespace Calculator
{

	using System;

	public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator1:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			eexponentiatoin = 5,
			eExtractSquare = 6,
			eReverse = 7,
			eSquareNumber = 8
		}

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		//TODO: Upgrade the version number to 3.0.1.1
		private static string versionInfo = "Calculator v9.0.1.1";


		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator1 calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalcEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}
		//key is pressed.
		//
		// Called when the +/- 

		public static string CalcSign()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}

			return (stringAnswer);
		}
		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ",";
				else
					stringAnswer = "0,";

				decimalAdded = true;
			}

			return (stringAnswer);
		}
		//
		// Called when an operator is selected (+, -, *, /)
		//

		public static void CalcOperation (Operator1 calcOper)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
				firstNumber = System.Convert.ToDouble (stringAnswer);
				calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
			}			
		}



		

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumberAdded = true;
				//decimalAdded = false;

				switch (calcOperation)
				{
					case Operator1.eUnknown:
						validEquation = false;
						break;

					case Operator1.eAdd:
						secondNumber = System.Convert.ToDouble(stringAnswer);
						
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator1.eSubtract:
						secondNumber = System.Convert.ToDouble(stringAnswer);						
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator1.eMultiply:
						secondNumber = System.Convert.ToDouble(stringAnswer);						
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator1.eDivide:
						secondNumber = System.Convert.ToDouble(stringAnswer);						
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;
					case Operator1.eexponentiatoin:
						secondNumber = System.Convert.ToDouble(stringAnswer);
						numericAnswer = Math.Pow(firstNumber, secondNumber); ;
						validEquation = true;
						break;


					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
            else
            {
				secondNumberAdded = true;
				//decimalAdded = false;

				switch (calcOperation)
				{
					
					case Operator1.eExtractSquare:
						numericAnswer = Math.Pow(firstNumber, 0.5);
						validEquation = true;
						break;
					case Operator1.eReverse:
						numericAnswer = 1 / firstNumber;
						validEquation = true;
						break;
					case Operator1.eSquareNumber:
						numericAnswer = Math.Pow(firstNumber, 2); ;
						validEquation = true;
						break;

					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString(numericAnswer);

			}
			
			return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator1.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}
	}
}