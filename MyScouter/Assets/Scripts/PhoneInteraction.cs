using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class PhoneInteraction : Interaction
{
    
    private void Awake() {
        base.isClicked = false;
        base.setupGui();
    }
    public override void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)     //player has collided with trigger
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
            this.currentPassage = NPC.instance.currentPassage;
            if (currentPassage.Contains("Hello"))
            {
                showInteractMsg = false;
                background.SetActive(false);
                TestConverstion.SetActive(false);
                NPC.instance.ShotDown();
                SaveVar.instance.currentPassage = NPC.instance.currentPassage;
                SceneManagerGame.instance.LoadNextScene(1);
            }

        }
    }

    

}
