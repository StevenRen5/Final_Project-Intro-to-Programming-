using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private Image _heartImage; // (Image error): click Image and connect it to Unity_UI
    private TextMeshProUGUI _donutText; // editing the 0/10 coin 
    private TextMeshProUGUI _sushiText; // editing the 0/10 coin 
    private GameObject _menuPanel; // menu panel 
    private Slider _sfxSlider;
    private Slider _musicSlider;

    private int _donutCount = 0; // coint count at the beginning 
    private int _sushiCount = 0; // coint count at the beginning 
    private AudioSourceController _audioSourceController;


    // Start is called before the first frame update
    void Start()
    {
        // Connects UI
        if (GameObject.Find(Structs.UI.heartImage)) // checks for existence of heart objects
            {
            _heartImage = GameObject.Find(Structs.UI.heartImage).GetComponent<Image>(); // heart always shows full when game starts// finds heart imagee in Unity
            HeartImageUpdate(1); 
            }

        if (GameObject.Find(Structs.UI.donutText)) // checks for existence of coin objects
            {
            _donutText = GameObject.Find(Structs.UI.donutText).GetComponent<TextMeshProUGUI>(); //finds coin text in Unity
            }

        if (GameObject.Find(Structs.UI.donuts)) // checks for if there are coins in this level
        {
            _donutCount = GameObject.Find(Structs.UI.donuts).transform.childCount; // counts how many coins in the coins child
            DonutTextUpdate(0); // coin shows 0/# whhen game starts
        }



       
        _sfxSlider = GameObject.Find(Structs.UI.sfxSlider).GetComponent<Slider>();
        _musicSlider = GameObject.Find(Structs.UI.musicSlider).GetComponent<Slider>();
        _menuPanel = GameObject.Find(Structs.UI.panel); // for menu 
       

        _audioSourceController = GameObject.FindAnyObjectByType<AudioSourceController>();


        _menuPanel.SetActive(false); // turns game panel off at the beginning of game
        SetSliders();
   
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)) // player clicks escape, menu panel pops up
        {
            if(_menuPanel.active)
            {
                _menuPanel.SetActive(false);
            }
            else
            {
                _menuPanel.SetActive(true);
            }
        }
    }
    // turns off menu panel
    public void BackButton() 
    {
        _menuPanel.SetActive(false);
    }
    // turns off mennu
    public void OptionsButton()
    {
        _menuPanel.SetActive(true);
    }

    // sneds player to main menu
    public void MenuButton() 
    {
        SceneManager.LoadScene(Structs.Scenes.menu);
    }

    // sends player to first level
    public void FirstLevelButton() 
    {
        SceneManager.LoadScene(Structs.Scenes.firstLevel);
    }

    // updates heart image
    public void HeartImageUpdate(float newAmount)
    {
        _heartImage.fillAmount = newAmount;
    }

    // updates coin text
    public void DonutTextUpdate(int newAmount)
    {
        _donutText.text = newAmount + " / " + _donutCount; 
    }

    // updates sushi context

    public void SushiTextUpdate(int newAmount)
    {
        _sushiText.text = newAmount + " / " + _sushiCount;
    }

    public void SetSliders()
    {
        _sfxSlider.value = PlayerPrefs.GetFloat(Structs.Mixers.sfxVolume);
        _musicSlider.value = PlayerPrefs.GetFloat(Structs.Mixers.musicVolume);
    }

    // updates SFX volume
    public void UpdateSFXSlider()
    {
        _audioSourceController.UpdateSFXGroup(_sfxSlider.value);
    }

    public void UpdateMusicSlider()
    {
        _audioSourceController.UpdateMusicGroup(_musicSlider.value);
    }

}
