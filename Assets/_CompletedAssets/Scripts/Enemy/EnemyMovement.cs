using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
	Transform player;
	// Reference to the player's position.
	NavMeshAgent nav;
	// Reference to the nav mesh agent.

	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform; 

//			Do not use FindGameObjectWithTag() method if the scene hierarchy is too big. 
//			In such case, declare 'player' as a public variable & set reference from the inspector.

		nav = GetComponent <NavMeshAgent> ();

	}

	void Update ()
	{
		// Set the destination of the nav mesh agent to the player.
		nav.SetDestination (player.position);
	}
}
