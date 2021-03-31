using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    [SerializeField] float objectDeleteDelay = 2f;
    private void OnCollisionEnter(Collision other) {

        switch (other.gameObject.tag)
        {
            case "WeaponClub":
                Death();
                Invoke("Despawn", objectDeleteDelay);
                break;
            default:
                break;
        }
    }

    //ns. kuolema animaatio, jonka jälkeen vihollinen despawnaa ruudulta.
    void Death()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        gameObject.tag = "Eliminated";
        transform.Rotate(60f,0,0);
        GetComponent<Rigidbody>().mass = 50f;
        Debug.Log("You killed enemy unit!!");
    }
    void Despawn()
    {
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
    }
}
