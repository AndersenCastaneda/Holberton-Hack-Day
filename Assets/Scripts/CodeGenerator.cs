using UnityEngine;

public static class CodeGenerator
{
	private static int[] masterCode = new int[4];
	private static int length = 4;

	//MasterCode Generator
	public static int[] GenerateMasterCode()
	{
		for (int i = 0; i < length; i++)
			masterCode[i] = Random.Range(1, 7);

		return masterCode;
	}
}
