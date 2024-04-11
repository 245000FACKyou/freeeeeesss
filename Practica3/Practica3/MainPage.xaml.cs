using Xamarin.Forms;
using System.IO;

namespace Practica3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        public void SaveText_Clicked(object sender, StreamWriter e)
        {
            string path = "Test.txt";
            if (!File.Exists(path))
            {
                using (FileStream strm = File.Create(path))
                using (StreamWriter sw = new StreamWriter(strm))
                    sw.WriteLine("The first line!");
            }
        }

        public void OpenText_Clicked(object sender, StreamReader e)
        {
            string path = "Test.txt";
            if (!File.Exists(path))
            {
                using (FileStream strm = File.OpenRead(path))
                using (StreamReader sw = new StreamReader(strm))
                    sw.ReadToEnd();

            }
        }
    }
}
