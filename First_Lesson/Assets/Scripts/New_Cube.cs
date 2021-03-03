using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Cube : MonoBehaviour
{

   //dichiariamo oggetto play sphere prefab
   public GameObject sphereToSpawn;

   private void OnTriggerEnter(Collider other) {
      Debug.Log("A sphere touch the ground");
      Vector3 spawnPosition = other.GetComponent<Manage_collision>().getStartPosition();
      Quaternion spawnRotation = Quaternion.Euler(Vector3.zero); 
      GameObject spawnedSphere = Instantiate(sphereToSpawn,spawnPosition, spawnRotation);
   }


}
