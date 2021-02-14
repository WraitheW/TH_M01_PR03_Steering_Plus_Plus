using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject phone;
    bool phoneActive;
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject evadeButton;

    public bool buttonEvadePressed;
    public bool isEvading;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Start()
    {
        phoneActive = false;
        phone.SetActive(false);
   //     StartCoroutine(evadeCoroutine());

    }

    public void evadeBool()
    {
        if (isEvading == false)
        {
            isEvading = true;
            StartCoroutine(evadeCoroutine());
            evadeButton.SetActive(false);
            buttonEvadePressed = true;
        }
    }

    IEnumerator evadeCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        isEvading = false;
    }

    //void Update()
    //{
    //    Debug.Log(phoneActive);
    //}

    //public void Phone()
    //{
    //    Debug.Log("Checkpoint 1");
    //    if (phoneActive == false)
    //    {
    //        Debug.Log("Checkpoint 2");
    //        phone.SetActive(true);
    //        phoneActive = true;
    //    }
    //    else if (phoneActive == true)
    //    {
    //        Debug.Log("Checkpoint 3");
    //        phoneActive = false;
    //        phone.SetActive(false);
    //    }
    //}
}
