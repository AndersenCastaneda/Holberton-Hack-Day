using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int[] masterCode = new int[4];
	public int[] userCode = new int[4];
	public int[] feedback = new int[4];

	public static Sprite[] playerColors = new Sprite[6];


	public FeedBackManager feedBackManager;


#pragma warning disable 0649
	[SerializeField] private UserPlayer userPlayer;
	[SerializeField] private ColorManager colorManager;
	[SerializeField] private GameObject youLose;
	[SerializeField] private GameObject youWin;
	[SerializeField] private GameObject cover;
#pragma warning restore 0649

	private void Awake()
	{
		masterCode = CodeGenerator.GenerateMasterCode();
		MasterCodePositions.CreateSprites();
		playerColors = colorManager.spriteColors;
		colorManager.SetMasterCodeColor(masterCode);
	}

	public void TestCases()
	{
		feedback = CheckMasterCode.IsCodeCorrect(masterCode, userCode);

		colorManager.SetFeedBackColor(feedBackManager, feedback, userPlayer.level, userCode);

		if (CheckVictory())
		{
			youWin.SetActive(true);
			cover.SetActive(false);
		}
		else
		{
			if (!EntryManager.IsValidUserCode(userCode))
				return;

			NewLevel();
			CleanUserCode();
		}
	}

	private void CleanUserCode()
	{
		for (int i = 0; i < 4; i++)
			userCode[i] = -1;
	}

	private void NewLevel()
	{
		if (userPlayer.level == 9 && !CheckVictory())
		{
			youLose.SetActive(true);
			cover.SetActive(false);
			userPlayer.level++;
		}

		if (userPlayer.level < 9)
			userPlayer.level++;

		userPlayer.Entrylevel();
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
