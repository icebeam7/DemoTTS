using AVFoundation;
using Xamarin.Forms;

using DemoTTS.iOS.Clases;
using DemoTTS.Interfaces;

[assembly: Dependency(typeof(TextToSpeechiOS))]
namespace DemoTTS.iOS.Clases
{
    public class TextToSpeechiOS : ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}