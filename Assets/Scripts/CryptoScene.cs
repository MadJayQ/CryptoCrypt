using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="CryptoCrypt/Scene")]
public class CryptoScene : ScriptableObject {

	[TextArea]
	public string Description;

	public string SceneName;

	public SceneLink[] Links;


}
