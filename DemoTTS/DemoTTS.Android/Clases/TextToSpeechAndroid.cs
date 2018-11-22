using Android.Speech.Tts;
using Xamarin.Forms;

using DemoTTS.Droid.Clases;
using DemoTTS.Interfaces;

[assembly: Dependency(typeof(TextToSpeechAndroid))]
namespace DemoTTS.Droid.Clases
{
    public class TextToSpeechAndroid : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech tts;
        string message;

        public void Speak(string text)
        {
            message = text;

            if (tts == null)
                tts = new TextToSpeech(MainActivity.Instance, this);
            else
                tts.Speak(text, QueueMode.Flush, null, null);
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
                tts.Speak(message, QueueMode.Flush, null, null);
        }
    }
}