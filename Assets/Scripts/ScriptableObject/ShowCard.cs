using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowCard : MonoBehaviour
{ 
    public ScriptableCard cards;
    [SerializeField] private TMP_Text _CardName;
    [SerializeField] private TMP_Text _Price;
    [SerializeField] private TMP_Text _Description;
    [SerializeField] private Image _CardImage;
    private void Start()
    {
        _CardName.text = cards._CardName;
        _Description.text = cards._CardDescription;
        _Price.text = cards._CardPrice.ToString();
        _CardImage.sprite = cards._CardPhoto;
    }
}
