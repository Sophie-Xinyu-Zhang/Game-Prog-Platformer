using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
	[SerializeField] int sceneNum;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene(sceneNum);
	}
}
