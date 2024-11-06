using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    // структура Song
    struct Song
    {
        // Публичные поля структуры
        public string author;
        public string title;
        public string filename;

        public Song (string author, string title, string filename)
        {
            this.author = author;
            this.title = title;
            this.filename = filename;
        }

    }
}
