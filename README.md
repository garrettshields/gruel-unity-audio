# **About**
A simple 2D audio system that can manage both sound effects and music.

## Features:
* Reusable `SfxData` and `MusicData` data files so specific settings only have to be set once per effect / song.
* Mute SFX / Music.
* Randomize Sfx audio / pitch within ranges.
* Lerp Sfx volume / pitch within ranges.
* Looping Sfx.

# **AudioController**
Type: `Component`  
Description: AudioController is a singleton component that manages playing sound effects and music.  

## Setup
The AudioController system has a few requirements to work:

### 1. AudioSourceContainer
AudioController needs a reference to a GameObject where it will automatically add a number of `AudioSource` components on initialization. These will be used for playing various Sfx and music.

Drag a reference to a GameObject to the `AudioSourceContainer` serialized field.

### 2. AudioMixerGroups
The AudioController component has two serialized fields for AudioMixerGroups. One for Sfx and one for music. These will be used for adjusting volume (in the future), and muting/un-muting.

This means that the AudioMixerGroup chosen for your SfxData/MusicData files should either be the same one chosen here, or a child of it.

Drag a reference to the AudioMixerGroup assets that you would like to use to both `SfxAudioMixerGroup` and `MusicAudioMixerGroup` respectively.

### 3. Initialization
The AudioController system must be manually initialized by calling it's `Init()` method.

## API
### Sfx API
* Properties:
  * `bool` SfxEnabled
  * `int` MaxSfxSources
  * `AudioMixerGroup` SfxAudioMixerGroup

* Methods:
  * `int` PlaySfx(`SfxData` sfxData, `float` delay = 0.0f)
  * StopSfx(`int` audioSourceId)
  * `bool` IsSfxPlaying(`int` audioSourceId)

### Music API
* Properties:
  * `bool` MusicEnabled
  * `AudioMixerGroup` MusicAudioMixerGroup
  * `float` MusicFadeDuration

* Methods:
  * PlayMusic(`MusicData` musicData)
  * StopMusic()

# **SfxData**
Type: `ScriptableObject`  
Asset creation menu: `Create/Gruel/SfxData  `
Description: SfxData is a scriptable object for storing data related to how a specific sound effect should be played. This means that you can set your settings and do tweaks in just one spot,rather than everywhere that audio clip needs to be played.

When telling the AudioController to play a sound effect, an SfxData file must be passed in.

# **MusicData**
Type: `ScriptableObject`  
Asset creation menu: `Create/Gruel/MusicData`    
Description: MusicData is a scriptable object for storing data related to how a music file should be played.

When telling the AudioController to play a sound effect, a MusicData file must be passed in.