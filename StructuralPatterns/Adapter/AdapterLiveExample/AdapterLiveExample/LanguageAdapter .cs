using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterLiveExample
{
    public class LanguageAdapter :IEnglishSpeakerNewSystem
    {
        private readonly ArabicSpeaker _arabicSpeaker;

        // Adapter that translates Arabic speech to English
        public LanguageAdapter(ArabicSpeaker arabicSpeaker)
        {
            _arabicSpeaker = arabicSpeaker;
        }

        public string SpeakEnglish()
        {
            // Get Arabic speech from the old system
            string arabic = _arabicSpeaker.SpeakArabic();

            // Translate Arabic to English (simplified example)
            return "Hello, how are you?";
        }
    }
}
