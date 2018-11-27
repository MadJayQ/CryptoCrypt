using System;

using UnityEngine;

[CreateAssetMenu(menuName="CryptoCrypt/Actions/Go")]
public class Go : InputAction
{
    public override void RespondToInput(GameController controller, string[] inputText)
    {
        controller.RoomNavigation.ChangeScene(
            inputText[1]
        );
    }
}