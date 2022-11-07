using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3_Korman_M_B_S2
{
    class Program
    {
        public enum Computer
        {
            Laptop,
            PersonalComputer,
            Tablet
        }
        public class Person
        {
            private string name;
            private string surname;
            private System.DateTime dataBirth;
            public Person(string name, string surname, System.DateTime dataBirth)
            {
                this.dataBirth = dataBirth;
                this.name = name;
                this.surname = surname;
            }
            public Person()
            {
                this.dataBirth = new DateTime();
                this.name = "NONE";
                this.surname = "NONE";
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public void setSurname(string surname)
            {
                this.surname = surname;
            }
            public void setDataBirth(System.DateTime dataBirth)
            {
                this.dataBirth = dataBirth;
            }
            public string getName()
            {
                return name;
            }
            public string getSurname()
            {
                return surname;
            }
            public System.DateTime getDataBirth()
            {
                return dataBirth;
            }
            public void setYearBirth(int Year)
            {
                dataBirth = dataBirth.AddYears(-dataBirth.Year + 1);
                dataBirth = dataBirth.AddYears(Year - 1);
            }
            public int getYearBirth()
            {
                return dataBirth.Year;
            }
            public override string ToString()
            {
                return "Name: " + getName() + " Surname: " + getSurname() + "\n" + dataBirth;
            }
            virtual public string ToShortString()
            {
                return "Name: " + getName() + " Surname: " + getSurname();
            }

        }

        public class Specifications
        {
            public Person person;
            public string operatingSystem;
            public double screenSize;

            public Specifications(Person person, string operatingSystem, double screenSize)
            {
                this.person = person;
                this.operatingSystem = operatingSystem;
                this.screenSize = screenSize;
            }
            public Specifications()
            {
                person = new Person();
                operatingSystem = "Bandera OS";
                screenSize = 17;
            }
            public Person getPerson()
            {
                return person;
            }
            public string getOperationSystem()
            {
                return operatingSystem;
            }
            public double getScreenSize()
            {
                return screenSize;
            }
            public void setPerson(Person person)
            {
                this.person = person;
            }
            public void setOperationSystem(string operatingSystem)
            {
                this.operatingSystem = operatingSystem;
            }
            public void setScreenSize(double screenSize)
            {
                this.screenSize = screenSize;
            }
            public override string ToString()
            {
                return "\nPerson:\n" + getPerson() + "\n\nOperating System: " + getOperationSystem() + "\n\nScreen Size; " + getScreenSize();
            }
        }

        public class ExtendedSpecifications
        {
            private string descriptionOfTheTechnique;
            private Computer typeComputer;
            private DateTime dateRelease;
            private int versionRelease;
            private Specifications[] listOfManufacturersOfParts;

            public ExtendedSpecifications(string descriptionOfTheTechnique, Computer typeComputer, DateTime dateRelease, int versionRelease)
            {
                this.descriptionOfTheTechnique = descriptionOfTheTechnique;
                this.typeComputer = typeComputer;
                this.dateRelease = dateRelease;
                this.versionRelease = versionRelease;
            }
            public ExtendedSpecifications()
            {
                descriptionOfTheTechnique = "Файна нова";
                typeComputer = Computer.PersonalComputer;
                dateRelease = DateTime.MinValue;
                versionRelease = 1;
            }
            public string getDescriptionOfTheTechnique()
            {
                return descriptionOfTheTechnique;
            }
            public Computer getTypeComputer()
            {
                return typeComputer;
            }
            public DateTime getDateRelease()
            {
                return dateRelease;
            }
            public int getVersionRelease()
            {
                return versionRelease;
            }
            public Specifications[] getListOfManufacturersOfParts()
            {
                return listOfManufacturersOfParts;
            }
            public void setDescriptionOfTheTechnique(string descriptionOfTheTechnique)
            {
                this.descriptionOfTheTechnique = descriptionOfTheTechnique;
            }
            public void getTypeComputer(Computer typeComputer)
            {
                this.typeComputer = typeComputer;
            }
            public void getDateRelease(DateTime dateRelease)
            {
                this.dateRelease = dateRelease;
            }
            public void getVersionRelease(int versionRelease)
            {
                this.versionRelease = versionRelease;
            }
            public void getListOfManufacturersOfParts(Specifications[] listOfManufacturersOfParts)
            {
                this.listOfManufacturersOfParts = listOfManufacturersOfParts;
            }
            public bool indexator(Computer arr)
            {
                if (arr == typeComputer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void AddSpecifications(params Specifications[] arr)
            {
                listOfManufacturersOfParts = arr;
            }
            public override string ToString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + "\nType Computer: " + getTypeComputer() + "\nDate Release: " + getDateRelease() + "\nVersion Release: " + getVersionRelease() + "\nList Of Manufacturers Of Parts: " + getListOfManufacturersOfParts();
            }
            virtual public string ToShortString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + "\nType Computer: " + getTypeComputer() + "\nDate Release: " + getDateRelease() + "\nVersion Release: " + getVersionRelease();
            }
        }
        static void Main(string[] args)
        {
            // Підпункт 1
            ExtendedSpecifications a = new ExtendedSpecifications();
            Console.WriteLine("\n\nЗавдання 1\n\n" + a.ToShortString());

            // Підпункт 2
            Console.WriteLine("\n\nЗавдання 2\n\n" + "\nПеревірка на рівність: " + a.indexator(Computer.PersonalComputer));
            Console.WriteLine("\nПеревірка на рівність: " + a.indexator(Computer.Laptop));

            // Підпункт 3
            ExtendedSpecifications b = new ExtendedSpecifications("asd", Computer.Laptop, System.DateTime.Now, 1);
            Console.WriteLine("\n\nЗавдання 3\n\n" + "\n" + b);

            // Підпункт 4
            ExtendedSpecifications сClass = new ExtendedSpecifications();
            Specifications[] spec = new Specifications[1];
            spec[0] = new Specifications();
            сClass.AddSpecifications(spec[0]);
            Console.WriteLine("\n\nЗавдання 4\n\n" + "\n" + spec[0]);

            // Підпункт 5
            string arrSize;
            int nrow, ncolum;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            Console.WriteLine("\n\nЗавдання 5\n\n" + "Для визначення розімуру масиву використовуйте запис двох цифо розподілених пробілом або комою(крапкою)");
            arrSize = Console.ReadLine();
            string[] decoupleddArrSize = arrSize.Split(delimiterChars);
            
            nrow = Convert.ToInt32(decoupleddArrSize[0]);
            ncolum = Convert.ToInt32(decoupleddArrSize[1]);

            Specifications[] arr_v1 = new Specifications[ncolum * nrow];
            Specifications[,] arr_v2 = new Specifications[ncolum, nrow];
            Specifications[][] arr_v3 = new Specifications[ncolum][];
            for (int i = 0; i < ncolum; i++)
            {
                if (i == ncolum - 1)
                {
                    arr_v3[i] = new Specifications[(ncolum * nrow) - i];
                    break;
                }
                arr_v3[i] = new Specifications[1];
            }


            // Одновимірний масив
            Console.WriteLine("Час обчислення одновимірного маиву");
            int timeStart1 = Environment.TickCount & Int32.MaxValue;

            for (int i = 0; i < ncolum * nrow; i++)
            {
                arr_v1[i] = new Specifications();
            }
            
            int timeFinish1 = Environment.TickCount & Int32.MaxValue;
            Console.WriteLine(timeFinish1 - timeStart1 + "\n");
            // Одновимірний масив

            // Двовимірний масив
            Console.WriteLine("Час обчислення двовимірного маиву");
            int timeStart2 = Environment.TickCount & Int32.MaxValue;

            for (int i = 0; i < ncolum; i++)
            {
                for (int j = 0; j < nrow; j++)
                {
                    arr_v2[i, j] = new Specifications();
                }
            }

            int timeFinish2 = Environment.TickCount & Int32.MaxValue;

            Console.WriteLine(timeFinish2 - timeStart2 + "\n");
            // Двовимірний масив

            // Ступінчастий масив
            Console.WriteLine("Час обчислення ступінчастого маиву");
            int timeStart3 = Environment.TickCount & Int32.MaxValue;

            for (int i = 0; i < ncolum; i++)
            {
                if (i == ncolum - 1)
                {
                    for (int j = 0; j < (ncolum * nrow) - i; j++)
                    {
                        arr_v3[i][j] = new Specifications();
                    }
                    break;
                }
                arr_v3[i][0] = new Specifications();

            }
            int timeFinish3 = Environment.TickCount & Int32.MaxValue;

            Console.WriteLine(timeFinish3 - timeStart3 + "\n");
            // Ступінчастий масив

            /*int Year = 2000;
            System.DateTime d;
            d = new DateTime();
            d = d.AddYears(3000);
            Console.WriteLine(d);
            d = d.AddYears(-d.Year + 1);
            Console.WriteLine(d);
            d = d.AddYears(Year - 1);
            Console.WriteLine(d);
            Person person = new Person();
            person.setYearBirth(2000);
            Console.WriteLine(person);
            Console.WriteLine(person.ToShortString());*/
        }
    }
}
