using System;

using UnityEngine;

[CreateAssetMenu(menuName="CryptoCrypt/Actions/Go")]
public class Go : InputAction
{
    public override void RespondToInput(GameController controller, string[] inputText)
    {
        if(inputText.Length < 2) 
        {
            controller.Log("How do you expect to go somewhere if you don't know where you want to go!");
        } 
        else 
        {
            controller.RoomNavigation.ChangeScene(
                inputText[1]
            );
        }
    }
}