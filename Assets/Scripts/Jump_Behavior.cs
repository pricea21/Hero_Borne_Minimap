using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Behavior : MonoBehaviour
{
    public float BoostMultiplier = 2f;
    public float BoostSeconds = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.transform.parent.gameObject);
        Debug.Log("Jump BOOST!");

        Player_Behavior Player = collision.gameObject.GetComponent<Player_Behavior>();
        Player.JumpBoost(BoostMultiplier, BoostSeconds);
    }
}