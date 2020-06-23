using UnityEngine;

public class ComputerInteraction : Interaction
{
    public override void OnTriggerStay(Collider other)
    {
        //base.OnTriggerStay(other);
        if (other.gameObject == player)     //player has collided with trigger
        {
            msg = "Press F to start conversation";
            showInteractMsg = true;
            if (Input.GetKey(KeyCode.F) && !isClicked)
            {
                Debug.Log("Player ENTER");
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                MouseLook.enabled = false;
                background.SetActive(true);
                TestConverstion.SetActive(true);
                NPC.instance.currentPassage = "Interaction Trainer";
                NPC.instance.Active();
                NPC.instance.GoToPassage();

                isClicked = true;
            }

        }
    }
    public override void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            showInteractMsg = false;
            isClicked = false;

        }
        if (NPC.instance.story.Vars.GetMember("waitTime") < 3)
        {
            NPC.instance.currentPassage = "After Activity";
            NPC.instance.GoToPassage();
        }
        base.OnTriggerExit(other);
    }
}
