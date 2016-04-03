using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourAlphabet.Models
{
    public class SoundDecide
    {


        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            // loop throug all sounds 
            allSounds.ForEach(p => sounds.Add(p));

        }

        public static void GetSoundByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var allSounds = getSounds();
            var filterSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filterSounds.ForEach(p => sounds.Add(p));
        }
        public static List<Sound> getSounds()
        {
            //list of sound
            var sounds = new List<Sound>();
            sounds.Add(new Sound("a", SoundCategory.MyAbcd));
            sounds.Add(new Sound("b", SoundCategory.MyAbcd));
            sounds.Add(new Sound("c", SoundCategory.MyAbcd));
            sounds.Add(new Sound("d", SoundCategory.MyAbcd));
            sounds.Add(new Sound("e", SoundCategory.MyAbcd));
            sounds.Add(new Sound("f", SoundCategory.MyAbcd));
            sounds.Add(new Sound("g", SoundCategory.MyAbcd));
            sounds.Add(new Sound("h", SoundCategory.MyAbcd));
            sounds.Add(new Sound("i", SoundCategory.MyAbcd));
            sounds.Add(new Sound("j", SoundCategory.MyAbcd));
            sounds.Add(new Sound("k", SoundCategory.MyAbcd));
            sounds.Add(new Sound("l", SoundCategory.MyAbcd));
            sounds.Add(new Sound("m", SoundCategory.MyAbcd));
            sounds.Add(new Sound("n", SoundCategory.MyAbcd));
            sounds.Add(new Sound("o", SoundCategory.MyAbcd));
            sounds.Add(new Sound("p", SoundCategory.MyAbcd));
            sounds.Add(new Sound("q", SoundCategory.MyAbcd));
            sounds.Add(new Sound("r", SoundCategory.MyAbcd));
            sounds.Add(new Sound("s", SoundCategory.MyAbcd));
            sounds.Add(new Sound("t", SoundCategory.MyAbcd));
            sounds.Add(new Sound("u", SoundCategory.MyAbcd));
            sounds.Add(new Sound("v", SoundCategory.MyAbcd));
            sounds.Add(new Sound("w", SoundCategory.MyAbcd));
            sounds.Add(new Sound("x", SoundCategory.MyAbcd));
            sounds.Add(new Sound("y", SoundCategory.MyAbcd));
            sounds.Add(new Sound("z", SoundCategory.MyAbcd));

            return sounds;
        }


    }
}
