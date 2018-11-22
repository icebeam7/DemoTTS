using Xamarin.Forms;

using DemoTTS.Interfaces;

namespace DemoTTS.Servicios
{
    public static class ServicioTTS
    {
        public static void Speak(string message)
        {
            var tts = DependencyService.Get<ITextToSpeech>();
            tts.Speak(message);
        }
    }
}