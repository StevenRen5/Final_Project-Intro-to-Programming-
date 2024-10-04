using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structs
{
    public struct SoundEffects
    {
        public const string donut = "Donut";
        public const string sushi = "Sushi";
        public const string heart = "Heart";
        public const string death = "Death";
        public const string checkpoint = "Checkpoint";
    }
    public struct Tags
    {
        public const string deathTag = "Death";
        public const string healthTag = "Health";
        public const string donutTag = "Donut";
        public const string sushiTag = "Sushi";
        public const string respawnTag = "Respawn";
        public const string finishTag = "Finish";
        public const string respawnColPoint = "Point";
        public const string playerTag = "Player";
    }

    public struct UI
    {
        public const string heartImage = "HeartImage";
        public const string donutText = "DonutText";
        public const string donuts = "Donuts";
        public const string sushis = "Sushis";
        public const string panel = "Panel";
        public const string sfxSlider = "SFXSlider";
        public const string musicSlider = "MusicSlider";

    }

    public struct Scenes
    {
        public const string menu = "MenuLevel";
        public const string firstLevel = "TestLevel";
    }

    public struct Mixers
    {
        public const string sfxVolume = "SFXVolume";
        public const string musicVolume = "MusicVolume";
    }
    public struct GameObjects
    {
        public const string talkIcon = "TalkIcon";
        public const string talkText = "TalkText";
        public const string talkPanel = "TalkPanel";
    }
}
