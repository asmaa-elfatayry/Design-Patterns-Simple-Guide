using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterLiveExample
{
    // New system requirement: the system supports English only
    public interface IEnglishSpeakerNewSystem
    {
        string SpeakEnglish();
    }
}
