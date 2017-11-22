using ModelFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {
            //LoadDatabase();
            ListAllPeopleRegisteredForQAEDNF();
        }


        static void LoadDatabase() {
            // Load the data into the database
            using (CoursesContainer ctx = new CoursesContainer()) {
                Course course1 = new Course() { CourseCode = "QAEDNF", Description = ".NET Enterprise Development", DaysDuration = 5 };

                PublicRun run1 = new PublicRun() { Course = course1, StartDate = DateTime.Today, VMImage = "EDNF Image", RoomCapacity = 12 };

                course1.CourseRuns.Add(run1);

                Person fred = new Person() {
                    Name = new Name() { FirstName = "Fred", LastName = "Flintstone" },
                    Address = new Address() { Line1 = "1 Pall Mall", Town = "London", Postcode = "ER1" }
                };
                Person wilma = new Person() {
                    Name = new Name() { FirstName = "Wilma", LastName = "Flintstone" },
                    Address = new Address() { Line1 = "2 Pall Mall", Town = "London", Postcode = "ER1" }
                };
                Person barney = new Person() {
                    Name = new Name() { FirstName = "Barney", LastName = "Rubble" },
                    Address = new Address() { Line1 = "3 Pall Mall", Town = "London", Postcode = "ER1" }
                };

                run1.People.Add(fred);
                run1.People.Add(wilma);
                run1.People.Add(barney);

                ctx.Courses.Add(course1);
                ctx.SaveChanges();
            }
        }


        private static void ListAllPeopleRegisteredForQAEDNF() {
            // Read it out from ModelFirst
            using (CoursesContainer ctx = new CoursesContainer()) {

                var query = from cr in ctx.CourseRuns
                            where cr.Course.CourseCode == "QAEDNF"
                            select cr.People;

                foreach (var q in query)
                    foreach (var p in q)
                        Console.WriteLine(p.Name.FirstName + " " + p.Name.LastName);
            }
        }
    }
}
