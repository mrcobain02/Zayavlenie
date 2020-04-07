using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var name = NAME.Text;
            var date = Date.Value.ToShortDateString();
            var group = Group.Text;

            var wordApp = new word.Application();
            wordApp.Visible = true;
            var wordDocument = wordApp.Documents.Open(@"");// Укажите путь к документу word

            if (NAME.Text == "Летов Егор Федорович")
            {
                Replacingtext("{ФИО1}", "Летова Егора Юрьевича", wordDocument);
                Replacingtext("{ФИО2}", "Летову.Е.Ю", wordDocument);
                Replacingtext("{ФИО3}", "Летов.Е.Ю", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);
            }
            if(NAME.Text == "Жуков Сергей Александрович")
            {
                Replacingtext("{ФИО1}", "Жукова Сергея Александровича", wordDocument);
                Replacingtext("{ФИО2}", "Жукову.С.А", wordDocument);
                Replacingtext("{ФИО3}", "Жуков.С.А", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);

            }
            if(NAME.Text =="Иванов Иван Алексеевич")
            {
                Replacingtext("{ФИО1}", "Иванова Ивана Алексеевича", wordDocument);
                Replacingtext("{ФИО2}", "Иванову.И.А", wordDocument);
                Replacingtext("{ФИО3}", "Иванов.И.А", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);
            }
            
        }
        // замена текста в документе
        private void Replacingtext(string stubToReplace, string text, word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
