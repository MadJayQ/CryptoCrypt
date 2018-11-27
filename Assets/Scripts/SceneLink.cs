using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SceneLink {

	public string LinkKey; //Link's primary key
	public string LinkDescription; //Description of link
	public CryptoScene TargetScene; //Scene that the link takes you to

	[TextArea]
	public string TravelText; //This is the text that gets displayed when you take this link
}
