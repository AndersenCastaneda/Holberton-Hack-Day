using UnityEngine;

public static class MasterCodePositions
{
	public static Vector2[] positions = new Vector2[4] {
		new Vector2(-6.03f, -0.46f), new Vector2(-6.03f, 0.16f),
		new Vector2(-6.03f, 0.82f), new Vector2(-6.03f, 1.45f)};

	public static SpriteRenderer[] masterObjects = new SpriteRenderer[4];

	public static void CreateSprites()
	{
		for (int i = 0; i < 4; i++)
		{
			GameObject gameObject = new GameObject(i.ToString());
			gameObject.transform.position = positions[i];
			SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>();
			masterObjects[i] = sr;
		}
	}
}
