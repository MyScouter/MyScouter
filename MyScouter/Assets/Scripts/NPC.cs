
using UnityEngine;
using Cradle;
public class NPC : MonoBehaviour
{
    #region singelton
    public static NPC instance;
    private void Awake()
    {
        if (instance != null)
            return;
        instance = this;
    }

    #endregion

    [SerializeField]
    private string startPassage;
    public string currentPassage;

    //[SerializeField]
    public Story story;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        //currentPassage = SaveVar.instance.currentPassage;
        currentPassage = startPassage;

    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            currentPassage = story.CurrentPassage.Name;
            
        }
    }
    public void GoToPassage()
    {
        story.GoTo(currentPassage);
    }
    public void Active()
    {
        active = true;
    }
    public void ShotDown()
    {
        active = false;
    }

}
