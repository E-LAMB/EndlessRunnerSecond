using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public int send_to = 0;

    private void OnTriggerEnter2D(Collider2D collison)
    {
        
        if (collison.gameObject.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(send_to);
        }

    }
}
