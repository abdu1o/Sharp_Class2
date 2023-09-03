using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Class2
{
    internal class Program
    {
        class CoWorker
        {
            private string _fullname;
            private string _birth;
            private string _phone_num;
            private string _email;
            private string _post;
            private string _responsibilities;

            private double _wage;


            public CoWorker(string fullname, string birth, string phone_num, string email, string post, string responsibilities, int wage)
            {
                _fullname = fullname;
                _birth = birth;
                _phone_num = phone_num;
                _email = email;
                _post = post;
                _responsibilities = responsibilities;
                _wage = wage;
            }

            public void PrintInfo()
            {
                Console.WriteLine("\nFull name: " +  _fullname);
                Console.WriteLine("Birth: " + _birth);
                Console.WriteLine("Phone num: " + _phone_num);
                Console.WriteLine("Email: " + _email);
                Console.WriteLine("Post: " + _post);
                Console.WriteLine("Responsibilities: " + _responsibilities);
                Console.WriteLine("Wage: " + _wage);
            }

            public static CoWorker operator +(CoWorker worker, double add_wage)
            {
                worker._wage += add_wage;
                return worker;
            }

            public static CoWorker operator -(CoWorker worker, double add_wage)
            {
                worker._wage -= add_wage;
                return worker;
            }

            public static bool operator ==(CoWorker worker1, CoWorker worker2)
            {
                return worker1._wage == worker2._wage;
            }

            public static bool operator !=(CoWorker worker1, CoWorker worker2)
            {
                return worker1._wage != worker2._wage;
            }

            public static bool operator >(CoWorker worker1, CoWorker worker2)
            {
                return worker1._wage > worker2._wage;
            }

            public static bool operator <(CoWorker worker1, CoWorker worker2)
            {
                return worker1._wage < worker2._wage;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is CoWorker))
                {
                    return false;
                }

                CoWorker worker = (CoWorker)obj;
                return this._wage == worker._wage;
            }

            public override int GetHashCode()
            {
                return _wage.GetHashCode();
            }
        }

        static void Main(string[] args)
        {
            CoWorker worker1 = new CoWorker("qwe", "qwe", "qwe", "qwe", "qwe", "qwe", 15000);
            CoWorker worker2 = new CoWorker("qwe", "qwe", "qwe", "qwe", "qwe", "qwe", 20000);

            Console.WriteLine("Is wage 1 = wage 2 \n" + ((worker1 == worker2)));
            Console.WriteLine("Is wage 1 < wage 2 \n" + ((worker1 < worker2)));

            worker1 += 5000;
            Console.WriteLine("Is wage 1 = wage 2 \n" + ((worker1 == worker2)));

            worker1.PrintInfo();
        }
    }
}
