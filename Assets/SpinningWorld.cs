using UnityEngine;
using UnityEngine.UI;

public class SpinningWorld : MonoBehaviour {
	
	public Slider Slider;
	public bool Paused = false;
	public KeyCode PauseKey = KeyCode.P;
	public Text PauseText;

	void Start()
	{
		PauseText.text = Paused ? "Paused" : "";
	}

	void Update()
	{
		if (Input.GetKeyUp(PauseKey)) {
			Paused = !Paused;
			PauseText.text = Paused ? "Paused" : "";
		}
	}

	void FixedUpdate () {
		if (!Paused)
			transform.RotateAround(Vector3.zero, Vector3.up, Slider.value * Time.fixedDeltaTime * 360);
	}
}
