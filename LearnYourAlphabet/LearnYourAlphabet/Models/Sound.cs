using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourAlphabet.Models
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = String.Format("/AppSoundsAndImages/Audio/{0}/{1}.mp3", category, name);
            ImageFile = String.Format("/AppSoundsAndImages/Images/{0}/{1}.jpg", category, name);
        }

    }

    public enum SoundCategory
    {
        MyAbcd
    }
}