using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var btn = GetComponent<UnityEngine.UI.Button>();
        btn.onClick.AddListener(OnClick); // Observer pattern
    }

    void OnClick()
    {
        var input = FindObjectOfType<TMP_InputField>();
        int sceneNumber = int.Parse(input.text);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNumber);
    }
}
