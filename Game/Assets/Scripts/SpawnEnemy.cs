using System.Collections;
using UnityEngine;


public class SpawnEnemy : MonoBehaviour
{
	public GameObject enemyPrefab;
	public float startingInterval, minimumInterval, intervalPercentDampening;
	public float minX, maxX, minY, maxY;

	[SerializeField] private float interval;

   void Start()
   {
	   interval = startingInterval;
	   StartCoroutine(SpawnBalls());
   }
  

   IEnumerator SpawnBalls()
   {
	   while (true)
	   {
		   yield return new WaitForSeconds(interval);
		   //Debug.Log("Updating now: " + interval);
		   interval = (interval - minimumInterval) * intervalPercentDampening + minimumInterval;
		   float randX = Random.Range(minX, maxX);
		   float randY = Random.Range(minY, maxY);
		   Vector3 spawnPos = new Vector3(randX, randY, 0f);
		   Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
	   }
   }
}
