using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    // класс Плейлист
    class Playlist
    {
        // поле листа с объектами класса Song
        private List<Song> list;
        // поле индекса для листа
        private int currentIndex;

        // конструктор класса для инициализации полей
        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        // добавление объекта класса в лист
        public void AddSong(string name, string author, string filename)
        {
            Song song = new Song();
            song.title = name;
            song.author = author;
            song.filename = filename;
            list.Add(song);
        }
        // вторая перегрузка для добавления
        public void AddSong(Song song)
        {
            list.Add(song);
        }
        // убираем объект класса из листа по индексу
        public void RemoveSong() {
            list.RemoveAt(currentIndex);
        }
        // очищаем лист класса
        public void ClearSongs()
        {
            list.Clear();
        }
        // вторая перегрузка для удаления объекта класса из листа с помощью нахождения по объекту
        public void RemoveSong(string name, string author, string filename)
        {
            Song song = new Song();
            song.title = name;
            song.author = author;
            song.filename=filename;

            if (list.Contains(song))
            {
                list.Remove(song);
            }
            else
            {
                MessageBox.Show("Такой песни в списке не найдено");
            }
        }
        // Возвращает следующий объект по индексу в листе
        public Song NextSong()
        {
            if (list.Count > currentIndex + 1)
            {
                Song song = list[currentIndex + 1];
                currentIndex++;
                return song;
            }
            else
            {
                Song song = list[0];
                currentIndex = 0;
                return song;
            }

            
        }
        // Возвращает прошлый объект по индексу в листе
        public Song PreviousSong()
        {
            if (currentIndex - 1 >= 0)
            {
                Song song = list[currentIndex - 1];
                currentIndex--;
                return song;
            }
            else
            {
                Song song = list[list.Count - 1];
                currentIndex = list.Count - 1;
                return song;
            }
            
        }
        // выбирает текущий объект класса в листе по выбранному индексу
        public Song SelectSong(int index)
        {
            if (index < list.Count )
            {
                currentIndex = index - 1;
                Song song = list[currentIndex];
                return song;
            }
            else
            {
                MessageBox.Show("Такой песни тута нету!");
                Song song = CurrentSong();
                return song;
            }

           
        }
        // возвращает размер листа
        public int GetListCount()
        {
            return list.Count;
        }
        // возвращает песню с текущим индексом
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
    }
}
