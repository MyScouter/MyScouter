using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
     public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        TextMesh t = text.AddComponent<TextMesh>();
        t.text = "new text set";
        t.fontSize = 30;
        t.transform.localEulerAngles += new Vector3(0, 0, 0);
        //t.transform.localPosition += new Vector3(56f, 3f, 40f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
