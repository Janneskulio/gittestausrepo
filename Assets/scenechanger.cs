using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public void Scene1()
    {
        if(Input.GetKeyDown("Fire1"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
