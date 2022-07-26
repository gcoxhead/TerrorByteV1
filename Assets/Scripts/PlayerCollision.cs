using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    
    public int floppyScore = 2;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Floppy")
        {
            //byteScore += floppyScore;
            Debug.Log("Something Collided");
        }
       // if (collisionInfo.collider.tag == "USB")
       // {
         //   byteScore += 32;
      //  }

       //  if (collisionInfo.collider.tag == "HDD")
        //{
        //    byteScore += 500;
        //}
    
    }
}