using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
public class Calculator : ICalculator
{
	public double Addition(double firstvalue, double secondvalue)
	{
		double result;
		try
		{
			result = firstvalue + secondvalue;

		}
		catch (Exception)
		{

			throw;
		}
		return result;
	}

	public double Subtraction(double firstvalue, double secondvalue)
	{
		double result;
		try
		{
			result = firstvalue - secondvalue;

		}
		catch (Exception)
		{

			throw;
		}
		return result;
	}

	public double Multiplication(double firstvalue, double secondvalue)
	{
		double result;
		try
		{
			result = firstvalue * secondvalue;

		}
		catch (Exception)
		{

			throw;
		}
		return result;
	}

	public double Division(double firstvalue, double secondvalue)
	{
		double result;
		try
		{
			if(secondvalue == 0)
			{
				throw new Exception("Cannot divide by Zero");
			}
			result = firstvalue / secondvalue;

		}
		catch (DivideByZeroException e)
		{

			throw e;
		}
		catch (Exception)
		{

			throw;
		}
		return result;
	}


}
