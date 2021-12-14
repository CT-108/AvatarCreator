using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveUsername : MonoBehaviour
{
    public static string username;
    public Text TextName;

    public void test()
    {
        username = TextName.text;
    }
}
