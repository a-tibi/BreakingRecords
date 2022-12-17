using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingRecords
{
	class Result
	{

		/*
		 * Complete the 'breakingRecords' function below.
		 *
		 * The function is expected to return an INTEGER_ARRAY.
		 * The function accepts INTEGER_ARRAY scores as parameter.
		 */

		public static List<int> breakingRecords(List<int> scores)
		{
			var result = new List<int>() { 0, 0 };

			int maxScore = scores[0];
			int minScore = scores[0];
			foreach (var score in scores)
			{
				if (score > maxScore)
				{
					result[0]++;
					maxScore = score;
				}
				if (score < minScore)
				{
					result[1]++;
					minScore = score;
				}
			}

			return result;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine().Trim());

			List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

			List<int> result = Result.breakingRecords(scores);

			Console.WriteLine(String.Join(" ", result));

			Console.ReadKey();
		}
	}
}
