using UnityEngine;
using System.Collections;

public class UserInputHandler : MonoBehaviour
{
	public int col = -1;
	public SpriteRenderer sr;
	public int index;

#pragma warning disable 0649
	[SerializeField] private GameManager gameManager;
#pragma warning restore 0649

	private void Awake() {
		index = int.Parse(gameObject.name);
	}

	private void OnMouseDown() => SelectColor();

	public void SelectColor()
	{
		if (col < 6)
			col++;

		if (col == 6)
			col = 0;

		//setiar el color
		sr.sprite = GameManager.playerColors[col];
		gameManager.UserMasterCode(col, index);
	}
}
