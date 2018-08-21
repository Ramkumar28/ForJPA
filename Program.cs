using System;

namespace Aug_21_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Dad = new Person(){Name = "Ramkumar",Age =30 };
            Person Daughter = new Person(){Name = "Neha",Age=1};
            LearningGenerics<Person> _firstInstance = new LearningGenerics<Person>();
         _firstInstance.GetAgeCategory(Dad);
         _firstInstance.GetAgeCategory(Daughter);
    }
  }
}
