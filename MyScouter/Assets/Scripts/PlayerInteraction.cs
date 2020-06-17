using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : Interaction
{
    bool isShow=true;
    bool isFromScene = true;
    public float restTime=15f;
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
                //Debug.Log(NPC.instance.story.Vars.GetMember("fromScene").ToString());
                
                switch (NPC.instance.story.Vars.GetMember("fromScene").ToString())
                {
                    case "Player Workout":
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        player.transform.position=SaveVar.instance.goToPositions[1].position;
                        isFromScene = false;
                        break;
                    case "Player Resting":
                        Debug.Log("Player Resting");
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(CameraControler.instance.showScene(restTime));
                        isFromScene = false;
                        break;
                    case "Player Practice":
                        isFromScene = false;
                         stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(StreamVideo.instance.playVideo());
                        break;
                    case "Player Eating":
                        isFromScene = false;
                        break;
                    case "Player Outing":
                        isFromScene = false;
                        break;
                }
                TextController.instance.updateScore = true;
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
