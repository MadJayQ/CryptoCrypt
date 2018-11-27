using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputAction : ScriptableObject {
	public string[] ActionKeys;

	public abstract void RespondToInput(GameController controller, string[] inputText);

	public bool ContainsKey(string actionKey)
	{
		foreach(var key in ActionKeys)
		{
			if(key == actionKey)
			{
				return true;
			}
		}
		return false;
	}
}
