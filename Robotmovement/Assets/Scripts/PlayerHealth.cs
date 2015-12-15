using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	int health;
	int maxHealth;

	bool isDead;

	// Use this for initialization
	void Start () {
		maxHealth = 100;//health = maxHealth;
		health = 3;
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Health: " + health);
	}

	public void GetDamage(int damage){
		health -= damage;
		if(health <= 0 && !isDead){
			Die();
		}
	}

	public void Die(){
		Destroy (gameObject);
		Application.LoadLevel(Application.loadedLevel); 
	}

	public void AddHealth(int heal){
		health += heal;
		if (health >= maxHealth) {
			health = maxHealth;
		}
	}

}
