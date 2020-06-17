using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    #region singelton
    public static CameraControler instance;
    private void Awake()
    {
        if (instance != null)
            return;
        instance = this;
    }

    #endregion
    public GameObject firstPersonCamera;
    public GameObject [] overheadCamera;


    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowSecondScene(int num)
    {
        firstPersonCamera.SetActive(false);
        overheadCamera[num].SetActive(true);
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView(int num)
    {
        firstPersonCamera.SetActive(true);
        overheadCamera[num].SetActive(false);
    }

     public IEnumerator showScene(float waitTime,int num)
    {
        ShowSecondScene(num);
        yield return new WaitForSeconds(waitTime);
        ShowFirstPersonView(num);

    }
}
