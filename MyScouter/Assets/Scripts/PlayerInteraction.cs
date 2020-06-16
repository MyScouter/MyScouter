using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : Interaction
{
    private void Awake() {
        //base.FindObject();
        base.isClicked = false;
        base.setupGui();
    }

    public override void OnTriggerStay(Collider other){
        if (other.gameObject == player)     //player has collided with trigger
        {
            ShowMassage.instanse.showMassage = false;
            showInteractMsg = true;
            if (Input.GetKey(KeyCode.F) && !isClicked)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                background.SetActive(true);
                TestConverstion.SetActive(true);
                NPC.instance.GoToPassage();
                NPC.instance.Active();
                isClicked = true;
            }
        }
    }

    public override void OnTriggerExit(Collider other) {
        if (other.gameObject == player)     //player has exited trigger
        {
            //hide interact message as player may not have been looking at object when they left
            showInteractMsg = false;
            background.SetActive(false);
            TestConverstion.SetActive(false);
            NPC.instance.ShotDown();
            showInteractMsg = false;
            ShowMassage.instanse.showMassage = true;
            isClicked = false;
        }
    }
}
