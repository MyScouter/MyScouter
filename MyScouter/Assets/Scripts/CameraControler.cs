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
    public GameObject overheadCamera;


    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowSecondScene()
    {
        firstPersonCamera.SetActive(false);
        overheadCamera.SetActive(true);
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView()
    {
        firstPersonCamera.SetActive(true);
        overheadCamera.SetActive(false);
    }

     public IEnumerator showScene(float waitTime)
    {
        ShowSecondScene();
        yield return new WaitForSeconds(waitTime);
        ShowFirstPersonView();

    }
}
