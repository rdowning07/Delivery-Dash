using UnityEngine;

public class Collision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
   {
      Debug.Log("Oops, you hit something!");
   }

   void OnTriggerEnter2D(Collider2D collision)
   {
      Debug.Log("You made it to the goal!");
   }
}
