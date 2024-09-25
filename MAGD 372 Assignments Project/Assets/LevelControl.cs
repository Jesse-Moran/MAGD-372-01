using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour {

    public int index;
    public string levelName;

    public Image black;
    public Animator anim;

    // This method now detects 3D collisions
    void OnTriggerEnter(Collider Other)
    {
        Debug.Log("OnTriggerEnter");
        if (Other.CompareTag("Player"))
        {
            Debug.Log("Player");
            // Start the fading effect
            StartCoroutine(Fading());
        }
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
