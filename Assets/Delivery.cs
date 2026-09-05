using UnityEngine;

public class Delivery : MonoBehaviour
{
   
   void OnTriggerEnter2D(Collider2D collision)
   {
      if(collision.CompareTag("Package"))
      {
         Debug.Log("Package delivered!");
      }
      else
      {
         Debug.Log("You need to deliver a package!");
      }
   }
}
