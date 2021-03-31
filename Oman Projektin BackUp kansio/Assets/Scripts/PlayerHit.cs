using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    bool isTransitioning = false;

    //tappaa pelaajan ja respawnaantuu uudelleen aloituspaikalle
    private void OnCollisionEnter(Collision other) {
        if (isTransitioning) {return;}

        switch (other.gameObject.tag)
        {
            case "Enemy":
                PlayerDeath();
                break;
            case "Spikes":
                PlayerDeath();
                Debug.Log("You have stepped on spikes. You are dead :(");
                break;
            default:
                break;
        }
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void PlayerDeath()
    {
        isTransitioning = true;
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<MeshRenderer>().material.color = Color.black;
        Invoke ("ReloadLevel", levelLoadDelay);
    }
}
