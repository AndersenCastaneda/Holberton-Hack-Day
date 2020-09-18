using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int[] masterCode = new int[4];

	private void Awake()
	{
		masterCode = CodeGenerator.MasterCode();
	}
}
