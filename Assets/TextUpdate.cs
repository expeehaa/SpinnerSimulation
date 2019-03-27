using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour {

	public Slider Slider;

	private Text Text;
	
	void Start () {
		Text = GetComponent<Text>();
		SetFrequencyText();
	}

	public void OnSliderValueChanged()
		=> SetFrequencyText();

	private void SetFrequencyText()
		=> Text.text = $"{Slider.value:F1} Hz";
}
