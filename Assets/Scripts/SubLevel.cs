using UnityEngine;

[System.Serializable]
public class SubLevel
{
	public BoxCollider2D[] previousLevels = new BoxCollider2D[4];
}

[System.Serializable]
public class SubFeedback
{
	public SpriteRenderer[] feedback;
}

public static class EntryManager
{
	public static bool IsValidUserCode(int[] userCode)
	{
		for (int i = 0; i < 4; i++)
		{
			if (userCode[i] == -1)
				return false;
		}
		return true;
	}
}
