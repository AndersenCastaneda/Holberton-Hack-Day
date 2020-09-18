using UnityEngine;

public static class CodeGenerator
{
	private static int[] arrayCode = new int[4];
	private static int length = 4;

	//MasterCode Generator
	public static int[] MasterCode()
	{
		for (int i = 0; i < length; i++)
			arrayCode[i] = Random.Range(0, 6);

		return arrayCode;
	}

	//Check if any position/'color' (value info) is Correct
	public static bool IsCodeCorrect(int[] userCode)
	{
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length; j++)
			{
				// if (arrayCode[i] == userCode[j])
			}
			if (arrayCode[i] != userCode[i])
				return false;
		}
		return true;
	}
}
