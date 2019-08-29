using UnityEngine;
using UnityEngine.Audio;

namespace Gruel.Audio {
	[CreateAssetMenu(menuName = "Gruel/SfxData")]
	public class SfxData : ScriptableObject {

#region Properties
		public AudioClip AudioClip => _audioClip;
		public float Volume => _volume;
		public float Pitch => _pitch;
		public bool Loop => _loop;
		public int MaxSources => _sourcesMax;
		public AudioMixerGroup AudioMixerGroup => _mixerGroup;

		public bool VolumeLerpEnabled => _volumeLerpEnabled;
		public float VolumeEnd => _volumeEnd;
		public float VolumeLerpTime => _volumeLerpTime;

		public bool VolumeRndEnabled => _volumeRndEnabled;
		public float VolumeRndMin => _volumeRndMin;
		public float VolumeRndMax => _volumeRndMax;

		public bool PitchLerpEnabled => _pitchLerpEnabled;
		public float PitchEnd => _pitchEnd;
		public float PitchLerpTime => _pitchLerpTime;

		public bool PitchRndEnabled => _pitchRndEnabled;
		public float PitchRndMin => _pitchRndMin;
		public float PitchRndMax => _pitchRndMax;
#endregion Properties

#region Fields
		[Header("SFX")]
		[SerializeField] private AudioClip _audioClip;
		[SerializeField] private float _volume = 1.0f;
		[SerializeField] private float _pitch = 1.0f;
		[SerializeField] private bool _loop;
		[SerializeField] private int _sourcesMax = 8;
		[SerializeField] private AudioMixerGroup _mixerGroup;

		[Header("Volume Lerp")]
		[SerializeField] private bool _volumeLerpEnabled;
		[SerializeField] private float _volumeEnd;
		[SerializeField] private float _volumeLerpTime;

		[Header("Volume Rnd")]
		[SerializeField] private bool _volumeRndEnabled;
		[SerializeField] private float _volumeRndMin;
		[SerializeField] private float _volumeRndMax;

		[Header("Pitch Lerp")]
		[SerializeField] private bool _pitchLerpEnabled;
		[SerializeField] private float _pitchEnd;
		[SerializeField] private float _pitchLerpTime;

		[Header("Pitch Rnd")]
		[SerializeField] private bool _pitchRndEnabled;
		[SerializeField] private float _pitchRndMin;
		[SerializeField] private float _pitchRndMax;
#endregion Fields
		
#region Public Methods
		public static bool IsValid(SfxData sfxData) {
			return (sfxData != null) && (sfxData._audioClip != null);
		}
#endregion Public Methods

	}
}