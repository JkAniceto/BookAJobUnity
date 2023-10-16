using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterAccountWorker : MonoBehaviour
{
    public void ButtonWorkerRegisterForm()
    {
        SceneManager.LoadScene("RegisterWorkerAccount");
    }

    public void ButtonNext()
    {
        SceneManager.LoadScene("WorkerInformation");
    }
    public void ButtonBookerRegisterForm()
    {
        SceneManager.LoadScene("RegisterBookerAccount");
    }
}
