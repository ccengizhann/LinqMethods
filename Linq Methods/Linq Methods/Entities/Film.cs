using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Methods.Entities
{
    public class Film: IEquatable<Film>
    {
        public Film(string name, int publishYear, string mainActor)
        {
            Name = name;
            PublishYear = publishYear;
            MainActor = mainActor;
        }

        public string Name { get; set; }
        public int PublishYear { get; set; }
        public string MainActor { get; set; }

        public bool Equals(Film other)
        {
            
            if (Object.ReferenceEquals(other, null)) return false;

            if (Object.ReferenceEquals(this, other)) return true;


            return PublishYear.Equals(other.PublishYear) && Name.Equals(other.Name) && MainActor.Equals(other.MainActor);
        }

        public override int GetHashCode()
        {
            int hashFilmName = Name == null ? 0 : Name.GetHashCode();
            int hashFilmPublishYear = PublishYear.GetHashCode();
            int hashFilmMainActor = MainActor?.GetHashCode() ?? 0;

            return hashFilmName ^ hashFilmPublishYear ^ hashFilmMainActor;
        }
    }

}

