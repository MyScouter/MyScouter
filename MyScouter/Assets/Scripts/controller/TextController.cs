
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    #region singelton
    public static TextController instance;
    private void Awake()
    {
        if (instance != null)
            return;
        instance = this;
    }

    #endregion

    public bool isInstantiated;
    public bool updateScore;
    public Text motivation;
    public Text physicalShape;
    public Text happiness;
    public Text hunger;
    public Text tiredness;
    public Text goal;
    public Text money;
    // Start is called before the first frame update
    void Start()
    {
        isInstantiated = false;
        updateScore = true;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (isInstantiated)
        {
            if (updateScore)
            {
                motivation.text = "Motivation: " + NPC.instance.story.Vars.GetMember("motivation").ToString();
                physicalShape.text = "Shape: " + NPC.instance.story.Vars.GetMember("physicalShape").ToString();
                happiness.text = "Happiness: " + NPC.instance.story.Vars.GetMember("happiness").ToString();
                hunger.text = "Hunger: " + NPC.instance.story.Vars.GetMember("hunger").ToString();
                tiredness.text = "Tiredness: " + NPC.instance.story.Vars.GetMember("tiredness").ToString();
                updateScore = false;
            }
            money.text = "Money: " + NPC.instance.story.Vars.GetMember("moneyAmount").ToString();
            //TODO: CHECK IF THE GOAL CHANGE
            goal.text = "Goal: " + NPC.instance.story.Vars.GetMember("goal").ToString();
        }
    }
}
