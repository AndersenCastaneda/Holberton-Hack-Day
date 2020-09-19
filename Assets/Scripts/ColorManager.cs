using UnityEngine;

public class ColorManager : MonoBehaviour
{
	public Sprite[] spriteColors = new Sprite[6];
	public Sprite[] feedBackColors = new Sprite[2];

	public void SetMasterCodeColor(int[] array)
	{
		for (int i = 0; i < 4; i++)
			MasterCodePositions.masterObjects[i].sprite = spriteColors[array[i]];
	}

	public void SetFeedBackColor(FeedBackManager feedBackManager, int[] feedBack, int level, int[] userCode)
	{
		if (!EntryManager.IsValidUserCode(userCode))
			return;

		for (int i = 0; i < 4; i++)
		{
			if (feedBack[i] == 1)
				feedBackManager.feedBacks[level].feedback[i].sprite = feedBackColors[1];
			else if (feedBack[i] == 2)
				feedBackManager.feedBacks[level].feedback[i].sprite = feedBackColors[0];
		}
	}

}
