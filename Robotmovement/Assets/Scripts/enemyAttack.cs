using UnityEngine;
using System.Collections;

public class enemyAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider obj)
    {

        if (obj.gameObject.CompareTag("Player"))
        {
            obj.gameObject.GetComponent<PlayerHealth>().GetDamage(1);
            //Debug.Log("Hit !!");
            Destroy(gameObject);

        }

        //Destroy(other.gameObject);
    }
}
