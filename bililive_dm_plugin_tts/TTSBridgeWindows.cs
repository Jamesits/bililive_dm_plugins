using System;
using System.Diagnostics;
using System.Speech.Synthesis;

namespace bililive_dm_plugin_tts
{
    class TTSBridgeWindows : ITTSBridge
    {
        private readonly SpeechSynthesizer synth = new SpeechSynthesizer();

        public TTSBridgeWindows()
        {
            // debugging info
            if (Debugger.IsAttached)
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    var info = voice.VoiceInfo;
                    Console.WriteLine($"Id: {info.Id} | Name: {info.Name} | Age: { info.Age} | Gender: { info.Gender} | Culture: { info.Culture}");
                }
            }

            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Huihui Desktop");
        }

        public void ReadDanmaku(BilibiliDM_PluginFramework.DanmakuModel d)
        {
            synth.Speak(Utils.GiftToString(d));
        }
    }
}
