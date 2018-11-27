using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	[HideInInspector] public RoomNavigation RoomNavigation; //We don't need to see this in inspector
	[HideInInspector] public List<string> InteractionDescriptions = new List<string>();

	public Text DisplayText;
	public InputAction[] Actions;
	private List<string> m_Log = new List<string>();

	void Awake()
	{
		RoomNavigation = GetComponent<RoomNavigation>();
	}
	void Start()
	{
		DisplaySceneText();
		DisplayLoggedText();
	}

	public void DisplayLoggedText()
	{
		string logOutput = string.Join("\n", m_Log.ToArray());
		DisplayText.text = logOutput;
	}
	public void DisplaySceneText()
	{
		RoomCleanup();
		UnpackRoom();
		string allInteractions = string.Join("\n", InteractionDescriptions.ToArray());
		string outputText = RoomNavigation.CurrentScene.Description + "\n" + allInteractions;
		Log(outputText, true);
	}

	void UnpackRoom()
	{
		RoomNavigation.DisplayLinks();
	}

	void RoomCleanup()
	{
		//Prepare for the new room
		InteractionDescriptions.Clear();
		RoomNavigation.ClearLinks();
	}

	public void Log(string action, bool newLine = true)
	{
		m_Log.Add(
			(!newLine) ? action : action + "\n"
		);
	}

	void Update()
	{

	}
}
