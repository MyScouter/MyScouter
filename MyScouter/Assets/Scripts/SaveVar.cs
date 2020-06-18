using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveVar : MonoBehaviour
{
    #region Singleton
    public static SaveVar instance;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance != null)
            return;
        instance = this;
    }

    #endregion

    public Transform[] goToPositions;
}
