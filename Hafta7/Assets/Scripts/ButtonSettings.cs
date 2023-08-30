using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject PausePanel;

    public void PauseButtonOnClick()
    {
        PausePanel.gameObject.SetActive(true);
    }

    public void ContinueOnClick()
    {
        PausePanel.gameObject.SetActive(false);
    }

    public void RetryOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
