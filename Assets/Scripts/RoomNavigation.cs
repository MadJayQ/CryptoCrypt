using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour {
	public CryptoScene CurrentScene;
	private GameController Controller;
	Dictionary<string, SceneLink> LinkDescriptionDictionary = new Dictionary<string, SceneLink>();

	void Awake()
	{
		Controller = GetComponent<GameController>();
	}

	public void DisplayLinks()
	{
		foreach(var link in CurrentScene.Links)
		{
			LinkDescriptionDictionary.Add(link.LinkKey, link);
			Controller.InteractionDescriptions.Add(link.LinkDescription);
		}
	}

	public void ChangeScene(string linkKey)
	{
		if(LinkDescriptionDictionary.ContainsKey(linkKey))
		{
			var targetLink = LinkDescriptionDictionary[linkKey];
			CurrentScene = targetLink.TargetScene;
			Controller.Log(targetLink.TravelText);
			Controller.DisplaySceneText();
		} else {
			Controller.Log("You cannot travel to the " + linkKey);
		}
	}

	public void ClearLinks()
	{
		LinkDescriptionDictionary.Clear();
	}
}
