using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int[] masterCode = new int[4];
	public int[] userCode = new int[4];
	public int[] feedback = new int[4];


	[SerializeField] private Sprite[] spriteColors = new Sprite[6];
	public static Sprite[] playerColors = new Sprite[6];

#pragma warning disable 0649
	[SerializeField] private UserPlayer userPlayer;
#pragma warning restore 0649

	private void Awake()
	{
		playerColors = spriteColors;
		masterCode = CodeGenerator.GenerateMasterCode();
		MasterCodePositions.CreateSprites();
		// feedback = CheckMasterCode.IsCodeCorrect(masterCode, userCode);
		for (int i = 0; i < 4; i++)
			MasterCodePositions.masterObjects[i].sprite = spriteColors[masterCode[i]];
	}

	public void TestCases()
	{
		feedback = CheckMasterCode.IsCodeCorrect(masterCode, userCode);
		if (CheckVictory())
		{
			//Si ganó
			Debug.Log("Ganaste");
		}
		else
		{
			userPlayer.level++;
			userPlayer.Entrylevel();
			Debug.Log("Sigue intentando");
		}
	}

	private bool CheckVictory()
	{
		for (int i = 0; i < 4; i++)
		{
			if (feedback[i] != 2)
				return false;
		}

		return true;
	}

	public void UserMasterCode(int value, int index)
	{
		userCode[index] = value;
	}
}
