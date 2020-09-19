public static class CheckMasterCode
{
	private static int[] feedback = new int[4];
	private static bool[] userIsEvaluated = new bool[4];
	private static int length = 4;


	private static void CleanAllArrays()
	{
		for (int i = 0; i < length; i++)
		{
			feedback[i] = 0;
			userIsEvaluated[i] = false;
		}
	}

	//Check if any position/'color' (value info) is Correct
	// i -> position in arrayCode
	// j -> position in userCode
	public static int[] IsCodeCorrect(int[] arrayCode, int[] userCode)
	{
		CleanAllArrays();
		for (int i = 0; i < length; i++)
		{
			// Comparar Color y Posición
			if (arrayCode[i] == userCode[i])
			{
				feedback[i] = 2; // color negro
				userIsEvaluated[i] = true;
				continue;
			}

			// Buscar si existe el color pero en diferente posición
			for (int j = 0; j < length; j++)
			{
				if (!userIsEvaluated[j])
				{
					// coincidencia de color
					if (!userIsEvaluated[j] && arrayCode[i] == userCode[j])
					{
						feedback[j] = 1; // color blanco
						userIsEvaluated[j] = true;
						break;
					}
				}
			}
		}
		return feedback;
	}
}
