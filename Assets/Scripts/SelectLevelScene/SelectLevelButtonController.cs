﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Each LevelButton in SelectLevel scene should have this script attached.
/// </summary>
public class SelectLevelButtonController : MonoBehaviour
{
    public int levelNum;
    private Button selectLevelButton;
    private TextMeshProUGUI textView;

    private void Start()
    {
        selectLevelButton = GetComponent<Button>();
        textView = GetComponentInChildren<TextMeshProUGUI>();
        SetText();
        if (!LevelManager.IsLevelUnlocked(levelNum))
        {
            selectLevelButton.interactable = false;
            textView.alpha = textView.alpha / 2;
        }
    }

    private void SetText()
    {
        textView.text = "<" + "Level " + levelNum.ToString() + ">";
    }

    /// <summary>
    /// This method is called when user wants to load level which this button represents.
    /// </summary>
    public void LoadLevel()
    {
        LevelManager.LoadLevel(levelNum);
    }
}
