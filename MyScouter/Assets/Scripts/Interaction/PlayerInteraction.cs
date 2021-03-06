﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : Interaction
{
   // bool isShow=true;
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

            msg = "Press F to start conversation";
            showInteractMsg = true;
            if (Input.GetKey(KeyCode.F) && !isClicked)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                MouseLook.enabled = false;
                background.SetActive(true);
                TestConverstion.SetActive(true);
                NPC.instance.Active();
                NPC.instance.GoToPassage();
                isClicked = true;
            }
            if(isFromScene)
            {
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
                        StartCoroutine(StreamVideo.instance.playVideo(-1));
                        resetVar();
                        break;
                    case "Player Eating":
                        isFromScene = false;
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(StreamVideo.instance.playVideo(4));
                        resetVar();
                        break;
                    case "Player Outing":
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        StartCoroutine(CameraControler.instance.showScene(dancingTime, 1));
                        isFromScene = false;
                        resetVar();
                        break;
                    case "Player Game":
                        Debug.Log("Player Game");
                        stopTwin();
                        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                        if(NPC.instance.story.Vars.GetMember("isWin") == true)
                        {
                            
                            StartCoroutine(StreamVideo.instance.playVideo(5));
                            NPC.instance.currentPassage = "Game Won";
                            NPC.instance.GoToPassage();
                            // play winning game video and go to scene "Game Won"
                            // need to check if change logic in twine to go automaticaly to calculate goal
                            // or leave as is - go when player clicks
                        }
                        else
                        {
                            StartCoroutine(StreamVideo.instance.playVideo(6));
                            NPC.instance.currentPassage = "Game Lost";
                            NPC.instance.GoToPassage();
                            // play loosing game video and go to scene "Game Lost"
                            // same check as win
                        }
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
            msg = "PLEASE GO TALK TO THE PLAYER";
            stopTwin();
            MouseLook.enabled = true;
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
        MouseLook.enabled = true;
        isClicked = false;
        isFromScene = true;
        player.SetActive(false);
        player.transform.position = moveTo.position;
        player.SetActive(true);
    }
}
