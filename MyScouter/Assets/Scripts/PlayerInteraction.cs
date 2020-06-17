using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : Interaction
{
    bool isShow=true;
    bool isFromScene = true;
    public float restTime=15f;
    public float workoutTime = 10f;
    public float dancingTime = 10f;

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
            if(isFromScene)
            {
                Debug.Log(NPC.instance.story.Vars.GetMember("fromScene").ToString());

                Debug.Log(NPC.instance.currentPassage);
                switch (NPC.instance.story.Vars.GetMember("fromScene").ToString())
                {
                    case "Player Workout":
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(CameraControler.instance.showScene(workoutTime, 2));
                        isFromScene = false;
                        resetVar();
                        break;
                    case "Player Resting":
                        Debug.Log("Player Resting");
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(CameraControler.instance.showScene(restTime,0));
                        isFromScene = false;
                        resetVar();
                        break;
                    case "Player Practice":
                        isFromScene = false;
                         stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(StreamVideo.instance.playVideo());
                        resetVar();
                        break;
                    case "Player Eating":
                        isFromScene = false;
                        resetVar();
                        break;
                    case "Player Outing":
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(CameraControler.instance.showScene(dancingTime, 1));
                        isFromScene = false;
                        resetVar();
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
    void resetVar()
    {
        TextController.instance.updateScore = true;
        NPC.instance.currentPassage = "After Activity";
        NPC.instance.story.Vars.SetMember("fromScene", "");
        isClicked = false;
        isFromScene = true;
    }
}
