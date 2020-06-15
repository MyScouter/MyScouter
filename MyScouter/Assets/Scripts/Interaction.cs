using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
   [SerializeField]
    protected GameObject player;
    protected bool isClicked;
    protected bool showInteractMsg;
    
    protected GUIStyle guiStyle;

    protected string msg;

    private void Awake()
    {
        isClicked = false;
        setupGui();
    }
    
    public virtual void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)     //player has collided with trigger
        {
            showInteractMsg = true;
            if (Input.GetKey(KeyCode.F) && !isClicked)
            {
                isClicked = true;
            }
        }
    }

    public virtual void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)     //player has exited trigger
        {
            //hide interact message as player may not have been looking at object when they left
            showInteractMsg = false;
            isClicked = false;
        }
    }

    private void Update()
    {
      
       
    }


    #region GUI Config
    //configure the style of the GUI
    protected void setupGui()
    {
        guiStyle = new GUIStyle();
        guiStyle.fontSize = 50;
        guiStyle.fontStyle = FontStyle.Bold;
        guiStyle.normal.textColor = Color.white;
        msg = "Press F to start conversation";
    }


    void OnGUI()
    {
        if (showInteractMsg)  //show on-screen prompts to user for guide.
        {
            GUI.Label(new Rect(50, Screen.height - 50, 200, 50), msg, guiStyle);
        }
    }
    #endregion


}
