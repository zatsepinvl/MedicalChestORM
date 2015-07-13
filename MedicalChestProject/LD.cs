using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalChestProject
{
    public enum Language
    {
        English,
        Russian
    }

    public enum Word
    {
        Disease,
        Doctor,
        Name,
        Info,
        Storage,
        Doctors_prescription,
        Drug,
        User,
        Application_type,
        Storage_info,
    }
    public static class LD
    {
        public static string Drug = dictionary[CurrentLan][Word.Drug];
        public static Language CurrentLan { get; set; }
        static Dictionary<Language, Dictionary<Word, string>> dictionary = new Dictionary<Language,Dictionary<Word,string>>();
        static Dictionary<Word, string> russian = new Dictionary<Word, string>();

        public static void Init()
        {
            CurrentLan = Language.Russian;
            InitRussian();
            dictionary[Language.Russian] = russian;
        }
        private static void InitRussian()
        {
            russian.Add(Word.Disease, "Болезнь");
            russian.Add(Word.Doctor, "Доктор");
            russian.Add(Word.Drug, "Лекарство");
            russian.Add(Word.User, "Пользователь");
            russian.Add(Word.Doctors_prescription, "Назначение врача");
            russian.Add(Word.Storage, "Место хранения");
            russian.Add(Word.Info, "Информация");
            russian.Add(Word.Name, "Название");
        }

        public static string GetWord(Word w)
        {
            return dictionary[CurrentLan][w];
        }
        
    }
}
