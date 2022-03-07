using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Behavior : MonoBehaviour
{
    public float BoostMultiplier = 2.0f;
    public float BoostSeconds = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("SPEED BOOST!");

            Player_Behavior Player = collision.gameObject.GetComponent<Player_Behavior>();
            Player.BoostSpeed(BoostMultiplier,BoostSeconds);
        }
    }
}
