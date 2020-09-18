using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int[] masterCode = new int[4];
	public int[] userCode = new int[4];
	public int[] feedback = new int[4];

	private void Awake()
	{
		MasterCodePositions.CreateSprites();
	}

	public void TestGame()
	{
		// masterCode = CodeGenerator.GenerateMasterCode();
		feedback = CheckMasterCode.IsCodeCorrect(masterCode, userCode);
	}

	private bool CheckVictory()
	{
		for (int i = 0; i < 4; i++)
			if (feedback[i] != 2)
			{
				Debug.Log("No ha ganado");
				return false;
			}

		Debug.Log("Juego Terminado Ganaste!");
		return true;
	}
}
