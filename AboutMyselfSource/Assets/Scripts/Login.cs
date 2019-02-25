using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {
    public AGCC ag;
    public InputField account;
    public InputField password;

    public void Click()
    {
        ag.ArcaletLaunch(account.text, password.text);
    }
}
