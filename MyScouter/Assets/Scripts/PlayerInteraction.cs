using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : Interaction
{
    bool isShow=true;
    bool isFromScene = true;
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
                NPC.instance.Active();
                NPC.instance.GoToPassage();
                isClicked = true;
            }
            /*            if (isShow)
                        {
                            Debug.Log(NPC.instance.story.Vars.GetMember("motivation"));
                            Debug.Log(NPC.instance.story.Vars.GetMember("physicalShape"));
                            Debug.Log(NPC.instance.story.Vars.GetMember("happiness"));
                            Debug.Log(NPC.instance.story.Vars.GetMember("hunger"));
                            Debug.Log(NPC.instance.story.Vars.GetMember("tiredness"));
                            Debug.Log(NPC.instance.story.Vars.GetMember("goal"));
                            isShow = false;

                       }*/
            if(isFromScene)
            {
                Debug.Log("in tag check");
                
                switch (NPC.instance.story.Vars.GetMember("fromScene").ToString())
                {
                    case "Player Workout":
                        stopTwin();
                        player.transform.position=SaveVar.instance.goToPositions[1].position;
                        isFromScene = false;
                        break;
                    case "Player Resting":
                        isFromScene = false;
                        break;
                    case "Player Practice":
                        isFromScene = false;
                        break;
                    case "Player Eating":
                        isFromScene = false;
                        break;
                    case "Player Outing":
                        isFromScene = false;
                        break;
                }

            }
        }
    }

    public override void OnTriggerExit(Collider other) {
        if (other.gameObject == player)     //player has exited trigger
        {
            //hide interact message as player may not have been looking at object when they left
            stopTwin();
            ShowMassage.instanse.showMassage = true;
            isClicked = false;
        }
    }

    void stopTwin()
    {
        showInteractMsg = false;
        background.SetActive(false);
        TestConverstion.SetActive(false);
        NPC.instance.ShotDown();
    }
}
