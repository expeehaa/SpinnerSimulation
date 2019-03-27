using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour {

	public KeyCode LowerKey = KeyCode.LeftArrow;
	public KeyCode UpKey = KeyCode.RightArrow;
	public float StepWidth = 0.1f;

	private Slider Slider;

	private void Start()
	{
		Slider = GetComponent<Slider>();
	}
	
	void Update () {
		var mult = Input.GetKeyUp(UpKey) ? 1 : Input.GetKeyUp(LowerKey) ? -1 : 0;

		if (mult != 0) {
			Slider.value += mult * StepWidth;

			if (Slider.value < Slider.minValue)
				Slider.value = Slider.minValue;
			else if (Slider.value > Slider.maxValue)
				Slider.value = Slider.maxValue;
		}
	}
}
