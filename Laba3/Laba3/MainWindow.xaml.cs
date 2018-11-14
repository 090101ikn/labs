using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       const int N = 100;
       int c = 0;
       Student[] stud = new Student[N];
        public enum Fac
        {
            ITS,
            MP,
            EKT,
            Design,
            InYaz
        };


        class Student
        {
            string lastname;        
            string name;            
            string patronymic;      
            string adres;
            int birthYear;                       
            string Fnumber;
            Fac faculty;
            int styear;
            public Student(string n, string l, string p, int b, string adr, string f, Fac fc, int s)
            {
                name = n;
                lastname = l;
                patronymic = p;                
                if (b < 1900)
                    throw new Exception("Некорректный год рождения!");
                birthYear = b;
                adres = adr;
                Fnumber = f;
                faculty = fc;
                if (s < 0 || s > 4)
                    throw new Exception("Некорректный курс!");
                styear = s;
            }
            public int getbirthYear()
            {
                return birthYear;
            }
            public Fac getfaculty()
            {
                return faculty;
            }
            public int getstyear()
            {
                return styear;
            }
            public string getlastname()
            {
                return lastname;
            }
            public string getname()
            {
                return name;
            }
            public string getpatronymic()
            {
                return patronymic;
            }
            public string getadres()
            {
                return adres;
            }
            public string getFnumber()
            {
                return Fnumber;
            }
            


        }

        public MainWindow()
        {

            InitializeComponent();
            
            stud[0] = new Student("Колосов", "Илюша", "Николаевич", 1999, "Общага", "Айфон ЭС ЙЕ", Fac.ITS, 2);
            stud[1] = new Student("Занять", "Денек", "Александрович", 1998, "Квартира", "88005553535", Fac.MP, 2);
            stud[2] = new Student("Колосов", "КопияИлюши", "ТолькоСтарше", 1996, "Съемная квартира", "Айфон ЭС ЙЕ", Fac.ITS, 3);
            stud[3] = new Student("Крутой", "ДЕсигнер", "Анатольевич", 1997, "Общагу не дали", "Айфон ИКС ЭС", Fac.EKT, 4);
            stud[4] = new Student("Первачок", "Слоник", "Уженешкольник", 2000, "Общага", "Нокиа", Fac.Design, 1);
            c += 5;
            for (int i = 0; i < c; i++)
                Output.Items.Add(stud[i].getlastname() + "\t" + stud[i].getname() + "\t" + stud[i].getpatronymic() + "\t" + stud[i].getbirthYear() + "\t" + stud[i].getadres() + "\t" + stud[i].getFnumber() + "\t" + stud[i].getfaculty() + "\t" + stud[i].getstyear());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            string n, l, p, adr, f;
            int y, st;
            Fac fc;
            n = Name.Text;
            l = LastN.Text;
            p = FaName.Text;
            adr = Adr.Text;
            f = PhoneN.Text;
            y = int.Parse(Year.Text);
            st = NewSt.SelectedIndex + 1;
            fc = (Fac)NewFac.SelectedIndex;
            stud[c] = new Student(l, n, p, y, adr, f, fc, st);
            Output.Items.Add(stud[c].getlastname() + "\t" + stud[c].getname() + "\t" + stud[c].getpatronymic() + "\t" + stud[c].getbirthYear() + "\t" + stud[c].getadres() + "\t" + stud[c].getFnumber() + "\t" + stud[c].getfaculty() + "\t" + stud[c].getstyear());
        }

        private void Facult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
