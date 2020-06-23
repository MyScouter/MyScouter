using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class PhoneInteraction : Interaction
{
    public GameObject player1;
    

    private void Awake() {
        
        base.isClicked = false;
        base.setupGui();
        showInteractMsg = true;
        msg = "PLEASE GO TO THE PHONE";
    }
    public override void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player1)     //player has collided with trigger
        {
            //showInteractMsg = true;
            msg = "Press F to start conversation";
            if (Input.GetKey(KeyCode.F) && !isClicked)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                MouseLook.enabled = false;
                background.SetActive(true);
                TestConverstion.SetActive(true);
                NPC.instance.Active();
                NPC.instance.GoToPassage();
                isClicked = true;
                showInteractMsg = false;
            }
            
        }
    }

    public override void OnTriggerExit(Collider other)
    {
        showInteractMsg = true;
        base.OnTriggerExit(other);
        msg = "PLEASE GO TALK TO THE PHONE";
        MouseLook.enabled = true;

    }
    private void Update()
    {
        if (NPC.instance.active)
        {
           
            if (NPC.instance.currentPassage.Contains("Hello") && !NPC.instance.currentPassage.Equals("Hello Player"))
            {
                UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                MouseLook.enabled = true;
                TextController.instance.isInstantiated = true;
                TextController.instance.updateScore = true;
                showInteractMsg = false;
                background.SetActive(false);
                TestConverstion.SetActive(false);
                //Debug.Log("Before " + player1.transform.position);
                player1.SetActive(false);
                player1.transform.position = moveTo.position;
                player1.SetActive(true);
                //Debug.Log("After " + player1.transform.position);
                NPC.instance.ShotDown();
                NPC.instance.currentPassage = "Hello Player";
            }
        }
    }

    

}
