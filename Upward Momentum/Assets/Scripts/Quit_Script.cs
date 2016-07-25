using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quit_Script : MonoBehaviour {

    public Button quitButton;

        void Start () 
        {

            quitButton.onClick.AddListener(() =>
            {
                Application.Quit();
            });
        }
}
