using MongoDB.Bson;
using MoviesDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataService
{
    static class DataHelper
    {
        static private readonly List<string> _moviesCollectionItems = new List<string>
        {
            "tytul",
            "rok_wydania",
            "dlugosc_trwania",
            "rezyseria",
            "gatunek",
            "krotki_opis"
        };

        static private readonly List<string> _commentsCollectionItems = new List<string>
        {
            "Imie",
            "Nazwisko",
            "Email",
            "Nazwa_filmu",
            "Tresc"
        };

        static private readonly List<string> _usersCollectionItems = new List<string>
        {
            "Imie",
            "Nazwisko",
            "Email",
            "Haslo"
        };

        static public void FillFilterComboBox(mainWindowForm._checkChoice check, ComboBox filterComboBox)
        {
            if (check.ToString() == "Movies")
                foreach (var item in _moviesCollectionItems)
                {
                    filterComboBox.Items.Add(item);
                }
            else if (check.ToString() == "Comments")
                foreach (var item in _commentsCollectionItems)
                {
                    filterComboBox.Items.Add(item);
                }
            else if (check.ToString() == "Users")
                foreach (var item in _usersCollectionItems)
                {
                    filterComboBox.Items.Add(item);
                }
        }

    }
}
