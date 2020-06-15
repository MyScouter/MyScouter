using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PhoneInteraction : Interaction
{
    
    private void Awake() {
        base.isClicked = false;
        base.setupGui();
    }

}
