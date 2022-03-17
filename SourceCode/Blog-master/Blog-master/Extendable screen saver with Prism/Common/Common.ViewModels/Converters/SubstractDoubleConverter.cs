﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Ikc5.ScreenSaver.Common.Views.Converters
{
	/// <summary>
	/// Substract two double elements.
	/// </summary>
	[ValueConversion(typeof(double[]), typeof(double))]
	public class SubstractDoubleConverter : OperationGenericConverter<double>
	{
		protected override Func<object, CultureInfo, double> ConvertMethod =>
				(value, culture) =>
				{
					if (value == null)
						return 0;
					var result = System.Convert.ToDouble(value);
					return double.IsNaN(result) ? 0 : result;
				};

		protected override Func<double, double, double> BinaryMethod =>
			(value1, value2) => value1 - value2;

		protected override Func<double, double, double> ApplyParameterMethod =>
			(value, parameter) => Math.Round(value, System.Convert.ToInt32(Math.Abs(parameter)));
	}
}
