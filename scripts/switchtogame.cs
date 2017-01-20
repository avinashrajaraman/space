using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class switchtogame : MonoBehaviour {

    /*IEnumerator Start()
     {
       // DialogueSystemManager.Instance.StartDialogueForNpc("lol");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("lol");
    }*/

     // Update is called once per frame
     void Update()
     {
         if (Input.GetKeyDown(KeyCode.Space))

         {
             //Application.LoadLevel("lol");
             SceneManager.LoadScene("lol");
         }
     }


   /* IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("lol");
    }*/
}
