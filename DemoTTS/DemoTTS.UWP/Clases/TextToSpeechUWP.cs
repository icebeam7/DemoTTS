using System;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;

using DemoTTS.UWP.Clases;
using DemoTTS.Interfaces;

[assembly: Dependency(typeof(TextToSpeechUWP))]
namespace DemoTTS.UWP.Clases
{
    public class TextToSpeechUWP : ITextToSpeech
    {
        public async void Speak(string text)
        {
            var mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            var stream = await synth.SynthesizeTextToStreamAsync(text);

            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
