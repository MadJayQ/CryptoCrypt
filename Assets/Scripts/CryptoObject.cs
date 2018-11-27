using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CryptoObject : ScriptableObject
{
    public InputAction AvailableActions;

    [TextArea]
    public string ExamineText = "It's an object!";

    public string ItemKey;

    public void OnExamine(GameController controller)
    {
        controller.Log(ExamineText);
    }
}