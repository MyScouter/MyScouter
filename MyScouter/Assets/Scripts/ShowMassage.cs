
using UnityEngine;

public class ShowMassage : MonoBehaviour
{
    #region singleton
    public static ShowMassage instanse;
    private void Awake()
    {
        setupGui();
        if (instanse != null)
            return;
        instanse = this;
    }
    #endregion
    private GUIStyle guiStyle;

    private string msg;

    public bool showMassage=true;


    #region GUI Config

    //configure the style of the GUI
    private void setupGui()
    {
        guiStyle = new GUIStyle();
        guiStyle.fontSize = 50;
        guiStyle.fontStyle = FontStyle.Bold;
        guiStyle.normal.textColor = Color.white;
        msg = "Please go talk to the Player";
    }


    void OnGUI()
    {
        if (showMassage)  //show on-screen prompts to user for guide.
        {
            GUI.Label(new Rect(50, Screen.height - 50, 200, 50), msg, guiStyle);
        }
    }
    #endregion
}
