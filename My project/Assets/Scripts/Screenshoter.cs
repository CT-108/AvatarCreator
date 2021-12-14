using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Screenshoter : MonoBehaviour
{
    public GameObject SaveButton;
    bool Hidden = false;
    public void OnMouseClickSaveButton()
    {
        StartCoroutine(Screenshot());

    }

    IEnumerator Screenshot()
    {
        SaveButton.SetActive(false);
        ScreenCapture.CaptureScreenshot(Path.Combine(Application.persistentDataPath, SaveUsername.username + ".png"));
        Hidden = true;
        Debug.Log(Path.Combine(Application.persistentDataPath, "Character.png"));
        yield return new WaitForSeconds(1f);
        SaveButton.SetActive(true);


    }

}