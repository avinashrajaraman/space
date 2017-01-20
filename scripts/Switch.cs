using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{

    /*public void ModeSelect()
    {
        StartCoroutine("Wait");
    }*/

    /*IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("lol5");
    }*/
        // Use this for initialization
          void Start()
       {

       }

       // Update is called once per frame
       void Update()
       {
           if (Input.GetKeyDown(KeyCode.Space))

           {
               
               SceneManager.LoadScene("lol5");
           }
       }
    }
