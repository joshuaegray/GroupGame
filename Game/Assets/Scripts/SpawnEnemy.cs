using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SpawnEnemy : MonoBehaviour
{
	public GameObject[] enemyPrefabs;
	public float[] positions;


	public int spawningSpeed;
	

	private IDictionary<float, GameObject> levelLayout = new Dictionary<float, GameObject>();
	private int i;



	void Start()
	{
		i = 0; 
	   for (int i = 0; i < enemyPrefabs.Length; i++)
	   {
		   levelLayout.Add(positions[i], enemyPrefabs[i]);
	   }
	   StartCoroutine(SpawnBalls());

   }


	
	

	
   IEnumerator SpawnBalls()
   {
	   while (true)
	   {
		   //int enemyNum = Random.Range(0, enemyPrefabs.Length-1);
		

		   Vector3 spawnPos = new Vector3(5, levelLayout.ElementAt(i).Key, 0f);
		   Instantiate(levelLayout.ElementAt(i).Value, spawnPos, Quaternion.identity);
		   i++;
		   if (i == enemyPrefabs.Length)
		   {
			   i = 0;
		   }
		   
		   yield return new WaitForSeconds(spawningSpeed);
		   
	   }

   }
   
   
	 
}
