using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class PhoneInteraction : Interaction
{
    public GameObject player1;
    public Transform moveTo;

    private void Awake() {
        base.isClicked = false;
        base.setupGui();
    }
    public override void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player1)     //player has collided with trigger
        {
            showInteractMsg = true;
            if (Input.GetKey(KeyCode.F) && !isClicked)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                background.SetActive(true);
                TestConverstion.SetActive(true);
                NPC.instance.Active();
                NPC.instance.GoToPassage();
                isClicked = true;
            }
        }
    }

    public override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
    }
    private void Update()
    {
        if (NPC.instance.active)
        {
           
            if (NPC.instance.currentPassage.Contains("Hello") && !NPC.instance.currentPassage.Equals("Hello Player"))
            {
                TextController.instance.isInstantiated = true;
                TextController.instance.updateScore = true;
                showInteractMsg = false;
                background.SetActive(false);
                TestConverstion.SetActive(false);
                //base.player.SetActive(false);
                Debug.Log("Before moving: " + player1.transform.position);
                player1.transform.position = moveTo.position;
                Debug.Log("After moving: " + player1.transform.position);
                // base.player.SetActive(true);
                //Debug.Log(TextController.instance.isInstantiated);
                NPC.instance.ShotDown();
                NPC.instance.currentPassage = "Hello Player";
                ShowMassage.instanse.changingMsg = "Please go talk to player";
                ShowMassage.instanse.showMassage = true;
                
            }
        }
    }

    

}
