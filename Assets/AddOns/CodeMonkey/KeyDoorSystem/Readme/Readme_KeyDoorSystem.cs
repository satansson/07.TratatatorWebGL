﻿/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System;
using UnityEngine;

//[CreateAssetMenu(fileName = "Readme", menuName = "ScriptableObjects/Create Readme", order = 1)]
public class Readme_KeyDoorSystem : ScriptableObject {

	public Texture2D codeMonkeyHeader;
	public string title;
    public string titlesub;
	public bool loadedLayout;
	public Section[] sections;
	
	[Serializable]
	public class Section {
		public string heading, linkText, url;
        public string[] textLines;
	}

    /*
     * Hi there!
     * Here is a really interesting System to add to your <b>Microgame!</b>
     * This System allows you to place Keys in your Levels, pick them up with your Player and Open Doors with specific Keys.
     * 
     * Video Tutorial
     * https://www.youtube.com/watch?v=MIt0PJHMN5Y
     * 
     * Getting Started Guide
     * 1. Drag the "KeyPrefab Red" onto your Level
     * 2. Drag the "DoorPrefab Red" onto your Level
     * 3. Select the "Player" Game Object and Add the "DoorKeyHolder" Script
     * Optional: Drag the DoorKeyUI onto GameManager > GameHUD > HUD and Drag the Player onto the DoorKeyHolder field
     * 4. Play the Game, move towards the Key to pick it up, move towards the Door to Open it
     * 
     * 
     * If you like this Microgame Add-On please write a review on the Asset Store page, I'd love to hear your thoughts!
     * Hope you find it useful and best of luck with your games!
     * - Code Monkey
     * https://youtube.com/c/CodeMonkeyUnity
     * 
     * */
}
