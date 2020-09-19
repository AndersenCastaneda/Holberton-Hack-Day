using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserPlayer : MonoBehaviour
{
	public GameObject[] levels = new GameObject[10];
	public SubLevel[] previousLevels = new SubLevel[10];
	public int[] userCode = new int[4];
	public int level = 0;

	private void Awake() {
		Entrylevel();
	}

	public void Entrylevel()
	{
		int length = levels.Length;
		levels[level].SetActive(true);
		for (int i = 0; i < 4; i++)
		{
			if (level > 0)
				previousLevels[level - 1].previousLevels[i].enabled = false;
		}
	}

}

[System.Serializable]
public class SubLevel
{
	public BoxCollider2D[] previousLevels = new BoxCollider2D[4];
}
