using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;

    private void Awake()
    {
        slider.onValueChanged.AddListener(ChangeSliderText);
    }

    private void ChangeSliderText(float text)
    {
        sliderText.text = text.ToString("0.00");
    }
}
