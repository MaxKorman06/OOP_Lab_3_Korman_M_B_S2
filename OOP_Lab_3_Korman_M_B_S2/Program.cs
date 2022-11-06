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
            public bool this[Computer Laptop]
            {
                get
                {
                    if (this.typeComputer == Laptop)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            public void AddSpecifications(params Specifications[] arr)
            {
                listOfManufacturersOfParts = listOfManufacturersOfParts.Concat(arr).ToArray();
            }
            public override string ToString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + " Type Computer: " + getTypeComputer() + " Date Release: " + getDateRelease() + " Version Release: " + getVersionRelease() + "List Of Manufacturers Of Parts: " + getListOfManufacturersOfParts();
            }
            virtual public string ToShortString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + " Type Computer: " + getTypeComputer() + " Date Release: " + getDateRelease() + " Version Release: " + getVersionRelease();
            }
        }
        static void Main(string[] args)
        {
            string arrSize;
            int nrow, ncolum;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            Console.WriteLine("Для визначення розімуру масиву використовуйте запис двох цифо розподілених пробілом або комою(крапкою)");
            arrSize = Console.ReadLine();
            string[] decoupleddArrSize = arrSize.Split(delimiterChars);
            
            nrow = Convert.ToInt32(decoupleddArrSize[0]);
            ncolum = Convert.ToInt32(decoupleddArrSize[1]);

            int timeStart1, timeFinish1, timeStart2, timeFinis2, timeStart3, timeFinis3;

            timeStart1 = System.Environment.TickCount;

            Console.WriteLine(nrow + "\n" + ncolum);

            timeFinish1 = System.Environment.TickCount;

            Console.WriteLine(timeFinish1 - timeStart1);

            Specifications aasd = new Specifications();

            Console.WriteLine(aasd);
            /*int Year = 2000;
            System.DateTime a;
            a = new DateTime();
            a = a.AddYears(3000);
            Console.WriteLine(a);
            a = a.AddYears(-a.Year + 1);
            Console.WriteLine(a);
            a = a.AddYears(Year - 1);
            Console.WriteLine(a);
            Person person = new Person();
            person.setYearBirth(2000);
            Console.WriteLine(person);
            Console.WriteLine(person.ToShortString());*/
        }
    }
}
