using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour {

	public InputField InputField;
	private GameController m_Controller;

	private readonly char[] delimeterCharacters = { ' ' };

	void Awake()
	{
		m_Controller = GetComponent<GameController>();
		
		InputField.onEndEdit.AddListener(
			userInput => 
			{
				userInput = userInput.ToLower();
				m_Controller.Log(userInput);

				var separatedInput = userInput.Split(delimeterCharacters);
				foreach(var action in m_Controller.Actions)
				{
					if(action.ContainsKey(separatedInput[0]))
					{
						action.RespondToInput(m_Controller, separatedInput);
					}
				}
				InputComplete();
			}
		);
	}

	void InputComplete()
	{
		m_Controller.DisplayLoggedText();
		InputField.ActivateInputField();
		InputField.text = null;
	}
}
