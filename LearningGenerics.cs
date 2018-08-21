using System;
namespace Aug_21_18_1
{
    public class LearningGenerics<T> where T :Person
    {
        public T GetAgeCategory(T _person) 
        {
            if(_person.Age <6)
            {
                _person.AgeCategory = AgeGroup.child;
            }
            else if(_person.Age >7 && _person.Age <60)
            {
                _person.AgeCategory = AgeGroup.Adult;
            }
            else
            {
                _person.AgeCategory = AgeGroup.SeniorCitizen;
            }
          return _person;

        }
    }
}